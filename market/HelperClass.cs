using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market {
    public static class HelperClass {
      /*  public static object[] createBarangObjectArray(params object[] data) {
            return data;
        }

        public static object[] createHargaPotoronganObjectArray(params object[] data) {
            return data;
        }*/
    }

    public class Koleksi {
        public string NamaKoleksi = "!@$kosong$@!";
        public string TipeSatuan;
        public UInt64 JumlahBarang;

        public Koleksi() { }

        public Koleksi(string namaKoleksi, string tipeSatuan, UInt64 jumlahBarang) {
            NamaKoleksi = namaKoleksi;
            TipeSatuan = tipeSatuan;
            JumlahBarang = jumlahBarang;
        }
    }
    
    public class SatuanType {
        public List<Satuan> SatuanList = new List<Satuan>();
        public string Satuan_type;

        public SatuanType(string satuanType) {
            Satuan_type = satuanType;
        }

        public override string ToString() {
            return Satuan_type;
        }
    }
    
    public class Satuan : IComparable<Satuan> {
        public int Id;
        public string SatuanName;
        public int Order;

        public Satuan(int id, string satuanName, int order) {
            Id = id;
            SatuanName = satuanName;
            Order = order;
        }

        public int CompareTo(Satuan other) {
            return Order.CompareTo(other.Order);
        }

        public override string ToString() {
            return SatuanName;
        }
    }

    public class BarangTransaksi {
        public List<AturanBarang> AturanBarangList = new List<AturanBarang>();
        
        public BarangTransaksi(List<AturanBarang> aturanBarang) {
            AturanBarangList = aturanBarang;
        }
    }

    public class AturanBarang {
        public Barang barang;
        public List<AturanHargaJual> AturanHarga = new List<AturanHargaJual>();

        public AturanBarang(Barang b) {
            barang = b;
        }

        public AturanBarang(Barang b, List<AturanHargaJual> aturanHarga) {
            barang = b;
            AturanHarga = aturanHarga;
        }
    }

    public class AturanHargaJual {
        public int jumlah;
        public ulong harga_jual;

        public AturanHargaJual(int jumlah, UInt64 harga_jual) {
            this.jumlah = jumlah;
            this.harga_jual = harga_jual;
        }
    }
}
