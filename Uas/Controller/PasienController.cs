using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uas.Modal.Repository;
using Uas.Model.Entity;

namespace Uas.Controller
{
    public class PasienController
    {
        private RepositoryPasien repositoryPasien;

        public PasienController()
        {
            repositoryPasien = new RepositoryPasien();
        }

        public void TambahPasien(Pasien pasien)
        {
            repositoryPasien.TambahPasien(pasien);
        }

        public List<Pasien> AmbilSemuaPasien()
        {
            return repositoryPasien.AmbilSemuaPasien();
        }

        public void UpdatePasien(Pasien pasien)
        {
            repositoryPasien.UpdatePasien(pasien);
        }

        public void HapusPasien(int idPasien)
        {
            repositoryPasien.HapusPasien(idPasien);
        }

        public Pasien AmbilPasienBerdasarkanId(int idPasien)
        {
            return repositoryPasien.AmbilPasienBerdasarkanId(idPasien);
        }

        public List<Pasien> AmbilPasienBerdasarkanNama(string nama)
        {
            return repositoryPasien.AmbilPasienBerdasarkanNama(nama);
        }
    }
}
