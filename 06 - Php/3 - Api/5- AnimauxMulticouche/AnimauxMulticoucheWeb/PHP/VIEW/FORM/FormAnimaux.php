<?php
global $regex;
$mode = $_GET['mode'];
$disabled = " ";
switch ($mode) {
	case "Afficher":
	case "Supprimer":
		$disabled = " disabled ";
		break;
}

// if (isset($_GET['id'])) {
// 	$elm = AnimauxManager::findById($_GET['id']);
// } else {
// 	$elm = new Animaux();
// }
$elm = new Animaux();
echo '<main class="center">';

echo '<form class="GridForm" action="" method=""/>';

echo '<div class="caseForm col-span-form">Formulaire Animaux</div>';
if ($mode != "Ajouter") {
	echo '<div class="noDisplay"><input id="idAnimal" type="hidden" value="'.$_GET['id'].'" name=IdAnimal></div>';
};
echo '<div class="caseForm">NomAnimal</div>';
echo '<div class="caseForm"><input type="text" '.$disabled.'id="nomAnimal"';
echo ' name=NomAnimal pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">IdRegimeAlimentaire</div>';
echo '<div class="caseForm" id="SelectRegime"></div>';
// echo '<div class="caseForm"><input type="text" '.$disabled;
// echo ($mode == "Ajouter") ? "" : " value=".$elm->getIdRegimeAlimentaire(); echo ' name=IdRegimeAlimentaire pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">IdHabitat</div>';
echo '<div class="caseForm" id="SelectHabitat"></div>';
// echo '<div class="caseForm"><input type="text" '.$disabled;
// echo ($mode == "Ajouter") ? "" : " value=".$elm->getIdHabitat(); echo ' name=IdHabitat pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeAnimaux"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button id=\"submit\" type=\"submit\" ><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';

/*index.php?page=ActionAnimaux&mode='.$_GET['mode'].'*/