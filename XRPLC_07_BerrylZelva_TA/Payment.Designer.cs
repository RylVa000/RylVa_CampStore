namespace XRPLC_07_BerrylZelva_TA
{
    partial class Payment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewKeranjang = new DataGridView();
            Nama = new DataGridViewTextBoxColumn();
            hargaSatuan = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            LamaSewa = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            buttonHapus = new Button();
            label2 = new Label();
            label1 = new Label();
            buttonBack = new Button();
            labelTotalPayment = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            radioButtonQris = new RadioButton();
            radioButtonCOD = new RadioButton();
            radioButtonKredit = new RadioButton();
            radioButtonBank = new RadioButton();
            groupBox5 = new GroupBox();
            button1 = new Button();
            labelAlamat = new Label();
            labelEmail = new Label();
            labelNomorTelepon = new Label();
            labelNamaPenerima = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKeranjang).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewKeranjang
            // 
            dataGridViewKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKeranjang.Columns.AddRange(new DataGridViewColumn[] { Nama, hargaSatuan, Qty, LamaSewa, SubTotal });
            dataGridViewKeranjang.Location = new Point(22, 30);
            dataGridViewKeranjang.Name = "dataGridViewKeranjang";
            dataGridViewKeranjang.Size = new Size(497, 326);
            dataGridViewKeranjang.TabIndex = 0;
            // 
            // Nama
            // 
            Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama.DataPropertyName = "Nama";
            dataGridViewCellStyle1.Format = "lamaSewa";
            Nama.DefaultCellStyle = dataGridViewCellStyle1;
            Nama.HeaderText = "Name Produk";
            Nama.Name = "Nama";
            // 
            // hargaSatuan
            // 
            hargaSatuan.DataPropertyName = "hargaSatuan";
            dataGridViewCellStyle2.Format = "N0";
            hargaSatuan.DefaultCellStyle = dataGridViewCellStyle2;
            hargaSatuan.HeaderText = "Harga Produk";
            hargaSatuan.Name = "hargaSatuan";
            hargaSatuan.Width = 120;
            // 
            // Qty
            // 
            Qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Qty.DataPropertyName = "qty";
            Qty.HeaderText = "Qty";
            Qty.Name = "Qty";
            Qty.Width = 60;
            // 
            // LamaSewa
            // 
            LamaSewa.DataPropertyName = "lamaSewa";
            LamaSewa.HeaderText = "Lama Sewa (Hari)";
            LamaSewa.Name = "LamaSewa";
            LamaSewa.Width = 90;
            // 
            // SubTotal
            // 
            SubTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SubTotal.DataPropertyName = "subtotal";
            dataGridViewCellStyle3.Format = "N0";
            SubTotal.DefaultCellStyle = dataGridViewCellStyle3;
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(211, 221, 197);
            groupBox1.Controls.Add(buttonHapus);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonBack);
            groupBox1.Controls.Add(labelTotalPayment);
            groupBox1.Controls.Add(dataGridViewKeranjang);
            groupBox1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 443);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ringkasan Pesanan";
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.Red;
            buttonHapus.ForeColor = SystemColors.ButtonHighlight;
            buttonHapus.Location = new Point(411, 362);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(108, 30);
            buttonHapus.TabIndex = 8;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = false;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(395, 403);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Klik Disini";
            label2.Click += labelAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 403);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 2;
            label1.Text = "Ada Data Akun Yang Salah?";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(126, 93, 61);
            buttonBack.ForeColor = SystemColors.ButtonHighlight;
            buttonBack.Location = new Point(31, 397);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(158, 31);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelTotalPayment
            // 
            labelTotalPayment.AutoSize = true;
            labelTotalPayment.Location = new Point(22, 361);
            labelTotalPayment.Name = "labelTotalPayment";
            labelTotalPayment.Size = new Size(109, 22);
            labelTotalPayment.TabIndex = 0;
            labelTotalPayment.Text = "Total Payment";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(1, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 20);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(232, 228, 201);
            groupBox3.Location = new Point(1, -13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(993, 35);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(210, 222, 198);
            groupBox4.Controls.Add(pictureBox4);
            groupBox4.Controls.Add(pictureBox3);
            groupBox4.Controls.Add(pictureBox2);
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Controls.Add(radioButtonQris);
            groupBox4.Controls.Add(radioButtonCOD);
            groupBox4.Controls.Add(radioButtonKredit);
            groupBox4.Controls.Add(radioButtonBank);
            groupBox4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(585, 32);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(361, 154);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Metode Pembayaran";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.LogoQR;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(77, 126);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 21);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.LogoUang;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(170, 94);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 21);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.LogoKredit;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(95, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 21);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LogoBank;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(143, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 21);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // radioButtonQris
            // 
            radioButtonQris.AutoSize = true;
            radioButtonQris.Location = new Point(27, 121);
            radioButtonQris.Name = "radioButtonQris";
            radioButtonQris.Size = new Size(56, 26);
            radioButtonQris.TabIndex = 3;
            radioButtonQris.TabStop = true;
            radioButtonQris.Text = "Qris";
            radioButtonQris.UseVisualStyleBackColor = true;
            // 
            // radioButtonCOD
            // 
            radioButtonCOD.AutoSize = true;
            radioButtonCOD.Location = new Point(27, 89);
            radioButtonCOD.Name = "radioButtonCOD";
            radioButtonCOD.Size = new Size(150, 26);
            radioButtonCOD.TabIndex = 2;
            radioButtonCOD.TabStop = true;
            radioButtonCOD.Text = "Cash On Delivery";
            radioButtonCOD.UseVisualStyleBackColor = true;
            // 
            // radioButtonKredit
            // 
            radioButtonKredit.AutoSize = true;
            radioButtonKredit.Location = new Point(27, 57);
            radioButtonKredit.Name = "radioButtonKredit";
            radioButtonKredit.Size = new Size(72, 26);
            radioButtonKredit.TabIndex = 1;
            radioButtonKredit.TabStop = true;
            radioButtonKredit.Text = "Kredit";
            radioButtonKredit.UseVisualStyleBackColor = true;
            // 
            // radioButtonBank
            // 
            radioButtonBank.AutoSize = true;
            radioButtonBank.Location = new Point(27, 25);
            radioButtonBank.Name = "radioButtonBank";
            radioButtonBank.Size = new Size(122, 26);
            radioButtonBank.TabIndex = 0;
            radioButtonBank.TabStop = true;
            radioButtonBank.Text = "Bank Transfer";
            radioButtonBank.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(210, 222, 198);
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(labelAlamat);
            groupBox5.Controls.Add(labelEmail);
            groupBox5.Controls.Add(labelNomorTelepon);
            groupBox5.Controls.Add(labelNamaPenerima);
            groupBox5.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(585, 221);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(356, 254);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Informasi Penguna";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(126, 93, 61);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(14, 208);
            button1.Name = "button1";
            button1.Size = new Size(328, 31);
            button1.TabIndex = 2;
            button1.Text = "Confirm and Pay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonPay_Click;
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Location = new Point(19, 137);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(64, 22);
            labelAlamat.TabIndex = 7;
            labelAlamat.Text = "Alamat:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(19, 96);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(55, 22);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email:";
            // 
            // labelNomorTelepon
            // 
            labelNomorTelepon.AutoSize = true;
            labelNomorTelepon.Location = new Point(16, 61);
            labelNomorTelepon.Name = "labelNomorTelepon";
            labelNomorTelepon.Size = new Size(123, 22);
            labelNomorTelepon.TabIndex = 5;
            labelNomorTelepon.Text = "Nomor Telepon:";
            // 
            // labelNamaPenerima
            // 
            labelNamaPenerima.AutoSize = true;
            labelNamaPenerima.Location = new Point(16, 30);
            labelNamaPenerima.Name = "labelNamaPenerima";
            labelNamaPenerima.Size = new Size(82, 22);
            labelNamaPenerima.TabIndex = 4;
            labelNamaPenerima.Text = "Penerima:";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 245, 230);
            ClientSize = new Size(959, 502);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewKeranjang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewKeranjang;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private RadioButton radioButtonCOD;
        private RadioButton radioButtonKredit;
        private RadioButton radioButtonBank;
        private GroupBox groupBox5;
        private Button buttonBack;
        private Label labelTotalPayment;
        private RadioButton radioButtonQris;
        private Label labelNomorTelepon;
        private Label labelNamaPenerima;
        private Button button1;
        private Label label1;
        private Label labelAlamat;
        private Label labelEmail;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button buttonHapus;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn hargaSatuan;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn LamaSewa;
        private DataGridViewTextBoxColumn SubTotal;
    }
}