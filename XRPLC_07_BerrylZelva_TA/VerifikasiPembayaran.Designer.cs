namespace XRPLC_07_BerrylZelva_TA
{
    partial class VerifikasiPembayaran
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
            components = new System.ComponentModel.Container();
            timerPembayaran = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            labelMetode = new Label();
            labelWaktu = new Label();
            panelQris = new Panel();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panelBank = new Panel();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            labelTagihan = new Label();
            panel3 = new Panel();
            buttonBatal = new Button();
            buttonSudahBayar = new Button();
            label10 = new Label();
            label11 = new Label();
            labelAlamat = new Label();
            pictureBox4 = new PictureBox();
            panelCOD = new Panel();
            comboBoxBulan = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            labeltotalBungga = new Label();
            label15 = new Label();
            labelcicilanperbulan = new Label();
            panelKredit = new Panel();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            buttonBackMenu = new Button();
            buttonCheckDetail = new Button();
            panelSukses = new Panel();
            printDocumentCetak = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelQris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelCOD.SuspendLayout();
            panelKredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panelSukses.SuspendLayout();
            SuspendLayout();
            // 
            // timerPembayaran
            // 
            timerPembayaran.Tick += timerPembayaran_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(126, 156, 128);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 101);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(183, 39);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 0;
            label1.Text = "RylVa Camp Store";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LogoRylVaHitam;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(108, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 85);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 120);
            label2.Name = "label2";
            label2.Size = new Size(272, 21);
            label2.TabIndex = 1;
            label2.Text = "Harap Lakukan Pembayaran Sebelum:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 154);
            label3.Name = "label3";
            label3.Size = new Size(201, 25);
            label3.TabIndex = 2;
            label3.Text = "Intruksi Pembayaran -";
            // 
            // labelMetode
            // 
            labelMetode.AutoSize = true;
            labelMetode.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMetode.Location = new Point(214, 154);
            labelMetode.Name = "labelMetode";
            labelMetode.Size = new Size(79, 25);
            labelMetode.TabIndex = 3;
            labelMetode.Text = "Metode";
            // 
            // labelWaktu
            // 
            labelWaktu.AutoSize = true;
            labelWaktu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWaktu.ForeColor = Color.LightCoral;
            labelWaktu.Location = new Point(368, 120);
            labelWaktu.Name = "labelWaktu";
            labelWaktu.Size = new Size(91, 21);
            labelWaktu.TabIndex = 4;
            labelWaktu.Text = "Countdown";
            // 
            // panelQris
            // 
            panelQris.Controls.Add(label5);
            panelQris.Controls.Add(pictureBox2);
            panelQris.Location = new Point(26, 243);
            panelQris.Name = "panelQris";
            panelQris.Size = new Size(410, 287);
            panelQris.TabIndex = 5;
            panelQris.Visible = false;
            panelQris.Paint += panelQris_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(76, 228);
            label5.Name = "label5";
            label5.Size = new Size(260, 50);
            label5.TabIndex = 2;
            label5.Text = "Silahkan scan barcode di atas\r\nmengunakan e-wallet (Dana)";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.QRDana;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(102, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(205, 195);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panelBank
            // 
            panelBank.Controls.Add(pictureBox3);
            panelBank.Controls.Add(button3);
            panelBank.Controls.Add(label9);
            panelBank.Controls.Add(label8);
            panelBank.Controls.Add(label7);
            panelBank.Controls.Add(label6);
            panelBank.Location = new Point(26, 243);
            panelBank.Name = "panelBank";
            panelBank.Size = new Size(410, 287);
            panelBank.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.LogoBCA;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(318, 244);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 34);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(273, 144);
            button3.Name = "button3";
            button3.Size = new Size(90, 23);
            button3.TabIndex = 4;
            button3.Text = "Salin Nomor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(102, 183);
            label9.Name = "label9";
            label9.Size = new Size(188, 25);
            label9.TabIndex = 3;
            label9.Text = "a/n Berryl Zelva C.AR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(80, 142);
            label8.Name = "label8";
            label8.Size = new Size(187, 25);
            label8.TabIndex = 2;
            label8.Text = "No.Rekening: 210210";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(168, 106);
            label7.Name = "label7";
            label7.Size = new Size(99, 25);
            label7.TabIndex = 1;
            label7.Text = "Bank BCA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 13);
            label6.Name = "label6";
            label6.Size = new Size(274, 42);
            label6.TabIndex = 0;
            label6.Text = "Silahkan transfer tepat sesuai nominal\r\n                ke rekening berikut ini:\r\n";
            // 
            // labelTagihan
            // 
            labelTagihan.AutoSize = true;
            labelTagihan.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTagihan.Location = new Point(119, 205);
            labelTagihan.Name = "labelTagihan";
            labelTagihan.Size = new Size(197, 25);
            labelTagihan.TabIndex = 0;
            labelTagihan.Text = "Total Tagihan: RP num";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(126, 156, 128);
            panel3.Location = new Point(-6, 610);
            panel3.Name = "panel3";
            panel3.Size = new Size(497, 72);
            panel3.TabIndex = 6;
            // 
            // buttonBatal
            // 
            buttonBatal.BackColor = Color.Red;
            buttonBatal.ForeColor = SystemColors.ButtonHighlight;
            buttonBatal.Location = new Point(12, 568);
            buttonBatal.Name = "buttonBatal";
            buttonBatal.Size = new Size(122, 36);
            buttonBatal.TabIndex = 7;
            buttonBatal.Text = "Batalkan Pesanan";
            buttonBatal.UseVisualStyleBackColor = false;
            buttonBatal.Click += buttonBatal_Click;
            // 
            // buttonSudahBayar
            // 
            buttonSudahBayar.BackColor = Color.FromArgb(132, 89, 48);
            buttonSudahBayar.ForeColor = SystemColors.ButtonHighlight;
            buttonSudahBayar.Location = new Point(322, 566);
            buttonSudahBayar.Name = "buttonSudahBayar";
            buttonSudahBayar.Size = new Size(149, 38);
            buttonSudahBayar.TabIndex = 8;
            buttonSudahBayar.Text = "Sudah Bayar";
            buttonSudahBayar.UseVisualStyleBackColor = false;
            buttonSudahBayar.Click += buttonSudahBayar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(27, 43);
            label10.Name = "label10";
            label10.Size = new Size(369, 42);
            label10.TabIndex = 0;
            label10.Text = "Pesanan Anda sedang diproses. Harap siapkan uang\r\n     tunai pas saat kurir kami tiba di alamat Anda:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(114, 131);
            label11.Name = "label11";
            label11.Size = new Size(176, 25);
            label11.TabIndex = 1;
            label11.Text = "Alamat Pengiriman:";
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAlamat.Location = new Point(99, 167);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(97, 25);
            labelAlamat.TabIndex = 2;
            labelAlamat.Text = "Ini Alamat";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.LogoTruk;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(318, 228);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(78, 50);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panelCOD
            // 
            panelCOD.Controls.Add(pictureBox4);
            panelCOD.Controls.Add(labelAlamat);
            panelCOD.Controls.Add(label11);
            panelCOD.Controls.Add(label10);
            panelCOD.Location = new Point(26, 243);
            panelCOD.Name = "panelCOD";
            panelCOD.Size = new Size(410, 287);
            panelCOD.TabIndex = 6;
            panelCOD.Visible = false;
            // 
            // comboBoxBulan
            // 
            comboBoxBulan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBulan.FormattingEnabled = true;
            comboBoxBulan.Items.AddRange(new object[] { "3 Bulan", "6 Bulan", "12 Bulan" });
            comboBoxBulan.Location = new Point(143, 58);
            comboBoxBulan.Name = "comboBoxBulan";
            comboBoxBulan.Size = new Size(121, 23);
            comboBoxBulan.TabIndex = 0;
            comboBoxBulan.SelectedIndexChanged += comboBoxBulan_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(24, 23);
            label12.Name = "label12";
            label12.Size = new Size(369, 20);
            label12.TabIndex = 1;
            label12.Text = "Silahkan pilih skema cicilan kredit yang Anda inginkan:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(165, 106);
            label13.Name = "label13";
            label13.Size = new Size(96, 21);
            label13.TabIndex = 2;
            label13.Text = "Bunga 2.5 %";
            // 
            // labeltotalBungga
            // 
            labeltotalBungga.AutoSize = true;
            labeltotalBungga.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltotalBungga.Location = new Point(99, 131);
            labeltotalBungga.Name = "labeltotalBungga";
            labeltotalBungga.Size = new Size(234, 25);
            labeltotalBungga.TabIndex = 3;
            labeltotalBungga.Text = "Total setelah bungga: num";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(127, 183);
            label15.Name = "label15";
            label15.Size = new Size(160, 25);
            label15.TabIndex = 4;
            label15.Text = "Cicilan Perbulan:";
            // 
            // labelcicilanperbulan
            // 
            labelcicilanperbulan.AutoSize = true;
            labelcicilanperbulan.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcicilanperbulan.Location = new Point(143, 211);
            labelcicilanperbulan.Name = "labelcicilanperbulan";
            labelcicilanperbulan.Size = new Size(85, 25);
            labelcicilanperbulan.TabIndex = 5;
            labelcicilanperbulan.Text = "Rp Num";
            // 
            // panelKredit
            // 
            panelKredit.Controls.Add(labelcicilanperbulan);
            panelKredit.Controls.Add(label15);
            panelKredit.Controls.Add(labeltotalBungga);
            panelKredit.Controls.Add(label13);
            panelKredit.Controls.Add(label12);
            panelKredit.Controls.Add(comboBoxBulan);
            panelKredit.Location = new Point(26, 243);
            panelKredit.Name = "panelKredit";
            panelKredit.Size = new Size(407, 287);
            panelKredit.TabIndex = 4;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Image = Properties.Resources.PaymentGif;
            pictureBox5.Location = new Point(32, 22);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(407, 279);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(131, 328);
            label4.Name = "label4";
            label4.Size = new Size(214, 25);
            label4.TabIndex = 1;
            label4.Text = "Pembayaran Berhasil!!!";
            // 
            // buttonBackMenu
            // 
            buttonBackMenu.BackColor = Color.FromArgb(126, 156, 128);
            buttonBackMenu.ForeColor = SystemColors.ControlLightLight;
            buttonBackMenu.Location = new Point(35, 411);
            buttonBackMenu.Name = "buttonBackMenu";
            buttonBackMenu.Size = new Size(166, 42);
            buttonBackMenu.TabIndex = 2;
            buttonBackMenu.Text = "Back To Menu";
            buttonBackMenu.UseVisualStyleBackColor = false;
            buttonBackMenu.Click += buttonBackMenu_Click;
            // 
            // buttonCheckDetail
            // 
            buttonCheckDetail.BackColor = Color.FromArgb(126, 156, 128);
            buttonCheckDetail.ForeColor = SystemColors.ControlLightLight;
            buttonCheckDetail.Location = new Point(283, 411);
            buttonCheckDetail.Name = "buttonCheckDetail";
            buttonCheckDetail.Size = new Size(166, 42);
            buttonCheckDetail.TabIndex = 3;
            buttonCheckDetail.Text = "Check Detail";
            buttonCheckDetail.UseVisualStyleBackColor = false;
            buttonCheckDetail.Click += buttonCheckDetail_Click;
            // 
            // panelSukses
            // 
            panelSukses.Controls.Add(buttonCheckDetail);
            panelSukses.Controls.Add(buttonBackMenu);
            panelSukses.Controls.Add(label4);
            panelSukses.Controls.Add(pictureBox5);
            panelSukses.Location = new Point(-3, 98);
            panelSukses.Name = "panelSukses";
            panelSukses.Size = new Size(486, 515);
            panelSukses.TabIndex = 6;
            panelSukses.Visible = false;
            // 
            // printDocumentCetak
            // 
            printDocumentCetak.PrintPage += printDocumentCetak_PrintPage;
            // 
            // VerifikasiPembayaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 237, 219);
            ClientSize = new Size(490, 637);
            Controls.Add(panelSukses);
            Controls.Add(panelBank);
            Controls.Add(buttonSudahBayar);
            Controls.Add(buttonBatal);
            Controls.Add(panel3);
            Controls.Add(labelTagihan);
            Controls.Add(panelQris);
            Controls.Add(labelWaktu);
            Controls.Add(labelMetode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panelKredit);
            Controls.Add(panelCOD);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "VerifikasiPembayaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerifikasiPembayaran";
            Load += VerifikasiPembayaran_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelQris.ResumeLayout(false);
            panelQris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelBank.ResumeLayout(false);
            panelBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelCOD.ResumeLayout(false);
            panelCOD.PerformLayout();
            panelKredit.ResumeLayout(false);
            panelKredit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panelSukses.ResumeLayout(false);
            panelSukses.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerPembayaran;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label labelMetode;
        private Label labelWaktu;
        private Panel panelQris;
        private Panel panel3;
        private Label labelTagihan;
        private PictureBox pictureBox2;
        private Label label5;
        private Button buttonBatal;
        private Button buttonSudahBayar;
        private Panel panelBank;
        private Label label7;
        private Label label6;
        private Button button3;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label10;
        private Label label11;
        private Label labelAlamat;
        private PictureBox pictureBox4;
        private Panel panelCOD;
        private ComboBox comboBoxBulan;
        private Label label12;
        private Label label13;
        private Label labeltotalBungga;
        private Label label15;
        private Label labelcicilanperbulan;
        private Panel panelKredit;
        private PictureBox pictureBox5;
        private Label label4;
        private Button buttonBackMenu;
        private Button buttonCheckDetail;
        private Panel panelSukses;
        private System.Drawing.Printing.PrintDocument printDocumentCetak;
    }
}