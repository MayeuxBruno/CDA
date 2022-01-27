<?php

class RegimesAlimentaireManager 
{

	public static function add(RegimesAlimentaire $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(RegimesAlimentaire $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(RegimesAlimentaire $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(RegimesAlimentaire::getAttributes(),"RegimesAlimentaire",["IdRegimeAlimentaire" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?RegimesAlimentaire::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"RegimesAlimentaire",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}