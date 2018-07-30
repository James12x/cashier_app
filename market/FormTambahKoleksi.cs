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
    public partial class FormTambahKoleksi : Form {
        public FormTabelKoleksi formKoleksi;

        public FormTambahKoleksi() {
            InitializeComponent();
        }

        private void FormTambahKoleksi_Load(object sender, EventArgs e) {
            try {
                Connection con = new Connection();
                List<SatuanType> satuanTypeList = con.GetSatuanTypeList();

                comboBoxTipeSatuan.DataSource = satuanTypeList;
            } catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }

        }

        private void buttonTambah_Click(object sender, EventArgs e) {
            try {
                Connection con = new Connection();

                string nama_koleksi = textBoxNamaKoleksi.Text;
                string tipe_satuan = comboBoxTipeSatuan.Text;

                if(con.IsKoleksiExist(nama_koleksi)) {
                    CustomMessageBox.Show("KOLEKSI TELAH ADA. PASTIKAN NAMA KOLEKSI UNIK");
                    return;
                }

                con.InsertBarangKoleksi(nama_koleksi, tipe_satuan);
                CustomMessageBox.Show("Koleksi telah ditambah");
                formKoleksi.TambahKoleksi(nama_koleksi);
                this.Close();
            }catch(Exception ex) {
                CustomMessageBox.Show("Error : " + ex.Message);
            }
            
        }

        private void buttonKeluar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
