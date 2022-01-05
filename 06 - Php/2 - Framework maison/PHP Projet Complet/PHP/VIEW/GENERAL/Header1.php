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
        <div class="demi"></div>
        <div><img src="./IMG/Logo_afpa.jpg" alt=""></div>
        <div class="titre"><?php echo $titre; ?></div>
        <div class="colonne">
            <?php

            if (isset($_SESSION['utilisateur'])) {
                echo '<div class="texteColore">Bonjour ' . $_SESSION['utilisateur']->getNom() . '</div>';
                echo '<div><a href="index.php?page=deconnection">deconnection</a></div>';
            } else {
                echo '<a href="index.php?page=connection">connexion</a>';
            }
            ?>

        </div>
        <div class="demi">
        <a href="<?php echo $uri; ?>lang=EN">
                EN
            </a>
            <a href="<?php echo $uri; ?>lang=FR">
                FR
        </div>
    </header>