using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace ExcelParcer
{
    class DataAccesstest
    {
        //Создание файла базы данных
        public static String SQLiteInitialyze(String dbFileName)
        {
            String StatusText;

            StatusText = "Отключено";

            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            return StatusText;
        }

        //Создание таблицы в базе данных, имя таблицы равно имени загружаемого xls/xlsx файла
        public static void SQLiteCreateTable(String tableName,String dbFileName,String StatusText, DataGridView dataGridView)
        {
            SQLiteConnection m_dbConn;
            SQLiteCommand m_sqlCmd;

            m_sqlCmd = new SQLiteCommand();

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS " + tableName + " (id INTEGER PRIMARY KEY AUTOINCREMENT, provider TEXT, description TEXT, departue INTEGER)";
                m_sqlCmd.ExecuteNonQuery();
                StatusText = "Ок";
                m_dbConn.Close();

                DataAccess.SQLiteTableWrite(tableName, dbFileName, StatusText, m_dbConn, m_sqlCmd, dataGridView);
            }
            catch (SQLiteException ex)
            {
                StatusText = "Error" + ex.Message;
            }

            
        }

        public static void SQLiteTableWrite(String tableName,String dbFileName, String StatusText,SQLiteConnection m_dbConn, SQLiteCommand m_sqlCmd, DataGridView dataGridView)
        {
            if (!File.Exists(dbFileName))
                MessageBox.Show("Пожалуйста, создайте базу данных и пустую таблицу");
            try
            {
                Int32 rows, columns;
                rows = dataGridView.Rows.Count;
                columns = dataGridView.Columns.Count;

                m_dbConn = new SQLiteConnection("DataSource=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                StatusText = "Идёт импорт";

                for(Int32 i = 0; i < rows; i++)
                {
                    m_sqlCmd.CommandText = "INSERT INTO " + tableName + " ('provider','description','departue') values ('" + 
                    dataGridView[0,i].Value + "' , '" +
                    dataGridView[1,i].Value + "' , '" +
                    dataGridView[2,i].Value + "')";
                    m_sqlCmd.ExecuteNonQuery();
                }
                m_dbConn.Close();
                StatusText = "Импорт завершён";
                
            }
            catch (SQLiteException ex)
            {
                StatusText = "Ошибка: " + ex.Message;
            }

            
        }

        public static DataGridView SQLiteTableRead(String tableName, String dbFileName, String StatusText, DataGridView dataGridView)
        {
            String sqlQuery;
            DataTable dTable = new DataTable();
            SQLiteConnection m_dbConn;
            SQLiteCommand m_sqlCmd = new SQLiteCommand();

            m_dbConn = new SQLiteConnection("DataSource=" + dbFileName + ";Version=3;");
            m_dbConn.Open();
            m_sqlCmd.Connection = m_dbConn;

            StatusText = "Идёт экспорт";

            try
            {
                sqlQuery = "SELECT * FROM "+ tableName;
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
                adapter.Fill(dTable);
                dTable.Columns.RemoveAt(0);
                dataGridView.ColumnCount = 3;

                if (dTable.Rows.Count > 0)
                {
                    dataGridView.Rows.Clear();

                    for (int i = 0; i < dTable.Rows.Count; i++)
                        dataGridView.Rows.Add(dTable.Rows[i].ItemArray);
                }
                else
                    MessageBox.Show("База данных пуста");
                dataGridView.Rows.RemoveAt(dataGridView.RowCount - 2);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            return dataGridView;
        }
    }
}
