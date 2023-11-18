using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace MenuMed
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }


        public static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-2D073NO\SQLEXPRESS;Initial Catalog=gestion_cabinet_médicale;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand("", cnx);
        public static SqlDataReader dr;
        //
        public static SqlDataAdapter da_medecin;
        public static SqlDataAdapter da_concul;
        public static SqlDataAdapter da_patient;
        public static SqlDataAdapter da;
        public static DataSet ds = new DataSet();

        public static void Executer_MAJ(string requete)
        {
            try
            {
                if (Program.cnx.State == ConnectionState.Closed)
                {
                    Program.cnx.Open();
                }
                cmd.CommandText = requete;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
               
            }
            finally
            {
                cnx.Close();
            }
        }
        public static DataTable Executer_select(string requete)
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                return dt;
            }
            catch
            {

                throw;
            }
            finally
            {
                cnx.Close();
            }

        }
        public static DataTable Afficher_journee()
        {
            DataTable dt = new DataTable();
            dt = Program.Executer_select("select * from Journée");
            return dt;
        }
        public static DataTable Afficher_Médicament()
        {
            DataTable dt = new DataTable();
            dt = Program.Executer_select("select * from Médicament");
            return dt;
        }
        //---methode charger dataSet

        public static void chargerdata()
        {
            da_medecin = new SqlDataAdapter("select * from Médecin", cnx);
            da_concul = new SqlDataAdapter("select * from Consultation", cnx);
            da_patient = new SqlDataAdapter("select * from Patient", cnx);
            da= new SqlDataAdapter("select * from Rendez_Vous", cnx);

            da_medecin.Fill(ds, " Médecin");
            da_patient.Fill(ds, "Patient");
            da_concul.Fill(ds, "Consultation");
            da.Fill(ds, "Rendez_Vous");
            //---definir les Pkey
            ds.Tables["Consultation"].PrimaryKey = new DataColumn[] { ds.Tables["Consultation"].Columns[0] };
            ds.Tables["patient"].PrimaryKey = new DataColumn[] { ds.Tables["Patient"].Columns[0] };
            //ds.Tables["Médecin"].PrimaryKey = new DataColumn[] { ds.Tables["Médecin"].Columns[0] };
            //ds.Tables["Rendez_Vous"].PrimaryKey = new DataColumn[] { ds.Tables["Rendz_Vous"].Columns[0] };

        }
        //enregistrer
        public static void MAJ_Consultation()
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da_concul);
            da_concul.Update(ds.Tables["Consultation"]);
        }
    }
}
