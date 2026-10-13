using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace XRPLC_07_BerrylZelva_TA
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            FormLogin Login = new FormLogin();
            Login.Show();
            this.Hide();
        }

        private void buttonSetujuRegister_Click(object sender, EventArgs e)
        {
            //validasi kesalahan
            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxPasswordRg.Text) || string.IsNullOrEmpty(textBoxUsernameRegister.Text) ||
                string.IsNullOrEmpty(textBoxPassVerif.Text) || string.IsNullOrEmpty(textBoxNamaUser.Text) ||
                string.IsNullOrEmpty(textBoxAlamatUser.Text) || string.IsNullOrEmpty(textBoxKotaKecamatan.Text) ||
                string.IsNullOrEmpty(textBoxProvinsi.Text) || string.IsNullOrEmpty(textBoxNomorTelepon.Text))
            {
                MessageBox.Show("Periksa lagi dan isi kolom yang kosong!", "gagal melakukan registrasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //username ga boleh ada "spasi" karena bug
            if (textBoxUsernameRegister.Text.Contains(" "))
            {
                MessageBox.Show("Username Tidak Boleh Ada Spasi!", "gagal melakukan registrasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //wajib beda
            if (textBoxPasswordRg.Text != textBoxPassVerif.Text)
            {
                MessageBox.Show("Password dan Verifikasi password tidak sama, harap ulang!", "Failed register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //sistem utama
            string UsernameBaru = textBoxUsernameRegister.Text.Trim();
            string EmailUserBaru = textBoxEmail.Text.Trim();

            if (File.Exists(DatabaseRylVa.FilePengguna))
            {
                //ambil data
                string[] KumpulanData = File.ReadAllLines(DatabaseRylVa.FilePengguna);

                foreach (string baris in KumpulanData)
                {
                    if (string.IsNullOrWhiteSpace(baris))//abaikan baris kosong
                    {
                        continue;
                    }

                    string[] KolomBaca = baris.Split(';');

                    if (KolomBaca.Length < 8)//jika format file rusak
                    {
                        continue;
                    }

                    if (KolomBaca[0] == UsernameBaru)//verivikasi nama
                    {
                        MessageBox.Show("Usename Sudah Terpakai! Coba Ganti", "Peringatan");
                        return;
                    }

                    if (KolomBaca[1] == EmailUserBaru)//verifikasi email
                    {
                        MessageBox.Show("Email Sudah Terdaftar! Coba Ganti", "Peringatan");
                        return;
                    }
                }
            }

            //gabungkan
            string dataUserRegis = $"{UsernameBaru};{EmailUserBaru};{textBoxPasswordRg.Text.Trim()};{textBoxNamaUser.Text.Trim()};{textBoxAlamatUser.Text.Trim()};{textBoxKotaKecamatan.Text.Trim()};{textBoxProvinsi.Text.Trim()};{textBoxNomorTelepon.Text.Trim()};";

            try
            {
                //coba masukkan ke database dan login
                File.AppendAllText(DatabaseRylVa.FilePengguna, dataUserRegis + Environment.NewLine);
                MessageBox.Show("Registrasi berhasil! Silahkan login", "Register Berhasil", MessageBoxButtons.OK);
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
            catch (Exception gagal)
            {
                MessageBox.Show("Terjadi Kesalahan saat menyimpan!" + gagal.Message);
            }
        }

        private void buttonCancelRegis_Click(object sender, EventArgs e)
        {
            cancel();
        }
        private void cancel()
        {
            if (MessageBox.Show("Apa anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                textBoxEmail.Text = "";
                textBoxUsernameRegister.Text = "";
                textBoxPasswordRg.Text = "";
                textBoxPassVerif.Text = "";
                textBoxNamaUser.Text = "";
                textBoxAlamatUser.Text = "";
                textBoxKotaKecamatan.Text = "";
                textBoxProvinsi.Text = "";
                textBoxNomorTelepon.Text = "";

                MessageBox.Show("Oke, Thank You :)");

                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }
    }
}
