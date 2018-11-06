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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static string teks;

        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotel");



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hasil;
            double harga, hari;
            harga = Convert.ToDouble(comboBox1.Text);
            hari = Convert.ToDouble(txtWaktu.Text);

            hasil = harga * hari;
            textBox6.Text = hasil.ToString(); ;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtWaktu.Text == "" || txtWaktu.Text == "" || comboBox1.Text == "" )
            {
                MessageBox.Show("Pengisian belum lengkap!", "Validasi Data");
            }
            else
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
                f2.Focus();

                teks = textBox6.Text;
            }
        }
       

        private void txtWaktu_TextChanged(object sender, EventArgs e)
        {
        }

    private void Form3_Load(object sender, EventArgs e)
        {

            try
            {
                conn.Close();
                conn.Open();
                string kueri = "select id_tamu from data_penyewa";
                using (var command = new MySqlCommand(kueri, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtKamar.Items.Add(reader.GetString("id_tamu"));
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Terjadi kesalahan!");
            }
        }

    void datakamar()
    {
        try {
                  conn.Close();
                  conn.Open();
                  string kueri = "select * from data_kamar where id_kamar='" + this.txtIDKamar.Text + "';";
                  MySqlCommand command = new MySqlCommand(kueri,conn);
                  MySqlDataReader reader = command.ExecuteReader();
                  if (reader.Read())
                  {
                      comboBox1.Text = reader.GetValue(2).ToString();
                  }
              }

                  catch (Exception ex){
                    MessageBox.Show(ex.Message,"Ada Kesalahan!");
                  }
            
    
    }

        private void txtKamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                  conn.Close();
                  conn.Open();
                  string kueri = "select * from data_penyewa where id_tamu='" + this.txtKamar.Text + "';";
                  MySqlCommand command = new MySqlCommand(kueri,conn);
                  MySqlDataReader reader = command.ExecuteReader();
                  if (reader.Read())
                  {
                      txtIDKamar.Text = reader.GetValue(1).ToString();
                      txtWaktu.Text = reader.GetValue(7).ToString();
                  }
                  datakamar();
              }
                  catch (Exception ex){
                    MessageBox.Show(ex.Message,"Ada Kesalahan!");
                  }
              }

        }
         }

