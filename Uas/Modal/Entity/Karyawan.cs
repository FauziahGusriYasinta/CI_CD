using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uas.Model.Entity
{
    public class Karyawan
    {
        public int Id_karyawan { get; set; }
        public string Nama { get; set; }
        public string Bagian_kerja { get; set; }
        public string Gender { get; set; }
        public string Alamat { get; set; }
    }
}
