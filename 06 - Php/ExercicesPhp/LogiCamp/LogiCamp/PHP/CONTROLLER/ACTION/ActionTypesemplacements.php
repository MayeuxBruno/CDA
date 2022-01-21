<?php
$elm = new Typesemplacements($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = TypesemplacementsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = TypesemplacementsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = TypesemplacementsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeTypesemplacements");