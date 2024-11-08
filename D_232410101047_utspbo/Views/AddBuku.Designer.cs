namespace D_232410101047_utspbo.Views
{
    partial class AddBuku
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbJudul = new TextBox();
            tbPengarang = new TextBox();
            tbTahunTerbit = new TextBox();
            tbKategori = new TextBox();
            btnSimpanBuku = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(273, 63);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 0;
            label1.Text = "Tambah Buku Baru";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 126);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 1;
            label2.Text = "Judul";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 171);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 2;
            label3.Text = "Pengarang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 223);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 3;
            label4.Text = "Tahun Terbit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 276);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 4;
            label5.Text = "Kategori";
            // 
            // tbJudul
            // 
            tbJudul.Location = new Point(226, 124);
            tbJudul.Name = "tbJudul";
            tbJudul.Size = new Size(345, 31);
            tbJudul.TabIndex = 5;
            // 
            // tbPengarang
            // 
            tbPengarang.Location = new Point(226, 171);
            tbPengarang.Name = "tbPengarang";
            tbPengarang.Size = new Size(345, 31);
            tbPengarang.TabIndex = 6;
            // 
            // tbTahunTerbit
            // 
            tbTahunTerbit.Location = new Point(226, 223);
            tbTahunTerbit.Name = "tbTahunTerbit";
            tbTahunTerbit.Size = new Size(150, 31);
            tbTahunTerbit.TabIndex = 7;
            // 
            // tbKategori
            // 
            tbKategori.Location = new Point(226, 276);
            tbKategori.Name = "tbKategori";
            tbKategori.Size = new Size(150, 31);
            tbKategori.TabIndex = 8;
            // 
            // btnSimpanBuku
            // 
            btnSimpanBuku.Location = new Point(459, 368);
            btnSimpanBuku.Name = "btnSimpanBuku";
            btnSimpanBuku.Size = new Size(112, 34);
            btnSimpanBuku.TabIndex = 9;
            btnSimpanBuku.Text = "Simpan";
            btnSimpanBuku.UseVisualStyleBackColor = true;
            btnSimpanBuku.Click += btnSimpanBuku_Click;
            // 
            // AddBuku
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSimpanBuku);
            Controls.Add(tbKategori);
            Controls.Add(tbTahunTerbit);
            Controls.Add(tbPengarang);
            Controls.Add(tbJudul);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBuku";
            Text = "Form Tambah Buku";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbJudul;
        private TextBox tbPengarang;
        private TextBox tbTahunTerbit;
        private TextBox tbKategori;
        private Button btnSimpanBuku;
    }
}