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
    public partial class RelatorioItens : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarItens();
        }

        private void CarregarItens()
        {
            itemDAL iDAL = new itemDAL();
            gvItens.DataSource = iDAL.ListarItens();
            gvItens.DataBind();
        }
    }
}