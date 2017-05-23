using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace WEB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            usuarioDAL uDAL = new usuarioDAL();
            e.Authenticated = uDAL.AutenticaUsuario(Login1.UserName, usuarioDAL.CalculaCriptografia(Login1.Password));
            
            if (e.Authenticated == true)
            {
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
            }
            else
            {
                e.Authenticated = false;
            }           

        }
    }
}