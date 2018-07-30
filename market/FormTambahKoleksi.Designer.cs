namespace market {
    partial class FormTambahKoleksi {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonTambah = new System.Windows.Forms.Button();
            this.textBoxNamaKoleksi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipeSatuan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(350, 156);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(123, 44);
            this.buttonTambah.TabIndex = 0;
            this.buttonTambah.Text = "Selesai";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // textBoxNamaKoleksi
            // 
            this.textBoxNamaKoleksi.Location = new System.Drawing.Point(165, 20);
            this.textBoxNamaKoleksi.Name = "textBoxNamaKoleksi";
            this.textBoxNamaKoleksi.Size = new System.Drawing.Size(308, 29);
            this.textBoxNamaKoleksi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Koleksi";
            // 
            // comboBoxTipeSatuan
            // 
            this.comboBoxTipeSatuan.FormattingEnabled = true;
            this.comboBoxTipeSatuan.Location = new System.Drawing.Point(165, 76);
            this.comboBoxTipeSatuan.Name = "comboBoxTipeSatuan";
            this.comboBoxTipeSatuan.Size = new System.Drawing.Size(181, 32);
            this.comboBoxTipeSatuan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipe Satuan";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.Location = new System.Drawing.Point(26, 156);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(123, 44);
            this.buttonKeluar.TabIndex = 5;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = true;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormTambahKoleksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 260);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTipeSatuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNamaKoleksi);
            this.Controls.Add(this.buttonTambah);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormTambahKoleksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahKoleksi";
            this.Load += new System.EventHandler(this.FormTambahKoleksi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.TextBox textBoxNamaKoleksi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipeSatuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKeluar;
    }
}