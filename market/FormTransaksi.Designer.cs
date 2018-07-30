namespace market {
    partial class FormTransaksi {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridTransaksi = new System.Windows.Forms.DataGridView();
            this.noBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new market.DataGridViewJumlahHargaColumn();
            this.jumlahBarang = new market.DataGridViewNumericColumn();
            this.tipeSatuan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.potonganHarga = new market.DataGridViewJumlahHargaColumn();
            this.total = new market.DataGridViewJumlahHargaColumn();
            this.hapus = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.textBoxNamaBarangLangsung = new System.Windows.Forms.TextBox();
            this.buttonTambahLangsung = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBayar = new System.Windows.Forms.Button();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNoBarang = new market.TextBoxNumeric();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTransaksi
            // 
            this.dataGridTransaksi.AllowUserToAddRows = false;
            this.dataGridTransaksi.AllowUserToDeleteRows = false;
            this.dataGridTransaksi.AllowUserToResizeColumns = false;
            this.dataGridTransaksi.AllowUserToResizeRows = false;
            this.dataGridTransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTransaksi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noBarang,
            this.namaBarang,
            this.harga,
            this.jumlahBarang,
            this.tipeSatuan,
            this.potonganHarga,
            this.total,
            this.hapus});
            this.dataGridTransaksi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridTransaksi.Location = new System.Drawing.Point(17, 86);
            this.dataGridTransaksi.Name = "dataGridTransaksi";
            this.dataGridTransaksi.Size = new System.Drawing.Size(1202, 386);
            this.dataGridTransaksi.TabIndex = 29;
            this.dataGridTransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTransaksi_CellContentClick);
            this.dataGridTransaksi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTransaksi_CellEnter);
            this.dataGridTransaksi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTransaksi_CellValueChanged);
            this.dataGridTransaksi.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridTransaksi_CurrentCellDirtyStateChanged);
            // 
            // noBarang
            // 
            this.noBarang.HeaderText = "No Barang";
            this.noBarang.Name = "noBarang";
            this.noBarang.ReadOnly = true;
            this.noBarang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // namaBarang
            // 
            this.namaBarang.FillWeight = 150F;
            this.namaBarang.HeaderText = "Nama Barang";
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.ReadOnly = true;
            this.namaBarang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // harga
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.harga.DefaultCellStyle = dataGridViewCellStyle1;
            this.harga.HeaderText = "Harga Per Satuan";
            this.harga.Name = "harga";
            this.harga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // jumlahBarang
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.jumlahBarang.DefaultCellStyle = dataGridViewCellStyle2;
            this.jumlahBarang.HeaderText = "Jumlah";
            this.jumlahBarang.Name = "jumlahBarang";
            this.jumlahBarang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jumlahBarang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tipeSatuan
            // 
            this.tipeSatuan.HeaderText = "Tipe Satuan";
            this.tipeSatuan.Name = "tipeSatuan";
            // 
            // potonganHarga
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.potonganHarga.DefaultCellStyle = dataGridViewCellStyle3;
            this.potonganHarga.HeaderText = "Potongan";
            this.potonganHarga.Name = "potonganHarga";
            this.potonganHarga.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.potonganHarga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // total
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total.DefaultCellStyle = dataGridViewCellStyle4;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // hapus
            // 
            this.hapus.FillWeight = 50F;
            this.hapus.HeaderText = "Hapus";
            this.hapus.Name = "hapus";
            this.hapus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(401, 19);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(6);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(94, 36);
            this.buttonTambah.TabIndex = 28;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // textBoxNamaBarangLangsung
            // 
            this.textBoxNamaBarangLangsung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNamaBarangLangsung.Location = new System.Drawing.Point(822, 29);
            this.textBoxNamaBarangLangsung.Name = "textBoxNamaBarangLangsung";
            this.textBoxNamaBarangLangsung.Size = new System.Drawing.Size(296, 29);
            this.textBoxNamaBarangLangsung.TabIndex = 27;
            // 
            // buttonTambahLangsung
            // 
            this.buttonTambahLangsung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTambahLangsung.Location = new System.Drawing.Point(1127, 25);
            this.buttonTambahLangsung.Margin = new System.Windows.Forms.Padding(6);
            this.buttonTambahLangsung.Name = "buttonTambahLangsung";
            this.buttonTambahLangsung.Size = new System.Drawing.Size(94, 36);
            this.buttonTambahLangsung.TabIndex = 26;
            this.buttonTambahLangsung.Text = "Tambah";
            this.buttonTambahLangsung.UseVisualStyleBackColor = true;
            this.buttonTambahLangsung.Click += new System.EventHandler(this.buttonTambahLangsung_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tambah Langsung:";
            // 
            // buttonBayar
            // 
            this.buttonBayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBayar.Location = new System.Drawing.Point(940, 577);
            this.buttonBayar.Margin = new System.Windows.Forms.Padding(6);
            this.buttonBayar.Name = "buttonBayar";
            this.buttonBayar.Size = new System.Drawing.Size(295, 42);
            this.buttonBayar.TabIndex = 24;
            this.buttonBayar.Text = "Bayar";
            this.buttonBayar.UseVisualStyleBackColor = true;
            this.buttonBayar.Click += new System.EventHandler(this.buttonBayar_Click);
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalHarga.AutoSize = true;
            this.labelTotalHarga.Location = new System.Drawing.Point(936, 502);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(20, 24);
            this.labelTotalHarga.TabIndex = 23;
            this.labelTotalHarga.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(818, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Total Harga:";
            // 
            // textBoxNoBarang
            // 
            this.textBoxNoBarang.Location = new System.Drawing.Point(137, 24);
            this.textBoxNoBarang.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNoBarang.Name = "textBoxNoBarang";
            this.textBoxNoBarang.Size = new System.Drawing.Size(236, 29);
            this.textBoxNoBarang.TabIndex = 20;
            this.textBoxNoBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNoBarang_KeyDown);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBack.Location = new System.Drawing.Point(17, 577);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(106, 42);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Keluar";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "No Barang :";
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 638);
            this.Controls.Add(this.dataGridTransaksi);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.textBoxNamaBarangLangsung);
            this.Controls.Add(this.buttonTambahLangsung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBayar);
            this.Controls.Add(this.labelTotalHarga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNoBarang);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormTransaksi_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTransaksi;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.TextBox textBoxNamaBarangLangsung;
        private System.Windows.Forms.Button buttonTambahLangsung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBayar;
        private System.Windows.Forms.Label labelTotalHarga;
        private System.Windows.Forms.Label label2;
        private TextBoxNumeric textBoxNoBarang;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarang;
        private DataGridViewJumlahHargaColumn harga;
        private DataGridViewNumericColumn jumlahBarang;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipeSatuan;
        private DataGridViewJumlahHargaColumn potonganHarga;
        private DataGridViewJumlahHargaColumn total;
        private System.Windows.Forms.DataGridViewImageColumn hapus;
    }
}