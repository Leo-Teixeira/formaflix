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
    public partial class ListeCommentaire : Form
    {
        private BindingSource bS1;
        public ListeCommentaire()
        {
            InitializeComponent();
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            Controleur.VmodeleCom.changer_status(dvgCommentaire.SelectedRows);
        }

        private void ListeCommentaire_Load(object sender, EventArgs e)
        {
            Controleur.initCommentaire();
            if (Controleur.VmodeleC.Connopen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
            }
            else
            {
                // chargement des données de la table FORMATION via DT[1] et affichage dans un dataGridView
                Controleur.VmodeleCom.charger_Commentaire();
                if (Controleur.VmodeleC.Chargement)
                {
                    bS1 = new BindingSource();

                    bS1.DataSource = Controleur.VmodeleC.DT[6];
                    dvgCommentaire.DataSource = bS1;
                    dvgCommentaire.Columns[0].HeaderText = "ID COMMENTAIRE";
                    dvgCommentaire.Columns[1].HeaderText = "LIBELLE COMMENTAIRE";
                    dvgCommentaire.Columns[2].HeaderText = "NOTE COMMENTAIRE";
                    dvgCommentaire.Columns[3].HeaderText = "STATUS COMMENTAIRE";

                    // mise à jour du dataGridView via le bindingSource rempli par le DataTable
                    dvgCommentaire.Refresh();
                    dvgCommentaire.Visible = true;
                }
            }
        }
    }
}
