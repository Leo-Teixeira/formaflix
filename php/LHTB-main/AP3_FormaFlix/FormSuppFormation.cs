using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_FormaFlix
{
    public partial class FormSuppFormation : Form
    {
        public FormSuppFormation()
        {
            InitializeComponent();
        }

        private void FormSuppFormation_Load(object sender, EventArgs e)
        {
            // instanciation du ModeleFormation VmodeleF
            Controleur.initFormation();
            if (Controleur.VmodeleC.Connopen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
            }
            else
            {
                // chargement des données de la table FORMATION via DT[1] et affichage dans un dataGridView
                Controleur.VmodeleF.charger_Formations();
                if (Controleur.VmodeleC.Chargement)
                {
                    // si des compétences existent pour cette formation, on les ajoute dans la listBox
                    for (int i = 0; i < Controleur.VmodeleC.DT[1].Rows.Count; i++)
                    {
                        lbSupp.Items.Add(Controleur.VmodeleC.DT[1].Rows[i]["IDFORMATION"].ToString() + " : " + Controleur.VmodeleC.DT[1].Rows[i]["LIBELLE"].ToString());
                    }

                    // mise à jour du dataGridView via le bindingSource rempli par le DataTable
                    lbSupp.Refresh();
                    lbSupp.Visible = true;
                }




            }
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (Controleur.VmodeleF.SuppFormation(Controleur.VmodeleC.DT[1].Rows[lbSupp.SelectedIndex]["IDFORMATION"].ToString()))
            {
                MessageBox.Show("Formation bien supprimer");
            }
            else
            {
                MessageBox.Show("Problème lors de la suppression d'une formation");
            }
        }
    }
}
