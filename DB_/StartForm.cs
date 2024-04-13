using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_
{
    public partial class StartForm : Form
    {
        string dbName;
        DB db;
        string ConnectionString;
        WarningMessage wm = new WarningMessage();

        /// <summary>
        /// Стартовая форма для подключения к базе данных
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Установка соединения на основе введенных данных
        /// </summary>
        private void BTN_Connect_Click(object sender, EventArgs e)
        {
            dbName = TB_DataBaseName.Text;              // Имя базы данных
            string server = TB_Server.Text;             // Наименование сервера
            string port = TB_port.Text;                 // Порт
            string username = TB_username.Text;         // Имя пользователя
            string password = TB_password.Text;         // Пароль

            // Строка подключения к БД
            ConnectionString = String.Format("Server={0};port={1};username={2};password={3};database={4}",
                                                server,
                                                port,
                                                username,
                                                password,
                                                dbName);

            DataTable dtgetdata = new DataTable();

            // Проверка введенных значений на пустоту
            if (dbName != "" && server != "" && port != "" && username != "" && password != "")
            {
                try
                {
                    // Установка соединения с БД
                    DB db = new DB(ConnectionString);

                    // Запрос к БД на нахождение указанной таблицы
                    dtgetdata = db.getData("SELECT table_name" +
                                        " FROM information_schema.tables" +
                                        " WHERE table_schema = 'public' ;");

                    // В случае обнаружения указанной таблицы 
                    if (dtgetdata != null)
                    {
                        MainForm mf = new MainForm(ConnectionString);
                        this.Hide();
                        mf.Show();
                    }

                    // В остальных случаях
                    else { wm.IncorrectData(); }
                }
                catch (Exception ex) { wm.Error(); }
            }
            else { wm.NullString(); }
        }

        /// <summary>
        /// Заполнение полей дефолтными значениями
        /// </summary>
        private void BTN_Default_Click(object sender, EventArgs e)
        {
            dbName = TB_DataBaseName.Text;
            TB_Server.Text = "localhost";
            TB_port.Text = "5432";
            TB_username.Text = "postgres";
            TB_password.Text = "rootroot";
        }
        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void LBL_Connection_Click(object sender, EventArgs e)
        {

        }


    }
}
