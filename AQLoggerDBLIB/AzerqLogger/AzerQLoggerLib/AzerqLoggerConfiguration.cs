using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerQLoggerLib
{
    /// <summary>
    /// Класс конфигурации логгера
    /// </summary>
   public class AzerqLoggerConfiguration
    {
        /// <summary>
        /// Новая конфигурация логгера
        /// </summary>
        /// <param name="dBcreditionals">Авторизация базы данных</param>
        /// <param name="tableName">Имя таблицы, в которую будет записан лог</param>
        /// <param name="level">Максимальный уровень текущего логирования</param>
        public AzerqLoggerConfiguration(ServerCreditionals dBcreditionals, string tableName, LogLevel level)
        {
            DBcreditionals = dBcreditionals;
            TableName = tableName;
            Level = level;
        }

        public AzerqLoggerConfiguration() { }

        public AzerqLoggerConfiguration(ServerCreditionals dBcreditionals, string tableName, LogLevel level, string applicationName, string channelName) : this(dBcreditionals, tableName, level)
        {
            ApplicationName = applicationName;
            ChannelName = channelName;
        }

        /// <summary>
        /// Авторизация на сервере базы данных
        /// </summary>
        public ServerCreditionals DBcreditionals { get; set; }

        /// <summary>
        /// Имя таблицы для записи лога
        /// </summary>
       public string TableName { get;set; } 

       /// <summary>
       /// Уровень логирования (Уровень с большим численным значением включает предыдущие)
       /// </summary>
       public LogLevel Level { get; set; }

        /// <summary>
        /// Имя приложение, которое будет совершать логгирование
        /// </summary>
       public string ApplicationName { get; set; }

        /// <summary>
        /// Имя какнала, в который будут записываться сообщение
        /// </summary>
       public string ChannelName { get; set; }


    }

    /// <summary>
    /// Уровень логирования
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Ошибка
        /// </summary>
        Error,
        /// <summary>
        /// Предупреждение
        /// </summary>
        Warning,
        /// <summary>
        /// Информация
        /// </summary>
        Information,
        /// <summary>
        /// Отладка
        /// </summary>
        Trace,
        /// <summary>
        /// Включать все
        /// </summary>
        All      
    }
}
