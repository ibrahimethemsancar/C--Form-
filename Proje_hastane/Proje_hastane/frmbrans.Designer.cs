
namespace Proje_hastane
{
    partial class frmbrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbrans));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 246);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Lime;
            this.btnguncelle.Location = new System.Drawing.Point(116, 150);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(119, 32);
            this.btnguncelle.TabIndex = 34;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Crimson;
            this.btnsil.Location = new System.Drawing.Point(177, 112);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(58, 32);
            this.btnsil.TabIndex = 33;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.SandyBrown;
            this.btnekle.Location = new System.Drawing.Point(115, 112);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(56, 32);
            this.btnekle.TabIndex = 32;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 29);
            this.textBox1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Branş Ad:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(115, 33);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(134, 29);
            this.txtid.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Branş id:";
            // 
            // frmbrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(593, 351);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmbrans";
            this.Text = "frmbrans";
            this.Load += new System.EventHandler(this.frmbrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
    }
}