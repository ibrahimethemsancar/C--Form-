
namespace Proje_hastane
{
    partial class frmdoktorbilgiduzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdoktorbilgiduzenle));
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(187, 185);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(140, 29);
            this.txtsifre.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Şifre:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(187, 65);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(140, 29);
            this.txtsoyad.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Soyad:";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(207, 231);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(107, 41);
            this.btnguncelle.TabIndex = 32;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(187, 25);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(140, 29);
            this.txtad.TabIndex = 31;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(187, 105);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(140, 29);
            this.msktc.TabIndex = 30;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(121, 28);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(39, 24);
            this.lblsifre.TabIndex = 29;
            this.lblsifre.Text = "Ad:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(99, 102);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(70, 24);
            this.lbltc.TabIndex = 28;
            this.lbltc.Text = "TC No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Branş:";
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(187, 142);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(140, 32);
            this.cmbbrans.TabIndex = 38;
            // 
            // frmdoktorbilgiduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(578, 340);
            this.Controls.Add(this.cmbbrans);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmdoktorbilgiduzenle";
            this.Text = "Doktor Bilg Güncelle";
            this.Load += new System.EventHandler(this.frmdoktorbilgiduzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbrans;
    }
}