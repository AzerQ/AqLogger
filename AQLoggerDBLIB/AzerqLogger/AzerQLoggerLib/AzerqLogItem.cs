using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Text;
using Newtonsoft.Json;

namespace AzerQLoggerLib
{
    /// <summary>
    /// Модель лога для записи в базу
    /// </summary>
    [Serializable]
    public class AzerqLogItem
    {

        /// <summary>
        /// Запись в поле Content объекта
        /// </summary>
        [NotMapped]
        public object LogObject
        {
            set
            {
                Content = JsonConvert.SerializeObject(value);
                ContentType = "JSON";
            }
            get => JsonConvert.DeserializeObject(Content);
        }    
        public AzerqLogItem()
        {

        }

        public AzerqLogItem(string content, string applicationName, string header)
        {
            Content = content;
            ApplicationName = applicationName;
            Header = header;
            ContentType = LogContentType.Text.ToString();
        }

        public AzerqLogItem(string contentType, LogLevel type, string content, string applicationName, string channelName, string tag, string author, string header)
        {
            ContentType = contentType;
            Type = type.ToString();
            Content = content;
            ApplicationName = applicationName;
            ChannelName = channelName;
            Tag = tag;
            Author = author;
            Header = header;
        }

        [Key]
        /// <summary>
        /// Идентификатор лога
        /// </summary>
        public Guid RowId { get; set; }

        /// <summary>
        /// MIME-тип содержимого
        /// </summary>
        public string ContentType { get; set; } = "";


        /// <summary>
        /// Тип уровня лога
        /// </summary>
        public string Type { get; set; } = LogLevel.Information.ToString();

        /// <summary>
        /// Тело лога
        /// </summary>
        public string Content { get; set; } = "";

        /// <summary>
        /// Имя приложения
        /// </summary>
        public string ApplicationName { get; set; } = "";
        /// <summary>
        /// Автоматическая дата создания
        /// </summary>
        public DateTime CreateDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Имя каннала лога
        /// </summary>
        public string ChannelName { get; set; } = "";

        /// <summary>
        /// Тэг
        /// </summary>
        public string Tag { get; set; } = "";

        /// <summary>
        /// Автор
        /// </summary>
        public string Author { get; set; } = "";

        /// <summary>
        /// Зашоловок элемента лога
        /// </summary>
        public string Header { get; set; } = "";
    }

    /// <summary>
    /// Тип содержимого в логе
    /// </summary>
    public enum LogContentType
    {
        /// <summary>
        /// Текст
        /// </summary>
        Text,
        /// <summary>
        /// XML Данные
        /// </summary>
        XML,
        /// <summary>
        /// JSON Данные
        /// </summary>
        JSON,
        /// <summary>
        /// Картинка в формате Base64
        /// </summary>
        ImageBase64,
        /// <summary>
        /// Табличные значения разделенные запятой
        /// </summary>
        CSV,
        /// <summary>
        /// Markdown разметка
        /// </summary>
        Markdown,
        /// <summary>
        /// HTML разметка
        /// </summary>
        HTML,
        /// <summary>
        /// Неизвестный тип содержимого
        /// </summary>
        UNKNOWN
    }
}
