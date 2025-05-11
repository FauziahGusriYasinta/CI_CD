using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uas.Modal.Entity;
using Uas.Modal.Repository;

namespace Uas.Controller
{
    public class TransaksiController
    {
        private RepositoryTransaksi repositoryTransaksi;

        public TransaksiController()
        {
            repositoryTransaksi = new RepositoryTransaksi();
        }

        public void CatatTransaksi(Transaksi transaksi)
        {
            repositoryTransaksi.CatatTransaksi(transaksi);
        }

        public List<Transaksi> AmbilSemuaTransaksi()
        {
            return repositoryTransaksi.AmbilSemuaTransaksi();
        }
    }
}


