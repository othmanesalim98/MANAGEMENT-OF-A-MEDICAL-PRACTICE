using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MenuMed
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        Rendez_Vous r = new Rendez_Vous();
        Consultation co = new Consultation();
        Patient p = new Patient();
        Medicament m = new Medicament();
        Ordennance o = new Ordennance();

        private void Menu_Load(object sender, EventArgs e)
        {
            
            dataGridView_RDV.Visible = true;
            string requet = @"select * from Rendez_vous where Day(DateR)=Day(getdate()) and
                          Month(DateR)=Month(getdate()) and year(DateR) = year(getdate())";
            SqlDataAdapter da = new SqlDataAdapter(requet,Program.cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                dataGridView_RDV.DataSource = da;
            }
            else
            {
                MessageBox.Show("aucun rendez_vous ");
            }

            this.IsMdiContainer = true;
        }
        //methode de verification
        public bool verifier(string form)
        {
            bool isOpen = false;
            foreach(Form f in Application.OpenForms)
            {
                if(f.Text == form)
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            return isOpen;
        }

        private void button_rendez_vous_Click(object sender, EventArgs e)
        {
            if(verifier("Rendez_Vous") == false)
            {
                
                co.Visible = false;
                m.Visible = false;
                p.Visible = false;
                o.Visible = false;
                dataGridView_RDV.Visible = false;
                monthCalendar1.Visible = false;
                pictureBox1.Visible = false;
                label1.Visible = false;
                panel3.Visible = false;
                r.MdiParent = this;
                r.Show();
            }
           
        }

        private void button_consultation_Click(object sender, EventArgs e)
        {
            if (verifier("Consultation") == false)
            {
                r.Visible = false;
                m.Visible = false;
                p.Visible = false;
                o.Visible = false;
                dataGridView_RDV.Visible = false;
                monthCalendar1.Visible = false;
                pictureBox1.Visible = false;
                label1.Visible = false;
                panel3.Visible = false;
                co.MdiParent = this;
                co.Show();
            }
        }
        private void button_patient_Click(object sender, EventArgs e)
        {
            if (verifier("Patient") == false)
            {
                co.Visible = false;
                m.Visible = false;
                r.Visible = false;
                o.Visible = false;
                dataGridView_RDV.Visible = false;
                monthCalendar1.Visible = false;
                pictureBox1.Visible = false;
                label1.Visible = false;
                panel3.Visible = false;
                p.MdiParent = this;
                p.Show();
            }
        }

        private void button_medicament_Click(object sender, EventArgs e)
        {
            if (verifier("Medicament") == false)
            {
                co.Visible = false;
                r.Visible = false;
                p.Visible = false;
                o.Visible = false;
                dataGridView_RDV.Visible = false;
                monthCalendar1.Visible = false;
                pictureBox1.Visible = false;
                label1.Visible = false;
                panel3.Visible = false;
                m.MdiParent = this;
                m.Show();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(e.End.ToString());
        }

        private void dataGridView_RDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_ordonnance_Click(object sender, EventArgs e)
        {
            if (verifier("Ordennance") == false)
            {
                co.Visible = false;
                r.Visible = false;
                p.Visible = false;
                m.Visible = false;
                dataGridView_RDV.Visible = false;
                monthCalendar1.Visible = false;
                pictureBox1.Visible = false;
                label1.Visible = false;
                panel3.Visible = false;
                o.MdiParent = this;
                o.Show();
            }
        }
        int i = 0;
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    pictureBox1.Image = imageList1.Images[i];
        //    i++;
        //}

        
    }
}

