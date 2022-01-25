<?php

class StudentsCoursesManager 
{

	public static function add(StudentsCourses $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(StudentsCourses $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(StudentsCourses $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(StudentsCourses::getAttributes(),"StudentsCourses",["StudentCourseId" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
		$nomColonnes = ($nomColonnes==null)?StudentsCourses::getAttributes():$nomColonnes;
		var_dump($nomColonnes);
 		return DAO::select($nomColonnes,"StudentsCourses",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );
	}
}