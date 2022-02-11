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

if (isset($_GET['id'])) {
	$elm = GradesManager::findById($_GET['id']);
} else {
	$elm = new Grades();
}
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionGrades&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm col-span-form">Formulaire Grades</div>';
if ($mode != "Ajouter") {
	echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getGradeID().'" name=GradeID></div>';
};
echo '<div class="caseForm">GradeName</div>';
echo '<div class="caseForm"><input type="text" '.$disabled;
echo ($mode == "Ajouter") ? "" : " value=".$elm->getGradeName(); echo ' name=GradeName pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeGrades"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';