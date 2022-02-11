<?php

if($_SESSION['utilisateur']->getRole()==2)
{
    echo'
        <nav>
        <div></div>    
        <div class="caseMenu"><a class="center" href="?page=ListeArticles">Articles</a></div>
        <div class="caseMenu"><a class="center" href="?page=ListeTypesarticles">Typesarticles</a></div>
        <div class="caseMenu"><a class="center" href="?page=ListePaniers">Paniers</a></div>
        <div class="caseMenu"><a class="center" href="?page=ListeUtilisateurs">Clients</a></div>
        <div class="caseMenu"><a class="center" href="?page=Accueil">Catalogue</a></div>
        <div></div>
        </nav>';
}
else{
        echo'
        <nav>
        <div></div>    
        <div class="caseMenu"><a class="center" href="?page=ListePaniers">Paniers</a></div>
        <div class="caseMenu"><a class="center" href="?page=Accueil">Categories</a></div>
        <div></div>
        </nav>';
}
