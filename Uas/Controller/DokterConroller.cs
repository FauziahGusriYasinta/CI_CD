using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uas.Modal.Repository;
using Uas.Model.Entity;

namespace Uas.Controller
{
    public class DokterConroller
    {
        private RepositoryDokter repositoryDokter;

        public void TambahDokter(Dokter dokter)
        {
            if (repositoryDokter != null)
            {
                repositoryDokter.TambahDokter(dokter);
            }
            else
            {
                Console.WriteLine("RepositoryDokter is null. Unable to add doctor."); // Pesan kesalahan untuk konsol
                                                                                      // Atau tambahkan penanganan kesalahan lainnya
            }
        }

        /*public void TambahDokter(Dokter dokter)
        {
            repositoryDokter.TambahDokter(dokter);
        }*/
        public List<Dokter> AmbilSemuaDokter()
        {
            if (repositoryDokter != null)
            {
                return repositoryDokter.AmbilSemuaDokter();
            }
            else
            {
                // Atur pengembalian nilai default atau penanganan kesalahan jika repositoryDokter null
                return new List<Dokter>(); // Atau return null atau nilai default lainnya
            }
        }
        /*public List<Dokter> AmbilSemuaDokter()
        {
            return repositoryDokter.AmbilSemuaDokter();
        }*/

        public void UpdateDokter(Dokter dokter)
        {
            repositoryDokter.UpdateDokter(dokter);
        }

        public void HapusDokter(int idDokter)
        {
            repositoryDokter.HapusDokter(idDokter);
        }

        public Dokter AmbilDokterBerdasarkanId(int idDokter)
        {
            return repositoryDokter.AmbilDokterBerdasarkanId(idDokter);
        }

        public List<Dokter> AmbilDokterBerdasarkanNama(string nama)
        {
            return repositoryDokter.AmbilDokterBerdasarkanNama(nama);
        }
    }
}