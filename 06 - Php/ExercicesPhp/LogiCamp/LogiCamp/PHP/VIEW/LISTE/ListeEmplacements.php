<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = EmplacementsManager::getList();
//Création du template de la grid
echo '<div class="grid-col-8 gridListe">';

echo '<div class="caseListe grid-columns-span-8">Liste des Emplacements </div>';
echo '<div class="caseListe grid-columns-span-8">
<div></div>
<div class="caseListe"><a href="index.php?page=FormEmplacements&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe">refEmplacment</div>';
echo '<div class="caseListe">descriptionEmplacement</div>';
echo '<div class="caseListe">eau</div>';
echo '<div class="caseListe">electricite</div>';
echo '<div class="caseListe">IdTypeEmplacement</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe">'.$unObjet->getRefEmplacment().'</div>';
echo '<div class="caseListe">'.$unObjet->getDescriptionEmplacement().'</div>';
echo '<div class="caseListe">'.$unObjet->getEau().'</div>';
echo '<div class="caseListe">'.$unObjet->getElectricite().'</div>';
echo '<div class="caseListe">'.$unObjet->getIdTypeEmplacement().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormEmplacements&mode=Afficher&id='.$unObjet->getIdEmplacement().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormEmplacements&mode=Modifier&id='.$unObjet->getIdEmplacement().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormEmplacements&mode=Supprimer&id='.$unObjet->getIdEmplacement().'"><i class="fas fa-trash-alt"></i></a></div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-8">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';