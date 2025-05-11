namespace Uas.View
{
    partial class DokterFormKecil
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
            this.txtSpesialis = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtIdDokter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(280, 283);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(171, 35);
            this.btnSelesai.TabIndex = 23;
            this.btnSelesai.Text = "SELESAI";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(280, 242);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(171, 35);
            this.btnSimpan.TabIndex = 22;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(117, 95);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(206, 22);
            this.txtNama.TabIndex = 21;
            // 
            // txtSpesialis
            // 
            this.txtSpesialis.Location = new System.Drawing.Point(117, 133);
            this.txtSpesialis.Name = "txtSpesialis";
            this.txtSpesialis.Size = new System.Drawing.Size(206, 22);
            this.txtSpesialis.TabIndex = 20;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(117, 169);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(138, 22);
            this.txtGender.TabIndex = 19;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(117, 205);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(334, 22);
            this.txtAlamat.TabIndex = 18;
            // 
            // txtIdDokter
            // 
            this.txtIdDokter.Location = new System.Drawing.Point(117, 63);
            this.txtIdDokter.Name = "txtIdDokter";
            this.txtIdDokter.Size = new System.Drawing.Size(169, 22);
            this.txtIdDokter.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Spesialis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Dokter";
            // 
            // DokterFormKecil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 334);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtSpesialis);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtIdDokter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DokterFormKecil";
            this.Text = "DokterFormKecil";
            this.Load += new System.EventHandler(this.DokterFormKecil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtSpesialis;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtIdDokter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}