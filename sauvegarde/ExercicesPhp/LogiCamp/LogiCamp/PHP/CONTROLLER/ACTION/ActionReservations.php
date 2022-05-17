<?php
$elm = new Reservations($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = ReservationsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = ReservationsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = ReservationsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeReservations");