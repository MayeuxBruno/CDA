<div class="demiPage colonne">
    <form action="index.php?page=actionInscription" method="POST">
        <div>
            <label for="nom"><?php echo texte("nom")?></label>
            <input type="text" name="nom" required />
        </div>
        <div>
            <label for="prenom"><?php echo texte("prenom")?></label>
            <input type="text" name="prenom" required />
        </div>
        <div>
            <label for="motDePasse"><?php echo texte("motDePasse")?></label>
            <input type="password" name="motDePasse" required />
        </div>
        <div>
            <label for="confirmation"><?php echo texte("confirmMdp")?></label>
            <input type="password" name="confirmation" required />
        </div>
        <div>
            <label for="adresseMail"><?php echo texte("adresseemail")?></label>
            <input type="text" name="adresseMail" required />
        </div>
        <div>
            <label for="role">Role (1 : user - 2 : admin)</label>
            <input type="text" name="role" required />
        </div>
        <div>
            <label for="pseudo">Pseudo</label>
            <input type="text" name="pseudo" required />
        </div>
        <div>
            <div></div>
            <button type="submit"><?php echo texte("valider")?></button>
            <div></div>
        </div>

    </form>