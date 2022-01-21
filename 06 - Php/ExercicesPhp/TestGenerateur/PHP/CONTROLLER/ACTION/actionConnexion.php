<?php 
// $uti =  UtilisateursManager::getList(['nom,prenom,adresseMail, motDePasse,role'], ['adresseMail' => $_POST['adresseMail']]);
$uti =  UtilisateursManager::getList(null, ['adresseMail' => $_POST['adresseMail']]);
if ($uti != null) {
    if ($uti[0]->getMotDePasse() == crypte($_POST['motDePasse'])) {       
        echo 'connection reussie';
        $_SESSION['utilisateur'] = $uti[0];
        header("location:index.php?page=accueil");
    } else {
        header("location:index.php?page=default");
    }
} else {
    header("location:index.php?page=default");
}