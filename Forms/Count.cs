using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Auto
{
    public partial class Count : Form
    {
        Database database = new Database();
        public Count()
        {
            InitializeComponent();
        }

        private void Count_Load(object sender, EventArgs e)
        {
            this.таблица_учета_остатковTableAdapter.Fill(this.AutoDataSet.Таблица_учета_остатков);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var id_Kod = textBox1.Text;
            var id_vid = textBox2.Text;
            var data = textBox3.Text;
            var Vday = textBox4.Text;
            var Vprice= textBox5.Text;

            var a = $"insert into [dbo].[Таблица учета остатков](id_accounting,id_vid,data,[volume day],[volume price]) values('{id_Kod}','{id_vid}','{data}','{Vday}','{Vprice}')";

            var command = new SqlCommand(a, database.GetSqlConnection());

            command.ExecuteNonQuery();

            dataGridView1.Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            var rows = dataGridView1.SelectedRows;
            dataGridView1.CurrentCell = null;
            foreach (DataGridViewRow r in rows)
                r.Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() != string.Empty)
            {


                this.таблица_учета_остатковTableAdapter.Delete((int)dataGridView1.Rows[index].Cells[0].Value, (int)dataGridView1.Rows[index].Cells[1].Value, (int)dataGridView1.Rows[index].Cells[2].Value, (int)dataGridView1.Rows[index].Cells[3].Value, (int)dataGridView1.Rows[index].Cells[4].Value);


            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton1.Checked)
            //{
            //    dataGridView1.Sort((DataGridViewColumn)(System.Collections.IComparer)volumePriceDataGridViewTextBoxColumn,ListSortDirection.Ascending);

            //}
            //else
            //{
            //    dataGridView1.Sort((DataGridViewColumn)(System.Collections.IComparer)volumePriceDataGridViewTextBoxColumn, ListSortDirection.Descending);
            //}

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}
