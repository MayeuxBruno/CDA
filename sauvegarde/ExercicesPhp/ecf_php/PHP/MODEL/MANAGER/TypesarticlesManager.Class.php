<?php

class TypesarticlesManager 
{

	public static function add(Typesarticles $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Typesarticles $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Typesarticles $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Typesarticles::getAttributes(),"Typesarticles",["IdTypeArticle" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Typesarticles::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Typesarticles",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}