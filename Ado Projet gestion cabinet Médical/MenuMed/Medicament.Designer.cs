namespace MenuMed
{
    partial class Medicament
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox2_Dosage = new System.Windows.Forms.TextBox();
            this.SUPPRIMER = new System.Windows.Forms.Button();
            this.ANNULER = new System.Windows.Forms.Button();
            this.AJOUTER = new System.Windows.Forms.Button();
            this.MODIFIER = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Forme = new System.Windows.Forms.ComboBox();
            this.textBox1_Num = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Forme = new System.Windows.Forms.Label();
            this.Dosage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumMédi = new System.Windows.Forms.Label();
            this.Médicament = new System.Windows.Forms.Label();
            this.textBox_NomMedi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2_Dosage
            // 
            this.textBox2_Dosage.Location = new System.Drawing.Point(217, 179);
            this.textBox2_Dosage.Name = "textBox2_Dosage";
            this.textBox2_Dosage.Size = new System.Drawing.Size(182, 20);
            this.textBox2_Dosage.TabIndex = 32;
            // 
            // SUPPRIMER
            // 
            this.SUPPRIMER.BackColor = System.Drawing.SystemColors.Control;
            this.SUPPRIMER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SUPPRIMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUPPRIMER.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SUPPRIMER.Location = new System.Drawing.Point(496, 198);
            this.SUPPRIMER.Name = "SUPPRIMER";
            this.SUPPRIMER.Size = new System.Drawing.Size(122, 29);
            this.SUPPRIMER.TabIndex = 31;
            this.SUPPRIMER.Text = "SUPPRIMER";
            this.SUPPRIMER.UseVisualStyleBackColor = false;
            this.SUPPRIMER.Click += new System.EventHandler(this.SUPPRIMER_Click);
            // 
            // ANNULER
            // 
            this.ANNULER.BackColor = System.Drawing.SystemColors.Control;
            this.ANNULER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ANNULER.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ANNULER.Location = new System.Drawing.Point(1042, 531);
            this.ANNULER.Name = "ANNULER";
            this.ANNULER.Size = new System.Drawing.Size(122, 29);
            this.ANNULER.TabIndex = 30;
            this.ANNULER.Text = "ANNULER";
            this.ANNULER.UseVisualStyleBackColor = false;
            // 
            // AJOUTER
            // 
            this.AJOUTER.BackColor = System.Drawing.SystemColors.Control;
            this.AJOUTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AJOUTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AJOUTER.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AJOUTER.Location = new System.Drawing.Point(496, 94);
            this.AJOUTER.Name = "AJOUTER";
            this.AJOUTER.Size = new System.Drawing.Size(122, 29);
            this.AJOUTER.TabIndex = 29;
            this.AJOUTER.Text = "AJOUTER";
            this.AJOUTER.UseVisualStyleBackColor = false;
            this.AJOUTER.Click += new System.EventHandler(this.AJOUTER_Click);
            // 
            // MODIFIER
            // 
            this.MODIFIER.BackColor = System.Drawing.SystemColors.Control;
            this.MODIFIER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MODIFIER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODIFIER.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MODIFIER.Location = new System.Drawing.Point(496, 146);
            this.MODIFIER.Name = "MODIFIER";
            this.MODIFIER.Size = new System.Drawing.Size(122, 30);
            this.MODIFIER.TabIndex = 28;
            this.MODIFIER.Text = "MODIFIER";
            this.MODIFIER.UseVisualStyleBackColor = false;
            this.MODIFIER.Click += new System.EventHandler(this.MODIFIER_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(24, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Liste de Médicament";
            // 
            // comboBox_Forme
            // 
            this.comboBox_Forme.DisplayMember = "DOLIPRANE";
            this.comboBox_Forme.FormattingEnabled = true;
            this.comboBox_Forme.Location = new System.Drawing.Point(217, 228);
            this.comboBox_Forme.Name = "comboBox_Forme";
            this.comboBox_Forme.Size = new System.Drawing.Size(180, 21);
            this.comboBox_Forme.TabIndex = 26;
            this.comboBox_Forme.ValueMember = "DOLIPRANE";
            // 
            // textBox1_Num
            // 
            this.textBox1_Num.Location = new System.Drawing.Point(219, 94);
            this.textBox1_Num.Name = "textBox1_Num";
            this.textBox1_Num.Size = new System.Drawing.Size(180, 20);
            this.textBox1_Num.TabIndex = 24;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 145);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Forme
            // 
            this.Forme.AutoSize = true;
            this.Forme.BackColor = System.Drawing.Color.Transparent;
            this.Forme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Forme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Forme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Forme.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Forme.Location = new System.Drawing.Point(24, 225);
            this.Forme.Name = "Forme";
            this.Forme.Size = new System.Drawing.Size(62, 22);
            this.Forme.TabIndex = 21;
            this.Forme.Text = "Forme";
            // 
            // Dosage
            // 
            this.Dosage.AutoSize = true;
            this.Dosage.BackColor = System.Drawing.Color.Transparent;
            this.Dosage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dosage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Dosage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Dosage.Location = new System.Drawing.Point(24, 175);
            this.Dosage.Name = "Dosage";
            this.Dosage.Size = new System.Drawing.Size(73, 22);
            this.Dosage.TabIndex = 20;
            this.Dosage.Text = "Dosage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(24, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nom Médicament";
            // 
            // NumMédi
            // 
            this.NumMédi.AutoSize = true;
            this.NumMédi.BackColor = System.Drawing.Color.Transparent;
            this.NumMédi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumMédi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumMédi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.NumMédi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.NumMédi.Location = new System.Drawing.Point(24, 94);
            this.NumMédi.Name = "NumMédi";
            this.NumMédi.Size = new System.Drawing.Size(175, 22);
            this.NumMédi.TabIndex = 18;
            this.NumMédi.Text = "Numéro Médicament";
            // 
            // Médicament
            // 
            this.Médicament.AutoSize = true;
            this.Médicament.BackColor = System.Drawing.Color.Transparent;
            this.Médicament.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Médicament.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Médicament.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Médicament.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Médicament.Location = new System.Drawing.Point(231, 7);
            this.Médicament.MinimumSize = new System.Drawing.Size(60, 0);
            this.Médicament.Name = "Médicament";
            this.Médicament.Size = new System.Drawing.Size(236, 53);
            this.Médicament.TabIndex = 22;
            this.Médicament.Text = "Médicament";
            this.Médicament.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_NomMedi
            // 
            this.textBox_NomMedi.Location = new System.Drawing.Point(219, 136);
            this.textBox_NomMedi.Name = "textBox_NomMedi";
            this.textBox_NomMedi.Size = new System.Drawing.Size(180, 20);
            this.textBox_NomMedi.TabIndex = 34;
            // 
            // Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 482);
            this.Controls.Add(this.textBox_NomMedi);
            this.Controls.Add(this.textBox2_Dosage);
            this.Controls.Add(this.SUPPRIMER);
            this.Controls.Add(this.ANNULER);
            this.Controls.Add(this.AJOUTER);
            this.Controls.Add(this.MODIFIER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Forme);
            this.Controls.Add(this.textBox1_Num);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Forme);
            this.Controls.Add(this.Dosage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumMédi);
            this.Controls.Add(this.Médicament);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Medicament";
            this.Text = "Medicament";
            this.Load += new System.EventHandler(this.Medicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2_Dosage;
        private System.Windows.Forms.Button SUPPRIMER;
        private System.Windows.Forms.Button ANNULER;
        private System.Windows.Forms.Button AJOUTER;
        private System.Windows.Forms.Button MODIFIER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Forme;
        private System.Windows.Forms.TextBox textBox1_Num;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Forme;
        private System.Windows.Forms.Label Dosage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NumMédi;
        private System.Windows.Forms.Label Médicament;
        private System.Windows.Forms.TextBox textBox_NomMedi;
    }
}