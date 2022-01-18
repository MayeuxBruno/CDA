<?php
$pasDErreur = true;
$reunion = new Reunions($_POST);
switch ($_GET['mode']) {
    case "Ajouter": {
            $pasDErreur = ReunionsManager::add($reunion);
            break;
        }
    case "Modifier": {

            $pasDErreur = ReunionsManager::update($reunion);
            break;
        }
    case "Supprimer": {

            $pasDErreur = ReunionsManager::delete($reunion);
            break;
        }
}
if ($pasDErreur) { // si pas d'erreur
    header("location:index.php?page=listeProduit");
} else {
    header("location:index.php?page=erreur&cible=listeProduit&codeErreur=erreur" . $_GET['mode']);
}