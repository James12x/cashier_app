namespace market {
    partial class FormIsiKoleksi {
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
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonTambahBarang = new System.Windows.Forms.Button();
            this.dataGridViewTabelBarang = new System.Windows.Forms.DataGridView();
            this.labelKoleksi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaJual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKembali
            // 
            this.buttonKembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonKembali.Location = new System.Drawing.Point(27, 607);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(166, 44);
            this.buttonKembali.TabIndex = 4;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonTambahBarang
            // 
            this.buttonTambahBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTambahBarang.Location = new System.Drawing.Point(1103, 13);
            this.buttonTambahBarang.Name = "buttonTambahBarang";
            this.buttonTambahBarang.Size = new System.Drawing.Size(166, 44);
            this.buttonTambahBarang.TabIndex = 3;
            this.buttonTambahBarang.Text = "Tambah Barang";
            this.buttonTambahBarang.UseVisualStyleBackColor = true;
            this.buttonTambahBarang.Click += new System.EventHandler(this.buttonTambahBarang_Click);
            // 
            // dataGridViewTabelBarang
            // 
            this.dataGridViewTabelBarang.AllowUserToAddRows = false;
            this.dataGridViewTabelBarang.AllowUserToDeleteRows = false;
            this.dataGridViewTabelBarang.AllowUserToResizeColumns = false;
            this.dataGridViewTabelBarang.AllowUserToResizeRows = false;
            this.dataGridViewTabelBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTabelBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewTabelBarang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTabelBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabelBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noBarang,
            this.namaBarang,
            this.hargaBeli,
            this.hargaJual,
            this.tipeSatuan,
            this.satuan,
            this.ubah,
            this.hapus});
            this.dataGridViewTabelBarang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewTabelBarang.Location = new System.Drawing.Point(27, 63);
            this.dataGridViewTabelBarang.Name = "dataGridViewTabelBarang";
            this.dataGridViewTabelBarang.Size = new System.Drawing.Size(1248, 528);
            this.dataGridViewTabelBarang.TabIndex = 2;
            this.dataGridViewTabelBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTabelBarang_CellContentClick);
            // 
            // labelKoleksi
            // 
            this.labelKoleksi.AutoSize = true;
            this.labelKoleksi.Location = new System.Drawing.Point(164, 23);
            this.labelKoleksi.Name = "labelKoleksi";
            this.labelKoleksi.Size = new System.Drawing.Size(163, 24);
            this.labelKoleksi.TabIndex = 1;
            this.labelKoleksi.Text = "nama koleksi here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Koleksi :";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 68.87309F;
            this.dataGridViewTextBoxColumn1.HeaderText = "No Barang";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 226;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama Barang";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 340;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 80F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Harga per Satuan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 226;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 60F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipe Satuan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 136;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 60F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Satuan";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 135;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 41.32386F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Satuan";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 107;
            // 
            // noBarang
            // 
            this.noBarang.FillWeight = 68.87309F;
            this.noBarang.HeaderText = "No Barang";
            this.noBarang.Name = "noBarang";
            this.noBarang.ReadOnly = true;
            this.noBarang.Width = 125;
            // 
            // namaBarang
            // 
            this.namaBarang.FillWeight = 103.3096F;
            this.namaBarang.HeaderText = "Nama Barang";
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.ReadOnly = true;
            this.namaBarang.Width = 150;
            // 
            // hargaBeli
            // 
            this.hargaBeli.FillWeight = 80F;
            this.hargaBeli.HeaderText = "Harga Beli";
            this.hargaBeli.Name = "hargaBeli";
            this.hargaBeli.ReadOnly = true;
            this.hargaBeli.Width = 122;
            // 
            // hargaJual
            // 
            this.hargaJual.FillWeight = 80F;
            this.hargaJual.HeaderText = "Harga Jual";
            this.hargaJual.Name = "hargaJual";
            this.hargaJual.ReadOnly = true;
            this.hargaJual.Width = 125;
            // 
            // tipeSatuan
            // 
            this.tipeSatuan.FillWeight = 41.32386F;
            this.tipeSatuan.HeaderText = "Tipe Satuan";
            this.tipeSatuan.Name = "tipeSatuan";
            this.tipeSatuan.ReadOnly = true;
            this.tipeSatuan.Width = 136;
            // 
            // satuan
            // 
            this.satuan.FillWeight = 41.32386F;
            this.satuan.HeaderText = "Satuan";
            this.satuan.Name = "satuan";
            this.satuan.ReadOnly = true;
            this.satuan.Width = 93;
            // 
            // ubah
            // 
            this.ubah.FillWeight = 20.66193F;
            this.ubah.HeaderText = "Ubah";
            this.ubah.Name = "ubah";
            this.ubah.Width = 61;
            // 
            // hapus
            // 
            this.hapus.FillWeight = 30F;
            this.hapus.HeaderText = "Hapus";
            this.hapus.Name = "hapus";
            this.hapus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hapus.Width = 71;
            // 
            // FormIsiKoleksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 659);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonTambahBarang);
            this.Controls.Add(this.dataGridViewTabelBarang);
            this.Controls.Add(this.labelKoleksi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormIsiKoleksi";
            this.Text = "FormIsiKoleksi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKoleksi;
        private System.Windows.Forms.DataGridView dataGridViewTabelBarang;
        private System.Windows.Forms.Button buttonTambahBarang;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn noBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaJual;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan;
        private System.Windows.Forms.DataGridViewButtonColumn ubah;
        private System.Windows.Forms.DataGridViewImageColumn hapus;
    }
}