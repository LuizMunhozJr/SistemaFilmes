using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class clienteDAL
    {

        string connectionString = ConfigurationManager.ConnectionStrings["BDVideolandiaConnectionString"].ConnectionString;

        //DONE
        public void InserirCliente(Cliente objcliente)
        {

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INTO Clientes VALUES (@nmCli, @dtCli, @sxCli, @ecCli, @rgCli, @cpfCli, @endCli, @cidCli, @cepCli, @ufCli, @telCli, @celCli, @emailCli, @stsCli)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nmCli", objcliente.Nome);
                cmd.Parameters.AddWithValue("@dtCli", objcliente.DtNascto);
                cmd.Parameters.AddWithValue("@sxCli", objcliente.Sexo);
                cmd.Parameters.AddWithValue("@ecCli", objcliente.EstadoCivil);
                cmd.Parameters.AddWithValue("@rgCli", objcliente.RG);
                cmd.Parameters.AddWithValue("@cpfCli", objcliente.CPF);
                cmd.Parameters.AddWithValue("@endCli", objcliente.Endereco);
                cmd.Parameters.AddWithValue("@cidCli", objcliente.Cidade);
                cmd.Parameters.AddWithValue("@cepCli", objcliente.CEP);
                cmd.Parameters.AddWithValue("@ufCli", objcliente.UF);
                cmd.Parameters.AddWithValue("@telCli", objcliente.TEL);
                cmd.Parameters.AddWithValue("@celCli", objcliente.CEL);
                cmd.Parameters.AddWithValue("@emailCli", objcliente.Email);
                cmd.Parameters.AddWithValue("@stsCli", objcliente.Status);

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

        public List<Cliente> ListarClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Clientes";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    Cliente f = null;
                    while (dr.Read())
                    {
                        f = new Cliente();
                        f.Codigo = Convert.ToInt32(dr["Cdcliente"]);
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
        public Cliente BuscarCliente(int cod)
        {
            Cliente C = null;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM clientes WHERE cdCli = @codigo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", cod);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows && dr.Read())
                {
                    C = new Cliente();
                    C.CEL = dr["celCli"].ToString();
                    C.CEP = dr["cepCli"].ToString();
                    C.Cidade = dr["cidCli"].ToString();
                    C.CPF = dr["cpfCli"].ToString();
                    C.DtNascto = Convert.ToDateTime(dr["dtCli"].ToString());
                    C.Email = dr["emailCli"].ToString();
                    C.Endereco = dr["endCli"].ToString();
                    C.EstadoCivil = dr["ecCli"].ToString();
                    C.Nome = dr["nmCli"].ToString();
                    C.RG = dr["rgCli"].ToString();
                    C.Sexo = dr["sxCli"].ToString();
                    C.Status = Convert.ToBoolean(dr["stsCli"].ToString());
                    C.TEL = dr["telCli"].ToString();
                    C.UF = dr["ufCli"].ToString();
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

            return C;
        }
        public Cliente BuscarClienteCPF(string cpf)
        {
            Cliente C = null;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM clientes WHERE cpfCli = @CPF";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CPF", cpf);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows && dr.Read())
                {
                    C = new Cliente();
                    C.CEL = dr["celCli"].ToString();
                    C.CEP = dr["cepCli"].ToString();
                    C.Cidade = dr["cidCli"].ToString();
                    C.CPF = dr["cpfCli"].ToString();
                    C.DtNascto = Convert.ToDateTime(dr["dtCli"].ToString());
                    C.Email = dr["emailCli"].ToString();
                    C.Endereco = dr["endCli"].ToString();
                    C.EstadoCivil = dr["ecCli"].ToString();
                    C.Nome = dr["nmCli"].ToString();
                    C.RG = dr["rgCli"].ToString();
                    C.Sexo = dr["sxCli"].ToString();
                    C.Status = Convert.ToBoolean(dr["stsCli"].ToString());
                    C.TEL = dr["telCli"].ToString();
                    C.UF = dr["ufCli"].ToString();
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

            return C;
        }

        //DONE
        public void AlterarCliente(Cliente objcliente)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "UPDATE clientes SET nmCli=@nmCli, dtCli=@dtCli, sxCli=@sxCli, ecCli=@ecCli, rgCli=@rgCli, cpfCli=@cpfCli, endCli=@endCli, cidCli=@cidCli, cepCli=@cepCli, ufCli=@ufCli, telCli=@telCli, celCli=@celCli, emailCli=@emailCli, stsCli=@stsCli WHERE cdCli =@cdCli";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cdCli", objcliente.Codigo);
                cmd.Parameters.AddWithValue("@nmCli", objcliente.Nome);
                cmd.Parameters.AddWithValue("@dtCli", objcliente.DtNascto);
                cmd.Parameters.AddWithValue("@sxCli", objcliente.Sexo);
                cmd.Parameters.AddWithValue("@ecCli", objcliente.EstadoCivil);
                cmd.Parameters.AddWithValue("@rgCli", objcliente.RG);
                cmd.Parameters.AddWithValue("@cpfCli", objcliente.CPF);
                cmd.Parameters.AddWithValue("@endCli", objcliente.Endereco);
                cmd.Parameters.AddWithValue("@cidCli", objcliente.Cidade);
                cmd.Parameters.AddWithValue("@cepCli", objcliente.CEP);
                cmd.Parameters.AddWithValue("@ufCli", objcliente.UF);
                cmd.Parameters.AddWithValue("@telCli", objcliente.TEL);
                cmd.Parameters.AddWithValue("@celCli", objcliente.CEL);
                cmd.Parameters.AddWithValue("@emailCli", objcliente.Email);
                cmd.Parameters.AddWithValue("@stsCli", objcliente.Status);
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
        public void ExcluirCliente(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "DELETE * FROM Clientes WHERE cdCli = @codigo";
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
