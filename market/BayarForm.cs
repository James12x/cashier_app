using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market {
    public partial class BayarForm : Form {
        public FormTransaksi formTransaksi;

        public BayarForm() {
            InitializeComponent();
        }

        public BayarForm(string hargaTotal) {
            try {
                InitializeComponent();
                labelHargaTotal.Text = hargaTotal;
            }catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
            
        }

        private void BayarForm_Load(object sender, EventArgs e) {
            try {
              //  labelKembalian.Text = "0";
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
        }

        private void buttonBayar_Click(object sender, EventArgs e) {
            try {
                if(textBoxPembayaran.Text == "") {
                    CustomMessageBox.Show("Pembayaran tidak boleh kosong");
                    return;
                }
                ulong hargaTotal = parseHargaTotal();
                ulong pembayaran = ulong.Parse(textBoxPembayaran.Text);

                bool lanjut = false;

                void lanjutkan() {
                    lanjut = true;
                }

                if(pembayaran < hargaTotal) {
                    CustomYesNoBox.Show("Pembayaran lebih kecil dari harga total, apakah anda yakin ingin melanjutkan?", lanjutkan);
                } else {
                    lanjut = true;
                }

                if(!lanjut) {
                    return;
                }

                FormSelesaiBayar form = new FormSelesaiBayar(hargaTotal, pembayaran);
                form.ShowDialog();

                this.Close();
                formTransaksi.ClearTable();

            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void textBoxPembayaran_TextChanged(object sender, EventArgs e) {
            try {
               /* ulong hargaTotal = parseHargaTotal();
                ulong pembayaran = 0;
                if(textBoxPembayaran.Text != "") {
                    pembayaran = ulong.Parse(textBoxPembayaran.Text);
                }

                ulong kembalian = pembayaran > hargaTotal ? pembayaran - hargaTotal : 0;
                labelKembalian.Text = parseToStringHarga(kembalian);*/
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void buttonBatal_Click(object sender, EventArgs e) {
            this.Close();
        }

        string parseToStringHarga(ulong harga) {
            string res = harga.ToString("C", CultureInfo.CreateSpecificCulture("ID"));
            res = res.Insert(2, " ");
            return res;
        }

        ulong parseHargaTotal() {
            return ulong.Parse(labelHargaTotal.Text.Substring(3).Replace(".", ""));
        }

        private void buttonPas_Click(object sender, EventArgs e) {
            textBoxPembayaran.Text = parseHargaTotal().ToString();
        }
    }
}
