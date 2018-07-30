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
    public partial class MenuForm : CustomForm {

        public MenuForm() {
            InitializeComponent();
        }

        private void buttonTransaksi_Click(object sender, EventArgs e) {
            try {
                FormTransaksi transaction = new FormTransaksi();
                mainForm.Add(transaction);
            }catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
           
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                mainForm.Close();
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void buttonDataBarang_Click(object sender, EventArgs e) {
            try {
                FormDataBarang dataBarang = new FormDataBarang();
                mainForm.Add(dataBarang);
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }
    }
}
