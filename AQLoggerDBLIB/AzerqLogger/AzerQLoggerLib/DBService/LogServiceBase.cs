using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AzerQLoggerLib.DBService.Configuratinon;
using AzerQLoggerLib.DBService.Filters;
using AzerQLoggerLib.DBService.SqlHelpers;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;

namespace AzerQLoggerLib.DBService
{
    public class LogServiceBase<T>:ILogDbService<AzerqLogItem>
    {
        /// <summary>
        /// Получить уникальные значения поля в таблице
        /// </summary>
        /// <param name="fieldName">Имя поля</param>
        /// <returns>Список уникальных значений</returns>
        public List<string> GetDistinctValues(string fieldName)
        {
            using IDbConnection db = new SqlConnection(Configuration.DBcreditionals.MSSQLConnectionString);
            return db.Query<string>($"SELECT DISTINCT {fieldName} FROM {Configuration.TableName}").ToList();
        }


        public string DbTypeString { get; }

        /// <summary>
        /// Общее количество записей логов
        /// </summary>
        public int LogsCount
        {
            get
            {
                using IDbConnection db = new SqlConnection(Configuration.DBcreditionals.MSSQLConnectionString);
                return (int)db.ExecuteScalar($"SELECT COUNT(*) FROM {Configuration.TableName}");
            }
        }

        LogDbConfigurationBase ILogDbService<AzerqLogItem>.Configuration
        {
            get => _configuration1;
            set => _configuration1 = value;
        }


        private AzerqLoggerConfiguration _configuration;
        private LogDbConfigurationBase _configuration1;

        /// <summary>
        /// Конфигурация логгера
        /// </summary>
        public AzerqLoggerConfiguration Configuration
        {
            get => _configuration; set
            {
                //Проверка и создание таблицы(если её нет в базе)
                _configuration = value;
                using IDbConnection db = new SqlConnection(Configuration.DBcreditionals.MSSQLConnectionString);
                TableChecker.CheckOrCreate(Configuration.TableName, db);
            }
        }





  

        /// <summary>
        /// Создание нового сервиса логирования с конфигурацией
        /// </summary>
        /// <param name="configuration">Параметры сервиса</param>
        public LogServiceBase(LogDbConfigurationBase configuration)
        {
            Configuration = configuration;
        }

        public LogServiceBase()
        {

        }


        /// <summary>
        /// Получить лог по идентефикатору
        /// </summary>
        /// <param name="id">Идентификатор лога</param>
        /// <returns>Запись лога</returns>
        public AzerqLogItem GetById(Guid id)
        {
            using IDbConnection db = new SqlConnection(Configuration.DBcreditionals.MSSQLConnectionString);
            return db.Query<AzerqLogItem>($@"SELECT * FROM {Configuration.TableName} WHERE RowId = '{id}'").FirstOrDefault();
        }

        /// <summary>
        /// Получить все записи логов из таблицы
        /// </summary>
        /// <returns>Список объектов логов</returns>
        public IEnumerable<AzerqLogItem> GetAllItems()
        {
            using IDbConnection db = new SqlConnection(Configuration.DBcreditionals.MSSQLConnectionString);
            return db.Query<AzerqLogItem>($@"SELECT * FROM {Configuration.TableName}");
        }

        public IEnumerable<AzerqLogItem> GetAllItems(IEnumerable<StandardFilter<object>> fieldsFilters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AzerqLogItem> GetItemsOnPage(int elementsOnPage, int pageNumber)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получить все записи логов из таблицы с условием
        /// </summary>
        /// <returns>Список объектов логов</returns>
        public IEnumerable<AzerqLogItem> GetAllItems(AzerqLogItem filterObject)
        {
            using IDbConnection db = new SqlConnection(Configuration.DBcreditionals.MSSQLConnectionString);
            return db.Query<AzerqLogItem>(GenerateWhereClausureFilter(filterObject));
        }
        public object GetDefaultValue(Type t)
        {
            if (t.IsValueType)
            {
                return Activator.CreateInstance(t);
            }
            else
            {
                return null;
            }
        }

        public Task StartTableWatching()
        {
            return new Task(() =>
            {
                using var Dep = new SqlTableDependency<AzerqLogItem>(Configuration.DBcreditionals.MSSQLConnectionString, Configuration.TableName, "dbo");
                Dep.OnChanged += (sender, evnt) =>
                {

                };
            });
        }

        /// <summary>
        /// Генерация условия Where фильтра
        /// </summary>
        /// <param name="filter">Объект фильтрации</param>
        /// <returns></returns>
        public string GenerateWhereClausureFilter(object filter)
        {
            SqlBuilder builder = new SqlBuilder();
            var template = builder.AddTemplate($@"SELECT * FROM {Configuration.TableName} /**where**/");
            var props = filter.GetType().GetProperties()
             .Where(prop => prop.GetCustomAttribute<DapperIgnoreAttribute>() == null)
             .Where(prop =>
             {
                 bool ishasValue = false;
                 Type propType = prop.PropertyType;
                 object value = prop.GetValue(filter);
                 if (propType == typeof(string))
                 {
                     ishasValue = !string.IsNullOrEmpty(value as string);
                 }
                 else
                 {
                     var defaultPropValue = GetDefaultValue(propType);
                     ishasValue = value != defaultPropValue;
                 }
                 return ishasValue;
             }).ToList();

            props.ForEach(prop =>
            {
                builder.Where($" {prop.Name} like '%{prop.GetValue(filter)}%' ");
            });

            return template.RawSql;

        }


        /// <summary>
        /// Получить все записи логов из таблицы постранично
        /// </summary>
        /// <returns>Список объектов логов</returns>
        public IEnumerable<AzerqLogItem> GetAllItemsPaginated(int elementsOnPage, int pageNumber)
        {
            int LastValueIndex = elementsOnPage * pageNumber;
            var LastPageDiff = Math.Abs(LogsCount - LastValueIndex);
            if (LastPageDiff > elementsOnPage)
            {
                throw new ArgumentOutOfRangeException("Количество элементов на странице слишом велико или слишком большой номер страницы для пагинации!");
            }

            using IDbConnection db = new SqlConnection(Configuration.DBcreditionals.MSSQLConnectionString);
            var elemCount = LastPageDiff >= elementsOnPage ? elementsOnPage : LastPageDiff;
            return db.Query<AzerqLogItem>($@"SELECT * FROM {Configuration.TableName} ORDER BY CreateDate 
                OFFSET {elementsOnPage * (pageNumber - 1)} ROWS FETCH NEXT {elemCount} ROWS ONLY");
        }

        /// <summary>
        /// Удалить элемент лога из таблицы
        /// </summary>
        /// <param name="id"></param>
        public void DeleteItem(Guid id)
        {
            using IDbConnection db = new SqlConnection(Configuration.DBcreditionals.MSSQLConnectionString);
            db.Execute($@"DELETE FROM {Configuration.TableName} WHERE RowId = '{id}'");
        }

        /// <summary>
        /// Создать новую запись лога
        /// </summary>
        /// <param name="item">Объект лога</param>
        /// <returns>Идентификатор созданной записи</returns>
        public Guid CreateItem(AzerqLogItem item)
        {
            item.RowId = Guid.NewGuid();

            var SQLCode = GenerateInsertSQL(item, Configuration.TableName);
            using (IDbConnection db = new SqlConnection(Configuration.DBcreditionals.MSSQLConnectionString))
            {
                Func<Guid, bool> IsPossibleGuid = (id) =>
                    !db.Query<dynamic>($"SELECT * FROM {Configuration.TableName} Where RowId = '{item.RowId}'").Any();
                while (!IsPossibleGuid(item.RowId)) //Если такой Guid есть
                {
                    item.RowId = Guid.NewGuid();
                }
                db.Execute(SQLCode, item);
            }
            return item.RowId;
        }

        /// <summary>
        /// Обновить существующую запись лога
        /// </summary>
        /// <param name="item">Запись лога</param>
        public void Update(AzerqLogItem item)
        {
            var SQLCode = GeneratUpdateSQL(item, Configuration.TableName, "RowId");
            using IDbConnection db = new SqlConnection(Configuration.DBcreditionals.MSSQLConnectionString);
            db.Execute(SQLCode, item);
        }

        public ISqlHelper SqlHelper { get; set; }
    }
}
