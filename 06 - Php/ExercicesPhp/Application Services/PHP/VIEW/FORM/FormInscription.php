<div class="espaceH"></div>
<div>
<div></div>
<div class="demiPage colonne backgroundForm">
    <div class="petitEspaceH"></div>
    <form action="index.php?page=actionInscription" method="POST">
            <div></div>
            <label for="nom"><?php echo texte('nom') ?></label>
            <input type="text" name="nom" required />
            <div></div>
            <div></div>
            <label for="prenom"><?php echo texte('prenom') ?></label>
            <input type="text" name="prenom" required />
            <div></div>
            <div></div>
            <label for="motDePasse"><?php echo texte('motDePasse') ?></label>
            <input type="password" name="motDePasse" required />
            <div></div>
            <div></div>
            <label for="confirmation"><?php echo texte('confirmationMotDePasse') ?></label>
            <input type="password" name="confirmation" required />
            <div></div>
            <div></div>
            <label for="adresseMail"><?php echo texte('adresseEmail') ?></label>
            <input type="text" name="adresseMail" required />
            <div></div>
            <div></div>
            <label for="role"><?php echo texte('role') ?></label>
            <input type="text" name="role" required />
            <div></div>
            <div></div>
            <label for="pseudo"><?php echo texte('pseudo') ?></label>
            <input type="text" name="pseudo" required />
            <div></div>
            <div></div>
            <button class="span2" type="submit"><?php echo texte('envoyer') ?></button>
            <div></div>
        
    </form>
    <div class="petitEspaceH"></div>
        <div class="centrer">
        <a href="index.php?page=connection"><?php echo texte('retour') ?></a>
    </div>
    <div class="petitEspaceH"></div>
</div>
<div></div>
</div>