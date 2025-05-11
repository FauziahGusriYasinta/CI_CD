using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uas.Model.Entity;

namespace Uas.Modal.Repository
{
    public class RepositoryKaryawan
    {
        private string connectionString = @"C:\uas\Uas\Uas\Modal\DbTugasAkhir.db;Version=3;";

        public void TambahKaryawan(Karyawan karyawan)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO karyawan (nama, bagian_kerja, gender, alamat) VALUES (@Nama, @BagianKerja, @Gender, @Alamat);";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Nama", karyawan.Nama);
                    command.Parameters.AddWithValue("@BagianKerja", karyawan.Bagian_kerja);
                    command.Parameters.AddWithValue("@Gender", karyawan.Gender);
                    command.Parameters.AddWithValue("@Alamat", karyawan.Alamat);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Karyawan> AmbilSemuaKaryawan()
        {
            List<Karyawan> daftarKaryawan = new List<Karyawan>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM karyawan;";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Karyawan karyawan = new Karyawan
                            {
                                Id_karyawan = Convert.ToInt32(reader["id_karyawan"]),
                                Nama = reader["nama"].ToString(),
                                Bagian_kerja = reader["bagian_kerja"].ToString(),
                                Gender = reader["gender"].ToString(),
                                Alamat = reader["alamat"].ToString()
                            };

                            daftarKaryawan.Add(karyawan);
                        }
                    }
                }
            }

            return daftarKaryawan;
        }

        public void UpdateKaryawan(Karyawan karyawan)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE karyawan SET nama = @Nama, bagian_kerja = @BagianKerja, gender = @Gender, alamat = @Alamat WHERE id_karyawan = @IdKaryawan;";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdKaryawan", karyawan.Id_karyawan);
                    command.Parameters.AddWithValue("@Nama", karyawan.Nama);
                    command.Parameters.AddWithValue("@BagianKerja", karyawan.Bagian_kerja);
                    command.Parameters.AddWithValue("@Gender", karyawan.Gender);
                    command.Parameters.AddWithValue("@Alamat", karyawan.Alamat);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void HapusKaryawan(int idKaryawan)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM karyawan WHERE id_karyawan = @IdKaryawan;";

                using (var command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdKaryawan", idKaryawan);

                    command.ExecuteNonQuery();
                }
            }
        }

        public Karyawan AmbilKaryawanBerdasarkanId(int idKaryawan)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM karyawan WHERE id_karyawan = @IdKaryawan;";
                Karyawan karyawan = null;

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdKaryawan", idKaryawan);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            karyawan = new Karyawan
                            {
                                Id_karyawan = Convert.ToInt32(reader["id_karyawan"]),
                                Nama = reader["nama"].ToString(),
                                Bagian_kerja = reader["bagian_kerja"].ToString(),
                                Gender = reader["gender"].ToString(),
                                Alamat = reader["alamat"].ToString()
                            };
                        }
                    }
                }

                return karyawan;
            }
        }

        public List<Karyawan> AmbilKaryawanBerdasarkanNama(string nama)
        {
            List<Karyawan> daftarKaryawan = new List<Karyawan>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM karyawan WHERE nama = @Nama;";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Nama", nama);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Karyawan karyawan = new Karyawan
                            {
                                Id_karyawan = Convert.ToInt32(reader["id_karyawan"]),
                                Nama = reader["nama"].ToString(),
                                Bagian_kerja = reader["bagian_kerja"].ToString(),
                                Gender = reader["gender"].ToString(),
                                Alamat = reader["alamat"].ToString()
                            };

                            daftarKaryawan.Add(karyawan);
                        }
                    }
                }
            }

            return daftarKaryawan;
        }
    }
}