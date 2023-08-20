
using System.Collections.Generic;

namespace AzerQLoggerLib.DBService.Filters
{
    /// <summary>
    /// Базовый класс фильтра поля
    /// </summary>
    public class StandardFilter<T>
    {
        /// <summary>
        /// Имя поля для фильтрации
        /// </summary>
        public string FieldName { get; set; }
        /// <summary>
        /// Тип фильтрации
        /// </summary>
        public FilterOperator Operator { get; set; }

        /// <summary>
        /// Передаваемое значение
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Значения для оператора "In" (Вхождения в множество значений)
        /// </summary>
        public IEnumerable<T> InValues { get; set; }


        /// <summary>
        /// Новый базовый фильтр (с одиночным значением)
        /// </summary>
        /// <param name="fieldName">Имя поля</param>
        /// <param name="operator">Оператор фильтрации (=, !=, "<", ">")</param>
        /// <param name="value">Значение для фильтрации</param>
        public StandardFilter(string fieldName, FilterOperator @operator, T value)
        {
            FieldName = fieldName;
            Operator = @operator;
            Value = value;
        }

        /// <summary>
        /// Новый базовый фильтр (с множественными значениями)
        ///  Оператор по умолчанию In
        /// </summary>
        /// <param name="fieldName">Имя поля</param>
        /// <param name="inValues">Значения из множества, для фильтрации</param>
        public StandardFilter(string fieldName, IEnumerable<T> inValues)
        {
            FieldName = fieldName;
            Operator = FilterOperator.In;
            InValues = inValues;
        }
    }

    /// <summary>
    /// Тип фильтрации
    /// </summary>
    public enum FilterOperator
    {
    /// <summary>
    /// Значение равно текущему
    /// </summary>
        Equal,
    /// <summary>
    /// Значение не равно текущему
    /// </summary>
        NotEqual,
    /// <summary>
    /// Значение больше чем текущее
    /// </summary>
        GreaterThan,
    /// <summary>
    /// Значение больше или равно чем текущее
    /// </summary>
        GreaterThanOrEqual, 
    /// <summary>
    /// Значение меньше чем текущее
    /// </summary>
        LessThan,
    /// <summary>
    /// Значение ментше или равно текущему
    /// </summary>
        LessThanOrEqual,    
    /// <summary>
    /// Значение содержит текущее (ДЛЯ СТРОК!!!)
    /// </summary>
        Contains,
    /// <summary>
    /// Значение не содержит текущее (ДЛЯ СТРОК!!!)
    /// </summary>
        NotContains,
    /// <summary>
    /// Входит в ограниченное множество значений
    /// </summary>
    In
    }

}
