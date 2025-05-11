using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uas.Model.Entity
{
    public class Pasien
    {
        public int Id_pasien { get; set; }
        public string Nama { get; set; }
        public string Diagnosis { get; set; }
        public string Umur { get; set; }
        public string Alamat { get; set; }
        public int Id_dokter { get; set; }
    }
}
