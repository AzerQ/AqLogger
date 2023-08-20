using AzerQLoggerLib;
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
    public partial class AddNewLogServer : Form
    {
        public AddNewLogServer(DBRecord record) : this()
        {
            DBConnectInfo = record;
            LoadValues();
        }

        public AddNewLogServer()
        {
            InitializeComponent();
            DBConnectInfo = new DBRecord()
            {
                TableName = "",
                ConnectInfo = new ServerCreditionals()
            };
            
            
        }

       public void LoadValues()
        {
            servernameTextBox.Text = DBConnectInfo.ConnectInfo.ServerName;
            loginTextBox.Text = DBConnectInfo.ConnectInfo.UserName;
            passwordTextBox.Text = DBConnectInfo.ConnectInfo.Password;
            DBNameTextBox.Text = DBConnectInfo.ConnectInfo.AdditionalInfo;
            DBTableNameTextBox.Text = DBConnectInfo.TableName;

        }

        /// <summary>
        /// Соединение  с БД
        /// </summary>
        public DBRecord DBConnectInfo { get; set; }
        private void OKButton_Click(object sender, EventArgs e)
        {

            DBConnectInfo.ConnectInfo = new ServerCreditionals(servernameTextBox.Text, loginTextBox.Text, passwordTextBox.Text, DBNameTextBox.Text);
                DBConnectInfo.TableName = DBTableNameTextBox.Text;
            
           
       }
        
    }
}
/// <summary>
/// Запись о базе данных
/// </summary>
public class DBRecord
{
    /// <summary>
    /// Информация о подключении
    /// </summary>
    public ServerCreditionals ConnectInfo;
    /// <summary>
    /// Имя таблицы
    /// </summary>
    public string TableName;
    public override string ToString()
    {
        return $"[{ConnectInfo.ServerName}; {ConnectInfo.AdditionalInfo}; {TableName}]";
    }
}
