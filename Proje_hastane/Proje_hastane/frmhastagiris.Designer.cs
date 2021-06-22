
namespace Proje_hastane
{
    partial class frmhastagiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhastagiris));
            this.lbltc = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.lnkuyeol = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(60, 66);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(70, 24);
            this.lbltc.TabIndex = 0;
            this.lbltc.Text = "TC No:";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(60, 106);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(52, 24);
            this.lblsifre.TabIndex = 1;
            this.lblsifre.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta Giriş Paneli";
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(148, 69);
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(140, 29);
            this.msktc.TabIndex = 1;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(148, 104);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(140, 29);
            this.txtsifre.TabIndex = 2;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(181, 139);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(107, 41);
            this.btngiris.TabIndex = 5;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // lnkuyeol
            // 
            this.lnkuyeol.AutoSize = true;
            this.lnkuyeol.Location = new System.Drawing.Point(305, 109);
            this.lnkuyeol.Name = "lnkuyeol";
            this.lnkuyeol.Size = new System.Drawing.Size(67, 24);
            this.lnkuyeol.TabIndex = 6;
            this.lnkuyeol.TabStop = true;
            this.lnkuyeol.Text = "Üye Ol";
            this.lnkuyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkuyeol_LinkClicked);
            // 
            // frmhastagiris
            // 
            this.AcceptButton = this.btngiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(439, 281);
            this.Controls.Add(this.lnkuyeol);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lbltc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "frmhastagiris";
            this.Text = "Hasta Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.LinkLabel lnkuyeol;
    }
}