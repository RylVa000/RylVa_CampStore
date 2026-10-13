using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace XRPLC_07_BerrylZelva_TA
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            DataDashBoard();
        }

        private void hopeRoundButtonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("anda Yakin Untuk Logout", "Logout", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FormLogin back = new FormLogin();
                back.Show();
                this.Hide();
            }
        }

        private void timerJamTanggal_Tick(object sender, EventArgs e)
        {
            labelTime.Text = $"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
        }

        private void hopeRoundButtonDashBoard_Click(object sender, EventArgs e)
        {
            panelDasbor.Visible = true;
            panelOrder.Visible = false;
            panelProduk.Visible = false;
            DataDashBoard();
        }

        private void ChartPenjualan()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Name = "Pendapatan (Rp)";

            string filePesanan = DatabaseRylVa.FilePesanan;
            if (!File.Exists(filePesanan))
            {
                return;
            }

            string[] pesanan = File.ReadAllLines(filePesanan);
            Dictionary<string, int> pendapatanPerHari = new Dictionary<string, int>();

            // 1. Proses Hitung Data 
            foreach (string baris in pesanan)
            {
                if (string.IsNullOrWhiteSpace(baris))
                {
                    continue;
                }
                string[] data = baris.Split(';');

                string status = data[9];

                if (status == "Cancel")
                {
                    continue;
                }

                if (data.Length > 6)
                {
                    string tanggalLengkap = data[1];
                    string tanggalPendek = tanggalLengkap.Length >= 5 ? tanggalLengkap.Substring(0, 5) : tanggalLengkap;
                    int uangMasuk = int.Parse(data[6]);

                    if (pendapatanPerHari.ContainsKey(tanggalPendek))
                    {
                        pendapatanPerHari[tanggalPendek] += uangMasuk;
                    }
                    else
                    {
                        pendapatanPerHari.Add(tanggalPendek, uangMasuk);
                    }
                }
            }

            var tujuhHariTerakhir = pendapatanPerHari.Skip(Math.Max(0, pendapatanPerHari.Count - 7)).ToList();

            foreach (var item in tujuhHariTerakhir)
            {
                int letakBatang = chart1.Series[0].Points.AddY(item.Value);
                chart1.Series[0].Points[letakBatang].AxisLabel = item.Key;
            }

            chart1.Series[0]["PointWidth"] = "0.5";
            chart1.Series[0].SmartLabelStyle.Enabled = false;
            chart1.Series[0]["LabelStyle"] = "Top";
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].LabelFormat = "Rp {0:N0}";
            chart1.Series[0].Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            chart1.Series[0].Color = Color.SeaGreen;

            chart1.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.Series[0].IsXValueIndexed = true;
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = true;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
        }

        private void MuatstockKurang()
        {
            listViewStockKurang.Items.Clear();
            string[] Pesanan = File.ReadAllLines(DatabaseRylVa.FileBarang);

            foreach (string baris in Pesanan)
            {
                string[] Data = baris.Split(';');
                string NamaBarang = Data[0];
                string KategoriBarang = Data[1];
                string StockBarang = Data[5];

                if (int.Parse(StockBarang) > 10)
                {
                    continue;
                }
                else
                {
                    ListViewItem Item = new ListViewItem(NamaBarang);

                    Item.SubItems.Add(KategoriBarang);
                    Item.SubItems.Add(StockBarang);

                    listViewStockKurang.Items.Add(Item);
                }
            }
        }

        private void DataDashBoard()
        {
            int Keuntungan = 0;
            int RestockProduk = 0;
            panelDasbor.Visible = true;
            ChartPenjualan();
            MuatstockKurang();

            string[] Pesanan = File.ReadAllLines(DatabaseRylVa.FilePesanan);
            string[] Akun = File.ReadAllLines(DatabaseRylVa.FilePengguna);
            string[] Barang = File.ReadAllLines(DatabaseRylVa.FileBarang);

            foreach (string semetara in Barang)
            {
                string[] Data = semetara.Split(";");
                string Restock = Data[5];

                if (int.Parse(Restock) <= 10)
                {
                    RestockProduk++;
                }

                labelRestock.Text = $"{RestockProduk.ToString("N0")} Barang";
            }

            int JumlahAkun = Akun.Length;
            labelTotalPenguna.Text = $"{JumlahAkun.ToString("N0")} Akun";

            int JumlahPesanan = 0;
            foreach (string tumbal in Pesanan)
            {
                string[] Data = tumbal.Split(";");
                string Orders = Data[9];
                string TotalKeutungan = Data[6];

                if (Orders == "Proses")
                {
                    JumlahPesanan++;
                }

                if (Orders != "Cancel")
                {
                    Keuntungan += int.Parse(TotalKeutungan);
                }

                labelPesanan.Text = $"{JumlahPesanan.ToString("N0")} Pesanan";
                labelPendapatan.Text = $"Rp {Keuntungan.ToString("N0")}";
            }
        }

        //order
        private void hopeRoundButtonOrder_Click(object sender, EventArgs e)
        {
            panelDasbor.Visible = false;
            panelOrder.Visible = true;
            panelProduk.Visible = false;
        }

        private void hopeRadioButtonBeli_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeRadioButtonBeli.Checked)
            {
                cyberGroupBoxPinjam.Visible = false;
                cyberGroupBoxKembali.Visible = false;
                hopeComboBoxStatusUbah.Items.Clear();
                hopeComboBoxStatusUbah.Items.AddRange(new string[] { "Proses", "Dalam Perjalanan", "Complete", "Cancel" });

                DataPesanan();
            }
        }

        private void hopeRadioButtonSewa_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeRadioButtonSewa.Checked)
            {
                cyberGroupBoxPinjam.Visible = true;
                cyberGroupBoxKembali.Visible = true;
                hopeComboBoxStatusUbah.Items.Clear();
                hopeComboBoxStatusUbah.Items.AddRange(new string[] { "Proses", "Dipinjam", "Dikembalikan", "Cancel" });

                DataPesanan();
            }
        }

        private void DataPesanan()
        {
            dataGridViewDaftarPesanan.Rows.Clear();
            int hitungTotal = 0, hitungProses = 0, hitungComplete = 0, hitungCancel = 0, hitungDipinjam = 0;

            string[] semuaPesanan = File.ReadAllLines(DatabaseRylVa.FilePesanan);
            foreach (string baris in semuaPesanan)
            {
                string[] Data = baris.Split(';');
                string IDBarang = Data[0];
                string tanggal = Data[1];
                string penerima = Data[3];
                string pesanan = Data[5];
                string total = Data[6];
                string mode = Data[7];
                string status = Data[9];

                bool sortir = (hopeRadioButtonBeli.Checked && mode.ToLower() == "beli" || hopeRadioButtonSewa.Checked && mode.ToLower() == "sewa");

                if (sortir)
                {
                    hitungTotal += 1;

                    if (status.ToLower() == "complete" || status.ToLower() == "dikembalikan")
                    {
                        hitungComplete += 1;
                    }
                    else if (status.ToLower() == "cancel")
                    {
                        hitungCancel += 1;
                    }
                    else if (status.ToLower() == "dipinjam")
                    {
                        hitungDipinjam += 1;
                    }
                    else
                    {
                        hitungProses += 1;
                    }

                    string HargaTotal = "Rp " + int.Parse(total).ToString("N0");
                    dataGridViewDaftarPesanan.Rows.Add(IDBarang, tanggal, penerima, pesanan, HargaTotal, status);
                }
            }

            labelTransaksiSelesai.Text = $"{hitungComplete} Transaksi";
            labelTransaksiDiproses.Text = $"{hitungProses} Transaksi";
            labelPinjam.Text = $"{hitungDipinjam} Barang";
            labelKembali.Text = $"{hitungComplete} Barang";
            labelTotalTransaksi.Text = $"{hitungTotal} Transaksi";
            labelBatal.Text = $"{hitungCancel} Transaksi";

            foreach (DataGridViewRow barisTabel in dataGridViewDaftarPesanan.Rows)
            {
                if (barisTabel.Cells[5].Value != null)
                {
                    string statusPesanan = barisTabel.Cells[5].Value.ToString().ToLower();

                    if (statusPesanan == "complete")
                    {
                        barisTabel.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (statusPesanan == "proses")
                    {
                        barisTabel.DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                    else if (statusPesanan == "cancel")
                    {
                        barisTabel.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                    else if (statusPesanan == "dalam perjalanan")
                    {
                        barisTabel.DefaultCellStyle.BackColor = Color.Lavender;
                    }
                    else if (statusPesanan == "dikembalikan")
                    {
                        barisTabel.DefaultCellStyle.BackColor = Color.Plum;
                    }
                    else if (statusPesanan == "dipinjam")
                    {
                        barisTabel.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                }
            }
            SewaKadaluarsa();
        }

        //sistem hapus pesanan
        private void hapusPesanan()
        {
            if (dataGridViewDaftarPesanan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Klik dulu salah satu baris pesanan di tabel yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string IDPesanan = dataGridViewDaftarPesanan.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult PilihModeHapus = MessageBox.Show($"Tindakan untuk pesanan {IDPesanan}:\n\n[YES] Hapus dari Database (Permanen)\n[NO] Sembunyikan dari Layar Saja\n[CANCEL] Batal", "Hapus Pesanan", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            //cancel
            if (PilihModeHapus == DialogResult.Cancel)
            {
                return;
            }
            //sembunyikan dari datagrid
            else if (PilihModeHapus == DialogResult.No)
            {
                dataGridViewDaftarPesanan.Rows.RemoveAt(dataGridViewDaftarPesanan.SelectedRows[0].Index);
                MessageBox.Show("Pesanan berhasil disembunyikan dari layar.", "Sukses");
            }
            //hapus permanen
            else if (PilihModeHapus == DialogResult.Yes)
            {
                string[] semuaPesanan = File.ReadAllLines(DatabaseRylVa.FilePesanan);
                List<string> dataTerbaru = new List<string>();

                foreach (string pesananTxt in semuaPesanan)
                {
                    if (string.IsNullOrWhiteSpace(pesananTxt))
                    {
                        continue;
                    }

                    string[] Data = pesananTxt.Split(';');
                    string IDDiDatabase = Data[0];

                    if (IDDiDatabase != IDPesanan)
                    {
                        dataTerbaru.Add(pesananTxt);
                    }
                }

                string jalurDokumen = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string folderStruk = System.IO.Path.Combine(jalurDokumen, "RylVaCampStore", "Struk");

                string namaFileStruk = $"Struck Invoice {IDPesanan}.txt";
                foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                {
                    namaFileStruk = namaFileStruk.Replace(c.ToString(), "-");
                }

                string pathFileStruk = System.IO.Path.Combine(folderStruk, namaFileStruk);

                if (File.Exists(pathFileStruk))
                {
                    try
                    {
                        File.Delete(pathFileStruk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Data database terhapus, tapi file struk TXT gagal dihapus dari folder.\nAlasan: {ex.Message}", "Peringatan Hapus File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                File.WriteAllLines(DatabaseRylVa.FilePesanan, dataTerbaru);
                DataPesanan();
                MessageBox.Show("Data pesanan berhasil dihapus permanen dari sistem!", "Sukses");
            }
        }

        //sistem ubah status
        private void hopeRoundButtonUbahStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewDaftarPesanan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Klik dulu salah satu pesanan di tabel!", "Peringatan");
                return;
            }

            if (string.IsNullOrWhiteSpace(hopeComboBoxStatusUbah.Text))
            {
                MessageBox.Show("Pilih status barunya dulu di kotak pilihan!", "Peringatan");
                return;
            }

            string IDDipilih = dataGridViewDaftarPesanan.SelectedRows[0].Cells[0].Value.ToString();
            string statusBaru = hopeComboBoxStatusUbah.Text;

            string[] kumpulanPesanan = File.ReadAllLines(DatabaseRylVa.FilePesanan);
            List<string> dataTerbaru = new List<string>();

            foreach (string tumbal in kumpulanPesanan)
            {
                string[] Data = tumbal.Split(';');

                if (Data[0] == IDDipilih)
                {
                    if (Data.Length >= 10)
                    {
                        Data[9] = statusBaru;
                    }
                    else
                    {
                        Array.Resize(ref Data, 10);
                        Data[9] = statusBaru;
                    }
                }

                dataTerbaru.Add(string.Join(";", Data));
            }

            File.WriteAllLines(DatabaseRylVa.FilePesanan, dataTerbaru);
            MessageBox.Show($"Pesanan {IDDipilih} berhasil diubah menjadi {statusBaru}!", "Sukses");
            hopeComboBoxStatusUbah.Text = "";
            DataPesanan();
        }



        private void SewaKadaluarsa()
        {
            try
            {
                string[] semuaPesanan = File.ReadAllLines(DatabaseRylVa.FilePesanan);

                foreach (DataGridViewRow baris in dataGridViewDaftarPesanan.Rows)
                {
                    if (baris.IsNewRow)
                    {
                        continue;
                    }

                    string idTabel = baris.Cells[0].Value?.ToString();

                    if (string.IsNullOrEmpty(idTabel))
                    {
                        continue;
                    }

                    foreach (string pesanan in semuaPesanan)
                    {
                        if (string.IsNullOrWhiteSpace(pesanan))
                        {
                            continue;
                        }

                        string[] Data = pesanan.Split(';');

                        if (Data[0] == idTabel)
                        {
                            string modePesanan = Data[7];
                            string statusPesanan = Data[9];
                            string tanggalText = Data[1];
                            string rincianBarang = Data[5];
                            string total = Data[6];

                            if (modePesanan == "Sewa" && statusPesanan == "Dipinjam")
                            {
                                int totalHarga = 0;
                                int.TryParse(total, out totalHarga);

                                DateTime tanggalPesan;
                                if (DateTime.TryParseExact(tanggalText, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out tanggalPesan))
                                {

                                    System.Text.RegularExpressions.Match pencariAngka = System.Text.RegularExpressions.Regex.Match(rincianBarang, @"(\d+)\s*Hari");

                                    if (pencariAngka.Success)
                                    {
                                        int durasiHari = int.Parse(pencariAngka.Groups[1].Value);
                                        DateTime jatuhTempo = tanggalPesan.AddDays(durasiHari);

                                        if (DateTime.Now.Date > jatuhTempo.Date)
                                        {
                                            TimeSpan lamaTelat = DateTime.Now.Date - jatuhTempo.Date;
                                            int telatHari = lamaTelat.Days;

                                            baris.DefaultCellStyle.BackColor = Color.Crimson;
                                            baris.DefaultCellStyle.ForeColor = Color.Black;

                                            int dendaSaja = telatHari * (totalHarga * 5 / 100);
                                            int totalTagihan = totalHarga + dendaSaja;

                                            baris.Tag = $"TELAT {telatHari} HARI!\nDenda: Rp {dendaSaja.ToString("N0")}\nTotal Tagihan: Rp {totalTagihan.ToString("N0")}";
                                        }
                                        else if (DateTime.Now.Date < jatuhTempo.Date)
                                        {
                                            TimeSpan lamaHari = jatuhTempo.Date - DateTime.Now.Date;
                                            int sisaHari = lamaHari.Days;
                                            baris.Tag = $"Sisa Pinjaman: {sisaHari} Hari";
                                        }
                                        else
                                        {
                                            baris.Tag = null;
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deteksi denda: " + ex.Message);
            }
        }

        //Produk
        private void hopeRoundButtonProduk_Click(object sender, EventArgs e)
        {
            panelProduk.Visible = true;
            panelDasbor.Visible = false;
            panelOrder.Visible = false;
            Produk();
        }

        private void hopeRoundButtonTambahBarang_Click(object sender, EventArgs e)
        {
            TambahProduk();
        }

        private void hopeRoundButtonUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void hopeRoundButtonHapus_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void hopeRoundButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshClear();
        }

        private void dataGridViewDataProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewDataProduk.Rows[e.RowIndex];
            string barangDipilih = row.Cells["NamaBarang"].Value.ToString();
            string[] semuaBarang = File.ReadAllLines(DatabaseRylVa.FileBarang);
            foreach (string tumbal in semuaBarang)
            {
                string[] Data = tumbal.Split(';');

                if (barangDipilih.ToLower() == Data[0].ToLower())
                {
                    bigTextBoxNamaBarang.Text = Data[0];
                    bigTextBoxhargaBarang.Text = Data[2];
                    bigTextBoxHargaSewa.Text = Data[8];
                    bigTextBoxSokBarang.Text = Data[5];
                    bigTextBoxFileGambar.Text = Data[3];
                    bigTextBoxDeskripsi.Text = Data[6];
                    bigTextBoxSpesifikasi.Text = Data[7];
                    hopeComboBoxKategori.Text = Data[1];
                }
            }
        }
        private void hopeRoundButtonSeach_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            dataGridViewDataProduk.Rows.Clear();
            string NamaBarangDicari = crownTextBoxSearch.Text;

            string[] semuaBarang = File.ReadAllLines(DatabaseRylVa.FileBarang);
            foreach (string baris in semuaBarang)
            {
                string[] Data = baris.Split(';');
                string NamaProduk = Data[0];
                bool BarangKetemu = NamaProduk.ToLower().Contains(NamaBarangDicari.ToLower());

                if (BarangKetemu)
                {
                    string Kategori = Data[1];
                    int HargaBeli = int.Parse(Data[2]);
                    int HargaSewa = int.Parse(Data[8]);
                    string Stok = Data[5];
                    string BarangDibeli = Data[9];
                    string BarangDiSewa = Data[10];
                    dataGridViewDataProduk.Rows.Add(NamaProduk, Kategori, HargaBeli.ToString("N0"), HargaSewa.ToString("N0"), Stok, BarangDibeli, BarangDiSewa);
                }
                else
                {
                    continue;
                }

                foreach (DataGridViewRow Kolom in dataGridViewDataProduk.Rows)
                {
                    string Kategori = Kolom.Cells[1].Value.ToString().ToLower();

                    switch (Kategori)
                    {
                        case "tenda":
                            Kolom.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        case "tas kemah":
                            Kolom.DefaultCellStyle.BackColor = Color.LightYellow;
                            break;
                        case "alat tidur":
                            Kolom.DefaultCellStyle.BackColor = Color.LightPink;
                            break;
                        case "alat masak":
                            Kolom.DefaultCellStyle.BackColor = Color.Bisque;
                            break;
                        case "penerangan":
                            Kolom.DefaultCellStyle.BackColor = Color.LemonChiffon;
                            break;
                        case "aksesoris":
                            Kolom.DefaultCellStyle.BackColor = Color.LightCyan;
                            break;
                        case "pakaian":
                            Kolom.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                            break;
                        default:
                            Kolom.DefaultCellStyle.BackColor = Color.White;
                            break;
                    }
                }
            }
        }

        private void Produk()
        {
            dataGridViewDataProduk.Rows.Clear();

            string[] semuaProduk = File.ReadAllLines(DatabaseRylVa.FileBarang);

            foreach (string khusus in semuaProduk)
            {
                string[] Data = khusus.Split(";");
                string NamaBarang = Data[0];
                string Kategori = Data[1];
                int HargaBeli = int.Parse(Data[2]);
                int HargaSewa = int.Parse(Data[8]);
                string Stok = Data[5];
                string BarangDibeli = Data[9];
                string BarangDiSewa = Data[10];

                dataGridViewDataProduk.Rows.Add(NamaBarang, Kategori, HargaBeli.ToString("N0"), HargaSewa.ToString("N0"), Stok, BarangDibeli, BarangDiSewa);
            }

            foreach (DataGridViewRow Kolom in dataGridViewDataProduk.Rows)
            {
                string Kategori = Kolom.Cells[1].Value.ToString().ToLower();

                switch (Kategori)
                {
                    case "tenda":
                        Kolom.DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    case "tas kemah":
                        Kolom.DefaultCellStyle.BackColor = Color.LightYellow;
                        break;
                    case "alat tidur":
                        Kolom.DefaultCellStyle.BackColor = Color.LightPink;
                        break;
                    case "alat masak":
                        Kolom.DefaultCellStyle.BackColor = Color.Bisque;
                        break;
                    case "penerangan":
                        Kolom.DefaultCellStyle.BackColor = Color.LemonChiffon;
                        break;
                    case "aksesoris":
                        Kolom.DefaultCellStyle.BackColor = Color.LightCyan;
                        break;
                    case "pakaian":
                        Kolom.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                        break;
                    default:
                        Kolom.DefaultCellStyle.BackColor = Color.White;
                        break;
                }
            }
        }

        private void TambahProduk()
        {
            if (dataGridViewDataProduk.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan klik salah satu barang di tabel terlebih dahulu!", "Peringatan");
                return;
            }

            if (string.IsNullOrEmpty(bigTextBoxNamaBarang.Text) || string.IsNullOrEmpty(bigTextBoxhargaBarang.Text) || string.IsNullOrEmpty(bigTextBoxHargaSewa.Text) ||
                string.IsNullOrEmpty(bigTextBoxSokBarang.Text) || string.IsNullOrEmpty(bigTextBoxFileGambar.Text) || string.IsNullOrEmpty(bigTextBoxDeskripsi.Text) ||
                string.IsNullOrEmpty(bigTextBoxSpesifikasi.Text) || string.IsNullOrEmpty(hopeComboBoxKategori.Text))
            {
                MessageBox.Show("Isi Data dan Jangan Kosong!", "Peringatan");
                return;
            }

            string[] semuaBarang = File.ReadAllLines(DatabaseRylVa.FileBarang);
            string namaBarang = bigTextBoxNamaBarang.Text;
            string Kategori = hopeComboBoxKategori.Text;

            foreach (string barang in semuaBarang)
            {
                string[] Data = barang.Split(';');

                if (Data[0].ToLower() == namaBarang.ToLower() && Data[1].ToLower() == Kategori.ToLower())
                {
                    MessageBox.Show("Barang Yang Sudah Ada Tidak Bisa Dimasukkan!", "Peringatan");
                    return;
                }
            }

            Random random = new Random();
            string hargaBarang = bigTextBoxhargaBarang.Text;
            string hargaSewa = bigTextBoxHargaSewa.Text;
            string stokBarang = bigTextBoxSokBarang.Text;
            string namaFileGambar = bigTextBoxFileGambar.Text;
            string deskripsiBarang = bigTextBoxDeskripsi.Text;
            string spesifikasiBarang = bigTextBoxSpesifikasi.Text;
            int rating = random.Next(10, 50);
            string diBeli = "0";
            string diSewa = "0";

            string barangBaru = $"{namaBarang};{Kategori};{hargaBarang};{namaFileGambar};{rating.ToString()};{stokBarang};{deskripsiBarang};{spesifikasiBarang};{hargaSewa};{diBeli};{diSewa}";

            try
            {
                File.AppendAllText(DatabaseRylVa.FileBarang, barangBaru + Environment.NewLine);
                MessageBox.Show("Data Berhasil Ditambahkan, silahkan refresh");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Menyimpan" + ex);
            }
        }

        private void Update()
        {
            if (dataGridViewDataProduk.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan klik salah satu barang di tabel terlebih dahulu!", "Peringatan");
                return;
            }

            if (string.IsNullOrEmpty(bigTextBoxNamaBarang.Text) || string.IsNullOrEmpty(bigTextBoxhargaBarang.Text) || string.IsNullOrEmpty(bigTextBoxHargaSewa.Text) ||
                string.IsNullOrEmpty(bigTextBoxSokBarang.Text) || string.IsNullOrEmpty(bigTextBoxFileGambar.Text) || string.IsNullOrEmpty(bigTextBoxDeskripsi.Text) ||
                string.IsNullOrEmpty(bigTextBoxSpesifikasi.Text) || string.IsNullOrEmpty(hopeComboBoxKategori.Text))
            {
                MessageBox.Show("Isi Data dan Jangan Kosong!", "Peringatan");
                return;
            }

            string NamaProdukDipilih = dataGridViewDataProduk.SelectedRows[0].Cells[0].Value.ToString();

            string[] semuaBarang = File.ReadAllLines(DatabaseRylVa.FileBarang);
            List<string> dataTerbaru = new List<string>();
            bool dataDitemukan = false;

            foreach (string tumbal in semuaBarang)
            {
                string[] Data = tumbal.Split(';');
                if (Data[0].ToLower() == NamaProdukDipilih.ToLower())
                {
                    string rating = Data[4];
                    string terjual = Data[9];
                    string diSewa = Data[10];

                    string updateData = $"{bigTextBoxNamaBarang.Text};{hopeComboBoxKategori.Text};{bigTextBoxhargaBarang.Text};{bigTextBoxFileGambar.Text};{rating};{bigTextBoxSokBarang.Text};{bigTextBoxDeskripsi.Text};{bigTextBoxSpesifikasi.Text};{bigTextBoxHargaSewa.Text};{terjual};{diSewa}";
                    dataTerbaru.Add(updateData);
                    dataDitemukan = true;
                }
                else
                {
                    dataTerbaru.Add(tumbal);
                }
            }

            if (dataDitemukan)
            {
                File.WriteAllLines(DatabaseRylVa.FileBarang, dataTerbaru);
                MessageBox.Show("Data produk berhasil diupdate!", "Sukses");
                RefreshClear();
            }
        }

        private void Remove()
        {
            string NamaProdukDipilih = dataGridViewDataProduk.SelectedRows[0].Cells[0].Value.ToString();
            if (MessageBox.Show($"Apakah Anda yakin ingin menghapus {NamaProdukDipilih} dari data produk \nDATA TIDAK AKAN BISA DIPULIHKAN JIKA DIHAPUS!", "Delete Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(bigTextBoxNamaBarang.Text) || string.IsNullOrEmpty(bigTextBoxhargaBarang.Text) || string.IsNullOrEmpty(bigTextBoxHargaSewa.Text) ||
                string.IsNullOrEmpty(bigTextBoxSokBarang.Text) || string.IsNullOrEmpty(bigTextBoxFileGambar.Text) || string.IsNullOrEmpty(bigTextBoxDeskripsi.Text) ||
                string.IsNullOrEmpty(bigTextBoxSpesifikasi.Text) || string.IsNullOrEmpty(hopeComboBoxKategori.Text))
                {
                    MessageBox.Show("Isi Data dan Jangan Kosong!", "Peringatan");
                    return;
                }

                string[] semuaProduk = File.ReadAllLines(DatabaseRylVa.FileBarang);
                List<string> dataTetap = new List<string>();

                foreach (string baris in semuaProduk)
                {
                    string[] Data = baris.Split(';');

                    if (Data[0] != NamaProdukDipilih)
                    {
                        dataTetap.Add(baris);
                    }
                }

                File.WriteAllLines(DatabaseRylVa.FileBarang, dataTetap);
                MessageBox.Show("Data produk berhasil dihapus!", "Sukses");
                RefreshClear();
            }
        }

        private void RefreshClear()
        {
            Produk();
            crownTextBoxSearch.Text = "";
            bigTextBoxNamaBarang.Text = "";
            bigTextBoxhargaBarang.Text = "";
            bigTextBoxHargaSewa.Text = "";
            bigTextBoxSokBarang.Text = "";
            bigTextBoxFileGambar.Text = "";
            bigTextBoxDeskripsi.Text = "";
            bigTextBoxSpesifikasi.Text = "";
            hopeComboBoxKategori.Text = "";
        }

        private void dataGridViewDataProduk_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewDataProduk.Columns[e.ColumnIndex].Name == "StokBarang" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int stok))
                {
                    if (stok < 10)
                    {
                        e.CellStyle.BackColor = Color.IndianRed;
                        e.CellStyle.ForeColor = Color.White;
                    }

                }
            }
        }

        //backup
        private void hopeRoundButtonBackup_Click(object sender, EventArgs e)
        {
            backup();
        }

        private void backup()
        {

            string jalurDokumen = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderUtamaAplikasi = System.IO.Path.Combine(jalurDokumen, "RylVaCampStore");

            string folderMasterBackup = System.IO.Path.Combine(folderUtamaAplikasi, "Backup");

            if (!System.IO.Directory.Exists(folderMasterBackup))
            {
                System.IO.Directory.CreateDirectory(folderMasterBackup);
            }

            string namaFolderTanggal = "Backup_" + DateTime.Now.ToString("dd-MM-yyyy_HHmmss");
            string folderBackupSaatIni = System.IO.Path.Combine(folderMasterBackup, namaFolderTanggal);

            System.IO.Directory.CreateDirectory(folderBackupSaatIni);

            string fileBarangAsli = System.IO.Path.Combine(folderUtamaAplikasi, "DataBarangRylVa.txt");
            string filePesananAsli = System.IO.Path.Combine(folderUtamaAplikasi, "DataPesananRylVa.txt");
            string filePenggunaAsli = System.IO.Path.Combine(folderUtamaAplikasi, "DataPengunaRylVa.txt");

            if (File.Exists(fileBarangAsli))
            {
                File.Copy(fileBarangAsli, System.IO.Path.Combine(folderBackupSaatIni, "DataBarangRylVa.txt"), true);
            }

            if (File.Exists(filePesananAsli))
            {
                File.Copy(filePesananAsli, System.IO.Path.Combine(folderBackupSaatIni, "DataPesananRylVa.txt"), true);
            }

            if (File.Exists(filePenggunaAsli))
            {
                File.Copy(filePenggunaAsli, System.IO.Path.Combine(folderBackupSaatIni, "DataPengunaRylVa.txt"), true);
            }

            string pathFolderGambarAsli = System.IO.Path.Combine(folderUtamaAplikasi, "Images");
            string pathFolderGambarBackup = System.IO.Path.Combine(folderBackupSaatIni, "Images");

            if (System.IO.Directory.Exists(pathFolderGambarAsli))
            {
                System.IO.Directory.CreateDirectory(pathFolderGambarBackup);
                string[] semuaFoto = System.IO.Directory.GetFiles(pathFolderGambarAsli);

                foreach (string foto in semuaFoto)
                {
                    string namaFileSaja = System.IO.Path.GetFileName(foto);
                    File.Copy(foto, System.IO.Path.Combine(pathFolderGambarBackup, namaFileSaja), true);
                }
            }

            string pathFolderStruk = System.IO.Path.Combine(folderUtamaAplikasi, "Struk");
            string pathFolderStrukBackup = System.IO.Path.Combine(folderBackupSaatIni, "Struk");

            if (System.IO.Directory.Exists(pathFolderStruk))
            {
                System.IO.Directory.CreateDirectory(pathFolderStrukBackup);
                string[] semuaStruk = System.IO.Directory.GetFiles(pathFolderStruk);

                foreach (string struk in semuaStruk)
                {
                    string namaTxt = System.IO.Path.GetFileName(struk);
                    File.Copy(struk, System.IO.Path.Combine(pathFolderStrukBackup, namaTxt), true);
                }
            }

            MessageBox.Show($"Backup Sukses!\nData diamankan di:\nDocuments \\ RylVaCampStore \\ Backup \\ {namaFolderTanggal}", "Backup Berhasil");
        }

        private void hopeRoundButtonCariStruk_Click(object sender, EventArgs e)
        {
            CariStruk();
        }

        private void CariStruk()
        {
            if (dataGridViewDaftarPesanan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan klik salah satu pesanan di tabel terlebih dahulu!", "Peringatan");
                return;
            }

            string IDPesanan = dataGridViewDaftarPesanan.SelectedRows[0].Cells[0].Value.ToString();

            bigTextBoxCariStruk.Text = IDPesanan;

            string folderDokumen = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderStruct = System.IO.Path.Combine(folderDokumen, "RylVaCampStore", "Struk");

            string fileStruk = System.IO.Path.Combine(folderStruct, $"Struck Invoice {IDPesanan}.txt");

            if (File.Exists(fileStruk))
            {
                try
                {
                    Process.Start("notepad.exe", fileStruk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Membuka Struck" + ex, "Gagal");
                }

            }
        }

        private void dataGridViewDaftarPesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string IDPesanan = dataGridViewDaftarPesanan.SelectedRows[0].Cells[0].Value.ToString();
            string Status = dataGridViewDaftarPesanan.SelectedRows[0].Cells[5].Value.ToString();

            textBoxHapusPesanan.Text = IDPesanan;
            bigTextBoxCariStruk.Text = IDPesanan;
            hopeComboBoxStatusUbah.Text = Status;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow barisYangDiklik = dataGridViewDaftarPesanan.Rows[e.RowIndex];

                if (barisYangDiklik.Tag != null)
                {
                    MessageBox.Show(barisYangDiklik.Tag.ToString(), "INFORMASI DENDA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void hopeRoundButtonHapusPesanan_Click(object sender, EventArgs e)
        {
            hapusPesanan();
        }
    }
}
