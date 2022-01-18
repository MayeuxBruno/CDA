<?php

class StagiaireformationManager 
{
	public static function add(Stagiaireformation $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("INSERT INTO Stagiaireformation (libelleFormation,idSessionFormation,numOffreFormation,idPeriode,dateDebutPAE,dateFinPAE,dateRapportSuivi,objectifPAE,idParticipation,dateDebut,dateFin,idStagiaire,genreStagiaire,nomStagiaire,prenomStagiaire,numSecuStagiaire,numBenefStagiaire,dateNaissanceStagiaire,emailStagiaire) VALUES (:libelleFormation,:idSessionFormation,:numOffreFormation,:idPeriode,:dateDebutPAE,:dateFinPAE,:dateRapportSuivi,:objectifPAE,:idParticipation,:dateDebut,:dateFin,:idStagiaire,:genreStagiaire,:nomStagiaire,:prenomStagiaire,:numSecuStagiaire,:numBenefStagiaire,:dateNaissanceStagiaire,:emailStagiaire)");
		$q->bindValue(":libelleFormation", $obj->getLibelleFormation());
		$q->bindValue(":idSessionFormation", $obj->getIdSessionFormation());
		$q->bindValue(":numOffreFormation", $obj->getNumOffreFormation());
		$q->bindValue(":idPeriode", $obj->getIdPeriode());
		$q->bindValue(":dateDebutPAE", $obj->getDateDebutPAE());
		$q->bindValue(":dateFinPAE", $obj->getDateFinPAE());
		$q->bindValue(":dateRapportSuivi", $obj->getDateRapportSuivi());
		$q->bindValue(":objectifPAE", $obj->getObjectifPAE());
		$q->bindValue(":idParticipation", $obj->getIdParticipation());
		$q->bindValue(":dateDebut", $obj->getDateDebut());
		$q->bindValue(":dateFin", $obj->getDateFin());
		$q->bindValue(":idStagiaire", $obj->getIdStagiaire());
		$q->bindValue(":genreStagiaire", $obj->getGenreStagiaire());
		$q->bindValue(":nomStagiaire", $obj->getNomStagiaire());
		$q->bindValue(":prenomStagiaire", $obj->getPrenomStagiaire());
		$q->bindValue(":numSecuStagiaire", $obj->getNumSecuStagiaire());
		$q->bindValue(":numBenefStagiaire", $obj->getNumBenefStagiaire());
		$q->bindValue(":dateNaissanceStagiaire", $obj->getDateNaissanceStagiaire());
		$q->bindValue(":emailStagiaire", $obj->getEmailStagiaire());
		$q->execute();
	}

	public static function update(Stagiaireformation $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("UPDATE Stagiaireformation SET idFormation=:idFormation,libelleFormation=:libelleFormation,idSessionFormation=:idSessionFormation,numOffreFormation=:numOffreFormation,idPeriode=:idPeriode,dateDebutPAE=:dateDebutPAE,dateFinPAE=:dateFinPAE,dateRapportSuivi=:dateRapportSuivi,objectifPAE=:objectifPAE,idParticipation=:idParticipation,dateDebut=:dateDebut,dateFin=:dateFin,idStagiaire=:idStagiaire,genreStagiaire=:genreStagiaire,nomStagiaire=:nomStagiaire,prenomStagiaire=:prenomStagiaire,numSecuStagiaire=:numSecuStagiaire,numBenefStagiaire=:numBenefStagiaire,dateNaissanceStagiaire=:dateNaissanceStagiaire,emailStagiaire=:emailStagiaire WHERE idFormation=:idFormation");
		$q->bindValue(":idFormation", $obj->getIdFormation());
		$q->bindValue(":libelleFormation", $obj->getLibelleFormation());
		$q->bindValue(":idSessionFormation", $obj->getIdSessionFormation());
		$q->bindValue(":numOffreFormation", $obj->getNumOffreFormation());
		$q->bindValue(":idPeriode", $obj->getIdPeriode());
		$q->bindValue(":dateDebutPAE", $obj->getDateDebutPAE());
		$q->bindValue(":dateFinPAE", $obj->getDateFinPAE());
		$q->bindValue(":dateRapportSuivi", $obj->getDateRapportSuivi());
		$q->bindValue(":objectifPAE", $obj->getObjectifPAE());
		$q->bindValue(":idParticipation", $obj->getIdParticipation());
		$q->bindValue(":dateDebut", $obj->getDateDebut());
		$q->bindValue(":dateFin", $obj->getDateFin());
		$q->bindValue(":idStagiaire", $obj->getIdStagiaire());
		$q->bindValue(":genreStagiaire", $obj->getGenreStagiaire());
		$q->bindValue(":nomStagiaire", $obj->getNomStagiaire());
		$q->bindValue(":prenomStagiaire", $obj->getPrenomStagiaire());
		$q->bindValue(":numSecuStagiaire", $obj->getNumSecuStagiaire());
		$q->bindValue(":numBenefStagiaire", $obj->getNumBenefStagiaire());
		$q->bindValue(":dateNaissanceStagiaire", $obj->getDateNaissanceStagiaire());
		$q->bindValue(":emailStagiaire", $obj->getEmailStagiaire());
		$q->execute();
	}
	public static function delete(Stagiaireformation $obj)
	{
 		$db=DbConnect::getDb();
		$db->exec("DELETE FROM Stagiaireformation WHERE idFormation=" .$obj->getIdFormation());
	}
	public static function findById($id)
	{
 		$db=DbConnect::getDb();
		$id = (int) $id;
		$q=$db->query("SELECT * FROM Stagiaireformation WHERE idFormation =".$id);
		$results = $q->fetch(PDO::FETCH_ASSOC);
		if($results != false)
		{
			return new Stagiaireformation($results);
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
		$q = $db->query("SELECT * FROM Stagiaireformation");
		while($donnees = $q->fetch(PDO::FETCH_ASSOC))
		{
			if($donnees != false)
			{
				$liste[] = new Stagiaireformation($donnees);
			}
		}
		return $liste;
	}
}