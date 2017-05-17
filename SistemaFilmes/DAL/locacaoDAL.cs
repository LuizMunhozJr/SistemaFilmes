using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using System.Configuration;


namespace DAL
{
    public class locacaoDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDVideolandiaConnectionString"].ConnectionString;

        public Locacao SelecionarLocacaoPeloCodigo(int codigo)
        {
            Locacao l = null;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Locacoes WHERE cdLocacao = @codigo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", codigo);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows && dr.Read())
                {
                    l = new Locacao();
                    l.cdLocacao = codigo;
                    l.cdFunc = Convert.ToInt32(dr["cdFunc"]);
                    l.cdFilme = Convert.ToInt32(dr["cdFilme"]);
                    l.cdCli = Convert.ToInt32(dr["cdCli"]);
                    l.dtRetirada = Convert.ToDateTime(dr["dtRetirada"]);
                    l.dtDevolucao = Convert.ToDateTime(dr["dtDevolucao"]); 
                    // l.StatusPG = dr["StatusPG"].ToString();
                    //l.qdteFilmesLocados = dr.HasRows

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

            return l;
        }




    }
}
