namespace D_232410101047_utspbo
{
    partial class WelcomePage
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
            label1 = new Label();
            btnHalBuku = new Button();
            btnRegistrasi = new Button();
            btnLogin = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(149, 44);
            label1.Name = "label1";
            label1.Size = new Size(490, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Library Management App";
            // 
            // btnHalBuku
            // 
            btnHalBuku.Location = new Point(306, 134);
            btnHalBuku.Name = "btnHalBuku";
            btnHalBuku.Size = new Size(167, 57);
            btnHalBuku.TabIndex = 1;
            btnHalBuku.Text = "Halaman Buku";
            btnHalBuku.UseVisualStyleBackColor = true;
            btnHalBuku.Click += BtnHalBuku_Click;
            // 
            // btnRegistrasi
            // 
            btnRegistrasi.Location = new Point(306, 212);
            btnRegistrasi.Name = "btnRegistrasi";
            btnRegistrasi.Size = new Size(167, 60);
            btnRegistrasi.TabIndex = 2;
            btnRegistrasi.Text = "Registrasi";
            btnRegistrasi.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(306, 293);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(167, 54);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 96);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 4;
            label2.Text = "Choose Action:";
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 365);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(btnRegistrasi);
            Controls.Add(btnHalBuku);
            Controls.Add(label1);
            Name = "WelcomePage";
            Text = "Welcome Page";
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnHalBuku_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Button btnHalBuku;
        private Button btnRegistrasi;
        private Button btnLogin;
        private Label label2;
    }
}
