using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class artistaDAL
    {

            string connectionString = ConfigurationManager.ConnectionStrings["BDVideolandiaConnectionString"].ConnectionString;

            
            public void InserirArtista(Artista objArtista)
            {

                SqlConnection conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();

                    string sql = "INSERT INTO Artistas VALUES (@nmArt, @dtArt, @natuArt, @imgArt)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nmArt", objArtista.Nome);
                    cmd.Parameters.AddWithValue("@dtArt", objArtista.DtNascto);
                    cmd.Parameters.AddWithValue("@natuArt", objArtista.Naturalidade);
                    cmd.Parameters.AddWithValue("@imgArt", objArtista.Imagem);

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

            public List<Artista> ListarArtistas()
            {
                List<Artista> lista = new List<Artista>();

                SqlConnection conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();

                    string sql = "SELECT * FROM Artistas";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        Artista a = null;
                        while (dr.Read())
                        {
                            a = new Artista();
                            a.Codigo = Convert.ToInt32(dr["cdArt"]);
                            a.Nome = dr["nmArt"].ToString();
                            a.DtNascto = Convert.ToDateTime(dr["dtArt"]);
                            a.Naturalidade = dr["natuArt"].ToString();
                            a.Imagem = (byte[])(dr["imgArt"]);
                           

                            lista.Add(a);
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

            
            public Artista BuscarArtista(int cod)
            {
                Artista a = null;

                SqlConnection conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();

                    string sql = "SELECT * FROM Artistas WHERE cdArt = @codigo";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@codigo", cod);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows && dr.Read())
                    {
                    a = new Artista();
                    a.Codigo = Convert.ToInt32(dr["cdArt"]);
                    a.Nome = dr["nmArt"].ToString();
                    a.DtNascto = Convert.ToDateTime(dr["dtArt"]);
                    a.Naturalidade = dr["natuArt"].ToString();
                    a.Imagem = (byte[]) (dr["imgArt"]);
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

                return a;
            }

            
            public void AlteraArtista(Artista objArtista)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();

                    string sql = "UPDATE Artistas SET nmArt=@nmArt, dtArt=@dtArt, natuArt=@natuArt, imgArt=@imgArt";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nmArt", objArtista.Nome);
                    cmd.Parameters.AddWithValue("@dtArt", objArtista.DtNascto);
                    cmd.Parameters.AddWithValue("@natuArt", objArtista.Naturalidade);
                    cmd.Parameters.AddWithValue("@imgArt", objArtista.Imagem);

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

            
            public void ExcluirArtista(int codigo)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();

                    string sql = "DELETE FROM Artistas WHERE cdArt = @codigo";
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
        public List<Item> SelecionarItensDoArtista(int codigo)
        {
            List<Item> lista = new List<Item>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                string sql = "select * from Itens where cdItem = (select cdItem from Participacoes where cdArt = @codigo)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", codigo);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Item i;
                    while (dr.Read())
                    {
                        i = new Item();
                        i.Codigo = Convert.ToInt32(dr["cdFilme"]);
                        i.CodigoDeBarras = dr["cddbarFilme"].ToString();
                        i.Descricao = dr["dsFilme"].ToString();
                        i.Preco = Convert.ToDecimal(dr["precoFilme"]);

                        lista.Add(i);
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

    }
}

