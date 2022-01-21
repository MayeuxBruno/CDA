<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = ClientsManager::getList();
//Création du template de la grid
echo '<div class="grid-col-9 gridListe">';

echo '<div class="caseListe grid-columns-span-9">Liste des Clients </div>';
echo '<div class="caseListe grid-columns-span-9">
<div></div>
<div class="caseListe"><a href="index.php?page=FormClients&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe">nomClient</div>';
echo '<div class="caseListe">prenomClient</div>';
echo '<div class="caseListe">telClient</div>';
echo '<div class="caseListe">mailClient</div>';
echo '<div class="caseListe">adresseClient</div>';
echo '<div class="caseListe">idVille</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe">'.$unObjet->getNomClient().'</div>';
echo '<div class="caseListe">'.$unObjet->getPrenomClient().'</div>';
echo '<div class="caseListe">'.$unObjet->getTelClient().'</div>';
echo '<div class="caseListe">'.$unObjet->getMailClient().'</div>';
echo '<div class="caseListe">'.$unObjet->getAdresseClient().'</div>';
echo '<div class="caseListe">'.$unObjet->getIdVille().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormClients&mode=Afficher&id='.$unObjet->getIdClient().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormClients&mode=Modifier&id='.$unObjet->getIdClient().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormClients&mode=Supprimer&id='.$unObjet->getIdClient().'"><i class="fas fa-trash-alt"></i></a></div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-9">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';