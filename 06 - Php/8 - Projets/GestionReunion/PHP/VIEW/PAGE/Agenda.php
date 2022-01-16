<?php 

/**
 * Fonction qui permet de récupérer les réunions et de les classer par dates
 * Elle Retourne un tableau associative 
 */
function getReunionsByDate(DateTime $start, DateTime $end)
{
	$reunions=ReunionsManager::findByDateBetween($start,$end); // on récupère les réunions en base de données
	$days=[];
	foreach ($reunions as $unereunion)
	{
		$date=$unereunion->getdateReunion();
		if (!isset($days[$date]))       // Si la date n'existe pas dans le tableau
		{
			$days[$date]=[$unereunion];  // On créé la case avec cette date et on ajoute notre objet reunion reunion
		}
		else{
			$days[$date][]=$unereunion;   // Si elle existe on ajoute notre objet reunion
		}
	}
    return $days; 
}

$month = new Mois($_GET['month']??null,$_GET['year']??null); // Initialisation du mois à afficher avec le Get si non avec le mois et l'année en cours
$firstDay=(clone $month->jourDeDepart())->modify('last monday'); // On récupère le dernier lundi précédent la date du début de mois
if ($month->jourDeDepart()->diff($firstDay)->format("%d")==7) // Si le premier jour du mois est un lundi
{
    $firstDay=$month->jourDeDepart();
}
$nbSemaines=$month->nbSemaines(); // On calcule le nombre de semaines de la grille
$dateFin=(clone $firstDay)->modify('+'.(6+7*($nbSemaines-1)).'days'); //on Determine la dernière date de la grille 
$tabReunions=getReunionsByDate($firstDay,$dateFin); // On recherche toutes les réunions entre la première et dernière date de la grille
//var_dump($tabReunions);
?>
<div>
    <div><h1><?php echo $month->ToString();?></h1></div>
    <div>
       <div class="mini centrer"><a href="/index.php?page=agenda&month=<?php echo $month->moisPrecedent()->getMois();?>&year=<?php echo $month->moisPrecedent()->getAnnee();?>"><i class="fas fa-arrow-circle-left"></i></a></div> 
       <div class="mini centrer"><a href="/index.php?page=agenda&month=<?php echo $month->moisSuivant()->getMois();?>&year=<?php echo $month->moisSuivant()->getAnnee();?>"><i class="fas fa-arrow-circle-right"></i></a></div>
    </div>
</div>

<table class="calendar">
    <?php 
        for ($i=0;$i<$nbSemaines;$i++)
        {
            echo '<tr>';
            foreach($month->getTabJours() as $k => $unjour)
            {
                $string="+".($k+$i*7)." days";
                $date=(clone $firstDay)->modify($string);
                $reuniondujour=$tabReunions[$date->format('Y-m-d')]??[]; //Si pas de date dans le tableau on envoi un tableau vide
                if ($month->estDansLeMois($date)) // Si la date est dans le mois elle est affichée normalement
                {
                    $class="";
                }
                else{ // Si non elle est mise en opacité
                    $class="dansLeMois";
                }
                echo '
                      <td class="'.$class.'">
                        <br>';
                        if($i==0)
                        {
                            echo '<div class="nomJour">'.$unjour.'</div><br>';
                        }     // Affichage nom du jour
                        echo '<div class="numJour">'.$date->format('d').'</div>';  // Affichage du numéro du jour
                        foreach($reuniondujour as $reunion)
                        {
                            $heure=new DateTime($reunion->getHoraireDebut());
                            echo '<div class="reunionagenda">'.
                                    ($heure->format('H:i')).' - '. $reunion->getTitreReunion().
                                 '</div>' ;
                        }
                        echo '</td>';
            }
            echo '</tr>';
        }
        ?>
</table>