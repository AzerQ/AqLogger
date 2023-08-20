using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerQLoggerLib.DBService.Filters
{
    /// <summary>
    /// Класс для построения условия WHERE запроса на базе фильтров.
    /// </summary>
    public class QueryBuilder
    {
        /// <summary>
        /// Фильтры для добавления
        /// </summary>
        private List<StandardFilter<object>> _filters;

        /// <summary>
        /// Создает новый экземпляр класса QueryBuilder.
        /// </summary>
        public QueryBuilder()
        {
            _filters = new List<StandardFilter<object>>();
        }

        //public QueryBuilder AddFilter<T>(StandardFilter<T> filter)
        //{
        //    _filters.Add(filter as StandardFilter<object>);
        //    return this;
        //}

        /// <summary>
        /// Добавляет фильтр равенства значения указанному полю.
        /// </summary>
        /// <typeparam name="T">Тип значения фильтра.</typeparam>
        /// <param name="fieldName">Имя поля для фильтрации.</param>
        /// <param name="value">Значение для фильтрации.</param>
        /// <returns>Экземпляр QueryBuilder с добавленным фильтром.</returns>
        public QueryBuilder Equal<T>(string fieldName, T value)
        {
            _filters.Add(new StandardFilter<object>(fieldName, FilterOperator.Equal, value));
            return this;
        }

        /// <summary>
        /// Добавляет фильтр неравенства значения указанному полю.
        /// </summary>
        /// <typeparam name="T">Тип значения фильтра.</typeparam>
        /// <param name="fieldName">Имя поля для фильтрации.</param>
        /// <param name="value">Значение для фильтрации.</param>
        /// <returns>Экземпляр QueryBuilder с добавленным фильтром.</returns>
        public QueryBuilder NotEqual<T>(string fieldName, T value)
        {
            _filters.Add(new StandardFilter<object>(fieldName, FilterOperator.NotEqual, value));
            return this;
        }

        /// <summary>
        /// Добавляет фильтр значения больше указанного.
        /// </summary>
        /// <typeparam name="T">Тип значения фильтра.</typeparam>
        /// <param name="fieldName">Имя поля для фильтрации.</param>
        /// <param name="value">Значение для фильтрации.</param>
        /// <returns>Экземпляр QueryBuilder с добавленным фильтром.</returns>
        public QueryBuilder GreaterThan<T>(string fieldName, T value)
        {
            _filters.Add(new StandardFilter<object>(fieldName, FilterOperator.GreaterThan, value));
            return this;
        }

        /// <summary>
        /// Добавляет фильтр значения больше или равное указанному.
        /// </summary>
        /// <typeparam name="T">Тип значения фильтра.</typeparam>
        /// <param name="fieldName">Имя поля для фильтрации.</param>
        /// <param name="value">Значение для фильтрации.</param>
        /// <returns>Экземпляр QueryBuilder с добавленным фильтром.</returns>
        public QueryBuilder GreaterThanOrEqual<T>(string fieldName, T value)
        {
            _filters.Add(new StandardFilter<object>(fieldName, FilterOperator.GreaterThanOrEqual, value));
            return this;
        }

        /// <summary>
        /// Добавляет фильтр значения меньше указанного.
        /// </summary>
        /// <typeparam name="T">Тип значения фильтра.</typeparam>
        /// <param name="fieldName">Имя поля для фильтрации.</param>
        /// <param name="value">Значение для фильтрации.</param>
        /// <returns>Экземпляр QueryBuilder с добавленным фильтром.</returns>
        public QueryBuilder LessThan<T>(string fieldName, T value)
        {
            _filters.Add(new StandardFilter<object>(fieldName, FilterOperator.LessThan, value));
            return this;
        }

        /// <summary>
        /// Добавляет фильтр значения меньше или равное указанному.
        /// </summary>
        /// <typeparam name="T">Тип значения фильтра.</typeparam>
        /// <param name="fieldName">Имя поля для фильтрации.</param>
        /// <param name="value">Значение для фильтрации.</param>
        /// <returns>Экземпляр QueryBuilder с добавленным фильтром.</returns>
        public QueryBuilder LessThanOrEqual<T>(string fieldName, T value)
        {
            _filters.Add(new StandardFilter<object>(fieldName, FilterOperator.LessThanOrEqual, value));
            return this;
        }

        /// <summary>
        /// Добавляет фильтр подстроки включенной в основную строку.
        /// </summary>
        /// <typeparam name="T">Тип значения фильтра.</typeparam>
        /// <param name="fieldName">Имя поля для фильтрации.</param>
        /// <param name="value">Подстрока</param>
        /// <returns>Экземпляр QueryBuilder с добавленным фильтром.</returns>
        public QueryBuilder Contains(string fieldName, string value)
        {
            _filters.Add(new StandardFilter<object>(fieldName, FilterOperator.Contains, value));
            return this;
        }

        /// <summary>
        /// Добавляет фильтр подстроки не включенной в основную строку.
        /// </summary>
        /// <typeparam name="T">Тип значения фильтра.</typeparam>
        /// <param name="fieldName">Имя поля для фильтрации.</param>
        /// <param name="value">Подстрока</param>
        /// <returns>Экземпляр QueryBuilder с добавленным фильтром.</returns>
        public QueryBuilder NotContains(string fieldName, string value)
        {
            _filters.Add(new StandardFilter<object>(fieldName, FilterOperator.NotContains, value));
            return this;
        }

        /// <summary>
        /// Добавляет фильтр нахождения значения в заданном множестве.
        /// </summary>
        /// <typeparam name="T">Тип значения фильтра.</typeparam>
        /// <param name="fieldName">Имя поля для фильтрации.</param>
        /// <param name="inValues">Множество заданных значений.</param>
        /// <returns>Экземпляр QueryBuilder с добавленным фильтром.</returns>
        public QueryBuilder In<T>(string fieldName, params T[] inValues)
        {
            _filters.Add(new StandardFilter<object>(fieldName, new[] { inValues }));
            return this;
        }

        /// <summary>
        /// Возвращает копию коллекции созданных фильтров
        /// </summary>
        /// <returns>Список установленных фильтров</returns>
         public List<StandardFilter<object>> Build() => _filters.ToList();
    }
}
