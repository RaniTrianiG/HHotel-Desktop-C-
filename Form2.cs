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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        MySqlConnection konek = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotel;");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Maaf, mohon lakukan pengisian data secara valid!!", "Valid!");
            }
            else
            {
                int uangmasuk;
                double hasil;
                uangmasuk = Convert.ToInt32(textBox5.Text);
                hasil = uangmasuk;
                textBox4.Text = "Rp." + Convert.ToString(hasil);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.Text = Form3.teks;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
