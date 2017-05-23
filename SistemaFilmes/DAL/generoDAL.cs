using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class generoDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDVideolandiaConnectionString"].ConnectionString;

        //DONE
        public void InserirGenero(Genero objGenero)
        {

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INTO Generos VALUES (@nmGen)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nmGen", objGenero.Nome);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
        public void InserirGeneroItem(int codItem,int CodGen)
        {

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INTO GenerosItem VALUES (@cditem,@cdGen)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cditem", codItem);
                cmd.Parameters.AddWithValue("@cdGen", CodGen);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        public List<Genero> ListarGeneros()
        {
            List<Genero> lista = new List<Genero>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Generos";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    Genero G = null;
                    while (dr.Read())
                    {
                        G = new Genero();
                        G.Codigo = Convert.ToInt32(dr["cdGen"]);
                        G.Nome = dr["nmGen"].ToString();                        

                        lista.Add(G);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }

            return lista;
        }

        //DONE
        public Genero BuscarGenero(int cod)
        {
            Genero G = null;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Generos WHERE cdGen = @codigo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", cod);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows && dr.Read())
                {
                    G = new Genero();
                    G.Nome = dr["nmGen"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }

            return G;
        }

        //DONE
        public void AlterarGenero(Genero objGenero)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "UPDATE Generos SET nmGen=@nomeGen WHERE cdGen =@cdGen";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nomeGen", objGenero.Nome);
                cmd.Parameters.AddWithValue("@cdGen", objGenero.Codigo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        //DONE
        public void ExcluirGenero(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "DELETE FROM Generos WHERE cdGen = @codigo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", codigo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
