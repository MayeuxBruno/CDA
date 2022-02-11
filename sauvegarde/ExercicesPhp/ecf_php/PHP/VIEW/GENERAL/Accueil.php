<?php
$typesArticles=TypesarticlesManager::getList();

foreach($typesArticles as $unType)
{
    $lesArticles=ArticlesManager::getList(null,['IdTypeArticle'=>$unType->getIdTypeArticle()]);
    //var_dump($lesArticles);
    echo '<div class="bigEspace"></div>';
    echo '<div class="center bold">'.$unType->getLibelleTypeArticle().'</div>';
    echo '<div class="bigEspace"></div>';
    echo '<div class="grid-catalogue">';
    foreach($lesArticles as $unArticle)
    {
       
        echo'<div>';
        echo '<form action="index.php?page=ActionLignespaniers&mode=Ajouter" method="POST" class="colonne">';
        echo '<div class="noDisplay"><input type="hidden" value="'.$unArticle->getIdArticle().'" name="IdArticle"></div>';
            echo '<div>
                    <div></div>
                    <div><img src="IMG/'.$unArticle->getPhotos().'" alt="logo produit"/></div>
                    <div></div>';
            echo'</div>';
            echo'<div class="center bold">
                    <div></div>
                    <div><input type="text" class="center inputCat" name="LibelleArticle" value="'.$unArticle->getLibelleArticle().'"/><button class="buttonCat" type="submit"><i class="fas fa-cart-plus"></i></button></div>
                    <div></div>
                </div>';
            echo'<div class="center ">'.$unArticle->getPrixArticle().'</div>';
            echo'<div class="center ">'.$unArticle->getDescriptionArticle().'</div>';
       
        echo'</form>';
        echo '</div>';
    }
    echo '</div>';
}
