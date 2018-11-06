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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;Database=hotel;username=root;password=");
        string skrg;
        void tampil()
        {
            conn.Close();
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from data_kamar", conn);
            DataSet ds = new DataSet();

            da.Fill(ds, "data_kamar");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "data_kamar";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtHarga.Text == "" || cmbJenis.Text == "" || txtIDkamar.Text == "")
            {
                MessageBox.Show("Data belum lengkap!!!!!!!!!!!!!!!", "Validasi Gagal!");
            }
            else
            {
                try
                {
                    conn.Close();
                    conn.Open();
                    string kueri = "insert into hotel.data_kamar values('" + this.txtIDkamar.Text + "','" + this.cmbJenis.Text + "','" + this.txtHarga.Text +"','" +  this.comboBox1.Text +"', '" +this.textBox2.Text + "');";

                    MySqlCommand command = new MySqlCommand(kueri, conn);
                    MySqlDataReader reader;
                    reader = command.ExecuteReader();

                    MessageBox.Show("Data berhasil dimasukkan.", "Berhasil");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                tampil();
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJenis.Text == "Single")
            {
                txtHarga.Text = "175000";
            }
            else if (cmbJenis.Text == "Double")
            {
                txtHarga.Text = "225000";
            }
            else if (cmbJenis.Text == "Suite")
            {
                txtHarga.Text = "300000";
            }
        }

        private void txtIDkamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            conn.Close();

            string kueri = "select * from data_kamar where id_kamar='" + txtIDkamar.Text + "';";
            MySqlCommand command = new MySqlCommand(kueri, conn);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtHarga.Text = reader.GetValue(2).ToString();
                comboBox1.Text = reader.GetValue(3).ToString();
                textBox2.Text = reader.GetValue(4).ToString();
            }
            else {
                txtHarga.Clear();
                textBox2.Clear();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (txtHarga.Text == "" || cmbJenis.Text == "" || txtIDkamar.Text == "")
            {
                MessageBox.Show("Data belum lengkap!!!!!!!!!!!!!!!", "Validasi Gagal!");
            }
            else
            {
                try
                {
                    conn.Close();
                    conn.Open();
                    string kueri = "update data_kamar set jenis='" + cmbJenis.Text + "', harga='" + txtHarga.Text + "',  status_kamar='" + comboBox1.Text + "', nomor_kamar= '" + textBox2.Text + "' where id_kamar='" + txtIDkamar.Text + "';";

                    MySqlCommand command = new MySqlCommand(kueri, conn);
                    MySqlDataReader reader;
                    reader = command.ExecuteReader();

                    MessageBox.Show("Data berhasil dimasukkan.", "Berhasil");
                    txtHarga.Clear();
                    textBox2.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                tampil();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();

                string kueri = "delete from data_kamar where id_kamar='" + txtIDkamar.Text + "';";

                MySqlCommand command = new MySqlCommand(kueri, conn);
                MySqlDataReader reader;

                reader = command.ExecuteReader();

                MessageBox.Show("Data berhasil di hapus","Berhasil");
                tampil();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ada Kesalahan");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                skrg = "";
            }
            else {
                skrg = textBox2.Text;
            }
            timer1.Enabled = false;
        }
        void validasi() {
            try
            {
                conn.Close();
                conn.Open();

                string kueri = "select * from data_kamar where nomor_kamar='" + textBox2.Text + "';";
                MySqlCommand command = new MySqlCommand(kueri, conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (textBox2.Text == skrg)
                    {
                        button2.Enabled = true;
                        button3.Enabled = false;
                    }
                    else
                    {
                        button3.Enabled = false;
                        button2.Enabled = false;
                    }
                }
                else
                {
                    button3.Enabled = true;
                    button2.Enabled = true;
                }
            }
            catch{
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            validasi();
        }

        private void txtIDkamar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();
                string kueri = "select * from data_kamar where id_kamar='" + this.txtIDkamar.Text + "';";
                MySqlCommand command = new MySqlCommand(kueri, conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtIDkamar.Text = reader.GetValue(0).ToString();
                    cmbJenis.Text = reader.GetValue(1).ToString();
                    txtHarga.Text = reader.GetValue(2).ToString();
                    comboBox1.Text = reader.GetValue(3).ToString();
                    textBox2.Text = reader.GetValue(4).ToString();
                    conn.Close();
                    button2.Enabled = true;
                }
                else
                {
                    reset();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Terjadi kesalahan!");
            }
        }
        void reset()
        {
            txtHarga.Clear();
            txtIDkamar.Clear();
            textBox2.Clear();
        }
        }
    }

