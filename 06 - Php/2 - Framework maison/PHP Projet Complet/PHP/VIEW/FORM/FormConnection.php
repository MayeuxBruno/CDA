<div class="demiPage colonne">
    <form action="index.php?page=actionConnection" method="post">
        <div>
            <label for="pseudo">Pseudo</label>
            <input type="text" name="pseudo" required />
        </div>
        <div>
            <label for="motDePasse"><?php echo texte("motDePasse")?></label>
            <input type="password" name="motDePasse" required />
        </div>
        <div>
            <div></div>
            <button type="submit"><?php echo texte("valider")?></button>
            <div></div>
        </div>

    </form>
    <div>
        <div></div>

        <a href="index.php?page=inscription"><?php echo texte("inscription")?></a>
        <div></div>
    </div>
</div>