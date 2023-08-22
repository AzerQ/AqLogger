using System;
using System.Collections.Generic;
using System.Text;

namespace AqORM.DB.SchemaGenerator
{
    /// <summary>
    /// Генерация текста классов и таблиу
    /// </summary>
    public interface ISchemaGenerator
    {
        /// <summary>
        /// Создать таблицу в БД по модели данных
        /// </summary>
        /// <param name="modelType">Тип модели</param>
        /// <param name="tableName">Полное имя таблицы в базе со схемой</param>
        /// <returns>Запрос SQL Create Table</returns>
        string GenerateCreateTableSql(Type modelType, string tableName);

        /// <summary>
        /// Создать класс c# из таблицы
        /// </summary>
        /// <param name="tableName">Имя таблицы</param>
        /// <param name="className">Имя класса</param>
        /// <returns>Исходный код класса</returns>
        string GenerateClrClass(string tableName, string className);

    }
}
