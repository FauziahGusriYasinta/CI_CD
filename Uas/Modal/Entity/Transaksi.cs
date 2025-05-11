using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uas.Modal.Entity
{
    public class Transaksi
    {
        public int Id_transaksi { get; set; }
        public int Id_pasien { get; set; }
        public int Id_dokter { get; set; }
        public int Id_karyawan { get; set; }
        public string Waktu { get; set; }
        public string Tindakan { get; set; }
        public string Entitas_terlibat { get; set; }
        public string Admin_username { get; set; }
        public string Data_baru { get; set; }
    }
}
