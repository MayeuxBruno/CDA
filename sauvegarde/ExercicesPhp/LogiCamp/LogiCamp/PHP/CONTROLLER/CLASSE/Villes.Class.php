<?php

class Villes 
{

	/*****************Attributs***************** */

	private $_idVille;
	private $_nomVille;
	private $_codePostal;
	private static $_attributes=["idVille","nomVille","codePostal"];
	/***************** Accesseurs ***************** */


	public function getIdVille()
	{
		return $this->_idVille;
	}

	public function setIdVille(int $idVille)
	{
		$this->_idVille=$idVille;
	}

	public function getNomVille()
	{
		return $this->_nomVille;
	}

	public function setNomVille(?string $nomVille)
	{
		$this->_nomVille=$nomVille;
	}

	public function getCodePostal()
	{
		return $this->_codePostal;
	}

	public function setCodePostal(?string $codePostal)
	{
		$this->_codePostal=$codePostal;
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
		return "IdVille : ".$this->getIdVille()."NomVille : ".$this->getNomVille()."CodePostal : ".$this->getCodePostal()."\n";
	}
}