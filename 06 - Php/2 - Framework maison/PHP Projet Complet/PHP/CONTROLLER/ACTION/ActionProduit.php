<?php
$p = new Produits($_POST);
switch ($_GET['mode']) {
    case "Ajouter": {
            ProduitsManager::add($p);
            break;
        }
    case "Modifier": {

            ProduitsManager::update($p);
            break;
        }
    case "Supprimer": {

            ProduitsManager::delete($p);
            break;
        }
}

header("location:index.php?page=listeProduit");
