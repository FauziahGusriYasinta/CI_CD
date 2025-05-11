using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uas.Model.Entity
{
    public class Dokter
    {
        public int Id_dokter { get; set; }
        public string Nama { get; set; }
        public string Spesialis { get; set; }
        public string Gender { get; set; }
        public string Alamat { get; set; }

    }
}
