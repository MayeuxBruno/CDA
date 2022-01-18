<?php

/* construction de l'url en fonction de l'uri existante  */
// var_dump($_SERVER);
$uri = $_SERVER['REQUEST_URI'];
if (substr($uri, strlen($uri) - 1) == "/") // se termine par /
{
    $uri .= "index.php?";
}
else if (in_array("?", str_split($uri))) // si l'uri contient deja un ?
{
    $uri .= "&";
}
else
{
    $uri .= "?";
}

?>
<body class="colonne">
    <header>
        <div class="demi">
              
        </div>
        <div><img src="./IMG/Logo_afpa.jpg" alt=""></div>
        <div class="titre"><?php echo texte($titre); ?></div>
        <div class="colonne demi">
            <div>
                <div class="demi"></div>
                <div class="centre">
                    <a href="<?php echo $uri; ?>lang=EN"> 
                         <img src="./IMG/EN.jpg" alt="drapeaux anglais">
                    </a>
                </div>
                <div class="demi"></div>
            </div>
            <div>
            <div class="demi"></div>
            <div class="centre">
                <a href="<?php echo $uri; ?>lang=FR"> 
                    <img src="./IMG/FR.jpg" alt="drapeaux francais">
                </a>
            </div>
            <div class="demi"></div>
            </div>
               
              
        </div>
        <div class="demi colonne centre">
        <?php

            if (isset($_SESSION['utilisateur'])) {
                echo '<div class="texteColore">'.texte("bonjour").' '. $_SESSION['utilisateur']->getNom() . '</div>';
                echo '<div><a href="index.php?page=deconnection">'.texte("deconnexion").'</a></div>';
            } else {
                echo '<a href="index.php?page=connection">'.texte("connexion").'</a>';
            }
            ?>
        </div>
        <div class="demi"></div>
    </header>