<?php
$elm = new Emplacements($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = EmplacementsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = EmplacementsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = EmplacementsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeEmplacements");