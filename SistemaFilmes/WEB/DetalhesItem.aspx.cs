using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Models;

namespace WEB
{
    public partial class DetalhesItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            itemDAL iDAL = new itemDAL();
            Item objItem = iDAL.BuscarItemCodigo(Convert.ToInt32(txtCod.Text));
            List<Item> lista = new List<Item>();
            lista.Add(objItem);


            gvItem.DataSource = lista;
            gvGeneros.DataSource = iDAL.ListarGenerosDeItem(Convert.ToInt32(txtCod.Text));
            gvParticipacoes.DataSource = iDAL.ListarArtistasDeItem(Convert.ToInt32(txtCod.Text));

            gvItem.DataBind();
            gvGeneros.DataBind();
            gvParticipacoes.DataBind();
        }
    }
}