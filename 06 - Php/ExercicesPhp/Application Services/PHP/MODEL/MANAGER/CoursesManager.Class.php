<?php

class CoursesManager 
{

	public static function add(Courses $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Courses $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Courses $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Courses::getAttributes(),"Courses",["CourseId" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
		$nomColonnes = ($nomColonnes==null)?Courses::getAttributes():$nomColonnes;
		var_dump($nomColonnes);
 		return DAO::select($nomColonnes,"Courses",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );
	}
}