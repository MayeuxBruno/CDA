<?php
$elm = new Grade($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = GradeManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = GradeManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = GradeManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeGrade");