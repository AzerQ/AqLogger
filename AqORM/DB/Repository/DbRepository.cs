using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using AqORM.DB.SchemaGenerator;
using AqORM.DB.SqlHelpers;
using AqORM.DB.TypeMapper;

namespace AqORM.DB.Repository
{
     class DbRepository<TModel>
    {
        /// <summary>
        /// Генерация данных по схеме
        /// </summary>
        private ISchemaGenerator _schemaGenerator;

        /// <summary>
        /// Генерация текста Sql запросов
        /// </summary>
        private ISqlTextHelper _sqlTextHelper;

        /// <summary>
        /// Сопоставление данных Sql и c#
        /// </summary>
        private ISqlTypeMapper _sqlTypeMapper;

        public IEnumerable<T> ExecuteSqlQuery<T>(SqlCommand command) where T : new()
        {
            List<T> result = new List<T>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                command.Connection = connection;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DbEntityHelper entityHelper = new DbEntityHelper(typeof(T), new SqlTypeMapper()); // Здесь передайте нужный вам ISqlTypeMapper
                    Dictionary<string, PropertyInfo> propertyMappings = MapPropertiesToColumns<T>(entityHelper);

                    while (reader.Read())
                    {
                        T item = MapDataReaderToObject<T>(reader, propertyMappings);
                        result.Add(item);
                    }
                }
            }

            return result;
        }

        private Dictionary<string, PropertyInfo> MapPropertiesToColumns<T>(DbEntityHelper entityHelper)
        {
            Dictionary<string, PropertyInfo> propertyMappings = new Dictionary<string, PropertyInfo>();

            foreach (var mapItem in entityHelper.MappingList)
            {
                PropertyInfo property = typeof(T).GetProperty(mapItem.PropertyName);
                propertyMappings[mapItem.DbColumn] = property;
            }

            return propertyMappings;
        }

        private T MapDataReaderToObject<T>(SqlDataReader reader, Dictionary<string, PropertyInfo> propertyMappings) where T : new()
        {
            T item = new T();

            foreach (var kvp in propertyMappings)
            {
                string columnName = kvp.Key;
                PropertyInfo property = kvp.Value;

                if (property != null && !reader.IsDBNull(reader.GetOrdinal(columnName)))
                {
                    object value = reader.GetValue(reader.GetOrdinal(columnName));
                    property.SetValue(item, value);
                }
            }

            return item;
        }


        public DbRepository(ISchemaGenerator schemaGenerator, ISqlTextHelper sqlTextHelper, ISqlTypeMapper sqlTypeMapper, string connec)
        {
            _schemaGenerator = schemaGenerator;
            _sqlTextHelper = sqlTextHelper;
            _sqlTypeMapper = sqlTypeMapper;
        }
    }
}
