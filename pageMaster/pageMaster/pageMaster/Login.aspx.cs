using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pageMaster
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (ADO.Authentifier(Login1.UserName, Login1.Password))
            { 
                Session["code"] = ADO.dt.Rows[0][0];
                Session["nom"] = ADO.dt.Rows[0][1];
                Response.Redirect("acceuil.Aspx");
              
            }
        }
    }
}