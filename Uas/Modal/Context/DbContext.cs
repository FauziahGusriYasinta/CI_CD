using System;
using System.Data;
using System.Data.SQLite;

namespace finalprojek.Model.Context
{
    public class DbContext : IDisposable
    {
        private SQLiteConnection _conn;

        public SQLiteConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null;
            try
            {
                string dbName = @"C:\uas\Uas\Uas\Modal\DbTugasAkhir.db";
                string connectionString = $"Data Source={dbName};Version=3;Pooling=True;Max Pool Size=100;";
                conn = new SQLiteConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                // Anda dapat mengganti Debug.Print dengan metode lain untuk menangani kesalahan
                // atau melakukan logging yang lebih baik.
                Console.WriteLine($"Open Connection Error: {ex.Message}");
            }
            return conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed)
                        _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }
    }
}

//C:\uas\Uas\Uas\Modal\DbTugasAkhir.db