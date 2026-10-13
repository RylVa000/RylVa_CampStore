using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XRPLC_07_BerrylZelva_TA
{
    public partial class PilihTujuan : Form
    {
        public PilihTujuan()
        {
            InitializeComponent();
        }

        private void PilihTujuan_Load(object sender, EventArgs e)
        {
        }

        private void buttonFormSewa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin Memilih Mode Sewa?", "Sewa Alat", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DatabaseRylVa.daftarbelanja.Clear();
                DatabaseRylVa.pilihanMode = "Sewa";
                FormSewa sewa = new FormSewa();
                sewa.Show();
                this.Hide();
            }
        }

        private void buttonFormbeli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin Memilih Mode Beli Alat?", "Beli Alat", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DatabaseRylVa.daftarbelanja.Clear();
                DatabaseRylVa.pilihanMode = "Beli";
                FormBeli beli = new FormBeli();
                beli.Show();
                this.Hide();
            }
        }
    }
}
