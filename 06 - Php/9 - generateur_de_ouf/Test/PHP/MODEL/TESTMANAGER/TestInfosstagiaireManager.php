<?php

//Test InfosstagiaireManager

echo "recherche id = 1" . "<br>";
$obj =InfosstagiaireManager::findById(1);
var_dump($obj);
echo $obj->toString();

echo "ajout de l'objet". "<br>";
$newObj = new Infosstagiaire(["numOffreFormation" => "([value 1])", "idFormation" => "([value 2])", "debutSession" => "([value 3])", "finSession" => "([value 4])", "idStagiaire" => "([value 5])", "genreStagiaire" => "([value 6])", "nomStagiaire" => "([value 7])", "prenomStagiaire" => "([value 8])", "numSecuStagiaire" => "([value 9])", "numBenefStagiaire" => "([value 10])", "dateNaissanceStagiaire" => "([value 11])", "nomVisiteur" => "([value 12])"]);
var_dump(InfosstagiaireManager::add($newObj));

echo "Liste des objets" . "<br>";
$array = InfosstagiaireManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

echo "on met à jour l'id 1" . "<br>";
$obj->setnumOffreFormation("[(Value)]");
InfosstagiaireManager::update($obj);
$objUpdated = InfosstagiaireManager::findById(1);
echo "Liste des objets" . "<br>";
$array = InfosstagiaireManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

echo "on supprime un objet". "<br>";
$obj = InfosstagiaireManager::findById(1);
InfosstagiaireManager::delete($obj);
echo "Liste des objets" . "<br>";
$array = InfosstagiaireManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

?>