<?php
$elm = new Habitats($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = HabitatsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = HabitatsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = HabitatsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeHabitats");