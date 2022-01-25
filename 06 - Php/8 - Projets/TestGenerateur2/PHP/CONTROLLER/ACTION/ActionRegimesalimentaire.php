<?php
$elm = new Regimesalimentaire($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = RegimesalimentaireManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = RegimesalimentaireManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = RegimesalimentaireManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeRegimesalimentaire");