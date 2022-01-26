<?php

class StudentsGradesCoursesManager 
{

	public static function add(StudentsGradesCourses $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(StudentsGradesCourses $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(StudentsGradesCourses $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(StudentsGradesCourses::getAttributes(),"StudentsGradesCourses",["CourseId" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?StudentsGradesCourses::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"StudentsGradesCourses",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}