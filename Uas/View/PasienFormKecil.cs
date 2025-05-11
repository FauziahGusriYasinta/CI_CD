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
    public partial class PasienFormKecil : Form
    {
        public delegate void CreateUpdateEventHandler(Pasien psn);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private PasienController controller;

        private bool isNewData = true;
        private Pasien pasien;
        public PasienFormKecil()
        {
            InitializeComponent();
        }
        public PasienFormKecil(string title, PasienController controller) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        public PasienFormKecil(string title, Pasien obj, PasienController controller) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
            isNewData = false; // set status edit data
            pasien = obj; // set objek mhs yang akan diedit
                          // untuk edit data, tampilkan data lama
            txtIdPasien.Text = pasien.Id_pasien.ToString(); ;
            txtNama.Text = pasien.Nama;
            txtDiagnosis.Text = pasien.Diagnosis;
            txtUmur.Text = pasien.Umur;
            txtAlamat.Text = pasien.Alamat;
            txtIdPasien.Text = pasien.Id_dokter.ToString(); ;

        }

        private void PasienFormKecil_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) pasien = new Pasien();

            pasien.Id_pasien = int.Parse(txtIdPasien.Text);
            pasien.Nama = txtNama.Text;
            pasien.Diagnosis = txtDiagnosis.Text;
            pasien.Umur = txtUmur.Text;
            pasien.Alamat = txtAlamat.Text;
            pasien.Id_dokter = int.Parse(txtIdPasien.Text);

            if (isNewData)
            {
                controller.TambahPasien(pasien);
                OnCreate?.Invoke(pasien);
                ClearForm();
            }
            else
            {
                controller.UpdatePasien(pasien);
                OnUpdate?.Invoke(pasien);
                this.Close();
            }
        }
        private void ClearForm()
        {
            txtIdPasien.Clear();
            txtNama.Clear();
            txtDiagnosis.Clear();
            txtUmur.Clear();
            txtAlamat.Clear();
            txtIdDokter.Clear();
            txtIdPasien.Focus();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
