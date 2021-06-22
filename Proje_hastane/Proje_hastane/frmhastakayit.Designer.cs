
namespace Proje_hastane
{
    partial class frmhastakayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhastakayit));
            this.btnkayıtyap = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnkayıtyap
            // 
            this.btnkayıtyap.Location = new System.Drawing.Point(188, 276);
            this.btnkayıtyap.Name = "btnkayıtyap";
            this.btnkayıtyap.Size = new System.Drawing.Size(107, 41);
            this.btnkayıtyap.TabIndex = 10;
            this.btnkayıtyap.Text = "Kayıt Yap";
            this.btnkayıtyap.UseVisualStyleBackColor = true;
            this.btnkayıtyap.Click += new System.EventHandler(this.btnkayıtyap_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(155, 31);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(140, 34);
            this.txtad.TabIndex = 1;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(155, 111);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(140, 34);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(89, 34);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(43, 27);
            this.lblsifre.TabIndex = 7;
            this.lblsifre.Text = "Ad:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(67, 108);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(73, 27);
            this.lbltc.TabIndex = 6;
            this.lbltc.Text = "TC No:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(155, 71);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(140, 34);
            this.txtsoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Soyad:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(155, 191);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(140, 34);
            this.txtsifre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şifre:";
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(155, 151);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(140, 34);
            this.msktelefon.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 27);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cinsiyet:";
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(155, 235);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(140, 35);
            this.cmbcinsiyet.TabIndex = 6;
            // 
            // frmhastakayit
            // 
            this.AcceptButton = this.btnkayıtyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(512, 350);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkayıtyap);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lbltc);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmhastakayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkayıtyap;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
    }
}