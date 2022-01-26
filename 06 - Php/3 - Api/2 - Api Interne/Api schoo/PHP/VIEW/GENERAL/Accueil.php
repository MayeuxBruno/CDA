<h1>TEST API</h1> 
<h3>Page génerée et gérée grace aux API internes</h3>
<br>
<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div class="colonne">';
 

$lesCours=CoursesManager ::getList();
//Création du template de la grid
echo '<div class="grid-col-5 gridListe">';

echo '<div class="caseListe grid-columns-span-5">Liste des Student </div>';
echo '<div>Selectionnez un cours : </div>';
echo '<select id="selectCours">
        <option value="default" selected> -- Choisissez un cours --</option>';
        foreach ($lesCours as $unCour)
        {
            echo '<option value="' . $unCour->getCourseId() . '">' . $unCour->getCourseName() . '</option>';
        }
echo '</select>';
echo '<div></div>';
echo '<div></div>';
echo '<div></div>';
echo '<div class="caseListe grid-columns-span-5">
      <div></div>
      <div class="caseListe"><a href="index.php?page=FormStudent&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
      <div></div>
      </div>';
echo '</div>';
echo '<div class="grid-col-5 gridListe" id="contenu">';


echo '<div class="caseListe">Nom</div>';
echo '<div class="caseListe">Classe</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
// foreach($objets as $unObjet)
// {
// echo '<div class="caseListe">'.$unObjet->getName().'</div>';
// echo '<div class="caseListe">'.$unObjet->getGradeID().'</div>';
// echo '<div class="caseListe"> <a href="index.php?page=FormStudent&mode=Afficher&id='.$unObjet->getStudentId().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
// echo '<div class="caseListe"> <a href="index.php?page=FormStudent&mode=Modifier&id='.$unObjet->getStudentId().'"><i class="fas fa-pen"></i></a></div>';
                                                    
// echo '<div class="caseListe"> <a href="index.php?page=FormStudent&mode=Supprimer&id='.$unObjet->getStudentId().'"><i class="fas fa-trash-alt"></i></a></div>';
// }
//Derniere ligne du tableau (bouton retour)
echo'</div>';
echo '<div class="grid-col-5 gridListe">';
echo '<div class="caseListe grid-columns-span-5">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';