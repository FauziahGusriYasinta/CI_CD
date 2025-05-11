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
    public partial class DokterFormKecil : Form
    {
        public delegate void CreateUpdateEventHandler(Dokter dkr);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private DokterConroller controller;

        private bool isNewData = true;
        private Dokter dokter;

        public DokterFormKecil()
        {
            InitializeComponent();
        }
        public DokterFormKecil(string title, DokterConroller controller) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        public DokterFormKecil(string title, Dokter obj, DokterConroller controller) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
            isNewData = false; // set status edit data
            dokter = obj; // set objek mhs yang akan diedit
                       // untuk edit data, tampilkan data lama
            txtIdDokter.Text = dokter.Id_dokter.ToString(); ;
            txtNama.Text = dokter.Nama;
            txtSpesialis.Text = dokter.Spesialis;
            txtGender.Text = dokter.Gender;
            txtAlamat.Text = dokter.Alamat;

        }

        private void DokterFormKecil_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) dokter = new Dokter();

            dokter.Id_dokter = int.Parse(txtIdDokter.Text);
            dokter.Nama = txtNama.Text;
            dokter.Spesialis = txtSpesialis.Text;
            dokter.Gender = txtGender.Text;
            dokter.Alamat = txtAlamat.Text;

            if (isNewData)
            {
                controller.TambahDokter(dokter);
                OnCreate?.Invoke(dokter);
                ClearForm();
            }
            else
            {
                controller.UpdateDokter(dokter);
                OnUpdate?.Invoke(dokter);
                this.Close();
            }
        }
        private void ClearForm()
        {
            txtIdDokter.Clear();
            txtNama.Clear();
            txtSpesialis.Clear();
            txtGender.Clear();
            txtAlamat.Clear();
            txtIdDokter.Focus();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
