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
echo '  <input type="hidden" name="idReunion" value="' . $reunion->getIdReunion() . '">';
echo '  <label class="centrer alignergauche">Titre de la réunion:</label>
        <input class="spanTrois" " type="text" name="titreReunion" pattern="^[a-z0-9A-ZÀ-ÖØ-öø-ÿ\'\-]{2,50}$" required title="Renseigner le titre de la réunion" value="' . $reunion->getTitreReunion() . '"' . $disabled . '>
        <fieldset class="spanDeux">
            <legend>Date & Heures</legend> 
            <label>Date de la réunion :</label>
            <input type="date" name="dateReunion" value="' . $reunion->getDateReunion() . '"' . $disabled . '>
            <label>Heure de Début :</label>
            <input type="time" name="horaireDebut" value="' . $reunion->getHoraireDebut() . '"' . $disabled . '>
            <label>Heure de Fin :</label>
            <input type="time" name="horaireFin" value="' . $reunion->getHoraireFin() . '"' . $disabled . '>
        </fieldset>
        <fieldset class="spanDeux"> 
            <legend>Intervenants</legend> 
            <label> Createur :</label>
            <select name="idCreateur" ' . $disabled . '>';
            foreach ($listeUtilisateurs as $unUtilisateur) {
                $sel = "";
                if ($unUtilisateur->getIdUtilisateur() == $reunion->getIdCreateur()) {
                    $sel = "selected";
                }
                echo '<option value="' . $unUtilisateur->getIdUtilisateur() . '" ' . $sel . ' >' . $unUtilisateur->getNomUtilisateur() .' '.$unUtilisateur->getPrenomUtilisateur().'</option>';
            }
            echo '</select>';
            echo '  <label> Animateur :</label>
            <select name="idAnimateur" ' . $disabled . '>';
            foreach ($listeUtilisateurs as $unUtilisateur) {
                $sel = "";
                if ($unUtilisateur->getIdUtilisateur() == $reunion->getIdAnimateur()) {
                    $sel = "selected";
                }
                echo '<option value="' . $unUtilisateur->getIdUtilisateur() . '" ' . $sel . ' >' . $unUtilisateur->getNomUtilisateur() .' '.$unUtilisateur->getPrenomUtilisateur().'</option>';
            }
            echo '</select>';
            echo '  <label> Secrétaire :</label>
            <select name="idSecretaire" ' . $disabled . '>';
            foreach ($listeUtilisateurs as $unUtilisateur) {
                $sel = "";
                if ($unUtilisateur->getIdUtilisateur() == $reunion->getIdSecretaire()) {
                    $sel = "selected";
                }
                echo '<option value="' . $unUtilisateur->getIdUtilisateur() . '" ' . $sel . ' >' . $unUtilisateur->getNomUtilisateur() .' '.$unUtilisateur->getPrenomUtilisateur().'</option>';
            }
            echo '</select>';
echo   '</fieldset>';
echo '  <label>Lieu de la Réunion :</label>
        <input type="text" name="lieuReunion" pattern="^[0-9a-zA-ZÀ-ÖØ-öø-ÿ\'\-]{2,50}$" required value="' . $reunion->getLieuReunion() . '"' . $disabled . '>';

echo '  <label>Nombre Maximum de prticipants :</label>
        <input type="text" name="nbMaxParticipants" pattern="^[0-9]{1-3}$" required title="Entrez le nombre de participants maxi" value="' . $reunion->getNbMaxParticipants() . '"' . $disabled . '>';

echo '  <label> Salle :</label>
        <select name="idSalle" ' . $disabled . '>';
        foreach ($salles as $uneSalle) {
            $sel = "";
            if ($uneSalle->getIdSalle() == $reunion->getIdSalle()) {
                $sel = "selected";
            }
            echo '<option value="' . $uneSalle->getIdSalle() . '" ' . $sel . ' >' . $uneSalle->getLibelleSalle() .'</option>';
        }
echo '</select>';

echo '  <label> Avencement :</label>
        <select name="idEtatAvancement" ' . $disabled . '>';
        foreach ($etatsAvancements as $unEtat) {
            $sel = "";
            if ($unEtat->getIdEtatAvancement() == $reunion->getIdEtatAvancement()) {
                $sel = "selected";
            }
            echo '<option value="' . $unEtat->getIdEtatAvancement() . '" ' . $sel . ' >' . $unEtat->getLibelleEtatAvancement() .'</option>';
        }
echo '</select>';
echo '  <label> Type :</label>
        <select name="idTypeReunion" ' . $disabled . '>';
        foreach ($types as $unType) {
            $sel = "";
            if ($unType->getIdTypeReunion() == $reunion->getIdTypeReunion()) {
                $sel = "selected";
            }
            echo '<option value="' . $unType->getIdTypeReunion() . '" ' . $sel . ' >' . $unType->getLibelleTypeReunion() .'</option>';
        }
echo '</select>';
echo '<div></div>';
echo '<div></div>';
echo '<div></div>';
if ($defaultMode != 'Editer')
    echo '<input type="submit" value="' . $defaultMode. '" class=" crudBtn crudBtn' . $defaultMode . '" disabled />';
else echo '<div></div>';
echo '
<a href="index.php?page=listeProduit" class=" crudBtn crudBtnRetour">Annuler</a>
</div>
</form>';