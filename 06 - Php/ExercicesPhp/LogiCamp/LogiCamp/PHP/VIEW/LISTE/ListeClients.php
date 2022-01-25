<?php
 echo '<div class="vBigEspace"></div>';
 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = ClientsManager::getList(null,null,'nomClient');
//Création du template de la grid
echo '<div class="grid-col-9 gridListe">';

echo '<div class="grid-columns-span-9">Liste des Clients </div>';
echo '<div class="grid-columns-span-9 gridEspace"></div>';
echo '<div class="grid-columns-span-9">
<div></div>
<a href="index.php?page=FormClients&mode=Ajouter"><button>Ajouter un client</button></a>
<div></div>
</div>';
echo '<div class="grid-columns-span-9 gridEspace"></div>';
echo '<div class="caseListe">Nom</div>';
echo '<div class="caseListe">Prénom</div>';
echo '<div class="caseListe">Téléphone</div>';
echo '<div class="caseListe">Adresse Mail</div>';
echo '<div class="caseListe">Adresse Postale</div>';
echo '<div class="caseListe">Ville</div>';

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
$ville=VillesManager::findById($unObjet->getIdVille());
echo '<div class="caseListe">'.$ville->getCodePostal()." ".$ville->getNomVille().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormClients&mode=Afficher&id='.$unObjet->getIdClient().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormClients&mode=Modifier&id='.$unObjet->getIdClient().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormClients&mode=Supprimer&id='.$unObjet->getIdClient().'"><i class="fas fa-trash-alt"></i></a></div>';
}
echo '<div class="grid-columns-span-9"></div>';
//Derniere ligne du tableau (bouton retour)
echo '<div class="grid-columns-span-9">
	<div></div>
	<a href="index.php?page=Accueil"><button>Retour</button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';