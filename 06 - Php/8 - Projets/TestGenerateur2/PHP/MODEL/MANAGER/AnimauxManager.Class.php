<?php

class AnimauxManager 
{

	public static function add(Animaux $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Animaux $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Animaux $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Animaux::getAttributes(),"Animaux",["IdAnimal" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Animaux::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Animaux",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}