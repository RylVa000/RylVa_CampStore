namespace XRPLC_07_BerrylZelva_TA
{
    partial class FormAccountSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            hopeRoundButtonBack = new ReaLTaiizor.Controls.HopeRoundButton();
            hopeRoundButtonLogout = new ReaLTaiizor.Controls.HopeRoundButton();
            hopeRoundButtonHistoryBelanja = new ReaLTaiizor.Controls.HopeRoundButton();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            hopeRoundButtonInformasiPribadi = new ReaLTaiizor.Controls.HopeRoundButton();
            panelInfoPribadi = new Panel();
            groupBox1 = new GroupBox();
            textBoxSandiGanti = new TextBox();
            label10 = new Label();
            hopeRoundButtonUpdate = new ReaLTaiizor.Controls.HopeRoundButton();
            textBoxTelepon = new TextBox();
            label9 = new Label();
            textBoxProvinsi = new TextBox();
            label8 = new Label();
            textBoxKota = new TextBox();
            label7 = new Label();
            textBoxAlamat = new TextBox();
            label6 = new Label();
            textBoxNamaLengkap = new TextBox();
            label5 = new Label();
            hopeRoundButtonEditData = new ReaLTaiizor.Controls.HopeRoundButton();
            textBoxSandi = new TextBox();
            label4 = new Label();
            textBoxEmail = new TextBox();
            label3 = new Label();
            labelUsername = new Label();
            panelHistory = new Panel();
            label19 = new Label();
            hopeRoundButtonCariStruk = new ReaLTaiizor.Controls.HopeRoundButton();
            bigTextBoxCariStruk = new ReaLTaiizor.Controls.BigTextBox();
            dataGridViewHistory = new DataGridView();
            IDPesanan = new DataGridViewTextBoxColumn();
            Tanggal = new DataGridViewTextBoxColumn();
            NamaBarang = new DataGridViewTextBoxColumn();
            ModePilihan = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelInfoPribadi.SuspendLayout();
            groupBox1.SuspendLayout();
            panelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LogoAkun;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(216, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 87);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(138, 169, 137);
            panel1.Controls.Add(hopeRoundButtonBack);
            panel1.Controls.Add(hopeRoundButtonLogout);
            panel1.Controls.Add(hopeRoundButtonHistoryBelanja);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(hopeRoundButtonInformasiPribadi);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 486);
            panel1.TabIndex = 2;
            // 
            // hopeRoundButtonBack
            // 
            hopeRoundButtonBack.BorderColor = Color.FromArgb(220, 223, 230);
            hopeRoundButtonBack.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButtonBack.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButtonBack.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButtonBack.Font = new Font("Segoe UI", 12F);
            hopeRoundButtonBack.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButtonBack.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButtonBack.Location = new Point(14, 275);
            hopeRoundButtonBack.Name = "hopeRoundButtonBack";
            hopeRoundButtonBack.PrimaryColor = Color.FromArgb(35, 47, 45);
            hopeRoundButtonBack.Size = new Size(139, 40);
            hopeRoundButtonBack.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButtonBack.TabIndex = 12;
            hopeRoundButtonBack.Text = "Back";
            hopeRoundButtonBack.TextColor = Color.White;
            hopeRoundButtonBack.WarningColor = Color.FromArgb(230, 162, 60);
            hopeRoundButtonBack.Click += hopeRoundButtonBack_Click;
            // 
            // hopeRoundButtonLogout
            // 
            hopeRoundButtonLogout.BorderColor = Color.FromArgb(220, 223, 230);
            hopeRoundButtonLogout.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButtonLogout.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButtonLogout.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButtonLogout.Font = new Font("Segoe UI", 12F);
            hopeRoundButtonLogout.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButtonLogout.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButtonLogout.Location = new Point(14, 413);
            hopeRoundButtonLogout.Name = "hopeRoundButtonLogout";
            hopeRoundButtonLogout.PrimaryColor = Color.FromArgb(35, 47, 45);
            hopeRoundButtonLogout.Size = new Size(139, 40);
            hopeRoundButtonLogout.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButtonLogout.TabIndex = 11;
            hopeRoundButtonLogout.Text = "Logout";
            hopeRoundButtonLogout.TextColor = Color.White;
            hopeRoundButtonLogout.WarningColor = Color.FromArgb(230, 162, 60);
            hopeRoundButtonLogout.Click += hopeRoundButtonLogout_Click;
            // 
            // hopeRoundButtonHistoryBelanja
            // 
            hopeRoundButtonHistoryBelanja.BorderColor = Color.FromArgb(220, 223, 230);
            hopeRoundButtonHistoryBelanja.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButtonHistoryBelanja.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButtonHistoryBelanja.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButtonHistoryBelanja.Font = new Font("Segoe UI", 12F);
            hopeRoundButtonHistoryBelanja.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButtonHistoryBelanja.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButtonHistoryBelanja.Location = new Point(14, 214);
            hopeRoundButtonHistoryBelanja.Name = "hopeRoundButtonHistoryBelanja";
            hopeRoundButtonHistoryBelanja.PrimaryColor = Color.FromArgb(35, 47, 45);
            hopeRoundButtonHistoryBelanja.Size = new Size(139, 40);
            hopeRoundButtonHistoryBelanja.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButtonHistoryBelanja.TabIndex = 10;
            hopeRoundButtonHistoryBelanja.Text = "History Belanja";
            hopeRoundButtonHistoryBelanja.TextColor = Color.White;
            hopeRoundButtonHistoryBelanja.WarningColor = Color.FromArgb(230, 162, 60);
            hopeRoundButtonHistoryBelanja.Click += hopeRoundButtonHistoryBelanja_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Subheading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(57, 69, 60);
            label2.Location = new Point(76, 99);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 8;
            label2.Text = "Camp Store";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(57, 69, 60);
            label1.Location = new Point(75, 64);
            label1.Name = "label1";
            label1.Size = new Size(75, 35);
            label1.TabIndex = 7;
            label1.Text = "RylVa";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.LogoRylVaHitam;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-18, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 75);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // hopeRoundButtonInformasiPribadi
            // 
            hopeRoundButtonInformasiPribadi.BorderColor = Color.FromArgb(220, 223, 230);
            hopeRoundButtonInformasiPribadi.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButtonInformasiPribadi.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButtonInformasiPribadi.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButtonInformasiPribadi.Font = new Font("Segoe UI", 12F);
            hopeRoundButtonInformasiPribadi.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButtonInformasiPribadi.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButtonInformasiPribadi.Location = new Point(11, 155);
            hopeRoundButtonInformasiPribadi.Name = "hopeRoundButtonInformasiPribadi";
            hopeRoundButtonInformasiPribadi.PrimaryColor = Color.FromArgb(35, 47, 45);
            hopeRoundButtonInformasiPribadi.Size = new Size(139, 40);
            hopeRoundButtonInformasiPribadi.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButtonInformasiPribadi.TabIndex = 0;
            hopeRoundButtonInformasiPribadi.Text = "Informasi Pribadi";
            hopeRoundButtonInformasiPribadi.TextColor = Color.White;
            hopeRoundButtonInformasiPribadi.WarningColor = Color.FromArgb(230, 162, 60);
            hopeRoundButtonInformasiPribadi.Click += hopeRoundButtonInformasiPribadi_Click;
            // 
            // panelInfoPribadi
            // 
            panelInfoPribadi.Controls.Add(groupBox1);
            panelInfoPribadi.Controls.Add(hopeRoundButtonEditData);
            panelInfoPribadi.Controls.Add(textBoxSandi);
            panelInfoPribadi.Controls.Add(label4);
            panelInfoPribadi.Controls.Add(textBoxEmail);
            panelInfoPribadi.Controls.Add(label3);
            panelInfoPribadi.Controls.Add(labelUsername);
            panelInfoPribadi.Controls.Add(pictureBox1);
            panelInfoPribadi.Location = new Point(184, 12);
            panelInfoPribadi.Name = "panelInfoPribadi";
            panelInfoPribadi.Size = new Size(550, 461);
            panelInfoPribadi.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxSandiGanti);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(hopeRoundButtonUpdate);
            groupBox1.Controls.Add(textBoxTelepon);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxProvinsi);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxKota);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBoxAlamat);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxNamaLengkap);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(18, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 226);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Akun:";
            // 
            // textBoxSandiGanti
            // 
            textBoxSandiGanti.Location = new Point(139, 86);
            textBoxSandiGanti.Name = "textBoxSandiGanti";
            textBoxSandiGanti.PlaceholderText = "Sandi Penguna";
            textBoxSandiGanti.ReadOnly = true;
            textBoxSandiGanti.Size = new Size(166, 23);
            textBoxSandiGanti.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(88, 86);
            label10.Name = "label10";
            label10.Size = new Size(52, 21);
            label10.TabIndex = 23;
            label10.Text = "Sandi:";
            // 
            // hopeRoundButtonUpdate
            // 
            hopeRoundButtonUpdate.BorderColor = Color.FromArgb(220, 223, 230);
            hopeRoundButtonUpdate.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButtonUpdate.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButtonUpdate.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButtonUpdate.Enabled = false;
            hopeRoundButtonUpdate.Font = new Font("Segoe UI", 12F);
            hopeRoundButtonUpdate.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButtonUpdate.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButtonUpdate.Location = new Point(350, 167);
            hopeRoundButtonUpdate.Name = "hopeRoundButtonUpdate";
            hopeRoundButtonUpdate.PrimaryColor = Color.FromArgb(35, 47, 45);
            hopeRoundButtonUpdate.Size = new Size(141, 29);
            hopeRoundButtonUpdate.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButtonUpdate.TabIndex = 14;
            hopeRoundButtonUpdate.Text = "Update Data";
            hopeRoundButtonUpdate.TextColor = Color.White;
            hopeRoundButtonUpdate.WarningColor = Color.FromArgb(230, 162, 60);
            hopeRoundButtonUpdate.Click += hopeRoundButtonUpdate_Click;
            // 
            // textBoxTelepon
            // 
            textBoxTelepon.Location = new Point(139, 184);
            textBoxTelepon.Name = "textBoxTelepon";
            textBoxTelepon.PlaceholderText = "Nomor Telepon Penguna";
            textBoxTelepon.ReadOnly = true;
            textBoxTelepon.Size = new Size(166, 23);
            textBoxTelepon.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 186);
            label9.Name = "label9";
            label9.Size = new Size(120, 21);
            label9.TabIndex = 21;
            label9.Text = "Nomor Telepon:";
            // 
            // textBoxProvinsi
            // 
            textBoxProvinsi.Location = new Point(139, 151);
            textBoxProvinsi.Name = "textBoxProvinsi";
            textBoxProvinsi.PlaceholderText = "Provinsi Penguna";
            textBoxProvinsi.ReadOnly = true;
            textBoxProvinsi.Size = new Size(166, 23);
            textBoxProvinsi.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(71, 153);
            label8.Name = "label8";
            label8.Size = new Size(69, 21);
            label8.TabIndex = 19;
            label8.Text = "Provinsi:";
            // 
            // textBoxKota
            // 
            textBoxKota.Location = new Point(139, 115);
            textBoxKota.Name = "textBoxKota";
            textBoxKota.PlaceholderText = "Kota Penguna";
            textBoxKota.ReadOnly = true;
            textBoxKota.Size = new Size(166, 23);
            textBoxKota.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(92, 117);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 17;
            label7.Text = "Kota :";
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.Location = new Point(139, 51);
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.PlaceholderText = "Alamat Lengkap Penguna";
            textBoxAlamat.ReadOnly = true;
            textBoxAlamat.Size = new Size(166, 23);
            textBoxAlamat.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 48);
            label6.Name = "label6";
            label6.Size = new Size(125, 21);
            label6.TabIndex = 15;
            label6.Text = "Alamat Lengkap:";
            // 
            // textBoxNamaLengkap
            // 
            textBoxNamaLengkap.Location = new Point(139, 22);
            textBoxNamaLengkap.Name = "textBoxNamaLengkap";
            textBoxNamaLengkap.PlaceholderText = "Nama Lengkap Penguna";
            textBoxNamaLengkap.ReadOnly = true;
            textBoxNamaLengkap.Size = new Size(166, 23);
            textBoxNamaLengkap.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 19);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 14;
            label5.Text = "Nama Lengkap:";
            // 
            // hopeRoundButtonEditData
            // 
            hopeRoundButtonEditData.BorderColor = Color.FromArgb(220, 223, 230);
            hopeRoundButtonEditData.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButtonEditData.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButtonEditData.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButtonEditData.Font = new Font("Segoe UI", 12F);
            hopeRoundButtonEditData.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButtonEditData.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButtonEditData.Location = new Point(394, 178);
            hopeRoundButtonEditData.Name = "hopeRoundButtonEditData";
            hopeRoundButtonEditData.PrimaryColor = Color.FromArgb(35, 47, 45);
            hopeRoundButtonEditData.Size = new Size(115, 29);
            hopeRoundButtonEditData.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButtonEditData.TabIndex = 12;
            hopeRoundButtonEditData.Text = "Edit Data";
            hopeRoundButtonEditData.TextColor = Color.White;
            hopeRoundButtonEditData.WarningColor = Color.FromArgb(230, 162, 60);
            hopeRoundButtonEditData.Click += hopeRoundButtonEditData_Click;
            // 
            // textBoxSandi
            // 
            textBoxSandi.Location = new Point(343, 149);
            textBoxSandi.Name = "textBoxSandi";
            textBoxSandi.PasswordChar = '*';
            textBoxSandi.PlaceholderText = "Sandi Penguna";
            textBoxSandi.Size = new Size(166, 23);
            textBoxSandi.TabIndex = 6;
            textBoxSandi.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(294, 147);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 5;
            label4.Text = "Sandi:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(113, 150);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email Penguna";
            textBoxEmail.Size = new Size(166, 23);
            textBoxEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 149);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(237, 107);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(61, 25);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Alpha";
            // 
            // panelHistory
            // 
            panelHistory.Controls.Add(label19);
            panelHistory.Controls.Add(hopeRoundButtonCariStruk);
            panelHistory.Controls.Add(bigTextBoxCariStruk);
            panelHistory.Controls.Add(dataGridViewHistory);
            panelHistory.Controls.Add(label11);
            panelHistory.Location = new Point(184, 12);
            panelHistory.Name = "panelHistory";
            panelHistory.Size = new Size(550, 461);
            panelHistory.TabIndex = 14;
            panelHistory.Visible = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(37, 417);
            label19.Name = "label19";
            label19.Size = new Size(88, 21);
            label19.TabIndex = 23;
            label19.Text = "Cari Struck:";
            // 
            // hopeRoundButtonCariStruk
            // 
            hopeRoundButtonCariStruk.BorderColor = Color.FromArgb(220, 223, 230);
            hopeRoundButtonCariStruk.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButtonCariStruk.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButtonCariStruk.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButtonCariStruk.Font = new Font("Segoe UI", 12F);
            hopeRoundButtonCariStruk.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButtonCariStruk.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButtonCariStruk.Location = new Point(352, 406);
            hopeRoundButtonCariStruk.Name = "hopeRoundButtonCariStruk";
            hopeRoundButtonCariStruk.PrimaryColor = Color.FromArgb(138, 169, 137);
            hopeRoundButtonCariStruk.Size = new Size(164, 40);
            hopeRoundButtonCariStruk.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButtonCariStruk.TabIndex = 22;
            hopeRoundButtonCariStruk.Text = "Cari Struck";
            hopeRoundButtonCariStruk.TextColor = Color.White;
            hopeRoundButtonCariStruk.WarningColor = Color.FromArgb(230, 162, 60);
            hopeRoundButtonCariStruk.Click += hopeRoundButtonCariStruk_Click;
            // 
            // bigTextBoxCariStruk
            // 
            bigTextBoxCariStruk.BackColor = Color.Transparent;
            bigTextBoxCariStruk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigTextBoxCariStruk.ForeColor = Color.DimGray;
            bigTextBoxCariStruk.Image = null;
            bigTextBoxCariStruk.Location = new Point(131, 406);
            bigTextBoxCariStruk.MaxLength = 32767;
            bigTextBoxCariStruk.Multiline = false;
            bigTextBoxCariStruk.Name = "bigTextBoxCariStruk";
            bigTextBoxCariStruk.PlaceholderText = "Cari Struk";
            bigTextBoxCariStruk.ReadOnly = true;
            bigTextBoxCariStruk.Size = new Size(213, 45);
            bigTextBoxCariStruk.TabIndex = 21;
            bigTextBoxCariStruk.TextAlignment = HorizontalAlignment.Left;
            bigTextBoxCariStruk.UseSystemPasswordChar = false;
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.AllowUserToAddRows = false;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Columns.AddRange(new DataGridViewColumn[] { IDPesanan, Tanggal, NamaBarang, ModePilihan, Total, Status });
            dataGridViewHistory.Location = new Point(38, 70);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.ReadOnly = true;
            dataGridViewHistory.RowHeadersVisible = false;
            dataGridViewHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHistory.Size = new Size(476, 328);
            dataGridViewHistory.TabIndex = 1;
            dataGridViewHistory.CellClick += dataGridViewHistory_CellClick;
            // 
            // IDPesanan
            // 
            IDPesanan.HeaderText = "ID Pesanan";
            IDPesanan.Name = "IDPesanan";
            IDPesanan.ReadOnly = true;
            // 
            // Tanggal
            // 
            Tanggal.HeaderText = "Tanggal Pesanan";
            Tanggal.Name = "Tanggal";
            Tanggal.ReadOnly = true;
            // 
            // NamaBarang
            // 
            NamaBarang.HeaderText = "NamaBarang";
            NamaBarang.Name = "NamaBarang";
            NamaBarang.ReadOnly = true;
            NamaBarang.Width = 150;
            // 
            // ModePilihan
            // 
            ModePilihan.HeaderText = "Mode Belanja";
            ModePilihan.Name = "ModePilihan";
            ModePilihan.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(23, 33);
            label11.Name = "label11";
            label11.Size = new Size(135, 25);
            label11.TabIndex = 0;
            label11.Text = "Pesanan Anda:";
            // 
            // FormAccountSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 485);
            Controls.Add(panelHistory);
            Controls.Add(panelInfoPribadi);
            Controls.Add(panel1);
            Name = "FormAccountSetting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAccountSetting";
            Load += FormAccountSetting_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelInfoPribadi.ResumeLayout(false);
            panelInfoPribadi.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelHistory.ResumeLayout(false);
            panelHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButtonInformasiPribadi;
        private Label label2;
        private Label label1;
        private Panel panelInfoPribadi;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButtonLogout;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButtonHistoryBelanja;
        private Label labelUsername;
        private TextBox textBoxSandi;
        private Label label4;
        private TextBox textBoxEmail;
        private Label label3;
        private GroupBox groupBox1;
        private Label label5;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButtonEditData;
        private TextBox textBoxNamaLengkap;
        private Label label6;
        private Label label7;
        private TextBox textBoxAlamat;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButtonUpdate;
        private TextBox textBoxTelepon;
        private Label label9;
        private TextBox textBoxProvinsi;
        private Label label8;
        private TextBox textBoxKota;
        private TextBox textBoxSandiGanti;
        private Label label10;
        private Panel panelHistory;
        private DataGridView dataGridViewHistory;
        private Label label11;
        private DataGridViewTextBoxColumn IDPesanan;
        private DataGridViewTextBoxColumn Tanggal;
        private DataGridViewTextBoxColumn NamaBarang;
        private DataGridViewTextBoxColumn ModePilihan;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Status;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButtonBack;
        private Label label19;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButtonCariStruk;
        private ReaLTaiizor.Controls.BigTextBox bigTextBoxCariStruk;
    }
}