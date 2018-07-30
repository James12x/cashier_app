using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace market {
    public class Connection {

        MySqlConnection conn;
        public const string CONNECTION = "server=localhost; database=agungjaya; user=meike; password=meike123; Convert Zero Datetime=True";

        public Connection() {
            try {
                conn = new MySqlConnection(CONNECTION);
                //CustomMessageBox.Show("Connected");
            } catch(Exception e) {
                CustomMessageBox.Show("Cannot create new connection");  
            }
        }

        public bool Connect() {
            try {
                conn.Open();
                return true;
                // CustomMessageBox.Show("Connected");
            } catch(Exception e) {
                CustomMessageBox.Show("Tidak dapat terhubung dengan database, error msg : " + e.Message);
                return false;
            }
        }
        public bool Disconnect() {
            try {
                conn.Close();
                return true;
                //  CustomMessageBox.Show("DIs");
            } catch(Exception e) {
                CustomMessageBox.Show("Tidak dapat diputus");
                return false;
            }
        }

        public Barang GetBarang(string no_barang) {
            try {
                Connect();
                Barang result = new Barang();

                string sql = $@"SELECT b.no_barang, b.nama_barang, b.harga_beli, b.harga_jual, b.satuan_id, b.nama_koleksi, s.satuan, s.tipe
                            FROM barang b, barang_satuan s
                            WHERE b.no_barang = '{no_barang}' AND b.satuan_id = s.id";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                while(reader.Read()) {
                    string nama_barang = reader.GetString("nama_barang");
                    UInt64 harga_beli = reader.GetUInt64("harga_beli");
                    UInt64 harga_jual = reader.GetUInt64("harga_jual");
                    int satuan_id = reader.GetInt32("satuan_id");
                    string nama_koleksi = reader.GetString("nama_koleksi");
                    string satuan_nama = reader.GetString("satuan");
                    string satuan_tipe = reader.GetString("tipe");
                    

                    result = new Barang(no_barang, nama_barang, harga_beli, harga_jual, satuan_id, satuan_nama, satuan_tipe, nama_koleksi);
                    //            result = reader.GetString("agent_name");
                }

                if(result.no_barang == "-1") {
                    //     CustomMessageBox.Show("BARANG TIDAK ADA");
                }
                reader.Close();
                Disconnect();
                return result;
            } catch(Exception e) {
                CustomMessageBox.Show("GET BARANG : " + e.Message);
            }
            return new Barang();
        }

        public AturanBarang GetAturanBarang(string no_barang) {
            try {
                Connect();
                string sql = $@"SELECT  b.no_barang, b.nama_barang, b.harga_beli, b.harga_jual, b.satuan_id, b.nama_koleksi, s.satuan, s.tipe
                            FROM barang b, barang_satuan s
                            WHERE b.no_barang = '{no_barang}' AND b.satuan_id = s.id";



                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                
                Barang b = new Barang();

                while(reader.Read()) {
                    string nama_barang = reader.GetString("nama_barang");
                    UInt64 harga_beli = reader.GetUInt64("harga_beli");
                    UInt64 harga_jual = reader.GetUInt64("harga_jual");
                    int satuan_id = reader.GetInt32("satuan_id");
                    string satuan_nama = reader.GetString("satuan");
                    string satuan_tipe = reader.GetString("tipe");
                    string nama_koleksi = reader.GetString("nama_koleksi");

                    b = new Barang(no_barang, nama_barang, harga_beli, harga_jual, satuan_id, satuan_nama, satuan_tipe, nama_koleksi);
                }


                reader.Close();
                Disconnect();
                AturanBarang result = new AturanBarang(b, GetAturanHargaJual(no_barang));
                
                return result;
            } catch(Exception e) {
                CustomMessageBox.Show("GET ATURAN BARANG : " + e.Message);
            }

            return null;
        }

        public List<SatuanType> GetSatuanTypeList() {
            try {
                Connect();
                string sql = $@"SELECT * 
                            FROM satuan_tipe";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                List<SatuanType> satuanTipeList = new List<SatuanType>();

                while(reader.Read()) {
                    string tipe_satuan = reader.GetString("nama");
                    
                    satuanTipeList.Add(new SatuanType(tipe_satuan));

                }

                if(satuanTipeList.Count < 1) {
                    CustomMessageBox.Show("SATUAN TIPE TIDAK ADA");
                }

                reader.Close();
                Disconnect();
                return satuanTipeList;
            } catch(Exception e) {
                CustomMessageBox.Show("GET SATUAN TIPE LIST : " + e.Message);
            }
            return null;
        }

        public Koleksi GetKoleksiData(string nama_koleksi) {
            try {
                Connect();
                string sql = $@"SELECT bk.nama_koleksi, bk.tipe_satuan
                            FROM barang_koleksi bk
                            WHERE bk.nama_koleksi = '{nama_koleksi}'
                            ORDER BY bk.nama_koleksi asc";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                Koleksi koleksi = new Koleksi();

                while(reader.Read()) {
                    string tipe_satuan = reader.GetString("tipe_satuan");

                    koleksi = new Koleksi(nama_koleksi, tipe_satuan, 0);
                }

                if(koleksi.NamaKoleksi == "!@$kosong$@!") {
                    CustomMessageBox.Show("Koleksi tidak ada");
                }

                reader.Close();
                Disconnect();

                return koleksi;
            } catch(Exception e) {
                CustomMessageBox.Show("GET KOLEKSI DATA : " + e.Message);
            }
            return null;
        }

        public List<Koleksi> GetAllKoleksiByName(string koleksiNama) {
            try {
                Connect();
                string sql = $@"SELECT bk.nama_koleksi, bk.tipe_satuan, 
                                            (SELECT COUNT(*)
                                            FROM barang b
                                            WHERE b.nama_koleksi = bk.nama_koleksi) as jumlahMacamBarang
                            FROM barang_koleksi bk
                            WHERE bk.nama_koleksi LIKE '%{koleksiNama}%'
                            ORDER BY bk.nama_koleksi asc";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                List<Koleksi> koleksi = new List<Koleksi>();

                while(reader.Read()) {
                    string nama_koleksi = reader.GetString("nama_koleksi");
                    string tipe_satuan = reader.GetString("tipe_satuan");
                    UInt64 jumlahMacamBarang = reader.GetUInt64("jumlahMacamBarang");

                    koleksi.Add(new Koleksi(nama_koleksi, tipe_satuan, jumlahMacamBarang));
                }

                if(koleksi.Count < 1) {
                    CustomMessageBox.Show("Koleksi Masih Kosong");
                }

                reader.Close();
                Disconnect();
                return koleksi;
            } catch(Exception e) {
                CustomMessageBox.Show("GET BARANG LIST BY KOLEKSI : " + e.Message);
            }
            return null;
        }

        public List<Koleksi> GetAllKoleksi() {
            try {
                Connect();
                string sql = $@"SELECT bk.nama_koleksi, bk.tipe_satuan, 
                                            (SELECT COUNT(*)
                                            FROM barang b
                                            WHERE b.nama_koleksi = bk.nama_koleksi) as jumlahMacamBarang
                            FROM barang_koleksi bk
                            ORDER BY bk.nama_koleksi asc";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                List<Koleksi> koleksi = new List<Koleksi>();

                while(reader.Read()) {
                    string nama_koleksi = reader.GetString("nama_koleksi");
                    string tipe_satuan = reader.GetString("tipe_satuan");
                    UInt64 jumlahMacamBarang = reader.GetUInt64("jumlahMacamBarang");

                    koleksi.Add(new Koleksi(nama_koleksi, tipe_satuan, jumlahMacamBarang));
                }

                if(koleksi.Count < 1) {
                    CustomMessageBox.Show("Koleksi Masih Kosong");
                }

                reader.Close();
                Disconnect();
                return koleksi;
            } catch(Exception e) {
                CustomMessageBox.Show("GET BARANG LIST BY KOLEKSI : " + e.Message);
            }
            return null;
        }

        public List<Barang> GetBarangListByKoleksi(string nama_koleksi) {
            try {
                Connect();
                string sql = $@"SELECT b.no_barang, b.nama_barang, b.harga_beli, b.harga_jual, b.satuan_id, b.nama_koleksi, s.satuan, s.tipe
                            FROM barang b, barang_satuan s
                            WHERE nama_koleksi = '{nama_koleksi}' AND b.satuan_id = s.id
                            ORDER BY nama_barang asc";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                List<Barang> barangList = new List<Barang>();

                while(reader.Read()) {
                    string no_barang = reader.GetString("no_barang");
                    string nama_barang = reader.GetString("nama_barang");
                    UInt64 harga_beli = reader.GetUInt64("harga_beli");
                    UInt64 harga_jual = reader.GetUInt64("harga_jual");
                    int satuan_id = reader.GetInt32("satuan_id");
                    string satuan_nama = reader.GetString("satuan");
                    string satuan_tipe = reader.GetString("tipe");

                    barangList.Add(new Barang(no_barang, nama_barang, harga_beli, harga_jual, satuan_id, satuan_nama, satuan_tipe, nama_koleksi));
                }

            /*    if(barangList.Count < 1) {
                    CustomMessageBox.Show("Tidak ada barang pada Koleksi \"" + nama_koleksi + "\"");
                }*/

                reader.Close();
                Disconnect();
                return barangList;
            } catch(Exception e) {
                CustomMessageBox.Show("GET BARANG LIST BY KOLEKSI : " + e.Message);
            }
            return null;
        }

        public List<Barang> GetBarangListByName(string ref_nama) {
            try {
                Connect();
                string sql = $@"SELECT b.no_barang, b.nama_barang, b.harga_beli, b.harga_jual, b.satuan_id, b.nama_koleksi, bs.satuan, bs.tipe
                            FROM barang b, barang_satuan bs
                            WHERE nama_barang LIKE '%{ref_nama}%' AND b.satuan_id = bs.id
                            ORDER BY nama_barang asc";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                List<Barang> barangList = new List<Barang>();

                while(reader.Read()) {
                    string no_barang = reader.GetString("no_barang");
                    string nama_barang = reader.GetString("nama_barang");
                    UInt64 harga_beli = reader.GetUInt64("harga_beli");
                    UInt64 harga_jual = reader.GetUInt64("harga_jual");
                    int satuan_id = reader.GetInt32("satuan_id");
                    string nama_koleksi = reader.GetString("nama_koleksi");
                    string satuan_nama = reader.GetString("satuan");
                    string satuan_tipe = reader.GetString("tipe");
                    
                    barangList.Add(new Barang(no_barang, nama_barang, harga_beli, harga_jual, satuan_id, satuan_nama, satuan_tipe, nama_koleksi));
                }

                if(barangList.Count < 1) {
                    CustomMessageBox.Show("BARANG TIDAK ADA");
                }

                reader.Close();
                Disconnect();
                return barangList;
            } catch(Exception e) {
                CustomMessageBox.Show("GET BARANG LIST BY NAME : " + e.Message);
            }
            return null;
        }

        public List<Satuan> GetSatuanList(string satuan_type) {
            try {
                Connect();
                string sql = $@"SELECT *
                            FROM barang_satuan bs
                            WHERE bs.tipe = '{satuan_type}'
                            ORDER BY bs.urutan asc";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                List<Satuan> satuanList = new List<Satuan>();

                while(reader.Read()) {
                    int id = reader.GetInt16("id");
                    string satuanName = reader.GetString("satuan");
                    int order = reader.GetInt16("urutan");

                    satuanList.Add(new Satuan(id, satuanName, order));
                }

                if(satuanList.Count < 1) {
                    CustomMessageBox.Show("SATUAN TIDAK ADA");
                }

                reader.Close();
                Disconnect();
                return satuanList;
            } catch(Exception e) {
                CustomMessageBox.Show("GET SATUAN LIST : " + e.Message);
            }
            return null;
        }

        public List<AturanBarang> GetAturanBarangList(string nama_koleksi) {
            try {
                Connect();
                string sql = $@"SELECT  b.no_barang, b.nama_barang, b.harga_beli, b.harga_jual, b.satuan_id, b.nama_koleksi, s.satuan, s.tipe
                            FROM barang b, barang_satuan s
                            WHERE b.nama_koleksi = '{nama_koleksi}' AND b.satuan_id = s.id";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                List<AturanBarang> result = new List<AturanBarang>();

                while(reader.Read()) {
                    string no_barang = reader.GetString("no_barang");
                    string nama_barang = reader.GetString("nama_barang");
                    UInt64 harga_beli = reader.GetUInt64("harga_beli");
                    UInt64 harga_jual = reader.GetUInt64("harga_jual");
                    int satuan_id = reader.GetInt32("satuan_id");
                    string satuan_nama = reader.GetString("satuan");
                    string satuan_tipe = reader.GetString("tipe");

                    Barang b = new Barang(no_barang, nama_barang, harga_beli, harga_jual, satuan_id, satuan_nama, satuan_tipe, nama_koleksi);

                    AturanBarang aturanBarang = new AturanBarang(b);



                    result.Add(aturanBarang);
                }


                reader.Close();
                Disconnect();

                for(int i = 0; i < result.Count; i++) {
                    result[i].AturanHarga = GetAturanHargaJual(result[i].barang.no_barang);
                }

                return result;
            } catch(Exception e) {
                CustomMessageBox.Show("GET ATURAN BARANG LIST : " + e.Message);
            }

            return null;
        }

        public List<AturanHargaJual> GetAturanHargaJual(string no_barang) {
            try {
                Connect();
                string sql = $@"SELECT *
                            FROM barang_potongan
                            WHERE no_barang = '{no_barang}'
                            ORDER BY jumlah";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                List<AturanHargaJual> result = new List<AturanHargaJual>();

                while(reader.Read()) {
                    int jumlah = reader.GetInt32("jumlah");
                    UInt64 harga = reader.GetUInt64("harga_jual");

                    result.Add(new AturanHargaJual(jumlah, harga));
                }

                reader.Close();
                Disconnect();
                return result;
            } catch(Exception e) {
                CustomMessageBox.Show("GET ATURAN HARGA JUAL : " + e.Message);
            }

            return null;
        }

        public bool IsBarangWithNameExist(string nama_barang) {
            try {
                Connect();
                string sql = $@"SELECT COUNT(*)
                            FROM barang
                            WHERE nama_barang LIKE '{nama_barang}'";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                int count = 0;
                while(reader.Read()) {
                    count = reader.GetInt32(0);
                }
                bool result = false;
                if(count == 1) {
                    result = true;
                }

                reader.Close();
                Disconnect();
                return result;
            } catch(Exception e) {
                CustomMessageBox.Show("IS NAMA BARANG EXIST : " + e.Message);
            }

            return false;
        }

        public bool IsBarangExist(string no_barang) {
            try {
                Connect();
                string sql = $@"SELECT COUNT(*) as jumlah
                            FROM barang
                            WHERE no_barang = '{no_barang}'";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                int count = 0;
                while(reader.Read()) {
                    count = reader.GetInt32("jumlah");
                }

                bool result = false;
                if(count == 1) {
                    result = true;
                }

                reader.Close();
                Disconnect();
                return result;
            } catch(Exception e) {
                CustomMessageBox.Show("IS BARANG EXIST : " + e.Message);
            }

            return false;
        }

        public bool IsSatuanExisInKoleksi(string nama_koleksi, int satuan_id) {
            try {
                Connect();
                string sql = $@"SELECT COUNT(*) 
                            FROM barang b
                            WHERE b.nama_koleksi = '{nama_koleksi}' AND b.satuan_id = '{satuan_id}'";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                int count = 0;
                while(reader.Read()) {
                    count = reader.GetInt32(0);
                }
                bool result = false;
                if(count == 1) {
                    result = true;
                }

                reader.Close();
                Disconnect();

                return result;
            } catch(Exception e) {
                CustomMessageBox.Show("IS SATUAN EXIST IN KOLEKSI : " + e.Message);
            }
            return false;
        }

        public string NoBarangSatuanInKoleksi(string nama_koleksi, int satuan_id) {
            try {
                Connect();
                string sql = $@"SELECT b.no_barang 
                            FROM barang b
                            WHERE b.nama_koleksi = '{nama_koleksi}' AND b.satuan_id = '{satuan_id}'";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                string result = "";
                while(reader.Read()) {
                    result = reader.GetString("no_barang");
                }

                reader.Close();
                Disconnect();

                return result;
            } catch(Exception e) {
                CustomMessageBox.Show("NO BARANG SATUAN IN KOLEKSI : " + e.Message);
            }
            return "";
        }

        public string TipeSatuanInKoleksi(string nama_koleksi) {
            try {
                Connect();
                string sql = $@"SELECT * 
                            FROM barang_koleksi b
                            WHERE b.nama_koleksi = '{nama_koleksi}'";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                string satuanType = "";
                while(reader.Read()) {
                    satuanType = reader.GetString("tipe_satuan");
                }

                reader.Close();
                Disconnect();

                return satuanType;
            } catch(Exception e) {
                CustomMessageBox.Show("TIPE SATUAN IN KOLEKSI : " + e.Message);
            }
            return "";
        }

        public bool IsKoleksiExist(string nama_koleksi) {
            try {
                Connect();
                string sql = $@"SELECT COUNT(*) 
                            FROM barang_koleksi
                            WHERE nama_koleksi = '{nama_koleksi}'";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                int count = 0;
                while(reader.Read()) {
                    count = reader.GetInt32(0);
                }
                bool result = false;
                if(count == 1) {
                    result = true;
                }

                reader.Close();
                Disconnect();

                return result;
            } catch(Exception e) {
                CustomMessageBox.Show("IS KOLEKSI EXIST : " + e.Message);
            }
            return false;
        }

        public const string NO_BARANG = "@no_barang";
        public const string NAMA_BARANG = "@nama_barang";
        public const string SATUAN_ID = "@satuan_id";
        public const string HARGA_BELI = "@harga_beli";
        public const string HARGA_JUAL = "@harga_jual";

        public void InsertBarang(object[] data) {
            try {
                Connect();
                string sql = $@"INSERT INTO barang (no_barang, nama_barang, satuan_id, harga_beli, harga_jual, nama_koleksi)
                            VALUES ({NO_BARANG}, {NAMA_BARANG}, {SATUAN_ID}, {HARGA_BELI}, {HARGA_JUAL}, {NAMA_KOLEKSI})";

                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlParameter idParam = new MySqlParameter(NO_BARANG, MySqlDbType.String);
                idParam.Value = data[0];

                MySqlParameter nameParam = new MySqlParameter(NAMA_BARANG, MySqlDbType.String);
                nameParam.Value = data[1];

                MySqlParameter satuanParam = new MySqlParameter(SATUAN_ID, MySqlDbType.Int32);
                satuanParam.Value = data[2];

                MySqlParameter beliParam = new MySqlParameter(HARGA_BELI, MySqlDbType.UInt64);
                beliParam.Value = data[3];

                MySqlParameter jualParam = new MySqlParameter(HARGA_JUAL, MySqlDbType.UInt64);
                jualParam.Value = data[4];

                MySqlParameter koleksiParam = new MySqlParameter(NAMA_KOLEKSI, MySqlDbType.String);
                koleksiParam.Value = data[5];

                command.Parameters.Add(idParam);
                command.Parameters.Add(nameParam);
                command.Parameters.Add(satuanParam);
                command.Parameters.Add(beliParam);
                command.Parameters.Add(jualParam);
                command.Parameters.Add(koleksiParam);
                command.Prepare();

                command.ExecuteNonQuery();
                Disconnect();

                //  CustomMessageBox.Show("BARANG BERHASIL DIDAFTAR");
            } catch(Exception e) {
                CustomMessageBox.Show("INSERT BARANG : " + e.Message);
            }

        }

        public const string JUMLAH = "@jumlah";

        public void InsertBarangPotongan(object[] data) {
            try {
                Connect();
                string sql = $@"INSERT INTO barang_potongan (no_barang, jumlah, harga_jual)
                            VALUES ({NO_BARANG}, {JUMLAH}, {HARGA_JUAL})";

                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlParameter noBarangParam = new MySqlParameter(NO_BARANG, MySqlDbType.String);
                noBarangParam.Value = data[0];

                MySqlParameter jumlahParam = new MySqlParameter(JUMLAH, MySqlDbType.Int32);
                jumlahParam.Value = data[1];

                MySqlParameter jualParam = new MySqlParameter(HARGA_JUAL, MySqlDbType.UInt64);
                jualParam.Value = data[2];

                command.Parameters.Add(noBarangParam);
                command.Parameters.Add(jumlahParam);
                command.Parameters.Add(jualParam);
                command.Prepare();

                command.ExecuteNonQuery();
                Disconnect();

                // CustomMessageBox.Show("BARANG POTONGAN TERDAFTAR");
            } catch(Exception e) {
                CustomMessageBox.Show("INSERT BARANG POTONGAN : " + e.Message);
            }
        }

        public const string NAMA_KOLEKSI = "@nama_koleksi";
        public const string TIPE_SATUAN = "@tipe_satuan";

        public void InsertBarangKoleksi(string nama_koleksi, string tipe_satuan) {
            try {
                Connect();
                string sql = $@"INSERT INTO barang_koleksi (nama_koleksi, tipe_satuan)
                            VALUES ({NAMA_KOLEKSI}, {TIPE_SATUAN})";

                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlParameter namaKoleksiParam = new MySqlParameter(NAMA_KOLEKSI, MySqlDbType.String);
                namaKoleksiParam.Value = nama_koleksi;

                MySqlParameter tipeSatuanParam = new MySqlParameter(TIPE_SATUAN, MySqlDbType.String);
                tipeSatuanParam.Value = tipe_satuan;

                command.Parameters.Add(namaKoleksiParam);
                command.Parameters.Add(tipeSatuanParam);
                command.Prepare();

                command.ExecuteNonQuery();
                Disconnect();

                //  CustomMessageBox.Show("BARANG BERHASIL DIDAFTAR");
            } catch(Exception e) {
                CustomMessageBox.Show("INSERT BARANG KOLEKSI : " + e.Message);
            }
        }


        //Edit
        #region EDIT
            //edit jumlah potongan
        public void SimpanJumlahPotongan(AturanBarang barang) {
            try {
                Connect();
                string sql1 = $@"DELETE FROM barang_potongan WHERE no_barang = '{barang.barang.no_barang}'";
                MySqlCommand command1 = new MySqlCommand(sql1, conn);
                command1.ExecuteNonQuery();

                string sql2 = $@"INSERT INTO barang_potongan (no_barang, jumlah, harga_jual) VALUES ";
                for(int i = 0; i < barang.AturanHarga.Count; i++) {
                    sql2 += $"({barang.barang.no_barang}, {barang.AturanHarga[i].jumlah}, {barang.AturanHarga[i].harga_jual})";
                    if(i < barang.AturanHarga.Count - 1) {
                        sql2 += ",";
                    } else {
                        sql2 += ";";
                    }
                }

                MySqlCommand command2 = new MySqlCommand(sql2, conn);
                command2.Prepare();

                command2.ExecuteNonQuery();
                Disconnect();

                //  CustomMessageBox.Show("BARANG BERHASIL DIDAFTAR");
            } catch(Exception e) {
                CustomMessageBox.Show("SIMPAN EDIT POTONGAN : " + e.Message);
            }
        }

        public void DeleteBarang(string no_barang) {
            try {
                Connect();
                string sql = $@"DELETE FROM barang WHERE no_barang = '{no_barang}'";

                MySqlCommand command = new MySqlCommand(sql, conn);

                command.ExecuteNonQuery();
                Disconnect();

                //  CustomMessageBox.Show("BARANG BERHASIL DIDAFTAR");
            } catch(Exception e) {
                CustomMessageBox.Show("DELETE BARANG ROW : " + e.Message);
            }
        }

        public void DeleteKoleksi(string nama_koleksi) {
            try {
                Connect();

             /*   string sqlDelte = $@"DELETE FROM barang WHERE nama_koleksi = '{nama_koleksi}'";
                MySqlCommand commandDelete = new MySqlCommand(sqlDelte, conn);

                commandDelete.ExecuteNonQuery();*/

                string sql = $@"DELETE FROM barang_koleksi WHERE nama_koleksi = '{nama_koleksi}'";

                MySqlCommand command = new MySqlCommand(sql, conn);

                command.ExecuteNonQuery();
                Disconnect();

                //  CustomMessageBox.Show("BARANG BERHASIL DIDAFTAR");
            } catch(Exception e) {
                CustomMessageBox.Show("DELETE KOLEKSI : " + e.Message);
            }
        }

        public void UpdateBarang(Barang b) {
            try {
                Connect();
                string sql = $@"UPDATE barang SET
                                nama_barang = '{b.nama_barang}',
                                satuan_id = {b.satuan_id},
                                harga_jual = {b.harga_jual},
                                harga_beli = {b.harga_beli},
                                nama_koleksi = '{b.nama_koleksi}'
                                WHERE no_barang = {b.no_barang}";

                MySqlCommand command = new MySqlCommand(sql, conn);

                command.ExecuteNonQuery();
                Disconnect();

                //  CustomMessageBox.Show("BARANG BERHASIL DIDAFTAR");
            } catch(Exception e) {
                CustomMessageBox.Show("UPDATE BARANG ROW : " + e.Message);
            }
        }
#endregion

    }
}
