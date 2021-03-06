<?php

class Valeurcomportementsprofessionnels 
{

	/*****************Attributs***************** */

	private $_idComportementProfessionnel;
	private $_idStage;
	private $_idLibelleComportementProfessionnel;
	private $_valeurComportement;

	/***************** Accesseurs ***************** */


	public function getIdComportementProfessionnel()
	{
		return $this->_idComportementProfessionnel;
	}

	public function setIdComportementProfessionnel($idComportementProfessionnel)
	{
		$this->_idComportementProfessionnel=$idComportementProfessionnel;
	}

	public function getIdStage()
	{
		return $this->_idStage;
	}

	public function setIdStage($idStage)
	{
		$this->_idStage=$idStage;
	}

	public function getIdLibelleComportementProfessionnel()
	{
		return $this->_idLibelleComportementProfessionnel;
	}

	public function setIdLibelleComportementProfessionnel($idLibelleComportementProfessionnel)
	{
		$this->_idLibelleComportementProfessionnel=$idLibelleComportementProfessionnel;
	}

	public function getValeurComportement()
	{
		return $this->_valeurComportement;
	}

	public function setValeurComportement($valeurComportement)
	{
		$this->_valeurComportement=$valeurComportement;
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
				$this->$methode($value);
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
		return "IdComportementProfessionnel : ".$this->getIdComportementProfessionnel()."IdStage : ".$this->getIdStage()."IdLibelleComportementProfessionnel : ".$this->getIdLibelleComportementProfessionnel()."ValeurComportement : ".$this->getValeurComportement()."\n";
	}


	
	/* Renvoit Vrai si lobjet en paramètre est égal 
	* à l'objet appelant
	*
	* @param [type] $obj
	* @return bool
	*/
	public function equalsTo($obj)
	{
		return;
	}


	/**
	* Compare l'objet à un autre
	* Renvoi 1 si le 1er est >
	*        0 si ils sont égaux
	*      - 1 si le 1er est <
	*
	* @param [type] $obj1
	* @param [type] $obj2
	* @return Integer
	*/
	public function compareTo($obj)
	{
		return;
	}
}