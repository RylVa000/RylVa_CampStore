using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XRPLC_07_BerrylZelva_TA
{
    public partial class FormBeli : Form
    {

        public FormBeli()
        {
            InitializeComponent();
        }

        private void Katalog(string KataKunci = "Semua", string KategoriPilihan = "")
        {
            flowLayoutPanelKatalog.Controls.Clear();

            if (!File.Exists(DatabaseRylVa.FileBarang))
            {
                return;
            }

            string[] Lines = File.ReadAllLines(DatabaseRylVa.FileBarang);

            foreach (string line in Lines)
            {
                //ambil data
                String[] Data = line.Split(';');
                String namaBarang = Data[0];
                string tipeBarang = Data[1];
                string hargaBarang = Data[2];
                string fileGambar = Data[3];
                string jumlahRating = Data[4];
                string stokBarang = Data[5];
                string deskripsiBarang = Data[6];
                string spekBarang = Data[7];

                //kategori nentuin sama kah, tipe dengan radio kategori
                bool CocokKategori = (KategoriPilihan == "Semua" || tipeBarang == KategoriPilihan);
                //kata kunci mencari kata yang di imput ke nama barang
                bool CocokKataKunci = namaBarang.ToLower().Contains(KataKunci.ToLower());

                if (CocokKataKunci && CocokKategori)
                {
                    if (int.Parse(stokBarang) <= 0)
                    {
                        continue;//jika stok <= 0 maka tidak akan dibaca
                    }

                    //buat tampilan OTOMATIS
                    Panel cardPanel = new Panel();
                    cardPanel.Size = new(180, 220);
                    cardPanel.BackColor = Color.White;
                    cardPanel.Margin = new Padding(10);

                    PictureBox pictureBarang = new PictureBox();
                    pictureBarang.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBarang.Location = new Point(10, 10);
                    pictureBarang.Size = new(160, 120);

                    string gambar = Path.Combine(DatabaseRylVa.FolderGambar, fileGambar);
                    if (File.Exists(gambar))
                    {
                        try
                        {
                            pictureBarang.Image = Image.FromFile(gambar);
                        }
                        catch
                        {
                            pictureBarang.BackColor = Color.LightGray;
                        }

                    }
                    else
                    {
                        pictureBarang.BackColor = Color.LightGray;
                    }

                    Label labelNamaProduk = new Label();
                    labelNamaProduk.Text = namaBarang;
                    labelNamaProduk.Font = new Font("Segeo UI", 10, FontStyle.Bold);
                    labelNamaProduk.Location = new Point(10, 140);
                    labelNamaProduk.AutoSize = true;

                    Label labelHarga = new Label();
                    labelHarga.Text = $"Rp {int.Parse(hargaBarang):N0}";
                    labelHarga.Location = new Point(10, 165);
                    labelHarga.AutoSize = true;

                    Button buttonDetail = new Button();
                    buttonDetail.Text = "Lihat Detail";
                    buttonDetail.Location = new Point(10, 190);
                    buttonDetail.Size = new Size(160, 25);
                    buttonDetail.BackColor = Color.FromArgb(46, 90, 39);
                    buttonDetail.ForeColor = Color.White;
                    buttonDetail.FlatStyle = FlatStyle.Flat;

                    buttonDetail.Click += (s, e) =>
                    {
                        FormDetailProduk formDetail = new FormDetailProduk(namaBarang, hargaBarang, fileGambar, stokBarang, jumlahRating, deskripsiBarang, spekBarang);
                        formDetail.Show();
                        this.Hide();
                    };

                    //tambahkan semua elemen ke panel
                    cardPanel.Controls.Add(labelNamaProduk);
                    cardPanel.Controls.Add(labelHarga);
                    cardPanel.Controls.Add(buttonDetail);
                    cardPanel.Controls.Add(pictureBarang);

                    //masukkan panel ke FlPK
                    flowLayoutPanelKatalog.Controls.Add(cardPanel);
                }
            }
        }

        private void FormBeli_Load(object sender, EventArgs e)
        {
            Katalog();
            labelSetAccount.Text = DatabaseRylVa.akunLogin;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string kataKunci = textBoxCariBarang.Text;
            string kategori = dapatkategori();
            Katalog(kataKunci, kategori);
        }

        private string dapatkategori()
        {
            if (radioTenda.Checked)
            {
                return "Tenda";
            }
            if (radioTas.Checked)
            {
                return "Tas Kemah";
            }
            if (radioAlatMasak.Checked)
            {
                return "Alat Masak";
            }
            if (radioButtonAlatTidur.Checked)
            {
                return "Alat Tidur";
            }
            if (radioButtonPenerangan.Checked)
            {
                return "Penerangan";
            }
            if (radioButtonAksesoris.Checked)
            {
                return "Aksesoris";
            }
            if (radioButtonPakaian.Checked)
            {
                return "Pakaian";
            }
            return "Semua";
        }


        private void labelSetAccount_Click(object sender, EventArgs e)
        {
            DatabaseRylVa.back = "Beli";
            FormAccountSetting Akun = new FormAccountSetting();
            Akun.Show();
            this.Hide();
        }

        private void pictureBoxKeranjang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin berpindah ke keranjang", "Beralih ke keranjang", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Payment bayar = new Payment();
                bayar.Show();
                this.Hide();
            }
        }
    }
}
