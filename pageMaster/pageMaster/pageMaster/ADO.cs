using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace pageMaster
{
    public class ADO
    {
        public static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-M15DGM0;
            Initial Catalog=gestion_commerc;Integrated Security=True");
        public static int code_client;
        public static SqlDataAdapter da;
        public static DataTable dt = new DataTable();
        public static bool Authentifier(string login, string mdp)
        {
            bool retour = false;
            string requete = string.Format(@"select * from client
where login_clt = '{0}'
and mdp_clt = '{1}'", login, mdp);

            da = new SqlDataAdapter(requete, cnx);

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                retour = true;

            }


            return retour;

        }

        public static int nombreCommande(int client)
        {
            DataTable t = new DataTable();
            string requete = "select count(*) from commande where client = " + client;
            da = new SqlDataAdapter(requete, cnx);

            da.Fill(t);
            return (int)t.Rows[0][0];
        }

        public static decimal chiffre_affaire(int client)
        {

            decimal ca = 0m;
            return ca;
        }
        public static DataTable liste_commandes(int client)
        {
            string requete = " select * from commande where codecl =" +
                client;

            da = new SqlDataAdapter(requete, cnx);
            da.Fill(dt);

            return dt;

        }
    }
}