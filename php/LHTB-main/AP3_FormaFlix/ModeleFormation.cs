using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace AP3_FormaFlix
{
    public class ModeleFormation
    {

        public ModeleFormation()
        { }

        /// <summary>
        /// Méthode qui récupère toutes les informations sur les formations
        /// </summary>
        public void charger_Formations()
        {
            Controleur.VmodeleC.charger("select IDFORMATION, LIBELLE, DESCRIPTION, IDENTIFIANTVIDEO, VISIBILITEPUBLIC, DATEVISIBILITE, IMAGE from formation;", Controleur.VmodeleC.DT[1]);
        }

        /// <summary>
        /// Métbode qui récupère les compétences liées à une formatuion dont l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="idF">ID de la formation</param>
        public void charger_CompetencesSelonFormation(int idF)
        {
            Controleur.VmodeleC.charger("select IDFORMATION, C.IDCOMPETENCE, LIBELLECOMPETENCE from competence C INNER JOIN developper D ON C.IDCOMPETENCE = D.IDCOMPETENCE WHERE IDFORMATION = " + idF + ";", Controleur.VmodeleC.DT[2]);
        }


        /// <summary>
        /// Métbode qui récupère toutes les compétences
        /// </summary>
        public void charger_Competences()
        {
            Controleur.VmodeleC.charger("select IDCOMPETENCE, LIBELLECOMPETENCE from competence;", Controleur.VmodeleC.DT[3]);
        }

        /// <summary>
        /// étbode qui récupère la compétence (identifiant et libellé) selon le libellé de compétence passé en paramètre s'il existe
        /// </summary>
        /// <param name="libC">libellé de la compétence</param>
        public void charger_CompetenceSelonLibelle(string libC)
        {
            Controleur.VmodeleC.charger("select IDCOMPETENCE, LIBELLECOMPETENCE from competence  WHERE LIBELLECOMPETENCE = '" + libC + "';", Controleur.VmodeleC.DT[4]);
        }

        public void charger_la_formation(int index)
        {
            Controleur.VmodeleC.charger("select IDFORMATION, LIBELLE, DESCRIPTION, IDENTIFIANTVIDEO, VISIBILITEPUBLIC, DATEVISIBILITE, IMAGE from formation WHERE IDFORMATION = '" + index + "';", Controleur.VmodeleC.DT[5]);
        }
        /// <summary>
        /// Permet d'ajouter une formation à la table FORMATION avec les éléments du formulaire passés en paramètre
        /// </summary>
        /// <param name="libelle"></param>
        /// <param name="description"></param>
        /// <param name="video"></param>
        /// <param name="visible"></param>
        /// <returns></returns>
        public bool AjoutFormation(string libelle, string description, string video, string image, bool visible, DateTime dateVisibilite)
        {
            try
            {
                // préparation de la requête 
                string requete = "insert into formation values (null, @lib, @descr, @dateVisibilite, @v, @visible, @image)";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("lib", libelle);
                command.Parameters.AddWithValue("descr", description);
                command.Parameters.AddWithValue("dateVisibilite", dateVisibilite);
                command.Parameters.AddWithValue("v", video);
                command.Parameters.AddWithValue("visible", visible);
                command.Parameters.AddWithValue("image", image);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();

                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Permet de supprimer une formation de la table FORMATION avec les éléments du formulaire passés en paramètre
        /// <param name="libelle"></param>
        /// <param name="description"></param>
        /// <param name="video"></param>
        /// <param name="visible"></param>
        /// <param name="dateVisibilite"></param>
        /// </summary>
        public bool SuppFormation(string id)
        {
            try
            {
                // préparation de la requête 
                string requeteDevelopper = "delete from developper where IDFORMATION = @id";
                string requete = "delete from formation where IDFORMATION = @id";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;
                MySqlCommand commandDevelopper = Controleur.VmodeleC.MyConnection.CreateCommand();
                commandDevelopper.CommandText = requeteDevelopper;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("id", id);
                commandDevelopper.Parameters.AddWithValue("id", id);
                // Exécution de la requête
                int j = commandDevelopper.ExecuteNonQuery();
                int i = command.ExecuteNonQuery();
                

                // i est positif si l'insertion a pu avoir lieu
                return (i > 0 || j > 0);
            }
            catch
            {
                return false;
            }
        }

        public bool ChargerCompetenceFormation(int index)
        {
            try
            {
                // préparation de la requête 
                string requete = "select IDCOMPETENCE from competence where IDFORMATION = @index";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("index", index);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();

                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="libelle"></param>
        /// <param name="description"></param>
        /// <param name="video"></param>
        /// <param name="image"></param>
        /// <param name="visible"></param>
        /// <param name="dateVisibilite"></param>
        /// <returns></returns>
        public bool ModifFormations(int index, string libelle, string description, string video, string image, bool visible, DateTime dateVisibilite)
        {
            try
            {
                // préparation de la requête 
                //string updateCompetence = "insert into developper values (@index, @competence)";
                string updateFormation = "update formation set LIBELLE = @lib, DESCRIPTION = @descr, DATEVISIBILITE = @dateVisibilite, IDENTIFIANTVIDEO = @v, VISIBILITEPUBLIC = @visible, IMAGE = @image where IDFORMATION = @index";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                //MySqlCommand commandCompetence = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = updateFormation;
                //commandCompetence.CommandText = updateCompetence;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("index", index);
                command.Parameters.AddWithValue("lib", libelle);
                command.Parameters.AddWithValue("descr", description);
                command.Parameters.AddWithValue("dateVisibilite", dateVisibilite);
                command.Parameters.AddWithValue("v", video);
                command.Parameters.AddWithValue("visible", visible);
                command.Parameters.AddWithValue("image", image);
                //commandCompetence.Parameters.AddWithValue("competence", competence);
                //commandCompetence.Parameters.AddWithValue("index", index);
                // Exécution de la requête
                //int j = commandCompetence.ExecuteNonQuery();
                int i = command.ExecuteNonQuery();

                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch(Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Permet d'ajouter un lien entre une formation et une compétence (avec les identifiants) dans la table DEVELOPPER
        /// </summary>
        /// <param name="idF"></param>
        /// <param name="idC"></param>
        /// <returns></returns>
        public bool AjoutDevelopper(int idF, int idC)
        {
            try
            {
                // préparation de la requête 
                string requete = "insert into developper values (@IDF, @IDC)";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("IDF", idF);
                command.Parameters.AddWithValue("IDC", idC);
            
                // Exécution de la requête
                int i = command.ExecuteNonQuery();

                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }
    }
}
