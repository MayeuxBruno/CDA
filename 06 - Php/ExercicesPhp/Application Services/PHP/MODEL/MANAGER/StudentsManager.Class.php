<?php

class StudentsManager 
{

	public static function add(Students $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Students $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Students $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Students::getAttributes(),"Students",["StudentId" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
		$nomColonnes = ($nomColonnes==null)?Students::getAttributes():$nomColonnes;
		var_dump($nomColonnes);
 		return DAO::select($nomColonnes,"Students",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );
	}
}