<?php

class GradeManager 
{

	public static function add(Grade $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Grade $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Grade $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Grade::getAttributes(),"Grade",["GradeID" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Grade::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Grade",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}