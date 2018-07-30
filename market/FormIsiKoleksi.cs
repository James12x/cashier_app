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
    public partial class FormIsiKoleksi : CustomForm {
        public Koleksi koleksi;

        public FormIsiKoleksi() {
            InitializeComponent();
        }

        public void UpdateTabel(string nama_koleksi) {
            try {
                dataGridViewTabelBarang.Rows.Clear();
                Connection con = new Connection();

                koleksi = con.GetKoleksiData(nama_koleksi);

                labelKoleksi.Text = koleksi.NamaKoleksi;

                List<Barang> listBarang = con.GetBarangListByKoleksi(koleksi.NamaKoleksi);

                for(int i = 0; i < listBarang.Count; i++) {
                    dataGridViewTabelBarang.Rows.Add(listBarang[i].no_barang, listBarang[i].nama_barang, listBarang[i].harga_beli, listBarang[i].harga_jual,
                                                    listBarang[i].satuan_tipe, listBarang[i].satuan_nama);
                }
            }catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
           
        }

        private void dataGridViewTabelBarang_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            try {
                if(e.RowIndex >= 0 && e.ColumnIndex == dataGridViewTabelBarang.Columns.Count - 2) {
                    //ubah
                    Connection con = new Connection();

                    Barang b = con.GetBarang(dataGridViewTabelBarang.Rows[e.RowIndex].Cells[0].Value.ToString());

                    FormBarang formBarang = new FormBarang();
                    formBarang.InitialisasiEditBarang(b, koleksi, this);
                    formBarang.ShowDialog();

                } else if(e.RowIndex >= 0 && e.ColumnIndex == dataGridViewTabelBarang.Columns.Count - 1) {
                    //hapus
                    void Hapus() {
                        Connection con = new Connection();
                        string no_barang = dataGridViewTabelBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
                        if(con.IsBarangExist(no_barang)) {
                            con.DeleteBarang(dataGridViewTabelBarang.Rows[e.RowIndex].Cells[0].Value.ToString());
                            //   dataGridViewTabelBarang.Rows.RemoveAt(e.RowIndex);
                            CustomMessageBox.Show("Barang telah dihapus");
                            UpdateTabel(koleksi.NamaKoleksi);
                        } else {
                            CustomMessageBox.Show("Barang dengan nomor : " + no_barang + " tidak ditemukan, masalah terjadi, harap hubungi elton");
                        }
                    }

                    CustomYesNoBox.Show("Apakah anda yakin untuk menghapus barang ini?", Hapus);
                }
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void buttonTambahBarang_Click(object sender, EventArgs e) {
            try {
                FormBarang formBarang = new FormBarang();
                formBarang.InitialisasiTambahBarang(koleksi, this);
                formBarang.ShowDialog();
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void buttonKembali_Click(object sender, EventArgs e) {
            try {
                this.Close();
                FormDataBarang form = new FormDataBarang();
                mainForm.Add(form);
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
