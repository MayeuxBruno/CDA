<?php
$elm = new Grades($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = GradesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = GradesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = GradesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeGrades");