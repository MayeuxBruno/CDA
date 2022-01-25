<?php

class Animaux 
{

	/*****************Attributs***************** */

	private $_IdAnimal;
	private $_nomAnimal;
	private $_IdRegimeAlimentaire;
	private $_IdHabitat;
	private static $_attributes=["IdAnimal","nomAnimal","IdRegimeAlimentaire","IdHabitat"];
	/***************** Accesseurs ***************** */


	public function getIdAnimal()
	{
		return $this->_IdAnimal;
	}

	public function setIdAnimal(int $IdAnimal)
	{
		$this->_IdAnimal=$IdAnimal;
	}

	public function getNomAnimal()
	{
		return $this->_nomAnimal;
	}

	public function setNomAnimal(string $nomAnimal)
	{
		$this->_nomAnimal=$nomAnimal;
	}

	public function getIdRegimeAlimentaire()
	{
		return $this->_IdRegimeAlimentaire;
	}

	public function setIdRegimeAlimentaire(int $IdRegimeAlimentaire)
	{
		$this->_IdRegimeAlimentaire=$IdRegimeAlimentaire;
	}

	public function getIdHabitat()
	{
		return $this->_IdHabitat;
	}

	public function setIdHabitat(int $IdHabitat)
	{
		$this->_IdHabitat=$IdHabitat;
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
		return "IdAnimal : ".$this->getIdAnimal()."NomAnimal : ".$this->getNomAnimal()."IdRegimeAlimentaire : ".$this->getIdRegimeAlimentaire()."IdHabitat : ".$this->getIdHabitat()."\n";
	}
}