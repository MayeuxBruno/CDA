<?php

class HabitatsManager 
{

	public static function add(Habitats $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Habitats $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Habitats $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Habitats::getAttributes(),"Habitats",["IdHabitat" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Habitats::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Habitats",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}