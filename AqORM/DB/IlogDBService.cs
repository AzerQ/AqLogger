using System;
using System.Collections.Generic;
using AqORM.DB.Filters;
using AqORM.DB.SqlHelpers;

namespace AqORM.DB
{
    /// <summary>
    /// Базовое представление сервиса взаимодействия с базой данных логов
    /// </summary>
    public interface ILogDbService<TLogType>
    {

        /// <summary>
        /// Тип  базы данных (MSSQL, Sqlite и т.д)
        /// перечень доступных строк в классе Provider.Strings
        /// </summary>
        public string DbTypeString { get; }

        /// <summary>
        /// Кол-во логов в таблице базы данных
        /// </summary>
        int LogsCount { get; }

        /// <summary>
        /// Конфигурация подключения к источнику данных
        /// </summary>
        LogDbConfigurationBase Configuration { get; set; }

        /// <summary>
        /// Получить лог по его идентификатору
        /// </summary>
        /// <param name="id">Идентификатор лога в формате UUID</param>
        /// <returns>Элемент лога</returns>
        AzerqLogItem GetById(Guid id);

        /// <summary>
        /// Получить все элементы таблицы логов
        /// </summary>
        /// <returns>Коллекцию всех элементов логов</returns>
        IEnumerable<TLogType> GetAllItems();

        /// <summary>
        /// Получить все элементы таблицы логов по фильтрующему объекту
        /// </summary>
        /// <param name="fieldsFilters">Фильтры полей</param>
        /// <returns>Отфильтрованная на строне сервера базы данных коллекция объектов</returns>
        IEnumerable<TLogType> GetAllItems(IEnumerable<StandardFilter<object>>? fieldsFilters);

        /// <summary>
        /// Постраничное получение данных с сервера
        /// </summary>
        /// <param name="elementsOnPage">Кол-во элементов на странице</param>
        /// <param name="pageNumber">Номер интересующей страницы</param>
        /// <returns>Список объектов логов</returns>
        IEnumerable<TLogType> GetItemsOnPage(int elementsOnPage, int pageNumber);

        /// <summary>
        /// Удалить элемент лога по его идентификатору
        /// </summary>
        /// <param name="id">Идентификатор лога</param>
        void DeleteItem(Guid id);

        /// <summary>
        /// Создать элемент лога
        /// </summary>
        /// <param name="item">Объект лога</param>
        /// <returns>Идинтификатор созданной записи в таблице базы данных</returns>
        Guid CreateItem(TLogType item);

        /// <summary>
        /// Обновить запись в базе данных
        /// </summary>
        /// <param name="item">Объект лога</param>
        void Update(TLogType item);

        /// <summary>
        /// Помошник для генерации однотипных Sql запросов
        /// </summary>
        ISqlTextHelper SqlHelper { get; set; }
    }
    /// <summary>
    /// Имена провайдеров баз данных, добавлять сюда при создании нового провайдера
    /// </summary>
    class DbProvidersNames
    {
         public const string MSSQLServer = nameof(MSSQLServer);
    }
}
