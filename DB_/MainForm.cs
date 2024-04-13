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
    public partial class MainForm : Form
    {
        string ConnectionString;
        DB db;
        DataTable tableNames;
        string tableName;
        MainForm mainform;

        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Основная форма для работы с БД
        /// </summary>
        /// <param name="ConnectionString"> Строка подключения к БД </param>
        public MainForm(string ConnectionString)
        {
            InitializeComponent();
            this.mainform = this;
            this.ConnectionString = ConnectionString;
            this.db = new DB(ConnectionString);
            this.tableNames = db.getData("SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' ;");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // В случае наличия таблиц в БД
            if (CheckTablesCount())
            {
                // Форматирование DataGridView для отображения таюлиц выбранной БД
                dgData.DataSource = tableNames;
                dgData.Columns[0].HeaderText = "Таблицы";
                dgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgData.AllowUserToAddRows = false;
                dgData.Height = dgData.Rows.GetRowsHeight(DataGridViewElementStates.Visible) +
                           dgData.ColumnHeadersHeight;
            }

            // В случае пустой БД
            else
            {
                LBL_TablesList.Text = "В базе данных нет ни одной таблицы.";
                dgData.Visible = false;
            }
        }

        /// <summary>
        /// Подсчет количества таблиц в БД
        /// </summary>
        public bool CheckTablesCount()
        {
            if (tableNames.Rows.Count > 0) { return true; }
            else return false;
        }

        /// <summary>
        /// Возврат на форму выбора подключения к БД
        /// </summary>
        private void BTN_ToStartForm_Click(object sender, EventArgs e)
        {
            StartForm st = new StartForm();
            this.Close();
            st.Show();
        }

        /// <summary>
        /// Открытие формы для добавления таблицы
        /// </summary>
        private void BTN_AddTable_Click(object sender, EventArgs e)
        {
            FLP_Right.Controls.Clear();
            UC_CreateTable ct = new UC_CreateTable(ConnectionString, mainform);
            FLP_Right.Controls.Add(ct);
        }

        /// <summary>
        /// Открытие элемента для просмотра таблицы (путем двойного щелчка по строке)
        /// </summary>
        private void dgData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Выбор имени таблицы для просмотра
                tableName = dgData[e.ColumnIndex, e.RowIndex].Value.ToString();

                // Открытие формы для просмотра
                UC_TableView tv = new UC_TableView(ConnectionString, tableName, this);
                FLP_Right.Controls.Clear();
                FLP_Right.Controls.Add(tv);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        /// <summary>
        /// Обновление основной формы
        /// </summary>
        public void UpdateMainForm()
        {
            MainForm mf = new MainForm(ConnectionString);
            this.Hide();
            mf.Show();

            // Запрос SQL для просмотра всех таблиц БД
            dgData.DataSource = db.getData("SELECT table_name" +
                                            " FROM information_schema.tables" +
                                            " WHERE table_schema = 'public' ;");

            // Форматирование внешнего вида отображающихся таблиц
            dgData.Height = dgData.Rows.GetRowsHeight(DataGridViewElementStates.Visible) +
                           dgData.ColumnHeadersHeight;
        }

        private void f(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
