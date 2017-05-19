using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Models;
using System.Configuration;

namespace DAL
{
    public class itemDAL
    {
        
        string connectionString = ConfigurationManager.ConnectionStrings["BDVideolandiaConnectionString"].ConnectionString;

        
        public void InserirItem(Item objItem)
        {

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INTO Itens VALUES (@cdbarItem, @dsItem, @anoItem, @tipoItem, @precoItem, @dtCompra, @vlcustoItem, @situItem, @diretorItem, @imgItem)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cdbarItem", objItem.CodigoDeBarras);
                cmd.Parameters.AddWithValue("@dsItem", objItem.Descricao);
                cmd.Parameters.AddWithValue("@anoItem", objItem.Ano);
                cmd.Parameters.AddWithValue("@tipoItem", objItem.Tipo);
                cmd.Parameters.AddWithValue("@precoItem", objItem.Preco);
                cmd.Parameters.AddWithValue("@dtCompra", objItem.DtCompra);
                cmd.Parameters.AddWithValue("@vlcustoItem", objItem.VlCusto);
                cmd.Parameters.AddWithValue("@situItem", objItem.Situacao);
                cmd.Parameters.AddWithValue("@diretorItem", objItem.Diretor);
                cmd.Parameters.AddWithValue("@imgItem", objItem.Imagem);

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

        public List<Item> ListarItens()
        {
            List<Item> lista = new List<Item>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Itens";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    Item I = null;
                    while (dr.Read())
                    {
                        I = new Item();
                        I.Codigo = Convert.ToInt32(dr["cdItem"]);
                        I.CodigoDeBarras = dr["cdbarItem"].ToString();
                        I.Descricao = dr["dsItem"].ToString();
                        I.Ano = Convert.ToInt32(dr["dtCompra"]);
                        I.Tipo = dr["tipoItem"].ToString();
                        I.Preco = Convert.ToDecimal(dr["precoItem"]);
                        I.VlCusto = Convert.ToDecimal(dr["vlcustoItem"]);
                        I.DtCompra = Convert.ToDateTime(dr["dtCompra"]);
                        I.Situacao = Convert.ToBoolean(dr["situItem"]);
                        I.Diretor = dr["diretorItem"].ToString();
                        I.Imagem = (byte[])dr["imgItem"];

                        lista.Add(I);
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

        
        public Item BuscarItemCodigo(int cod)
        {
            Item I = null;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Itens WHERE cdItem = @codigo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", cod);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows && dr.Read())
                {
                    I = new Item();
                    I.Codigo = Convert.ToInt32(dr["cdItem"]);
                    I.CodigoDeBarras = dr["cdbarItem"].ToString();
                    I.Descricao = dr["dsItem"].ToString();
                    I.Ano = Convert.ToInt32(dr["anoItem"]);
                    I.Tipo = dr["tipoItem"].ToString();
                    I.Preco = Convert.ToDecimal(dr["precoItem"]);
                    I.VlCusto = Convert.ToDecimal(dr["vlcustoItem"]);
                    I.DtCompra = Convert.ToDateTime(dr["dtCompra"]);
                    I.Situacao = Convert.ToBoolean(dr["situItem"]);
                    I.Diretor = dr["diretorItem"].ToString();
                    I.Imagem = (byte[])dr["imgItem"];                    
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

            return I;
        }
        public Item BuscarItemCodigoBarras(int cod)
        {
            Item I = null;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Itens WHERE cdbarItem = @codigo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", cod);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows && dr.Read())
                {
                    I = new Item();
                    I.Codigo = Convert.ToInt32(dr["cdItem"]);
                    I.CodigoDeBarras = dr["cdbarItem"].ToString();
                    I.Descricao = dr["dsItem"].ToString();
                    I.Ano = Convert.ToInt32(dr["dtCompra"]);
                    I.Tipo = dr["tipoItem"].ToString();
                    I.Preco = Convert.ToDecimal(dr["precoItem"]);
                    I.VlCusto = Convert.ToDecimal(dr["vlcustoItem"]);
                    I.DtCompra = Convert.ToDateTime(dr["dtCompra"]);
                    I.Situacao = Convert.ToBoolean(dr["situItem"]);
                    I.Diretor = dr["diretorItem"].ToString();
                    I.Imagem = (byte[])dr["imgItem"];
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

            return I;
        }

        
        public void AlteraItem(Item objItem)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "UPDATE Itens SET cdbarItem=@cdbar, dsItem=@dsItem, anoItem=@anoItem, tipoItem=@tipoItem, precoItem=@precoItem, dtCompra=@dtCompra, vlcustoItem=@vlcustoItem, situItem=@situItem, diretorItem=@diretorItem, imgItem=@imgItem WHERE cdItem=@codItem";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codItem", objItem.Codigo);
                cmd.Parameters.AddWithValue("@cdbar", objItem.CodigoDeBarras);
                cmd.Parameters.AddWithValue("@dsItem", objItem.Descricao);
                cmd.Parameters.AddWithValue("@anoItem", objItem.Ano);
                cmd.Parameters.AddWithValue("@tipoItem", objItem.Tipo);
                cmd.Parameters.AddWithValue("@precoItem", objItem.Preco);
                cmd.Parameters.AddWithValue("@dtCompra", objItem.DtCompra);
                cmd.Parameters.AddWithValue("@vlcustoItem", objItem.VlCusto);
                cmd.Parameters.AddWithValue("@situItem", objItem.Situacao);
                cmd.Parameters.AddWithValue("@diretorItem", objItem.Diretor);
                cmd.Parameters.AddWithValue("@imgItem", objItem.Imagem);
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

        
        public void ExcluirItem(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "DELETE FROM Itens WHERE cdItem = @codigo";
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
