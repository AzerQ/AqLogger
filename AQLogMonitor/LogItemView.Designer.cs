namespace AQLogMonitor
{
    partial class LogItemView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.addItemsPanel = new System.Windows.Forms.Panel();
            this.applicationNameButton = new System.Windows.Forms.Button();
            this.channelPlusButton = new System.Windows.Forms.Button();
            this.tagPlusButton = new System.Windows.Forms.Button();
            this.dialogButtonsPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tagСomboBox = new System.Windows.Forms.ComboBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeCreated = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logHeaderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logContentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.chanelNameComboBox = new System.Windows.Forms.ComboBox();
            this.appNameComboBox = new System.Windows.Forms.ComboBox();
            this.logTypeComboBox = new System.Windows.Forms.ComboBox();
            this.contentTabControl = new System.Windows.Forms.TabControl();
            this.rawPage = new System.Windows.Forms.TabPage();
            this.logContentControl = new ICSharpCode.TextEditor.TextEditorControl();
            this.visualTabPage = new System.Windows.Forms.TabPage();
            this.previewWebBrowser = new System.Windows.Forms.WebBrowser();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.addItemsPanel.SuspendLayout();
            this.dialogButtonsPanel.SuspendLayout();
            this.contentTabControl.SuspendLayout();
            this.rawPage.SuspendLayout();
            this.visualTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.IDTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.addItemsPanel);
            this.splitContainer1.Panel1.Controls.Add(this.dialogButtonsPanel);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.tagСomboBox);
            this.splitContainer1.Panel1.Controls.Add(this.authorTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimeCreated);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.logHeaderTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.logContentTypeComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.chanelNameComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.appNameComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.logTypeComboBox);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.contentTabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1359, 930);
            this.splitContainer1.SplitterDistance = 593;
            this.splitContainer1.TabIndex = 0;
            // 
            // addItemsPanel
            // 
            this.addItemsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemsPanel.Controls.Add(this.applicationNameButton);
            this.addItemsPanel.Controls.Add(this.channelPlusButton);
            this.addItemsPanel.Controls.Add(this.tagPlusButton);
            this.addItemsPanel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addItemsPanel.Location = new System.Drawing.Point(446, 364);
            this.addItemsPanel.Name = "addItemsPanel";
            this.addItemsPanel.Size = new System.Drawing.Size(54, 404);
            this.addItemsPanel.TabIndex = 36;
            // 
            // applicationNameButton
            // 
            this.applicationNameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.applicationNameButton.Location = new System.Drawing.Point(8, 24);
            this.applicationNameButton.Name = "applicationNameButton";
            this.applicationNameButton.Size = new System.Drawing.Size(43, 23);
            this.applicationNameButton.TabIndex = 34;
            this.applicationNameButton.Text = "+";
            this.applicationNameButton.UseVisualStyleBackColor = true;
            this.applicationNameButton.Click += new System.EventHandler(this.applicationNameButton_Click);
            // 
            // channelPlusButton
            // 
            this.channelPlusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.channelPlusButton.Location = new System.Drawing.Point(8, 178);
            this.channelPlusButton.Name = "channelPlusButton";
            this.channelPlusButton.Size = new System.Drawing.Size(43, 23);
            this.channelPlusButton.TabIndex = 33;
            this.channelPlusButton.Text = "+";
            this.channelPlusButton.UseVisualStyleBackColor = true;
            this.channelPlusButton.Click += new System.EventHandler(this.applicationNameButton_Click);
            // 
            // tagPlusButton
            // 
            this.tagPlusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tagPlusButton.Location = new System.Drawing.Point(8, 357);
            this.tagPlusButton.Name = "tagPlusButton";
            this.tagPlusButton.Size = new System.Drawing.Size(43, 23);
            this.tagPlusButton.TabIndex = 32;
            this.tagPlusButton.Text = "+";
            this.tagPlusButton.UseVisualStyleBackColor = true;
            this.tagPlusButton.Click += new System.EventHandler(this.applicationNameButton_Click);
            // 
            // dialogButtonsPanel
            // 
            this.dialogButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogButtonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dialogButtonsPanel.Controls.Add(this.cancelButton);
            this.dialogButtonsPanel.Controls.Add(this.saveButton);
            this.dialogButtonsPanel.Location = new System.Drawing.Point(105, 790);
            this.dialogButtonsPanel.Name = "dialogButtonsPanel";
            this.dialogButtonsPanel.Size = new System.Drawing.Size(317, 77);
            this.dialogButtonsPanel.TabIndex = 31;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.AutoEllipsis = true;
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.cancelButton.Location = new System.Drawing.Point(183, 12);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 48);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveButton.Location = new System.Drawing.Point(12, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(113, 48);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(102, 695);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Тэг";
            // 
            // tagСomboBox
            // 
            this.tagСomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagСomboBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tagСomboBox.FormattingEnabled = true;
            this.tagСomboBox.Location = new System.Drawing.Point(105, 721);
            this.tagСomboBox.Name = "tagСomboBox";
            this.tagСomboBox.Size = new System.Drawing.Size(320, 26);
            this.tagСomboBox.TabIndex = 27;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorTextBox.Location = new System.Drawing.Point(102, 628);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(320, 25);
            this.authorTextBox.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(102, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Автор";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(99, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Имя канала";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(99, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Дата создания";
            // 
            // dateTimeCreated
            // 
            this.dateTimeCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeCreated.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimeCreated.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeCreated.Location = new System.Drawing.Point(102, 469);
            this.dateTimeCreated.Name = "dateTimeCreated";
            this.dateTimeCreated.Size = new System.Drawing.Size(320, 25);
            this.dateTimeCreated.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(99, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Приложение";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(99, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Идентификатор в базе";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDTextBox.Location = new System.Drawing.Point(102, 93);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(320, 25);
            this.IDTextBox.TabIndex = 19;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(99, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Тип содержимого";
            // 
            // logHeaderTextBox
            // 
            this.logHeaderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logHeaderTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logHeaderTextBox.Location = new System.Drawing.Point(102, 239);
            this.logHeaderTextBox.Name = "logHeaderTextBox";
            this.logHeaderTextBox.Size = new System.Drawing.Size(320, 25);
            this.logHeaderTextBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(99, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Заголовок лога";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(99, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Тип лога";
            // 
            // logContentTypeComboBox
            // 
            this.logContentTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logContentTypeComboBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logContentTypeComboBox.FormattingEnabled = true;
            this.logContentTypeComboBox.Location = new System.Drawing.Point(102, 309);
            this.logContentTypeComboBox.Name = "logContentTypeComboBox";
            this.logContentTypeComboBox.Size = new System.Drawing.Size(320, 26);
            this.logContentTypeComboBox.TabIndex = 14;
            this.logContentTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.logContentTypeComboBox_SelectedIndexChanged);
            // 
            // chanelNameComboBox
            // 
            this.chanelNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chanelNameComboBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chanelNameComboBox.FormattingEnabled = true;
            this.chanelNameComboBox.Location = new System.Drawing.Point(102, 544);
            this.chanelNameComboBox.Name = "chanelNameComboBox";
            this.chanelNameComboBox.Size = new System.Drawing.Size(320, 26);
            this.chanelNameComboBox.TabIndex = 12;
            // 
            // appNameComboBox
            // 
            this.appNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appNameComboBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appNameComboBox.FormattingEnabled = true;
            this.appNameComboBox.Location = new System.Drawing.Point(102, 390);
            this.appNameComboBox.Name = "appNameComboBox";
            this.appNameComboBox.Size = new System.Drawing.Size(320, 26);
            this.appNameComboBox.TabIndex = 11;
            // 
            // logTypeComboBox
            // 
            this.logTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTypeComboBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logTypeComboBox.FormattingEnabled = true;
            this.logTypeComboBox.Location = new System.Drawing.Point(102, 169);
            this.logTypeComboBox.Name = "logTypeComboBox";
            this.logTypeComboBox.Size = new System.Drawing.Size(320, 26);
            this.logTypeComboBox.TabIndex = 9;
            // 
            // contentTabControl
            // 
            this.contentTabControl.Controls.Add(this.rawPage);
            this.contentTabControl.Controls.Add(this.visualTabPage);
            this.contentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTabControl.Location = new System.Drawing.Point(0, 0);
            this.contentTabControl.Name = "contentTabControl";
            this.contentTabControl.SelectedIndex = 0;
            this.contentTabControl.Size = new System.Drawing.Size(762, 930);
            this.contentTabControl.TabIndex = 2;
            this.contentTabControl.SelectedIndexChanged += new System.EventHandler(this.contentTabControl_SelectedIndexChanged);
            this.contentTabControl.TabIndexChanged += new System.EventHandler(this.contentTabControl_TabIndexChanged);
            // 
            // rawPage
            // 
            this.rawPage.Controls.Add(this.logContentControl);
            this.rawPage.Location = new System.Drawing.Point(4, 22);
            this.rawPage.Name = "rawPage";
            this.rawPage.Padding = new System.Windows.Forms.Padding(3);
            this.rawPage.Size = new System.Drawing.Size(754, 904);
            this.rawPage.TabIndex = 0;
            this.rawPage.Text = "Исходный вид";
            this.rawPage.UseVisualStyleBackColor = true;
            // 
            // logContentControl
            // 
            this.logContentControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logContentControl.IsReadOnly = false;
            this.logContentControl.Location = new System.Drawing.Point(3, 3);
            this.logContentControl.Name = "logContentControl";
            this.logContentControl.ShowVRuler = false;
            this.logContentControl.Size = new System.Drawing.Size(748, 898);
            this.logContentControl.TabIndex = 2;
            // 
            // visualTabPage
            // 
            this.visualTabPage.Controls.Add(this.previewWebBrowser);
            this.visualTabPage.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visualTabPage.Location = new System.Drawing.Point(4, 22);
            this.visualTabPage.Name = "visualTabPage";
            this.visualTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.visualTabPage.Size = new System.Drawing.Size(656, 862);
            this.visualTabPage.TabIndex = 1;
            this.visualTabPage.Text = "Визуализация";
            this.visualTabPage.UseVisualStyleBackColor = true;
            // 
            // previewWebBrowser
            // 
            this.previewWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.previewWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewWebBrowser.Name = "previewWebBrowser";
            this.previewWebBrowser.Size = new System.Drawing.Size(650, 856);
            this.previewWebBrowser.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(650, 856);
            this.webBrowser1.TabIndex = 0;
            // 
            // LogItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 930);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LogItemView";
            this.Text = "LogItemView";
            this.Load += new System.EventHandler(this.LogItemView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.addItemsPanel.ResumeLayout(false);
            this.dialogButtonsPanel.ResumeLayout(false);
            this.contentTabControl.ResumeLayout(false);
            this.rawPage.ResumeLayout(false);
            this.visualTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeCreated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox logHeaderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox logContentTypeComboBox;
        private System.Windows.Forms.ComboBox chanelNameComboBox;
        private System.Windows.Forms.ComboBox appNameComboBox;
        private System.Windows.Forms.ComboBox logTypeComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tagСomboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel dialogButtonsPanel;
        private System.Windows.Forms.Button tagPlusButton;
        private System.Windows.Forms.Button channelPlusButton;
        private System.Windows.Forms.Button applicationNameButton;
        private System.Windows.Forms.TabControl contentTabControl;
        private System.Windows.Forms.TabPage rawPage;
        private ICSharpCode.TextEditor.TextEditorControl logContentControl;
        private System.Windows.Forms.TabPage visualTabPage;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser previewWebBrowser;
        private System.Windows.Forms.Panel addItemsPanel;
    }
}