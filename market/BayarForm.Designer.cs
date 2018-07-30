namespace market {
    partial class BayarForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelHargaTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBayar = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPas = new System.Windows.Forms.Button();
            this.textBoxPembayaran = new market.TextBoxNumeric();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harga Total:";
            // 
            // labelHargaTotal
            // 
            this.labelHargaTotal.AutoSize = true;
            this.labelHargaTotal.Location = new System.Drawing.Point(165, 34);
            this.labelHargaTotal.Name = "labelHargaTotal";
            this.labelHargaTotal.Size = new System.Drawing.Size(100, 24);
            this.labelHargaTotal.TabIndex = 1;
            this.labelHargaTotal.Text = "hargaHere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pembayaran:";
            // 
            // buttonBayar
            // 
            this.buttonBayar.Location = new System.Drawing.Point(397, 410);
            this.buttonBayar.Name = "buttonBayar";
            this.buttonBayar.Size = new System.Drawing.Size(125, 45);
            this.buttonBayar.TabIndex = 6;
            this.buttonBayar.Text = "Bayar";
            this.buttonBayar.UseVisualStyleBackColor = true;
            this.buttonBayar.Click += new System.EventHandler(this.buttonBayar_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(41, 422);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(100, 33);
            this.buttonBatal.TabIndex = 7;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rp";
            // 
            // buttonPas
            // 
            this.buttonPas.Location = new System.Drawing.Point(398, 107);
            this.buttonPas.Name = "buttonPas";
            this.buttonPas.Size = new System.Drawing.Size(124, 34);
            this.buttonPas.TabIndex = 10;
            this.buttonPas.Text = "Harga pas";
            this.buttonPas.UseVisualStyleBackColor = true;
            this.buttonPas.Click += new System.EventHandler(this.buttonPas_Click);
            // 
            // textBoxPembayaran
            // 
            this.textBoxPembayaran.Location = new System.Drawing.Point(205, 109);
            this.textBoxPembayaran.Name = "textBoxPembayaran";
            this.textBoxPembayaran.Size = new System.Drawing.Size(177, 29);
            this.textBoxPembayaran.TabIndex = 3;
            this.textBoxPembayaran.TextChanged += new System.EventHandler(this.textBoxPembayaran_TextChanged);
            // 
            // BayarForm
            // 
            this.AcceptButton = this.buttonBayar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 482);
            this.Controls.Add(this.buttonPas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonBayar);
            this.Controls.Add(this.textBoxPembayaran);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHargaTotal);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BayarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BayarForm";
            this.Load += new System.EventHandler(this.BayarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHargaTotal;
        private System.Windows.Forms.Label label2;
        private TextBoxNumeric textBoxPembayaran;
        private System.Windows.Forms.Button buttonBayar;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPas;
    }
}