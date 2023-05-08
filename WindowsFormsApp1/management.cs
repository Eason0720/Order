using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class management : Form
    {
        public management()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int rows_cnt = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            conn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void management_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "----選取----" || textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("商品資訊不完整，請仔細填寫");
            else
            {
                if(Regex.IsMatch(textBox1.Text,@"^[^0-9]+$") && Regex.IsMatch(textBox2.Text, @"^[0-9]"))
                {
                    SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"insert into {comboBox1.Text} values (@類別, @商品, @價格, @狀態)", conn);
                    
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
