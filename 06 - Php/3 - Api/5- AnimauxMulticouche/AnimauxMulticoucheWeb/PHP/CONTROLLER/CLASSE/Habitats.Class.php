<?php

class Habitats 
{

	/*****************Attributs***************** */

	private $_IdHabitat;
	private $_libelleHabitat;
	private static $_attributes=["IdHabitat","libelleHabitat"];
	/***************** Accesseurs ***************** */


	public function getIdHabitat()
	{
		return $this->_IdHabitat;
	}

	public function setIdHabitat(int $IdHabitat)
	{
		$this->_IdHabitat=$IdHabitat;
	}

	public function getLibelleHabitat()
	{
		return $this->_libelleHabitat;
	}

	public function setLibelleHabitat(string $libelleHabitat)
	{
		$this->_libelleHabitat=$libelleHabitat;
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
		return "IdHabitat : ".$this->getIdHabitat()."LibelleHabitat : ".$this->getLibelleHabitat()."\n";
	}
}