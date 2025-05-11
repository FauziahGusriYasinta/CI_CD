using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uas.Controller;
using Uas.Model.Entity;

namespace Uas.View
{
    public partial class KaryawanFormKecil : Form
    {
        public delegate void CreateUpdateEventHandler(Karyawan krn);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private KaryawanController controller;
        private bool isNewData = true;
        private Karyawan karyawan;

        public KaryawanFormKecil()
        {
            InitializeComponent();
        }
        public KaryawanFormKecil(string title, KaryawanController controller) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }
        public KaryawanFormKecil(string title, Karyawan obj, KaryawanController controller) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
            isNewData = false; // set status edit data
            karyawan = obj; // set objek mhs yang akan diedit
                          // untuk edit data, tampilkan data lama
            txtIdKaryawan.Text = karyawan.Id_karyawan.ToString(); ;
            txtNama.Text = karyawan.Nama;
            txtBagianKeja.Text = karyawan.Bagian_kerja;
            txtGender.Text = karyawan.Gender;
            txtAlamat.Text = karyawan.Alamat;

        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) karyawan = new Karyawan();

            karyawan.Id_karyawan = int.Parse(txtIdKaryawan.Text);
            karyawan.Nama = txtNama.Text;
            karyawan.Bagian_kerja = txtBagianKeja.Text;
            karyawan.Gender = txtGender.Text;
            karyawan.Alamat = txtAlamat.Text;

            if (isNewData)
            {
                controller.TambahKaryawan(karyawan);
                OnCreate?.Invoke(karyawan);
                ClearForm();
            }
            else
            {
                controller.TambahKaryawan(karyawan);
                OnUpdate?.Invoke(karyawan);
                this.Close();
            }
        }
        private void ClearForm()
        {
            txtIdKaryawan.Clear();
            txtNama.Clear();
            txtBagianKeja.Clear();
            txtGender.Clear();
            txtAlamat.Clear();
            txtIdKaryawan.Focus();

        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
