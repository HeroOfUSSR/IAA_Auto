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
using System.Data.Entity;

namespace Auto
{
   
    public partial class Guide : Form
    {
        

        Database database = new Database();
        public Guide()
        {
            InitializeComponent();
        }

        private void Spravocnik_Load(object sender, EventArgs e)
        {
            this.справочник_поставщиковTableAdapter.Fill(this.AutoDataSet.Справочник_поставщиков);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var id = textBox1.Text;
            var name= textBox2.Text;

            var a = $"insert into [dbo].[Справочник поставщиков](name_post,id_post) values('{name}','{id}')";
        
            var command=new SqlCommand(a,database.GetSqlConnection());

            command.ExecuteNonQuery();

            dataGridView1.Update();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
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


                this.справочник_поставщиковTableAdapter.Delete((int)dataGridView1.Rows[index].Cells[0].Value,(string)dataGridView1.Rows[index].Cells[1].Value);


            }
        }

        public void Update()
        {
            database.openConnection();

            database.CloseConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
