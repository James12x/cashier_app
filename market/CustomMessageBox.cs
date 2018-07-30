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
    public partial class CustomMessageBox : Form {
        public CustomMessageBox() {
            InitializeComponent();
        }

        public static void Show(string message) {
            try {
                CustomMessageBox custom = new CustomMessageBox();
                custom.labelMessage.Text = message;
                custom.ShowDialog();
            }catch(Exception ex) {
                MessageBox.Show("ERROR BESAR, HUBUNGI ELTON, error message : \"" + ex.Message + "\"");
            }
            
        }

        

        private void buttonOk_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
