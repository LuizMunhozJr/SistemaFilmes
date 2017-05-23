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
                        I.Ano = Convert.ToInt32(dr["anoItem"]);
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

        public List<Item> Listar10UltimosItens()
        {
            List<Item> lista = new List<Item>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT TOP 10 * FROM Itens ORDER BY cdItem DESC";
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
                        I.Ano = Convert.ToInt32(dr["anoItem"]);
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

        public int BuscarCodUltimoItem()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            int codigo=0;
            try
            {
                conn.Open();

                string sql = "select top 1 cdItem from itens order by cdItem desc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.HasRows && dr.Read())
                {
                   codigo = Convert.ToInt32(dr["cdItem"]);                                       
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

        //FINALIZANDO
        public List<Item> BuscarItemFiltros(string desc, string ator, string genero)
        {
            List<Item> lista = new List<Item>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = @"select I.dsItem,I.anoItem,I.imgItem  from Itens as I 
                            inner join GenerosItem as GI on GI.cdItem=I.cdItem
                            inner join Generos as G on G.cdGen=GI.cdGen 
                            inner join Participacoes as P on P.cdItem = I.cdItem
                            inner join Artistas as Art on Art.cdArt = P.cdArt
                            WHERE I.dsItem LIKE @descricao AND ART.nmArt LIKE @ator AND G.nmGen LIKE @genero";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@descricao", "%" + desc + "%");
                cmd.Parameters.AddWithValue("@ator", "%" + ator + "%");
                cmd.Parameters.AddWithValue("@genero", "%" + genero + "%");

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    Item I = null;
                    while (dr.Read())
                    {
                        I = new Item();
                        I.Descricao = dr["dsItem"].ToString();
                        I.Ano = Convert.ToInt32(dr["anoItem"]);
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

        public List<Participacoes> ListarArtistasDeItem(Int32 cod)
        {
            List<Participacoes> Lista = new List<Participacoes>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql= @"Select * from Artistas as A 
                            inner join Participacoes as P on P.cdArt = A.cdArt
                            inner join Itens as I on i.cdItem = P.cdItem
                            WHERE I.cdItem = @codItem ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@codItem", cod);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    Participacoes P = null;
                    while (dr.Read())
                    {
                        P = new Participacoes();
                        P.cdArt = Convert.ToInt32(dr["cdArt"]);
                        P.cdItem = cod;
                        P.nmArt= dr["nmArt"].ToString();
                        P.cdPersonagem = dr["cdPersonagem"].ToString();
                        P.ImagemArt = (byte[])dr["imgArt"];

                        Lista.Add(P);
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

            return Lista;
        }

        public List<Genero> ListarGenerosDeItem(Int32 cod)
        {
            List<Genero> Lista = new List<Genero>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = @"Select nmGen from Generos as G
                               inner join GenerosItem as GI on GI.cdGen= G.cdGen
                               inner join Itens as I on I.cdItem = GI.cdItem
                               Where I.cdItem = @codItem";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@codItem", cod);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    Genero G = null;
                    while (dr.Read())
                    {
                        G = new Genero();
                        G.Nome= dr["nmGen"].ToString();

                        Lista.Add(G);
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

            return Lista;
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
