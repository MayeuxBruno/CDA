<?php

class GradesManager 
{

	public static function add(Grades $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Grades $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Grades $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Grades::getAttributes(),"Grades",["GradeID" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Grades::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Grades",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}