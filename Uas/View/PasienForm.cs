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
    public partial class PasienForm : Form
    {
        private List<Pasien> listOfPasien = new List<Pasien>();
        private PasienController controller;
        public PasienForm()
        {
            InitializeComponent();
            controller = new PasienController();
            InisialisasiListView();
            LoadDataPasien();
        }

        private void InisialisasiListView()
        {
            listPasien.View = System.Windows.Forms.View.Details;
            listPasien.FullRowSelect = true;
            listPasien.GridLines = true;
            listPasien.Columns.Add("No.", 50, HorizontalAlignment.Center);
            listPasien.Columns.Add("ID", 100, HorizontalAlignment.Center);
            listPasien.Columns.Add("Nama", 100, HorizontalAlignment.Center);
            listPasien.Columns.Add("Diagnosis", 90, HorizontalAlignment.Left);
            listPasien.Columns.Add("Gender", 90, HorizontalAlignment.Center);
            listPasien.Columns.Add("Umur", 90, HorizontalAlignment.Center);
            listPasien.Columns.Add("Alamat", 150, HorizontalAlignment.Center);
            listPasien.Columns.Add("Dokter Penanggung Jawab", 180, HorizontalAlignment.Center);


        }

        private void LoadDataPasien()
        {
            // kosongkan listview
            listPasien.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfPasien = controller.AmbilSemuaPasien();
            // ekstrak objek mhs dari collection
            foreach (var pasien in listOfPasien)
            {
                var noUrut = listPasien.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pasien.Id_pasien.ToString());
                item.SubItems.Add(pasien.Nama);
                item.SubItems.Add(pasien.Diagnosis);
                item.SubItems.Add(pasien.Umur);
                item.SubItems.Add(pasien.Alamat);
                item.SubItems.Add(pasien.Id_dokter.ToString());
                // tampilkan data mhs ke listview
                listPasien.Items.Add(item);
            }
        }

        // method event handler untuk merespon event OnCreate,
        private void OnCreateEventHandler(Pasien pasien)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            listOfPasien.Add(pasien);
            int noUrut = listPasien.Items.Count + 1;
            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(pasien.Id_pasien.ToString());
            item.SubItems.Add(pasien.Nama);
            item.SubItems.Add(pasien.Diagnosis);
            item.SubItems.Add(pasien.Umur);
            item.SubItems.Add(pasien.Alamat);
            item.SubItems.Add(pasien.Id_dokter.ToString());

            // tampilkan data mhs ke listview
            listPasien.Items.Add(item);
        }
        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Pasien pasien)
        {
            // ambil index data mhs yang edit
            int index = listPasien.SelectedIndices[0];
            // update informasi mhs di listview
            ListViewItem itemRow = listPasien.Items[index];
            itemRow.SubItems[1].Text = pasien.Id_pasien.ToString();
            itemRow.SubItems[2].Text = pasien.Nama;
            itemRow.SubItems[3].Text = pasien.Diagnosis;
            itemRow.SubItems[4].Text = pasien.Umur;
            itemRow.SubItems[5].Text = pasien.Alamat;
            itemRow.SubItems[6].Text = pasien.Id_dokter.ToString();
        }


        private void DokterForm_Load(object sender, EventArgs e)
        {

        }
        private void PasienForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            PasienFormKecil frmEntry = new PasienFormKecil("Tambah Data Pasien", controller);
            // mendaftarkan method event handler untuk merespon event OnCreate
            frmEntry.OnCreate += OnCreateEventHandler;
            // tampilkan form entry mahasiswa
            frmEntry.ShowDialog();
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (listPasien.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Pasien pasien = listOfPasien[listPasien.SelectedIndices[0]];
                // buat objek form entry data mahasiswa
                PasienFormKecil frmEntry = new PasienFormKecil("Edit Data Dokter", pasien, controller);
                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEntry.OnUpdate += OnUpdateEventHandler;
                // tampilkan form entry mahasiswa
                frmEntry.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (listPasien.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data Dokter ingin  dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Pasien pasien = listOfPasien[listPasien.SelectedIndices[0]];
                    // panggil operasi CRUD
                    //var result = controller.HapusDokter(dokter.Id_dokter); // Menggunakan ID sebagai parameter
                    //if (result > 0) LoadDataDokter();
                    // Panggil operasi CRUD
                    controller.HapusPasien(pasien.Id_pasien);

                    // Setelah penghapusan selesai, muat ulang data
                    LoadDataPasien();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data Dokter belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
