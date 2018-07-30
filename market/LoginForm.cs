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
    public partial class LoginForm : CustomForm {

        public LoginForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            /*   Connection con = new Connection();

               Barang asd = con.GetBarang("12345");

               MessageBox.Show($@"no_barang: {asd.no_barang}, 
                                   nama barang: {asd.nama_barang}, 
                                   harga_beli: {asd.harga_beli}, 
                                   harga_jual: {asd.harga_jual}, 
                                   satuan_id: {asd.satuan_id}, 
                                   satuan_nama: {asd.satuan_nama},
                                   satuan_tipe: {asd.satuan_tipe}");*/
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            try {
                MenuForm menuForm = new MenuForm();
                mainForm.Add(menuForm);
            }catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
          
           /* Transaction transaction = new Transaction();
            mainForm.AddForm(transaction);*/
        }
    }
}
