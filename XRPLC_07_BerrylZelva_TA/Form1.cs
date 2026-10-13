using System.IO;
using System;
using System.Security.Cryptography.X509Certificates;
namespace XRPLC_07_BerrylZelva_TA
{
    public partial class FormLogin : Form
    {
        public static bool antri = false;
        public bool akunLogout = false;
        public string akunVerifikasiLogout = "";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBoxMata_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == true)
            {
                pictureBoxMata.Image = Properties.Resources.Matabuka;
                textBoxPassword.UseSystemPasswordChar = false;
                pictureBoxMata.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBoxMata.Image = Properties.Resources.Matanutup;
                textBoxPassword.UseSystemPasswordChar = true;
                pictureBoxMata.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string UserName = textBoxUsername.Text.Trim();
            string UserPass = textBoxPassword.Text.Trim();
            string DataSumber = (DatabaseRylVa.FilePengguna);

            bool verivikasi = false;
            string[] Data = File.ReadAllLines(DataSumber);

            foreach (string baris in Data)
            {
                string[] Find = baris.Split(';');

                //penentu yang mencocokan database dengan input user 
                if (Find[0] == UserName && Find[2] == UserPass)
                {
                    verivikasi = true;
                    string Username = Find[0];
                    DatabaseRylVa.akunLogin = Username;

                    //sesi admin
                    if (UserName == "RylVa" && UserPass == "Lyree000")
                    {
                        MessageBox.Show("Selamat Datang Admin!!!", "Admin", MessageBoxButtons.OK);

                        DashBoard dashBoard = new DashBoard();
                        dashBoard.Show();

                    }
                    //sesi user
                    else
                    {
                        MessageBox.Show($"Akun Ditemukan, Selamat Datang {UserName.ToUpper()}", "Login", MessageBoxButtons.OK);

                        akunVerifikasiLogout = Username;
                        //cek apakah akun yang logout
                        habisLogout();

                        //akun ketemu dan bukan akun yang logout karena suatu hal
                        if (!akunLogout)
                        {
                            PilihTujuan tujuan = new PilihTujuan();
                            tujuan.Show();
                            DatabaseRylVa.akunLogin = UserName;
                        }
                    }

                    this.Hide();
                    break;
                }

            }

            if (!verivikasi)
            {
                MessageBox.Show("Username Atau Sandi salah, Silahkan Coba Lagi!!!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void habisLogout()
        {
            if (DatabaseRylVa.daftarbelanja.Count == 0)// memastikan kalo user belum milih apa2 tapi logout
            {
                DatabaseRylVa.logoutBeli = false;
                DatabaseRylVa.logoutSewa = false;
                DatabaseRylVa.akunLogout = "";
                return;
            }

            if (akunVerifikasiLogout == DatabaseRylVa.akunLogout && DatabaseRylVa.sudahBayar == false)
            {
                //cek status pilihan mode
                if (DatabaseRylVa.pilihanMode == "Beli" && DatabaseRylVa.logoutBeli)
                {
                    //mode beli
                    if (MessageBox.Show("Anda Logout Dari Mode Beli \nIngin Lanjutkan Transaksi?", "Kembali Transaksi", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        akunLogout = true;
                        Payment bayar = new Payment();
                        bayar.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Transaksi ulang dari awal!");
                        DatabaseRylVa.daftarbelanja.Clear();
                    }
                }
                else if (DatabaseRylVa.pilihanMode == "Sewa" && DatabaseRylVa.logoutSewa)
                {
                    //mode sewa
                    if (MessageBox.Show("Anda Logout Dari Mode Sewa \nIngin Lanjutkan Transaksi?", "Kembali Transaksi", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        akunLogout = true;
                        Payment bayar = new Payment();
                        bayar.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Transaksi ulang dari awal!");
                        DatabaseRylVa.daftarbelanja.Clear();
                    }
                }
                //reset status
                DatabaseRylVa.sudahBayar = false;
                DatabaseRylVa.logoutBeli = false;
                DatabaseRylVa.logoutSewa = false;
                DatabaseRylVa.akunLogout = "";
            }
        }
    }
}
