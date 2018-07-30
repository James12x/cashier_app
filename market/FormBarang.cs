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
    public partial class FormBarang : Form {
        FormIsiKoleksi formIsiKoleksi;

        AturanBarang aturanBarang;
        List<Satuan> satuanList = new List<Satuan>();

        public delegate void Selesai();

        Koleksi koleksi;

        bool tambahBarang;

        public bool CustomErrorMessage(params object[] data) {
            string errorMessage = "";

            for(int i = 0; i < data.Length; i += 2) {
                TextBox txtBox = (TextBox)data[i];
                if(txtBox.Text == "") {
                    errorMessage += ("- " + data[i + 1] + " \n");
                }
            }

            if(errorMessage != "") {
                CustomMessageBox.Show(errorMessage);
                return true;
            }
            return false;
        }

        public void InitialisasiEditBarang(Barang dataBarang, Koleksi dataKoleksi, FormIsiKoleksi form) {
            try {
                koleksi = dataKoleksi;
                formIsiKoleksi = form;
                Connection con = new Connection();

                aturanBarang = con.GetAturanBarang(dataBarang.no_barang);
                

                //isi textbox dan combobox
                labelTipeSatuan.Text = dataBarang.satuan_tipe;

                textBoxNoBarangDaftar.Text = aturanBarang.barang.no_barang;
                textBoxNamaBarang.Text = aturanBarang.barang.nama_barang;
                textBoxHargaBeli.Text = aturanBarang.barang.harga_beli.ToString();
                textBoxHargaJual.Text = aturanBarang.barang.harga_jual.ToString();
                labelTipeSatuan.Text = aturanBarang.barang.satuan_tipe;

                satuanList = con.GetSatuanList(aturanBarang.barang.satuan_tipe);

                comboBoxSatuan.DataSource = satuanList;
                comboBoxSatuan.Text = aturanBarang.barang.satuan_nama;
                //selesai isi


                //isi aturan harga
                void AddDataToDataGrid(params object[] data) {
                    dataGridHargaJualData.Rows.Add(data[0], data[1]);
                }
                for(int i = 0; i < aturanBarang.AturanHarga.Count; i++) {
                    AddDataToDataGrid(aturanBarang.AturanHarga[i].jumlah, aturanBarang.AturanHarga[i].harga_jual);
                }

                //selesai isi


                textBoxNoBarangDaftar.Enabled = false;

                tambahBarang = false;

                labelTambahEdit.Text = "Edit Barang";
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
           
        }

        public void InitialisasiTambahBarang(Koleksi dataKoleksi, FormIsiKoleksi form) {
            try {
                formIsiKoleksi = form;
                Connection con = new Connection();

                koleksi = dataKoleksi;

                satuanList = con.GetSatuanList(koleksi.TipeSatuan);
                comboBoxSatuan.DataSource = satuanList;
                labelTipeSatuan.Text = koleksi.TipeSatuan;

                

                tambahBarang = true;
                labelTambahEdit.Text = "Tambah Barang";
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }
        
        public FormBarang() {
            InitializeComponent();
        }

        private void buttonSelesai_Click(object sender, EventArgs e) {
            //try {
                //Error cek dimulai
                if(CustomErrorMessage(textBoxNoBarangDaftar, "No Barang tidak boleh kosong",
                                    textBoxNamaBarang, "Nama barang tidak boleh kosong",
                                    textBoxHargaBeli, "Haraga beli tidak boleh kosong",
                                    textBoxHargaJual, "Harga jual tidak boleh kosong")) {
                    return;
                }

                for(int i = 0; i < dataGridHargaJualData.Rows.Count; i++) {
                    for(int j = 0; j < dataGridHargaJualData.Rows[i].Cells.Count; j++) {
                        if(dataGridHargaJualData.Rows[i].Cells[j].ColumnIndex < 2) {
                            if(j == 0) {
                                if((int)dataGridHargaJualData.Rows[i].Cells[j].Value <= 0) {
                                    CustomMessageBox.Show("Kolom jumlah pada tabel harga jual tidak boleh 0 ke bawah");
                                    return;
                                }
                            } else {
                                if((ulong)dataGridHargaJualData.Rows[i].Cells[j].Value <= 0) {
                                    CustomMessageBox.Show("Kolom jumlah pada tabel harga jual tidak boleh 0 ke bawah");
                                    return;
                                }
                            }
                            if(dataGridHargaJualData.Rows[i].Cells[j].Value.ToString() == "" || dataGridHargaJualData.Rows[i].Cells[j].Value == null) {
                                CustomMessageBox.Show("Tabel harga jual tidak boleh ada yang kosong");
                                return;
                            }
                        }
                    }
                }

                List<string> jumlahList = new List<string>();

                for(int i = 0; i < dataGridHargaJualData.Rows.Count; i++) {
                    for(int j = 0; j < dataGridHargaJualData.Rows[i].Cells.Count; j++) {
                        if(dataGridHargaJualData.Rows[i].Cells[j].ColumnIndex == 0) {
                            jumlahList.Add(dataGridHargaJualData.Rows[i].Cells[j].Value.ToString());
                            break;
                        }
                    }
                }
                for(int i = 0; i < jumlahList.Count; i++) {
                    for(int j = i + 1; j < jumlahList.Count; j++) {
                        if(jumlahList[i] == jumlahList[j]) {
                            CustomMessageBox.Show("Jumlah tidak boleh ada yang sama");
                            return;
                        }
                    }
                }

                string no_barang = textBoxNoBarangDaftar.Text;
                string nama_barang = textBoxNamaBarang.Text;
                string satuan_tipe = labelTipeSatuan.Text;
                string nama_satuan = comboBoxSatuan.Text;

                string nama_koleksi = koleksi.NamaKoleksi;

                int GetSatuanID(string satuan) {
                    for(int i = 0; i < satuanList.Count; i++) {
                        if(satuanList[i].SatuanName == satuan) {
                            return satuanList[i].Id;
                        }
                    }
                    return -1;
                }

                int satuan_id = GetSatuanID(nama_satuan);

                UInt64 harga_beli = UInt64.Parse(textBoxHargaBeli.Text);
                UInt64 harga_jual = UInt64.Parse(textBoxHargaJual.Text);

                if(harga_jual < harga_beli) {
                    CustomMessageBox.Show("Harga jual tidak boleh di bawah harga beli");
                    return;
                }


                //error cek selesai, mulai proses data



                Connection con = new Connection();

                //cek validasi data dan insert
                if(tambahBarang) {
                    if(con.IsBarangExist(no_barang)) {
                        CustomMessageBox.Show("Barang dengan nomor barang : " + no_barang + " telah ada, nomor barang tidak boleh sama");
                        return;
                    }

                    if(!con.IsKoleksiExist(nama_koleksi)) {
                        CustomMessageBox.Show("KOLEKSI TIDAK DITEMUKAN. PASTIKAN NAMA KOLEKSI BENAR ATAU BUAT KOLEKSI BARU");
                        return;
                    }

                    if(con.IsSatuanExisInKoleksi(nama_koleksi, satuan_id)) {
                        CustomMessageBox.Show("Satuan -" + nama_satuan + "- telah ada pada koleksi tersebut, gunakan satuan yang lain");
                        return;
                    }

                    object[] dataBarang = new object[] { no_barang, nama_barang, satuan_id, harga_beli, harga_jual, nama_koleksi };

                    con.InsertBarang(dataBarang);
                    for(int i = 0; i < dataGridHargaJualData.Rows.Count; i++) {
                        var dataRes = dataGridHargaJualData.Rows[i].Cells;
                        object[] dataPotongan = new object[] { no_barang, dataRes[0].Value, dataRes[1].Value };
                        con.InsertBarangPotongan(dataPotongan);
                    }

                    CustomMessageBox.Show("Barang telah di tambah");
                }
                //cek validasi data dan edit
                else {
                    if(!con.IsBarangExist(no_barang)) {
                        CustomMessageBox.Show("Barang dengan nomor barang : " + no_barang + " tidak ada, ada masalah BESAR, tolong hubungi Elton");
                        return;
                    }

                    if(!con.IsKoleksiExist(nama_koleksi)) {
                        CustomMessageBox.Show("KOLEKSI TIDAK DITEMUKAN. PASTIKAN NAMA KOLEKSI BENAR ATAU BUAT KOLEKSI BARU");
                        return;
                    }

                    Barang data = new Barang(no_barang, nama_barang, harga_beli, harga_jual, satuan_id, "", satuan_tipe, nama_koleksi);
                    con.UpdateBarang(data);

                    AturanBarang barangBaru = new AturanBarang(data);
                    List<AturanHargaJual> aturanHargaJual = new List<AturanHargaJual>();
                    for(int i = 0; i < dataGridHargaJualData.Rows.Count; i++) {
                        aturanHargaJual.Add(new AturanHargaJual((int)dataGridHargaJualData.Rows[i].Cells[0].Value, (ulong)dataGridHargaJualData.Rows[i].Cells[1].Value));
                    }
                    barangBaru.AturanHarga = aturanHargaJual;
                    con.SimpanJumlahPotongan(barangBaru);

                    CustomMessageBox.Show("Barang telah di edit");
                }
                this.Close();
                formIsiKoleksi.UpdateTabel(koleksi.NamaKoleksi);

        /*    } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }*/
            
        }

        private void dataGridHargaJualData_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            try {
                if(e.RowIndex >= 0 && e.ColumnIndex == dataGridHargaJualData.Columns.Count - 1) {
                    //hapuss
                    dataGridHargaJualData.Rows.RemoveAt(e.RowIndex);
                }
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
           
        }

        private void buttonPlus_Click(object sender, EventArgs e) {
            try {
                dataGridHargaJualData.Rows.Add(5, 1000);
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
           
        }

        private void dataGridHargaJualData_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            try {
                labelTambahEdit.Select();
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
            
        }

        private void buttonKeluar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
