<?php

class LignespaniersManager 
{

	public static function add(Lignespaniers $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Lignespaniers $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Lignespaniers $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Lignespaniers::getAttributes(),"Lignespaniers",["IdLignePanier" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Lignespaniers::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Lignespaniers",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}