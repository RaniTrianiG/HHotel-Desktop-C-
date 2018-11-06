using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        MySqlConnection conection = new MySqlConnection("datasource=localhost;port=3306;Database=hotel;username=root;password=");

            MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        int valid;

        private void button1_Click(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("select * from login where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", conection);
            adapter.Fill(table);
            if (table.Rows.Count <= 0)
            {  
            valid = 0;
                timer1.Enabled = true;
            }
            else
            {
                valid = 1;
                timer1.Enabled = true;
            }
            table.Clear();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                if (valid == 1)
                {
                    MessageBox.Show("Login Sukses!");
                    Form4 menu = new Form4();
                    menu.Show();
                    this.Visible = false;
                    progressBar1.Value = 0;
                }
                else
                {
                    MessageBox.Show("Login Gagal!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                    progressBar1.Value = 0;
                }
            }
            else {
                this.progressBar1.Value = this.progressBar1.Value + 5;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
