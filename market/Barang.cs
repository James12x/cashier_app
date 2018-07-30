using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market {
    public class Barang {
        public string no_barang;
        public string nama_barang;
        public UInt64 harga_beli;
        public UInt64 harga_jual;
        public int satuan_id;
        public string satuan_nama;
        public string satuan_tipe;
        public string nama_koleksi;

        public Barang() {
            no_barang = "-1";
        }

        public bool IsEmpty() {
            return no_barang == "-1" ? true : false; 
        }

        public Barang(string no_barang, string nama_barang, UInt64 harga_beli, UInt64 harga_jual, int satuan_id, string satuan_nama, string satuan_tipe, string nama_koleksi) {
            this.no_barang = no_barang;
            this.nama_barang = nama_barang;
            this.harga_beli = harga_beli;
            this.harga_jual = harga_jual;
            this.satuan_id = satuan_id;
            this.satuan_nama = satuan_nama;
            this.satuan_tipe = satuan_tipe;
            this.nama_koleksi = nama_koleksi;
        }
    }
}
