namespace Uas.View
{
    partial class KaryawanFormKecil
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
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtBagianKeja = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtIdKaryawan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(274, 257);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(171, 35);
            this.btnSelesai.TabIndex = 35;
            this.btnSelesai.Text = "SELESAI";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(274, 216);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(171, 35);
            this.btnSimpan.TabIndex = 34;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(111, 69);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(206, 22);
            this.txtNama.TabIndex = 33;
            // 
            // txtBagianKeja
            // 
            this.txtBagianKeja.Location = new System.Drawing.Point(111, 107);
            this.txtBagianKeja.Name = "txtBagianKeja";
            this.txtBagianKeja.Size = new System.Drawing.Size(206, 22);
            this.txtBagianKeja.TabIndex = 32;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(111, 143);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(138, 22);
            this.txtGender.TabIndex = 31;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(111, 179);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(334, 22);
            this.txtAlamat.TabIndex = 30;
            // 
            // txtIdKaryawan
            // 
            this.txtIdKaryawan.Location = new System.Drawing.Point(111, 37);
            this.txtIdKaryawan.Name = "txtIdKaryawan";
            this.txtIdKaryawan.Size = new System.Drawing.Size(169, 22);
            this.txtIdKaryawan.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Spesialis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID Dokter";
            // 
            // KaryawanFormKecil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 333);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtBagianKeja);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtIdKaryawan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KaryawanFormKecil";
            this.Text = "KaryawanFormKecil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtBagianKeja;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtIdKaryawan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}