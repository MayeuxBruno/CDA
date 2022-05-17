<?php
$elm = new Typesarticles($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = TypesarticlesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = TypesarticlesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = TypesarticlesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeTypesarticles");