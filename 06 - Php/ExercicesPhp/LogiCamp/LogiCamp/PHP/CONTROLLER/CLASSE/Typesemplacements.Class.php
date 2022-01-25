<?php

class Typesemplacements 
{

	/*****************Attributs***************** */

	private $_IdTypeEmplacement;
	private $_libelleTypeEmplacement;
	private static $_attributes=["IdTypeEmplacement","libelleTypeEmplacement"];
	/***************** Accesseurs ***************** */


	public function getIdTypeEmplacement()
	{
		return $this->_IdTypeEmplacement;
	}

	public function setIdTypeEmplacement(int $IdTypeEmplacement)
	{
		$this->_IdTypeEmplacement=$IdTypeEmplacement;
	}

	public function getLibelleTypeEmplacement()
	{
		return $this->_libelleTypeEmplacement;
	}

	public function setLibelleTypeEmplacement(?string $libelleTypeEmplacement)
	{
		$this->_libelleTypeEmplacement=$libelleTypeEmplacement;
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
		return "IdTypeEmplacement : ".$this->getIdTypeEmplacement()."LibelleTypeEmplacement : ".$this->getLibelleTypeEmplacement()."\n";
	}
}