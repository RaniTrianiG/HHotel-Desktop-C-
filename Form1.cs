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

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        } 

        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotel");
        
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

        void reset()
        {
            txtHarga.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
            tampil2();
            try
            {
                conn.Close();
                conn.Open();
                string kueri = "select id_kamar from data_kamar";
                using (var command = new MySqlCommand(kueri, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtIDkamar.Items.Add(reader.GetString("id_kamar"));
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Terjadi kesalahan!");
            }
        }

        void kamar() {
            try {
                conn.Close();
                conn.Open();

                string kueri = "update data_kamar set status_kamar='Terisi' where id_kamar='" + this.txtIDkamar.Text + "';";
                MySqlCommand command = new MySqlCommand(kueri, conn);
                MySqlDataReader reader = command.ExecuteReader();
            }
            catch{}
        
        }
     private void button1_Click(object sender, EventArgs e)
     {
         if (txtKTP.Text == "" && txtSIM.Text == "")
              {
                   MessageBox.Show("Mohon lengkapi data diatas!", "Data tidak lengkap");
              }
              else{
                  if (txtNama.Text == "" || txtIDTamu.Text == "" || txtAlamat.Text == "" || txtTelp.Text == "" ||txtIDkamar.Text == "")
                  {
                      MessageBox.Show("Data tidak lengkap, Mohon isi kembali!", "Data tidak lengkap");
                  }
                  else
                  {
                      try
                      {

                          conn.Close();
                          conn.Open();
                          string kueri = "INSERT INTO data_penyewa VALUES ('" + this.txtIDTamu.Text + "', '" + this.txtIDkamar.Text + "', '" + this.txtKTP.Text + "', '" + this.txtSIM.Text + "', '" + this.txtNama.Text + "','" + this.txtAlamat.Text +"', '" + this.txtTelp.Text + "','" + this.txtWaktu.Text +"');";
                         
                          MySqlCommand command = new MySqlCommand(kueri, conn);
                          MySqlDataReader reader;
                          reader = command.ExecuteReader();
                          kamar();
                          MessageBox.Show("Data berhasil dimasukkan.", "Berhasil");
                          tampil2();
                      }

                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);
                      }
                  }
     }
     }

          void tampil2(){
            conn.Close();
        conn.Open();

        MySqlDataAdapter da = new MySqlDataAdapter("select * from data_penyewa", conn);
        DataSet ds = new DataSet();
        
        da.Fill(ds, "data_penyewa");
        dataGridView2.DataSource = ds;
        dataGridView2.DataMember = "data_penyewa";
    }

          private void button1_Click_1(object sender, EventArgs e)
          {
              if (txtKTP.Text == "" && txtSIM.Text == "")
              {
                   MessageBox.Show("Mohon lengkapi data diatas!", "Data tidak lengkap");
              }
              else{
                  if (txtNama.Text == "" || txtIDTamu.Text == "" || txtAlamat.Text == "" ||txtTelp.Text == "")
                  {
                      MessageBox.Show("Mohon lengkapi data diatas!", "Data tidak lengkap");
                  }
                  else
                  {
                      Form3 f3 = new Form3();
                      f3.ShowDialog();
                      f3.Focus();
                  }
              }
          }

          private void checkBox1_CheckedChanged(object sender, EventArgs e)
          {
              if (checkBox1.Checked == true)
              {
                  txtKTP.Enabled = true;
              }
              else {
                  txtKTP.Enabled = false;
                  txtKTP.Clear();
              }

         }

          private void checkBox2_CheckedChanged(object sender, EventArgs e)
          {
              if (checkBox2.Checked == true)
              {
                  txtSIM.Enabled = true;
              }
              else {
                  txtSIM.Enabled = false;
                  txtSIM.Clear();
              }
          }

          private void txtIDkamar_SelectedIndexChanged(object sender, EventArgs e)
          {
              try {
                  conn.Close();
                  conn.Open();
                  string kueri = "select * from data_kamar where id_kamar='" + this.txtIDkamar.Text + "';";
                  MySqlCommand command = new MySqlCommand(kueri,conn);
                  MySqlDataReader reader = command.ExecuteReader();
                  if (reader.Read())
                  {
                      cmbJenis.Text = reader.GetValue(1).ToString();
                      txtHarga.Text = reader.GetValue(2).ToString();
                      textBox1.Text = reader.GetValue(3).ToString();
                      textBox2.Text = reader.GetValue(4).ToString();
                      conn.Close();
                  }
              }
                  catch (Exception ex){
                    MessageBox.Show(ex.Message,"Ada Kesalahan!");
                  }
              }
          }

         }



