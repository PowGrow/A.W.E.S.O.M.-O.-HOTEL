using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using System.Data.SQLite;
using System.Threading;

namespace ExcelParcer
{
    public partial class Main_Form : Form
    {
        public static String db_File_Name = "awesomo.sqlite";
        public Main_Form()
        {
            InitializeComponent();
        }

        public static DataGridView DataGridFormation(DataGridView dataGridView)
        {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle rowHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Black;
            rowHeaderStyle.BackColor = Color.Black;
            columnHeaderStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            rowHeaderStyle.Font = new Font("Tahoma", 6, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridView.RowHeadersDefaultCellStyle = rowHeaderStyle;
            dataGridView.RowHeadersWidth = 50;
            dataGridView.Columns[0].Name = "Поставщик";
            dataGridView.Columns[0].Width = 250;
            dataGridView.Columns[1].Name = "Описание";
            dataGridView.Columns[1].Width = 500;
            dataGridView.Columns[2].Name = "Дней";
            dataGridView.Columns[2].Width = 250;

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

            return dataGridView;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                dataGridView = ExcelParcer.FileRead(fileselectTextbox.Text, dataGridView);
            }
            else
            {
                dataGridView = ExcelParcer.SearchData(dataGridView, SearchTextBox.Text);
            }
        }

        private void StripMenuItemImport_Click(object sender, EventArgs e)
        {
            String[] filename;
            if (dataGridView.Rows.Count != 0)
            {
                Double secondThreadWork,mainThreadWork;
                filename = fileselectTextbox.Text.Split("\\");
                filename = filename.Last().Split(".");
                secondThreadWork = Math.Ceiling(Convert.ToDouble(dataGridView.RowCount - 1 )/2);
                mainThreadWork = secondThreadWork - 1;
                DataAccess.SQLiteCreateTable(filename[0], db_File_Name,StatusLable.Text,dataGridView);
            }
                

        }

        private void StripMenuItemExport_Click(object sender, EventArgs e)
        {
            String tableName = "testovaya_big";
            dataGridView = DataAccess.SQLiteTableRead(tableName, db_File_Name, StatusLable.Text, dataGridView);
            dataGridView = DataGridFormation(dataGridView);
        }

        private void FileselectButton_Click(object sender, EventArgs e)
        {

            if (fileselectTextbox.Text != "")
            {
                try
                {
                    FileAttributes attr = File.GetAttributes(fileselectTextbox.Text);
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                        fileselectTextbox.Text = "Fail";
                    else
                    {
                        dataGridView = ExcelParcer.FileRead(fileselectTextbox.Text, dataGridView);
                        searchButton.Enabled = true;
                    }
                }

                catch(System.IO.FileNotFoundException)
                {
                    fileselectTextbox.Text = "Fail";
                }

            }
            else
            {
                OpenFileDialog OPF = new OpenFileDialog();
                OPF.Filter = "Excel sheet files (*.xls;*.xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";
                if (OPF.ShowDialog() == DialogResult.OK)
                {
                    fileselectTextbox.Text = OPF.FileName;
                    dataGridView = ExcelParcer.FileRead(fileselectTextbox.Text, dataGridView);
                    searchButton.Enabled = true;
                }
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            StatusLable.Text = DataAccess.SQLiteInitialyze(db_File_Name);
        }
    }
}
