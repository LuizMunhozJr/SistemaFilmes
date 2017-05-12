using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class ItemDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDVideolandiaConnectionString"].ConnectionString;

        public List<Item> SelecionarTodosItensPedido(int codigo)
        {
            List<Item> lista = new List<Item>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                string sql = "select * from Filmes where cdFilme = (select cdFilme from ItemLocacao where cdLocacao = @codigo)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Item i;
                    while (dr.Read())
                    {
                        i = new Item();
                        i.Codigo = Convert.ToInt32(dr["cdFilme"]);
                        i.CodigoDeBarras = Convert.ToInt32(dr["cddbarFilme"]);
                        i.Descricao = dr["dsFilme"].ToString();
                        i.Preco = Convert.ToDecimal( dr["precoFilme"]);

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
