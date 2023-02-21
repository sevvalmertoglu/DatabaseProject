namespace veriT
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txturunıd = new System.Windows.Forms.TextBox();
            this.txtwvano = new System.Windows.Forms.TextBox();
            this.txtoemno = new System.Windows.Forms.TextBox();
            this.txtkullanılanarac = new System.Windows.Forms.TextBox();
            this.txtstokno = new System.Windows.Forms.TextBox();
            this.txtfirmaıd = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txtkategoriıd = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÜRÜN ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "WVA NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "OEM NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "KULLANILAN ARAÇ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "STOK NO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "FİRMA ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "FİYAT:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "KATEGORİ ID:";
            // 
            // txturunıd
            // 
            this.txturunıd.Location = new System.Drawing.Point(163, 9);
            this.txturunıd.Name = "txturunıd";
            this.txturunıd.Size = new System.Drawing.Size(100, 20);
            this.txturunıd.TabIndex = 9;
            // 
            // txtwvano
            // 
            this.txtwvano.Location = new System.Drawing.Point(163, 45);
            this.txtwvano.Name = "txtwvano";
            this.txtwvano.Size = new System.Drawing.Size(100, 20);
            this.txtwvano.TabIndex = 10;
            // 
            // txtoemno
            // 
            this.txtoemno.Location = new System.Drawing.Point(163, 85);
            this.txtoemno.Name = "txtoemno";
            this.txtoemno.Size = new System.Drawing.Size(100, 20);
            this.txtoemno.TabIndex = 11;
            // 
            // txtkullanılanarac
            // 
            this.txtkullanılanarac.Location = new System.Drawing.Point(163, 120);
            this.txtkullanılanarac.Name = "txtkullanılanarac";
            this.txtkullanılanarac.Size = new System.Drawing.Size(100, 20);
            this.txtkullanılanarac.TabIndex = 12;
            // 
            // txtstokno
            // 
            this.txtstokno.Location = new System.Drawing.Point(494, 6);
            this.txtstokno.Name = "txtstokno";
            this.txtstokno.Size = new System.Drawing.Size(100, 20);
            this.txtstokno.TabIndex = 13;
            // 
            // txtfirmaıd
            // 
            this.txtfirmaıd.Location = new System.Drawing.Point(494, 42);
            this.txtfirmaıd.Name = "txtfirmaıd";
            this.txtfirmaıd.Size = new System.Drawing.Size(100, 20);
            this.txtfirmaıd.TabIndex = 14;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(494, 82);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat.TabIndex = 15;
            // 
            // txtkategoriıd
            // 
            this.txtkategoriıd.Location = new System.Drawing.Point(494, 120);
            this.txtkategoriıd.Name = "txtkategoriıd";
            this.txtkategoriıd.Size = new System.Drawing.Size(100, 20);
            this.txtkategoriıd.TabIndex = 16;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(665, 34);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 41);
            this.btnekle.TabIndex = 17;
            this.btnekle.Text = "EKLE\r\n";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(665, 85);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 40);
            this.btnsil.TabIndex = 18;
            this.btnsil.Text = "SİL\r\n";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::veriT.Properties.Resources.logın1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtkategoriıd);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.txtfirmaıd);
            this.Controls.Add(this.txtstokno);
            this.Controls.Add(this.txtkullanılanarac);
            this.Controls.Add(this.txtoemno);
            this.Controls.Add(this.txtwvano);
            this.Controls.Add(this.txturunıd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txturunıd;
        private System.Windows.Forms.TextBox txtwvano;
        private System.Windows.Forms.TextBox txtoemno;
        private System.Windows.Forms.TextBox txtkullanılanarac;
        private System.Windows.Forms.TextBox txtstokno;
        private System.Windows.Forms.TextBox txtfirmaıd;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txtkategoriıd;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
    }
}