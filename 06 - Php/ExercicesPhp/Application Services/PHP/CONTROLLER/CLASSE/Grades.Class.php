<?php
class Grades
{

	/*****************Attributs***************** */

	private $_GradeId;
	private $_GradeName;
	private static $_attributes=["GradeId","GradeName"];

	/***************** Accesseurs ***************** */
	
    public function getGradeId()
	{
		return $this->_GradeId;
	}

	public function setGradeId($_GradeId)
	{
		$this->_GradeId = $_GradeId;

	}

	public function getGradeName()
	{
		return $this->_CourseName;
	}

	public function setGradeName($_CourseName)
	{
		$this->_CourseName = $_CourseName;
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
		return "GradeId: ".$this->getGradeId()."<br>GradeName : ".$this->getGradeName();
	}

}
