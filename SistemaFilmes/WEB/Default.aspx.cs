using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace WEB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            itemDAL iDAL = new itemDAL();
            gvItens.DataSource =iDAL.Listar10UltimosItens();
            gvItens.DataBind();
        }
    }
}