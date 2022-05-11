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
    public partial class FormModifFormation : Form
    {
        private int index;
        public FormModifFormation(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void FormModifFormation_Load(object sender, EventArgs e)
        {
            Controleur.VmodeleF.charger_la_formation(index);
            Controleur.VmodeleF.charger_Competences();
            chargerComboBoxCompetences();
            if (Controleur.VmodeleC.Chargement)
            {
                MessageBox.Show(index.ToString());
                if (Convert.ToInt32(Controleur.VmodeleC.DT[5].Rows[0]["VISIBILITEPUBLIC"]) == 1)
                {
                    cbVisibleModif.Checked = true;
                }
                else
                {
                    cbVisibleModif.Checked = false;
                }
                tbLibelleModif.Text = Controleur.VmodeleC.DT[5].Rows[0]["LIBELLE"].ToString();
                tbDescriptionModif.Text = Controleur.VmodeleC.DT[5].Rows[0]["DESCRIPTION"].ToString();
                tbVideoModif.Text= Controleur.VmodeleC.DT[5].Rows[0]["IDENTIFIANTVIDEO"].ToString();
                tbImageModif.Text = Controleur.VmodeleC.DT[5].Rows[0]["IMAGE"].ToString();

                dtp1Modif.Value = Convert.ToDateTime(Controleur.VmodeleC.DT[5].Rows[0]["DATEVISIBILITE"]);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (Controleur.VmodeleF.ModifFormations(index, tbLibelleModif.Text, tbDescriptionModif.Text, tbVideoModif.Text, tbImageModif.Text, cbVisibleModif.Checked, dtp1Modif.Value))
            {
                // parcourir lbCompetence
                // récuperer l'IDCOMPETENCE pour chaque compétence à ajouter
                int idC = 0;
                for (int i = 0; i < lbCompetencesModif.Items.Count; i++)
                {
                    Controleur.VmodeleF.charger_CompetenceSelonLibelle(lbCompetencesModif.Items[i].ToString());
                    if (Controleur.VmodeleC.DT[4].Rows.Count != 0)
                    {
                        idC = Convert.ToInt32(Controleur.VmodeleC.DT[4].Rows[0]["IDCOMPETENCE"]);
                        // ajouter dans la table DEVELOPPER les compétences pour la formation
                        if (Controleur.VmodeleF.AjoutDevelopper(index, idC))
                        {
                            MessageBox.Show("Lien Formation-Competence ajouté pour la compétence " + Controleur.VmodeleC.DT[4].Rows[0]["LIBELLECOMPETENCE"]);
                        }
                    }

                }
                MessageBox.Show("Formation bien modifié");
            }
            else
            {
                MessageBox.Show("Problème lors de la modification d'une formation");
            }
        }

        /// <summary>
        /// Mtéhode qui permet d'ajouter dans la comboBox tous les libellés des compétences issus de la BD (via DT[3])
        /// </summary>
        private void chargerComboBoxCompetences()
        {
            cbCompetencesModif.Items.Clear();
            if (Controleur.VmodeleC.DT[3].Rows.Count == 0)
            {
                cbCompetencesModif.Items.Add("Pas de compétences enregistrées");
                lbCompetencesModif.Visible = false;
            }
            else
            {
                for (int i = 0; i < Controleur.VmodeleC.DT[3].Rows.Count; i++)
                {
                    cbCompetencesModif.Items.Add(Controleur.VmodeleC.DT[3].Rows[i]["LIBELLECOMPETENCE"].ToString());
                }
                lbCompetencesModif.Visible = true;
                lbCompetencesModif.Items.Clear();
            }
        }

        private void CbCompetencesModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbCompetencesModif.SelectedIndex;

            // à la sélection d'une compétence dna sla comboBox : on l'ajoute dans la listBox et la supprime de la combo
            if (index != -1)
            {
                lbCompetencesModif.Items.Add(cbCompetencesModif.SelectedItem); // pour la lier à la formation dans la table DEVELOPPER lors de l'ajout
                cbCompetencesModif.Items.RemoveAt(index); // pour éviter les doublons
            }
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
