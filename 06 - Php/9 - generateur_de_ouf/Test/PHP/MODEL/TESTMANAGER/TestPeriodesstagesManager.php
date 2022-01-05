<?php

//Test PeriodesstagesManager

echo "recherche id = 1" . "<br>";
$obj =PeriodesstagesManager::findById(1);
var_dump($obj);
echo $obj->toString();

echo "ajout de l'objet". "<br>";
$newObj = new Periodesstages(["idSessionFormation" => "([value 1])", "dateDebutPAE" => "([value 2])", "dateFinPAE" => "([value 3])", "dateRapportSuivi" => "([value 4])", "objectifPAE" => "([value 5])"]);
var_dump(PeriodesstagesManager::add($newObj));

echo "Liste des objets" . "<br>";
$array = PeriodesstagesManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

echo "on met à jour l'id 1" . "<br>";
$obj->setidSessionFormation("[(Value)]");
PeriodesstagesManager::update($obj);
$objUpdated = PeriodesstagesManager::findById(1);
echo "Liste des objets" . "<br>";
$array = PeriodesstagesManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

echo "on supprime un objet". "<br>";
$obj = PeriodesstagesManager::findById(1);
PeriodesstagesManager::delete($obj);
echo "Liste des objets" . "<br>";
$array = PeriodesstagesManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

?>