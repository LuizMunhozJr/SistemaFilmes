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

        public List<Item> SelecionarTodosItensNumeroPedido(int codigo)
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
        public void InserirLocacao(Locacao objLoc)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

                string sql = "INSERT INTO Locacoes VALUES (@cdCli, @cdFun, @dtRetirada)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cdCli", objLoc.cdCli);
                cmd.Parameters.AddWithValue("@cdFun", objLoc.cdFunc);
                cmd.Parameters.AddWithValue("@dtRetirada", objLoc.dtRetirada);

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
        public void InserirItensLocacao(ItemLocacao objItemLoc)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

                string sql = "INSERT INTO ItemLocacao VALUES (@cdLocacao, @cdItem,@statusPG,@dtDevolucao)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cdLocacao", objItemLoc.cdLocacao);
                cmd.Parameters.AddWithValue("@cdItem", objItemLoc.cdItem);
                cmd.Parameters.AddWithValue("@statusPG", "NÃO PAGO");
                cmd.Parameters.AddWithValue("@dtDevolucao", objItemLoc.dtDevolucao);

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
        public int BuscarCodUltimaLocacao()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            int codigo = 0;
            try
            {
                conn.Open();

                string sql = "select top 1 cdLocacao from Locacoes order by cdLocacao desc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows && dr.Read())
                {
                    codigo = Convert.ToInt32(dr["cdLocacao"]);
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

            return codigo;
        }
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
                    //l.cdFilme = Convert.ToInt32(dr["cdFilme"]);
                    l.cdCli = Convert.ToInt32(dr["cdCli"]);
                    l.dtRetirada = Convert.ToDateTime(dr["dtRetirada"]);
                    //l.dtDevolucao = Convert.ToDateTime(dr["dtDevolucao"]); 
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
        public ItemDevolucao SelecionarItemDevolucaoCodBar(string codigo)
         {
             SqlConnection conn = new SqlConnection(connectionString);
            ItemDevolucao i = new ItemDevolucao();
             try
             {
                 conn.Open();
                 string sql = "Select I.cdItem,I.cddbarItem,I.dsItem,I.precoItem,IL.statusPG,IL.dtDevolucao,IL.CodLocacao from Itens I inner join ItemLocacao IL ON( I.cdItem = IL.cdItem) WHERE cddbarItem = @codigo";
                 SqlCommand cmd = new SqlCommand(sql, conn);
 
                 SqlDataReader dr = cmd.ExecuteReader();
                 if (dr.HasRows)
                 {
                     
                     while (dr.Read())
                     {
                         i = new ItemDevolucao();
                         i.cdItem = Convert.ToInt32(dr["I.cdItem"]);
                         i.cddbarItem = dr["I.cddbarItem"].ToString();
                         i.dsItem = dr["I.dsItem"].ToString();
                         i.precoItem = Convert.ToDecimal(dr["I.precoItem"]);
                         i.statusPG = dr["IL.statusPG"].ToString();
                         i.dtDevolucao = Convert.ToDateTime(dr["IL.dtDevolucao"]);
                         i.cdLocacao = Convert.ToInt32(dr["IL.cdLocacao"]);
 
 
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
 
             return i;
         }
        public void ConfirmaPagamento(int cdItem, int cdLocacao)
         {
             SqlConnection conn = new SqlConnection(connectionString);
             try
             {
                 conn.Open();
 
                 string sql = "UPDATE Locacoes SET statusPG = @statusPG, dtDevolucao=@dtDevolucao WHERE cdLocacao = @cdLocacao AND cdItem = @cdItem";
                 SqlCommand cmd = new SqlCommand(sql, conn);
                 cmd.Parameters.AddWithValue("@cdLocacao", cdLocacao);
                 cmd.Parameters.AddWithValue("@cdItem", cdItem);
                 cmd.Parameters.AddWithValue("@statusPG", "PAGO");
                 cmd.Parameters.AddWithValue("@dtDevolucao", DateTime.Now);
 
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

        public List<Locacao> SelecionarLocacoes()
        {
            List<Locacao> lista = new List<Locacao>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                string sql = "select * from Locacoes";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Locacao l;
                    while (dr.Read())
                    {
                        l = new Locacao();
                        l.cdCli = (Convert.ToInt32(dr["cdCli"]));
                        l.cdFunc = (Convert.ToInt32(dr["cdFunc"]));

                        lista.Add(l);
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
