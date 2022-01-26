<?php

class StudentsGradesCourses 
{

	/*****************Attributs***************** */

	private $_CourseId;
	private $_courseName;
	private $_Name;
	private $_GradeName;
	private static $_attributes=["CourseId","courseName","Name","GradeName"];
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
		return $this->_courseName;
	}

	public function setCourseName(?string $courseName)
	{
		$this->_courseName=$courseName;
	}

	public function getName()
	{
		return $this->_Name;
	}

	public function setName(?string $Name)
	{
		$this->_Name=$Name;
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
		return "CourseId : ".$this->getCourseId()."CourseName : ".$this->getCourseName()."Name : ".$this->getName()."GradeName : ".$this->getGradeName()."\n";
	}
}