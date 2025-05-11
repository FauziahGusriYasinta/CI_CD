using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uas.View;

namespace Uas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" && Password.Text == "")
            {
                MessageBox.Show("Informasi Salah");
            }
            else if (Username.Text == "Admin" && Password.Text == "Admin")
            {
                HomeScreen obj = new HomeScreen();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Tolong periksa kembali username dan passwordnya");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
