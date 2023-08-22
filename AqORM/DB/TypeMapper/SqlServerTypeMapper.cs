using System;
using System.Collections.Generic;

namespace AqORM.DB.TypeMapper
{
    /// <summary>
    /// Маппинг типов данных SQL
    /// </summary>
    public class SqlServerTypeMapper : ISqlTypeMapper
    { 
        /// <summary>
        /// Словарь сопоставления типов c# и sql
        /// </summary>
        private readonly Dictionary<Type, string> _sqlTypeMappings = new Dictionary<Type, string>
        {
            { typeof(int), "INT" },
            { typeof(long), "BIGINT" },
            { typeof(short), "SMALLINT" },
            { typeof(byte), "TINYINT" },
            { typeof(float), "FLOAT" },
            { typeof(double), "FLOAT" }, // or "REAL" for single precision
            { typeof(decimal), "DECIMAL(18, 2)" }, // Adjust precision and scale as needed
            { typeof(bool), "BIT" },
            { typeof(string), "NVARCHAR(MAX)" },
            { typeof(DateTime), "DATETIME" }, // or "DATETIME" if needed
        };

        /// <summary>
        /// Добавть сопоставление
        /// </summary>
        /// <param name="type">Тип c#</param>
        /// <param name="sqlType">SQL тип</param>

        public  void AddMapping(Type type, string sqlType)
        {
            if (!SqlTypeMappings.ContainsKey(type))
            {
                SqlTypeMappings[type] = sqlType;
            }
        }

        /// <summary>
        /// Получить SQL тип из типа c#
        /// </summary>
        /// <param name="type">Тип c#</param>
        /// <returns>Строка типа SQL Server</returns>
        public string MapSqlType(Type type)
        {
            if (SqlTypeMappings.ContainsKey(type))
            {
                return SqlTypeMappings[type];
            }

            if (type.IsEnum)
            {
                return "INT"; // Store enums as integers
            }

            if (type.IsClass || type.IsValueType && !type.IsPrimitive)
            {
                // Serialize complex types to JSON and store as string
                return "NVARCHAR(MAX)";
            }

            return string.Empty;
        }

        /// <summary>
        /// Сопоставление типа c# с типом SQL Server
        /// </summary>
        /// <param name="sqlServerType">Тип SQL Server</param>
        /// <returns>Тип c#</returns>
        public Type MapClrType(string sqlServerType)
        {

            foreach (var element in SqlTypeMappings)
            {
                if (element.Value.Equals(sqlServerType, StringComparison.CurrentCultureIgnoreCase))
                {
                    return element.Key;
                }
            }
            return typeof(object);
        }


        public Dictionary<Type, string> SqlTypeMappings => _sqlTypeMappings;
    }
}