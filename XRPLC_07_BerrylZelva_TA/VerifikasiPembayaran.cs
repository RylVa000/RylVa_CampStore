using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace XRPLC_07_BerrylZelva_TA
{
    public partial class VerifikasiPembayaran : Form
    {
        double totalPlusBunga = 0;
        int sisaWaktu = 599;

        int lamaPinjaman = 0;
        string username = "";
        string namauser = "";
        string alamatUser = "";
        string produkDiPesan = "";
        string qty = "";
        string harga = "";
        string tanggal = "";
        string kodeAntri = "";
        string metode = "";
        string mode = "";


        public VerifikasiPembayaran()
        {
            InitializeComponent();
        }

        private void panelQris_Paint(object sender, PaintEventArgs e)
        {

        }

        //sistem copy nomor
        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("210210");
            MessageBox.Show("Nomor disalin!");
        }

        //sistem pemunculan panel berdasarkan metode bayar
        private void VerifikasiPembayaran_Load(object sender, EventArgs e)
        {
            if (DatabaseRylVa.back == "VerifikasiPembayaran")//kalo user beres bayar dan ingin ss
            {
                panelSukses.Visible = true;
                panelBank.Visible = false;
                panelCOD.Visible = false;
                panelKredit.Visible = false;
                panelQris.Visible = false;
                return;
            }

            panelBank.Visible = false;
            panelCOD.Visible = false;
            panelKredit.Visible = false;
            panelQris.Visible = false;
            panelSukses.Visible = false;

            if (DatabaseRylVa.MetodeBayar == "Bank")
            {
                labelMetode.Text = "Bank Tranfer";
                panelBank.Visible = true;
            }
            else if (DatabaseRylVa.MetodeBayar == "COD")
            {
                labelMetode.Text = "COD";
                panelCOD.Visible = true;

                string[] infoAkun = File.ReadAllLines(DatabaseRylVa.FilePengguna);

                foreach (string line in infoAkun)
                {
                    string[] Data = line.Split(";");
                    if (Data[0] == DatabaseRylVa.akunLogin)
                    {
                        labelAlamat.Text = $"Alamat: {Data[4]}, \n{Data[5]}, {Data[6]}";

                        break;
                    }
                }

            }
            else if (DatabaseRylVa.MetodeBayar == "Kredit")
            {
                labelMetode.Text = "Kredit";
                panelKredit.Visible = true;
            }
            else
            {
                labelMetode.Text = "Qris";
                panelQris.Visible = true;
            }

            timerPembayaran.Start();
            labelTagihan.Text = $"Total Tagihan: Rp {DatabaseRylVa.totalPayment.ToString("N0")}";
        }

        //sistem sisa waktu
        private void timerPembayaran_Tick(object sender, EventArgs e)
        {
            sisaWaktu--;

            int menit = sisaWaktu / 60;
            int detik = sisaWaktu % 60;

            labelWaktu.Text = $"Sisa Waktu: {menit}:{detik}";

            if (sisaWaktu == 0)
            {
                timerPembayaran.Stop();

                MessageBox.Show("Waktu Pembayaran sudah habis", "Time limit", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Payment bayar = new Payment();
                bayar.Show();
                this.Hide();
            }
        }

        //sistem batal pesan
        private void buttonBatal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin membatalkan pesanan?", "Cancel Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                timerPembayaran.Stop();
                Payment bayar = new Payment();
                bayar.Show();
                this.Hide();
            }
        }

        //sistem bunga
        private void comboBoxBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            double totalTagihan = DatabaseRylVa.totalPayment;
            double bungaPersen = 0.025; //2,5%
            double cicilanPerbulan = 0;


            if (comboBoxBulan.Text == "3 Bulan")
            {
                totalPlusBunga = totalTagihan + (totalTagihan * bungaPersen * 3);
                cicilanPerbulan = totalPlusBunga / 3; //total/bulan
            }
            else if (comboBoxBulan.Text == "6 Bulan")
            {
                totalPlusBunga = totalTagihan + (totalTagihan * bungaPersen * 6);
                cicilanPerbulan = totalPlusBunga / 6;
            }
            else if (comboBoxBulan.Text == "12 Bulan")
            {
                totalPlusBunga = totalTagihan + (totalTagihan * bungaPersen * 12);
                cicilanPerbulan = totalPlusBunga / 12;
            }

            //tampilkan
            labeltotalBungga.Text = $"Total Setelah Bungga: Rp {totalPlusBunga.ToString("N0")}";
            labelcicilanperbulan.Text = $"Rp {cicilanPerbulan.ToString("N0")}";


        }

        //sistem back to menu
        private void buttonBackMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Memilih kembali ke pilihan?", "Back to lobby", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                PilihTujuan tujuan = new PilihTujuan();
                tujuan.Show();
                this.Hide();
            }
        }

        //sistem sudah bayar, masukkan ke text dan lanjut ke panel sukses
        private void buttonSudahBayar_Click(object sender, EventArgs e)
        {
            kodeAntri = DatabaseRylVa.KodeAntri;
            tanggal = DatabaseRylVa.Waktu;
            metode = DatabaseRylVa.MetodeBayar;
            mode = DatabaseRylVa.pilihanMode;
            DatabaseRylVa.statusPesanan = "Proses";
            string statusPesanan = DatabaseRylVa.statusPesanan;

            if (DatabaseRylVa.MetodeBayar == "Kredit")
            {
                harga = totalPlusBunga.ToString();
            }
            else
            {
                harga = DatabaseRylVa.totalPayment.ToString();
            }

            timerPembayaran.Stop();

            if (MessageBox.Show("Harap Tunggu Sebentar!!! Memeriksa pembayaran", "Check Payment", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                DatabaseRylVa.totalPayment = 0;
                panelBank.Visible = false;
                panelCOD.Visible = false;
                panelKredit.Visible = false;
                panelQris.Visible = false;
                panelSukses.Visible = true;
            }

            //sistem masukkan pesanan ke file pesanan untk admin
            string[] dataAkun = File.ReadAllLines(DatabaseRylVa.FilePengguna);
            foreach (string dataUser in dataAkun)
            {
                string[] Data = dataUser.Split(';');

                if (Data[0] == DatabaseRylVa.akunLogin)
                {
                    username = Data[0];
                    namauser = Data[3];
                    alamatUser = $"{Data[4]}, {Data[5]}, {Data[6]}";
                }
            }

            foreach (Keranjang item in DatabaseRylVa.daftarbelanja)
            {
                if (DatabaseRylVa.pilihanMode == "Sewa")
                {
                    produkDiPesan += $"{item.Nama} ({item.qty} pcs - {item.lamaSewa} Hari), ";
                }
                else
                {
                    produkDiPesan += $"{item.Nama} ({item.qty}), ";
                }

                lamaPinjaman = item.lamaSewa;
            }

            string dataPesanan = $"{kodeAntri};{tanggal};{username};{namauser};{alamatUser};{produkDiPesan};{harga};{mode};{metode};{statusPesanan}";

            //masukan
            try
            {
                File.AppendAllText(DatabaseRylVa.FilePesanan, dataPesanan + Environment.NewLine);
                MessageBox.Show("Pesanan Berhasil Dibuat", "Pesanan Ditambahkan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KurangiStok();
                BarangTerjualDanSewa();
                CetakStruck();
                DatabaseRylVa.sudahBayar = true;
                printDocumentCetak.Print();

                if (DatabaseRylVa.daftarbelanja != null)
                {
                    DatabaseRylVa.daftarbelanja.Clear();
                }
            }
            catch (Exception ggl)
            {
                MessageBox.Show("Terjadi Kesalahan " + ggl.Message, "Pesanan Tidak dapat Ditambahkan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //sistem  kurangi stock
        private void KurangiStok()
        {
            if (File.Exists(DatabaseRylVa.FileBarang) && DatabaseRylVa.daftarbelanja.Count > 0)
            {
                string[] SemuaBarang = File.ReadAllLines(DatabaseRylVa.FileBarang);
                //buat list baru yang menampung data
                List<string> DataBarangBaru = new List<string>();

                foreach (string baris in SemuaBarang)
                {
                    if (string.IsNullOrWhiteSpace(baris))
                    {
                        continue;
                    }

                    string[] Data = baris.Split(';');
                    string NamaBarang = Data[0];
                    int StockBarang = int.Parse(Data[5]);

                    foreach (Keranjang ItemBeli in DatabaseRylVa.daftarbelanja)
                    {
                        if (NamaBarang.ToLower() == ItemBeli.Nama.ToLower())
                        {
                            StockBarang -= ItemBeli.qty;

                            if (StockBarang < 0)
                            {
                                StockBarang = 0;
                            }

                            Data[5] = StockBarang.ToString("N0");
                        }
                    }

                    string DataQtyBaru = string.Join(";", Data);
                    DataBarangBaru.Add(DataQtyBaru);
                }

                File.WriteAllLines(DatabaseRylVa.FileBarang, DataBarangBaru);
            }
        }

        //sistem angka jual dan sewa
        private void BarangTerjualDanSewa()
        {
            if (File.Exists(DatabaseRylVa.FileBarang) && DatabaseRylVa.daftarbelanja.Count > 0)
            {
                string[] semuaBarang = File.ReadAllLines(DatabaseRylVa.FileBarang);
                List<string> dataBarangDipesanAtauBeli = new List<string>();

                foreach (string baris in semuaBarang)
                {
                    string[] Data = baris.Split(';');

                    string NamaBarang = Data[0];
                    int JumlahDiBeli = int.Parse(Data[9]);
                    int JumlahDiSewa = int.Parse(Data[10]);

                    foreach (Keranjang Items in DatabaseRylVa.daftarbelanja)
                    {
                        if (NamaBarang.ToLower() == Items.Nama.ToLower())
                        {
                            //ambil data dari list
                            int qtyDipesan = Items.qty;
                            if (DatabaseRylVa.pilihanMode == "Beli")
                            {
                                //jumlahkan jumlah beli+qty dipesan user
                                JumlahDiBeli += qtyDipesan;
                                //masukkan data yang sudah di update
                                Data[9] = JumlahDiBeli.ToString();
                            }
                            else
                            {
                                JumlahDiSewa += qtyDipesan;
                                Data[10] = JumlahDiSewa.ToString();
                            }
                        }
                    }

                    string barisBaru = string.Join(";", Data);
                    dataBarangDipesanAtauBeli.Add(barisBaru);
                }

                File.WriteAllLines(DatabaseRylVa.FileBarang, dataBarangDipesanAtauBeli);
            }
        }

        //sistem struk
        private void CetakStruck()
        {
            string jalurDokumen = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderStruk = System.IO.Path.Combine(jalurDokumen, "RylVaCampStore", "Struk");

            if (!System.IO.Directory.Exists(folderStruk))
                System.IO.Directory.CreateDirectory(folderStruk);

            string namaFileAwal = $"Struck Invoice {kodeAntri}.txt";
            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
            {
                namaFileAwal = namaFileAwal.Replace(c.ToString(), "-");
            }
            string NamaStruckProduk = System.IO.Path.Combine(folderStruk, namaFileAwal);

            // Menyusun isi TXT
            string strukTxt = "========================================\n";
            strukTxt += "            RYLVA CAMP STORE            \n";
            strukTxt += "      ~ Adventure & Camping Gear ~      \n";
            strukTxt += "========================================\n";
            strukTxt += $"No. Invoice : {kodeAntri}\n";
            strukTxt += $"Tanggal     : {tanggal}\n";
            strukTxt += $"Pelanggan   : {namauser}\n";
            strukTxt += $"Mode        : {mode}\n";
            strukTxt += $"Metode      : {metode}\n";
            strukTxt += "----------------------------------------\n";
            strukTxt += "Rincian Pembelian :\n";

            foreach (var item in DatabaseRylVa.daftarbelanja)
            {
                if (mode == "Sewa")
                    strukTxt += $" >{item.Nama} - {item.lamaSewa} Hari (x{item.qty})\n";
                else
                    strukTxt += $" >{item.Nama} (x{item.qty})\n";
            }

            string HargaTotal = int.Parse(harga).ToString("N0");
            strukTxt += "----------------------------------------\n";
            strukTxt += $"TOTAL BAYAR : Rp {HargaTotal}\n";
            strukTxt += "========================================\n";
            strukTxt += "     Terima Kasih Telah Berbelanja!     \n";

            try
            {
                File.WriteAllText(NamaStruckProduk, strukTxt);
                MessageBox.Show($"File Struk berhasil disimpan di:\n{NamaStruckProduk}", "Info Lokasi File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Backup TXT gagal!\nAlasan: " + ex.Message, "Peringatan");
            }
        }


        //sistem check detail
        private void buttonCheckDetail_Click(object sender, EventArgs e)
        {
            FormAccountSetting akun = new FormAccountSetting();
            akun.Show();
            this.Hide();
            DatabaseRylVa.back = "VerifikasiPembayaran";
        }

        private void printDocumentCetak_PrintPage(object sender, PrintPageEventArgs e)
        {
            string struk = "";

            struk += "====== RYLVA CAMP STORE ======\n";
            struk += " ~ Adventure & Camping Gear ~\n";
            struk += "==============================\n";
            struk += $"No. Inv : {kodeAntri}\n";
            struk += $"Tanggal : {tanggal}\n";
            struk += $"Nama    : {namauser}\n";
            struk += $"Mode    : {mode}\n";
            struk += $"Metode  : {metode}\n";
            struk += "------------------------------\n";

            // Looping Data Keranjang
            foreach (var item in DatabaseRylVa.daftarbelanja)
            {
                struk += item.Nama + "\n"; // Baris 1: Nama Barang

                // Baris 2: Qty, Harga Satuan, (Hari), dan Subtotal
                if (mode == "Sewa")
                {
                    struk += $" {item.qty}x Rp{item.hargaSatuan:N0} ({item.lamaSewa}Hr)\n";
                }
                else
                {
                    struk += $" {item.qty}x Rp{item.hargaSatuan:N0}\n";
                }

                struk += $"           Subtotal: Rp{item.subtotal:N0}\n"; // Rata Kanan Manual
            }

            struk += "------------------------------\n";

            string HargaTotal = int.Parse(harga).ToString("N0");
            struk += $"TOTAL BAYAR : Rp {HargaTotal}\n";

            struk += "==============================\n";
            struk += " Terima Kasih Telah Berbelanja\n";
            struk += "Utamakan Keselamatan Kejujuran\n";

            // Mencetak satu string raksasa tersebut ke printer sekaligus
            e.Graphics.DrawString(struk, new Font("Consolas", 9), Brushes.Black, 0, 0);
        }
    }
}
