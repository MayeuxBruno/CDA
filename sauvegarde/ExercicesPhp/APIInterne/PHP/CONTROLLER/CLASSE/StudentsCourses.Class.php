<?php

class StudentsCourses 
{

	/*****************Attributs***************** */

	private $_StudentCourseId;
	private $_StudentId;
	private $_CourseId;
	private static $_attributes=["StudentCourseId","StudentId","CourseId"];
	/***************** Accesseurs ***************** */


	public function getStudentCourseId()
	{
		return $this->_StudentCourseId;
	}

	public function setStudentCourseId(int $StudentCourseId)
	{
		$this->_StudentCourseId=$StudentCourseId;
	}

	public function getStudentId()
	{
		return $this->_StudentId;
	}

	public function setStudentId(?int $StudentId)
	{
		$this->_StudentId=$StudentId;
	}

	public function getCourseId()
	{
		return $this->_CourseId;
	}

	public function setCourseId(?int $CourseId)
	{
		$this->_CourseId=$CourseId;
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
		return "StudentCourseId : ".$this->getStudentCourseId()."StudentId : ".$this->getStudentId()."CourseId : ".$this->getCourseId()."\n";
	}
}