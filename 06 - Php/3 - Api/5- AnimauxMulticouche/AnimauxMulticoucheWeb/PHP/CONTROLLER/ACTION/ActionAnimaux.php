<!-- <script src="./JS/ActionAnimaux.js"></script> -->
<?php
// $elm = new Animaux($_POST);
// die(var_dump($elm));

// switch ($_GET['mode']) {
// 	case "Ajouter": {
// 		$elm = AnimauxManager::add($elm);
// 		break;
// 	}
// 	case "Modifier": {
// 		$elm = AnimauxManager::update($elm);
// 		break;
// 	}
// 	case "Supprimer": {
// 		$elm = AnimauxManager::delete($elm);
// 		break;
// 	}
// }

header("location:index.php?page=ListeAnimaux");
