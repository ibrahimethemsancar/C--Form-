
namespace Proje_hastane
{
    partial class frmdoktorgiris
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
            this.lnkuyeol = new System.Windows.Forms.LinkLabel();
            this.btngiris = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkuyeol
            // 
            this.lnkuyeol.AutoSize = true;
            this.lnkuyeol.Location = new System.Drawing.Point(320, 154);
            this.lnkuyeol.Name = "lnkuyeol";
            this.lnkuyeol.Size = new System.Drawing.Size(67, 24);
            this.lnkuyeol.TabIndex = 13;
            this.lnkuyeol.TabStop = true;
            this.lnkuyeol.Text = "Üye Ol";
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(196, 184);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(107, 41);
            this.btngiris.TabIndex = 12;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 29);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "12345";
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(163, 114);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(140, 29);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.Text = "11111111111";
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Doktor Giriş Paneli";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(75, 151);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(52, 24);
            this.lblsifre.TabIndex = 8;
            this.lblsifre.Text = "Şifre:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(75, 111);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(70, 24);
            this.lbltc.TabIndex = 7;
            this.lbltc.Text = "TC No:";
            // 
            // frmdoktorgiris
            // 
            this.AcceptButton = this.btngiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(490, 351);
            this.Controls.Add(this.lnkuyeol);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lbltc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmdoktorgiris";
            this.Text = "frmdoktorgiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkuyeol;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lbltc;
    }
}