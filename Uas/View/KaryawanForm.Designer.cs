namespace Uas.View
{
    partial class KaryawanForm
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
            this.btnCari = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnPerbaiki = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.listKaryawan = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(752, 14);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(70, 32);
            this.btnCari.TabIndex = 32;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(470, 22);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(265, 22);
            this.txtNama.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cari ID atau Nama";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(435, 495);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(172, 42);
            this.btnHapus.TabIndex = 29;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(70, 495);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(172, 42);
            this.btnTambah.TabIndex = 28;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnPerbaiki
            // 
            this.btnPerbaiki.Location = new System.Drawing.Point(248, 495);
            this.btnPerbaiki.Name = "btnPerbaiki";
            this.btnPerbaiki.Size = new System.Drawing.Size(172, 42);
            this.btnPerbaiki.TabIndex = 27;
            this.btnPerbaiki.Text = "PERBAIKI";
            this.btnPerbaiki.UseVisualStyleBackColor = true;
            this.btnPerbaiki.Click += new System.EventHandler(this.btnPerbaiki_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(776, 495);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(172, 42);
            this.btnSelesai.TabIndex = 26;
            this.btnSelesai.Text = "SELESAI";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // listKaryawan
            // 
            this.listKaryawan.HideSelection = false;
            this.listKaryawan.Location = new System.Drawing.Point(60, 75);
            this.listKaryawan.Name = "listKaryawan";
            this.listKaryawan.Size = new System.Drawing.Size(888, 414);
            this.listKaryawan.TabIndex = 25;
            this.listKaryawan.UseCompatibleStateImageBehavior = false;
            // 
            // KaryawanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 573);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnPerbaiki);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.listKaryawan);
            this.Name = "KaryawanForm";
            this.Text = "KaryawanForm";
            this.Load += new System.EventHandler(this.KaryawanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnPerbaiki;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.ListView listKaryawan;
    }
}