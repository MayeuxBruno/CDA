<?php

class TypesemplacementsManager 
{

	public static function add(Typesemplacements $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Typesemplacements $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Typesemplacements $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Typesemplacements::getAttributes(),"Typesemplacements",["IdTypeEmplacement" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Typesemplacements::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Typesemplacements",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}