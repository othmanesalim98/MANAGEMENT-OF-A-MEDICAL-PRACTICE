namespace MenuMed
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button_ordonnance = new System.Windows.Forms.Button();
            this.button_patient = new System.Windows.Forms.Button();
            this.button_consultation = new System.Windows.Forms.Button();
            this.button_medicament = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_rendez_vous = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView_RDV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button_ordonnance);
            this.panel1.Controls.Add(this.button_patient);
            this.panel1.Controls.Add(this.button_consultation);
            this.panel1.Controls.Add(this.button_medicament);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button_rendez_vous);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 587);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Cornsilk;
            this.button6.Location = new System.Drawing.Point(88, 424);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 38);
            this.button6.TabIndex = 9;
            this.button6.Text = "DECONNEXION";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_ordonnance
            // 
            this.button_ordonnance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ordonnance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ordonnance.ForeColor = System.Drawing.Color.Cornsilk;
            this.button_ordonnance.Location = new System.Drawing.Point(37, 339);
            this.button_ordonnance.Name = "button_ordonnance";
            this.button_ordonnance.Size = new System.Drawing.Size(237, 49);
            this.button_ordonnance.TabIndex = 8;
            this.button_ordonnance.Text = "ORDONNANCE";
            this.button_ordonnance.UseVisualStyleBackColor = true;
            this.button_ordonnance.Click += new System.EventHandler(this.button_ordonnance_Click);
            // 
            // button_patient
            // 
            this.button_patient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_patient.ForeColor = System.Drawing.Color.Cornsilk;
            this.button_patient.Location = new System.Drawing.Point(37, 174);
            this.button_patient.Name = "button_patient";
            this.button_patient.Size = new System.Drawing.Size(237, 49);
            this.button_patient.TabIndex = 7;
            this.button_patient.Text = "PATIENT";
            this.button_patient.UseVisualStyleBackColor = true;
            this.button_patient.UseWaitCursor = true;
            this.button_patient.Click += new System.EventHandler(this.button_patient_Click);
            // 
            // button_consultation
            // 
            this.button_consultation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_consultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_consultation.ForeColor = System.Drawing.Color.Cornsilk;
            this.button_consultation.Location = new System.Drawing.Point(37, 229);
            this.button_consultation.Name = "button_consultation";
            this.button_consultation.Size = new System.Drawing.Size(237, 49);
            this.button_consultation.TabIndex = 6;
            this.button_consultation.Text = "CONSULTATION";
            this.button_consultation.UseVisualStyleBackColor = true;
            this.button_consultation.Click += new System.EventHandler(this.button_consultation_Click);
            // 
            // button_medicament
            // 
            this.button_medicament.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_medicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_medicament.ForeColor = System.Drawing.Color.Cornsilk;
            this.button_medicament.Location = new System.Drawing.Point(37, 284);
            this.button_medicament.Name = "button_medicament";
            this.button_medicament.Size = new System.Drawing.Size(237, 49);
            this.button_medicament.TabIndex = 5;
            this.button_medicament.Text = "MEDICAMENT";
            this.button_medicament.UseVisualStyleBackColor = true;
            this.button_medicament.Click += new System.EventHandler(this.button_medicament_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MenuMed.Properties.Resources.cmm;
            this.pictureBox2.Location = new System.Drawing.Point(10, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button_rendez_vous
            // 
            this.button_rendez_vous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_rendez_vous.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rendez_vous.ForeColor = System.Drawing.Color.Cornsilk;
            this.button_rendez_vous.Location = new System.Drawing.Point(37, 119);
            this.button_rendez_vous.Name = "button_rendez_vous";
            this.button_rendez_vous.Size = new System.Drawing.Size(237, 49);
            this.button_rendez_vous.TabIndex = 2;
            this.button_rendez_vous.Text = "RENDEZ-VOUS";
            this.button_rendez_vous.UseVisualStyleBackColor = true;
            this.button_rendez_vous.Click += new System.EventHandler(this.button_rendez_vous_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(327, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 122);
            this.panel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(305, 38);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(305, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 30);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(68, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calendrier";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(1275, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Azure;
            this.imageList1.Images.SetKeyName(0, "gettyimages-981772592-1024x1024.jpg");
            this.imageList1.Images.SetKeyName(1, "atrix-international-medical-slide04.jpg");
            this.imageList1.Images.SetKeyName(2, "gettyimages-881196296-1024x1024.jpg");
            this.imageList1.Images.SetKeyName(3, "-977479589.jpg");
            // 
            // dataGridView_RDV
            // 
            this.dataGridView_RDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RDV.Location = new System.Drawing.Point(305, 229);
            this.dataGridView_RDV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_RDV.Name = "dataGridView_RDV";
            this.dataGridView_RDV.RowTemplate.Height = 24;
            this.dataGridView_RDV.Size = new System.Drawing.Size(226, 352);
            this.dataGridView_RDV.TabIndex = 1;
            this.dataGridView_RDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RDV_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MenuMed.Properties.Resources.gettyimages_544488379_1024x10241;
            this.pictureBox1.Location = new System.Drawing.Point(533, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 581);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 587);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_RDV);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_rendez_vous;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_patient;
        private System.Windows.Forms.Button button_consultation;
        private System.Windows.Forms.Button button_medicament;
        private System.Windows.Forms.Button button_ordonnance;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_RDV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

