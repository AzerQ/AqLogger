using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerQLoggerLib
{
    /// <summary>
    /// Интерфейса стандартного логера
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Логгировние ошибки
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <param name="header">Заголовок сообщения</param>
        /// <param name="tag">Тэг</param>
        void LogError(string message, string header, string tag = "default");

        /// <summary>
        /// Логгировние предупреждения
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <param name="header">Заголовок сообщения</param>
        /// <param name="tag">Тэг</param>
        void LogWarning(string message, string header, string tag = "default");

        /// <summary>
        /// Логгирование информации
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <param name="header">Заголовок сообщения</param>
        /// <param name="tag">Тэг</param>
        void LogInformation(string message, string header, string tag = "default");

        /// <summary>
        /// Логирование в отладке
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <param name="header">Заголовок сообщения</param>
        /// <param name="tag">Тэг</param>
        void LogTrace(string message, string header, string tag = "default");
    }
}
