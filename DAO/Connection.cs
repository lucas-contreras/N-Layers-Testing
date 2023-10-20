using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Runtime.CompilerServices;

namespace DAO
{
    public class Connection
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["appdb"].ConnectionString;

        public static DataTable ExecuteReader(string query, OleDbParameter[]? parameters = null)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand(query);
                command.Connection = conn;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                OleDbDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                reader.Close();
                return dt;
            }
        }

        public async static Task<DataTable> ExecuteReaderAsync(string query, OleDbParameter[]? parameters = null)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand(query);
                command.Connection = conn;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                DbDataReader reader = await command.ExecuteReaderAsync();

                DataTable dt = new DataTable();
                dt.Load(reader);

                reader.Close();
                return dt;
            }
        }
        public static bool ExecuteNonQuery(string query, OleDbParameter[] parameters)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand(query);

                command.Connection = conn;
                command.Parameters.AddRange(parameters);

                int rowAffected = command.ExecuteNonQuery();

                return rowAffected > 0;
            }
        }
    }
}