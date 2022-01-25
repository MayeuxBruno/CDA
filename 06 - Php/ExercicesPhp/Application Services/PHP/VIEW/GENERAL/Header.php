<body class="colonne">
    <header>
        <div class="demi"></div>
        <div></div>
        <div class="titre centrer"><h1><?php echo $titre; ?></h1></div>
        <div class="colonne">
            <?php

            if (isset($_SESSION['utilisateur'])) {
                echo '<div class="texteColore centrer">'. texte('Bonjour') ." ". $_SESSION['utilisateur']->getNom() . '</div>';
                // echo '<div><a href="index.php?page=deconnection" class="texteColore centrer">'. texte("deconnexion") .'</a></div>';
                 echo '<div><a href="index.php?page=deconnection" class="texteColore centrer">Deconnexion</a></div>';
            } else {
                echo '<a href="index.php?page=connection" class="texteColore centrer">'. texte("connexion") .'</a>';
                 //echo '<a href="index.php?page=connection" class="texteColore centrer">Connexion</a>';
            }
            ?>

        </div>
        <div class="demi"></div>
    </header>