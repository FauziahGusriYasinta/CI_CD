using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uas.Model.Entity;

namespace Uas.Modal.Repository
{
    public class RepositoryDokter
    {
        private string connectionString = @"C:\uas\Uas\Uas\Modal\DbTugasAkhir.db;Version=3;";


        public void TambahDokter(Dokter dokter)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO dokter (nama, spesialis, gender, alamat) VALUES (@Nama, @Spesialis, @Gender, @Alamat);";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Nama", dokter.Nama);
                    command.Parameters.AddWithValue("@Spesialis", dokter.Spesialis);
                    command.Parameters.AddWithValue("@Gender", dokter.Gender);
                    command.Parameters.AddWithValue("@Alamat", dokter.Alamat);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Dokter> AmbilSemuaDokter()
        {
            List<Dokter> daftarDokter = new List<Dokter>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM dokter;";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dokter dokter = new Dokter
                            {
                                Id_dokter = Convert.ToInt32(reader["id_dokter"]),
                                Nama = reader["nama"].ToString(),
                                Spesialis = reader["spesialis"].ToString(),
                                Gender = reader["gender"].ToString(),
                                Alamat = reader["alamat"].ToString()
                            };

                            daftarDokter.Add(dokter);
                        }
                    }
                }
            }

            return daftarDokter;
        }

        public void UpdateDokter(Dokter dokter)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE dokter SET nama = @Nama, spesialis = @Spesialis, gender = @Gender, alamat = @Alamat WHERE id_dokter = @IdDokter;";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdDokter", dokter.Id_dokter);
                    command.Parameters.AddWithValue("@Nama", dokter.Nama);
                    command.Parameters.AddWithValue("@Spesialis", dokter.Spesialis);
                    command.Parameters.AddWithValue("@Gender", dokter.Gender);
                    command.Parameters.AddWithValue("@Alamat", dokter.Alamat);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void HapusDokter(int idDokter)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM dokter WHERE id_dokter = @IdDokter;";

                using (var command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdDokter", idDokter);

                    command.ExecuteNonQuery();
                }
            }
        }

        public Dokter AmbilDokterBerdasarkanId(int idDokter)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM dokter WHERE id_dokter = @IdDokter;";
                Dokter dokter = null;

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdDokter", idDokter);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dokter = new Dokter
                            {
                                Id_dokter = Convert.ToInt32(reader["id_dokter"]),
                                Nama = reader["nama"].ToString(),
                                Spesialis = reader["spesialis"].ToString(),
                                Gender = reader["gender"].ToString(),
                                Alamat = reader["alamat"].ToString()
                            };
                        }
                    }
                }
                return dokter;
            }
        }
        public List<Dokter> AmbilDokterBerdasarkanNama(string nama)
        {
            List<Dokter> daftarDokter = new List<Dokter>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM dokter WHERE nama = @Nama;";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Nama", nama);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dokter dokter = new Dokter
                            {
                                Id_dokter = Convert.ToInt32(reader["id_dokter"]),
                                Nama = reader["nama"].ToString(),
                                Spesialis = reader["spesialis"].ToString(),
                                Gender = reader["gender"].ToString(),
                                Alamat = reader["alamat"].ToString()
                            };

                            daftarDokter.Add(dokter);
                        }
                    }
                }
            }

            return daftarDokter;
        }

    }
}

