﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MenuMed
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reqEnt = string.Format(@"select * from medecin where login='{0}' and mdp = '{1}'", textBoxLogin.Text.Trim(), TextBoxPass.Text.Trim());
           Program.da_medecin= new SqlDataAdapter(reqEnt, Program.cnx);
            DataTable dt = new DataTable();
            Program.da_medecin.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Menu n = new Menu();
                this.Visible = false;
                n.Show();
            }
        }
    }
}
