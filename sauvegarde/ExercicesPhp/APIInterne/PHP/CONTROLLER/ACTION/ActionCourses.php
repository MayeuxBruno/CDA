<?php
$elm = new Courses($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = CoursesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = CoursesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = CoursesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeCourses");