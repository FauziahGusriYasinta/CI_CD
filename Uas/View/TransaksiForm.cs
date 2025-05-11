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
using Uas.Modal.Entity;

namespace Uas.View
{
    public partial class TransaksiForm : Form
    {
        private List<Transaksi> listOfTransaksi = new List<Transaksi>();
        private TransaksiController controller;

        public TransaksiForm()
        {
            InitializeComponent();
            controller = new TransaksiController();
            InisialisasiListView();
            LoadDataTransaksi();
        }

        private void InisialisasiListView()
        {
            listTransaksi.View = System.Windows.Forms.View.Details;
            listTransaksi.FullRowSelect = true;
            listTransaksi.GridLines = true;

            // Sesuaikan kolom yang dibutuhkan untuk tampilan transaksi
            listTransaksi.Columns.Add("No.", 50, HorizontalAlignment.Center);
            listTransaksi.Columns.Add("ID Transaksi", 100, HorizontalAlignment.Center);
            listTransaksi.Columns.Add("ID Pasien", 100, HorizontalAlignment.Center);
            listTransaksi.Columns.Add("ID Dokter", 90, HorizontalAlignment.Left);
            listTransaksi.Columns.Add("ID Karyawan", 90, HorizontalAlignment.Center);
            listTransaksi.Columns.Add("Waktu", 150, HorizontalAlignment.Center);
            // Tambahkan kolom lain sesuai kebutuhan

        }

        private void LoadDataTransaksi()
        {
            // Kosongkan listview
            listTransaksi.Items.Clear();

            // Panggil method AmbilSemuaTransaksi dan tampung datanya ke dalam collection
            listOfTransaksi = controller.AmbilSemuaTransaksi();

            // Ekstrak objek transaksi dari collection
            foreach (var transaksi in listOfTransaksi)
            {
                var noUrut = listTransaksi.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(transaksi.Id_transaksi.ToString());
                item.SubItems.Add(transaksi.Id_pasien.ToString());
                item.SubItems.Add(transaksi.Id_dokter.ToString());
                item.SubItems.Add(transaksi.Id_karyawan.ToString());
                item.SubItems.Add(transaksi.Waktu);
                // Tambahkan data lain sesuai dengan properti yang ada pada Transaksi

                // Tampilkan data transaksi ke listview
                listTransaksi.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Transaksi transaksi)
        {
            // Tambahkan objek transaksi yang baru ke dalam collection
            listOfTransaksi.Add(transaksi);
            int noUrut = listTransaksi.Items.Count + 1;

            // Tampilkan data transaksi yang baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(transaksi.Id_transaksi.ToString());
            item.SubItems.Add(transaksi.Id_pasien.ToString());
            item.SubItems.Add(transaksi.Id_dokter.ToString());
            item.SubItems.Add(transaksi.Id_karyawan.ToString());
            item.SubItems.Add(transaksi.Waktu);
            // Tambahkan data lain sesuai dengan properti yang ada pada Transaksi

            // Tampilkan data transaksi ke listview
            listTransaksi.Items.Add(item);
        }

        private void OnUpdateEventHandler(Transaksi transaksi)
        {
            int index = listTransaksi.SelectedIndices[0];
            ListViewItem itemRow = listTransaksi.Items[index];

            itemRow.SubItems[1].Text = transaksi.Id_transaksi.ToString();
            itemRow.SubItems[2].Text = transaksi.Id_pasien.ToString();
            itemRow.SubItems[3].Text = transaksi.Id_dokter.ToString();
            itemRow.SubItems[4].Text = transaksi.Id_karyawan.ToString();
            itemRow.SubItems[5].Text = transaksi.Waktu;
            // Update data lain sesuai dengan properti yang ada pada Transaksi
        }

        // Method-event handler lainnya jika diperlukan


    }
}
