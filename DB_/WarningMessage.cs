using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_
{
    /// <summary>
    /// Класс для вывода сообщений с возникающими предупреждениями и ошибками
    /// </summary>
    public class WarningMessage
    {
        /// <summary>
        /// Наличие пустых значений
        /// </summary>
        public void NullString()
        {
            MessageBox.Show("Заполните пустые значения!");
        }

        /// <summary>
        /// Наличие неверных значений введенных пользователем
        /// </summary>
        public void IncorrectData()
        {
            MessageBox.Show("Введены некорректные данные!");
        }


        /// <summary>
        /// Наличие в таблице количества первичных ключей, не равного 1
        /// </summary>
        public void NotOnePK()
        {
            MessageBox.Show("В таблице должен быть ровно один первичный ключ.");
        }

        /// <summary>
        /// Указание имени таблицы, которое уже используется
        /// </summary>
        public void ExistTable()
        {
            MessageBox.Show("Таблица с заданным именем уже существует.");
        }

        /// <summary>
        /// Указание имени поля, которое уже используется
        /// </summary>
        public void ExistField()
        {
            MessageBox.Show("Поле с заданным именем уже существует.");
        }

        /// <summary>
        /// Нераспознанная ошибка
        /// </summary>
        public void Error()
        {
            MessageBox.Show("Что-то пошло не так.");
        }
        /// <summary>
        /// Попытка удалить поле, являющееся ПК в таблице
        /// </summary>
        public void IsPKField()
        {
            MessageBox.Show("Данное поле является первичным ключом таблицы. Удаление невозможно.");
        }
        public void Exit()
        {
            MessageBox.Show("Вы дошли до блока finally.");
        }
    }
}
