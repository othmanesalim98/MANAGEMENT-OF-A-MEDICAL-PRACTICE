using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pageMaster
{
    public partial class Acceuil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = ADO.nombreCommande((int)Session["code"]).ToString();
        }
    }
}