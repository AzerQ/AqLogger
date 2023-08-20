using AzerQLoggerLib;
using Microsoft.VisualBasic;
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
    public partial class LogItemView : Form
    {
        /// <summary>
        /// Элемент лога для отображения
        /// </summary>
        public AzerqLogItem LogItem { get; set; }

        /// <summary>
        /// Сервис логирования
        /// </summary>
        public AzerqLogService LogService { get; set; }

        /// <summary>
        /// Режим отображения формы
        /// </summary>
        public LogViewMode Mode { get; set; }

        /// <summary>
        /// Новая форма для создания элемента лога
        /// </summary>
        public LogItemView(AzerqLogService service)
        {
            InitializeComponent();
            LogService = service;
            Mode = LogViewMode.Create;
            LogItem = new AzerqLogItem();
            dateTimeCreated.Value = DateTime.Now;
            LoadAutocomplete(LogItem);
        }

        public List<string> HighLitings { get; set; } = new List<string>() { "Json", "Xml", "Html", "Text", "Markdown" };

        public void SetContentHighliting(string type)
        {
            type = (type == "Json") ? "JavaScript" : type.ToUpper();
            logContentControl.SetHighlighting(type);
        }

        /// <summary>
        /// Загрузить объект лога, для отбражения на форме
        /// </summary>
        /// <param name="item">Параметр объекта лога (по умолчанию значение поля LogItem)</param>
        public void LoadLogItem(AzerqLogItem item = null)
        {

            if (item == null)
            {
                item = LogItem;
            }

            LoadAutocomplete(item);

            logTypeComboBox.Text = item.Type;

            logHeaderTextBox.Text = item.Header;

            logContentTypeComboBox.Text = item.ContentType;

            authorTextBox.Text = item.Author;

            logContentControl.Text = item.Content;

            chanelNameComboBox.Text = item.ChannelName;

            IDTextBox.Text = item.RowId.ToString();

            dateTimeCreated.Value = item.CreateDate;

            appNameComboBox.Text = item.ApplicationName;

            SetContentHighliting(item.ContentType);

        }

        /// <summary>
        /// Сохранить запись лога
        /// </summary>
        /// <returns>Запись лога</returns>
        public AzerqLogItem SaveLogItem()
        {

            LogItem.Type = logTypeComboBox.Text;

            LogItem.Header = logHeaderTextBox.Text;

            LogItem.ContentType = logContentTypeComboBox.Text;

            LogItem.Author = authorTextBox.Text;

            LogItem.Content = logContentControl.Text;

            LogItem.ChannelName = chanelNameComboBox.Text;

            LogItem.CreateDate = dateTimeCreated.Value;

            LogItem.ApplicationName = appNameComboBox.Text;

            return LogItem;
        }


        /// <summary>
        /// Создание формы просмотра на базе объекта лога
        /// </summary>
        /// <param name="item">Объект лога</param>
        /// <param name="service">Сервис логирования</param>
        /// <param name="mode">Режим отображения разметки (по умолчанию просмотр)</param>
        public LogItemView(AzerqLogItem item, AzerqLogService service, LogViewMode mode = LogViewMode.Read)

        {

            InitializeComponent();

            LogService = service;

            LogItem = item;

            Mode = mode;

            if (Mode == LogViewMode.Read)
            {
                dialogButtonsPanel.Enabled = false;
                dialogButtonsPanel.Visible = false;

                addItemsPanel.Enabled = false;
                addItemsPanel.Visible = false;

            }

            LoadLogItem();

        }

        /// <summary>
        /// Загрузить автозаполненеие для всех полей
        /// </summary>
        public void LoadAutocomplete(AzerqLogItem LogItem)
        {
            chanelNameComboBox.DataSource = LogService.GetDistinctValues(nameof(LogItem.ChannelName));
            logTypeComboBox.DataSource = LogService.GetDistinctValues(nameof(LogItem.Type));
            logContentTypeComboBox.DataSource = HighLitings;//LogService.GetDistinctValues(nameof(LogItem.ContentType));
            tagСomboBox.DataSource = LogService.GetDistinctValues(nameof(LogItem.Tag));
            appNameComboBox.DataSource = LogService.GetDistinctValues(nameof(LogItem.ApplicationName));

        }

        private void LogItemView_Load(object sender, EventArgs e)
        {
            logContentControl.EnableFolding = true;


        }

        /// <summary>
        /// Нажатие на кнопку сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {

            switch (Mode)
            {
                case LogViewMode.Create:
                    LogService.CreateItem(SaveLogItem());
                    break;

                case LogViewMode.Edit:
                    LogService.Update(SaveLogItem());
                    break;

            }
        }
        /// <summary>
        /// Нажатие на кнопку отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void logContentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetContentHighliting(((ComboBox)sender).Text);
        }

        private void contentTabControl_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void visualazeButton_Click(object sender, EventArgs e)
        {
            var documentText = "";
            if (logContentTypeComboBox.Text.ToLower() == "xml")
            {
                documentText += "<?xml version = \"1.0\"?> ";
            }
            if (logContentTypeComboBox.Text.ToLower() == "markdown")
            {
                var md = new MarkdownSharp.Markdown();
                documentText += md.Transform(logContentControl.Text);
            }
            else
            {
                documentText += logContentControl.Text;
            }
            previewWebBrowser.DocumentText = documentText;
        }

        private void contentTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabName = contentTabControl.SelectedTab.Name;
            //MessageBox.Show(contentTabControl.SelectedTab.Name);
            if (tabName == nameof(visualTabPage))
            {
                visualazeButton_Click(null, null);
            }
        }

        private void applicationNameButton_Click(object sender, EventArgs e)
        {

            var Dict = new Dictionary<Button, ComboBox>()
            {
                { applicationNameButton, appNameComboBox },
                { channelPlusButton, chanelNameComboBox },
                { tagPlusButton, tagСomboBox }
            };

            var combobox = Dict[sender as Button];
            var comboList = combobox.DataSource as List<string>;
            var dialogResult = Interaction.InputBox("Добавьте новый элемент", "Новый элемент", String.Empty);
            if (!String.IsNullOrEmpty(dialogResult))
            {
                comboList.Add(dialogResult);
                combobox.DataSource = null;
                combobox.DataSource = comboList;
                combobox.SelectedText = dialogResult;

            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    /// <summary>
    /// Режим отображения лога
    /// </summary>
    public enum LogViewMode
    {
        /// <summary>
        /// Создание
        /// </summary>
        Create,
        /// <summary>
        /// Редактирование
        /// </summary>
        Edit,
        /// <summary>
        /// Чтение
        /// </summary>
        Read
    }
}
