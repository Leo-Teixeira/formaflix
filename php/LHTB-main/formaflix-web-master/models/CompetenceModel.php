<?php

namespace models;

use models\base\SQL;

class CompetenceModel extends SQL
{
    public function __construct()
    {
        parent::__construct("competence", "IDCOMPETENCE");
    }

    function getCompetences()
    {
        $stmt = $this->pdo->query("SELECT * FROM `competence`");
        return $stmt->fetchAll(\PDO::FETCH_ASSOC);
    }

    function getVideoCompetence()
    {
        $stmt = $this->pdo->query("SELECT * FROM formation INNER JOIN developper ON formation.IDFORMATION = developper.IDFORMATION INNER JOIN competence ON developper.IDCOMPETENCE = competence.IDCOMPETENCE WHERE competence.IDCOMPETENCE = ?;");
        $stmt->execute(["IDCOMPTENCE"]);
    }
}