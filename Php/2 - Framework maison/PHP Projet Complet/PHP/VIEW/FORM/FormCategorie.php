<?php
$mode = $_GET['mode'];
echo '<div class="demiPage colonne">';
echo '<div id="DivSousTitre">';


$disabled = " ";
switch ($mode) {
    case "Editer":
    case "Supprimer":
        $disabled = " disabled ";
        break;
}
echo '  <h5>'.texte($mode).' '.texte("uneCategorie").'</h5></div>
        <form id="formulaire" method="post" action="index.php?page=actionCategorie&mode='.$mode.'">';

if (isset($_GET['id'])) {
    $categ = CategoriesManager::findById($_GET['id']);
}
else{
    $categ = new Categories();
}

echo '  <input type="hidden" name="idCategorie" value="' . $categ->getIdCategorie() . '">';
echo '  <label> '.texte("libelle").' :</label>
        <input type="text" name="libelleCategorie" value="' . $categ->getLibelleCategorie() . '"' .$disabled.'>';
echo '<input type="submit" value="'.texte($mode).'" class=" crudBtn crudBtn'.$mode.'"/>';

echo '<a href="index.php?page=listeCategorie" class=" crudBtn crudBtnRetour">'.texte("Annuler").'</a>
</form>';