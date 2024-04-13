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
    public partial class UpdateForm : Form
    {
        string connectionString;
        UC_TableView tableView;
        DB db;
        string columnName;
        string tableName;
        int id;
        string type;
        string isPK;
        bool isPK_new;
        WarningMessage wm = new WarningMessage();
        InputCheck ic;


        /// <summary>
        /// Форма для обновления поля таблицы
        /// </summary>
        public UpdateForm()
        {
            InitializeComponent();
        }
        public UpdateForm(string connectionString, UC_TableView tableView, string tableName, string columnName)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.db = new DB(connectionString);
            this.tableView = tableView;
            this.tableName = tableName;
            this.columnName = columnName;
            this.ic = new InputCheck(connectionString);
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Отображение имени поля таблицы
                TB_PK.Text = columnName;

                // Получение идентификатора выбранного поля
                string q1 = String.Format("SELECT id FROM {0} WHERE column_name_ = '{1}';", this.tableName, columnName);
                this.id = Convert.ToInt32(db.getData(q1).Rows[0][0]);

                // Получение типа выбранного поля
                string q2 = String.Format("SELECT type_ FROM {0} WHERE id = {1};", tableName, id);
                this.type = db.getData(q2).Rows[0][0].ToString();
                CB_PKType.Text = type;

                // Получение значения является ли выбранное поле первичным ключом таблицы
                string q3 = String.Format("SELECT isPK FROM {0} WHERE id = {1};", tableName, id);
                this.isPK = db.getData(q3).Rows[0][0].ToString();

                string q4 = String.Format("SELECT isPK FROM {0} WHERE id = {1};", tableName, id);
                this.isPK_new = Convert.ToBoolean(db.getData(q4).Rows[0][0]);
                CB_CheckPK.Checked = isPK_new;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // wm.Exit();
            }
        }
        /// <summary>
        /// Проверка сохранения первичного ключа таблицы после изменений
        /// </summary>
        public bool IsCorrectPK(bool check)
        {
            // Количество первичных ключей таблицы в текущий момент 
            int count = db.CountPK(tableName);

            // Проверка является ли выбранное поле первичным ключом таблицы в базе
            bool isBasePK = db.IsBasePK(tableName, TB_PK.Text);

            // Увеличение количества первичных ключей таблицы
            if (check == true && isBasePK == false) { count += 1; }

            // Уменьшение количества ключей в таблице
            else if (check == false && isBasePK == true) { count -= 1; }

            if (count > 1)
            {
                DialogResult result = MessageBox.Show("" +
                    "В таблице должен быть только один первичный ключ." +
                    "Заменить текущий ключ на выбранный?" +
                    "?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    // Смена первичного ключа в таблице в случае согласия пользователя
                    return InternalChangePK();
                }
            }
            else if (count == 1) { return BaseFieldUpdate(); }
            else if (count == 0) { wm.NotOnePK(); return false; }
            return false;
        }
        /// <summary>
        /// Замена первичного ключа таблицы
        /// </summary>
        public bool InternalChangePK()
        {
            bool operationRes = db.UpdatePKField(id, tableName, TB_PK.Text, CB_PKType.SelectedItem.ToString());
            return SaveChanges(operationRes);
        }
        /// <summary>
        /// Обновление поля таблицы
        /// </summary>
        public bool BaseFieldUpdate()
        {
            bool operationRes = db.UpdateField(tableName, id, TB_PK.Text, CB_PKType.SelectedItem.ToString(), CB_CheckPK.Checked);
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
        ///  Проверка измененного поля таблицы на уникальность
        /// </summary>
        /// <param name="columnName"> Имя поля таблицы</param>
        public bool IsUniqueField(string columnName)
        {
            string newField = TB_PK.Text;
            bool exist = db.IsFieldExist(tableName, newField);
            if (exist && columnName == TB_PK.Text) { return true; }
            else if (exist) { return false; }
            else { return true; }
        }

        /// <summary>
        /// Подтверждение действия обновления поля
        /// </summary>
        private void BTN_SaveChanges_Click(object sender, EventArgs e)
        {
            // Проверка на пустые значения и уникальность вводимых строк 
            if (ic.IsFillNames(TB_PK.Text, CB_PKType.SelectedItem.ToString(), tableName)
                && IsUniqueField(columnName)
                && ic.IsCorrectString(TB_PK.Text))
            {
                columnName = TB_PK.Text;
                type = CB_PKType.Text;

                // Результат проверки на сохранение единственного ПК
                bool updateRes = IsCorrectPK(CB_CheckPK.Checked);

                // Результат сохранения изменений
                bool res = SaveChanges(updateRes);
            }
            // В случае наличия пустых значений
            else if (!ic.IsFillNames(TB_PK.Text, CB_PKType.SelectedItem.ToString(), tableName))
            { wm.NullString(); }

            // В случае существования указанного поля
            else if (!IsUniqueField(columnName)) { wm.ExistField(); }


            // В случае указания некорректных данных
            else if (!ic.IsCorrectString(columnName)) { wm.IncorrectData(); }

            // В остальных случаях
            else wm.Error();
        }


        /// <summary>
        /// Удаление выбранного поля
        /// </summary>
        private void BTN_DeleteField_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить поле?",
                                "Confirmation",
                                MessageBoxButtons.YesNoCancel);

            // В случае согласия пользователя и поле - не первичный ключ
            if (result == DialogResult.Yes && !db.IsBasePK(tableName, columnName))
            {
                // Результат выполнения SQL запроса удаления
                bool operationRes = db.DeleteField(id, tableName);

                if (operationRes)
                {
                    this.Controls.Clear();
                    tableView.UpdateTableView(tableName);
                    this.Close();
                }
            }
            // В случае если выбранное поле - первичный ключ
            else if (db.IsBasePK(tableName, columnName)) { wm.IsPKField(); }

            // В остальных случаях
            else { this.Close(); }
        }
    }
}
