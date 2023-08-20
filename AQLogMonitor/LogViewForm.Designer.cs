namespace AQLogMonitor
{
    partial class LogViewForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DBServersListBox = new System.Windows.Forms.ListBox();
            this.DBListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCountLabel = new System.Windows.Forms.Label();
            this.paginationEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.PaginationPanel = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.elementsCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.PageTotalLabel = new System.Windows.Forms.Label();
            this.pageNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.logsDataGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveServersListDialog = new System.Windows.Forms.SaveFileDialog();
            this.openServersListDialog = new System.Windows.Forms.OpenFileDialog();
            this.logsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.watchLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logViewFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.DBListContextMenuStrip.SuspendLayout();
            this.PaginationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementsCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsDataGridView)).BeginInit();
            this.logsContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logViewFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.logsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1292, 730);
            this.splitContainer1.SplitterDistance = 391;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.DBServersListBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.allCountLabel);
            this.splitContainer2.Panel2.Controls.Add(this.paginationEnabledCheckBox);
            this.splitContainer2.Panel2.Controls.Add(this.PaginationPanel);
            this.splitContainer2.Panel2.Controls.Add(this.loadDataButton);
            this.splitContainer2.Size = new System.Drawing.Size(1292, 391);
            this.splitContainer2.SplitterDistance = 393;
            this.splitContainer2.TabIndex = 0;
            // 
            // DBServersListBox
            // 
            this.DBServersListBox.ContextMenuStrip = this.DBListContextMenuStrip;
            this.DBServersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DBServersListBox.FormattingEnabled = true;
            this.DBServersListBox.Location = new System.Drawing.Point(0, 0);
            this.DBServersListBox.Name = "DBServersListBox";
            this.DBServersListBox.Size = new System.Drawing.Size(393, 391);
            this.DBServersListBox.TabIndex = 0;
            this.DBServersListBox.Click += new System.EventHandler(this.DBServersListBox_Click);
            this.DBServersListBox.SelectedIndexChanged += new System.EventHandler(this.DBServersListBox_SelectedIndexChanged);
            // 
            // DBListContextMenuStrip
            // 
            this.DBListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.changeToolStripMenuItem});
            this.DBListContextMenuStrip.Name = "DBListContextMenuStrip";
            this.DBListContextMenuStrip.Size = new System.Drawing.Size(175, 114);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveToolStripMenuItem.Text = "Сохранить в файл";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.changeToolStripMenuItem.Text = "Изменить";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // allCountLabel
            // 
            this.allCountLabel.AutoSize = true;
            this.allCountLabel.Location = new System.Drawing.Point(15, 221);
            this.allCountLabel.Name = "allCountLabel";
            this.allCountLabel.Size = new System.Drawing.Size(108, 13);
            this.allCountLabel.TabIndex = 4;
            this.allCountLabel.Text = "Всего элементов: X";
            // 
            // paginationEnabledCheckBox
            // 
            this.paginationEnabledCheckBox.AutoSize = true;
            this.paginationEnabledCheckBox.Location = new System.Drawing.Point(18, 21);
            this.paginationEnabledCheckBox.Name = "paginationEnabledCheckBox";
            this.paginationEnabledCheckBox.Size = new System.Drawing.Size(133, 17);
            this.paginationEnabledCheckBox.TabIndex = 3;
            this.paginationEnabledCheckBox.Text = "Включить пагинацию";
            this.paginationEnabledCheckBox.UseVisualStyleBackColor = true;
            this.paginationEnabledCheckBox.CheckedChanged += new System.EventHandler(this.paginationEnabledCheckBox_CheckedChanged);
            // 
            // PaginationPanel
            // 
            this.PaginationPanel.Controls.Add(this.nextButton);
            this.PaginationPanel.Controls.Add(this.prevButton);
            this.PaginationPanel.Controls.Add(this.label1);
            this.PaginationPanel.Controls.Add(this.elementsCountUpDown);
            this.PaginationPanel.Controls.Add(this.label3);
            this.PaginationPanel.Controls.Add(this.PageTotalLabel);
            this.PaginationPanel.Controls.Add(this.pageNumberUpDown);
            this.PaginationPanel.Enabled = false;
            this.PaginationPanel.Location = new System.Drawing.Point(18, 44);
            this.PaginationPanel.Name = "PaginationPanel";
            this.PaginationPanel.Size = new System.Drawing.Size(287, 112);
            this.PaginationPanel.TabIndex = 1;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.Location = new System.Drawing.Point(211, 73);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(51, 23);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "->";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // prevButton
            // 
            this.prevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevButton.Location = new System.Drawing.Point(154, 73);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(51, 23);
            this.prevButton.TabIndex = 6;
            this.prevButton.Text = "<-";
            this.prevButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "элементов на странице";
            // 
            // elementsCountUpDown
            // 
            this.elementsCountUpDown.Location = new System.Drawing.Point(13, 9);
            this.elementsCountUpDown.Name = "elementsCountUpDown";
            this.elementsCountUpDown.Size = new System.Drawing.Size(96, 20);
            this.elementsCountUpDown.TabIndex = 4;
            this.elementsCountUpDown.ValueChanged += new System.EventHandler(this.elementsCountUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "страница";
            // 
            // PageTotalLabel
            // 
            this.PageTotalLabel.AutoSize = true;
            this.PageTotalLabel.Location = new System.Drawing.Point(80, 78);
            this.PageTotalLabel.Name = "PageTotalLabel";
            this.PageTotalLabel.Size = new System.Drawing.Size(29, 13);
            this.PageTotalLabel.TabIndex = 1;
            this.PageTotalLabel.Text = "из X";
            // 
            // pageNumberUpDown
            // 
            this.pageNumberUpDown.Location = new System.Drawing.Point(46, 40);
            this.pageNumberUpDown.Name = "pageNumberUpDown";
            this.pageNumberUpDown.Size = new System.Drawing.Size(96, 20);
            this.pageNumberUpDown.TabIndex = 0;
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(18, 174);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(155, 23);
            this.loadDataButton.TabIndex = 0;
            this.loadDataButton.Text = "Загрузить данные";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // logsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.logsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.logsDataGridView.AutoGenerateColumns = false;
            this.logsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.typeDataGridViewTextBoxColumn,
            this.headerDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.contentTypeDataGridViewTextBoxColumn,
            this.rowIdDataGridViewTextBoxColumn,
            this.applicationNameDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.channelNameDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn});
            this.logsDataGridView.ContextMenuStrip = this.logsContextMenuStrip;
            this.logsDataGridView.DataSource = this.logViewFormBindingSource;
            this.logsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.logsDataGridView.Name = "logsDataGridView";
            this.logsDataGridView.Size = new System.Drawing.Size(1292, 335);
            this.logsDataGridView.TabIndex = 0;
            this.logsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.logsDataGridView_CellContentClick);
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            // 
            // saveServersListDialog
            // 
            this.saveServersListDialog.DefaultExt = "json";
            this.saveServersListDialog.FileName = "ServersList";
            this.saveServersListDialog.Filter = "Данные JSON|*.json";
            this.saveServersListDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveServersListDialog_FileOk);
            // 
            // openServersListDialog
            // 
            this.openServersListDialog.DefaultExt = "json";
            this.openServersListDialog.FileName = "ServersList";
            this.openServersListDialog.Filter = "Данные JSON|*.json";
            // 
            // logsContextMenuStrip
            // 
            this.logsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watchLogToolStripMenuItem,
            this.changeLogToolStripMenuItem,
            this.deleteLogToolStripMenuItem,
            this.createLogToolStripMenuItem});
            this.logsContextMenuStrip.Name = "logsContextMenuStrip";
            this.logsContextMenuStrip.Size = new System.Drawing.Size(218, 114);
            // 
            // watchLogToolStripMenuItem
            // 
            this.watchLogToolStripMenuItem.Name = "watchLogToolStripMenuItem";
            this.watchLogToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.watchLogToolStripMenuItem.Text = "Посмотреть подробности";
            this.watchLogToolStripMenuItem.Click += new System.EventHandler(this.watchLogToolStripMenuItem_Click);
            // 
            // changeLogToolStripMenuItem
            // 
            this.changeLogToolStripMenuItem.Name = "changeLogToolStripMenuItem";
            this.changeLogToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.changeLogToolStripMenuItem.Text = "Изменить";
            this.changeLogToolStripMenuItem.Click += new System.EventHandler(this.changeLogToolStripMenuItem_Click);
            // 
            // deleteLogToolStripMenuItem
            // 
            this.deleteLogToolStripMenuItem.Name = "deleteLogToolStripMenuItem";
            this.deleteLogToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.deleteLogToolStripMenuItem.Text = "Удалить";
            this.deleteLogToolStripMenuItem.Click += new System.EventHandler(this.deleteLogToolStripMenuItem_Click);
            // 
            // createLogToolStripMenuItem
            // 
            this.createLogToolStripMenuItem.Name = "createLogToolStripMenuItem";
            this.createLogToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.createLogToolStripMenuItem.Text = "Создать";
            this.createLogToolStripMenuItem.Click += new System.EventHandler(this.createLogToolStripMenuItem_Click);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ToolTipText = "Тип лога";
            // 
            // headerDataGridViewTextBoxColumn
            // 
            this.headerDataGridViewTextBoxColumn.DataPropertyName = "Header";
            this.headerDataGridViewTextBoxColumn.HeaderText = "Header";
            this.headerDataGridViewTextBoxColumn.Name = "headerDataGridViewTextBoxColumn";
            this.headerDataGridViewTextBoxColumn.ToolTipText = "Заголовок лога";
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Content";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.ToolTipText = "Содержание лога";
            // 
            // contentTypeDataGridViewTextBoxColumn
            // 
            this.contentTypeDataGridViewTextBoxColumn.DataPropertyName = "ContentType";
            this.contentTypeDataGridViewTextBoxColumn.HeaderText = "ContentType";
            this.contentTypeDataGridViewTextBoxColumn.Name = "contentTypeDataGridViewTextBoxColumn";
            this.contentTypeDataGridViewTextBoxColumn.ToolTipText = "Тип содержимого";
            // 
            // rowIdDataGridViewTextBoxColumn
            // 
            this.rowIdDataGridViewTextBoxColumn.DataPropertyName = "RowId";
            this.rowIdDataGridViewTextBoxColumn.HeaderText = "RowId";
            this.rowIdDataGridViewTextBoxColumn.Name = "rowIdDataGridViewTextBoxColumn";
            this.rowIdDataGridViewTextBoxColumn.ToolTipText = "Идентификатор в БД";
            // 
            // applicationNameDataGridViewTextBoxColumn
            // 
            this.applicationNameDataGridViewTextBoxColumn.DataPropertyName = "ApplicationName";
            this.applicationNameDataGridViewTextBoxColumn.HeaderText = "ApplicationName";
            this.applicationNameDataGridViewTextBoxColumn.Name = "applicationNameDataGridViewTextBoxColumn";
            this.applicationNameDataGridViewTextBoxColumn.ToolTipText = "Имя приложения";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ToolTipText = "Дата создания";
            // 
            // channelNameDataGridViewTextBoxColumn
            // 
            this.channelNameDataGridViewTextBoxColumn.DataPropertyName = "ChannelName";
            this.channelNameDataGridViewTextBoxColumn.HeaderText = "ChannelName";
            this.channelNameDataGridViewTextBoxColumn.Name = "channelNameDataGridViewTextBoxColumn";
            this.channelNameDataGridViewTextBoxColumn.ToolTipText = "Имя канала лога";
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.ToolTipText = "Метка лога";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ToolTipText = "Автор лога";
            // 
            // logViewFormBindingSource
            // 
            this.logViewFormBindingSource.DataMember = "LogItems";
            this.logViewFormBindingSource.DataSource = typeof(AQLogMonitor.LogViewForm);
            // 
            // LogViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 730);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LogViewForm";
            this.Text = "AQLogMonitor";
            this.Load += new System.EventHandler(this.LogViewForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.DBListContextMenuStrip.ResumeLayout(false);
            this.PaginationPanel.ResumeLayout(false);
            this.PaginationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementsCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsDataGridView)).EndInit();
            this.logsContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logViewFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox DBServersListBox;
        private System.Windows.Forms.DataGridView logsDataGridView;
        private System.Windows.Forms.ContextMenuStrip DBListContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveServersListDialog;
        private System.Windows.Forms.OpenFileDialog openServersListDialog;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.Button loadDataButton;
        public System.Windows.Forms.BindingSource logViewFormBindingSource;
        private System.Windows.Forms.Panel PaginationPanel;
        private System.Windows.Forms.CheckBox paginationEnabledCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown elementsCountUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PageTotalLabel;
        private System.Windows.Forms.NumericUpDown pageNumberUpDown;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Label allCountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn channelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip logsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem watchLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createLogToolStripMenuItem;
    }
}

