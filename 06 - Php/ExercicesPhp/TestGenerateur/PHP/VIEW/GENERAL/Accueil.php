
<a href="index.php?page=ListeAnimaux">Liste des Animaux</a>
<?php if ($_SESSION['utilisateur']->getRole()==2)
{
    echo '<a href="index.php?page=ListeHabitats">Liste des Animaux</a>
          <a href="index.php?page=ListeRegimesalimentaire">Régimes Alimentaires</a>
          <a href="index.php?page=ListeRoles">Roles</a>
          <a href="index.php?page=ListeUtilisateurs">Utilisateurs</a>';
}
?>