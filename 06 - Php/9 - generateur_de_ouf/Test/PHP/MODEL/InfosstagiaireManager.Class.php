<?php

class InfosstagiaireManager 
{
	public static function add(Infosstagiaire $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("INSERT INTO Infosstagiaire (numOffreFormation,idFormation,debutSession,finSession,idStagiaire,genreStagiaire,nomStagiaire,prenomStagiaire,numSecuStagiaire,numBenefStagiaire,dateNaissanceStagiaire,nomVisiteur) VALUES (:numOffreFormation,:idFormation,:debutSession,:finSession,:idStagiaire,:genreStagiaire,:nomStagiaire,:prenomStagiaire,:numSecuStagiaire,:numBenefStagiaire,:dateNaissanceStagiaire,:nomVisiteur)");
		$q->bindValue(":numOffreFormation", $obj->getNumOffreFormation());
		$q->bindValue(":idFormation", $obj->getIdFormation());
		$q->bindValue(":debutSession", $obj->getDebutSession());
		$q->bindValue(":finSession", $obj->getFinSession());
		$q->bindValue(":idStagiaire", $obj->getIdStagiaire());
		$q->bindValue(":genreStagiaire", $obj->getGenreStagiaire());
		$q->bindValue(":nomStagiaire", $obj->getNomStagiaire());
		$q->bindValue(":prenomStagiaire", $obj->getPrenomStagiaire());
		$q->bindValue(":numSecuStagiaire", $obj->getNumSecuStagiaire());
		$q->bindValue(":numBenefStagiaire", $obj->getNumBenefStagiaire());
		$q->bindValue(":dateNaissanceStagiaire", $obj->getDateNaissanceStagiaire());
		$q->bindValue(":nomVisiteur", $obj->getNomVisiteur());
		$q->execute();
	}

	public static function update(Infosstagiaire $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("UPDATE Infosstagiaire SET idSessionFormation=:idSessionFormation,numOffreFormation=:numOffreFormation,idFormation=:idFormation,debutSession=:debutSession,finSession=:finSession,idStagiaire=:idStagiaire,genreStagiaire=:genreStagiaire,nomStagiaire=:nomStagiaire,prenomStagiaire=:prenomStagiaire,numSecuStagiaire=:numSecuStagiaire,numBenefStagiaire=:numBenefStagiaire,dateNaissanceStagiaire=:dateNaissanceStagiaire,nomVisiteur=:nomVisiteur WHERE idSessionFormation=:idSessionFormation");
		$q->bindValue(":idSessionFormation", $obj->getIdSessionFormation());
		$q->bindValue(":numOffreFormation", $obj->getNumOffreFormation());
		$q->bindValue(":idFormation", $obj->getIdFormation());
		$q->bindValue(":debutSession", $obj->getDebutSession());
		$q->bindValue(":finSession", $obj->getFinSession());
		$q->bindValue(":idStagiaire", $obj->getIdStagiaire());
		$q->bindValue(":genreStagiaire", $obj->getGenreStagiaire());
		$q->bindValue(":nomStagiaire", $obj->getNomStagiaire());
		$q->bindValue(":prenomStagiaire", $obj->getPrenomStagiaire());
		$q->bindValue(":numSecuStagiaire", $obj->getNumSecuStagiaire());
		$q->bindValue(":numBenefStagiaire", $obj->getNumBenefStagiaire());
		$q->bindValue(":dateNaissanceStagiaire", $obj->getDateNaissanceStagiaire());
		$q->bindValue(":nomVisiteur", $obj->getNomVisiteur());
		$q->execute();
	}
	public static function delete(Infosstagiaire $obj)
	{
 		$db=DbConnect::getDb();
		$db->exec("DELETE FROM Infosstagiaire WHERE idSessionFormation=" .$obj->getIdSessionFormation());
	}
	public static function findById($id)
	{
 		$db=DbConnect::getDb();
		$id = (int) $id;
		$q=$db->query("SELECT * FROM Infosstagiaire WHERE idSessionFormation =".$id);
		$results = $q->fetch(PDO::FETCH_ASSOC);
		if($results != false)
		{
			return new Infosstagiaire($results);
		}
		else
		{
			return false;
		}
	}
	public static function getList()
	{
 		$db=DbConnect::getDb();
		$liste = [];
		$q = $db->query("SELECT * FROM Infosstagiaire");
		while($donnees = $q->fetch(PDO::FETCH_ASSOC))
		{
			if($donnees != false)
			{
				$liste[] = new Infosstagiaire($donnees);
			}
		}
		return $liste;
	}
}