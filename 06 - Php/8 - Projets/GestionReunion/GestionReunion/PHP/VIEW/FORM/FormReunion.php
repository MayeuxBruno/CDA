<?php
$defaultMode =  $_GET['mode'];
$modeTraduit = texte($defaultMode);
echo '<div class="demiPage colonne">';
echo '<div id="DivSousTitre" >';

$disabled = " ";
switch ($defaultMode) {
    case "Editer":
    case "Supprimer":
        $disabled = " disabled ";
        break;
}

//echo '<h5>' . $modeTraduit . texte('CrudProduit') . '</h5></div>
echo '<h3>' . $defaultMode . ' une Réunion</h3></div>
<form class="gridForm" id="formulaire" method="post" action="index.php?page=actionReunion&mode=' . $defaultMode . '">';
if (isset($_GET['id'])) {
    $reunion = ReunionsManager::findById($_GET['id']);
    $idReunion = $reunion->getIdReunion();
} else {
    $reunion = new Reunions();
    $idReunion = null;
}
$listeUtilisateurs = UtilisateursManager::getList();
$types=TypesReunionsManager::getList();
$etatsAvancements = EtatsAvancementsManager::getList();
$salles=SallesManager::getList();

echo '  <label>Titre de la réunion:</label>
        <input class="spanTrois" type="text" name="titreReunion" value="' . $reunion->getTitreReunion() . '"' . $disabled . '>';
echo '</form>';
// on crée les inputs du formulaire
// il faut que les name des input correspondent aux attributs de la class
// si on a les informations (cas Editer, Modifier, supp) on les mets à jour
// echo '  <input type="hidden" name="idReunion" value="' . $reunion->getIdReunion() . '">';
// echo '  <label>Titre de la réunion:</label>
//         <input type="text" name="titreReunion" value="' . $reunion->getTitreReunion() . '"' . $disabled . '>';
// echo '  <label>Date de la réunion :</label>
//         <input type="date" name="dateReunion" value="' . $reunion->getDateReunion() . '"' . $disabled . '>';
// echo '  <label>Lieu de la Réunion :</label>
//         <input type="text" name="lieuReunion" value="' . $reunion->getLieuReunion() . '"' . $disabled . '>';
// echo '  <label>Heure de Début :</label>
//         <input type="time" name="horaireDebut" value="' . $reunion->getHoraireDebut() . '"' . $disabled . '>';
// echo '  <label>Heure de Fin :</label>
//         <input type="time" name="horaireFin" value="' . $reunion->getHoraireFin() . '"' . $disabled . '>';
// echo '  <label>Nombre Maximum de prticipants :</label>
//         <input type="number" name="nbMaxParticipants" value="' . $reunion->getNbMaxParticipants() . '"' . $disabled . '>';
// echo '  <label> Createur :</label>
//         <select name="idCreateur" ' . $disabled . '>';
//         foreach ($listeUtilisateurs as $unUtilisateur) {
//             $sel = "";
//             if ($unUtilisateur->getIdUtilisateur() == $reunion->getIdCreateur()) {
//                 $sel = "selected";
//             }
//             echo '<option value="' . $unUtilisateur->getIdUtilisateur() . '" ' . $sel . ' >' . $unUtilisateur->getNomUtilisateur() .' '.$unUtilisateur->getPrenomUtilisateur().'</option>';
//         }
//         echo '</select>';
// echo '  <label> Animateur :</label>
//         <select name="idAnimateur" ' . $disabled . '>';
//         foreach ($listeUtilisateurs as $unUtilisateur) {
//             $sel = "";
//             if ($unUtilisateur->getIdUtilisateur() == $reunion->getIdAnimateur()) {
//                 $sel = "selected";
//             }
//             echo '<option value="' . $unUtilisateur->getIdUtilisateur() . '" ' . $sel . ' >' . $unUtilisateur->getNomUtilisateur() .' '.$unUtilisateur->getPrenomUtilisateur().'</option>';
//         }
//         echo '</select>';
// echo '  <label> Createur :</label>
//         <select name="idCreateur" ' . $disabled . '>';
//         foreach ($listeUtilisateurs as $unUtilisateur) {
//             $sel = "";
//             if ($unUtilisateur->getIdUtilisateur() == $reunion->getIdCreateur()) {
//                 $sel = "selected";
//             }
//             echo '<option value="' . $unUtilisateur->getIdUtilisateur() . '" ' . $sel . ' >' . $unUtilisateur->getNomUtilisateur() .' '.$unUtilisateur->getPrenomUtilisateur().'</option>';
//         }
// echo '</select>';
// echo '  <label> Type :</label>
//         <select name="idTypeReunion" ' . $disabled . '>';
//         foreach ($types as $unType) {
//             $sel = "";
//             if ($unType->getIdTypeReunion() == $reunion->getIdTypeReunion()) {
//                 $sel = "selected";
//             }
//             echo '<option value="' . $unType->getIdTypeReunion() . '" ' . $sel . ' >' . $unType->getLibelleTypeReunion() .'</option>';
//         }
// echo '</select>';
// echo '  <label> Avencement :</label>
//         <select name="idEtatAvancement" ' . $disabled . '>';
//         foreach ($etatsAvancements as $unEtat) {
//             $sel = "";
//             if ($unEtat->getIdEtatAvancement() == $reunion->getIdEtatAvancement()) {
//                 $sel = "selected";
//             }
//             echo '<option value="' . $unEtat->getIdEtatAvancement() . '" ' . $sel . ' >' . $unEtat->getLibelleEtatAvancement() .'</option>';
//         }
// echo '</select>';
// echo '  <label> Salle :</label>
//         <select name="idSalle" ' . $disabled . '>';
//         foreach ($salles as $uneSalle) {
//             $sel = "";
//             if ($uneSalle->getIdSalle() == $reunion->getIdSalle()) {
//                 $sel = "selected";
//             }
//             echo '<option value="' . $uneSalle->getIdSalle() . '" ' . $sel . ' >' . $uneSalle->getLibelleSalle() .'</option>';
//         }
// echo '</select>';
// if ($defaultMode != 'Editer')
//     echo '<input type="submit" value="' . $defaultMode. '" class=" crudBtn crudBtn' . $defaultMode . '"/>';
// else echo '<div></div>';
// echo '
// <a href="index.php?page=listeProduit" class=" crudBtn crudBtnRetour">Annuler</a>
//</div>
//echo '</form>';