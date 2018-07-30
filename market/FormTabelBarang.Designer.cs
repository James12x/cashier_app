namespace market {
    partial class FormTabelBarang {
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
            this.dataGridViewTabelBarang = new System.Windows.Forms.DataGridView();
            this.buttonCariNamaBarang = new System.Windows.Forms.Button();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomorBarang = new System.Windows.Forms.TextBox();
            this.buttonCariNoBarang = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaPerSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koleksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pilih = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelBarang)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewTabelBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTabelBarang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTabelBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabelBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noBarang,
            this.namaBarang,
            this.hargaBeli,
            this.hargaPerSatuan,
            this.tipeSatuan,
            this.satuan,
            this.koleksi,
            this.pilih});
            this.dataGridViewTabelBarang.Location = new System.Drawing.Point(12, 112);
            this.dataGridViewTabelBarang.Name = "dataGridViewTabelBarang";
            this.dataGridViewTabelBarang.Size = new System.Drawing.Size(1279, 535);
            this.dataGridViewTabelBarang.TabIndex = 0;
            this.dataGridViewTabelBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTabelBarang_CellContentClick);
            // 
            // buttonCariNamaBarang
            // 
            this.buttonCariNamaBarang.Location = new System.Drawing.Point(306, 43);
            this.buttonCariNamaBarang.Name = "buttonCariNamaBarang";
            this.buttonCariNamaBarang.Size = new System.Drawing.Size(87, 31);
            this.buttonCariNamaBarang.TabIndex = 1;
            this.buttonCariNamaBarang.Text = "Cari";
            this.buttonCariNamaBarang.UseVisualStyleBackColor = true;
            this.buttonCariNamaBarang.Click += new System.EventHandler(this.buttonCariNamaBarang_Click);
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.Location = new System.Drawing.Point(16, 45);
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.Size = new System.Drawing.Size(274, 29);
            this.textBoxNamaBarang.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nomor Barang";
            // 
            // textBoxNomorBarang
            // 
            this.textBoxNomorBarang.Location = new System.Drawing.Point(511, 43);
            this.textBoxNomorBarang.Name = "textBoxNomorBarang";
            this.textBoxNomorBarang.Size = new System.Drawing.Size(265, 29);
            this.textBoxNomorBarang.TabIndex = 5;
            // 
            // buttonCariNoBarang
            // 
            this.buttonCariNoBarang.Location = new System.Drawing.Point(792, 41);
            this.buttonCariNoBarang.Name = "buttonCariNoBarang";
            this.buttonCariNoBarang.Size = new System.Drawing.Size(87, 31);
            this.buttonCariNoBarang.TabIndex = 4;
            this.buttonCariNoBarang.Text = "Cari";
            this.buttonCariNoBarang.UseVisualStyleBackColor = true;
            this.buttonCariNoBarang.Click += new System.EventHandler(this.buttonCariNoBarang_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No Barang";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 206;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama Barang";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 309;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Harga per Satuan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 207;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 60F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Satuan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 123;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 60F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Satuan";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 124;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 60F;
            this.dataGridViewTextBoxColumn6.HeaderText = "koleksi";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 206;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "koleksi";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 177;
            // 
            // noBarang
            // 
            this.noBarang.HeaderText = "No Barang";
            this.noBarang.Name = "noBarang";
            this.noBarang.ReadOnly = true;
            // 
            // namaBarang
            // 
            this.namaBarang.FillWeight = 150F;
            this.namaBarang.HeaderText = "Nama Barang";
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.ReadOnly = true;
            // 
            // hargaBeli
            // 
            this.hargaBeli.HeaderText = "Harga Beli";
            this.hargaBeli.Name = "hargaBeli";
            this.hargaBeli.ReadOnly = true;
            // 
            // hargaPerSatuan
            // 
            this.hargaPerSatuan.HeaderText = "Harga Jual";
            this.hargaPerSatuan.Name = "hargaPerSatuan";
            this.hargaPerSatuan.ReadOnly = true;
            // 
            // tipeSatuan
            // 
            this.tipeSatuan.FillWeight = 60F;
            this.tipeSatuan.HeaderText = "Tipe Satuan";
            this.tipeSatuan.Name = "tipeSatuan";
            this.tipeSatuan.ReadOnly = true;
            // 
            // satuan
            // 
            this.satuan.FillWeight = 60F;
            this.satuan.HeaderText = "Satuan";
            this.satuan.Name = "satuan";
            this.satuan.ReadOnly = true;
            // 
            // koleksi
            // 
            this.koleksi.HeaderText = "koleksi";
            this.koleksi.Name = "koleksi";
            this.koleksi.ReadOnly = true;
            // 
            // pilih
            // 
            this.pilih.FillWeight = 30F;
            this.pilih.HeaderText = "Pilih";
            this.pilih.Name = "pilih";
            // 
            // FormTabelBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1303, 659);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomorBarang);
            this.Controls.Add(this.buttonCariNoBarang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNamaBarang);
            this.Controls.Add(this.buttonCariNamaBarang);
            this.Controls.Add(this.dataGridViewTabelBarang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormTabelBarang";
            this.Text = "FormTabelBarang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTabelBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonCariNamaBarang;
        private System.Windows.Forms.TextBox textBoxNamaBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomorBarang;
        private System.Windows.Forms.Button buttonCariNoBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn noBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaPerSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn koleksi;
        private System.Windows.Forms.DataGridViewButtonColumn pilih;
    }
}