using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace XRPLC_07_BerrylZelva_TA
{
    public partial class FormDetailProduk : Form
    {
        string namaProdukDipilih;
        int hargaProdukDipilih;
        int stock;
        public FormDetailProduk(string nama, string harga, string fileGambar, string stok, string rating, string deskripsi, string spek)
        {
            InitializeComponent();

            stock = int.Parse(stok);
            namaProdukDipilih = nama;
            hargaProdukDipilih = int.Parse(harga);
            labelNamaProduk.Text = nama;

            if (DatabaseRylVa.pilihanMode == "Beli")
            {
                labelHargaProduk.Text = $"Rp {hargaProdukDipilih.ToString("N0")} /Unit";
            }
            else if (DatabaseRylVa.pilihanMode == "Sewa")
            {
                labelHargaProduk.Text = $"Rp {hargaProdukDipilih.ToString("N0")} /Hari";
            }


            labelStok.Text = $"Stok Tersedia: {stok} Units";
            labelRating.Text = $"({rating}) reviews";
            labelDeskripsi.Text = deskripsi;

            string Spek = spek.Replace(" - ", " \n ");
            labelSpek.Text = Spek;

            string gambar = Path.Combine(DatabaseRylVa.FolderGambar, fileGambar);
            pictureBoxUtama.SizeMode = PictureBoxSizeMode.Zoom;
            if (File.Exists(gambar))
            {
                try
                {
                    pictureBoxUtama.Image = Image.FromFile(gambar);
                }
                catch
                {
                    pictureBoxUtama.BackColor = Color.LightGray;
                }

            }
        }

        private void FormDetailProduk_Load(object sender, EventArgs e)
        {
            if (DatabaseRylVa.pilihanMode == "Beli")
            {
                dateTimePickerPinjam.Visible = false;
                dateTimePickerKembali.Visible = false;
                labelPinjam.Visible = false;
                labelLabelKembali.Visible = false;
            }
            else
            {
                dateTimePickerPinjam.Visible = true;
                dateTimePickerKembali.Visible = true;
                labelPinjam.Visible = true;
                labelLabelKembali.Visible = true;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (DatabaseRylVa.pilihanMode == "Beli")
            {
                FormBeli formBeli = new FormBeli();
                formBeli.Show();
                this.Hide();
            }
            else if (DatabaseRylVa.pilihanMode == "Sewa")
            {
                FormSewa formSewa = new FormSewa();
                formSewa.Show();
                this.Hide();
            }  
        }

        private void buttonKeranjang_Click(object sender, EventArgs e)
        {
            string teksjumlahPesan = textBoxJumlahPesan.Text;

            if (int.TryParse(teksjumlahPesan, out int jumlahPesan) && jumlahPesan > 0 && jumlahPesan <= stock)
            {
                int hitungLamaSewa = 1; 

                if (DatabaseRylVa.pilihanMode == "Sewa")
                {
                    DateTime pinjam = dateTimePickerPinjam.Value.Date;
                    DateTime kembali = dateTimePickerKembali.Value.Date;

                    TimeSpan selisihHari = kembali - pinjam;
                    hitungLamaSewa = selisihHari.Days;

                    if (hitungLamaSewa < 1)
                    {
                        hitungLamaSewa = 1;
                    }

                    MessageBox.Show($"Lama Pinjaman: {hitungLamaSewa} Hari");
                }
                Keranjang barangada = DatabaseRylVa.daftarbelanja.FirstOrDefault(i => i.Nama == namaProdukDipilih);

                if (barangada != null)
                {
                    if (DatabaseRylVa.pilihanMode == "Sewa")
                    {
                        DialogResult barangUdahAda = MessageBox.Show($"Barang sudah ada di dalam keranjang.\n\nPilih tindakan:\n[YES] = Tambah Qty (Jumlah Barang)\n[NO] = Ubah Masa Sewa (Hari)\n[CANCEL] = Batalkan","Kelola", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (barangUdahAda == DialogResult.Yes)
                        {
                            if (barangada.qty + jumlahPesan > stock)
                            {
                                MessageBox.Show($"Gagal! Jika ditambah, jumlah barang ({barangada.qty + jumlahPesan}) akan melebihi stok yang ada ({stock}).", "Peringatan Stok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; 
                            }
                            barangada.qty += jumlahPesan;
                        }
                        else if (barangUdahAda == DialogResult.No)
                        {
                            barangada.lamaSewa = hitungLamaSewa;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else if (DatabaseRylVa.pilihanMode == "Beli")
                    {
                        if (barangada.qty + jumlahPesan > stock)
                        {
                            MessageBox.Show($"Gagal! Jika ditambah, jumlah barang ({barangada.qty + jumlahPesan}) akan melebihi stok yang ada ({stock}).", "Peringatan Stok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        barangada.qty += jumlahPesan;
                        barangada.lamaSewa = hitungLamaSewa;
                    }

                    DatabaseRylVa.daftarbelanja.ResetBindings(); 
                }
                else
                {
                    Keranjang dataBarang = new Keranjang();
                    dataBarang.Nama = namaProdukDipilih;
                    dataBarang.hargaSatuan = hargaProdukDipilih;
                    dataBarang.qty = jumlahPesan;
                    dataBarang.lamaSewa = hitungLamaSewa; 

                    DatabaseRylVa.daftarbelanja.Add(dataBarang);
                }

                if (MessageBox.Show("Barang Berhasil Ditambahkan di Keranjang \nApakah ingin lihat keranjang?", "Keranjang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Payment bayar = new Payment();
                    bayar.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Mohon masukkan jumlah angka yang benar!\n                    Atau \n Jumlah Pesan Tidak Boleh Lebih dari stock", "Peringatan Qty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
