namespace Uas.View
{
    partial class HomeScreen
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
            this.btnX = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnDokter = new System.Windows.Forms.Button();
            this.btnKaryawan = new System.Windows.Forms.Button();
            this.btnPasien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnX
            // 
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(618, 106);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(33, 34);
            this.btnX.TabIndex = 9;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Location = new System.Drawing.Point(354, 298);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(116, 46);
            this.btnTransaksi.TabIndex = 8;
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.UseVisualStyleBackColor = true;
            // 
            // btnDokter
            // 
            this.btnDokter.Location = new System.Drawing.Point(354, 203);
            this.btnDokter.Name = "btnDokter";
            this.btnDokter.Size = new System.Drawing.Size(116, 46);
            this.btnDokter.TabIndex = 7;
            this.btnDokter.Text = "Dokter";
            this.btnDokter.UseVisualStyleBackColor = true;
            this.btnDokter.Click += new System.EventHandler(this.btnDokter_Click);
            // 
            // btnKaryawan
            // 
            this.btnKaryawan.Location = new System.Drawing.Point(150, 285);
            this.btnKaryawan.Name = "btnKaryawan";
            this.btnKaryawan.Size = new System.Drawing.Size(116, 46);
            this.btnKaryawan.TabIndex = 6;
            this.btnKaryawan.Text = "Karyawan";
            this.btnKaryawan.UseVisualStyleBackColor = true;
            this.btnKaryawan.Click += new System.EventHandler(this.btnKaryawan_Click);
            // 
            // btnPasien
            // 
            this.btnPasien.Location = new System.Drawing.Point(150, 203);
            this.btnPasien.Name = "btnPasien";
            this.btnPasien.Size = new System.Drawing.Size(116, 46);
            this.btnPasien.TabIndex = 5;
            this.btnPasien.Text = "Pasien";
            this.btnPasien.UseVisualStyleBackColor = true;
            this.btnPasien.Click += new System.EventHandler(this.btnPasien_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnTransaksi);
            this.Controls.Add(this.btnDokter);
            this.Controls.Add(this.btnKaryawan);
            this.Controls.Add(this.btnPasien);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button btnDokter;
        private System.Windows.Forms.Button btnKaryawan;
        private System.Windows.Forms.Button btnPasien;
    }
}