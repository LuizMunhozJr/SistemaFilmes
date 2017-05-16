using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class funcionarioDAL
    {
       
        string connectionString = ConfigurationManager.ConnectionStrings["BDVideolandiaConnectionString"].ConnectionString;

        //DONE
        public void InserirFuncionario(Funcionario objfuncionario)
        {
           
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INTO Funcionarios VALUES (@nmFunc, @dtFunc, @sxFunc, @ecFunc, @rgFunc, @cpfFunc, @endFunc, @cidFunc, @cepFunc, @ufFunc, @telFunc, @celFunc, @emailFunc, @stsFunc)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nmFunc", objfuncionario.Nome);
                cmd.Parameters.AddWithValue("@dtFunc", objfuncionario.DtNascto);
                cmd.Parameters.AddWithValue("@sxFunc", objfuncionario.Sexo);
                cmd.Parameters.AddWithValue("@ecFunc", objfuncionario.EstadoCivil);
                cmd.Parameters.AddWithValue("@rgFunc", objfuncionario.RG);
                cmd.Parameters.AddWithValue("@cpfFunc", objfuncionario.CPF);
                cmd.Parameters.AddWithValue("@endFunc", objfuncionario.Endereco);
                cmd.Parameters.AddWithValue("@cidFunc", objfuncionario.Cidade);
                cmd.Parameters.AddWithValue("@cepFunc", objfuncionario.CEP);
                cmd.Parameters.AddWithValue("@ufFunc", objfuncionario.UF);
                cmd.Parameters.AddWithValue("@telFunc", objfuncionario.TEL);
                cmd.Parameters.AddWithValue("@celFunc", objfuncionario.CEL);
                cmd.Parameters.AddWithValue("@emailFunc", objfuncionario.Email);
                cmd.Parameters.AddWithValue("@stsFunc", objfuncionario.Status);

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

        public List<Funcionario> ListarFuncionarios()
        {
            List<Funcionario> lista = new List<Funcionario>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Funcionarios";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {                    
                    Funcionario f = null;
                    while (dr.Read())
                    {
                        f = new Funcionario();
                        f.Codigo = Convert.ToInt32(dr["CdFuncionario"]);
                        f.Nome = dr["nmFunc"].ToString();
                        f.DtNascto = Convert.ToDateTime(dr["dtFunc"]);
                        f.Sexo = dr["sxFunc"].ToString();
                        f.EstadoCivil= dr["ecFunc"].ToString();
                        f.RG= dr["rgFunc"].ToString();
                        f.CPF= dr["cpfFunc"].ToString();
                        f.Endereco= dr["endFunc"].ToString();
                        f.Cidade= dr["cidFunc"].ToString();
                        f.CEP= dr["cepFunc"].ToString();
                        f.UF= dr["ufFunc"].ToString();
                        f.TEL= dr["telFunc"].ToString();
                        f.CEL= dr["celFunc"].ToString();
                        f.Email= dr["emailFunc"].ToString();
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
        public Funcionario BuscarFuncionario(int cod)
        {
            Funcionario F = null;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Funcionarios WHERE cdFunc = @codigo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", cod);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows && dr.Read())
                {
                    F = new Funcionario();
                    F.CEL = dr["celFunc"].ToString();
                    F.CEP= dr["cepFunc"].ToString();
                    F.Cidade= dr["cidFunc"].ToString();                    
                    F.CPF= dr["cpfFunc"].ToString();
                    F.DtNascto= Convert.ToDateTime(dr["dtFunc"].ToString());
                    F.Email= dr["emailFunc"].ToString();
                    F.Endereco= dr["endFunc"].ToString();
                    F.EstadoCivil= dr["ecFunc"].ToString();
                    F.Nome= dr["nmFunc"].ToString();
                    F.RG= dr["rgFunc"].ToString();
                    F.Sexo= dr["sxFunc"].ToString();
                    F.Status= Convert.ToBoolean(dr["stsFunc"].ToString());
                    F.TEL= dr["telFunc"].ToString();
                    F.UF= dr["ufFunc"].ToString();
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
        public void AlteraFuncionario(Funcionario objfuncionario)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "UPDATE Funcionarios SET nmFunc=@nmFunc, dtFunc=@dtFunc, sxFunc=@sxFunc, ecFunc=@ecFunc, rgFunc=@rgFunc, cpfFunc=@cpfFunc, endFunc=@endFunc, cidFunc=@cidFunc, cepFunc=@cepFunc, ufFunc=@ufFunc, telFunc=@telFunc, celFunc=@celFunc, emailFunc=@emailFunc, stsFunc=@stsFunc WHERE cdFunc =@cdFunc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cdFunc", objfuncionario.Codigo);
                cmd.Parameters.AddWithValue("@nmFunc", objfuncionario.Nome);
                cmd.Parameters.AddWithValue("@dtFunc", objfuncionario.DtNascto);
                cmd.Parameters.AddWithValue("@sxFunc", objfuncionario.Sexo);
                cmd.Parameters.AddWithValue("@ecFunc", objfuncionario.EstadoCivil);
                cmd.Parameters.AddWithValue("@rgFunc", objfuncionario.RG);
                cmd.Parameters.AddWithValue("@cpfFunc", objfuncionario.CPF);
                cmd.Parameters.AddWithValue("@endFunc", objfuncionario.Endereco);
                cmd.Parameters.AddWithValue("@cidFunc", objfuncionario.Cidade);
                cmd.Parameters.AddWithValue("@cepFunc", objfuncionario.CEP);
                cmd.Parameters.AddWithValue("@ufFunc", objfuncionario.UF);
                cmd.Parameters.AddWithValue("@telFunc", objfuncionario.TEL);
                cmd.Parameters.AddWithValue("@celFunc", objfuncionario.CEL);
                cmd.Parameters.AddWithValue("@emailFunc", objfuncionario.Email);
                cmd.Parameters.AddWithValue("@stsFunc", objfuncionario.Status);
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
        public void ExcluirFuncionario(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "DELETE FROM Funcionarios WHERE cdFunc = @codigo";
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
