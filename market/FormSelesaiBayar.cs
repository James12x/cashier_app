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
    public partial class FormSelesaiBayar : Form {
        public FormSelesaiBayar() {
            InitializeComponent();
        }
        

        string parseToStringHarga(ulong harga) {
            try {
                string res = harga.ToString("C", CultureInfo.CreateSpecificCulture("ID"));
                res = res.Insert(2, " ");
                return res;
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
            return "ERROR ERROR";
        }

        public FormSelesaiBayar(ulong hargaTotal, ulong pembayaran) {
            InitializeComponent();
            try {
                ulong kembalian = 0;
                if(pembayaran > hargaTotal) {
                    kembalian = pembayaran - hargaTotal;
                }

                labelHargaTotal.Text = parseToStringHarga(hargaTotal);
                labelPembayaran.Text = parseToStringHarga(pembayaran);
                labelKembalian.Text = parseToStringHarga(kembalian);
            }catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
          
        }

        private void buttonTutup_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
