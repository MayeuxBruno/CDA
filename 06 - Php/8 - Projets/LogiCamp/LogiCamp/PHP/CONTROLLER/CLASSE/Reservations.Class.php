<?php

class Reservations 
{

	/*****************Attributs***************** */

	private $_idReservation;
	private $_idClient;
	private $_idEmplacement;
	private $_dateReservation;
	private $_debutSejour;
	private $_finSejour;
	private static $_attributes=["idReservation","idClient","idEmplacement","dateReservation","debutSejour","finSejour"];
	/***************** Accesseurs ***************** */


	public function getIdReservation()
	{
		return $this->_idReservation;
	}

	public function setIdReservation(int $idReservation)
	{
		$this->_idReservation=$idReservation;
	}

	public function getIdClient()
	{
		return $this->_idClient;
	}

	public function setIdClient(int $idClient)
	{
		$this->_idClient=$idClient;
	}

	public function getIdEmplacement()
	{
		return $this->_idEmplacement;
	}

	public function setIdEmplacement(int $idEmplacement)
	{
		$this->_idEmplacement=$idEmplacement;
	}

	public function getDateReservation()
	{
		return is_null($this->_dateReservation)?null:$this->_dateReservation->format('Y-n-j');
	}

	public function setDateReservation(?string $dateReservation)
	{
		$this->_dateReservation=is_null($dateReservation)?null:DateTime::createFromFormat("Y-n-j",$dateReservation);
	}

	public function getDebutSejour()
	{
		return is_null($this->_debutSejour)?null:$this->_debutSejour->format('Y-n-j');
	}

	public function setDebutSejour(?string $debutSejour)
	{
		$this->_debutSejour=is_null($debutSejour)?null:DateTime::createFromFormat("Y-n-j",$debutSejour);
	}

	public function getFinSejour()
	{
		return is_null($this->_finSejour)?null:$this->_finSejour->format('Y-n-j');
	}

	public function setFinSejour(?string $finSejour)
	{
		$this->_finSejour=is_null($finSejour)?null:DateTime::createFromFormat("Y-n-j",$finSejour);
	}

	public static function getAttributes()
	{
		return self::$_attributes;
	}

	/*****************Constructeur***************** */

	public function __construct(array $options = [])
	{
 		if (!empty($options)) // empty : renvoi vrai si le tableau est vide
		{
			$this->hydrate($options);
		}
	}
	public function hydrate($data)
	{
 		foreach ($data as $key => $value)
		{
 			$methode = "set".ucfirst($key); //ucfirst met la 1ere lettre en majuscule
			if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
			{
				$this->$methode($value===""?null:$value);
			}
		}
	}

	/*****************Autres Méthodes***************** */

	/**
	* Transforme l'objet en chaine de caractères
	*
	* @return String
	*/
	public function toString()
	{
		return "IdReservation : ".$this->getIdReservation()."IdClient : ".$this->getIdClient()."IdEmplacement : ".$this->getIdEmplacement()."DateReservation : ".$this->getDateReservation()."DebutSejour : ".$this->getDebutSejour()."FinSejour : ".$this->getFinSejour()."\n";
	}
}