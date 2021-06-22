
namespace Proje_hastane
{
    partial class frmdoktordetay
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
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchsikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.btnduyuru = new System.Windows.Forms.Button();
            this.btnduzenle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(106, 82);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(81, 24);
            this.lbladsoyad.TabIndex = 3;
            this.lbladsoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(106, 39);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(120, 24);
            this.lbltc.TabIndex = 1;
            this.lbltc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC no:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchsikayet);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rchsikayet
            // 
            this.rchsikayet.Location = new System.Drawing.Point(6, 28);
            this.rchsikayet.Name = "rchsikayet";
            this.rchsikayet.Size = new System.Drawing.Size(262, 159);
            this.rchsikayet.TabIndex = 0;
            this.rchsikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btncıkıs);
            this.groupBox3.Controls.Add(this.btnduyuru);
            this.groupBox3.Controls.Add(this.btnduzenle);
            this.groupBox3.Location = new System.Drawing.Point(12, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 101);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı Erişim";
            // 
            // btncıkıs
            // 
            this.btncıkıs.Location = new System.Drawing.Point(6, 64);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(268, 30);
            this.btncıkıs.TabIndex = 3;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = true;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // btnduyuru
            // 
            this.btnduyuru.Location = new System.Drawing.Point(156, 28);
            this.btnduyuru.Name = "btnduyuru";
            this.btnduyuru.Size = new System.Drawing.Size(129, 30);
            this.btnduyuru.TabIndex = 1;
            this.btnduyuru.Text = "Duyurular";
            this.btnduyuru.UseVisualStyleBackColor = true;
            this.btnduyuru.Click += new System.EventHandler(this.btnduyuru_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.Location = new System.Drawing.Point(6, 28);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(144, 30);
            this.btnduzenle.TabIndex = 0;
            this.btnduzenle.Text = "Bilgi Düzenle";
            this.btnduzenle.UseVisualStyleBackColor = true;
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(303, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 499);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 471);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmdoktordetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(802, 520);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmdoktordetay";
            this.Text = "frmdoktordetay";
            this.Load += new System.EventHandler(this.frmdoktordetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rchsikayet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Button btnduyuru;
        private System.Windows.Forms.Button btnduzenle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}