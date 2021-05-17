using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ExcelParcer
{
    public static partial class ExcelParcer
    {

        //Поиск по заданым параметрам в dataGridView
        public static DataGridView SearchData(DataGridView dataGridView, String searchText)
        {
            Int32 rows = dataGridView.Rows.Count;
            Int32 k = 0;
            for (int i = 0; i < rows; i++)
            {
                if (searchText != null & dataGridView[1, i].Value != null)
                {
                    String search = dataGridView[1, i].Value.ToString();
                    if (search.IndexOf(searchText) > -1)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            dataGridView[j, k].Value = dataGridView[j, i].Value.ToString();
                        }
                        k++;
                    }
                }
            }
            for (int i = k; i < rows - 1; i++)
            {
                dataGridView.Rows.RemoveAt(k);
            }
            return dataGridView;
        }
    }
}
