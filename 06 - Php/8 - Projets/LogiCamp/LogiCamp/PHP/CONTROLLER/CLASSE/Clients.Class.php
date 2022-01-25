<?php

class Clients 
{

	/*****************Attributs***************** */

	private $_idClient;
	private $_nomClient;
	private $_prenomClient;
	private $_telClient;
	private $_mailClient;
	private $_adresseClient;
	private $_idVille;
	private static $_attributes=["idClient","nomClient","prenomClient","telClient","mailClient","adresseClient","idVille"];
	/***************** Accesseurs ***************** */


	public function getIdClient()
	{
		return $this->_idClient;
	}

	public function setIdClient(int $idClient)
	{
		$this->_idClient=$idClient;
	}

	public function getNomClient()
	{
		return $this->_nomClient;
	}

	public function setNomClient(?string $nomClient)
	{
		$this->_nomClient=$nomClient;
	}

	public function getPrenomClient()
	{
		return $this->_prenomClient;
	}

	public function setPrenomClient(?string $prenomClient)
	{
		$this->_prenomClient=$prenomClient;
	}

	public function getTelClient()
	{
		return $this->_telClient;
	}

	public function setTelClient(string $telClient)
	{
		$this->_telClient=$telClient;
	}

	public function getMailClient()
	{
		return $this->_mailClient;
	}

	public function setMailClient(?string $mailClient)
	{
		$this->_mailClient=$mailClient;
	}

	public function getAdresseClient()
	{
		return $this->_adresseClient;
	}

	public function setAdresseClient(?string $adresseClient)
	{
		$this->_adresseClient=$adresseClient;
	}

	public function getIdVille()
	{
		return $this->_idVille;
	}

	public function setIdVille(int $idVille)
	{
		$this->_idVille=$idVille;
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
		return "IdClient : ".$this->getIdClient()."NomClient : ".$this->getNomClient()."PrenomClient : ".$this->getPrenomClient()."TelClient : ".$this->getTelClient()."MailClient : ".$this->getMailClient()."AdresseClient : ".$this->getAdresseClient()."IdVille : ".$this->getIdVille()."\n";
	}
}