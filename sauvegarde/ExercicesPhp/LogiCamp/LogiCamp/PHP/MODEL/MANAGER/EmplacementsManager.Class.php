<?php

class EmplacementsManager 
{

	public static function add(Emplacements $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Emplacements $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Emplacements $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Emplacements::getAttributes(),"Emplacements",["idEmplacement" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Emplacements::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Emplacements",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}