using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuMed
{
    public partial class Rendez_Vous : Form
    {
        public Rendez_Vous()
        {
            InitializeComponent();
        }
        BindingSource BS = new BindingSource();

        private void Rendez_Vous_Load(object sender, EventArgs e)
        {
            dataGridView_RendezVous.DataSource = Program.Executer_select("select* from Rendez_vous");
            BS.DataSource = Program.Executer_select("Select * from Rendez_vous");

            comboBox_journee.DisplayMember = "NumJ";
            comboBox_journee.DataSource = Program.Afficher_journee();

            textBox_NumR.DataBindings.Add(new Binding("text", BS, "NumR"));
            dateTimePicker_DateR.DataBindings.Add(new Binding("text", BS, "DateR"));
            dateTimePicker_HeureR.DataBindings.Add(new Binding("text", BS, "HeurR"));
            comboBox_journee.DataBindings.Add(new Binding("text", BS, "journée"));
        }
        public void actualiser_dgv()
        {
            string req = "select * from Rendez_vous";
            dataGridView_RendezVous.DataSource = Program.Executer_select(req);
        }
  
        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string requete = string.Format(@"insert into Rendez_vous values({0},'{1}','{2}',{3})",
                textBox_NumR.Text, dateTimePicker_DateR.Value.ToString("yyyy-MM-dd"), dateTimePicker_HeureR.Value.ToString("hh:MM:ss"),
                comboBox_journee.Text);
                Program.Executer_MAJ(requete);
                actualiser_dgv();
                MessageBox.Show("ajouter reussi");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            string requete = string.Format(@"update Rendez_vous 
               set DateR='{0}',HeurR='{1}',journée={2} where NumR={3}", dateTimePicker_DateR.Value.ToString("yyyy-MM-dd"), dateTimePicker_HeureR.Value.ToString("hh:MM:ss"), comboBox_journee.Text, textBox_NumR.Text);
            Program.Executer_MAJ(requete);
            MessageBox.Show("Modification réusie");
            actualiser_dgv();
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
           
            int index = this.dataGridView_RendezVous.CurrentRow.Index;
            this.dataGridView_RendezVous.Rows.RemoveAt(index);
            MessageBox.Show("suppression réusite");
           
        }

        private void button_Premier_Click(object sender, EventArgs e)
        {
            BS.MoveFirst();
            actualiser_dgv();
        }

        private void button_Précédent_Click(object sender, EventArgs e)
        {
            BS.MovePrevious();
            actualiser_dgv();
        }

        private void button_Suivant_Click(object sender, EventArgs e)
        {
            BS.MoveNext();
            actualiser_dgv();
        }

        private void button_Dernier_Click(object sender, EventArgs e)
        {
            BS.MoveLast();
            actualiser_dgv();
        }

        private void button_Quiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_RendezVous_Click(object sender, EventArgs e)
        {
            textBox_NumR.Text = dataGridView_RendezVous.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker_DateR.Value=DateTime.Parse( dataGridView_RendezVous.CurrentRow.Cells[1].Value.ToString());
            dateTimePicker_HeureR.Value= DateTime.Parse(dataGridView_RendezVous.CurrentRow.Cells[2].Value.ToString());
            comboBox_journee.Text= dataGridView_RendezVous.CurrentRow.Cells[3].Value.ToString();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
