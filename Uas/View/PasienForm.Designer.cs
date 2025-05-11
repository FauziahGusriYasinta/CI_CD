namespace Uas.View
{
    partial class PasienForm
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
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnPerbaiki = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.listPasien = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(720, 37);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(70, 32);
            this.btnCari.TabIndex = 24;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(438, 45);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(265, 22);
            this.txtCari.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cari ID atau Nama";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(403, 518);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(172, 42);
            this.btnHapus.TabIndex = 21;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(38, 518);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(172, 42);
            this.btnTambah.TabIndex = 20;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnPerbaiki
            // 
            this.btnPerbaiki.Location = new System.Drawing.Point(216, 518);
            this.btnPerbaiki.Name = "btnPerbaiki";
            this.btnPerbaiki.Size = new System.Drawing.Size(172, 42);
            this.btnPerbaiki.TabIndex = 19;
            this.btnPerbaiki.Text = "PERBAIKI";
            this.btnPerbaiki.UseVisualStyleBackColor = true;
            this.btnPerbaiki.Click += new System.EventHandler(this.btnPerbaiki_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(744, 518);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(172, 42);
            this.btnSelesai.TabIndex = 18;
            this.btnSelesai.Text = "SELESAI";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // listPasien
            // 
            this.listPasien.HideSelection = false;
            this.listPasien.Location = new System.Drawing.Point(28, 98);
            this.listPasien.Name = "listPasien";
            this.listPasien.Size = new System.Drawing.Size(888, 414);
            this.listPasien.TabIndex = 17;
            this.listPasien.UseCompatibleStateImageBehavior = false;
            // 
            // PasienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 588);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnPerbaiki);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.listPasien);
            this.Name = "PasienForm";
            this.Text = "PasienForm";
            this.Load += new System.EventHandler(this.PasienForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnPerbaiki;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.ListView listPasien;
    }
}