﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signin signin = new Signin();
            this.Visible = false;
            signin.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            this.Visible = false;
            fm1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog='我的資料庫';Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from 帳號", conn);//sql語法
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            int cnt = 0;//重複
            while(reader.Read())
            {
                if (textBox1.Text == reader[0].ToString() || textBox2.Text == reader[1].ToString())
                    cnt++;
            }
            if (cnt > 0)
            {
                Form1 fm1 = new Form1();
                //this.Visible = false;
                fm1.ShowDialog(this);
            }
            else
                MessageBox.Show("帳號或密碼錯誤");

        }
    }
}
