using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_
{
    public partial class UC_CreateTable : UserControl
    {
        string connectionString;
        MainForm mainForm;
        DB db;
        WarningMessage wm = new WarningMessage();
        InputCheck ic;
        public UC_CreateTable()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Пользовтаельский элемент управления для создания таблицы
        /// </summary>
        /// <param name="connectionString"> Строка соединения</param>
        /// <param name="mainForm"> Главная форма (меню) </param>
        public UC_CreateTable(string connectionString, MainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.db = new DB(connectionString);
            this.mainForm = mainForm;
            this.ic = new InputCheck(connectionString);
        }

        private void UC_CreateTable_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Подтверждение создания таблицы
        /// </summary>
        private void BTN_CreateTable_Click(object sender, EventArgs e)
        {
            string tableName = TB_TableName.Text.ToString();

            if (tableName != ""
                && ic.IsFillSelectedItem(CB_PKType)
                && ic.IsFillNames(TB_PK.Text, CB_PKType.SelectedItem.ToString(), TB_TableName.Text)
                && ic.IsUnique(tableName)
                && ic.IsCorrect(tableName, TB_PK.Text))
            {

                // Результаты выполнения SQL запросов
                bool operationRes = db.CreateTable(tableName);
                bool insertRes = db.InsertTable(tableName, TB_PK.Text, CB_PKType.SelectedItem.ToString(), true);

                // В случае успешного выполнения
                if (operationRes && insertRes)
                {
                    this.Controls.Clear();
                    mainForm.Refresh();
                    mainForm.UpdateMainForm();
                }
            }
            else if (!ic.IsFillSelectedItem(CB_PKType)) { CB_PKType.SelectedItem = "TEXT"; }
            else if (!ic.IsFillNames(TB_PK.Text, CB_PKType.SelectedItem.ToString(), TB_TableName.Text)) { wm.NullString(); }
            else if (!ic.IsUnique(tableName)) { wm.ExistTable(); }
            else if (!ic.IsCorrect(tableName, TB_PK.Text)) { wm.IncorrectData(); }

        }
        /// <summary>
        /// Кнопка закрытия формы создания таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }
    }
}
