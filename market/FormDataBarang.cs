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
    public partial class FormDataBarang : CustomForm {
        public FormDataBarang() {
            InitializeComponent();
        }

        void Add(Form form) {
            try {
                panelTabel.Controls.Clear();
                form.TopLevel = false;
                panelTabel.Controls.Add(form);
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void buttonBukaSemua_Click(object sender, EventArgs e) {
            try {

            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
        }

        private void FormDataBarang_Load(object sender, EventArgs e) {
            buttonKoleksi_Click(sender, e);
        }

        private void buttonKoleksi_Click(object sender, EventArgs e) {
            try {
                FormTabelKoleksi formTabelKoleksi = new FormTabelKoleksi();
                formTabelKoleksi.form = this;
                Add(formTabelKoleksi);
                buttonKoleksi.Enabled = false;
                buttonTabelBarang.Enabled = true;
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void buttonTabelBarang_Click(object sender, EventArgs e) {
            try {
                FormTabelBarang formTabelBarang = new FormTabelBarang();
                formTabelBarang.form = this;
                Add(formTabelBarang);
                buttonTabelBarang.Enabled = false;
                buttonKoleksi.Enabled = true;
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
            
        }

        private void buttonKembali_Click(object sender, EventArgs e) {
            this.Close();
            MenuForm menu = new MenuForm();
            mainForm.Add(menu);
        }
    }
}
