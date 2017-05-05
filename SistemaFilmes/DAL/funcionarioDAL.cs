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
       
        string connectionString = ConfigurationManager.ConnectionStrings["BDZikaConnectionString"].ConnectionString;

        public void InserirFuncionario(Funcionario objfuncionario)
        {
           
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INTO Funcionarios VALUES (@nome, @dtFunc, @sxFunc, @ecFunc, @rgFunc, @cpfFunc, @endFunc, @cidFunc, @cepFunc, @ufFunc, @telFunc, @celFunc, @emailFunc, @stsFunc)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", objfuncionario.Nome);
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
                    /*
                    Funcionario f = null;
                    while (dr.Read())
                    {
                        f = new Funcionario();
                        f.Codigo = Convert.ToInt32(dr["CdFuncionario"]);
                        f.Nome = dr["NmFuncionario"].ToString();
                        f.DsEmail = dr["DsEmail"].ToString();
                        f.DsSexo = dr["DsSexo"].ToString();
                        f.DsEstadoCivil = dr["DsEstadoCivil"].ToString();
                        f.BtRecebeSMS = Convert.ToBoolean(dr["BtRecebeSMS"]);
                        f.BtRecebeEmail = Convert.ToBoolean(dr["BtRecebeEmail"]);

                        lista.Add(p);
                        */
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
