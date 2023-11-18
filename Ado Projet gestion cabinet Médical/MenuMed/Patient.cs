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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        public string Sexe()
        {
            String sexe = "";
            if (radioButton_femme.Checked == true)
            {
                sexe = "Femme";
            }
            else
            {
                sexe = "Homme";
            }
            return sexe;
        }


        private void Patient_Load(object sender, EventArgs e)
        {
            comboBox_NumR.DisplayMember = "NumR";
            comboBox_NumR.DataSource = Program.Executer_select("select * from Rendez_vous");
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                
                    string req = string.Format("insert into Patient values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}',{9})", textBox_NumP.Text,
                                            textBox_NomP.Text, textBox_PrenomP.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), Sexe(), textBox_email.Text,
                                            textBox_adresse.Text, textBox_tele.Text, textBox1.Text, comboBox_NumR.Text);


                    Program.Executer_MAJ(req);
                    MessageBox.Show("Le patient été ajouter");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                string req = string.Format(@"update Patient
                                            set NomP='{0}' ,PrénomP='{1}', DateN='{2}',Sexe='{3}',Email_P='{4}',Adresse_P='{5}',Tél_P={6},Mutuelle={7},rendez_vous={8} where CIN='{9}'", textBox_NomP.Text
                                           , textBox_PrenomP.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), Sexe(), textBox_email.Text,
                                           textBox_adresse.Text, textBox_tele.Text, textBox1.Text, comboBox_NumR.Text,textBox_NumP.Text);
                Program.Executer_MAJ(req);
                MessageBox.Show("bien madofier");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string req = "delete Patient where CIN=' " + textBox_numPRech.Text+"'" ;
                Program.Executer_MAJ(req);
                MessageBox.Show("bien supprimer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_recherche_Click(object sender, EventArgs e)
        {
            try
            {
                string req = @"select * from Patient where CIN= '" + textBox_numPRech.Text +"'";
                DataTable dt = new DataTable();
                dt = Program.Executer_select(req);
                textBox_NumP.Text = dt.Rows[0][0].ToString();
                textBox_NomP.Text = dt.Rows[0][1].ToString();
                textBox_PrenomP.Text = dt.Rows[0][2].ToString();
                dateTimePicker1.Value = DateTime.Parse(dt.Rows[0][3].ToString());
                if ((string)dt.Rows[0][4] == "Femme")
                {
                    radioButton_femme.Checked = true;
                }
                else if ((string)dt.Rows[0][4] == "Homme")
                {
                    radioButton_Homme.Checked = true;
                }
                textBox_email.Text = dt.Rows[0][5].ToString();
                textBox_adresse.Text = dt.Rows[0][6].ToString();
                textBox_tele.Text = dt.Rows[0][7].ToString();
                textBox1.Text = dt.Rows[0][8].ToString();
                comboBox_NumR.Text = dt.Rows[0][9].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label_age.Text = (DateTime.Today.Year - dateTimePicker1.Value.Year).ToString();
        }

      
    }
}
    