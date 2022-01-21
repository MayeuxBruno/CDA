<main>
    <section class="center colonne">
        <form action="index.php?page=actionConnexion" method="POST">
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
        </form>
    </section>
    <section class="center colonne">
        <form action="index.php?page=actionInscription" method="POST">
            <div class="colSpan2 center"><h1><?php echo texte('Inscription') ?></h1></div>

            <label for="nom"><?php echo texte('Nom') ?> * : </label>
            <input type="text" id="nom" name="nom" pattern="^[a-zA-ZÀ-ÖØ-öø-ÿ'\-]*$" required title="Renseigner votre nom d'usage">

            <label for="prenom"><?php echo texte('Prenom') ?> * : </label>
            <input type="text" id="prenom" name="prenom" pattern="^[a-zA-ZÀ-ÖØ-öø-ÿ'\-]*$" required title="Renseigner votre prénom">

            <label for="adresseMail"><?php echo texte('AdresseEmail') ?> * : </label>
            <div class="relative">
                <input type="text" id="adresseMail" name="adresseMail" pattern="^[a-zA-Z]([\.\-_]?[a-zA-Z0-9])+@[a-zA-Z]([\.\-_]?[a-zA-Z0-9])+\.[a-zA-Z]{2,4}$" required title="Renseigner une adresse mail valide. Elle sera utilisée pour la connexion">
                <fieldset id="infoEmail" class="infoBulle noDisplay">
                    <div >Un compte à déjà été créé avec ce mail</div>
                </fieldset>
            </div>

            <label for="motDePasse"><?php echo texte('Mdp') ?> : </label> 
            <div class="relative">
                <input type="password" id="motDePasse" name="motDePasse" pattern="^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#\$%\^&\*+])([a-zA-Z0-9!@#\$%\^&\*+]{8,})$"
                     required>
                <i class="oeil fas fa-eye"></i>
                <fieldset id="infoMDP" class="noDisplay infoBulle">
                <legend><?php echo texte('infoMdpLegend') ?></legend>
                    <div class="colonne gridAideMDP">
                        <i class="fas fa-times-circle fa-red"></i>
                        <label class="double" for=""><?php echo texte('uneMajuscule') ?></label>

                        <i class="fas fa-times-circle fa-red"></i>
                        <label class="double" for=""><?php echo texte('uneMinuscule') ?></label>

                        <i class="fas fa-times-circle fa-red"></i>
                        <label class="double" for=""><?php echo texte('UnChiffre') ?></label>

                        <i class="fas fa-times-circle fa-red"></i>
                        <label class="double" for=""><?php echo texte('UnCaractereSpecial') ?></label>
                        
                        <i class="fas fa-times-circle fa-red"></i>
                        <label class="double" for=""><?php echo texte('MinimumCaractere') ?></label>
                    </div>
                </fieldset>
            </div>


            <label for="confirmPassword"><?php echo texte('Confirmation') ?> : </label>
            <div class="relative">
                <input type="password" id="confirmPassword" name="confirmPassword"  required >
                <i class="oeil fas fa-eye"></i>
            </div>

            <div></div>
            <div></div>

            <input type="reset" value="<?php echo texte('Reset') ?>">
            <input type="submit" value="<?php echo texte('Envoyer') ?>">
        </form>
    </section>
</main>