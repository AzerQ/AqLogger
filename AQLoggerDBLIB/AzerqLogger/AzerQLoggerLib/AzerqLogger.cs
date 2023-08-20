using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzerQLoggerLib.DBService;

namespace AzerQLoggerLib
{
    /// <summary>
    /// Эвент при создании лога
    /// </summary>
    /// <param name="level">Уровень логгирования</param>
    /// <param name="message">сообщение</param>
    /// <param name="header">заголовок</param>
    /// <param name="tag">метка</param>
    public delegate void LogWriteDelegate(LogLevel level, string message, string header, string tag);

    /// <summary>
    /// Логирование в таблицу базы данных
    /// </summary>
    public class AzerqLogger : ILogger
    {
        /// <summary>
        /// Событие при записи лога в базу данных
        /// </summary>
        public LogWriteDelegate OnLogWrite;

        /// <summary>
        /// Сервис логгирования в базу данных
        /// </summary>
        public LogServiceBase LogServiceBase { get; set; }

        /// <summary>
        /// Конфигурация логгирования
        /// </summary>
        public AzerqLoggerConfiguration Configuration { get => LogServiceBase.Configuration; }
        public AzerqLogger(AzerqLoggerConfiguration configuration, LogWriteDelegate onLogWrite = null)
        {
            LogServiceBase = new LogServiceBase(configuration);

            if (onLogWrite != null)
            {
                OnLogWrite = onLogWrite;
            }
            else
            {
                OnLogWrite = (level, message, header, tag) => { };
            }
        }

        /// <summary>
        /// Универсальный обработчик
        /// </summary>
        /// <param name="level">Уровень логгирования</param>
        /// <param name="message">сообщение</param>
        /// <param name="header">заголовок</param>
        /// <param name="tag">метка</param>
        private void LogUniversal(LogLevel level, string message, string header, string tag)
        {
            if (Configuration.Level >= level) //Проверка на уровень лога
            {
                LogServiceBase.CreateItem(
                    new AzerqLogItem()
                    {
                        ApplicationName = Configuration.ApplicationName,
                        ChannelName = Configuration.ChannelName,
                        Type = level.ToString(),
                        Content = message,
                        Header = header,
                        Tag = tag,
                        Author = "AZERQ LOGGER",
                        CreateDate = DateTime.Now,
                        ContentType = "TEXT"
                    });
            }
        }


        public void LogError(string message, string header, string tag = "default")
        {
            LogUniversal(LogLevel.Error, message, header, tag);
        }

        public void LogWarning(string message, string header, string tag = "default")
        {
            LogUniversal(LogLevel.Warning, message, header, tag);
        }

        public void LogInformation(string message, string header, string tag = "default")
        {
            LogUniversal(LogLevel.Information, message, header, tag);
        }

        public void LogTrace(string message, string header, string tag = "default")
        {
            LogUniversal(LogLevel.Trace, message, header, tag);
        }
    }
}
