<?php

class Emplacements 
{

	/*****************Attributs***************** */

	private $_idEmplacement;
	private $_refEmplacment;
	private $_descriptionEmplacement;
	private $_eau;
	private $_electricite;
	private $_IdTypeEmplacement;
	private static $_attributes=["idEmplacement","refEmplacment","descriptionEmplacement","eau","electricite","IdTypeEmplacement"];
	/***************** Accesseurs ***************** */


	public function getIdEmplacement()
	{
		return $this->_idEmplacement;
	}

	public function setIdEmplacement(int $idEmplacement)
	{
		$this->_idEmplacement=$idEmplacement;
	}

	public function getRefEmplacment()
	{
		return $this->_refEmplacment;
	}

	public function setRefEmplacment(string $refEmplacment)
	{
		$this->_refEmplacment=$refEmplacment;
	}

	public function getDescriptionEmplacement()
	{
		return $this->_descriptionEmplacement;
	}

	public function setDescriptionEmplacement(?string $descriptionEmplacement)
	{
		$this->_descriptionEmplacement=$descriptionEmplacement;
	}

	public function getEau()
	{
		return $this->_eau;
	}

	public function setEau(?string $eau)
	{
		$this->_eau=$eau;
	}

	public function getElectricite()
	{
		return $this->_electricite;
	}

	public function setElectricite(?string $electricite)
	{
		$this->_electricite=$electricite;
	}

	public function getIdTypeEmplacement()
	{
		return $this->_IdTypeEmplacement;
	}

	public function setIdTypeEmplacement(int $IdTypeEmplacement)
	{
		$this->_IdTypeEmplacement=$IdTypeEmplacement;
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
		return "IdEmplacement : ".$this->getIdEmplacement()."RefEmplacment : ".$this->getRefEmplacment()."DescriptionEmplacement : ".$this->getDescriptionEmplacement()."Eau : ".$this->getEau()."Electricite : ".$this->getElectricite()."IdTypeEmplacement : ".$this->getIdTypeEmplacement()."\n";
	}
}