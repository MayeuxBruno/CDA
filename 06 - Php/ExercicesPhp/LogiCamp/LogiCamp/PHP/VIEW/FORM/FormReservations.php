<?php
global $regex;
$mode = $_GET['mode'];
$disabled = " ";
switch ($mode) {
	case "Afficher":
	case "Supprimer":
		$disabled = " disabled";
		break;
}

if (isset($_GET['id'])) {
	$elm = ReservationsManager::findById($_GET['id']);
} else {
	$elm = new Reservations();
}
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionReservations&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm col-span-form">Formulaire Reservations</div>';
if ($mode != "Ajouter") {
	echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdReservation().'" name=IdReservation></div>';
};
echo '<div class="caseForm">Clent</div>';
echo '<div class="caseForm">'.creerSelect(($mode == "Ajouter") ? 1 : $elm->getIdClient(),'Clients',['nomClient','prenomClient'],$disabled).'</div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">Emplacement</div>';
echo '<div class="caseForm">'.creerSelect(($mode == "Ajouter") ? 1 : $elm->getIdEmplacement(),'Emplacements',['refEmplacment'],$disabled).'</div>';

// echo '<div class="caseForm"><input type="text" '.$disabled;
// echo ($mode == "Ajouter") ? "" : " value=".$elm->getIdEmplacement(); echo ' name=IdEmplacement pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">DateReservation</div>';
echo '<div class="caseForm"><input type="date" '.$disabled;
// die(var_dump($elm));
echo ($mode == "Ajouter") ? "" : " value=".(new DateTime($elm->getDateReservation()))->format('Y-m-d'); echo ' name=DateReservation pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">DebutSejour</div>';
echo '<div class="caseForm"><input type="date" '.$disabled;
echo ($mode == "Ajouter") ? "" : " value=".(new DateTime($elm->getDebutSejour()))->format('Y-m-d'); echo ' name=DebutSejour pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">FinSejour</div>';
echo '<div class="caseForm"><input type="date" '.$disabled;
echo ($mode == "Ajouter") ? "" : " value=".(new DateTime($elm->getFinSejour()))->format('Y-m-d'); echo ' name=FinSejour pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeReservations"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';