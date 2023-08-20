using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerQLoggerLib
{
    /// <summary>
    /// Проверка существования таблицы
    /// </summary>
    public class TableChecker
    {
        /// <summary>
        /// Шаблон создания таблицы логов
        /// </summary>
        public const string LogTableCreateTemplate = @"
CREATE TABLE [dbo].[{0}] (
    [RowId]           UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [ContentType]     VARCHAR (50)     DEFAULT ('PLAIN/TEXT') NULL,
    [Type]            VARCHAR (50)     DEFAULT ('INFO') NULL,
    [Content]         NVARCHAR (MAX)   NOT NULL,
    [ApplicationName] VARCHAR (150)    NOT NULL,
    [CreateDate]      DATETIME         DEFAULT (getdate()) NULL,
    [ChannelName]     VARCHAR (100)    DEFAULT ('Default') NULL,
    [Tag]             VARCHAR (80)     DEFAULT ('Default') NULL,
    [Author]          VARCHAR (100)    DEFAULT ('System') NULL,
    [Header]          NVARCHAR (350)   NOT NULL,
    PRIMARY KEY CLUSTERED ([RowId] ASC)
);";
        /// <summary>
        /// Шаблон проверки существования таблицы в базе
        /// </summary>
        public const string CheckTableTemplate = @"SELECT CASE WHEN EXISTS ((SELECT * FROM INFORMATION_SCHEMA.TABLES
WHERE table_name = '{0}')) then 1 else 0 end";
        /// <summary>
        /// Проверить или создать таблицу в  базе данных
        /// </summary>
        /// <param name="tableName">Имя таблицы</param>
        /// <param name="connection">Соеденинение с БД</param>
        /// <returns>true, если таблица уже есть, false если таблицы нет</returns>
        public static bool CheckOrCreate(string tableName, IDbConnection connection)
        {
            // Флаг существования таблицы (0 - таблицы нет, 1 - таблица существует)
            bool tableExists = (int)connection.ExecuteScalar(string.Format(CheckTableTemplate, tableName)) == 1;
            if (!tableExists)
            {
                connection.Execute(string.Format(LogTableCreateTemplate, tableName));
            }
            return tableExists;
        }
    }
}
