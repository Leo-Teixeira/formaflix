namespace AP3_FormaFlix
{
    partial class FormModifFormation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifFormation));
            this.label6 = new System.Windows.Forms.Label();
            this.dtp1Modif = new System.Windows.Forms.DateTimePicker();
            this.tbImageModif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCompetences = new System.Windows.Forms.GroupBox();
            this.lbCompetencesModif = new System.Windows.Forms.ListBox();
            this.cbCompetencesModif = new System.Windows.Forms.ComboBox();
            this.cbVisibleModif = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVideoModif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescriptionModif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLibelleModif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.gbCompetences.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Date de visibilité";
            // 
            // dtp1Modif
            // 
            this.dtp1Modif.Location = new System.Drawing.Point(567, 291);
            this.dtp1Modif.Name = "dtp1Modif";
            this.dtp1Modif.Size = new System.Drawing.Size(200, 20);
            this.dtp1Modif.TabIndex = 30;
            // 
            // tbImageModif
            // 
            this.tbImageModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImageModif.Location = new System.Drawing.Point(209, 230);
            this.tbImageModif.Multiline = true;
            this.tbImageModif.Name = "tbImageModif";
            this.tbImageModif.Size = new System.Drawing.Size(183, 81);
            this.tbImageModif.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Image";
            // 
            // gbCompetences
            // 
            this.gbCompetences.Controls.Add(this.lbCompetencesModif);
            this.gbCompetences.Controls.Add(this.cbCompetencesModif);
            this.gbCompetences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompetences.Location = new System.Drawing.Point(473, 46);
            this.gbCompetences.Name = "gbCompetences";
            this.gbCompetences.Size = new System.Drawing.Size(200, 211);
            this.gbCompetences.TabIndex = 27;
            this.gbCompetences.TabStop = false;
            this.gbCompetences.Text = "Ajout des compétences";
            // 
            // lbCompetencesModif
            // 
            this.lbCompetencesModif.FormattingEnabled = true;
            this.lbCompetencesModif.ItemHeight = 16;
            this.lbCompetencesModif.Location = new System.Drawing.Point(7, 73);
            this.lbCompetencesModif.Name = "lbCompetencesModif";
            this.lbCompetencesModif.Size = new System.Drawing.Size(187, 116);
            this.lbCompetencesModif.TabIndex = 1;
            // 
            // cbCompetencesModif
            // 
            this.cbCompetencesModif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompetencesModif.FormattingEnabled = true;
            this.cbCompetencesModif.Location = new System.Drawing.Point(6, 31);
            this.cbCompetencesModif.Name = "cbCompetencesModif";
            this.cbCompetencesModif.Size = new System.Drawing.Size(188, 24);
            this.cbCompetencesModif.TabIndex = 0;
            this.cbCompetencesModif.SelectedIndexChanged += new System.EventHandler(this.CbCompetencesModif_SelectedIndexChanged);
            // 
            // cbVisibleModif
            // 
            this.cbVisibleModif.AutoSize = true;
            this.cbVisibleModif.Location = new System.Drawing.Point(209, 323);
            this.cbVisibleModif.Name = "cbVisibleModif";
            this.cbVisibleModif.Size = new System.Drawing.Size(45, 17);
            this.cbVisibleModif.TabIndex = 25;
            this.cbVisibleModif.Text = "OUI";
            this.cbVisibleModif.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Visibilité Public";
            // 
            // tbVideoModif
            // 
            this.tbVideoModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVideoModif.Location = new System.Drawing.Point(209, 190);
            this.tbVideoModif.Multiline = true;
            this.tbVideoModif.Name = "tbVideoModif";
            this.tbVideoModif.Size = new System.Drawing.Size(183, 28);
            this.tbVideoModif.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Identifiant Video";
            // 
            // tbDescriptionModif
            // 
            this.tbDescriptionModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescriptionModif.Location = new System.Drawing.Point(209, 90);
            this.tbDescriptionModif.Multiline = true;
            this.tbDescriptionModif.Name = "tbDescriptionModif";
            this.tbDescriptionModif.Size = new System.Drawing.Size(183, 81);
            this.tbDescriptionModif.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Description de la formation";
            // 
            // tbLibelleModif
            // 
            this.tbLibelleModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLibelleModif.Location = new System.Drawing.Point(209, 46);
            this.tbLibelleModif.Name = "tbLibelleModif";
            this.tbLibelleModif.Size = new System.Drawing.Size(183, 22);
            this.tbLibelleModif.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Libellé de la formation";
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Black;
            this.btnModifier.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(209, 364);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(86, 41);
            this.btnModifier.TabIndex = 17;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Black;
            this.btnFermer.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(306, 364);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(86, 41);
            this.btnFermer.TabIndex = 16;
            this.btnFermer.Text = "FERMER";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // FormModifFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp1Modif);
            this.Controls.Add(this.tbImageModif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbCompetences);
            this.Controls.Add(this.cbVisibleModif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVideoModif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescriptionModif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLibelleModif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnFermer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModifFormation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModifFormation";
            this.Load += new System.EventHandler(this.FormModifFormation_Load);
            this.gbCompetences.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp1Modif;
        private System.Windows.Forms.TextBox tbImageModif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbCompetences;
        private System.Windows.Forms.ListBox lbCompetencesModif;
        private System.Windows.Forms.CheckBox cbVisibleModif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVideoModif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescriptionModif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLibelleModif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.ComboBox cbCompetencesModif;
    }
}