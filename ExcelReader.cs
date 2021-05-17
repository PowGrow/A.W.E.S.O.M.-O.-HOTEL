using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OfficeOpenXml;
using System.Data;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SQLite;

namespace ExcelParcer
{
    public static partial class ExcelParcer
    {
        //Открытие файла и вызов функции чтения
        public static DataGridView FileRead(string path, DataGridView dataGridView)
        {
            DataGridView dataGridViewReturn;
            var file = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage pckg = new ExcelPackage(file);
            dataGridViewReturn = ExcelGridWrite(dataGridView, pckg);
            return dataGridViewReturn;
            
        }


        //Чтение xls/xlsx файла и его последующая запись в dataGridView
        private static DataGridView ExcelGridWrite(DataGridView dataGridView, ExcelPackage pckg)
        {

            Int32[] columnNeeded = new Int32[3];
            Int32 rows, columns;
            ExcelWorksheet ws = pckg.Workbook.Worksheets[0];
            rows = ws.Dimension.Rows;
            columns = ws.Dimension.Columns;
            dataGridView.ColumnCount = columnNeeded.Length;
            dataGridView.RowCount = rows;



            
            for (int j = 0; j < columns; j++)
            {
                if (ws.Cells[1, j + 1].Value != null)
                {

                    switch (ws.Cells[1, j + 1].Value.ToString())
                    {
                        case "Departure":
                            columnNeeded[2] = j + 1;
                            dataGridView.Columns[2].Width = 250;
                            break;
                        case "ProviderName":
                            columnNeeded[0] = j + 1;
                            dataGridView.Columns[0].Width = 250;
                            break;
                        case "Description":
                            columnNeeded[1] = j + 1;
                            dataGridView.Columns[1].Width = 500;
                            break;
                    }
                }
                

            }

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columnNeeded.Length; j++)
                {
                    if (ws.Cells[i + 2, columnNeeded[j]].Value != null)
                    {
                        dataGridView[j, i].Value = ws.Cells[i + 2, columnNeeded[j]].Value.ToString();
                        
                    }
                    else
                    {
                        dataGridView[j, i].Value = " ";
                    }
                }
            }
            dataGridView = Main_Form.DataGridFormation(dataGridView);
            return dataGridView;
        }
    }
}
