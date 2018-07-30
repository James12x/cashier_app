using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market {
    public partial class FormTransaksi : CustomForm {
        public FormTransaksi() {
            InitializeComponent();
        }

        public List<BarangTransaksi> barangTransaksiList = new List<BarangTransaksi>();

        const int NO_BARANG = 0;
        const int NAMA_BARANG = 1;
        const int HARGA_PERSATUAN = 2;
        const int JUMLAH = 3;
        const int SATUAN = 4;
        const int POTONGAN = 5;
        const int HARGA_TOTAL = 6;

        private void FormTransaksi_Load(object sender, EventArgs e) {
            ClearTable();
        }

        public void ClearTable() {
            barangTransaksiList.Clear();
            dataGridTransaksi.Rows.Clear();

            textBoxNoBarang.Focus();
            labelTotalHarga.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            MenuForm menu = new MenuForm();
            mainForm.Add(menu);
        }

        #region Utilities Method
        public int GetBarangTransaksiIndex(string no_barang) {
            if(no_barang == "") {
                return -1;
            }
            for(int i = 0; i < barangTransaksiList.Count; i++) {
                if(barangTransaksiList[i].AturanBarangList == null) {
                    continue;
                }
                for(int j = 0; j < barangTransaksiList[i].AturanBarangList.Count; j++) {
                    //  CustomMessageBox.Show(no_barang + " : " + barangTransaksiList[i].AturanBarangList[j].barang.no_barang);
                    if(barangTransaksiList[i].AturanBarangList[j].barang.no_barang == no_barang) {

                        return j;
                    }
                }
            }
            return -1;
        }

        public AturanBarang GetBarangTransaksiAturanBarang(string no_barang) {
            if(no_barang == "") {
                return null;
            }
            for(int i = 0; i < barangTransaksiList.Count; i++) {
                if(barangTransaksiList[i].AturanBarangList == null) {
                    continue;
                }
                for(int j = 0; j < barangTransaksiList[i].AturanBarangList.Count; j++) {
                    //  CustomMessageBox.Show(no_barang + " : " + barangTransaksiList[i].AturanBarangList[j].barang.no_barang);
                    if(barangTransaksiList[i].AturanBarangList[j].barang.no_barang == no_barang) {

                        return barangTransaksiList[i].AturanBarangList[j];
                    }
                }
            }
            return null;
        }

        public Barang GetAturanBarangLainDalamKoleksi(string nama_koleksi, string satuan_nama) {
            for(int i = 0; i < barangTransaksiList.Count; i++) {
                if(barangTransaksiList[i].AturanBarangList == null) {
                    continue;
                }
                for(int j = 0; j < barangTransaksiList[i].AturanBarangList.Count; j++) {
                    if(barangTransaksiList[i].AturanBarangList[j].barang.nama_koleksi == nama_koleksi && barangTransaksiList[i].AturanBarangList[j].barang.satuan_nama == satuan_nama) {
                        return barangTransaksiList[i].AturanBarangList[j].barang;
                    }
                }
            }
            return null;
        }

        public bool IsBarangAlreadyInInvoice(string no_barang, out int row) {
            for(int i = 0; i < dataGridTransaksi.Rows.Count; i++) {
                if(dataGridTransaksi.Rows[i].Cells[0].Value.ToString() == no_barang) {
                    row = i;
                    return true;
                }
            }
            row = -1;
            return false;
        }

        public string GetSatuanValue(int row) {
            return dataGridTransaksi[SATUAN, row].Value.ToString();
        }

        public string GetNoBarang(int row) {
            return dataGridTransaksi[NO_BARANG, row].Value.ToString();
        }

        public int GetJumlahValue(int row) {
            return (int)dataGridTransaksi[JUMLAH, row].Value;
        }

        public UInt64 GetHargaJualValue(int row) {
            return (UInt64)dataGridTransaksi[HARGA_PERSATUAN, row].Value;
        }

        public UInt64 GetPotonganValue(int row) {
            return (UInt64)dataGridTransaksi[POTONGAN, row].Value;
        }

        public void SetValueToRow(int row, params object[] data) {
            try {
                int rowTemp = -1;
                if(IsBarangAlreadyInInvoice(data[0].ToString(), out rowTemp)) {
                    if(rowTemp == row) {
                        return;
                    }
                    dataGridTransaksi[JUMLAH, rowTemp].Value = ((int)dataGridTransaksi[JUMLAH, rowTemp].Value) + (int)dataGridTransaksi[JUMLAH, row].Value;
                    dataGridTransaksi.Rows.RemoveAt(row);
                    return;
                }
                for(int i = 0; i < data.Length; i++) {

                    dataGridTransaksi.Rows[row].Cells[i].Value = data[i];
                }
            } catch(Exception e) {
                CustomMessageBox.Show("Error : " + e.Message);
            }
        }

        void SetHargaJualTotal(int row, ulong hargaJual) {
            dataGridTransaksi[HARGA_TOTAL, row].Value = hargaJual;
        }

        void SetHargaJual(int row, ulong hargaJual) {
            dataGridTransaksi[HARGA_PERSATUAN, row].Value = hargaJual;
        }

        void SetJumlah(int row, ulong jumlah) {
            dataGridTransaksi[JUMLAH, row].Value = jumlah;
        }

        void HitungTotal() {
            UInt64 total = 0;
            for(int i = 0; i < dataGridTransaksi.Rows.Count; i++) {
                total += (UInt64)dataGridTransaksi[HARGA_TOTAL, i].Value;
            }
            labelTotalHarga.Text = total.ToString("C", CultureInfo.CreateSpecificCulture("ID"));
            labelTotalHarga.Text = labelTotalHarga.Text.Insert(2, " ");
        }

        void AddBarang() {
            Connection con = new Connection();
            string no_barang = textBoxNoBarang.Text;
            if(!con.IsBarangExist(no_barang)) {
                CustomMessageBox.Show("BARANG TIDK ADA");
                return;
            }
            int row = -1;
            if(IsBarangAlreadyInInvoice(no_barang, out row)) {
                dataGridTransaksi[JUMLAH, row].Value = ((int)dataGridTransaksi[JUMLAH, row].Value) + 1;
                textBoxNoBarang.Text = "";
                return;
            }

            Barang b = con.GetBarang(no_barang);

            BarangTransaksi bt = new BarangTransaksi(con.GetAturanBarangList(b.nama_koleksi));

            TambahBarang(b, bt);
        }

        void TambahBarang(Barang b, BarangTransaksi bt) {
            barangTransaksiList.Add(bt);

            List<string> bs = new List<string>();

            for(int i = 0; i < barangTransaksiList[barangTransaksiList.Count - 1].AturanBarangList?.Count; i++) {
                bs.Add(barangTransaksiList[barangTransaksiList.Count - 1].AturanBarangList[i].barang.satuan_nama);
            }

            dataGridTransaksi.Rows.Add(b.no_barang, b.nama_barang, b.harga_jual, 1, null, 0, b.harga_jual);
            DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dataGridTransaksi[4, dataGridTransaksi.Rows.Count - 1];
            comboCell.Items.Clear();
            if(bs.Count != 0) {
                comboCell.DataSource = bs;
                comboCell.Value = b.satuan_nama;
            } else {
                comboCell.DataSource = new string[] { "buah" };

                comboCell.Value = "buah";
            }



            textBoxNoBarang.Text = "";

            textBoxNoBarang.Focus();
        }
        #endregion

        private void buttonBayar_Click(object sender, EventArgs e) {
            try {
                if(dataGridTransaksi.Rows.Count < 1) {
                    CustomMessageBox.Show("Belum ada barang yang di cek");
                    return;
                }
                BayarForm bayarForm = new BayarForm(labelTotalHarga.Text);
                bayarForm.formTransaksi = this;
                bayarForm.ShowDialog();
                textBoxNoBarang.Focus();
            } catch(Exception ex) {
                CustomMessageBox.Show("Error :  + " + ex.Message);
            }
        }

        private void buttonTambahLangsung_Click(object sender, EventArgs e) {
            try {
                Barang b = new Barang("", textBoxNamaBarangLangsung.Text, 0, 0, 1, "buah", "", "");
                BarangTransaksi bt = new BarangTransaksi(null);

                TambahBarang(b, bt);
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void buttonTambah_Click(object sender, EventArgs e) {
            try {
                AddBarang();
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void dataGridTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            try {
                if(e.ColumnIndex == dataGridTransaksi.Columns.Count - 1 && e.RowIndex >= 0) {
                    barangTransaksiList.RemoveAt(e.RowIndex);
                    dataGridTransaksi.Rows.RemoveAt(e.RowIndex);
                    HitungTotal();
                }
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void dataGridTransaksi_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            try {
                if(this.dataGridTransaksi.IsCurrentCellDirty) {
                    // This fires the cell value changed handler below
                    dataGridTransaksi.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
         
        }

        private void dataGridTransaksi_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            try {
                if(e.ColumnIndex == SATUAN && e.RowIndex >= 0) {
                    //     CustomMessageBox.Show(dataGridTransaksi[4, 0].Value + "");
                    int index = GetBarangTransaksiIndex(GetNoBarang(e.RowIndex));
                    if(index >= 0) {
                        Barang oldBarang = barangTransaksiList[e.RowIndex].AturanBarangList[index].barang;
                        Barang newBarang = GetAturanBarangLainDalamKoleksi(oldBarang.nama_koleksi, GetSatuanValue(e.RowIndex));



                        SetValueToRow(e.RowIndex, newBarang.no_barang, newBarang.nama_barang, newBarang.harga_jual, dataGridTransaksi[3, e.RowIndex].Value, newBarang.satuan_nama, 0);
                    }

                }

                //check the jumlah and adjust the price based on potongan harga
                if(e.ColumnIndex >= 2 && e.RowIndex >= 0) {
                    int jumlah = GetJumlahValue(e.RowIndex);
                    if(jumlah < 1) {
                        SetJumlah(e.RowIndex, 1);
                    }
                    // SetHargaJualTotal(e.RowIndex, GetJumlahValue(e.RowIndex) * GetHargaJualValue(e.RowIndex) - GetPotonganValue(e.RowIndex));
                    ulong jumlahValue = (ulong)GetJumlahValue(e.RowIndex);
                    ulong hargaJual = GetHargaJualValue(e.RowIndex);
                    ulong hargaPotongan = GetPotonganValue(e.RowIndex);

                    ulong hargaAkhir = jumlahValue * hargaJual - hargaPotongan;
                    AturanBarang ab = GetBarangTransaksiAturanBarang(GetNoBarang(e.RowIndex));
                    if(ab != null) {
                        for(int i = 0; i < ab.AturanHarga.Count; i++) {
                            int jumlahAturan = ab.AturanHarga[i].jumlah;
                            if(jumlah == jumlahAturan) {
                                hargaAkhir = ab.AturanHarga[i].harga_jual - hargaPotongan;
                                // SetHargaJualTotal(e.RowIndex, ab.AturanHarga[i].harga_jual);
                                break;
                            }

                            if(jumlah < jumlahAturan && i == 0) {
                                //  hargaAkhir = GetJumlahValue(e.RowIndex) * GetHargaJualValue(e.RowIndex) - GetPotonganValue(e.RowIndex);
                                break;
                            }

                            if(jumlah > jumlahAturan) {
                                int dif = jumlah - jumlahAturan;
                                hargaAkhir = ab.AturanHarga[i].harga_jual + (ulong)dif * GetHargaJualValue(e.RowIndex) - hargaPotongan;
                                // SetHargaJualTotal(e.RowIndex, ab.AturanHarga[i].harga_jual + dif * GetHargaJualValue(e.RowIndex));
                            }
                        }
                    }

                    SetHargaJualTotal(e.RowIndex, hargaAkhir);

                    HitungTotal();
                    //  labelTotalHarga.Text = total.ToString("#,##0"); //string.Format("{#,##0}", total);
                    //  SetValueToRow(e.RowIndex, newBarang.no_barang, newBarang.nama_barang, newBarang.harga_jual, dataGridTransaksi[3, e.RowIndex].Value, newBarang.satuan_nama, 0);
                }
            } catch (Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
            //set new value to row if the combo box satuan is changed
            

        }

        private void textBoxNoBarang_KeyDown(object sender, KeyEventArgs e) {
            try {
                if(e.KeyCode == Keys.Enter) {
                    AddBarang();
                    textBoxNoBarang.Focus();
                    e.SuppressKeyPress = true;
                }
            } catch (Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
            
        }

        private void dataGridTransaksi_CellEnter(object sender, DataGridViewCellEventArgs e) {
            try {
                bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
                var dataGridTransaksi = sender as DataGridView;

                // Check to make sure the cell clicked is the cell containing the combobox 
                if(dataGridTransaksi.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick) {
                    dataGridTransaksi.BeginEdit(true);
                    ((ComboBox)dataGridTransaksi.EditingControl).DroppedDown = true;
                }
            }catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
          
        }

        private void FormTransaksi_MouseClick(object sender, MouseEventArgs e) {
            textBoxNoBarang.Focus();
        }
    }
}
