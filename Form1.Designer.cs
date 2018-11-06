namespace WindowsFormsApplication1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDkamar = new System.Windows.Forms.ComboBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.Data_Penyewa = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnProses2 = new System.Windows.Forms.Button();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtIDTamu = new System.Windows.Forms.TextBox();
            this.txtSIM = new System.Windows.Forms.TextBox();
            this.txtKTP = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtWaktu = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.Data_Penyewa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWaktu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWaktu);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDkamar);
            this.groupBox1.Controls.Add(this.txtHarga);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbJenis);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 210);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilih Kamar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Waktu Sewa";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(114, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Nomor Kamar";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(114, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Status Kamar";
            // 
            // txtIDkamar
            // 
            this.txtIDkamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIDkamar.FormattingEnabled = true;
            this.txtIDkamar.Location = new System.Drawing.Point(114, 19);
            this.txtIDkamar.Name = "txtIDkamar";
            this.txtIDkamar.Size = new System.Drawing.Size(168, 21);
            this.txtIDkamar.TabIndex = 12;
            this.txtIDkamar.SelectedIndexChanged += new System.EventHandler(this.txtIDkamar_SelectedIndexChanged);
            // 
            // txtHarga
            // 
            this.txtHarga.Enabled = false;
            this.txtHarga.Location = new System.Drawing.Point(133, 90);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(149, 20);
            this.txtHarga.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rp.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Harga Kamar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jenis Kamar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Kamar";
            // 
            // cmbJenis
            // 
            this.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite"});
            this.cmbJenis.Location = new System.Drawing.Point(114, 50);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(168, 21);
            this.cmbJenis.TabIndex = 2;
            this.cmbJenis.SelectedIndexChanged += new System.EventHandler(this.cmbJenis_SelectedIndexChanged);
            // 
            // Data_Penyewa
            // 
            this.Data_Penyewa.Controls.Add(this.checkBox2);
            this.Data_Penyewa.Controls.Add(this.checkBox1);
            this.Data_Penyewa.Controls.Add(this.btnProses2);
            this.Data_Penyewa.Controls.Add(this.txtTelp);
            this.Data_Penyewa.Controls.Add(this.txtAlamat);
            this.Data_Penyewa.Controls.Add(this.txtIDTamu);
            this.Data_Penyewa.Controls.Add(this.txtSIM);
            this.Data_Penyewa.Controls.Add(this.txtKTP);
            this.Data_Penyewa.Controls.Add(this.txtNama);
            this.Data_Penyewa.Controls.Add(this.label11);
            this.Data_Penyewa.Controls.Add(this.label10);
            this.Data_Penyewa.Controls.Add(this.label9);
            this.Data_Penyewa.Controls.Add(this.label8);
            this.Data_Penyewa.Controls.Add(this.label7);
            this.Data_Penyewa.Controls.Add(this.label6);
            this.Data_Penyewa.Location = new System.Drawing.Point(12, 228);
            this.Data_Penyewa.Name = "Data_Penyewa";
            this.Data_Penyewa.Size = new System.Drawing.Size(666, 177);
            this.Data_Penyewa.TabIndex = 5;
            this.Data_Penyewa.TabStop = false;
            this.Data_Penyewa.Text = "Masukkan Data Penyewa";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(311, 109);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(312, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnProses2
            // 
            this.btnProses2.Location = new System.Drawing.Point(584, 136);
            this.btnProses2.Name = "btnProses2";
            this.btnProses2.Size = new System.Drawing.Size(75, 23);
            this.btnProses2.TabIndex = 11;
            this.btnProses2.Text = "Proses";
            this.btnProses2.UseVisualStyleBackColor = true;
            this.btnProses2.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTelp
            // 
            this.txtTelp.Location = new System.Drawing.Point(443, 110);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(216, 20);
            this.txtTelp.TabIndex = 10;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(443, 32);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(216, 72);
            this.txtAlamat.TabIndex = 9;
            // 
            // txtIDTamu
            // 
            this.txtIDTamu.Enabled = false;
            this.txtIDTamu.Location = new System.Drawing.Point(89, 58);
            this.txtIDTamu.Name = "txtIDTamu";
            this.txtIDTamu.Size = new System.Drawing.Size(216, 20);
            this.txtIDTamu.TabIndex = 6;
            this.txtIDTamu.Text = "0";
            // 
            // txtSIM
            // 
            this.txtSIM.Enabled = false;
            this.txtSIM.Location = new System.Drawing.Point(89, 110);
            this.txtSIM.Name = "txtSIM";
            this.txtSIM.Size = new System.Drawing.Size(216, 20);
            this.txtSIM.TabIndex = 8;
            // 
            // txtKTP
            // 
            this.txtKTP.Enabled = false;
            this.txtKTP.Location = new System.Drawing.Point(89, 84);
            this.txtKTP.Name = "txtKTP";
            this.txtKTP.Size = new System.Drawing.Size(216, 20);
            this.txtKTP.TabIndex = 7;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(89, 32);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(216, 20);
            this.txtNama.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(371, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "No. Telepon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(354, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Alamat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "No. SIM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "No.KTP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 411);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(666, 194);
            this.dataGridView2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Mau?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtWaktu
            // 
            this.txtWaktu.Location = new System.Drawing.Point(114, 175);
            this.txtWaktu.Name = "txtWaktu";
            this.txtWaktu.Size = new System.Drawing.Size(168, 20);
            this.txtWaktu.TabIndex = 18;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Data_Penyewa);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HHotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Data_Penyewa.ResumeLayout(false);
            this.Data_Penyewa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWaktu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Data_Penyewa;
        private System.Windows.Forms.Button btnProses2;

















        private System.Windows.Forms.TextBox txtTelp;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtIDTamu;
        private System.Windows.Forms.TextBox txtSIM;
        private System.Windows.Forms.TextBox txtKTP;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtIDkamar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown txtWaktu;
    }
}

