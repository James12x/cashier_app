namespace market {
    partial class CustomYesNoBox {
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
            this.labelPesan = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPesan
            // 
            this.labelPesan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPesan.Location = new System.Drawing.Point(27, 20);
            this.labelPesan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPesan.Name = "labelPesan";
            this.labelPesan.Size = new System.Drawing.Size(464, 275);
            this.labelPesan.TabIndex = 0;
            this.labelPesan.Text = "Pesan Here";
            this.labelPesan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(362, 330);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(98, 48);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(69, 330);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 48);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // CustomYesNoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 414);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelPesan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CustomYesNoBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomYesNoBox";
            this.Load += new System.EventHandler(this.CustomYesNoBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPesan;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonCancel;
    }
}