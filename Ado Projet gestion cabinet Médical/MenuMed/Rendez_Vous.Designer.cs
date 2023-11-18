namespace MenuMed
{
    partial class Rendez_Vous
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_Quiter = new System.Windows.Forms.Button();
            this.dateTimePicker_HeureR = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DateR = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_RendezVous = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Dernier = new System.Windows.Forms.Button();
            this.button_Suivant = new System.Windows.Forms.Button();
            this.button_Précédent = new System.Windows.Forms.Button();
            this.button_Premier = new System.Windows.Forms.Button();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.button_Modifier = new System.Windows.Forms.Button();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.comboBox_journee = new System.Windows.Forms.ComboBox();
            this.textBox_NumR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RendezVous)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Quiter
            // 
            this.button_Quiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Quiter.ForeColor = System.Drawing.Color.Navy;
            this.button_Quiter.Location = new System.Drawing.Point(551, 410);
            this.button_Quiter.Name = "button_Quiter";
            this.button_Quiter.Size = new System.Drawing.Size(87, 29);
            this.button_Quiter.TabIndex = 59;
            this.button_Quiter.Text = "Quiter";
            this.button_Quiter.UseVisualStyleBackColor = true;
            this.button_Quiter.Click += new System.EventHandler(this.button_Quiter_Click);
            // 
            // dateTimePicker_HeureR
            // 
            this.dateTimePicker_HeureR.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_HeureR.Location = new System.Drawing.Point(583, 140);
            this.dateTimePicker_HeureR.Name = "dateTimePicker_HeureR";
            this.dateTimePicker_HeureR.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker_HeureR.TabIndex = 58;
            // 
            // dateTimePicker_DateR
            // 
            this.dateTimePicker_DateR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DateR.Location = new System.Drawing.Point(178, 181);
            this.dateTimePicker_DateR.Name = "dateTimePicker_DateR";
            this.dateTimePicker_DateR.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_DateR.TabIndex = 57;
            // 
            // dataGridView_RendezVous
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_RendezVous.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_RendezVous.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_RendezVous.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_RendezVous.Location = new System.Drawing.Point(86, 298);
            this.dataGridView_RendezVous.Name = "dataGridView_RendezVous";
            this.dataGridView_RendezVous.Size = new System.Drawing.Size(398, 150);
            this.dataGridView_RendezVous.TabIndex = 56;
            this.dataGridView_RendezVous.Click += new System.EventHandler(this.dataGridView_RendezVous_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(184, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Gestion des Rendez_Vous";
            // 
            // button_Dernier
            // 
            this.button_Dernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Dernier.ForeColor = System.Drawing.Color.Navy;
            this.button_Dernier.Location = new System.Drawing.Point(422, 246);
            this.button_Dernier.Name = "button_Dernier";
            this.button_Dernier.Size = new System.Drawing.Size(75, 28);
            this.button_Dernier.TabIndex = 54;
            this.button_Dernier.Text = ">>";
            this.button_Dernier.UseVisualStyleBackColor = true;
            this.button_Dernier.Click += new System.EventHandler(this.button_Dernier_Click);
            // 
            // button_Suivant
            // 
            this.button_Suivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Suivant.ForeColor = System.Drawing.Color.Navy;
            this.button_Suivant.Location = new System.Drawing.Point(308, 246);
            this.button_Suivant.Name = "button_Suivant";
            this.button_Suivant.Size = new System.Drawing.Size(75, 28);
            this.button_Suivant.TabIndex = 53;
            this.button_Suivant.Text = ">";
            this.button_Suivant.UseVisualStyleBackColor = true;
            this.button_Suivant.Click += new System.EventHandler(this.button_Suivant_Click);
            // 
            // button_Précédent
            // 
            this.button_Précédent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Précédent.ForeColor = System.Drawing.Color.Navy;
            this.button_Précédent.Location = new System.Drawing.Point(188, 246);
            this.button_Précédent.Name = "button_Précédent";
            this.button_Précédent.Size = new System.Drawing.Size(75, 28);
            this.button_Précédent.TabIndex = 52;
            this.button_Précédent.Text = "<";
            this.button_Précédent.UseVisualStyleBackColor = true;
            this.button_Précédent.Click += new System.EventHandler(this.button_Précédent_Click);
            // 
            // button_Premier
            // 
            this.button_Premier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Premier.ForeColor = System.Drawing.Color.Navy;
            this.button_Premier.Location = new System.Drawing.Point(59, 246);
            this.button_Premier.Name = "button_Premier";
            this.button_Premier.Size = new System.Drawing.Size(75, 28);
            this.button_Premier.TabIndex = 51;
            this.button_Premier.Text = "<<";
            this.button_Premier.UseVisualStyleBackColor = true;
            this.button_Premier.Click += new System.EventHandler(this.button_Premier_Click);
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Supprimer.ForeColor = System.Drawing.Color.Navy;
            this.button_Supprimer.Location = new System.Drawing.Point(551, 375);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(87, 29);
            this.button_Supprimer.TabIndex = 50;
            this.button_Supprimer.Text = "Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // button_Modifier
            // 
            this.button_Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modifier.ForeColor = System.Drawing.Color.Navy;
            this.button_Modifier.Location = new System.Drawing.Point(551, 340);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(87, 29);
            this.button_Modifier.TabIndex = 49;
            this.button_Modifier.Text = "Modifier";
            this.button_Modifier.UseVisualStyleBackColor = true;
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ajouter.ForeColor = System.Drawing.Color.Navy;
            this.button_Ajouter.Location = new System.Drawing.Point(551, 298);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(87, 29);
            this.button_Ajouter.TabIndex = 48;
            this.button_Ajouter.Text = "Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // comboBox_journee
            // 
            this.comboBox_journee.FormattingEnabled = true;
            this.comboBox_journee.Location = new System.Drawing.Point(572, 184);
            this.comboBox_journee.Name = "comboBox_journee";
            this.comboBox_journee.Size = new System.Drawing.Size(121, 21);
            this.comboBox_journee.TabIndex = 47;
            // 
            // textBox_NumR
            // 
            this.textBox_NumR.Location = new System.Drawing.Point(178, 144);
            this.textBox_NumR.Name = "textBox_NumR";
            this.textBox_NumR.Size = new System.Drawing.Size(200, 20);
            this.textBox_NumR.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(445, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "NumJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(445, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "HeureR;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(50, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "DateR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(50, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "NumR:";
            // 
            // Rendez_Vous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 470);
            this.Controls.Add(this.button_Quiter);
            this.Controls.Add(this.dateTimePicker_HeureR);
            this.Controls.Add(this.dateTimePicker_DateR);
            this.Controls.Add(this.dataGridView_RendezVous);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Dernier);
            this.Controls.Add(this.button_Suivant);
            this.Controls.Add(this.button_Précédent);
            this.Controls.Add(this.button_Premier);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.button_Modifier);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.comboBox_journee);
            this.Controls.Add(this.textBox_NumR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Rendez_Vous";
            this.Text = "Rendez_Vous";
            this.Load += new System.EventHandler(this.Rendez_Vous_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RendezVous)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Quiter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_HeureR;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateR;
        private System.Windows.Forms.DataGridView dataGridView_RendezVous;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Dernier;
        private System.Windows.Forms.Button button_Suivant;
        private System.Windows.Forms.Button button_Précédent;
        private System.Windows.Forms.Button button_Premier;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button button_Modifier;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.ComboBox comboBox_journee;
        private System.Windows.Forms.TextBox textBox_NumR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}