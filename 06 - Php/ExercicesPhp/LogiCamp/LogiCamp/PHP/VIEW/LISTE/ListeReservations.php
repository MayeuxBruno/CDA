<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = ReservationsManager::getList();
//Création du template de la grid
echo '<div class="grid-col-8 gridListe">';

echo '<div class="caseListe grid-columns-span-8">Liste des Reservations </div>';
echo '<div class="caseListe grid-columns-span-8">
<div></div>
<div class="caseListe"><a href="index.php?page=FormReservations&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe">idClient</div>';
echo '<div class="caseListe">idEmplacement</div>';
echo '<div class="caseListe">dateReservation</div>';
echo '<div class="caseListe">debutSejour</div>';
echo '<div class="caseListe">finSejour</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe">'.$unObjet->getIdClient().'</div>';
echo '<div class="caseListe">'.$unObjet->getIdEmplacement().'</div>';
echo '<div class="caseListe">'.$unObjet->getDateReservation().'</div>';
echo '<div class="caseListe">'.$unObjet->getDebutSejour().'</div>';
echo '<div class="caseListe">'.$unObjet->getFinSejour().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormReservations&mode=Afficher&id='.$unObjet->getIdReservation().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormReservations&mode=Modifier&id='.$unObjet->getIdReservation().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormReservations&mode=Supprimer&id='.$unObjet->getIdReservation().'"><i class="fas fa-trash-alt"></i></a></div>';
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