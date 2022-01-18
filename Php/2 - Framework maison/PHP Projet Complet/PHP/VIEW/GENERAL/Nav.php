<?php

if (isset($_SESSION['utilisateur'])) {
    if ($_SESSION['utilisateur']->getRole() == 1) {

        $classeCouleur = "blue"; // l'admin voir les boutons bleu
    } else {
        $classeCouleur = "green"; //les utilisateurs Vert
    }

    echo '<nav>
    <button class="crudBtn crudBtnRetour ' . $classeCouleur . '"><a href="index.php?page=listeProduit">'.texte("produits").'</a></button>';
    if ($_SESSION['utilisateur']->getRole() == 2) {
        echo '<button class="crudBtn crudBtnRetour ' . $classeCouleur . '"><a href="index.php?page=listeCategorie">Categories</a></button>';
    }
    echo'</nav>';
}
