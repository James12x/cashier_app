using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market {
    public partial class CustomYesNoBox : Form {
        public CustomYesNoBox() {
            InitializeComponent();
        }

        public delegate void YesMethod();

        YesMethod yesMethod;

        
        public CustomYesNoBox(string message, YesMethod yesMethod) {
            try {
                InitializeComponent();
                labelPesan.Text = message;
                this.yesMethod = yesMethod;
            }catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
            
        }

        public static void Show(string message, YesMethod yesMethod) {
            try {
                CustomYesNoBox custom = new CustomYesNoBox(message, yesMethod);
                custom.ShowDialog();
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void CustomYesNoBox_Load(object sender, EventArgs e) {

        }

        private void buttonYes_Click(object sender, EventArgs e) {
            try {
                yesMethod?.Invoke();
                yesMethod = null;
                this.Close();
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void buttonNo_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
