using System;
using System.Collections.Generic;
using AqORM.DB.Filters;

namespace AqORM.DB.SqlHelpers
{
    /// <summary>
    /// Интерфейс для генерации SQL запросов и операций с базой данных.
    /// </summary>
    public interface ISqlTextHelper
    {
        /// <summary>
        /// Генерирует SQL запрос для проверки существования таблицы в базе данных.
        /// </summary>
        /// <param name="fullTableName">Полное имя таблицы (со схемой)</param>
        /// <returns>SQL запрос для проверки существования таблицы</returns>
        /// <remarks>В запросе должна быть булевая переменная TableExists, в которую заносится значение</remarks>
        string GenerateTableExistenceCheckSql(string fullTableName);


        /// <summary>
        /// Возвращает имя типа данных в базе данных, соответствующее типу поля модели.
        /// </summary>
        /// <param name="propertyType">Тип поля данных C#</param>
        /// <returns>Имя типа данных в конкретной базе данных</returns>
        string GetDbMapTypeName(Type propertyType);

        /// <summary>
        /// Генерирует SQL запрос для выборки уникальных значений из указанной таблицы.
        /// </summary>
        /// <param name="fieldName">Имя поля</param>
        /// <param name="tableName">Имя таблицы</param>
        /// <returns>SQL запрос для выборки уникальных значений</returns>
        string GenerateDistinctValueSelect(string fieldName, string tableName);

        /// <summary>
        /// Генерирует SQL запрос для вставки данных в таблицу.
        /// </summary>
        /// <param name="modelType">Тип модели данных</param>
        /// <param name="tableName">Имя таблицы</param>
        /// <returns>SQL запрос для вставки данных</returns>
        string GenerateInsertSql(Type modelType, string tableName);

        /// <summary>
        /// Генерирует SQL запрос для обновления данных в таблице по заданным параметрам.
        /// </summary>
        /// <param name="modelType">Тип модели данных</param>
        /// <param name="tableName">Имя таблицы</param>
        /// <param name="idName">Имя первичного ключа</param>
        /// <returns>SQL запрос для обновления данных</returns>
        string GenerateUpdateSql(Type modelType, string tableName, string idName);

        /// <summary>
        /// Генерирует SQL запрос для удаления строки по ключу.
        /// </summary>
        /// <param name="idColumnName">Имя столбца ключа</param>
        /// <param name="tableName">Имя таблицы</param>
        /// <returns>SQL запрос для удаления строки</returns>
        string GenerateDeleteByKeySql(string idColumnName, string tableName);

        /// <summary>
        /// Генерирует SQL запрос для удаления строк по условию.
        /// </summary>
        /// <param name="tableName">Имя таблицы</param>
        /// <param name="fieldFilters">Список фильтров полей</param>
        /// <returns>SQL запрос для удаления строк</returns>
        string GenerateDeleteByConditionSql(string tableName, IEnumerable<StandardFilter<object>> fieldFilters);

        /// <summary>
        /// Генерирует условие для выборки данных из таблицы по фильтру.
        /// </summary>
        /// <param name="fieldFilters">Список фильтров полей</param>
        /// <returns>SQL условие для выборки данных</returns>
        string GenerateDbWhereFilter(IEnumerable<StandardFilter<object>> fieldFilters);

        /// <summary>
        /// Генерирует SQL запрос для подсчета записей в таблице.
        /// </summary>
        /// <param name="tableName">Имя таблицы</param>
        /// <returns>SQL запрос для подсчета записей</returns>
        string GenerateCountSql(string tableName);

        /// <summary>
        /// Генерирует SQL запрос для выборки значений из таблицы.
        /// </summary>
        /// <param name="modelType">Тип модели данных</param>
        /// <param name="tableName">Имя таблицы</param>
        /// <param name="excludeModelFields">Исключаемые из выборки поля модели</param>
        /// <param name="fieldFilters">Фильтры полей</param>
        /// <returns>SQL запрос для выборки значений</returns>
        string GenerateDbSelect(Type modelType, string tableName, List<string> excludeModelFields, IEnumerable<StandardFilter<object>> fieldFilters);

        /// <summary>
        /// Помощник при спопоставлении БД и класса
        /// </summary>
        DbEntityHelper EntityHelper { get; set; }
    }
}
