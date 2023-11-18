namespace MenuMed
{
    partial class Patient
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
            this.comboBox_NumR = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_tele = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.label_age = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton_femme = new System.Windows.Forms.RadioButton();
            this.radioButton_Homme = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_PrenomP = new System.Windows.Forms.TextBox();
            this.textBox_NomP = new System.Windows.Forms.TextBox();
            this.textBox_NumP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Quitter = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_numPRech = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_recherche = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_NumR
            // 
            this.comboBox_NumR.FormattingEnabled = true;
            this.comboBox_NumR.Location = new System.Drawing.Point(63, 358);
            this.comboBox_NumR.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_NumR.Name = "comboBox_NumR";
            this.comboBox_NumR.Size = new System.Drawing.Size(92, 21);
            this.comboBox_NumR.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/mm/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 142);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker1.TabIndex = 62;
            this.dateTimePicker1.Value = new System.DateTime(2019, 3, 15, 22, 33, 54, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(212, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 24);
            this.label13.TabIndex = 61;
            this.label13.Text = "Fichier Patient :";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBox_tele
            // 
            this.textBox_tele.Location = new System.Drawing.Point(106, 272);
            this.textBox_tele.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_tele.Name = "textBox_tele";
            this.textBox_tele.Size = new System.Drawing.Size(76, 20);
            this.textBox_tele.TabIndex = 57;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(106, 213);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(76, 20);
            this.textBox_email.TabIndex = 56;
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Location = new System.Drawing.Point(106, 241);
            this.textBox_adresse.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(76, 20);
            this.textBox_adresse.TabIndex = 55;
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(185, 146);
            this.label_age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(26, 13);
            this.label_age.TabIndex = 54;
            this.label_age.Text = "Age";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 310);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Mutuelle :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 215);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "E_mail :";
            // 
            // radioButton_femme
            // 
            this.radioButton_femme.AutoSize = true;
            this.radioButton_femme.Location = new System.Drawing.Point(168, 179);
            this.radioButton_femme.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_femme.Name = "radioButton_femme";
            this.radioButton_femme.Size = new System.Drawing.Size(59, 17);
            this.radioButton_femme.TabIndex = 51;
            this.radioButton_femme.TabStop = true;
            this.radioButton_femme.Text = "Femme";
            this.radioButton_femme.UseVisualStyleBackColor = true;
            // 
            // radioButton_Homme
            // 
            this.radioButton_Homme.AutoSize = true;
            this.radioButton_Homme.Location = new System.Drawing.Point(106, 179);
            this.radioButton_Homme.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Homme.Name = "radioButton_Homme";
            this.radioButton_Homme.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Homme.TabIndex = 50;
            this.radioButton_Homme.TabStop = true;
            this.radioButton_Homme.Text = "Homme";
            this.radioButton_Homme.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 182);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Sexe :";
            // 
            // textBox_PrenomP
            // 
            this.textBox_PrenomP.Location = new System.Drawing.Point(102, 113);
            this.textBox_PrenomP.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PrenomP.Name = "textBox_PrenomP";
            this.textBox_PrenomP.Size = new System.Drawing.Size(76, 20);
            this.textBox_PrenomP.TabIndex = 48;
            // 
            // textBox_NomP
            // 
            this.textBox_NomP.Location = new System.Drawing.Point(102, 84);
            this.textBox_NomP.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NomP.Name = "textBox_NomP";
            this.textBox_NomP.Size = new System.Drawing.Size(76, 20);
            this.textBox_NomP.TabIndex = 47;
            // 
            // textBox_NumP
            // 
            this.textBox_NumP.Location = new System.Drawing.Point(102, 53);
            this.textBox_NumP.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NumP.Name = "textBox_NumP";
            this.textBox_NumP.Size = new System.Drawing.Size(76, 20);
            this.textBox_NumP.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Date Naissance :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Téléphone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "CIN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Adesse :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Prénom :";
            // 
            // button_Quitter
            // 
            this.button_Quitter.Location = new System.Drawing.Point(523, 361);
            this.button_Quitter.Margin = new System.Windows.Forms.Padding(2);
            this.button_Quitter.Name = "button_Quitter";
            this.button_Quitter.Size = new System.Drawing.Size(63, 25);
            this.button_Quitter.TabIndex = 39;
            this.button_Quitter.Text = "Quitter";
            this.button_Quitter.UseVisualStyleBackColor = true;
            this.button_Quitter.Click += new System.EventHandler(this.button_Quitter_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(384, 141);
            this.button_supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(82, 28);
            this.button_supprimer.TabIndex = 38;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(384, 95);
            this.button_modifier.Margin = new System.Windows.Forms.Padding(2);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(82, 31);
            this.button_modifier.TabIndex = 37;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_numPRech);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_recherche);
            this.groupBox1.Location = new System.Drawing.Point(343, 203);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(225, 124);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // textBox_numPRech
            // 
            this.textBox_numPRech.Location = new System.Drawing.Point(98, 82);
            this.textBox_numPRech.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_numPRech.Name = "textBox_numPRech";
            this.textBox_numPRech.Size = new System.Drawing.Size(76, 20);
            this.textBox_numPRech.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NumP_Reche :";
            // 
            // button_recherche
            // 
            this.button_recherche.Location = new System.Drawing.Point(70, 29);
            this.button_recherche.Margin = new System.Windows.Forms.Padding(2);
            this.button_recherche.Name = "button_recherche";
            this.button_recherche.Size = new System.Drawing.Size(84, 24);
            this.button_recherche.TabIndex = 6;
            this.button_recherche.Text = "Rechercher";
            this.button_recherche.UseVisualStyleBackColor = true;
            this.button_recherche.Click += new System.EventHandler(this.button_recherche_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(384, 53);
            this.button_ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(82, 26);
            this.button_ajouter.TabIndex = 35;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 361);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "NumR :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 307);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 64;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 433);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox_NumR);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_tele);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_adresse);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radioButton_femme);
            this.Controls.Add(this.radioButton_Homme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_PrenomP);
            this.Controls.Add(this.textBox_NomP);
            this.Controls.Add(this.textBox_NumP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Quitter);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_NumR;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_tele;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton_femme;
        private System.Windows.Forms.RadioButton radioButton_Homme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_PrenomP;
        private System.Windows.Forms.TextBox textBox_NomP;
        private System.Windows.Forms.TextBox textBox_NumP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Quitter;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_numPRech;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_recherche;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}