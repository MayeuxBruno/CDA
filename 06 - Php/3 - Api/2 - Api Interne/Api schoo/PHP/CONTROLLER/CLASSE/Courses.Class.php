<?php

class Courses 
{

	/*****************Attributs***************** */

	private $_CourseId;
	private $_CourseName;
	private $_Description;
	private static $_attributes=["CourseId","CourseName","Description"];
	/***************** Accesseurs ***************** */


	public function getCourseId()
	{
		return $this->_CourseId;
	}

	public function setCourseId(int $CourseId)
	{
		$this->_CourseId=$CourseId;
	}

	public function getCourseName()
	{
		return $this->_CourseName;
	}

	public function setCourseName(?string $CourseName)
	{
		$this->_CourseName=$CourseName;
	}

	public function getDescription()
	{
		return $this->_Description;
	}

	public function setDescription(?string $Description)
	{
		$this->_Description=$Description;
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
		return "CourseId : ".$this->getCourseId()."CourseName : ".$this->getCourseName()."Description : ".$this->getDescription()."\n";
	}
}