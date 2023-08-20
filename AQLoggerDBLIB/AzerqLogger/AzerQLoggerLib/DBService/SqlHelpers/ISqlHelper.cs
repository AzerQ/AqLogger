using AzerQLoggerLib.DBService.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerQLoggerLib.DBService.SqlHelpers
{
    /// <summary>
    /// Вспомогательный интерфейс для SQL
    /// </summary>
    public interface ISqlHelper
    {
        /// <summary>
        /// Создание SQL запроса проверки существования таблицы в базе
        /// </summary>
        /// <param name="fullTableName">Полное имя таблицы (со схемой)</param>
        /// <returns>SQL запрос проверки существования таблицы в базе данных</returns>
        /// <remarks>В запросе должна быть булевая переменная TableExists, в которую заноситься значение</remarks>
        public string GenerateTableExistenceCheckSql(string fullTableName);

        /// <summary>
        /// Создание таблицы по структуре объекта C#
        /// </summary>
        /// <param name="model">Оюъект c#</param>
        /// <param name="tableName">Имя создаваемой таблицы</param>
        /// <returns>SQL запрос создания таблицы с идентичной структурой</returns>
        public string GenerateTableCreateSql(object model, string tableName);

        /// <summary>
        /// Получить имя типа данных в базе данных (по типу поля)
        /// </summary>
        /// <param name="propertyType">Тип поля данных c#</param>
        /// <returns>Строка с именем типа в конкретной базе данных</returns>
        public string GetDbMapTypeName(Type propertyType);

        /// <summary>
        /// Генерация SQL запроса на выборку уникального значения
        /// </summary>
        /// <param name="fieldName">Имя поля</param>
        /// <param name="tableName">Имя тблицы</param>
        /// <returns>Текст SQL запроса для Dapper</returns>
        string GenerateDistinctValueSelect(string fieldName, string tableName);

        /// <summary>
        /// Создать SQL запрос на вставку
        /// </summary>
        /// <param name="model">Объект для вставки</param>
        /// <param name="tableName">Имя таблицы БД</param>
        /// <returns>Текст SQL запроса для Dapper</returns>
        string GenerateInsertSql(object model, string tableName);

        /// <summary>
        /// Создать SQL запрос на обновление
        /// </summary>
        /// <param name="model">Обновляемый объект</param>
        /// <param name="tableName">Имя таблицы</param>
        /// <param name="idName">Имя первичного ключа</param>
        /// <returns>Текст SQL запроса для Dapper</returns>
        string GenerateUpdateSql(object model, string tableName, string idName);

        /// <summary>
        /// Сгенерировать запрос на удаление
        /// </summary>
        /// <param name="idColumnName">Имя столбца ключа</param>
        /// <param name="tableName">Имя таблицы</param>
        /// <returns>Текст SQL запроса для Dapper</returns>
        string GenerateDeleteSql(string idColumnName, string tableName);

        /// <summary>
        /// Создать условие для выбора данных из таблицы по фильтру
        /// </summary>
        /// <param name="fieldFilters">Список фильтров полей</param>
        /// <returns>Текст SQL запроса для Dapper</returns>
        string GenerateDbWhereFilter(IEnumerable<StandardFilter<object>> fieldFilters);

        /// <summary>
        /// Создать выражение для подсчета записей в таблице
        /// </summary>
        /// <param name="tableName">Имя таблицы</param>
        /// <returns>Число записей в таблице</returns>
        string GenerateCountSql(string tableName);

        /// <summary>
        /// SQL запрос на выборку значениий
        /// </summary>
        /// <param name="model">Модель данных c#</param>
        /// <param name="excludeModelFields">Исключаемые из выборки поля модели</param>
        /// <param name="fieldFilters">Фильтры полей</param>
        /// <returns>Текст SQL запроса для оператора выбора значений</returns>
        string GenerateDbSelect(object model, List<string> excludeModelFields = null,IEnumerable<StandardFilter<object>> fieldFilters = null);
    }
}
