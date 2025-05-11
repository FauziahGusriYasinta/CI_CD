using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uas.Modal.Repository;
using Uas.Model.Entity;

namespace Uas.Controller
{
    public class KaryawanController
    {
        private RepositoryKaryawan repositoryKaryawan;

        public KaryawanController()
        {
            repositoryKaryawan = new RepositoryKaryawan();
        }

        public void TambahKaryawan(Karyawan karyawan)
        {
            repositoryKaryawan.TambahKaryawan(karyawan);
        }

        public List<Karyawan> AmbilSemuaKaryawan()
        {
            return repositoryKaryawan.AmbilSemuaKaryawan();
        }

        public void UpdateKaryawan(Karyawan karyawan)
        {
            repositoryKaryawan.UpdateKaryawan(karyawan);
        }

        public void HapusKaryawan(int idKaryawan)
        {
            repositoryKaryawan.HapusKaryawan(idKaryawan);
        }

        public Karyawan AmbilKaryawanBerdasarkanId(int idKaryawan)
        {
            return repositoryKaryawan.AmbilKaryawanBerdasarkanId(idKaryawan);
        }

        public List<Karyawan> AmbilKaryawanBerdasarkanNama(string nama)
        {
            return repositoryKaryawan.AmbilKaryawanBerdasarkanNama(nama);
        }
    }
}

