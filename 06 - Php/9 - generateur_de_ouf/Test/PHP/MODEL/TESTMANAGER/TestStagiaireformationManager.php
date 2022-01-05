<?php

//Test StagiaireformationManager

echo "recherche id = 1" . "<br>";
$obj =StagiaireformationManager::findById(1);
var_dump($obj);
echo $obj->toString();

echo "ajout de l'objet". "<br>";
$newObj = new Stagiaireformation(["libelleFormation" => "([value 1])", "idSessionFormation" => "([value 2])", "numOffreFormation" => "([value 3])", "idPeriode" => "([value 4])", "dateDebutPAE" => "([value 5])", "dateFinPAE" => "([value 6])", "dateRapportSuivi" => "([value 7])", "objectifPAE" => "([value 8])", "idParticipation" => "([value 9])", "dateDebut" => "([value 10])", "dateFin" => "([value 11])", "idStagiaire" => "([value 12])", "genreStagiaire" => "([value 13])", "nomStagiaire" => "([value 14])", "prenomStagiaire" => "([value 15])", "numSecuStagiaire" => "([value 16])", "numBenefStagiaire" => "([value 17])", "dateNaissanceStagiaire" => "([value 18])", "emailStagiaire" => "([value 19])"]);
var_dump(StagiaireformationManager::add($newObj));

echo "Liste des objets" . "<br>";
$array = StagiaireformationManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

echo "on met à jour l'id 1" . "<br>";
$obj->setlibelleFormation("[(Value)]");
StagiaireformationManager::update($obj);
$objUpdated = StagiaireformationManager::findById(1);
echo "Liste des objets" . "<br>";
$array = StagiaireformationManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

echo "on supprime un objet". "<br>";
$obj = StagiaireformationManager::findById(1);
StagiaireformationManager::delete($obj);
echo "Liste des objets" . "<br>";
$array = StagiaireformationManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

?>