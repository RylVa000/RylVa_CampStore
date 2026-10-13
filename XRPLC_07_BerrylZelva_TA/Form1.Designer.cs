namespace XRPLC_07_BerrylZelva_TA
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelRegister = new Label();
            textBoxUsername = new TextBox();
            label4 = new Label();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            pictureBoxMata = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMata).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LogoRylVaHitam;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(107, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 72);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(57, 69, 60);
            label1.Location = new Point(195, 64);
            label1.Name = "label1";
            label1.Size = new Size(75, 35);
            label1.TabIndex = 1;
            label1.Text = "RylVa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Subheading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(57, 69, 60);
            label2.Location = new Point(195, 98);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 2;
            label2.Text = "Camp Store";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 156);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Font = new Font("Sitka Display", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelRegister.ForeColor = Color.FromArgb(37, 79, 44);
            labelRegister.Location = new Point(136, 358);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(145, 23);
            labelRegister.TabIndex = 5;
            labelRegister.Text = "Created New Account";
            labelRegister.Click += labelRegister_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(66, 182);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Enter Username";
            textBoxUsername.Size = new Size(285, 23);
            textBoxUsername.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 228);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(66, 254);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Enter Password";
            textBoxPassword.Size = new Size(285, 23);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(37, 79, 44);
            buttonLogin.ForeColor = SystemColors.ButtonHighlight;
            buttonLogin.Location = new Point(66, 304);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(285, 40);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // pictureBoxMata
            // 
            pictureBoxMata.BackgroundImage = (Image)resources.GetObject("pictureBoxMata.BackgroundImage");
            pictureBoxMata.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxMata.Location = new Point(357, 254);
            pictureBoxMata.Name = "pictureBoxMata";
            pictureBoxMata.Size = new Size(30, 23);
            pictureBoxMata.TabIndex = 10;
            pictureBoxMata.TabStop = false;
            pictureBoxMata.Click += pictureBoxMata_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 230);
            ClientSize = new Size(432, 424);
            Controls.Add(pictureBoxMata);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(label4);
            Controls.Add(textBoxUsername);
            Controls.Add(labelRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - RylVa Camp Store";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelRegister;
        private TextBox textBoxUsername;
        private Label label4;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private PictureBox pictureBoxMata;
    }
}
