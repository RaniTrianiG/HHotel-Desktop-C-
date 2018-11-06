using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataKamarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMain fMain = new frmMain();
            fMain.ShowDialog();
            fMain.Focus();
        }

        private void dataSewaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain fMain = new frmMain();
            fMain.ShowDialog();
            fMain.Focus();
        }

        private void dataTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            f2.Focus();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            f3.Focus();
        }

        private void fasilitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
            f6.Focus();
        }

        private void keluarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 f7  = new Form7();
            f7.ShowDialog();
            f7.Focus();
        }

        private void keluarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain fMain = new frmMain();
            fMain.ShowDialog();
            fMain.Focus();

        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            f3.Focus();

        }

        private void dataKamarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
            f9.Focus();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
