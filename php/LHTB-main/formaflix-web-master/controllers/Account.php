<?php


namespace controllers;


use controllers\base\Web;
use models\AccountModel;
use utils\SessionHelpers;

class Account extends Web
{
    protected $accountModel;

    public function __construct()
    {
        $this->accountModel = new AccountModel();
    }

    // Méthode de connexion. Prise des paramètre en POST
    function login()
    {
        $error = false;
        if (isset($_POST['login']) && isset($_POST['password'])) {
            if ($this->accountModel->login($_POST["login"], $_POST["password"])) {
                $this->redirect("me");
            } else {
                // Connexion impossible avec les identifiants fourni.
                $error = true;
            }
        }

        $this->header();
        include("views/account/login.php");
        $this->footer();
    }

    // Déconnexion et suppression de la SESSION.
    function logout()
    {
        SessionHelpers::logout();
        $this->redirect("./login");
    }

    // Affiche l'utilisateur actuellement connecté.
    function me()
    {
        $this->header();
        include("views/account/me.php");
        $this->footer();
    }

    //Méthode d'inscription
    function register()
    {
        $diplomes = $this->accountModel->GetDiplome();
        if (isset($_POST['Email']) && isset($_POST['password']) && isset($_POST['Nom']) && isset($_POST['Prenom']) && isset($_POST['selectDiplome']))
        {
            if ($this->accountModel->register($_POST["Email"], $_POST["password"], $_POST['Nom'], $_POST["Prenom"],$_POST['selectDiplome']))
            {
                $this->redirect("login");
            }
        }
        $this->header();
        include("views/account/register.php");
        $this->footer();


    }
}