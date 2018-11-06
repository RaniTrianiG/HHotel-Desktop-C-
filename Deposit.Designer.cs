namespace WindowsFormsApplication1
{
    partial class Form8
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
            this.Deposit = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Deposit
            // 
            this.Deposit.Location = new System.Drawing.Point(28, 30);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(230, 189);
            this.Deposit.TabIndex = 0;
            this.Deposit.TabStop = false;
            this.Deposit.Text = "Deposit";
            this.Deposit.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Deposit);
            this.Name = "Form8";
            this.Text = "Deposit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Deposit;
    }
}