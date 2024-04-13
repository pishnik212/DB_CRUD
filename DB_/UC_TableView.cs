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
    public partial class UC_TableView : UserControl
    {
        string connectionString;
        DB db;
        string tableName;
        MainForm mainForm;
        WarningMessage wm = new WarningMessage();

        public UC_TableView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Пользовательский элемент управления для просмотра выбранной таблицы
        /// </summary>
        /// <param name="connectionString"> Строка соединения</param>
        /// <param name="tableName"> Имя таблицы</param>
        /// <param name="mainForm"> Главная форма (меню) </param>
        public UC_TableView(string connectionString, string tableName, MainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.db = new DB(connectionString);
            this.tableName = tableName;
            this.mainForm = mainForm;
        }

        private void UC_TableView_Load(object sender, EventArgs e)
        {
            LBL_TableName.Text = tableName;
            DataTable dtgetdata = new DataTable();

            // SQL запрос для получения всех данных о полях выбранной таблицы
            dtgetdata = db.getData(String.Format("SELECT * FROM {0};", this.tableName));

            dgTable.DataSource = dtgetdata;
            dgTable.AllowUserToAddRows = false;
            dgTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTable.Height = dgTable.Rows.GetRowsHeight(DataGridViewElementStates.Visible) +
                       dgTable.ColumnHeadersHeight;
            try
            {
                // Сокрытие столбца идентификатора при отображении DataGridView пользователю
                dgTable.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        /// <summary>
        /// Открытие формы для добавления поля в таблицу
        /// </summary>
        private void BTN_AddField_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm(connectionString, this, tableName);
            af.Show();
        }

        /// <summary>
        /// Обновление поля просмотра таблицы 
        /// </summary>
        /// <param name="paramTableName">Имя таблицы</param>
        public void UpdateTableView(string paramTableName)
        {
            this.Refresh();
            dgTable.DataSource = db.getData(String.Format("SELECT * FROM {0};", paramTableName));
            dgTable.Height = dgTable.Rows.GetRowsHeight(DataGridViewElementStates.Visible) +
                           dgTable.ColumnHeadersHeight;
        }

        /// <summary>
        /// Удаление таблицы
        /// </summary>
        private void BTN_DeleteTable_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить таблицу?",
                                                    "Confirmation",
                                                    MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                // Результат выполнения SQL запроса
                bool operationRes = db.DeleteTable(tableName);
                if (operationRes)
                {
                    this.Controls.Clear();
                    mainForm.UpdateMainForm();
                }
            }
        }

        /// <summary>
        /// Закрытие поля просмотра таблицы
        /// </summary>
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }

        /// <summary>
        /// Просмотр поля таблицы после двойного щелчка по строке таблицы
        /// </summary>
        private void dgTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgTable["column_name_", e.RowIndex].Value.ToString();
            UpdateForm uf = new UpdateForm(connectionString, this, tableName, columnName);
            uf.Show();
        }

        /// <summary>
        /// Изменение имени таблицы
        /// </summary>
        private void BTN_ChangeTableName_Click(object sender, EventArgs e)
        {
            ChangeTableNameForm ctn = new ChangeTableNameForm(this.mainForm, this, connectionString, tableName);
            ctn.Show();
        }
    }
}
