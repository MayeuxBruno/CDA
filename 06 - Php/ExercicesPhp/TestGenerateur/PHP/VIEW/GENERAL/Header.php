<body class="colonne">
    <header>
        <div class="demi"></div>
        <div><img src="" alt=""></div>
        <div class="titre"><?php echo $titre; ?></div>
        <div class="colonne">
            <?php
            if (isset($_SESSION['utilisateur'])) {
                echo '<div class="center">'. texte('Bonjour') ." ". $_SESSION['utilisateur']->getNom() . '</div>';
                echo '<div><a href="index.php?page=actionDeconnexion" class="center">'. texte("Deconnection") .'</a></div>';
            } else {
                echo '<a href="index.php?page=connection" class="center">'. texte("Connexion") .'</a>';
            }
            ?>

        </div>
        <div class="demi"></div>
    </header>