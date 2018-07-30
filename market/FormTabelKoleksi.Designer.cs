namespace market {
    partial class FormTabelKoleksi {
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
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKoleksi = new System.Windows.Forms.TextBox();
            this.buttonCari = new System.Windows.Forms.Button();
            this.buttonTampilkanSemua = new System.Windows.Forms.Button();
            this.buttonTambahKoleksi = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKoleksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahMacamBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pilih = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.AllowUserToAddRows = false;
            this.dataGridViewBarang.AllowUserToDeleteRows = false;
            this.dataGridViewBarang.AllowUserToResizeColumns = false;
            this.dataGridViewBarang.AllowUserToResizeRows = false;
            this.dataGridViewBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBarang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaKoleksi,
            this.tipeSatuan,
            this.jumlahMacamBarang,
            this.pilih,
            this.hapus});
            this.dataGridViewBarang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewBarang.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.Size = new System.Drawing.Size(1249, 587);
            this.dataGridViewBarang.TabIndex = 1;
            this.dataGridViewBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBarang_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cari Koleksi";
            // 
            // textBoxKoleksi
            // 
            this.textBoxKoleksi.Location = new System.Drawing.Point(150, 15);
            this.textBoxKoleksi.Name = "textBoxKoleksi";
            this.textBoxKoleksi.Size = new System.Drawing.Size(339, 29);
            this.textBoxKoleksi.TabIndex = 3;
            // 
            // buttonCari
            // 
            this.buttonCari.Location = new System.Drawing.Point(507, 13);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(129, 31);
            this.buttonCari.TabIndex = 4;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // buttonTampilkanSemua
            // 
            this.buttonTampilkanSemua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTampilkanSemua.Location = new System.Drawing.Point(1054, 11);
            this.buttonTampilkanSemua.Name = "buttonTampilkanSemua";
            this.buttonTampilkanSemua.Size = new System.Drawing.Size(207, 31);
            this.buttonTampilkanSemua.TabIndex = 5;
            this.buttonTampilkanSemua.Text = "Tampilkan Semua";
            this.buttonTampilkanSemua.UseVisualStyleBackColor = true;
            this.buttonTampilkanSemua.Click += new System.EventHandler(this.buttonTampilkanSemua_Click);
            // 
            // buttonTambahKoleksi
            // 
            this.buttonTambahKoleksi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTambahKoleksi.Location = new System.Drawing.Point(768, 11);
            this.buttonTambahKoleksi.Name = "buttonTambahKoleksi";
            this.buttonTambahKoleksi.Size = new System.Drawing.Size(207, 31);
            this.buttonTambahKoleksi.TabIndex = 6;
            this.buttonTambahKoleksi.Text = "Tambah Koleksi";
            this.buttonTambahKoleksi.UseVisualStyleBackColor = true;
            this.buttonTambahKoleksi.Click += new System.EventHandler(this.buttonTambahKoleksi_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nama Koleksi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "TipeSatuan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Jumlah Macam Barang";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // namaKoleksi
            // 
            this.namaKoleksi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaKoleksi.HeaderText = "Nama Koleksi";
            this.namaKoleksi.Name = "namaKoleksi";
            this.namaKoleksi.ReadOnly = true;
            // 
            // tipeSatuan
            // 
            this.tipeSatuan.HeaderText = "TipeSatuan";
            this.tipeSatuan.Name = "tipeSatuan";
            this.tipeSatuan.ReadOnly = true;
            this.tipeSatuan.Width = 200;
            // 
            // jumlahMacamBarang
            // 
            this.jumlahMacamBarang.HeaderText = "Jumlah Macam Barang";
            this.jumlahMacamBarang.Name = "jumlahMacamBarang";
            this.jumlahMacamBarang.ReadOnly = true;
            this.jumlahMacamBarang.Width = 250;
            // 
            // pilih
            // 
            this.pilih.HeaderText = "Pilih";
            this.pilih.Name = "pilih";
            this.pilih.Width = 58;
            // 
            // hapus
            // 
            this.hapus.FillWeight = 50F;
            this.hapus.HeaderText = "Hapus";
            this.hapus.Name = "hapus";
            // 
            // FormTabelKoleksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 655);
            this.Controls.Add(this.buttonTambahKoleksi);
            this.Controls.Add(this.buttonTampilkanSemua);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.textBoxKoleksi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBarang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormTabelKoleksi";
            this.Text = "FormTabelKoleksi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKoleksi;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Button buttonTampilkanSemua;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button buttonTambahKoleksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKoleksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahMacamBarang;
        private System.Windows.Forms.DataGridViewButtonColumn pilih;
        private System.Windows.Forms.DataGridViewImageColumn hapus;
    }
}