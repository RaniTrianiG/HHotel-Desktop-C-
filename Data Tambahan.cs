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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void txtTotalHarga_TextChanged(object sender, EventArgs e)
        {

        }

        // MAKANAN 1
  
        private void Mk1Plus_Click(object sender, EventArgs e)
        {
            float Mk1, hasil;
            Mk1 = float.Parse(this.txtMk1.Text);
            hasil = Mk1 + 1;
            this.txtMk1.Text = Convert.ToString(hasil);
        }

        private void Mk1Min_Click(object sender, EventArgs e)
        {
            float Mk1, hasil;
            Mk1 = float.Parse(this.txtMk1.Text);
            hasil = Mk1 - 1;
            this.txtMk1.Text = Convert.ToString(hasil);
        }

        private void txtMk1_TextChanged(object sender, EventArgs e)
        {
            float Mk1;
            Mk1 = float.Parse(this.txtMk1.Text);
            if (Mk1 < 1)
            {
                this.Mk1Min.Enabled = false;
            }
            else
            {
                this.Mk1Min.Enabled = true;
            }
        }

        // MAKANAN 2
        private void Mk2Plus_Click(object sender, EventArgs e)
        {
            float Mk2, hasil;
            Mk2 = float.Parse(this.txtMk2.Text);
            hasil = Mk2 + 1;
            this.txtMk2.Text = Convert.ToString(hasil);
        }

        private void Mk2Min_Click(object sender, EventArgs e)
        {
            float Mk2, hasil;
            Mk2 = float.Parse(this.txtMk2.Text);
            hasil = Mk2 - 1;
            this.txtMk2.Text = Convert.ToString(hasil);
        }

        private void txtMk2_TextChanged(object sender, EventArgs e)
        {
            float Mk2;
            Mk2 = float.Parse(this.txtMk2.Text);
            if (Mk2 < 1)
            {
                this.Mk2Min.Enabled = false;
            }
            else
            {
                this.Mk2Min.Enabled = true;
            }

        }
        // MAKANAN 3
        private void Mk3Plus_Click(object sender, EventArgs e)
        {
            float Mk3, hasil;
            Mk3 = float.Parse(this.txtMk3.Text);
            hasil = Mk3 + 1;
            this.txtMk3.Text = Convert.ToString(hasil);
        }

        private void Mk3Min_Click(object sender, EventArgs e)
        {
            float Mk3, hasil;
            Mk3 = float.Parse(this.txtMk3.Text);
            hasil = Mk3 - 1;
            this.txtMk3.Text = Convert.ToString(hasil);
        }

        private void txtMk3_TextChanged(object sender, EventArgs e)
        {
            float Mk3;
            Mk3 = float.Parse(this.txtMk3.Text);
            if (Mk3 < 1)
            {
                this.Mk3Min.Enabled = false;
            }
            else
            {
                this.Mk3Min.Enabled = true;
            }
        }
        // MAKANAN 4
        private void Mk4Plus_Click(object sender, EventArgs e)
        {
            float Mk4, hasil;
            Mk4 = float.Parse(this.txtMk4.Text);
            hasil = Mk4 + 1;
            this.txtMk4.Text = Convert.ToString(hasil);
        }

        private void Mk4Min_Click(object sender, EventArgs e)
        {
            float Mk4, hasil;
            Mk4 = float.Parse(this.txtMk4.Text);
            hasil = Mk4 - 1;
            this.txtMk4.Text = Convert.ToString(hasil);
        }

        private void txtMk4_TextChanged(object sender, EventArgs e)
        {
            float Mk4;
            Mk4 = float.Parse(this.txtMk4.Text);
            if (Mk4 < 1)
            {
                this.Mk4Min.Enabled = false;
            }
            else
            {
                this.Mk4Min.Enabled = true;
            }
        }
        //DESSERT
        //DESSERT 1 

        private void Mn1Plus_Click(object sender, EventArgs e)
        {
            float Mn1, hasil;
            Mn1 = float.Parse(this.txtMn1.Text);
            hasil = Mn1 + 1;
            this.txtMn1.Text = Convert.ToString(hasil);
        }

        private void Mn1Min_Click(object sender, EventArgs e)
        {
            float Mn1, hasil;
            Mn1 = float.Parse(this.txtMn1.Text);
            hasil = Mn1 - 1;
            this.txtMn1.Text = Convert.ToString(hasil);
        }

        private void txtMn1_TextChanged(object sender, EventArgs e)
        {
            float Mn1;
            Mn1 = float.Parse(this.txtMn1.Text);
            if (Mn1 < 1)
            {
                this.Mn1Min.Enabled = false;
            }
            else
            {
                this.Mn1Min.Enabled = true;
            }
        }

        //DESSERT 2
        private void Mn2Plus_Click(object sender, EventArgs e)
        {
            float Mn2, hasil;
            Mn2 = float.Parse(this.txtMn2.Text);
            hasil = Mn2 + 1;
            this.txtMn2.Text = Convert.ToString(hasil);
        }

        private void Mn2Min_Click(object sender, EventArgs e)
        {
            float Mn2, hasil;
            Mn2 = float.Parse(this.txtMn2.Text);
            hasil = Mn2 - 1;
            this.txtMn2.Text = Convert.ToString(hasil);
        }

        private void txtMn2_TextChanged(object sender, EventArgs e)
        {
            float Mn2;
            Mn2 = float.Parse(this.txtMn2.Text);
            if (Mn2 < 1)
            {
                this.Mn2Min.Enabled = false;
            }
            else
            {
                this.Mn2Min.Enabled = true;
            }
        }
        //DESSERT 3
        private void Mn3Plus_Click(object sender, EventArgs e)
        {
            float Mn3, hasil;
            Mn3 = float.Parse(this.txtMn3.Text);
            hasil = Mn3 + 1;
            this.txtMn3.Text = Convert.ToString(hasil);
        }

        private void Mn3Min_Click(object sender, EventArgs e)
        {
            float Mn3, hasil;
            Mn3 = float.Parse(this.txtMn3.Text);
            hasil = Mn3 - 1;
            this.txtMn3.Text = Convert.ToString(hasil);
        }

        private void txtMn3_TextChanged(object sender, EventArgs e)
        {
            float Mn3;
            Mn3 = float.Parse(this.txtMn3.Text);
            if (Mn3 < 1)
            {
                this.Mn3Min.Enabled = false;
            }
            else {
                this.Mn3Min.Enabled = true;
            }
        }
        // DESSERT 4
        private void Mn4Plus_Click(object sender, EventArgs e)
        {
            float Mn4, hasil;
            Mn4 = float.Parse(this.txtMn4.Text);
            hasil = Mn4 + 1;
            this.txtMn4.Text = Convert.ToString(hasil);
        }

        private void Mn4Min_Click(object sender, EventArgs e)
        {
            float Mn4, hasil;
            Mn4 = float.Parse(this.txtMn4.Text);
            hasil = Mn4 - 1;
            this.txtMn4.Text = Convert.ToString(hasil);
        }

        private void txtMn4_TextChanged(object sender, EventArgs e)
        {
            float Mn4;
            Mn4 = float.Parse(this.txtMn4.Text);
            if (Mn4 < 1)
            {
                this.Mn4Min.Enabled = false;
            }
            else {
                this.Mn4Min.Enabled = true;
            }
        }
        // DESSERT 5
        private void Mn5Plus_Click(object sender, EventArgs e)
        {
            float Mn5, hasil;
            Mn5 = float.Parse(this.txtMn5.Text);
            hasil = Mn5 + 1;
            this.txtMn5.Text = Convert.ToString(hasil);
        }

        private void Mn5Min_Click(object sender, EventArgs e)
        {
            float Mn5, hasil;
            Mn5 = float.Parse(this.txtMn5.Text);
            hasil = Mn5 - 1;
            this.txtMn5.Text = Convert.ToString(hasil);
        }

        private void txtMn5_TextChanged(object sender, EventArgs e)
        {
            float Mn5;
            Mn5 = float.Parse(this.txtMn5.Text);
            if (Mn5 < 1)
            {
                this.Mn5Min.Enabled = false;
            }
            else {
                this.Mn5Min.Enabled = true;
            }
        }
        // DESSERT 6
        private void Mn6Plus_Click(object sender, EventArgs e)
        {
            float Mn6, hasil;
            Mn6 = float.Parse(this.txtMn6.Text);
            hasil = Mn6 + 1;
            this.txtMn6.Text = Convert.ToString(hasil);
        }

        private void Mn6Min_Click(object sender, EventArgs e)
        {
            float Mn6, hasil;
            Mn6 = float.Parse(this.txtMn6.Text);
            hasil = Mn6 - 1;
            this.txtMn6.Text = Convert.ToString(hasil);
        }

        private void txtMn6_TextChanged(object sender, EventArgs e)
        {
            float Mn6;
            Mn6 = float.Parse(this.txtMn6.Text);
            if (Mn6 < 1)
            {
                this.Mn6Min.Enabled = false;
            }
            else {
                this.Mn6Min.Enabled = Enabled;
            }
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {

        }


    }
}
