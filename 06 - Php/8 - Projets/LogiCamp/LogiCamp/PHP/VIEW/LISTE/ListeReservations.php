<?php
 echo '<div class="vBigEspace"></div>';
 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = ReservationsManager::getList();
//Création du template de la grid
echo '<div class="grid-col-8 gridListe">';

echo '<div class="grid-columns-span-8">Liste des Reservations </div>';
echo '<div class="grid-columns-span-8 gridEspace"></div>';
echo '<div class="grid-columns-span-8">
		<div></div>
			<a href="index.php?page=FormReservations&mode=Ajouter"><button>Ajouter une réservation</button></a>
		<div></div>
	  </div>';
echo '<div class="grid-columns-span-8 gridEspace"></div>';
echo '<div class="caseListe">Identité du client</div>';
echo '<div class="caseListe">Emplacement</div>';
echo '<div class="caseListe">Date de réservation</div>';
echo '<div class="caseListe">Debut de Séjour</div>';
echo '<div class="caseListe">Fin de Séjour</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
	$client=ClientsManager::findById($unObjet->getIdClient());
echo '<div class="caseListe">'.$client->getNomClient()." ".$client->getPrenomClient().'</div>';
echo '<div class="caseListe">'.EmplacementsManager::findById($unObjet->getIdEmplacement())->getRefEmplacment().'</div>';
echo '<div class="caseListe">'.(new DateTime($unObjet->getDateReservation()))->format('d/m/Y').'</div>';
echo '<div class="caseListe">'.(new DateTime($unObjet->getDebutSejour()))->format('d/m/Y').'</div>';
echo '<div class="caseListe">'.(new DateTime($unObjet->getFinSejour()))->format('d/m/Y').'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormReservations&mode=Afficher&id='.$unObjet->getIdReservation().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormReservations&mode=Modifier&id='.$unObjet->getIdReservation().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormReservations&mode=Supprimer&id='.$unObjet->getIdReservation().'"><i class="fas fa-trash-alt"></i></a></div>';
}
echo '<div class="grid-columns-span-8 gridEspace"></div>';
//Derniere ligne du tableau (bouton retour)
echo '<div class="grid-columns-span-8">
	<div></div>
	<a href="index.php?page=Accueil"><button>Retour</button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';