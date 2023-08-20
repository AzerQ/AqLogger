using AzerQLoggerLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AQLogMonitor
{
    public partial class LogViewForm : Form
    {
        /// <summary>
        /// Данные авторизации БД
        /// </summary>
        public List<DBRecord> DBServerCreditionals
        {
            get => DBServersListBox.Items.Cast<DBRecord>().ToList();
            set => value.ForEach(el => DBServersListBox.Items.Add(el));
        }

        /// <summary>
        /// Общее количество записей логов
        /// </summary>
        public int AllCount;

        /// <summary>
        /// Сервис логирования
        /// </summary>
        public AzerqLogService LogService { get; set; }

        public List<AzerqLogItem> LogItems { get; set; } = new List<AzerqLogItem>();


        public LogViewForm()
        {
            InitializeComponent();
            LogService = new AzerqLogService();

        }

        /// <summary>
        /// Нажатие на кнопку добавить в контекстном меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddNewLogServer addForm = new AddNewLogServer())
            {
                addForm.ShowDialog();

                if (addForm.DialogResult == DialogResult.OK)
                {
                    DBServersListBox.Items.Add(addForm.DBConnectInfo);
                    DBServerCreditionals.Remove(addForm.DBConnectInfo);
                }
            }

        }
        /// <summary>
        /// Нажатие на кнопку удалить в списке серверов
        /// </summary>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBServersListBox.Items.Remove(DBServersListBox.SelectedItem);
        }

        /// <summary>
        /// Нажатие на кнопку сохранить в файл в списке серверов
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveServersListDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveServersListDialog.FileName;
                System.IO.File.WriteAllText(fileName, JsonConvert.SerializeObject(DBServerCreditionals));

            }
        }

        private void saveServersListDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void DBServersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// При нажатии в списке таблиц логирования
        /// </summary>
        private void DBServersListBox_Click(object sender, EventArgs e)
        {
            try
            {
                var configurationItem = (DBRecord)DBServersListBox.SelectedItem;
                LogService.Configuration = new AzerqLoggerConfiguration()
                {
                    ApplicationName = "AQLogMonitor",
                    ChannelName = "#monitoring",
                    Level = LogLevel.All,
                    TableName = configurationItem.TableName,
                    DBcreditionals = configurationItem.ConnectInfo

                };
                MessageBox.Show($@"Подключение к базе {configurationItem.ConnectInfo.AdditionalInfo} на 
                сервере {configurationItem.ConnectInfo.ServerName} успешно установленно", "Успешное подключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exep)
            {
                MessageBox.Show($"Ошибка: {exep}", "Ошибка в подключении и загрузке данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadServersFromFile(string path)
        {
            var JSON = System.IO.File.ReadAllText(path);
            List<DBRecord> serverCreditionals = JsonConvert.DeserializeObject<List<DBRecord>>(JSON);
            DBServersListBox.Items.Clear();
            DBServerCreditionals = serverCreditionals;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openServersListDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openServersListDialog.FileName;
                LoadServersFromFile(fileName);

            }
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var configurationItem = (DBRecord)DBServersListBox.SelectedItem;
            if (configurationItem != null)
            {
                using (AddNewLogServer addNewLogServer = new AddNewLogServer(configurationItem))
                {
                    addNewLogServer.ShowDialog();

                }
                DBServersListBox.Items[DBServersListBox.SelectedIndex] = configurationItem;
            }
        }

        public void ColorColumnCells(DataGridView gridView, int columnIndex, Func<string, System.Drawing.Color> Colorizer)
        {
            for (int i = 0; i < gridView.Rows.Count - 1; i++)
            {
                var currentItem = gridView[columnIndex, i];
                currentItem.Style.ForeColor = Colorizer(currentItem.Value.ToString());
            }
        }

        public void LoadItemsToGrid(IEnumerable<AzerqLogItem> items)
        {
            logsDataGridView.DataSource = items;
            for (int i = 0; i < logsDataGridView.Rows.Count; i++)
            {
                logsDataGridView[1, i].Style.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Bold);
            }
            var resizeIndex = new List<int>() { 0, 1, 2, 4, 5, 6, 7, 8, 9 };
            resizeIndex.ForEach(i => logsDataGridView.AutoResizeColumn(i));
            ColorColumnCells(logsDataGridView, 1, (inp) =>
            {
                LogLevel level = (LogLevel)Enum.Parse(typeof(LogLevel), inp);
                switch (level)
                {
                    case LogLevel.Error:
                        return Color.Red;
                        break;
                    case LogLevel.Warning:
                        return Color.FromArgb(255, 133, 135, 8);
                        break;
                    case LogLevel.Information:
                        return Color.Blue;
                        break;
                    case LogLevel.Trace:
                        return Color.Orange;
                        break;
                    default:
                        return Color.Black;
                }
            });
            var cnt = 1;
            foreach (DataGridViewRow Row in logsDataGridView.Rows)
            {
                Row.Cells[0].Value = cnt++;
            }

        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            if (LogService.Configuration == null)
            {
                MessageBox.Show($"Ошибка: конфигурация сервера не выбранна и не заполненна", "Ошибка конфигурации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (paginationEnabledCheckBox.Checked)
                {
                   LogItems = LogService.GetAllItemsPaginated((int)elementsCountUpDown.Value,
                        (int)pageNumberUpDown.Value).ToList();
                    LoadItemsToGrid(LogItems);
                }
                else
                {
                    LogItems = LogService.GetAllItems().ToList();
                    LoadItemsToGrid(LogItems);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "Ошибка в загрузке данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void paginationEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PaginationPanel.Enabled = paginationEnabledCheckBox.Checked;
            AllCount = LogService.LogsCount;

            elementsCountUpDown.Minimum = 1;
            elementsCountUpDown.Maximum = AllCount;

            pageNumberUpDown.Minimum = 1;

            allCountLabel.Text = $"Всего элементов: {AllCount}";

        }

        private void elementsCountUpDown_ValueChanged(object sender, EventArgs e)
        {
            var elementsCount = (sender as NumericUpDown).Value;
            var Ost = AllCount % elementsCount;
            var Count = AllCount / elementsCount;
            pageNumberUpDown.Maximum = (Ost == 0) ? Count : Count + 1;
            PageTotalLabel.Text = $"из {pageNumberUpDown.Maximum}";
        }

        private void logsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LogViewForm_Load(object sender, EventArgs e)
        {
            LoadServersFromFile(@"Configuration\ServersList.json");
        }

        AzerqLogItem CollectItem()
        {
            var index = logsDataGridView.CurrentCell.RowIndex;
            if (index < 0)
            { return null; }
            else
            {
                logsDataGridView.Rows[index].Selected = true;
                var log = logsDataGridView.SelectedRows[0].DataBoundItem as AzerqLogItem;
                logsDataGridView.Rows[index].Selected = false;
                return log;
            }
        }
        private void watchLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var log = CollectItem();
            if (log != null)
            {
                using (LogItemView logItemView = new LogItemView(log, LogService))
                {
                    logItemView.ShowDialog();
                }
            }
        }

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var log = CollectItem();
            if (log != null)
            {
                using (LogItemView logItemView = new LogItemView(log, LogService, LogViewMode.Edit))
                {
                    var result = logItemView.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        logsDataGridView.DataSource = null;
                        logsDataGridView.DataSource = LogItems;
                    }
                }
            }

        }

        private void deleteLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Log = CollectItem();
            LogService.DeleteItem(Log.RowId);
        }

        private void createLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (LogItemView logItemView = new LogItemView(LogService))
            {
                var result = logItemView.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LogItems.Add(logItemView.LogItem);
                    logsDataGridView.DataSource = null;
                    logsDataGridView.DataSource = LogItems;
                }
            }
        }
    }
}
