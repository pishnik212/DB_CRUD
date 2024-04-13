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
    public partial class AddForm : Form
    {
        string connectionString;
        UC_TableView tableView;
        DB db;
        string tableName;
        WarningMessage wm = new WarningMessage();
        InputCheck ic;
        public AddForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Форма для лобавления поля в таблицу
        /// </summary>
        /// <param name="connectionString"> Стркоа соединения </param>
        /// <param name="tableView"> Пользовательский элемент для просмотра таблицы </param>
        /// <param name="tableName"> Имя таблицы </param>
        public AddForm(string connectionString, UC_TableView tableView, string tableName)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.db = new DB(connectionString);
            this.tableView = tableView;
            this.tableName = tableName;
            this.ic = new InputCheck(connectionString);
        }

        /// <summary>
        /// Проверка ПК на корректность
        /// </summary>
        public bool IsCorrectPK(bool check)
        {
            int count = db.CountPK(tableName);                          // Подсчет количества ПК в таблице 
            bool isBasePK = db.IsBasePK(tableName, TB_PK.Text);         // Является ли выбранное поле ПК в текущей таблице
            if (check == true && isBasePK == false) { count += 1; }
            else if (count == 0) { count += 1; }
            else if (check == false && isBasePK == true) { count -= 1; }

            if (count > 1)
            {
                DialogResult result = MessageBox.Show("" +
                    "В таблице должен быть только один первичный ключ." +
                    "Заменить текущий ключ на выбранный?" +
                    "?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    return InternalChangePK();
                }
                this.Close();
            }
            else if (count == 1)
            {
                return BaseFieldUpdate();
            }
            return false;
        }
        /// <summary>
        /// Изменение первичного ключа в таблице
        /// </summary>
        public bool InternalChangePK()
        {
            // SQL запрос для изменения ПК
            bool operationRes = db.ChangePK(tableName, TB_PK.Text, CB_PKType.SelectedItem.ToString());

            if (operationRes)
            {
                // Обновление формы
                this.Controls.Clear();
                tableView.UpdateTableView(tableName);
                this.Close();
                return true;
            }
            else { return false; }
        }
        /// <summary>
        /// Добавление нового поля в таблицу
        /// </summary>
        private void BTN_AddField_Click(object sender, EventArgs e)
        {
            if (IsFillNames() && ic.IsFillSelectedItem(CB_PKType) && IsUniqueField() && ic.IsCorrectString(TB_PK.Text))

            {
                bool insertRes = IsCorrectPK(CB_CheckPK.Checked);
                if (insertRes)
                {
                    this.Controls.Clear();
                    tableView.Refresh();
                    tableView.UpdateTableView(tableName);
                    this.Close();
                }
            }
            else if (!ic.IsFillSelectedItem(CB_PKType)) { CB_PKType.SelectedItem = "TEXT"; }
            else if (!ic.IsCorrectString(TB_PK.Text)) { wm.IncorrectData(); }
            else if (!IsUniqueField()) { wm.ExistField(); }

        }
        /// <summary>
        /// Добавление нового поля и сохранение изменений в форме
        /// </summary>
        public bool BaseFieldUpdate()
        {
            bool operationRes = db.AddField(tableName, TB_PK.Text, CB_PKType.SelectedItem.ToString());
            return SaveChanges(operationRes);
        }
        /// <summary>
        /// Обновление формы после внесения изменений
        /// </summary>
        /// <param name="result"> Результат выполнения SQL запроса (bool) </param>
        public bool SaveChanges(bool result)
        {
            // В случае успешной SQL операции
            if (result)
            {
                // Обновление формы с таблицей 
                this.Controls.Clear();
                tableView.Refresh();
                tableView.UpdateTableView(tableName);

                // Закрытие окна редактирования поля
                this.Close();
                return true;
            }
            // В случае неуспешной SQL операции
            else { return false; }
        }
        /// <summary>
        /// Проверка введенных пользователем значений на непустоту
        /// </summary>
        /// <returns></returns>
        public bool IsFillNames()
        {
            if (TB_PK.Text != null
                && TB_PK.Text != ""
                && CB_PKType.SelectedItem != null
                && tableName != null)
            { return true; }
            else return false;

        }
        /// <summary>
        /// Проверка поля на уникальность
        /// </summary>
        public bool IsUniqueField()
        {
            string newField = TB_PK.Text;

            // SQL запрос на существование поля с указанным именем
            bool exist = db.IsFieldExist(tableName, newField);
            if (exist) { return false; }
            else { return true; }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
