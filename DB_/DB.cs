using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_
{
    /// <summary>
    /// Класс для обращения к базе данных
    /// </summary>
    public class DB
    {
        string ConnectionString;            // Строка подключения к БД
        NpgsqlConnection vCon;              // Соединение с БД
        NpgsqlCommand vCmd;                 // Запрос к БД


        public DB(string ConnectionString_)
        {
            this.ConnectionString = ConnectionString_;
        }

        /// <summary>
        /// Поулчение соединения с БД
        /// </summary>
        private void connection(string ConnectionString)
        {
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = ConnectionString;

            try
            {
                if (vCon.State == ConnectionState.Closed)
                {
                    vCon.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Получение данных от БД по запросу 
        /// </summary>
        /// <param name="sql"> SQL запрос к БД </param>
        /// <returns></returns>
        public DataTable getData(string sql)
        {
            DataTable dt = new DataTable();
            connection(ConnectionString);

            try
            {
                vCmd = new NpgsqlCommand();
                vCmd.Connection = vCon;
                vCmd.CommandText = sql;

                NpgsqlDataReader dr = vCmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// Создание таблицы
        /// </summary>
        /// <param name="tableName"> Имя иаблицы </param>
        /// <returns></returns>
        public bool CreateTable(string tableName)
        {
            DataTable dt = new DataTable();
            connection(ConnectionString);

            try
            {
                vCmd = new NpgsqlCommand();
                vCmd.Connection = vCon;

                // SQL Запрос на создание таблицы
                string firstString = String.Format("CREATE TABLE {0} (id SERIAL PRIMARY KEY, column_name_ VARCHAR(30)," +
                                                    " type_ VARCHAR(20),  isPK BOOLEAN DEFAULT FALSE);", tableName);
                vCmd.CommandText = firstString;

                vCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Добавление нового поля в таблицу
        /// </summary>
        /// <param name="tableName"> Имя таблицы </param>
        /// <param name="columnName"> Имя поля </param>
        /// <param name="type"> Тип поля </param>
        /// <param name="isPK"> Является ли первичным ключом</param>
        public bool InsertTable(string tableName, string columnName, string type, bool isPK)
        {
            DataTable dt = new DataTable();
            connection(ConnectionString);

            try
            {
                vCmd = new NpgsqlCommand();
                vCmd.Connection = vCon;

                // SQL Запрос на добавление поля
                string firstString = String.Format("INSERT INTO {0} (column_name_, type_, isPK) " +
                                                    "VALUES ('{1}', '{2}', {3});", tableName, columnName, type, isPK);
                vCmd.CommandText = firstString;

                vCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Удаление таблицы
        /// </summary>
        /// <param name="tableName"> Имя таблицы </param>
        public bool DeleteTable(string tableName)
        {
            DataTable dt = new DataTable();
            connection(ConnectionString);

            try
            {
                vCmd = new NpgsqlCommand();
                vCmd.Connection = vCon;

                // SQL Запрос на удаление таблицы
                string firstString = String.Format("DROP TABLE {0};", tableName);
                vCmd.CommandText = firstString;

                vCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Удаление поля
        /// </summary>
        /// <param name="id"> Идентификатор поля </param>
        /// <param name="tableName"> Имя таблицы </param>
        public bool DeleteField(int id, string tableName)
        {
            DataTable dt = new DataTable();
            connection(ConnectionString);

            try
            {
                vCmd = new NpgsqlCommand();
                vCmd.Connection = vCon;

                // SQL Запрос на удаление поля по его идентификатору
                string firstString = String.Format("DELETE FROM {0} WHERE id={1}; ", tableName, id);
                vCmd.CommandText = firstString;

                vCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Обновление поля таблицы
        /// </summary>
        /// <param name="tableName"> Имя таблицы </param>
        /// <param name="id"> Идентификатор поля</param>
        /// <param name="columnName"> Наименование поля </param>
        /// <param name="type"> Тип поля </param>
        /// <param name="isPK_new"> Является ли первичным ключом </param>
        public bool UpdateField(string tableName, int id, string columnName, string type, bool isPK_new)
        {
            DataTable dt = new DataTable();
            connection(ConnectionString);

            try
            {
                vCmd = new NpgsqlCommand();
                vCmd.Connection = vCon;

                // SQL Запрос на обновление поля по его идентификатору
                string firstString = String.Format("UPDATE {0} SET column_name_ = '{1}', type_ = '{2}'," +
                                             " isPK = {3}  WHERE id = {4}; ", tableName, columnName, type, isPK_new, id);
                vCmd.CommandText = firstString;

                vCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Добавление нового поля в таблицу
        /// </summary>
        public bool AddField(string tableName, string columnName, string type)
        {
            DataTable dt = new DataTable();
            connection(ConnectionString);

            try
            {
                vCmd = new NpgsqlCommand();
                vCmd.Connection = vCon;

                // SQL Запрос на добавление поля 
                string firstString = String.Format("INSERT INTO {0} (column_name_, type_, isPK)" +
                                                    " VALUES ('{1}', '{2}', False);", tableName, columnName, type);
                vCmd.CommandText = firstString;

                vCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Подсчет количества первичных ключей в таблице
        /// </summary>
        /// <param name="tableName"> ИМя таблицы </param>
        /// <returns></returns>
        public int CountPK(string tableName)
        {
            DataTable dt = new DataTable();
            connection(ConnectionString);

            try
            {
                vCmd = new NpgsqlCommand();
                vCmd.Connection = vCon;

                // SQL Запрос на подсчет количества ПК в таблице
                string firstString = String.Format("SELECT COUNT(*) FROM {0} WHERE isPK IS TRUE;", tableName);
                vCmd.CommandText = firstString;

                NpgsqlDataReader dr = vCmd.ExecuteReader();
                dt.Load(dr);
                int a = Convert.ToInt32(vCmd.ExecuteScalar());
                return a;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        /// <summary>
        /// Проверка поля таблицы на то, является ли оно первычнм ключом
        /// </summary>
        /// <param name="tableName"> Имя таблицы </param>
        /// <param name="columnName"> Имя поля </param>
        /// <returns></returns>
        public bool IsBasePK(string tableName, string columnName)
        {
            DataTable dt = new DataTable();
            connection(ConnectionString);

            try
            {
                vCmd = new NpgsqlCommand();
                vCmd.Connection = vCon;

                // SQL запрос проверки поля на принадлежность его к ПК 
                string firstString = String.Format("SELECT isPK FROM {0} WHERE column_name_ = '{1}'; ",
                                                    tableName, columnName);
                vCmd.CommandText = firstString;

                NpgsqlDataReader dr = vCmd.ExecuteReader();
                dt.Load(dr);

                return Convert.ToBoolean(vCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Обновление имени таблицы
        /// </summary>
        /// <param name="tableName"> Прежнее имя таблицы </param>
        /// <param name="newTableName"> Новое имя таблицы </param>
        public void UpdateTableName(string tableName, string newTableName)
        {
            DataTable dt = new DataTable();
            connection(ConnectionString);

            try
            {
                vCmd = new NpgsqlCommand();
                vCmd.Connection = vCon;

                // SQL запрос на обновление имени талицы 
                string firstString = String.Format("ALTER TABLE {0} RENAME TO {1};", tableName, newTableName);
                vCmd.CommandText = firstString;

                NpgsqlDataReader dr = vCmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Проверка поля на существование
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="newFieldName"></param>
        /// <returns></returns>
        public bool IsFieldExist(string tableName, string newFieldName)
        {
            DataTable dt = new DataTable();
            connection(ConnectionString);

            try
            {
                vCmd = new NpgsqlCommand();
                vCmd.Connection = vCon;

                // SQL запрос на поиск проверку наличия поля таблицы по его имени
                string firstString = String.Format("SELECT EXISTS (SELECT column_name_ FROM {0} " +
                                                    "WHERE column_name_ = '{1}');", tableName, newFieldName);
                vCmd.CommandText = firstString;

                NpgsqlDataReader dr = vCmd.ExecuteReader();
                dt.Load(dr);
                bool res = Convert.ToBoolean(dt.Rows[0][0]);
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }
        /// <summary>
        /// Изменение первичного ключа таблицы 
        /// </summary>
        /// <param name="tableName"> Имя таблицы </param>
        /// <param name="columnName"> Имя поля </param>
        /// <param name="type"> Имя типа поля</param>
        public bool ChangePK(string tableName, string columnName, string type)
        {
            return (DiscardPK(tableName)
                && SetPK(tableName, columnName, type));
        }
        /// <summary>
        /// Обновление ПК таблицы
        /// </summary>
        /// <param name="id"> Идентифиактор поля </param>
        /// <param name="tableName"> Имя таблицы </param>
        /// <param name="columnName"> Имя поля </param>
        /// <param name="type"> Тип поля </param>
        public bool UpdatePKField(int id, string tableName, string columnName, string type)
        {
            return (DiscardPK(tableName)
                && UpdatePK(tableName, id, columnName, type));
        }

        /// <summary>
        /// Сброс всех ПК таблицы
        /// </summary>
        /// <param name="tableName"> Имя таблицы </param>
        public bool DiscardPK(string tableName)
        {
            DataTable dt = new DataTable();
            connection(ConnectionString);

            try
            {
                vCmd = new NpgsqlCommand();
                vCmd.Connection = vCon;

                //SQL запрос для обновления таблицы - установки ПК выбранному полю
                string firstString = String.Format("UPDATE {0} set isPK = False; ", tableName);
                vCmd.CommandText = firstString;
                NpgsqlDataReader dr = vCmd.ExecuteReader();

                dt.Load(dr);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Установка первичного ключа таблицы
        /// </summary>
        /// <param name="tableName"> Имя таблицы </param>
        /// <param name="columnName"> Имя поля - будущего ПК</param>
        /// <param name="type"> Тия поля </param>
        public bool SetPK(string tableName, string columnName, string type)
        {
            DataTable dt = new DataTable();
            connection(ConnectionString);

            try
            {
                vCmd = new NpgsqlCommand();
                vCmd.Connection = vCon;

                // SQL запрос для добавления нового поля (ПК) в таблицу
                string secondString = String.Format("INSERT INTO {0} (column_name_, type_, isPK)" +
                                                    " VALUES ('{1}', '{2}', True);", tableName, columnName, type);
                vCmd.CommandText = secondString;
                NpgsqlDataReader dr = vCmd.ExecuteReader();


                dt.Load(dr);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Обновление первичного ключа таблицы
        /// </summary>
        /// <param name="tableName"> Имя таблицы </param>
        /// <param name="id"> Идентификатор поля </param>
        /// <param name="columnName"> Имя поля </param>
        /// <param name="type"> Тип поля </param>
        public bool UpdatePK(string tableName, int id, string columnName, string type)
        {
            DataTable dt = new DataTable();
            connection(ConnectionString);

            try
            {
                vCmd = new NpgsqlCommand();
                vCmd.Connection = vCon;

                // SQL запрос для обновления существующего поля (устновка как ПК) в таблицуе
                string firstString = String.Format("UPDATE {0} SET column_name_ = '{1}', type_ = '{2}', isPK = True" +
                                                "  WHERE id = {3}; ", tableName, columnName, type, id);
                vCmd.CommandText = firstString;

                vCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
