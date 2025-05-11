using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uas.Model.Entity;
using Uas.Controller;

namespace Uas.View
{
    public partial class DokterForm : Form
    {
        private List<Dokter> listOfDokter = new List<Dokter>();
        private DokterConroller controller;
        public DokterForm()
        {
            InitializeComponent();
            controller = new DokterConroller();
            InisialisasiListView();
            LoadDataDokter();
        }

        private void InisialisasiListView()
        {
            listDokter.View = System.Windows.Forms.View.Details;
            listDokter.FullRowSelect = true;
            listDokter.GridLines = true;
            listDokter.Columns.Add("No.", 50, HorizontalAlignment.Center);
            listDokter.Columns.Add("ID", 100, HorizontalAlignment.Center);
            listDokter.Columns.Add("Nama", 100, HorizontalAlignment.Center);
            listDokter.Columns.Add("Spesialis", 90, HorizontalAlignment.Left);
            listDokter.Columns.Add("Gender", 90, HorizontalAlignment.Center);
            listDokter.Columns.Add("Alamat", 150, HorizontalAlignment.Center);

        }

        private void LoadDataDokter()
        {
            // kosongkan listview
            listDokter.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfDokter = controller.AmbilSemuaDokter();
            // ekstrak objek mhs dari collection
            foreach (var dokter in listOfDokter)
            {
                var noUrut = listDokter.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(dokter.Id_dokter.ToString());
                item.SubItems.Add(dokter.Nama);
                item.SubItems.Add(dokter.Spesialis);
                item.SubItems.Add(dokter.Gender);
                item.SubItems.Add(dokter.Alamat);
                // tampilkan data mhs ke listview
                listDokter.Items.Add(item);
            }
        }

        // method event handler untuk merespon event OnCreate,
        private void OnCreateEventHandler(Dokter dokter)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            listOfDokter.Add(dokter);
            int noUrut = listDokter.Items.Count + 1;
            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(dokter.Id_dokter.ToString());
            item.SubItems.Add(dokter.Nama);
            item.SubItems.Add(dokter.Spesialis);
            item.SubItems.Add(dokter.Gender);
            item.SubItems.Add(dokter.Alamat);
            // tampilkan data mhs ke listview
            listDokter.Items.Add(item);
        }
        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Dokter dokter)
        {
            // ambil index data mhs yang edit
            int index = listDokter.SelectedIndices[0];
            // update informasi mhs di listview
            ListViewItem itemRow = listDokter.Items[index];
            itemRow.SubItems[1].Text = dokter.Id_dokter.ToString();
            itemRow.SubItems[2].Text = dokter.Nama;
            itemRow.SubItems[3].Text = dokter.Spesialis;
            itemRow.SubItems[4].Text = dokter.Gender;
            itemRow.SubItems[5].Text = dokter.Alamat;
        }


        private void DokterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            DokterFormKecil frmEntry = new DokterFormKecil("Tambah Data Dokter", controller);
            // mendaftarkan method event handler untuk merespon event OnCreate
            frmEntry.OnCreate += OnCreateEventHandler;
            // tampilkan form entry mahasiswa
            frmEntry.ShowDialog();

        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (listDokter.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Dokter dokter = listOfDokter[listDokter.SelectedIndices[0]];
                // buat objek form entry data mahasiswa
                DokterFormKecil frmEntry = new DokterFormKecil("Edit Data Dokter", dokter, controller);
                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEntry.OnUpdate += OnUpdateEventHandler;
                // tampilkan form entry mahasiswa
                frmEntry.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
               MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (listDokter.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data Dokter ingin  dihapus ? ", "Konfirmasi",  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Dokter dokter = listOfDokter[listDokter.SelectedIndices[0]];
                    // panggil operasi CRUD
                    //var result = controller.HapusDokter(dokter.Id_dokter); // Menggunakan ID sebagai parameter
                    //if (result > 0) LoadDataDokter();
                    // Panggil operasi CRUD
                    controller.HapusDokter(dokter.Id_dokter);

                    // Setelah penghapusan selesai, muat ulang data
                    LoadDataDokter();
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
