
namespace Proje_hastane
{
    partial class frmbilgiduzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbilgiduzenle));
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(147, 233);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(140, 31);
            this.cmbcinsiyet.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cinsiyet:";
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(147, 149);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(140, 31);
            this.msktelefon.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Telefon:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(147, 189);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(140, 31);
            this.txtsifre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Şifre:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(147, 69);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(140, 31);
            this.txtsoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Soyad:";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(180, 274);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(107, 41);
            this.btnguncelle.TabIndex = 23;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(147, 29);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(140, 31);
            this.txtad.TabIndex = 1;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(147, 109);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(140, 31);
            this.msktc.TabIndex = 3;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(81, 32);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(37, 23);
            this.lblsifre.TabIndex = 20;
            this.lblsifre.Text = "Ad:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(59, 106);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(64, 23);
            this.lbltc.TabIndex = 19;
            this.lbltc.Text = "TC No:";
            // 
            // frmbilgiduzenle
            // 
            this.AcceptButton = this.btnguncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(482, 378);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lbltc);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frmbilgiduzenle";
            this.Text = "Bilgi Güncelle";
            this.Load += new System.EventHandler(this.frmbilgiduzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lbltc;
    }
}