<?php
class Students
{

	/*****************Attributs***************** */

	private $_StudentId;
	private $_Name;
	private $_LastName;
    private $_GradeId;
	private static $_attributes=["StudentID","Name","LastName","GradeId"];

	/***************** Accesseurs ***************** */
	
    public function getStudentId()
	{
		return $this->_StudentId;
	}

	public function setStudentId($StudentId)
	{
		$this->_StudentId = $StudentId;

	}

	public function getName()
	{
		return $this->_Name;
	}

	public function setName($Name)
	{
		$this->_Name = $Name;
	}

	public function getLastName()
	{
		return $this->_LastName;
	}

	public function setLastName($LastName)
	{
		$this->_Name = $LastName;
	}

    public function getGradeId()
	{
		return $this->_GradeId;
	}

	public function setGradeId($GradeId)
	{
		$this->_GradeId = $GradeId;

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
		return "StudentId: ".$this->getStudentId()."<br>StudentName : ".$this->getName()."<br>StudentName : ".$this->getLastName()."<br>GradeId : ".$this->getGradeId();
	}

}