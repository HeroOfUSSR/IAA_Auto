using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class Form1 : Form
    {

        Database database=new Database();
        public Form1()
        {
            InitializeComponent();
        }

 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guide_Click(object sender, EventArgs e)
        {
            Guide spravocnik = new Guide();
            spravocnik.Show();

        }

        private void fuel_Click(object sender, EventArgs e)
        {
            Fuel topil = new Fuel();
            topil.Show();
        }

        private void count_Click(object sender, EventArgs e)
        {
            Count Count = new Count();
            Count.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Иванов Алексей, ИП-20-7к https://github.com/HeroOfUSSR", "Контакты");
        }
    }
}
