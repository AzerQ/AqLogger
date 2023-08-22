using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using AqORM.DB.TypeMapper;

namespace AqORM.DB.SchemaGenerator
{
    public class MssqlSchemaGenerator : ISchemaGenerator
    {
        public ISqlTypeMapper Mapper { get; set; } = new SqlServerTypeMapper();

        private string _connectionString;

        public MssqlSchemaGenerator(string connectionString)
        {
            _connectionString = connectionString;

        }

        public string GenerateCreateTableSql(Type modelType, string tableName)
        {
            if (modelType == null)
            {
                throw new ArgumentNullException(nameof(modelType));
            }

            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentException("Table name cannot be null or empty.", nameof(tableName));
            }


            StringBuilder sqlBuilder = new StringBuilder();

            var checkTableStatement = $@"@TableExists bit
        IF OBJECT_ID('{tableName}', 'U') IS NOT NULL
            SELECT @TableExists = 1
        ELSE
            SELECT @TableExists = 0";

            sqlBuilder.AppendLine($@"{checkTableStatement} --проверка существоваания таблицы на сервере БД
                                IF NOT @TableExists
                                BEGIN
                                CREATE TABLE {tableName} (");

            PropertyInfo[] properties = modelType.GetProperties();
            foreach (PropertyInfo property in
                     properties.Where(prop =>
                         prop.GetCustomAttribute<NotMappedAttribute>() == null)) // Пропускаем не связанные поля класса
            {
                string columnName = property.GetCustomAttribute<ColumnAttribute>()?.Name ?? property.Name;
                string columnType = Mapper.MapSqlType(property.PropertyType);
                sqlBuilder.AppendLine($"{columnName} {columnType},");
            }

            sqlBuilder.Length--; // Remove the last comma
            sqlBuilder.AppendLine($"); {Environment.NewLine} END");

            return sqlBuilder.ToString();
        }

        public string GenerateClrClass(string tableName, string className)
        {
            {
                if (string.IsNullOrEmpty(tableName))
                {
                    throw new ArgumentException("Table name cannot be null or empty.", nameof(tableName));
                }

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = $"SELECT TOP 1 * FROM {tableName}";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.SchemaOnly))
                    {
                        DataTable schemaTable = reader.GetSchemaTable();

                        if (schemaTable == null)
                        {
                            throw new InvalidOperationException($"Table '{tableName}' not found.");
                        }

                        StringBuilder classBuilder = new StringBuilder();
                        classBuilder.AppendLine($"public class {tableName}");
                        classBuilder.AppendLine("{");

                        foreach (DataRow row in schemaTable.Rows)
                        {
                            string columnName = row["ColumnName"].ToString();
                            string dataType = row["DataType"].ToString();
                            Type clrType = Type.GetType(dataType);
                            string propertyType = clrType != null ? clrType.Name : "object";
                            classBuilder.AppendLine($"    public {propertyType} {columnName} {{ get; set; }}");
                        }

                        classBuilder.AppendLine("}");

                        return classBuilder.ToString();
                    }
                }
            }
        }
    }
}
