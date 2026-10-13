using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XRPLC_07_BerrylZelva_TA
{
    public partial class FormAccountSetting : Form
    {
        public FormAccountSetting()
        {
            InitializeComponent();
        }

        private void hopeRoundButtonLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void logout()
        {
            if (MessageBox.Show("anda Yakin Untuk Logout", "Logout", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DatabaseRylVa.akunLogout = DatabaseRylVa.akunLogin;
                if (DatabaseRylVa.pilihanMode == "Beli")
                {
                    DatabaseRylVa.logoutBeli = true;
                    DatabaseRylVa.logoutSewa = false;
                }
                else
                {
                    DatabaseRylVa.logoutSewa = true;
                    DatabaseRylVa.logoutBeli = false;
                }

                FormLogin back = new FormLogin();
                back.Show();
                this.Hide();
            }
        }

        private void hopeRoundButtonEditData_Click(object sender, EventArgs e)
        {
            VerifikasiAkun();
        }

        private void hopeRoundButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void VerifikasiAkun()
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxSandi.Text))
            {
                MessageBox.Show("Isi email dan sandi dulu");
                return;
            }

            string[] semuaAkun = File.ReadAllLines(DatabaseRylVa.FilePengguna);
            string email = textBoxEmail.Text;
            string sandi = textBoxSandi.Text;
            bool akunDitemukan = false;

            foreach (string s in semuaAkun)
            {
                string[] Data = s.Split(';');
                if (Data[2] == sandi && Data[1] == email)
                {
                    MessageBox.Show("Silahkan Isi Data");

                    textBoxSandiGanti.Text = Data[2];
                    textBoxNamaLengkap.Text = Data[3];
                    textBoxAlamat.Text = Data[4];
                    textBoxKota.Text = Data[5];
                    textBoxProvinsi.Text = Data[6];
                    textBoxTelepon.Text = Data[7];

                    textBoxSandiGanti.ReadOnly = false;
                    textBoxNamaLengkap.ReadOnly = false;
                    textBoxAlamat.ReadOnly = false;
                    textBoxKota.ReadOnly = false;
                    textBoxProvinsi.ReadOnly = false;
                    textBoxTelepon.ReadOnly = false;

                    hopeRoundButtonUpdate.Enabled = true;
                    akunDitemukan = true;
                    break;
                }
            }

            if (!akunDitemukan)
            {
                MessageBox.Show("Email Atau Sandi Salah!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateData()
        {
            if (string.IsNullOrWhiteSpace(textBoxSandiGanti.Text) || string.IsNullOrWhiteSpace(textBoxNamaLengkap.Text) ||
                string.IsNullOrWhiteSpace(textBoxAlamat.Text) || string.IsNullOrWhiteSpace(textBoxKota.Text) ||
                string.IsNullOrWhiteSpace(textBoxProvinsi.Text) || string.IsNullOrWhiteSpace(textBoxTelepon.Text))
            {
                MessageBox.Show("Harap Masukkan Data Dengan Benar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] semuaAkun = File.ReadAllLines(DatabaseRylVa.FilePengguna);
            List<string> dataTerbaru = new List<string>();
            bool dataKetemu = false;

            foreach (string Akun in semuaAkun)
            {
                if (string.IsNullOrWhiteSpace(Akun))
                {
                    continue;
                }

                string[] Data = Akun.Split(';');

                if (Data.Length < 2)
                {
                    dataTerbaru.Add(Akun);
                    continue;
                }

                if (Data[1] == textBoxEmail.Text)
                {
                    string username = Data[0];
                    string email = Data[1];

                    string DataAkunUpdate = $"{username};{email};{textBoxSandiGanti.Text};{textBoxNamaLengkap.Text};{textBoxAlamat.Text};{textBoxKota.Text};{textBoxProvinsi.Text};{textBoxTelepon.Text}";
                    dataTerbaru.Add(DataAkunUpdate);

                    dataKetemu = true;
                }
                else
                {
                    dataTerbaru.Add(Akun);
                }
            }

            if (dataKetemu)
            {
                DatabaseRylVa.akunLogout = DatabaseRylVa.akunLogin;

                if (DatabaseRylVa.pilihanMode == "Beli")
                {
                    DatabaseRylVa.logoutBeli = true;
                    DatabaseRylVa.logoutSewa = false;
                }
                else if (DatabaseRylVa.pilihanMode == "Sewa")
                {
                    DatabaseRylVa.logoutSewa = true;
                    DatabaseRylVa.logoutBeli = false;
                }

                File.WriteAllLines(DatabaseRylVa.FilePengguna, dataTerbaru);

                MessageBox.Show("Data Akun berhasil diupdate!", "Sukses");

                textBoxEmail.Text = "";
                textBoxSandi.Text = "";
                textBoxSandiGanti.Text = "";
                textBoxNamaLengkap.Text = "";
                textBoxAlamat.Text = "";
                textBoxKota.Text = "";
                textBoxProvinsi.Text = "";
                textBoxTelepon.Text = "";

                MessageBox.Show("Silahkan Login Ulang!", "Login");
                FormLogin back = new FormLogin();
                back.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data. Akun tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormAccountSetting_Load(object sender, EventArgs e)
        {
            labelUsername.Text = DatabaseRylVa.akunLogin;
        }


        //History Belanja
        private void hopeRoundButtonHistoryBelanja_Click(object sender, EventArgs e)
        {
            panelHistory.Visible = true;
            panelInfoPribadi.Visible = false;
            History();
        }

        private void hopeRoundButtonInformasiPribadi_Click(object sender, EventArgs e)
        {
            panelHistory.Visible = false;
            panelInfoPribadi.Visible = true;
        }

        private void History()
        {
            dataGridViewHistory.Rows.Clear();

            string[] semuaAkun = File.ReadAllLines(DatabaseRylVa.FilePesanan);

            foreach (string akun in semuaAkun)
            {
                if (string.IsNullOrWhiteSpace(akun)) continue;

                string[] Data = akun.Split(';');

                if (Data[2] == DatabaseRylVa.akunLogin)
                {
                    string IDPesanan = Data[0];
                    string Tanggal = Data[1];
                    string Pesanan = Data[5];
                    string Mode = Data[7];
                    string Total = int.Parse(Data[6]).ToString("N0");
                    string status = Data[9];

                    int rowIndex = dataGridViewHistory.Rows.Add(IDPesanan, Tanggal, Pesanan, Mode, Total, status);
                    DataGridViewRow row = dataGridViewHistory.Rows[rowIndex];

                    string kategori = Mode.ToLower().Trim();

                    if (kategori == "beli")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (kategori == "sewa")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                }
            }
        }

        private void hopeRoundButtonBack_Click(object sender, EventArgs e)
        {
            penentuBack();
        }

        private void penentuBack()
        {
            if (DatabaseRylVa.back == "Payment")
            {
                if (MessageBox.Show("Anda Yakin ingin kembali ke Payment?", "Kembali", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Payment bayar = new Payment();
                    bayar.Show();
                    this.Hide();
                }
            }
            else if (DatabaseRylVa.back == "Beli")
            {
                if (MessageBox.Show("Anda Yakin ingin kembali ke Katalog Beli?", "Kembali", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    FormBeli beli = new FormBeli();
                    beli.Show();
                    this.Hide();
                }
            }
            else if (DatabaseRylVa.back == "Sewa")
            {
                if (MessageBox.Show("Anda Yakin ingin kembali ke Katalog Sewa?", "Kembali", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    FormSewa sewa = new FormSewa();
                    sewa.Show();
                    this.Hide();
                }
            }

            else if (DatabaseRylVa.back == "VerifikasiPembayaran")
            {
                DialogResult pilihan = MessageBox.Show("Pilih Opsi Kembali:\n\nKlik 'YES' untuk kembali ke splash pembayaran berhasil.\nKlik 'NO' untuk kembali ke pilihan mode.\nKlik 'CANCEL' untuk batal.", "Hapus Pesanan", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (pilihan == DialogResult.Yes)
                {
                    VerifikasiPembayaran verifikasi = new VerifikasiPembayaran();
                    verifikasi.Show();
                    this.Hide();
                }
                else if (pilihan == DialogResult.No)
                {
                    PilihTujuan tujuan = new PilihTujuan();
                    tujuan.Show();
                    this.Hide();
                }
            }
        }

        private void CariStruk()
        {
            if (dataGridViewHistory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan klik salah satu pesanan di tabel terlebih dahulu!", "Peringatan");
                return;
            }

            string IDPesanan = dataGridViewHistory.SelectedRows[0].Cells[0].Value.ToString();

            if (IDPesanan == null || string.IsNullOrWhiteSpace(IDPesanan))
            {
                MessageBox.Show("Harap klik baris data yang berisi ID Pesanan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void dataGridViewHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow barisDiklik = dataGridViewHistory.Rows[e.RowIndex];

            if (barisDiklik.IsNewRow)
            {
                return;
            }

            string IDPesanan = dataGridViewHistory.SelectedRows[0].Cells[0].Value.ToString();
            bigTextBoxCariStruk.Text = IDPesanan;
        }

        private void hopeRoundButtonCariStruk_Click(object sender, EventArgs e)
        {
            CariStruk();
        }
    }
}
