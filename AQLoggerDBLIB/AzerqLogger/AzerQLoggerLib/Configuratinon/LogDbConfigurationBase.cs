using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerQLoggerLib.DBService.Configuratinon
{
    /// <summary>
    /// Базовый класс конфигурации логгера
    /// </summary>
    public abstract class LogDbConfigurationBase
    {
        /// <summary>
        /// Создает новую конфигурацию логгера.
        /// </summary>
        /// <param name="connectionString">Авторизация базы данных</param>
        /// <param name="tableName">Имя таблицы, в которую будет записан лог</param>
        /// <param name="level">Максимальный уровень текущего логирования</param>
        /// <param name="dbTypeString">Тип ббазы данных</param>
        /// <param name="applicationName">Имя приложения, делающего лог-запись</param>
        /// <param name="channelName">Имя канала лога</param>
        protected LogDbConfigurationBase(string connectionString, string tableName, LogLevel level,
            string dbTypeString,
            string applicationName = "", string channelName = "")
        {
            ConnectionString = connectionString;
            TableName = tableName ?? throw new ArgumentNullException(nameof(tableName));
            Level = level;
            ApplicationName = applicationName;
            ChannelName = channelName;
            DbTypeString = dbTypeString;
        }

        /// <summary>
        /// Строка  подключения к источнику данных
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Имя таблицы для записи лога (желательно с именем базы и схемой).
        /// </summary>
        public string TableName { get; }

        /// <summary>
        /// Уровень логирования (Уровень с большим численным значением включает предыдущие).
        /// </summary>
        public LogLevel Level { get; }

        /// <summary>
        /// Имя приложения, которое будет совершать логгирование.
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Имя канала, в который будут записываться сообщения.
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// Тип базы данных для подключения
        /// </summary>
        public string DbTypeString { get; set; }
    }
}
