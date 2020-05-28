using System;
using System.Data;
using Npgsql;

namespace HUGO
{
    public static class ConectionDb
    {
        private static String _host = "127.0.0.1",
            _database = "Parcial02_Hugo",
            _userId = "postgres",
            _password = "128506";
                
        private static string _sConnection =
            String.Format("Host={host};Port=5432;User Id={userId};" +
                          "Password={password};Database={database};");
        // $"sslmode=Require;Trust Server Certificate=true";

        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(_sConnection);
            DataSet ds = new DataSet();
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            connection.Close();
            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string act)
        {
            Console.WriteLine(_sConnection);
            NpgsqlConnection connection = new NpgsqlConnection(_sConnection);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}