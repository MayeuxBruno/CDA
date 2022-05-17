<?php
$elm = new Students($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = StudentsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = StudentsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = StudentsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeStudents");