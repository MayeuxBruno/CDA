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
	$elm = ArticlesManager::findById($_GET['id']);
} else {
	$elm = new Articles();
}

$listeTypeArticle=TypesarticlesManager::getList(['idTypeArticle','libelleTypeArticle'],null,'libelleTypeArticle');
echo '<main class="center">';


echo '<form class="GridForm" action="index.php?page=ActionArticles&mode='.$_GET['mode'].'" method="post"/>';
echo '<div class="caseForm titreForm col-span-form"></div>';
echo '<div class="caseForm titreForm col-span-form">'.texte($mode).' '.texte("UnArticle").'</div>';
echo '<div class="caseForm titreForm col-span-form"></div>';
echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdArticle().'" name=IdArticle></div>';
echo '<label for=LibelleArticle class="caseForm labelForm">'.texte("LibelleArticle").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getLibelleArticle().'" name=LibelleArticle pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=DescriptionArticle class="caseForm labelForm">'.texte("DescriptionArticle").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getDescriptionArticle().'" name=DescriptionArticle pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=PrixArticle class="caseForm labelForm">'.texte("PrixArticle").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getPrixArticle().'" name=PrixArticle pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=IdTypeArticle class="caseForm labelForm">'.texte("TypeArticle").'</label>';
echo '<div class="caseForm donneeForm">
		<select '.$disabled .'name="IdTypeArticle">';
		foreach($listeTypeArticle as $unType)
		{
			echo'<option value="'.$unType->getIdTypeArticle().'">'.$unType->getLibelleTypeArticle().'</option>';
		}
echo' </select>
	  </div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Photos class="caseForm labelForm">'.texte("Photos").'</label>';
echo '<div class="caseForm donneeForm"><img id="photoForm" src="IMG/'.$elm->getPhotos().'" alt=""/></div>';
echo '<div class="caseForm donneeForm"><input id="inputPhoto" type="file" '.$disabled .'file="'.$elm->getPhotos().'" accept=".jpg, .jpeg, .png" name="Photos"></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';


echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeArticles"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';