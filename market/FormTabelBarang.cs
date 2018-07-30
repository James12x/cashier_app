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
    public partial class FormTabelBarang : Form {
        public FormDataBarang form;
        public FormTabelBarang() {
            InitializeComponent();
        }

        private void buttonCariNamaBarang_Click(object sender, EventArgs e) {
            try {
                Connection con = new Connection();
                string nama_barang = textBoxNamaBarang.Text;

                if(textBoxNamaBarang.Text == "") {
                    CustomMessageBox.Show("Nama barang tidak boleh kosong");
                }

                /* if(con.IsBarangWithNameExist(nama_barang)) {
                     CustomMessageBox.Show($"TIDAK ADA BARANG DENGAN NAMA '{nama_barang}'");
                     return;
                 }*/
                dataGridViewTabelBarang.Rows.Clear();

                List<Barang> barangList = con.GetBarangListByName(nama_barang);
                for(int i = 0; i < barangList.Count; i++) {
                    dataGridViewTabelBarang.Rows.Add(barangList[i].no_barang, barangList[i].nama_barang, barangList[i].harga_beli, barangList[i].harga_jual,
                                                    barangList[i].satuan_tipe, barangList[i].satuan_nama, barangList[i].nama_koleksi);
                }
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
        }

        private void dataGridViewTabelBarang_CellContentClick(object sender, DataGridViewCellEventArgs e) {
              try {
                if(e.RowIndex >= 0 && e.ColumnIndex == dataGridViewTabelBarang.Columns.Count - 1) {
                    //pilih
                    FormIsiKoleksi formKoleksi = new FormIsiKoleksi();
                    formKoleksi.UpdateTabel(dataGridViewTabelBarang.Rows[e.RowIndex].Cells[dataGridViewTabelBarang.Columns.Count - 2].Value.ToString());
                    form.mainForm.Add(formKoleksi);
                }
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
            
        }

        private void buttonCariNoBarang_Click(object sender, EventArgs e) {
            try {
                Connection con = new Connection();
                string no_barang = textBoxNomorBarang.Text;

                if(textBoxNomorBarang.Text == "") {
                    CustomMessageBox.Show("No barang tidak boleh kosong");
                }

               // MessageBox.Show(no_barang);

                if(!con.IsBarangExist(no_barang)) {
                    CustomMessageBox.Show($"BARANG DENGAN NO BARANG '{no_barang}' TIDAK ADA");
                    return;
                }

                Barang b = con.GetBarang(no_barang);
                dataGridViewTabelBarang.Rows.Clear();

                dataGridViewTabelBarang.Rows.Add(b.no_barang, b.nama_barang, b.harga_beli, b.harga_jual,
                                                    b.satuan_tipe, b.satuan_nama, b.nama_koleksi);
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }
    }
}
