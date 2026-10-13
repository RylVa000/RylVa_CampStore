namespace XRPLC_07_BerrylZelva_TA
{
    partial class FormBeli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBeli));
            groupBox1 = new GroupBox();
            pictureBoxKeranjang = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonSearch = new Button();
            textBoxCariBarang = new TextBox();
            groupBox2 = new GroupBox();
            radioButtonPenerangan = new RadioButton();
            radioButtonPakaian = new RadioButton();
            radioButtonAksesoris = new RadioButton();
            radioButtonAlatTidur = new RadioButton();
            labelSetAccount = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            radioAlatMasak = new RadioButton();
            radioTas = new RadioButton();
            radioTenda = new RadioButton();
            radioSemua = new RadioButton();
            label1 = new Label();
            flowLayoutPanelKatalog = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKeranjang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(35, 47, 45);
            groupBox1.Controls.Add(pictureBoxKeranjang);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(textBoxCariBarang);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 66);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pictureBoxKeranjang
            // 
            pictureBoxKeranjang.BackgroundImage = Properties.Resources.LogoKeranjang;
            pictureBoxKeranjang.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxKeranjang.Location = new Point(579, 10);
            pictureBoxKeranjang.Name = "pictureBoxKeranjang";
            pictureBoxKeranjang.Size = new Size(64, 44);
            pictureBoxKeranjang.TabIndex = 4;
            pictureBoxKeranjang.TabStop = false;
            pictureBoxKeranjang.Click += pictureBoxKeranjang_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(130, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 50);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(39, 78, 45);
            buttonSearch.BackgroundImageLayout = ImageLayout.None;
            buttonSearch.ForeColor = SystemColors.ButtonHighlight;
            buttonSearch.Location = new Point(472, 22);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(80, 23);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxCariBarang
            // 
            textBoxCariBarang.Location = new Point(230, 22);
            textBoxCariBarang.Name = "textBoxCariBarang";
            textBoxCariBarang.PlaceholderText = "Cari Barang";
            textBoxCariBarang.Size = new Size(222, 23);
            textBoxCariBarang.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(138, 169, 137);
            groupBox2.Controls.Add(radioButtonPenerangan);
            groupBox2.Controls.Add(radioButtonPakaian);
            groupBox2.Controls.Add(radioButtonAksesoris);
            groupBox2.Controls.Add(radioButtonAlatTidur);
            groupBox2.Controls.Add(labelSetAccount);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(radioAlatMasak);
            groupBox2.Controls.Add(radioTas);
            groupBox2.Controls.Add(radioTenda);
            groupBox2.Controls.Add(radioSemua);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(11, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(148, 364);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // radioButtonPenerangan
            // 
            radioButtonPenerangan.AutoSize = true;
            radioButtonPenerangan.Location = new Point(12, 227);
            radioButtonPenerangan.Name = "radioButtonPenerangan";
            radioButtonPenerangan.Size = new Size(88, 19);
            radioButtonPenerangan.TabIndex = 15;
            radioButtonPenerangan.TabStop = true;
            radioButtonPenerangan.Text = "Penerangan";
            radioButtonPenerangan.UseVisualStyleBackColor = true;
            // 
            // radioButtonPakaian
            // 
            radioButtonPakaian.AutoSize = true;
            radioButtonPakaian.Location = new Point(12, 202);
            radioButtonPakaian.Name = "radioButtonPakaian";
            radioButtonPakaian.Size = new Size(66, 19);
            radioButtonPakaian.TabIndex = 14;
            radioButtonPakaian.TabStop = true;
            radioButtonPakaian.Text = "Pakaian";
            radioButtonPakaian.UseVisualStyleBackColor = true;
            // 
            // radioButtonAksesoris
            // 
            radioButtonAksesoris.AutoSize = true;
            radioButtonAksesoris.Location = new Point(12, 177);
            radioButtonAksesoris.Name = "radioButtonAksesoris";
            radioButtonAksesoris.Size = new Size(74, 19);
            radioButtonAksesoris.TabIndex = 13;
            radioButtonAksesoris.TabStop = true;
            radioButtonAksesoris.Text = "Aksesoris";
            radioButtonAksesoris.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlatTidur
            // 
            radioButtonAlatTidur.AutoSize = true;
            radioButtonAlatTidur.Location = new Point(12, 152);
            radioButtonAlatTidur.Name = "radioButtonAlatTidur";
            radioButtonAlatTidur.Size = new Size(76, 19);
            radioButtonAlatTidur.TabIndex = 12;
            radioButtonAlatTidur.TabStop = true;
            radioButtonAlatTidur.Text = "Alat Tidur";
            radioButtonAlatTidur.UseVisualStyleBackColor = true;
            // 
            // labelSetAccount
            // 
            labelSetAccount.AutoEllipsis = true;
            labelSetAccount.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelSetAccount.Location = new Point(50, 319);
            labelSetAccount.Name = "labelSetAccount";
            labelSetAccount.Size = new Size(83, 25);
            labelSetAccount.TabIndex = 7;
            labelSetAccount.Text = "Akun";
            labelSetAccount.Click += labelSetAccount_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LogoAkun;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-9, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 67);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(964, 111);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // radioAlatMasak
            // 
            radioAlatMasak.AutoSize = true;
            radioAlatMasak.Location = new Point(12, 127);
            radioAlatMasak.Name = "radioAlatMasak";
            radioAlatMasak.Size = new Size(83, 19);
            radioAlatMasak.TabIndex = 4;
            radioAlatMasak.TabStop = true;
            radioAlatMasak.Text = "Alat Masak";
            radioAlatMasak.UseVisualStyleBackColor = true;
            // 
            // radioTas
            // 
            radioTas.AutoSize = true;
            radioTas.Location = new Point(12, 102);
            radioTas.Name = "radioTas";
            radioTas.Size = new Size(81, 19);
            radioTas.TabIndex = 3;
            radioTas.TabStop = true;
            radioTas.Text = "Tas Kemah";
            radioTas.UseVisualStyleBackColor = true;
            // 
            // radioTenda
            // 
            radioTenda.AutoSize = true;
            radioTenda.Location = new Point(12, 77);
            radioTenda.Name = "radioTenda";
            radioTenda.Size = new Size(56, 19);
            radioTenda.TabIndex = 2;
            radioTenda.TabStop = true;
            radioTenda.Text = "Tenda";
            radioTenda.UseVisualStyleBackColor = true;
            // 
            // radioSemua
            // 
            radioSemua.AutoSize = true;
            radioSemua.Location = new Point(12, 52);
            radioSemua.Name = "radioSemua";
            radioSemua.Size = new Size(61, 19);
            radioSemua.TabIndex = 1;
            radioSemua.TabStop = true;
            radioSemua.Text = "Semua";
            radioSemua.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Filter Kategori";
            // 
            // flowLayoutPanelKatalog
            // 
            flowLayoutPanelKatalog.AutoScroll = true;
            flowLayoutPanelKatalog.Location = new Point(178, 81);
            flowLayoutPanelKatalog.Name = "flowLayoutPanelKatalog";
            flowLayoutPanelKatalog.Size = new Size(610, 357);
            flowLayoutPanelKatalog.TabIndex = 2;
            // 
            // FormBeli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 250, 234);
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelKatalog);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormBeli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Katalog - RylVa Camp Store";
            Load += FormBeli_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKeranjang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxCariBarang;
        private Button buttonSearch;
        private GroupBox groupBox2;
        private RadioButton radioAlatMasak;
        private RadioButton radioTas;
        private RadioButton radioTenda;
        private RadioButton radioSemua;
        private Label label1;
        private Label labelSetAccount;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanelKatalog;
        private PictureBox pictureBoxKeranjang;
        private RadioButton radioButtonPenerangan;
        private RadioButton radioButtonPakaian;
        private RadioButton radioButtonAksesoris;
        private RadioButton radioButtonAlatTidur;
    }
}