<?php

namespace models;

use models\base\SQL;

class FormationModel extends SQL
{
    public function __construct()
    {
        parent::__construct('formation', "IDFORMATION");
    }

    function getPublicVideos($competence)
    {
        $stmt = $this->pdo->prepare("SELECT * FROM formation INNER JOIN developper ON formation.IDFORMATION = developper.IDFORMATION INNER JOIN competence ON developper.IDCOMPETENCE = competence.IDCOMPETENCE WHERE competence.IDCOMPETENCE = ? AND VISIBILITEPUBLIC = 1 AND CURRENT_DATE > DATEVISIBILITE;");
        $stmt->execute([$competence]);
        return $stmt->fetchAll(\PDO::FETCH_ASSOC);
    }

    function getVideos()
    {
        return $this->getAll();
    }

    function getByVideoId($videoId)
    {
        // Utilisation d'une query a la place d'un simple getOne car la requête
        // est réalisé sur un champs différent que l'ID de la table.

        $stmt = $this->pdo->prepare("SELECT * FROM formation WHERE IDENTIFIANTVIDEO = ?");
        $stmt->execute([$videoId]);
        return $stmt->fetch(\PDO::FETCH_ASSOC);
    }

    public function competencesFormation($id)
    {
        $stmt = $this->pdo->prepare("SELECT * FROM competence LEFT JOIN developper d on competence.IDCOMPETENCE = d.IDCOMPETENCE WHERE d.IDCOMPETENCE = ?");
        $stmt->execute([$id]);
        return $stmt->fetchAll(\PDO::FETCH_ASSOC);
    }

    function ajouterCommentaire($texte,$note)
    {
        $stmt = $this->pdo->prepare("INSERT INTO commentaire (IDCOMMENTAIRE, LIBELLECOMMENTAIRE, NOTECOMMENTAIRE, STATUSCOMMENTAIRE) VALUES (null, ?, ?, 0)");
        $stmt->bindParam(1, $texte);
        $stmt->bindParam(2, $note);
        $stmt->execute();
    }
}