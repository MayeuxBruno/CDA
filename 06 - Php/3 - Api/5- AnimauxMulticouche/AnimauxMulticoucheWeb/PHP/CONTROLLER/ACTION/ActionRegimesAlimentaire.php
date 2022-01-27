<?php
$elm = new RegimesAlimentaire($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = RegimesAlimentaireManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = RegimesAlimentaireManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = RegimesAlimentaireManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeRegimesAlimentaire");