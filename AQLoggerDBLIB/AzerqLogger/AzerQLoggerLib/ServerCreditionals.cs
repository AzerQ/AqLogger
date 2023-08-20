using Newtonsoft.Json;
using System;

namespace AzerQLoggerLib
{
    /// <summary>
    /// Данные авторизации сервера
    /// </summary>
    [Serializable]
    public class ServerCreditionals
    {
        /// <summary>
        /// Новые данные авторизации
        /// </summary>
        /// <param name="serverName">Имя сервера</param>
        /// <param name="userName">Пользователь</param>
        /// <param name="password">Пароль</param>
        /// <param name="additionalInfo">Дополнительная информация (например имя Базы Данных или Домен пользователя)</param>
        public ServerCreditionals(string serverName, string userName, string password, string additionalInfo = "")
        {
            ServerName = serverName;
            UserName = userName;
            Password = password;
            AdditionalInfo = additionalInfo;
        }
        /// <summary>
        /// Новые данные авторизации
        /// </summary>
        public ServerCreditionals() { }

        /// <summary>
        /// Имя сервера
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }


        /// <summary>
        /// Дополнителная информация, например имя Базы Данных или Домен пользователя
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Автогенерируемая строка подключения к БД
        /// </summary>
        [JsonIgnore]
        public string MSSQLConnectionString
        {
            get
            {
                var ADLoginTemplate = "Data Source={0};Initial Catalog={1};Connect Timeout=60;Integrated Security=True;";
                var SQLLoginTemplate = "Data Source={0}; Initial Catalog={1}; Integrated Security=False; User={2}; Password={3};";
                if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
                {
                    return string.Format(ADLoginTemplate, ServerName, AdditionalInfo);
                }
                else
                {
                    return string.Format(SQLLoginTemplate, ServerName, AdditionalInfo, UserName, Password);
                }
            }
        }

    }
}