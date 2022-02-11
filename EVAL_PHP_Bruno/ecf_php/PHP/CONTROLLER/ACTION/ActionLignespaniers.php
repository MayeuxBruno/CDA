<?php

$elm = new Lignespaniers($_POST);
$
$panierClient=PaniersManager::getList(null,['IdClient'=>$_SESSION['utilisateur']->getIdUtilisateur()]);
var_dump($elm);

 if($panierClient==null)
 {
	$date=new Date ('now');
 	$panierClient=new Panier ();
	
	
 }



switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = LignespaniersManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = LignespaniersManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = LignespaniersManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListePaniers");