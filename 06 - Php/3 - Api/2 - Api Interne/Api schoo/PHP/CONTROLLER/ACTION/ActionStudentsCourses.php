<?php
$elm = new StudentsCourses($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = StudentsCoursesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = StudentsCoursesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = StudentsCoursesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeStudentsCourses");