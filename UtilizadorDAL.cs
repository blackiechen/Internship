using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataEntity;

namespace DataAcess
{
   public class UtilizadorDAL
   {
        public static void InserirUtilizador(Login login)
        {
            using (SqlConnection connection = new SqlConnection(DB_DAL.ConnectionString))
            {

                try
                {
                    string queryIns = "Insert into LoginPrograma (username, nomeU, codigo, acesso, escalao) " +
                       "Values (@username, @nomeU, @codigo, @acesso, @escalao);";

                    SqlCommand cmd = new SqlCommand(queryIns, connection);
                    connection.Open();

                    SqlParameter paramNome = new SqlParameter("@username", login.Username);
                    cmd.Parameters.Add(paramNome);

                    SqlParameter paramuser = new SqlParameter("@nomeU", login.NomeUser);
                    cmd.Parameters.Add(paramuser);

                    SqlParameter paramucod = new SqlParameter("@codigo", login.Codigo);
                    cmd.Parameters.Add(paramucod);

                    SqlParameter paramAcesso = new SqlParameter("@acesso", login.Acesso);
                    cmd.Parameters.Add(paramAcesso);

                    SqlParameter paramEscalao = new SqlParameter("@escalao", login.Escalao);
                    cmd.Parameters.Add(paramEscalao);

                    cmd.ExecuteNonQuery();
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
        public static int ContarUtilizadoresNome(string Nome)
        {
            int qtdUtilizadores;

            using (SqlConnection connection = new SqlConnection(DB_DAL.ConnectionString))
            {
                try
                {
                    string query = "Select count(*) from LoginPrograma where username = @username;";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();

                    SqlParameter paramNome = new SqlParameter("@username", Nome);
                    cmd.Parameters.Add(paramNome);


                    qtdUtilizadores = (int)cmd.ExecuteScalar();
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
            return qtdUtilizadores;
        }

        public static int ConsultarTipo(string user)
        {
            int tipo;

            using (SqlConnection connection = new SqlConnection(DB_DAL.ConnectionString))
            {
                string query = "select acesso from LoginPrograma where username = @user";

                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();

                SqlParameter paramUsername =
                            new SqlParameter("@user", user);
                cmd.Parameters.Add(paramUsername);

                tipo = (int)cmd.ExecuteScalar();
            }
            return tipo;
        }

        public static int ContarUtilizadoresNomePin(string Nome, int pin)
        {

            int qtdUtilizadores;

            using (SqlConnection connection = new SqlConnection(DB_DAL.ConnectionString))
            {
                try
                {
                    string query = "Select count(*) from LoginPrograma where username=@nomeUser and codigo=@pin;";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();

                    SqlParameter paramNome = new SqlParameter("@nomeUser", Nome);
                    cmd.Parameters.Add(paramNome);
                    SqlParameter paramPin = new SqlParameter("@pin", pin);
                    cmd.Parameters.Add(paramPin);

                    qtdUtilizadores = (int)cmd.ExecuteScalar();

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
            return qtdUtilizadores;

        }


    }
}
