<?php

class RegimesalimentaireManager 
{

	public static function add(Regimesalimentaire $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Regimesalimentaire $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Regimesalimentaire $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Regimesalimentaire::getAttributes(),"Regimesalimentaire",["IdRegimeAlimentaire" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Regimesalimentaire::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Regimesalimentaire",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}