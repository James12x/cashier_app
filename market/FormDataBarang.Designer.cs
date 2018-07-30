namespace market {
    partial class FormDataBarang {
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
            this.panelTabel = new System.Windows.Forms.Panel();
            this.buttonKoleksi = new System.Windows.Forms.Button();
            this.buttonTabelBarang = new System.Windows.Forms.Button();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelTabel
            // 
            this.panelTabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTabel.BackColor = System.Drawing.Color.White;
            this.panelTabel.Location = new System.Drawing.Point(12, 65);
            this.panelTabel.Name = "panelTabel";
            this.panelTabel.Size = new System.Drawing.Size(1268, 534);
            this.panelTabel.TabIndex = 0;
            // 
            // buttonKoleksi
            // 
            this.buttonKoleksi.Location = new System.Drawing.Point(12, 12);
            this.buttonKoleksi.Name = "buttonKoleksi";
            this.buttonKoleksi.Size = new System.Drawing.Size(161, 38);
            this.buttonKoleksi.TabIndex = 1;
            this.buttonKoleksi.Text = "Tabel Koleksi";
            this.buttonKoleksi.UseVisualStyleBackColor = true;
            this.buttonKoleksi.Click += new System.EventHandler(this.buttonKoleksi_Click);
            // 
            // buttonTabelBarang
            // 
            this.buttonTabelBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTabelBarang.Location = new System.Drawing.Point(1112, 12);
            this.buttonTabelBarang.Name = "buttonTabelBarang";
            this.buttonTabelBarang.Size = new System.Drawing.Size(168, 38);
            this.buttonTabelBarang.TabIndex = 2;
            this.buttonTabelBarang.Text = "Tabel Barang";
            this.buttonTabelBarang.UseVisualStyleBackColor = true;
            this.buttonTabelBarang.Click += new System.EventHandler(this.buttonTabelBarang_Click);
            // 
            // buttonKembali
            // 
            this.buttonKembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonKembali.Location = new System.Drawing.Point(12, 612);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(161, 38);
            this.buttonKembali.TabIndex = 3;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // FormDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 662);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.buttonTabelBarang);
            this.Controls.Add(this.buttonKoleksi);
            this.Controls.Add(this.panelTabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormDataBarang";
            this.Text = "FormDataBarang";
            this.Load += new System.EventHandler(this.FormDataBarang_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTabel;
        private System.Windows.Forms.Button buttonKoleksi;
        private System.Windows.Forms.Button buttonTabelBarang;
        private System.Windows.Forms.Button buttonKembali;
    }
}