using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerQLoggerLib.DBService.TypeMapper
{
    /// <summary>
    /// Интерфейс маппинга типов данных SQL
    /// </summary>
    public interface ISqlTypeMapper
    {
        /// <summary>
        /// Добавить сопоставление типа c# с SQL типом
        /// </summary>
        /// <param name="type">Тип c#</param>
        /// <param name="sqlType">SQL тип</param>
        void AddMapping(Type type, string sqlType);

        /// <summary>
        /// Получить SQL тип из типа c#
        /// </summary>
        /// <param name="type">Тип c#</param>
        /// <returns>Строка типа SQL</returns>
        string MapSqlType(Type type);

        /// <summary>
        /// Сопоставить тип c# с типом SQL
        /// </summary>
        /// <param name="sqlServerType">Тип SQL</param>
        /// <returns>Тип c#</returns>
        Type MapClrType(string sqlServerType);

        /// <summary>
        /// Словарь сопоставления типов c# и SQL
        /// </summary>
        Dictionary<Type, string> SqlTypeMappings { get; }
    }
}
