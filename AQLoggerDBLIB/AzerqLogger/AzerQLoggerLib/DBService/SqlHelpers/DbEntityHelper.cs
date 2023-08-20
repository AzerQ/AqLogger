using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using AzerQLoggerLib.DBService.TypeMapper;

namespace AzerQLoggerLib.DBService.SqlHelpers
{
    /// <summary>
    /// Тип данных связи колонки БД и поля класса
    /// </summary>
    public class ColumnMapItem
    {
        /// <summary>
        /// Тип данных в БД
        /// </summary>
        public string SqlType { get; set; }

        /// <summary>
        /// Тип данных в c#
        /// </summary>
        public Type ClrType { get; set; }

        /// <summary>
        /// Колонка в БД
        /// </summary>
        public string DbColumn { get; set; }

        /// <summary>
        /// Имя свойства c#
        /// </summary>
        public string  PropertyName { get; set; }

        /// <summary>
        /// Поле является первичным ключом таблицы
        /// </summary>
        public bool IsPrimaryKey { get; set; }
    }

    /// <summary>
    /// Помошник при работе с классом-сущностью
    /// </summary>
    public class DbEntityHelper
    {
        private ISqlTypeMapper _mapper;
        /// <summary>
        /// Словарь-сопоставление свойств класса с свойствами таблицы в БД
        /// </summary>
        public List<ColumnMapItem> MappingList { get; set; }

        /// <summary>
        /// Имя первичного ключа
        /// </summary>
        public string PrimaryKeyName { get; set; }

        /// <summary>
        /// Имя таблицы в базе данных
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Вспомогательный класс для работы с сущностями базы данных.
        /// Инициализирует маппинг и атрибуты сущности для удобной работы с таблицей.
        /// </summary>
        /// <param name="modelType">Тип сущности, для которой нужно инициализировать маппинг и атрибуты</param>
        /// <param name="mapper">Сопоставитель типов</param>
        /// <param name="tableName">Имя таблицы, если оно отличается от имени сущности (опционально)</param>
        public DbEntityHelper(Type modelType, ISqlTypeMapper mapper, string tableName = "")
        {
            _mapper = mapper;
            MappingList = new List<ColumnMapItem>();

            // Получаем атрибут таблицы (если есть)
            var tableAttribute = modelType.GetCustomAttribute<TableAttribute>();

            TableName = tableName; // Устанавливаем имя таблицы

            // Если имя таблицы не передано явно и есть атрибут таблицы, используем его имя
            if (tableName == "" && tableAttribute != null)
            {
                TableName = tableAttribute.Name;
            }

            // Сканирование полей (свойств) класса
            foreach (var modelProperty in modelType.GetProperties())
            {
                // Пропускаем поля с атрибутом NotMapped
                if (modelProperty.GetCustomAttribute<NotMappedAttribute>() != null)
                {
                    continue; // Пропускаем несвязанное поле класса
                }

                var mapItem = new ColumnMapItem();
                mapItem.PropertyName = modelProperty.Name; // Имя поля класса
                mapItem.DbColumn  = modelProperty.GetCustomAttribute<ColumnAttribute>()?.Name ?? modelProperty.Name; // Имя колонки таблицы
                mapItem.ClrType = modelProperty.PropertyType;
                mapItem.SqlType = _mapper.MapSqlType(mapItem.ClrType);
                MappingList.Add(mapItem);

                // Устанавливаем имя первичного ключа, если есть атрибут Key
                var idAttribute = modelProperty.GetCustomAttribute<KeyAttribute>();
                mapItem.IsPrimaryKey = idAttribute != null;
                if (mapItem.IsPrimaryKey)
                {
                    PrimaryKeyName = mapItem.DbColumn;
                }
            }
        }
    }

}