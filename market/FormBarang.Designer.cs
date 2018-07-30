namespace market {
    partial class FormBarang {
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
            this.buttonPlus = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridHargaJualData = new System.Windows.Forms.DataGridView();
            this.jumlahData = new market.DataGridViewNumericColumn();
            this.harga = new market.DataGridViewJumlahHargaColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSatuan = new System.Windows.Forms.ComboBox();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelesai = new System.Windows.Forms.Button();
            this.labelTipeSatuan = new System.Windows.Forms.Label();
            this.labelTambahEdit = new System.Windows.Forms.Label();
            this.dataGridViewNumericColumn1 = new market.DataGridViewNumericColumn();
            this.dataGridViewJumlahHargaColumn1 = new market.DataGridViewJumlahHargaColumn();
            this.textBoxHargaBeli = new market.TextBoxNumeric();
            this.textBoxNoBarangDaftar = new market.TextBoxNumeric();
            this.textBoxHargaJual = new market.TextBoxNumeric();
            this.buttonKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHargaJualData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(665, 89);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(42, 40);
            this.buttonPlus.TabIndex = 77;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 24);
            this.label10.TabIndex = 75;
            this.label10.Text = "Harga Beli:";
            // 
            // dataGridHargaJualData
            // 
            this.dataGridHargaJualData.AllowUserToAddRows = false;
            this.dataGridHargaJualData.AllowUserToDeleteRows = false;
            this.dataGridHargaJualData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridHargaJualData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridHargaJualData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHargaJualData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jumlahData,
            this.harga,
            this.delete});
            this.dataGridHargaJualData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridHargaJualData.Location = new System.Drawing.Point(301, 140);
            this.dataGridHargaJualData.Name = "dataGridHargaJualData";
            this.dataGridHargaJualData.Size = new System.Drawing.Size(406, 423);
            this.dataGridHargaJualData.TabIndex = 74;
            this.dataGridHargaJualData.TabStop = false;
            this.dataGridHargaJualData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHargaJualData_CellContentClick);
            this.dataGridHargaJualData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHargaJualData_CellEndEdit);
            // 
            // jumlahData
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.jumlahData.DefaultCellStyle = dataGridViewCellStyle1;
            this.jumlahData.HeaderText = "Jumlah";
            this.jumlahData.Name = "jumlahData";
            this.jumlahData.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jumlahData.Width = 96;
            // 
            // harga
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.harga.DefaultCellStyle = dataGridViewCellStyle2;
            this.harga.HeaderText = "Harga Jual";
            this.harga.MinimumWidth = 8;
            this.harga.Name = "harga";
            this.harga.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.harga.Width = 125;
            // 
            // delete
            // 
            this.delete.HeaderText = "Hapus";
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Width = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 72;
            this.label6.Text = "Tipe Satuan:";
            // 
            // comboBoxSatuan
            // 
            this.comboBoxSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSatuan.FormattingEnabled = true;
            this.comboBoxSatuan.Location = new System.Drawing.Point(36, 353);
            this.comboBoxSatuan.Name = "comboBoxSatuan";
            this.comboBoxSatuan.Size = new System.Drawing.Size(232, 32);
            this.comboBoxSatuan.TabIndex = 2;
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaBarang.Location = new System.Drawing.Point(36, 182);
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.Size = new System.Drawing.Size(232, 29);
            this.textBoxNamaBarang.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 71;
            this.label5.Text = "Atur Harga Jual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 69;
            this.label4.Text = "Harga Jual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 67;
            this.label3.Text = "Satuan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 65;
            this.label2.Text = "Nama Barang:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "No Barang:";
            // 
            // buttonSelesai
            // 
            this.buttonSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelesai.Location = new System.Drawing.Point(514, 601);
            this.buttonSelesai.Name = "buttonSelesai";
            this.buttonSelesai.Size = new System.Drawing.Size(193, 41);
            this.buttonSelesai.TabIndex = 5;
            this.buttonSelesai.Text = "Selesai";
            this.buttonSelesai.UseVisualStyleBackColor = true;
            this.buttonSelesai.Click += new System.EventHandler(this.buttonSelesai_Click);
            // 
            // labelTipeSatuan
            // 
            this.labelTipeSatuan.AutoSize = true;
            this.labelTipeSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipeSatuan.Location = new System.Drawing.Point(32, 277);
            this.labelTipeSatuan.Name = "labelTipeSatuan";
            this.labelTipeSatuan.Size = new System.Drawing.Size(140, 24);
            this.labelTipeSatuan.TabIndex = 79;
            this.labelTipeSatuan.Text = "tipeSatuanHere";
            // 
            // labelTambahEdit
            // 
            this.labelTambahEdit.AutoSize = true;
            this.labelTambahEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTambahEdit.Location = new System.Drawing.Point(297, 19);
            this.labelTambahEdit.Name = "labelTambahEdit";
            this.labelTambahEdit.Size = new System.Drawing.Size(157, 24);
            this.labelTambahEdit.TabIndex = 80;
            this.labelTambahEdit.Text = "Tambah atau Edit";
            // 
            // dataGridViewNumericColumn1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewNumericColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewNumericColumn1.HeaderText = "Jumlah";
            this.dataGridViewNumericColumn1.Name = "dataGridViewNumericColumn1";
            this.dataGridViewNumericColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNumericColumn1.Width = 65;
            // 
            // dataGridViewJumlahHargaColumn1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewJumlahHargaColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewJumlahHargaColumn1.HeaderText = "Harga Jual";
            this.dataGridViewJumlahHargaColumn1.MinimumWidth = 8;
            this.dataGridViewJumlahHargaColumn1.Name = "dataGridViewJumlahHargaColumn1";
            this.dataGridViewJumlahHargaColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJumlahHargaColumn1.Width = 83;
            // 
            // textBoxHargaBeli
            // 
            this.textBoxHargaBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHargaBeli.Location = new System.Drawing.Point(36, 431);
            this.textBoxHargaBeli.Name = "textBoxHargaBeli";
            this.textBoxHargaBeli.Size = new System.Drawing.Size(229, 29);
            this.textBoxHargaBeli.TabIndex = 3;
            // 
            // textBoxNoBarangDaftar
            // 
            this.textBoxNoBarangDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoBarangDaftar.Location = new System.Drawing.Point(36, 105);
            this.textBoxNoBarangDaftar.Name = "textBoxNoBarangDaftar";
            this.textBoxNoBarangDaftar.Size = new System.Drawing.Size(232, 29);
            this.textBoxNoBarangDaftar.TabIndex = 0;
            // 
            // textBoxHargaJual
            // 
            this.textBoxHargaJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHargaJual.Location = new System.Drawing.Point(36, 509);
            this.textBoxHargaJual.Name = "textBoxHargaJual";
            this.textBoxHargaJual.Size = new System.Drawing.Size(229, 29);
            this.textBoxHargaJual.TabIndex = 4;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.Location = new System.Drawing.Point(36, 601);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(193, 41);
            this.buttonKeluar.TabIndex = 81;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = true;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 666);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.labelTambahEdit);
            this.Controls.Add(this.labelTipeSatuan);
            this.Controls.Add(this.buttonSelesai);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxHargaBeli);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridHargaJualData);
            this.Controls.Add(this.textBoxNoBarangDaftar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSatuan);
            this.Controls.Add(this.textBoxHargaJual);
            this.Controls.Add(this.textBoxNamaBarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHargaJualData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlus;
        private TextBoxNumeric textBoxHargaBeli;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridHargaJualData;
        private TextBoxNumeric textBoxNoBarangDaftar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSatuan;
        private TextBoxNumeric textBoxHargaJual;
        private System.Windows.Forms.TextBox textBoxNamaBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelesai;
        private System.Windows.Forms.Label labelTipeSatuan;
        private System.Windows.Forms.Label labelTambahEdit;
        private DataGridViewNumericColumn jumlahData;
        private DataGridViewJumlahHargaColumn harga;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private DataGridViewNumericColumn dataGridViewNumericColumn1;
        private DataGridViewJumlahHargaColumn dataGridViewJumlahHargaColumn1;
        private System.Windows.Forms.Button buttonKeluar;
    }
}