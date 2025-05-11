using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uas.Model.Entity;

namespace Uas.Modal.Repository
{
    public class RepositoryPasien
    {
        private string connectionString = @"Data Source=C:\uas\Uas\Uas\Modal\DbTugasAkhir.db;Version=3;";

        public void TambahPasien(Pasien pasien)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO pasien (nama, diagnosis, umur, alamat, id_dokter) VALUES (@Nama, @Diagnosis, @Umur, @Alamat, @IdDokter);";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Nama", pasien.Nama);
                    command.Parameters.AddWithValue("@Diagnosis", pasien.Diagnosis);
                    command.Parameters.AddWithValue("@Umur", pasien.Umur);
                    command.Parameters.AddWithValue("@Alamat", pasien.Alamat);
                    command.Parameters.AddWithValue("@IdDokter", pasien.Id_dokter);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Pasien> AmbilSemuaPasien()
        {
            List<Pasien> daftarPasien = new List<Pasien>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM pasien;";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pasien pasien = new Pasien
                            {
                                Id_pasien = Convert.ToInt32(reader["id_pasien"]),
                                Nama = reader["nama"].ToString(),
                                Diagnosis = reader["diagnosis"].ToString(),
                                Umur = reader["umur"].ToString(),
                                Alamat = reader["alamat"].ToString(),
                                Id_dokter = Convert.ToInt32(reader["id_dokter"])
                            };

                            daftarPasien.Add(pasien);
                        }
                    }
                }
            }

            return daftarPasien;
        }

        public void UpdatePasien(Pasien pasien)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE pasien SET nama = @Nama, diagnosis = @Diagnosis, umur = @Umur, alamat = @Alamat, id_dokter = @IdDokter WHERE id_pasien = @IdPasien;";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdPasien", pasien.Id_pasien);
                    command.Parameters.AddWithValue("@Nama", pasien.Nama);
                    command.Parameters.AddWithValue("@Diagnosis", pasien.Diagnosis);
                    command.Parameters.AddWithValue("@Umur", pasien.Umur);
                    command.Parameters.AddWithValue("@Alamat", pasien.Alamat);
                    command.Parameters.AddWithValue("@IdDokter", pasien.Id_dokter);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void HapusPasien(int idPasien)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM pasien WHERE id_pasien = @IdPasien;";

                using (var command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdPasien", idPasien);

                    command.ExecuteNonQuery();
                }
            }
        }

        public Pasien AmbilPasienBerdasarkanId(int idPasien)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM pasien WHERE id_pasien = @IdPasien;";
                Pasien pasien = null;

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdPasien", idPasien);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pasien = new Pasien
                            {
                                Id_pasien = Convert.ToInt32(reader["id_pasien"]),
                                Nama = reader["nama"].ToString(),
                                Diagnosis = reader["diagnosis"].ToString(),
                                Umur = reader["umur"].ToString(),
                                Alamat = reader["alamat"].ToString(),
                                Id_dokter = Convert.ToInt32(reader["id_dokter"])
                            };
                        }
                    }
                }

                return pasien;
            }
        }

        public List<Pasien> AmbilPasienBerdasarkanNama(string nama)
        {
            List<Pasien> daftarPasien = new List<Pasien>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM pasien WHERE nama = @Nama;";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Nama", nama);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pasien pasien = new Pasien
                            {
                                Id_pasien = Convert.ToInt32(reader["id_pasien"]),
                                Nama = reader["nama"].ToString(),
                                Diagnosis = reader["diagnosis"].ToString(),
                                Umur = reader["umur"].ToString(),
                                Alamat = reader["alamat"].ToString(),
                                Id_dokter = Convert.ToInt32(reader["id_dokter"])
                            };

                            daftarPasien.Add(pasien);
                        }
                    }
                }
            }

            return daftarPasien;
        }
    }
}
