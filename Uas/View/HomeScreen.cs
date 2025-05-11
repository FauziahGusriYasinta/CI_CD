using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uas.View
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnDokter_Click(object sender, EventArgs e)
        {
            DokterForm dokterForm = new DokterForm();
            dokterForm.Show();
            this.Hide();
        }

        private void btnPasien_Click(object sender, EventArgs e)
        {
            PasienForm pasienForm = new PasienForm();
            pasienForm.Show();
            this.Hide();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            TransaksiForm transaksiForm = new TransaksiForm();
            transaksiForm.Show();
            this.Hide();
        }
    }
}
