<?php
global $regex;
?>
<div class="vBigEspace"></div>
<section class="center colonne">
    <form class="petitForm" action="index.php?page=ActionConnexion" method="POST">
        <div class="colSpan2 center"><h1><?php echo texte('Connexion') ?></h1></div>
        <label for="adresseMail"><?php echo texte('AdresseEmail') ?> : </label>
        <input type="text" name="adresseMail" required>
        <label for="motDePasse"><?php echo texte('Mdp') ?> : </label>
        <div class="relative">
            <input type="Password" name="motDePasse" required>
            <i class="oeil fas fa-eye"></i>
        </div>
        <div></div>
        <div></div>
        <div></div>
        <input type="submit" value="<?php echo texte('Envoyer') ?>">
        <div></div>
        <div></div>
        <div class="colSpan2"><a href="index.php?page=Inscription">Je n'ai pas de compte</a></div>
    </form>
    <div>
</section>