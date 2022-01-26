<?php
$elm = new Student($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = StudentManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = StudentManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = StudentManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeStudent");