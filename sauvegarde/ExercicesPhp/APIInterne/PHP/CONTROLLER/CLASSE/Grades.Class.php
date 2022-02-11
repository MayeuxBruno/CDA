<?php

class Grades 
{

	/*****************Attributs***************** */

	private $_GradeID;
	private $_GradeName;
	private static $_attributes=["GradeID","GradeName"];
	/***************** Accesseurs ***************** */


	public function getGradeID()
	{
		return $this->_GradeID;
	}

	public function setGradeID(int $GradeID)
	{
		$this->_GradeID=$GradeID;
	}

	public function getGradeName()
	{
		return $this->_GradeName;
	}

	public function setGradeName(?string $GradeName)
	{
		$this->_GradeName=$GradeName;
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
		return "GradeID : ".$this->getGradeID()."GradeName : ".$this->getGradeName()."\n";
	}
}