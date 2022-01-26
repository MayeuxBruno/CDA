<?php

class Student 
{

	/*****************Attributs***************** */

	private $_StudentId;
	private $_Name;
	private $_GradeID;
	private static $_attributes=["StudentId","Name","GradeID"];
	/***************** Accesseurs ***************** */


	public function getStudentId()
	{
		return $this->_StudentId;
	}

	public function setStudentId(int $StudentId)
	{
		$this->_StudentId=$StudentId;
	}

	public function getName()
	{
		return $this->_Name;
	}

	public function setName(?string $Name)
	{
		$this->_Name=$Name;
	}

	public function getGradeID()
	{
		return $this->_GradeID;
	}

	public function setGradeID(int $GradeID)
	{
		$this->_GradeID=$GradeID;
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
		return "StudentId : ".$this->getStudentId()."Name : ".$this->getName()."GradeID : ".$this->getGradeID()."\n";
	}
}