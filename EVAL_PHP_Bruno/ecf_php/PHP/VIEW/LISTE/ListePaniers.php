<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 
$role=$_SESSION['utilisateur']->getRole();
if($role==2)
{
	$objets = PaniersManager::getList();
	if($objets==null)
	{
		echo '<div class="bigEspace"></div>';
		echo '<div class="center" >Aucun Panier a afficher </div>';
	}
	else{
		//Création du template de la grid

	echo '<div class="grid-col-6 gridListe">';

	echo '<div class="caseListe titreListe grid-columns-span-6">Liste des Paniers </div>';
	echo '<div class="caseListe grid-columns-span-6">
	<div></div>
	<div class="caseListe"><a href="index.php?page=FormPaniers&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
	<div></div>
	</div>';

	echo '<div ></div>';
	echo '<div class="caseListe bold">Client</div>';
	echo '<div class="caseListe bold">Nombre d\'article</div>';

	//Remplissage de div vide pour la structure de la grid
	echo '<div class="caseListe"></div>';
	echo '<div class="caseListe"></div>';
	echo '<div class="caseListe"></div>';

	// Affichage des ennregistrements de la base de données
	foreach($objets as $unObjet)
	{
		$lignes=LignespaniersManager::getList(['Quantite'], ['IdPanier'=>$unObjet->getIdPanier()]);
		$quantite=0;
		foreach($lignes as $uneLigne)
		{
			$quantite+=$uneLigne->getQuantite();
		}

	$client=UtilisateursManager::findById($unObjet->getIdClient());
	echo '<div class="caseListe donneeListe"></div>';
	echo '<div class="caseListe donneeListe">'.$client->getNom().' '.$client->getPrenom().'</div>';
	echo '<div class="caseListe donneeListe">'.$quantite.'</div>';


	echo '<div class="caseListe"> <a href="index.php?page=FormPaniers&mode=Afficher&id='.$unObjet->getIdPanier().'"><i class="fas fa-file-contract"></i></a></div>';
														
	echo '<div class="caseListe"> <a href="index.php?page=FormPaniers&mode=Modifier&id='.$unObjet->getIdPanier().'"><i class="fas fa-pen"></i></a></div>';
														
	echo '<div class="caseListe"> <a href="index.php?page=FormPaniers&mode=Supprimer&id='.$unObjet->getIdPanier().'"><i class="fas fa-trash-alt"></i></a></div>';
	}
	//Derniere ligne du tableau (bouton retour)
	echo '<div class="caseListe grid-columns-span-6">
		<div></div>
		<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180 "></i></button></a>
		<div></div>
	</div>';

	echo'</div>'; //Grid
	echo'</div>'; //Div
	echo '<div class="flex-0-1"></div>';

	}
	echo '</main>';
}
else{
	$objets = PaniersManager::getList(null,['IdClient'=>$_SESSION['utilisateur']->getIdUtilisateur()]);
	//var_dump($objets);
	if($objets==null)
	{
		echo '<div class="bigEspace"></div>';
		echo '<div class="center" >Aucun Panier a afficher </div>';
	}
	else{
		//Création du template de la grid

	echo '<div class="grid-col-6 gridListe">';

	echo '<div class="caseListe titreListe grid-columns-span-6">Liste des Lignes du Paniers </div>';
	echo '<div class="caseListe grid-columns-span-6">
	<div></div>
	<div class="caseListe"><a href="index.php?page=FormPaniers&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
	<div></div>
	</div>';

	echo '<div ></div>';
	echo '<div class="caseListe bold">Article</div>';
	echo '<div class="caseListe bold">Nombre d\'article</div>';

	//Remplissage de div vide pour la structure de la grid
	echo '<div class="caseListe"></div>';
	echo '<div class="caseListe"></div>';
	echo '<div class="caseListe"></div>';

	// Affichage des ennregistrements de la base de données
	foreach($objets as $unObjet)
	{
		$lignes=LignespaniersManager::getList(null, ['IdPanier'=>$unObjet->getIdPanier()]);
		foreach($lignes as $uneLigne)
		{
			echo '<div class="caseListe donneeListe"></div>';
			echo '<div class="caseListe donneeListe">'.ArticlesManager::findById($uneLigne->getIdArticle())->getLibelleArticle().'</div>';
			echo '<div class="caseListe donneeListe">'.$uneLigne->getQuantite().'</div>';


																
			echo '<div class="caseListe"> <a href="index.php?page=FormPaniers&mode=Modifier&id='.$unObjet->getIdPanier().'"><i class="fas fa-pen"></i></a></div>';
																
			echo '<div class="caseListe"> <a href="index.php?page=FormPaniers&mode=Supprimer&id='.$unObjet->getIdPanier().'"><i class="fas fa-trash-alt"></i></a></div>';
			echo '<div class="caseListe"> </div>';
		}
	}
	//Derniere ligne du tableau (bouton retour)
	echo '<div class="caseListe grid-columns-span-6">
		<div></div>
		<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180 "></i></button></a>
		<div></div>
	</div>';

	echo'</div>'; //Grid
	echo'</div>'; //Div
	echo '<div class="flex-0-1"></div>';

	}
echo '</main>';
}



