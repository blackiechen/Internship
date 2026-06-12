using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class DB_DAL
    {
        static string connectionString = @"Data Source=LAPTOP-HF6A7IKE\SQLEXPRESS;" +
                                        "Initial Catalog=ClubeR;" +
                                        "Integrated Security=sspi;";

        public static string ConnectionString { get => connectionString; }

        public static void ExecutarComando(string query)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
                    sqlconn.Open();

                    sqlcmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static DataTable ConsultarDados(string query)
        {
            DataTable dt = null;

            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
                    sqlconn.Open();

                    SqlDataReader sdr = sqlcmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        dt = new DataTable();
                        dt.Load(sdr);
                    }
                    sdr.Close();
                }
                catch (SqlException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return dt;
        }

        public static int ExecutarEscalar(string query)
        {
            int valor;

            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
                    sqlconn.Open();

                    valor = (int)sqlcmd.ExecuteScalar();
                }
                catch (SqlException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
                return valor;
            }
        }
    }
}
