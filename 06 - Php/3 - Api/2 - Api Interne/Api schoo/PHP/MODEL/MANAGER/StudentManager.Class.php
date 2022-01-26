<?php

class StudentManager 
{

	public static function add(Student $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Student $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Student $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Student::getAttributes(),"Student",["StudentId" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Student::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Student",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}