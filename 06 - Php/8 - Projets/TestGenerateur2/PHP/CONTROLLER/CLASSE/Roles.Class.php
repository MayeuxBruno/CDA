<?php

class Roles 
{

	/*****************Attributs***************** */

	private $_IdRole;
	private $_libelleRole;
	private static $_attributes=["IdRole","libelleRole"];
	/***************** Accesseurs ***************** */


	public function getIdRole()
	{
		return $this->_IdRole;
	}

	public function setIdRole(int $IdRole)
	{
		$this->_IdRole=$IdRole;
	}

	public function getLibelleRole()
	{
		return $this->_libelleRole;
	}

	public function setLibelleRole(string $libelleRole)
	{
		$this->_libelleRole=$libelleRole;
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
		return "IdRole : ".$this->getIdRole()."LibelleRole : ".$this->getLibelleRole()."\n";
	}
}