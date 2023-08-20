using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerQLoggerLib.DBService.Configuratinon
{
    /// <summary>
    /// Класс конфигурации логгера для MSSQL
    /// </summary>
    public class MssqlLogDbConfiguration : LogDbConfigurationBase
    {
        /// <summary>
        /// Создает новую конфигурацию логгера для MSSQL.
        /// </summary>
        /// <param name="connectionString">Строка подключения к базе данных</param>
        /// <param name="dbTypeString">Тип базы данных</param>
        /// <param name="tableName">Имя таблицы, в которую будет записан лог</param>
        /// <param name="level">Максимальный уровень текущего логирования</param>
        /// <param name="applicationName">Имя приложения, делающего лог-запись</param>
        /// <param name="channelName">Имя канала лога</param>
        public MssqlLogDbConfiguration(string connectionString, string tableName, LogLevel level
            , string dbTypeString = DbProvidersNames.MSSQLServer,
            string applicationName = "", string channelName = "")
            : base(connectionString, tableName, level, dbTypeString, applicationName, channelName)
        {
        }
    }
}