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
	$elm = EmplacementsManager::findById($_GET['id']);
} else {
	$elm = new Emplacements();
}
// die(var_dump($elm));
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionEmplacements&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm col-span-form">Formulaire Emplacements</div>';
if ($mode != "Ajouter") {
	echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdEmplacement().'" name=IdEmplacement></div>';
};
echo '<div class="caseForm">RefEmplacment</div>';
echo '<div class="caseForm"><input type="text" '.$disabled;
echo ($mode == "Ajouter") ? "" : " value=".$elm->getRefEmplacment(); echo ' name=RefEmplacment pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">DescriptionEmplacement</div>';
echo '<div class="caseForm"><input type="text" '.$disabled;
echo ($mode == "Ajouter") ? "" : " value=".$elm->getDescriptionEmplacement(); echo ' name=DescriptionEmplacement pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">Eau</div>';
echo '';
echo '<div class="caseForm"><input type="checkbox" class="checknochange"';
echo ($elm->getEau() == "on") ? "checked" : ""; echo ' name=Eau value="on"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">Electricite</div>';
echo '<div class="caseForm"><input type="checkbox" '.$disabled;
echo ($elm->getElectricite() == "on") ? "checked" : ""; echo ' name=Electricite ></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">IdTypeEmplacement</div>';
echo '<div class="caseForm">'.creerSelect(($mode == "Ajouter") ? 1 : $elm->getIdTypeEmplacement(),'typesemplacements',['libelleTypeEmplacement'],$disabled).'</div>';

echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeEmplacements"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';