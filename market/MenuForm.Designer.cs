namespace market {
    partial class MenuForm {
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
            this.buttonTransaksi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDataBarang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTransaksi
            // 
            this.buttonTransaksi.Location = new System.Drawing.Point(98, 56);
            this.buttonTransaksi.Name = "buttonTransaksi";
            this.buttonTransaksi.Size = new System.Drawing.Size(210, 78);
            this.buttonTransaksi.TabIndex = 0;
            this.buttonTransaksi.Text = "Transaksi";
            this.buttonTransaksi.UseVisualStyleBackColor = true;
            this.buttonTransaksi.Click += new System.EventHandler(this.buttonTransaksi_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1032, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Keluar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDataBarang
            // 
            this.buttonDataBarang.Location = new System.Drawing.Point(98, 196);
            this.buttonDataBarang.Name = "buttonDataBarang";
            this.buttonDataBarang.Size = new System.Drawing.Size(210, 78);
            this.buttonDataBarang.TabIndex = 3;
            this.buttonDataBarang.Text = "Data Barang";
            this.buttonDataBarang.UseVisualStyleBackColor = true;
            this.buttonDataBarang.Click += new System.EventHandler(this.buttonDataBarang_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 578);
            this.Controls.Add(this.buttonDataBarang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTransaksi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTransaksi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDataBarang;
    }
}