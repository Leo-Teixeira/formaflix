<?php

namespace models;

use models\base\SQL;
use utils\SessionHelpers;

class AccountModel extends SQL
{
    public function __construct()
    {
        parent::__construct('inscrit', 'IDINSCRIT');
    }

    public function login($username, $password)
    {
        $stmt = $this->pdo->prepare("SELECT * FROM inscrit WHERE EMAILINSCRIT=? LIMIT 1");
        $stmt->execute([$username]);
        $inscrit = $stmt->fetch(\PDO::FETCH_ASSOC);

        if ($inscrit !== false && password_verify($password, $inscrit['MOTPASSEINSCRIT'])) {
            SessionHelpers::login(array("username" => "{$inscrit["NOMINSCRIT"]} {$inscrit["PRENOMINSCRIT"]}", "email" => $inscrit["EMAILINSCRIT"]));
            return true;
        } else {
            SessionHelpers::logout();
            return false;
        }
    }

    function getDiplome()
    {
        $stmt = $this->pdo->prepare("SELECT * FROM diplome");
        $stmt->execute();
        return $stmt->fetchAll(\PDO::FETCH_ASSOC);
    }

    public function register($Email, $password, $Nom, $Prenom, $selectDiplome)
    {
        $password = password_hash($password, PASSWORD_BCRYPT);
        $stmt = $this->pdo->prepare("insert into inscrit (IDINSCRIT, NOMINSCRIT, PRENOMINSCRIT, EMAILINSCRIT, MOTPASSEINSCRIT, IDDIPLOME) value (null ,?,?,?,?,?)");
        $stmt->bindParam(1, $Nom);
        $stmt->bindParam(2, $Prenom);
        $stmt->bindParam(3, $Email);
        $stmt->bindParam(4, $password);
        $stmt->bindParam(5, $selectDiplome);
        $stmt->execute();
        return true;
    }
}