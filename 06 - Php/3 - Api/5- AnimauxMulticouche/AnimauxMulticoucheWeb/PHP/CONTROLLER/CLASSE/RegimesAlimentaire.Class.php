<?php

class RegimesAlimentaire 
{

	/*****************Attributs***************** */

	private $_IdRegimeAlimentaire;
	private $_libelleRegimeAlimentaire;
	private static $_attributes=["IdRegimeAlimentaire","libelleRegimeAlimentaire"];
	/***************** Accesseurs ***************** */


	public function getIdRegimeAlimentaire()
	{
		return $this->_IdRegimeAlimentaire;
	}

	public function setIdRegimeAlimentaire(int $IdRegimeAlimentaire)
	{
		$this->_IdRegimeAlimentaire=$IdRegimeAlimentaire;
	}

	public function getLibelleRegimeAlimentaire()
	{
		return $this->_libelleRegimeAlimentaire;
	}

	public function setLibelleRegimeAlimentaire(?string $libelleRegimeAlimentaire)
	{
		$this->_libelleRegimeAlimentaire=$libelleRegimeAlimentaire;
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
		return "IdRegimeAlimentaire : ".$this->getIdRegimeAlimentaire()."LibelleRegimeAlimentaire : ".$this->getLibelleRegimeAlimentaire()."\n";
	}
}