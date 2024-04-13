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
    public partial class ChangeTableNameForm : Form
    {
        string tableName;
        DB db;
        string newTableName;
        UC_TableView tableView;
        string connectionString;
        WarningMessage wm = new WarningMessage();
        MainForm mainForm;
        InputCheck ic;
        public ChangeTableNameForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Форма для ввода нового имени таблицы
        /// </summary>
        /// <param name="mf"> Основная форма </param>
        /// <param name="tableView"> Пользовательский элемент просотра таблиц</param>
        /// <param name="connectionString"> Строка соединения </param>
        /// <param name="tableName"> Имя таблицы</param>
        public ChangeTableNameForm(MainForm mf, UC_TableView tableView, string connectionString, string tableName)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.db = new DB(connectionString);
            this.tableView = tableView;
            this.connectionString = connectionString;
            this.mainForm = mf;
            ic = new InputCheck(connectionString);
        }
        /// <summary>
        /// Обновление имени таблицы
        /// </summary>
        private void BTN_ChangeTableName_Click(object sender, EventArgs e)
        {
            this.newTableName = TB_NewTableName.Text;

            // В случае заполненого и неповторяющегося поля 
            if (IsFillNames() && IsUnique(newTableName) && ic.IsCorrectString(newTableName))
            {
                // Выполнение запроса с БД
                db.UpdateTableName(tableName, newTableName);
                tableName = newTableName;

                // Обновление формы просмотра таблиц
                tableView.UpdateTableView(newTableName);
                mainForm.Close();
                MainForm mf = new MainForm(connectionString);
                this.Hide();
                mf.Show();
            }
            else if (!ic.IsCorrectString(newTableName)) { wm.IncorrectData(); }
            else if (!IsUnique(newTableName)) { wm.ExistTable(); }
            else if (!IsFillNames()) { wm.NullString(); }
        }

        private void ChangeTableNameForm_Load(object sender, EventArgs e)
        {
            TB_NewTableName.Text = tableName;
        }
        /// <summary>
        /// Проверка введенных значений на заполненность (непустоту)
        /// </summary>
        public bool IsFillNames()
        {
            // В случае если новое имя таблицы не пустое
            if (TB_NewTableName.Text != null && TB_NewTableName.Text != "")
            { return true; }

            // В остальных случаях
            else return false;

        }

        /// <summary>
        /// Проверка указанного имени таблицы на уникальность
        /// </summary>
        /// <param name="tableName"> Новое имя таблицы</param>
        public bool IsUnique(string tableName)
        {
            // Проверка SQL запросом на существование таблицы с указанным именем в БД
            bool isExist = Convert.ToBoolean(
                            db.getData(
                            String.Format(
                            "SELECT EXISTS (SELECT * FROM pg_tables WHERE tablename = '{0}' AND schemaname = 'public');",
                            tableName)).Rows[0][0]);

            if (isExist) { return false; }
            else { return true; }
        }
    }
}
