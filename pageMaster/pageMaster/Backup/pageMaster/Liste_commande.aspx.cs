using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pageMaster
{
    public partial class Liste_commande : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.ShowFooter = true;
            
            GridViewRow r = GridView1.FooterRow;
            r.Cells[0].Text = "Total commande:";
            r.Cells[1].Text = GridView1.Rows.Count.ToString();
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void selectionner()
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            

        }

        protected void SqlDataSource3_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}