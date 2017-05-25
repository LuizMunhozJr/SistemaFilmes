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

        public List<ItemDevolucao> SelecionarTodosItensNumeroPedido(int codigo)
        {
            List<ItemDevolucao> lista = new List<ItemDevolucao>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                string sql = "Select I.cdItem,I.cddbarItem,I.dsItem,I.precoItem,IL.statusPG,IL.dtDevolucao, IL.CodLocacao from Itens I inner join ItemLocacao IL ON( I.cdItem = IL.cdItem) WHERE cdLocacao = @codigo";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    ItemDevolucao i;
                    while (dr.Read())
                    {
                        i = new ItemDevolucao();
                        i.cdItem = Convert.ToInt32(dr["I.cdItem"]);
                        i.cddbarItem = dr["I.cddbarItem"].ToString();
                        i.dsItem = dr["I.dsItem"].ToString();
                        i.precoItem = Convert.ToDecimal(dr["I.precoItem"]);
                        i.statusPG = dr["IL.statusPG"].ToString();
                        i.dtDevolucao = Convert.ToDateTime(dr["IL.dtDevolucao"]);
                        i.cdLocacao = Convert.ToInt32(dr["IL.cdCodLocacao"]);


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
        public void AlteraLocacao(Locacao objLoc)
        {
            SqlConnection conn = new SqlConnection(connectionString);
           
                try
                {
                    conn.Open();

                    string sql = "UPDATE Locacoes SET cdCli=@cdCli, cdFun=@cdFun, dtRetirada=@dtRetirada WHERE cdLocacao = @cdLocacao)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@cdLocacao", objLoc.cdLocacao);
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

                string sql = "INSERT INTO Locacoes VALUES (@cdLocacao, @cdItem, @statusPG, @dtDevolucao)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cdLocacao", objItemLoc.cdLocacao);
                cmd.Parameters.AddWithValue("@cdItem", objItemLoc.cdItem);
                cmd.Parameters.AddWithValue("@statusPG", objItemLoc.statusPG);
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
        public void AlteraItensLocacao(ItemLocacao objItemLoc)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

                string sql = "UPDATE Locacoes SET statusPG = @statusPG, dtDevolucao=@dtDevolucao WHERE cdLocacao = @cdLocacao AND cdItem = @cdItem";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cdLocacao", objItemLoc.cdLocacao);
                cmd.Parameters.AddWithValue("@cdItem", objItemLoc.cdItem);
                cmd.Parameters.AddWithValue("@statusPG", objItemLoc.statusPG);
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

                string sql = "select top 1 cdLocacao from Locacoes order by cdItem desc";
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
                    l.cdCli = Convert.ToInt32(dr["cdCli"]);
                    l.dtRetirada = Convert.ToDateTime(dr["dtRetirada"]);
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

        public void ExcluirLocacao(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "DELETE * FROM Locacoes WHERE cdLocacao = @codigo";
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
        public void ExcluirItensLocacao(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "DELETE * FROM ItemLocacao WHERE cdLocacao = @codigo";
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
    }
}
