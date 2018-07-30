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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

        }

        public void Add(CustomForm form) {
            try {
                form.mainForm = this;
                panelShow.Controls.Clear();
                form.TopLevel = false;
                panelShow.Controls.Add(form);
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void MainForm_Load(object sender, EventArgs e) {
            try {
                Connection con = new Connection();
                if(!con.Connect()) {
                    CustomMessageBox.Show("PASTIKAN APACHE DAN MYSQL PADA XAMPP TELAH DIJALANKAN \n JIKA TETAP ADA MASALAH HUBUNGI ELTON");
                    this.Close();
                    return;
                }
                LoginForm login = new LoginForm();
                Add(login);
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }
    }
}
