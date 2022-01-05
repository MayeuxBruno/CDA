<?php
$liste = ProduitsManager::getList();
?>
<div class="demiPage colonne">
    <div id="crudBarreOutil">
        <a class=" crudBtn crudBtnOutil" href='index.php?page=formProduit&mode=Ajouter'><?php echo texte("ajouter")?></a>
    </div>
    <div id="crudTableau">

        <div class="crudColonne"><?php echo texte("libelle")?></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <?php foreach ($liste as $elt) {
            echo '<div class="crudColonne">' . $elt->getLibelleProduit() . '</div>
            <div></div>    
            <a class=" crudBtn crudBtnEditer" href="index.php?page=formProduit&mode=Editer&id='. $elt->getIdProduit().'">'.texte("afficher").'</a>
                <a class=" crudBtn crudBtnModifier" href="index.php?page=formProduit&mode=Modifier&id='.$elt->getIdProduit().'">'.texte("modifier").'</a>
                <a class=" crudBtn crudBtnSupprimer" href="index.php?page=formProduit&mode=Supprimer&id='. $elt->getIdProduit().'">'.texte("supprimer").'</a>
            ';
        } ?>

    </div>
</div>