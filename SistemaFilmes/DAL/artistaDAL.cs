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

                    string sql = "INSERT INTO Artistas VALUES (@nmFunc, @dtFunc, @sxFunc, @ecFunc, @rgFunc, @cpfFunc, @endFunc, @cidFunc, @cepFunc, @ufFunc, @telFunc, @celFunc, @emailFunc, @stsFunc)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nmFunc", objArtista.Nome);
                    cmd.Parameters.AddWithValue("@dtFunc", objArtista.DtNascto);
                    cmd.Parameters.AddWithValue("@sxFunc", objArtista.Sexo);
                    cmd.Parameters.AddWithValue("@ecFunc", objArtista.EstadoCivil);
                    cmd.Parameters.AddWithValue("@rgFunc", objArtista.RG);
                    cmd.Parameters.AddWithValue("@cpfFunc", objArtista.CPF);
                    cmd.Parameters.AddWithValue("@endFunc", objArtista.Endereco);
                    cmd.Parameters.AddWithValue("@cidFunc", objArtista.Cidade);
                    cmd.Parameters.AddWithValue("@cepFunc", objArtista.CEP);
                    cmd.Parameters.AddWithValue("@ufFunc", objArtista.UF);
                    cmd.Parameters.AddWithValue("@telFunc", objArtista.TEL);
                    cmd.Parameters.AddWithValue("@celFunc", objArtista.CEL);
                    cmd.Parameters.AddWithValue("@emailFunc", objArtista.Email);
                    cmd.Parameters.AddWithValue("@stsFunc", objArtista.Status);

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
                        Artista f = null;
                        while (dr.Read())
                        {
                            f = new Artista();
                            f.Codigo = Convert.ToInt32(dr["CdArtista"]);
                            f.Nome = dr["nmFunc"].ToString();
                            f.DtNascto = Convert.ToDateTime(dr["dtFunc"]);
                            f.Sexo = dr["sxFunc"].ToString();
                            f.EstadoCivil = dr["ecFunc"].ToString();
                            f.RG = dr["rgFunc"].ToString();
                            f.CPF = dr["cpfFunc"].ToString();
                            f.Endereco = dr["endFunc"].ToString();
                            f.Cidade = dr["cidFunc"].ToString();
                            f.CEP = dr["cepFunc"].ToString();
                            f.UF = dr["ufFunc"].ToString();
                            f.TEL = dr["telFunc"].ToString();
                            f.CEL = dr["celFunc"].ToString();
                            f.Email = dr["emailFunc"].ToString();
                            f.Status = Convert.ToBoolean(dr["stsFunc"]);

                            lista.Add(f);
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
            public Artista BuscarArtista(int cod)
            {
                Artista F = null;

                SqlConnection conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();

                    string sql = "SELECT * FROM Artistas WHERE cdFunc = @codigo";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@codigo", cod);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows && dr.Read())
                    {
                        F = new Artista();
                        F.CEL = dr["celFunc"].ToString();
                        F.CEP = dr["cepFunc"].ToString();
                        F.Cidade = dr["cidFunc"].ToString();
                        F.CPF = dr["cpfFunc"].ToString();
                        F.DtNascto = Convert.ToDateTime(dr["dtFunc"].ToString());
                        F.Email = dr["emailFunc"].ToString();
                        F.Endereco = dr["endFunc"].ToString();
                        F.EstadoCivil = dr["ecFunc"].ToString();
                        F.Nome = dr["nmFunc"].ToString();
                        F.RG = dr["rgFunc"].ToString();
                        F.Sexo = dr["sxFunc"].ToString();
                        F.Status = Convert.ToBoolean(dr["stsFunc"].ToString());
                        F.TEL = dr["telFunc"].ToString();
                        F.UF = dr["ufFunc"].ToString();
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

                return F;
            }

            //DONE
            public void AlteraArtista(Artista objArtista)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();

                    string sql = "UPDATE Artistas SET nmFunc=@nmFunc, dtFunc=@dtFunc, sxFunc=@sxFunc, ecFunc=@ecFunc, rgFunc=@rgFunc, cpfFunc=@cpfFunc, endFunc=@endFunc, cidFunc=@cidFunc, cepFunc=@cepFunc, ufFunc=@ufFunc, telFunc=@telFunc, celFunc=@celFunc, emailFunc=@emailFunc, stsFunc=@stsFunc WHERE cdFunc =@cdFunc";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@cdFunc", objArtista.Codigo);
                    cmd.Parameters.AddWithValue("@nmFunc", objArtista.Nome);
                    cmd.Parameters.AddWithValue("@dtFunc", objArtista.DtNascto);
                    cmd.Parameters.AddWithValue("@sxFunc", objArtista.Sexo);
                    cmd.Parameters.AddWithValue("@ecFunc", objArtista.EstadoCivil);
                    cmd.Parameters.AddWithValue("@rgFunc", objArtista.RG);
                    cmd.Parameters.AddWithValue("@cpfFunc", objArtista.CPF);
                    cmd.Parameters.AddWithValue("@endFunc", objArtista.Endereco);
                    cmd.Parameters.AddWithValue("@cidFunc", objArtista.Cidade);
                    cmd.Parameters.AddWithValue("@cepFunc", objArtista.CEP);
                    cmd.Parameters.AddWithValue("@ufFunc", objArtista.UF);
                    cmd.Parameters.AddWithValue("@telFunc", objArtista.TEL);
                    cmd.Parameters.AddWithValue("@celFunc", objArtista.CEL);
                    cmd.Parameters.AddWithValue("@emailFunc", objArtista.Email);
                    cmd.Parameters.AddWithValue("@stsFunc", objArtista.Status);
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
            public void ExcluirArtista(int codigo)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();

                    string sql = "DELETE FROM Artistas WHERE cdFunc = @codigo";
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
}
