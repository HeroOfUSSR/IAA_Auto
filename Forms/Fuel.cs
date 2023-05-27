using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Auto
{
    public partial class Fuel : Form
    {
        Database database = new Database();
        public Fuel()
        {
            InitializeComponent();
        }

        private void Topil_Load(object sender, EventArgs e)
        {
            this.таблица_видов_топливаTableAdapter.Fill(this.AutoDataSet.Таблица_видов_топлива);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           database.openConnection();

            var id_post = textBox2.Text;
            var name = textBox1.Text;
            var id_vid = textBox4.Text;
            var price = textBox3.Text;

            var a = $"insert into [dbo].[Таблица видов топлива](id_post,price,Name,id_vid) values('{id_post}','{price}','{name}','{id_vid}')";

            var command = new SqlCommand(a, database.GetSqlConnection());

            command.ExecuteNonQuery();

            dataGridView1.Update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            var rows = dataGridView1.SelectedRows;
            dataGridView1.CurrentCell = null;
            foreach (DataGridViewRow r in rows)
                r.Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() != string.Empty)
            {


                this.таблица_видов_топливаTableAdapter.Delete((int)dataGridView1.Rows[index].Cells[0].Value,(int)dataGridView1.Rows[index].Cells[1].Value,(int)dataGridView1.Rows[index].Cells[2].Value,(string)dataGridView1.Rows[index].Cells[3].Value);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                dataGridView1.Sort(priceDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending);
                
            }
            else
            {
                dataGridView1.Sort(priceDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Descending);
            }
        }
    }
}
