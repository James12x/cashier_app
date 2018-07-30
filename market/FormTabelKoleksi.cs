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
    public partial class FormTabelKoleksi : Form {
        public FormDataBarang form;
        public FormTabelKoleksi() {
            InitializeComponent();
        }

        private void buttonTampilkanSemua_Click(object sender, EventArgs e) {
            try {
                dataGridViewBarang.Rows.Clear();
                Connection con = new Connection();

                List<Koleksi> koleksi = con.GetAllKoleksi();

                for(int i = 0; i < koleksi.Count; i++) {
                    dataGridViewBarang.Rows.Add(koleksi[i].NamaKoleksi, koleksi[i].TipeSatuan, koleksi[i].JumlahBarang);
                }
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void dataGridViewBarang_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            try {
                if(e.RowIndex >= 0 && e.ColumnIndex == dataGridViewBarang.Columns.Count - 2) {
                    //pilih
                    FormIsiKoleksi formKoleksi = new FormIsiKoleksi();
                    formKoleksi.UpdateTabel(dataGridViewBarang.Rows[e.RowIndex].Cells[0].Value.ToString());
                    form.mainForm.Add(formKoleksi);
                }else if(e.RowIndex >= 0 && e.ColumnIndex == dataGridViewBarang.Columns.Count - 1) {
                    //hapus
                    Connection con = new Connection();
                    string nama_koleksi = dataGridViewBarang.Rows[e.RowIndex].Cells[0].Value.ToString();

                    if(!con.IsKoleksiExist(nama_koleksi)) {
                        CustomMessageBox.Show("Koleksi tersebut tidak ada");
                        return;
                    }

                    void Yes() {
                        con.DeleteKoleksi(nama_koleksi);
                        dataGridViewBarang.Rows.RemoveAt(e.RowIndex);
                    }

                    CustomYesNoBox.Show("Apakah anda yakin ingin menghapus koleksi : " + nama_koleksi + "? \n Semua barang pada koleksi tersebut akan ikut terhapus", Yes);
                }
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        public void TambahKoleksi(string newKoleksi) {
            try {
                Connection con = new Connection();
                Koleksi koleksi = con.GetKoleksiData(newKoleksi);
                dataGridViewBarang.Rows.Add(koleksi.NamaKoleksi, koleksi.TipeSatuan, koleksi.JumlahBarang);
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void buttonTambahKoleksi_Click(object sender, EventArgs e) {
            try {
                FormTambahKoleksi form = new FormTambahKoleksi();
                form.formKoleksi = this;
                form.ShowDialog();
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
           
        }

        private void buttonCari_Click(object sender, EventArgs e) {
            try {
                dataGridViewBarang.Rows.Clear();
                Connection con = new Connection();

                List<Koleksi> koleksi = con.GetAllKoleksiByName(textBoxKoleksi.Text);

                for(int i = 0; i < koleksi.Count; i++) {
                    dataGridViewBarang.Rows.Add(koleksi[i].NamaKoleksi, koleksi[i].TipeSatuan, koleksi[i].JumlahBarang);
                }
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
