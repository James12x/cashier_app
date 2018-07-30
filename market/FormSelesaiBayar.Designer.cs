namespace market {
    partial class FormSelesaiBayar {
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
            this.buttonTutup = new System.Windows.Forms.Button();
            this.buttonPrintStruk = new System.Windows.Forms.Button();
            this.labelPesan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHargaTotal = new System.Windows.Forms.Label();
            this.labelPembayaran = new System.Windows.Forms.Label();
            this.labelKembalian = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTutup
            // 
            this.buttonTutup.Location = new System.Drawing.Point(391, 401);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(98, 48);
            this.buttonTutup.TabIndex = 5;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = true;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // buttonPrintStruk
            // 
            this.buttonPrintStruk.Location = new System.Drawing.Point(53, 401);
            this.buttonPrintStruk.Name = "buttonPrintStruk";
            this.buttonPrintStruk.Size = new System.Drawing.Size(163, 48);
            this.buttonPrintStruk.TabIndex = 4;
            this.buttonPrintStruk.Text = "Print Struk lagi";
            this.buttonPrintStruk.UseVisualStyleBackColor = true;
            // 
            // labelPesan
            // 
            this.labelPesan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPesan.Location = new System.Drawing.Point(28, 9);
            this.labelPesan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPesan.Name = "labelPesan";
            this.labelPesan.Size = new System.Drawing.Size(461, 92);
            this.labelPesan.TabIndex = 3;
            this.labelPesan.Text = "Pembayaran selesai";
            this.labelPesan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Harga Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pembayaran :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kembalian :";
            // 
            // labelHargaTotal
            // 
            this.labelHargaTotal.AutoSize = true;
            this.labelHargaTotal.Location = new System.Drawing.Point(231, 126);
            this.labelHargaTotal.Name = "labelHargaTotal";
            this.labelHargaTotal.Size = new System.Drawing.Size(60, 24);
            this.labelHargaTotal.TabIndex = 9;
            this.labelHargaTotal.Text = "label4";
            // 
            // labelPembayaran
            // 
            this.labelPembayaran.AutoSize = true;
            this.labelPembayaran.Location = new System.Drawing.Point(231, 175);
            this.labelPembayaran.Name = "labelPembayaran";
            this.labelPembayaran.Size = new System.Drawing.Size(60, 24);
            this.labelPembayaran.TabIndex = 10;
            this.labelPembayaran.Text = "label5";
            // 
            // labelKembalian
            // 
            this.labelKembalian.AutoSize = true;
            this.labelKembalian.Location = new System.Drawing.Point(231, 262);
            this.labelKembalian.Name = "labelKembalian";
            this.labelKembalian.Size = new System.Drawing.Size(60, 24);
            this.labelKembalian.TabIndex = 11;
            this.labelKembalian.Text = "label6";
            // 
            // FormSelesaiBayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 482);
            this.Controls.Add(this.labelKembalian);
            this.Controls.Add(this.labelPembayaran);
            this.Controls.Add(this.labelHargaTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonPrintStruk);
            this.Controls.Add(this.labelPesan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormSelesaiBayar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelesaiBayar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.Button buttonPrintStruk;
        private System.Windows.Forms.Label labelPesan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHargaTotal;
        private System.Windows.Forms.Label labelPembayaran;
        private System.Windows.Forms.Label labelKembalian;
    }
}