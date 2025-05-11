using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uas.Modal.Entity;

namespace Uas.Modal.Repository
{
    public class RepositoryTransaksi
    {
        private string connectionString = @"C:\uas\Uas\Uas\Modal\DbTugasAkhir.db;Version=3;";

        public void CatatTransaksi(Transaksi transaksi)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO transaksi (id_pasien, id_dokter, id_karyawan, waktu, tindakan, entitas_terlibat, admin_username, data_baru) VALUES (@IdPasien, @IdDokter, @IdKaryawan, @Waktu, @Tindakan, @EntitasTerlibat, @AdminUsername, @DataBaru);";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdPasien", transaksi.Id_pasien);
                    command.Parameters.AddWithValue("@IdDokter", transaksi.Id_dokter);
                    command.Parameters.AddWithValue("@IdKaryawan", transaksi.Id_karyawan);
                    command.Parameters.AddWithValue("@Waktu", transaksi.Waktu);
                    command.Parameters.AddWithValue("@Tindakan", transaksi.Tindakan);
                    command.Parameters.AddWithValue("@EntitasTerlibat", transaksi.Entitas_terlibat);
                    command.Parameters.AddWithValue("@AdminUsername", transaksi.Admin_username);
                    command.Parameters.AddWithValue("@DataBaru", transaksi.Data_baru);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Transaksi> AmbilSemuaTransaksi()
        {
            List<Transaksi> daftarTransaksi = new List<Transaksi>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM transaksi;";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaksi transaksi = new Transaksi
                            {
                                Id_transaksi = Convert.ToInt32(reader["id_transaksi"]),
                                Id_pasien = Convert.ToInt32(reader["id_pasien"]),
                                Id_dokter = Convert.ToInt32(reader["id_dokter"]),
                                Id_karyawan = Convert.ToInt32(reader["id_karyawan"]),
                                Waktu = reader["waktu"].ToString(),
                                Tindakan = reader["tindakan"].ToString(),
                                Entitas_terlibat = reader["entitas_terlibat"].ToString(),
                                Admin_username = reader["admin_username"].ToString(),
                                Data_baru = reader["data_baru"].ToString()
                            };

                            daftarTransaksi.Add(transaksi);
                        }
                    }
                }
            }

            return daftarTransaksi;
        }
    }
}

