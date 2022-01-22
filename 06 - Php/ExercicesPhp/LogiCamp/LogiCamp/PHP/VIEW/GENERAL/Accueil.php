<?php
echo '<a href="index.php?page=ListeClients">Liste des Clients</a>';
echo '<a href="index.php?page=ListeReservations">Liste des Reservations</a>';
if($_SESSION['utilisateur']->getRole()==2)
{
    echo '<a href="index.php?page=ListeEmplacements">Liste des emplacements</a>';
    echo '<a href="index.php?page=ListeVilles">Liste des Villes</a>';
}
?>
