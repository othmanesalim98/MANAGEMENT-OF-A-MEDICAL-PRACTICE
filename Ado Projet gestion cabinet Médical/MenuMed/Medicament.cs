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
    public partial class Medicament : Form
    {
        public Medicament()
        {
            InitializeComponent();
        }

        private void Medicament_Load(object sender, EventArgs e)
        {
            comboBox_Forme.DisplayMember = "Formes";
            comboBox_Forme.DataSource = Program.Afficher_Médicament();
            actualiser_dgv();
        }
        public void actualiser_dgv()
        {
            string req = "select * from Médicament";
            dataGridView1.DataSource = Program.Executer_select(req);
           
        }

       
        private void MODIFIER_Click(object sender, EventArgs e)
        {
            string requete = string.Format(@"update Médicament 
               set NomMédi='{0}',Dosage='{1}',Formes='{2}' where NumMédi={3}", 
               textBox_NomMedi.Text, textBox2_Dosage.Text,comboBox_Forme.Text, 
               textBox1_Num.Text);
            Program.Executer_MAJ(requete);
            MessageBox.Show("Modification réusie");
            actualiser_dgv();
        }

        private void AJOUTER_Click(object sender, EventArgs e)
        {
           
                string requete = string.Format(@"insert into Médicament values({0},'{1}','{2}','{3}')",
                textBox1_Num.Text,
               textBox_NomMedi.Text,textBox2_Dosage.Text,
               comboBox_Forme.Text);
                Program.Executer_MAJ(requete);
                MessageBox.Show("insrtion réusie");
                actualiser_dgv();
            
        }

        private void SUPPRIMER_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            this.dataGridView1.Rows.RemoveAt(index);
            MessageBox.Show("suppression réusite");
            actualiser_dgv();
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1_Num.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_NomMedi.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2_Dosage.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox_Forme.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
        }
        private void RECHERCHER_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
