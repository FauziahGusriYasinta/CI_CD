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
    public partial class KaryawanForm : Form
    {
        private List<Karyawan> listOfKaryawan = new List<Karyawan>();
        private KaryawanController controller;
        public KaryawanForm()
        {
            InitializeComponent();
            controller = new KaryawanController();
            InisialisasiListView();
            LoadDataKaryawan();
        }
        private void InisialisasiListView()
        {
            listKaryawan.View = System.Windows.Forms.View.Details;
            listKaryawan.FullRowSelect = true;
            listKaryawan.GridLines = true;
            listKaryawan.Columns.Add("No.", 50, HorizontalAlignment.Center);
            listKaryawan.Columns.Add("ID", 100, HorizontalAlignment.Center);
            listKaryawan.Columns.Add("Nama", 100, HorizontalAlignment.Center);
            listKaryawan.Columns.Add("Bidang", 90, HorizontalAlignment.Left);
            listKaryawan.Columns.Add("Gender", 90, HorizontalAlignment.Center);
            listKaryawan.Columns.Add("Alamat", 150, HorizontalAlignment.Center);

        }
        private void LoadDataKaryawan()
        {
            // kosongkan listview
            listKaryawan.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfKaryawan = controller.AmbilSemuaKaryawan();
            // ekstrak objek mhs dari collection
            foreach (var pasien in listOfKaryawan)
            {
                var noUrut = listKaryawan.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pasien.Id_karyawan.ToString());
                item.SubItems.Add(pasien.Nama);
                item.SubItems.Add(pasien.Bagian_kerja);
                item.SubItems.Add(pasien.Gender);
                item.SubItems.Add(pasien.Alamat);
                // tampilkan data mhs ke listview
                listKaryawan.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Karyawan karyawan)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            listOfKaryawan.Add(karyawan);
            int noUrut = listKaryawan.Items.Count + 1;
            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(karyawan.Id_karyawan.ToString());
            item.SubItems.Add(karyawan.Nama);
            item.SubItems.Add(karyawan.Bagian_kerja);
            item.SubItems.Add(karyawan.Gender);
            item.SubItems.Add(karyawan.Alamat);

            // tampilkan data mhs ke listview
            listKaryawan.Items.Add(item);
        }

        private void OnUpdateEventHandler(Karyawan karyawan)
        {
            // ambil index data mhs yang edit
            int index = listKaryawan.SelectedIndices[0];
            // update informasi mhs di listview
            ListViewItem itemRow = listKaryawan.Items[index];
            itemRow.SubItems[1].Text = karyawan.Id_karyawan.ToString();
            itemRow.SubItems[2].Text = karyawan.Nama;
            itemRow.SubItems[3].Text = karyawan.Bagian_kerja;
            itemRow.SubItems[4].Text = karyawan.Gender;
            itemRow.SubItems[5].Text = karyawan.Alamat;
        }
        private void KaryawanForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            KaryawanFormKecil frmEntry = new KaryawanFormKecil("Tambah Data Pasien", controller);
            // mendaftarkan method event handler untuk merespon event OnCreate
            frmEntry.OnCreate += OnCreateEventHandler;
            // tampilkan form entry mahasiswa
            frmEntry.ShowDialog();
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (listKaryawan.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Karyawan karyawan = listOfKaryawan[listKaryawan.SelectedIndices[0]];
                // buat objek form entry data mahasiswa
                KaryawanFormKecil frmEntry = new KaryawanFormKecil("Edit Data Karyawan", karyawan, controller);
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
            if (listKaryawan.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data Dokter ingin  dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Karyawan karyawan = listOfKaryawan[listKaryawan.SelectedIndices[0]];
                    // panggil operasi CRUD
                    //var result = controller.HapusDokter(dokter.Id_dokter); // Menggunakan ID sebagai parameter
                    //if (result > 0) LoadDataDokter();
                    // Panggil operasi CRUD
                    controller.HapusKaryawan(karyawan.Id_karyawan);

                    // Setelah penghapusan selesai, muat ulang data
                    LoadDataKaryawan();
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

        private void btnCari_Click(object sender, EventArgs e)
        {
            listKaryawan.Items.Clear();

            // panggil method ReadByNama dan tampung datanya ke dalam collection
            listOfKaryawan = controller.AmbilKaryawanBerdasarkanNama(txtNama.Text);

            // ekstrak objek mhs dari collection
            foreach (var karyawan in listOfKaryawan)
            {
                var noUrut = listKaryawan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(karyawan.Id_karyawan.ToString());
                item.SubItems.Add(karyawan.Nama);
                item.SubItems.Add(karyawan.Bagian_kerja);

                // tampilkan data mhs ke listview
                listKaryawan.Items.Add(item);
            }
        }
    }
}
