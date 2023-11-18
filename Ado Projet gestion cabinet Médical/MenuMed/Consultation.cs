using System;
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
    public partial class Consultation : Form
    {
        public Consultation()
        {
            InitializeComponent();
        }

        private void Consultation_Load(object sender, EventArgs e)
        {
            Program.chargerdata();

            //afficher les consultation sur DGV en chargement
            string req2 = @"select  *
                           from  Consultation ";
            SqlDataAdapter da2 = new SqlDataAdapter(req2, Program.cnx);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView_consultation.DataSource = dt2;
        }
        //vider tout les champts
        public void vider()
        {
            textBox_NumConc.Clear();
            richTextBox_DIAGNOSTIC.Clear();
            maskedTextBox1.Clear();
            textBox_Poids.Clear();
            textBox_tension.Clear();
            textBox_prix.Clear();
            textBox_Med.Clear();
            textBox_Patient.Clear();
            textBox_NumConc.Focus();

        }
        //actualiser datagridview
        public void ACT_DGV()
        {

            dataGridView_consultation.DataSource = Program.ds.Tables["Consultation"];
        }
        //bouton Ajouter
        private void button_AJOUTER_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = Program.ds.Tables["Consultation"].NewRow();
                dr[0] = textBox_NumConc.Text;
                dr[1] = richTextBox_DIAGNOSTIC.Text;
                dr[2] = DateTime.Parse(maskedTextBox1.Text);
                dr[3] = textBox_Poids.Text;

                dr[4] = textBox_tension.Text;
                dr[5] = textBox_prix.Text;
                dr[6] = textBox_Med.Text;
                dr[7] = textBox_Patient.Text;
                Program.ds.Tables["Consultation"].Rows.Add(dr);
                ACT_DGV();
                Program.MAJ_Consultation();

                MessageBox.Show("bien ajoutée");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                vider(); 
            }
        }

        //bouton Modifier
        private void button_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
               
                DataRow DR = null;

                DR = Program.ds.Tables["Consultation"].Rows.Find(textBox_NumConc.Text);
                if (DR != null)
                {
                    DR[0] = textBox_NumConc.Text; 
                    DR[1] = richTextBox_DIAGNOSTIC.Text;
                    DR[2] = DateTime.Parse(maskedTextBox1.Text);
                    DR[3] =textBox_Poids.Text;
                    DR[4] = textBox_tension.Text;
                    DR[5] = textBox_prix.Text;
                    DR[6] = textBox_Med.Text;
                    DR[7] = textBox_Patient.Text;
                    Program.MAJ_Consultation();
                    ACT_DGV();
                    vider();

                }
                else { MessageBox.Show("cette consultation inexistante !!"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                vider(); 
            }
        }
        //bouton supprimer
        private void button_supp_Click(object sender, EventArgs e)
        {

            
            try
            {
                int index = this.dataGridView_consultation.CurrentRow.Index;
                this.dataGridView_consultation.Rows.RemoveAt(index);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //bouton annuler
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //bouton recharcher
        private void button_rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                //--
                string s = @"select  c.*
                              from  Consultation c 
                              join Patient p on p.CIN=c.Patient 
                              where c.patient = '"+ textBox_recherche.Text+"'";

                SqlDataAdapter da = new SqlDataAdapter(s, Program.cnx);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    //Afficher le nom du patient APARTIR DU CIN
                    string requet = @"  select  Concat(NomP,' ',PrénomP)  from  Patient where CIN='" + textBox_recherche.Text+"'";
                    SqlDataAdapter da1 = new SqlDataAdapter(requet, Program.cnx);
                    DataTable dt1 = new DataTable();

                    da1.Fill(dt1);
                    textBox_NomP.Text = dt1.Rows[0][0].ToString();
                    dataGridView_rechercher.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("CIN INESCISTANTE");
                    textBox_recherche.Clear();
                    textBox_NomP.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //--
        private void dataGridView_consultation_Click(object sender, EventArgs e)
        {
            textBox_NumConc.Text = dataGridView_consultation.CurrentRow.Cells[0].Value.ToString();
            richTextBox_DIAGNOSTIC.Text = dataGridView_consultation.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView_consultation.CurrentRow.Cells[2].Value.ToString();
            textBox_Poids.Text = dataGridView_consultation.CurrentRow.Cells[3].Value.ToString();
            textBox_tension.Text = dataGridView_consultation.CurrentRow.Cells[4].Value.ToString();
            textBox_prix.Text = dataGridView_consultation.CurrentRow.Cells[5].Value.ToString();
            textBox_Med.Text = dataGridView_consultation.CurrentRow.Cells[6].Value.ToString();
            textBox_Patient.Text= dataGridView_consultation.CurrentRow.Cells[7].Value.ToString();

        }

        
        private void dataGridView_consultation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_consultation_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_consultation_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView_rechercher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
