<?php

namespace controllers;

use controllers\base\Web;
use models\CompetenceModel;
use models\FormationModel;
use utils\SessionHelpers;

/**
 * Contrôleur des formations
 * Affichage de la liste des formations.
 */
class Formation extends Web
{
    private $formationModel;
    /**
     * @var CompetenceModel
     */
    private $competencesModel;

    function __construct()
    {
        $this->formationModel = new FormationModel();
        $this->competencesModel = new CompetenceModel();
    }

    // Affichage de la page d'accueil avec en fonction si connecté ou non une liste plus complète.
    function home()
    {
        $formations = [];
        if (!isset($_POST["selectCompetence"])) {
            // Récupération des vidéo par le modèle
            $formations = $this->formationModel->getVideos();
        } else {
            $formations = $this->formationModel->getPublicVideos($_POST["selectCompetence"]);
        }
            $competences = $this->competencesModel->getCompetences();


        $this->header();
        include("./views/formation/list.php");
        $this->footer();
    }

    /**
     * $id est automatiquement rempli via la valeur du GET
     * @param $id
     */
    function tv($id)
    {
        // Récupération de la vidéo par rapport à l'ID demandé
        $video = $this->formationModel->getByVideoId($id);
        if (!$video) {
            $this->redirect("./formations");
        }

        // Les vidéos non public ne doivent pas être visible si non connecté
        if($video['VISIBILITEPUBLIC'] == 0 && !SessionHelpers::isLogin()){
            $this->redirect("./formations");
        }

        // Compétence assocés à la vidéo
        $competences = $this->formationModel->competencesFormation($video["IDFORMATION"]);
        // commentaires assocés a la vidéo
        $commentaires = $this->formationModel->getAll(); // Récupération des commentaires présents en base.
        $this->header();
        include("./views/formation/tv.php");
        $this->footer();


    }

    function ajouter($texte = "" ,$note="")
    {
        $this->formationModel->ajouterCommentaire($texte,$note);
        $this->redirect("./formations");
    }
}