<div class="espaceH"></div>
<div>
<div></div>
    <div class="demiPage colonne backgroundForm">
        <div class="petitEspaceH"></div>
        <form action="index.php?page=actionConnection" method="post">
                <div></div>
                <label for="pseudo"><?php echo texte('pseudo') ?></label>
                <input type="text" name="pseudo" required />
                <div></div>
                <div></div>
                <label for="motDePasse"><?php echo texte('motDePasse') ?></label>
                <input type="password" name="motDePasse" required />
                <div></div>
                <div></div>
                <button class="span2" type="submit"><?php echo texte('envoyer') ?></button>
        </form>
        <div class="petitEspaceH"></div>
        <div class="centrer">
        <a href="index.php?page=inscription"><?php echo texte('inscription') ?></a>
        </div>
        <div class="petitEspaceH"></div>
    </div>
    <div></div>
</div>