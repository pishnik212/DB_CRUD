using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_
{
    public class InputCheck
    {
        DB db;
        /// <summary>
        /// Класс для проверок
        /// </summary>
        /// <param name="connectionString"> Строка подключения </param>
        public InputCheck(string connectionString)
        {
            this.db = new DB(connectionString);
        }

        /// <summary>
        /// Проверка названия таблицы и поля на корректность
        /// </summary>
        /// <param name="tableName"> Имя таблицы </param>
        /// <param name="someField"> Имя поля </param>
        /// <returns></returns>
        public bool IsCorrect(string tableName, string someField)
        {
            if (IsCorrectString(tableName)
                && IsCorrectString(someField))
            { return true; }
            else { return false; }
        }
        /// <summary>
        /// Проверка строки на корректность
        /// </summary>
        /// <param name="stringToCheck"></param>
        /// <returns></returns>
        public bool IsCorrectString(string stringToCheck)
        {
            if (stringToCheck.Length <= 30
                && stringToCheck.Length >= 1
                && Regex.IsMatch(stringToCheck, "^[a-zA-Z0-9]*$")
                && Char.IsLetter(stringToCheck[0])
                )
            { return true; }
            else { return false; }
        }

        /// <summary>
        /// Проверка названия таблицы на уникальность
        /// </summary>
        /// <param name="tableName"> Имя таблицы </param>
        public bool IsUnique(string tableName)
        {
            // Запрос на проверку существования таблицы с указанным именем
            bool isExist = Convert.ToBoolean(
                            db.getData(
                            String.Format(
                            "SELECT EXISTS (SELECT * FROM pg_tables WHERE tablename = '{0}' AND schemaname = 'public');",
                            tableName)).Rows[0][0]);
            if (isExist) { return false; }
            else { return true; }
        }

        /// <summary>
        /// Проверка 3 строк на заполненность 
        /// </summary>
        public bool IsFillNames(string someField1, string someField2, string someField3)
        {
            if (someField1 != null && someField2 != null && someField3 != null &&
                someField1 != "" && someField2 != "" && someField3 != "")
            { return true; }
            else return false;

        }
        /// <summary>
        /// Проверка ComboBox на выбранное значение
        /// </summary>
        /// <param name="cb"> Комбобокс</param>
        /// <returns></returns>
        public bool IsFillSelectedItem(ComboBox cb)
        {
            if (cb.SelectedItem == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
