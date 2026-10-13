    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XRPLC_07_BerrylZelva_TA
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        //ubah data akun
        private void labelAccount_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Anda Yakin ingin merubah data akun?", "Charge Data", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FormAccountSetting akun = new FormAccountSetting();
                akun.Show();
                this.Hide();
                DatabaseRylVa.back = "Payment";
            }
        }

        //sistem bayar
        private void buttonPay_Click(object sender, EventArgs e)
        {
            string metode = metodebayar();

            if (DatabaseRylVa.totalPayment <= 0) 
            {
                MessageBox.Show("Total Payment Tidak Boleh 0!", "Peringatan");
                return;
            }

            switch (metode)
            {
                case "Bank Transfer":
                    DatabaseRylVa.MetodeBayar = "Bank";
                    MessageBox.Show("Andaa memilih Transfer", "Bank Transfer");
                    break;

                case "COD":
                    DatabaseRylVa.MetodeBayar = "COD";
                    MessageBox.Show("Pesanan akan diproses. Siapkan uang tunai saat kurir tiba!", "Cash On Delivery");
                    break;

                case "Kredit":
                    DatabaseRylVa.MetodeBayar = "Kredit";
                    MessageBox.Show("Kamu memilih metode cicilan Kredit.", "Kredit");
                    break;

                case "Qris":
                    DatabaseRylVa.MetodeBayar = "Qris";
                    MessageBox.Show("Anda Memilih Qris sebagai metode pembayaran", "QRIS");
                    break;

                default:
                    MessageBox.Show("Harap pilih metode pembayaran terlebih dahulu!", "Peringatan");
                    return;
                    break;
            }

            VerifikasiPembayaran verif = new VerifikasiPembayaran();
            verif.Show();
            this.Hide();
        }

        private string metodebayar()
        {
            if (radioButtonBank.Checked)
            {
                return "Bank Transfer";
            }
            else if (radioButtonCOD.Checked)
            {
                return "COD";
            }
            else if (radioButtonKredit.Checked)
            {
                return "Kredit";
            }
            else if (radioButtonQris.Checked)
            {
                return "Qris";
            }
            return "Payment Gagal";
        }

        //sistem tampilkan data di datagrid
        private void Payment_Load(object sender, EventArgs e)
        {
            dataGridViewKeranjang.AutoGenerateColumns = false;
            //menyesuaikan panjang kolom dengan nama produk
            dataGridViewKeranjang.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //mengambil data dari list utama
            dataGridViewKeranjang.DataSource = DatabaseRylVa.daftarbelanja;

            HitungTotalHarga();

            if (DatabaseRylVa.pilihanMode == "Sewa")
            {
                dataGridViewKeranjang.Columns["LamaSewa"].Visible = true;
            }
            else if (DatabaseRylVa.pilihanMode == "Beli")
            {
                dataGridViewKeranjang.Columns["LamaSewa"].Visible = false;
            }

            string[] infoAkun = File.ReadAllLines(DatabaseRylVa.FilePengguna);

            foreach (string line in infoAkun)
            {
                string[] Data = line.Split(";");
                if (Data[0] == DatabaseRylVa.akunLogin)
                {
                    labelNamaPenerima.Text = $"Penerima: {Data[3]}";
                    labelEmail.Text = $"Email: {Data[1]}";
                    labelNomorTelepon.Text = $"Nomor Telepon: {Data[7]}";
                    labelAlamat.Text = $"Alamat: {Data[4]}, \n{Data[5]}, {Data[6]}";

                    break;
                }
            }
        }

        //sistem back
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (DatabaseRylVa.pilihanMode == "Beli")
            {
                FormBeli katalog = new FormBeli();
                katalog.Show();
                this.Hide();
            }
            else if (DatabaseRylVa.pilihanMode == "Sewa")
            {
                FormSewa katalog = new FormSewa();
                katalog.Show();
                this.Hide();
            }
        }

        private void HitungTotalHarga()
        {
            DatabaseRylVa.totalPayment = 0;

            foreach (Keranjang items in DatabaseRylVa.daftarbelanja)
            {
                DatabaseRylVa.totalPayment += items.subtotal;//akan menambah seiring pesanan
            }

            labelTotalPayment.Text = $"Total Payment: {DatabaseRylVa.totalPayment.ToString("N0")}";
        }

        //sistem hapus barang
        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (dataGridViewKeranjang.CurrentRow == null)
            {
                MessageBox.Show("Pilih Dulu Barang Yang Ingin Di Hapus", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            DialogResult pilihan = MessageBox.Show("Pilih Opsi Hapus:\n\nKlik 'YES' untuk MENGURANGI QTY (-1).\nKlik 'NO' untuk MENGHAPUS SELURUH barang ini.\nKlik 'CANCEL' untuk batal.","Hapus Pesanan",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

            //mengambil data dari cell yang diklik
            Keranjang produkDipilih = (Keranjang)dataGridViewKeranjang.CurrentRow.DataBoundItem;

            if (pilihan == DialogResult.Yes)
            {
                produkDipilih.qty--;

                if (produkDipilih.qty <= 0)
                {
                    DatabaseRylVa.daftarbelanja.Remove(produkDipilih);
                }
                else
                {
                    DatabaseRylVa.daftarbelanja.ResetBindings();
                }
                HitungTotalHarga();
            }
            else if (pilihan == DialogResult.No)
            {
                DatabaseRylVa.daftarbelanja.Remove(produkDipilih);
                HitungTotalHarga();
            }
        }

        
    }
}
