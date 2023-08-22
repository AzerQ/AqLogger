using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using AqORM.DB.Filters;

namespace AqORM.DB.SqlHelpers
{
    public class MssqlServerHelper : ISqlTextHelper
    {
        public DbEntityHelper EntityHelper { get; set; } = null;

        public string GenerateTableExistenceCheckSql(string fullTableName)
        {
            string sql = $@"
        @TableExists bit
        IF OBJECT_ID('{fullTableName}', 'U') IS NOT NULL
            SELECT @TableExists = 1
        ELSE
            SELECT @TableExists = 0";

            return sql;
        }



        public string GetDbMapTypeName(Type propertyType)
        {
            // Check for nullable types
            if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                propertyType = propertyType.GetGenericArguments()[0];
            }


            if (propertyType == typeof(int))
            {
                return "INT";
            }
            else if (propertyType == typeof(long))
            {
                return "BIGINT";
            }
            else if (propertyType == typeof(short))
            {
                return "SMALLINT";
            }
            else if (propertyType == typeof(byte))
            {
                return "TINYINT";
            }
            else if (propertyType == typeof(float))
            {
                return "FLOAT";
            }
            else if (propertyType == typeof(double))
            {
                return "FLOAT"; // or "REAL" for single precision
            }
            else if (propertyType == typeof(decimal))
            {
                return "DECIMAL(18, 2)"; // Adjust precision and scale as needed
            }
            else if (propertyType == typeof(bool))
            {
                return "BIT";
            }
            else if (propertyType == typeof(string))
            {
                return "NVARCHAR(MAX)";
            }
            else if (propertyType == typeof(DateTime))
            {
                return "DATETIME2"; // or "DATETIME" if needed
            }
            else if (propertyType.IsEnum)
            {
                return "INT"; // Store enums as integers
            }
            else if (propertyType.IsClass || (propertyType.IsValueType && !propertyType.IsPrimitive))
            {
                // Serialize complex types to JSON and store as string
                return "NVARCHAR(MAX)";
            }

            return string.Empty;

        }

        public string GenerateDistinctValueSelect(string fieldName, string tableName) => $"SELECT DISTINCT {fieldName} FROM {tableName}";

        /// <summary>
        /// Генерация списка колонок таблицы
        /// </summary>
        /// <param name="modelType">Тип данных модели</param>
        /// <param name="columnStatement">Тип генерации</param>
        /// <param name="excludeList">Список исключений из полей класса</param>
        /// <returns>Строка с перечислением колонок таблицы</returns>
        private string generateDbColumnsListStatement(Type modelType, ColumnStatementType columnStatement,
            List<string> excludeList = null)
        {
            var properties = modelType.GetProperties()
                .Where(prop => prop.GetCustomAttribute<NotMappedAttribute>() == null
                && (excludeList != null && !excludeList.Contains(prop.Name)) ); // Исключаем непривязанные поля, а также поля в списке исключений
            var propertyInfos = properties.ToList().Select(prop =>
            {
                var propertyName = prop.Name; // Если имя колонки задано, то использовать его
                var dbColumnName = prop.GetCustomAttribute<ColumnAttribute>()?.Name ?? propertyName;
                return new { dbColumnName, propertyName};
            });
            var resultBuilder = new StringBuilder();
            foreach (var info in propertyInfos)
            {
                switch (columnStatement)
                {
                    case ColumnStatementType.NamesList:
                        resultBuilder.Append(info.dbColumnName + ",");
                        break;
                    case ColumnStatementType.AsSqlParametr:
                        resultBuilder.Append("@" + info.propertyName + ",");
                        break;
                    case ColumnStatementType.AsSqlUpdate:
                        resultBuilder.Append($"{info.dbColumnName} = @{info.propertyName},");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(columnStatement), columnStatement, null);
                } 
            }

            return resultBuilder.ToString().TrimEnd(','); //Уьираем последнюю запятую
        }

        /// <summary>
        /// Тип генерации записи для колонки
        /// </summary>
        public enum ColumnStatementType
        {
            /// <summary>
            /// Список имен колонок через ,
            /// </summary>
            NamesList,

            /// <summary>
            /// Список колонок с префиксом @ColumName (Имя свойства класса) через ,
            /// </summary>
            AsSqlParametr,

            /// <summary>
            /// Как Sql UPDATE в формате имя SqlColumnName = @ClassPropertyNamw
            /// </summary>
            AsSqlUpdate
        }

        public string GenerateInsertSql(Type modelType, string tableName)
        {
            var insertTemplate = "INSERT INTO {0} ({1}) VALUES({2})";
            
            return string.Format(insertTemplate, 
                tableName, generateDbColumnsListStatement(modelType, ColumnStatementType.NamesList),
                generateDbColumnsListStatement(modelType, ColumnStatementType.AsSqlParametr));
        }

        public string GenerateUpdateSql(Type modelType, string tableName, string idName)
        {
            var insertTemplate = "UPDATE {0} SET {1} WHERE {2} = @{2}";

            return String.Format(insertTemplate, tableName, generateDbColumnsListStatement(modelType, ColumnStatementType.AsSqlUpdate), idName);
        }
        // TODO Реализовать прием фильтров для комплексного удаления записей
        public string GenerateDeleteByKeySql(string idColumnName, string tableName) => $"DELETE {tableName} WHERE {idColumnName} = @{idColumnName}";

        public string GenerateDeleteByConditionSql(string tableName, IEnumerable<StandardFilter<object>> fieldFilters)
        {
            if (fieldFilters == null) throw new ArgumentNullException(nameof(fieldFilters),"Поля фильтра fieldFilters NULL!");
            if (!fieldFilters.Any())
                throw new ArgumentException(nameof(fieldFilters), "Пустой массив полей фильтров!");
            return $"DELETE FROM {tableName} {GenerateDbWhereFilter(fieldFilters)}";
        }


        public string GenerateDbWhereFilter(IEnumerable<StandardFilter<object>> fieldFilters)
        {
            if (fieldFilters == null || !fieldFilters.Any())
            {
                return string.Empty;
            }

            StringBuilder whereClause = new StringBuilder("WHERE ");
            List<string> filterExpressions = new List<string>();

            foreach (var filter in fieldFilters)
            {
                string expression = GenerateFilterExpression(filter);
                if (!string.IsNullOrEmpty(expression))
                {
                    filterExpressions.Add(expression);
                }
            }

            whereClause.Append(string.Join(" AND ", filterExpressions));

            return whereClause.ToString();
        }

        public string GenerateCountSql(string tableName)
        {
            return $"SELECT COUNT(*) FROM {tableName}";
        }

        public string GenerateDbSelect(Type modelType, string tableName, List<string> excludeModelFields,
            IEnumerable<StandardFilter<object>> fieldFilters)
        {
            var columnsList = generateDbColumnsListStatement(modelType, ColumnStatementType.NamesList, excludeModelFields);
            return $"SELECT {columnsList} FROM {tableName} {GenerateDbWhereFilter(fieldFilters)}";
        }


        /// <summary>
        /// Генерация значения фильтра для одного поля
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>SQL строку условия WHERE</returns>
        private string GenerateFilterExpression(StandardFilter<object> filter)
        {
            //Проверка того, что у нас в типе фильтра строка
            if (filter.Value is string stringValue)
            {
                string operatorSymbol = GetOperatorSymbol(filter.Operator);

                switch (filter.Operator)
                {
                    case FilterOperator.In:
                        return $"{filter.FieldName} {operatorSymbol} ({string.Join(", ", filter.InValues)})";
                    case FilterOperator.Contains:
                    case FilterOperator.NotContains:
                        //LIKE, NOT LIKE
                        return $"{filter.FieldName} {operatorSymbol} '%{stringValue}%'";
                    default:
                        //Обычная проверка строки 
                        return $"{filter.FieldName} {operatorSymbol} '{stringValue}'";
                }
            }
            if ( (filter.Operator == FilterOperator.In) && ( (filter.InValues?.Count() ?? 0) > 0) ) //Проверка на оператор IN и существовании множества элементов
            {
                return $"{filter.FieldName} IN ({string.Join(", ", filter.InValues)})";
            }

            // Стандартная генерация части  общего условия (кроме оператора IN)
            if (filter.Value != null)
            {
                string operatorSymbol = GetOperatorSymbol(filter.Operator);
                return $"{filter.FieldName} {operatorSymbol} {filter.Value}";
            }

            return string.Empty;
        }
        /// <summary>
        /// Получить Sql оператор
        /// </summary>
        /// <param name="operator">Логический оператор</param>
        /// <returns>T-SQL оператор</returns>
        private string GetOperatorSymbol(FilterOperator @operator)
        {
            switch (@operator)
            {
                case FilterOperator.Equal: return "=";
                case FilterOperator.NotEqual: return "<>";
                case FilterOperator.GreaterThan: return ">";
                case FilterOperator.GreaterThanOrEqual: return ">=";
                case FilterOperator.LessThan: return "<";
                case FilterOperator.LessThanOrEqual: return "<=";
                case FilterOperator.Contains: return "LIKE";
                case FilterOperator.NotContains: return "NOT LIKE";
                case FilterOperator.In: return "IN";
                default: return string.Empty;
            }
        }

    }
}
