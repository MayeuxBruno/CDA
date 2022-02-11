<?php

class ReservationsManager 
{

	public static function add(Reservations $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Reservations $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Reservations $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Reservations::getAttributes(),"Reservations",["idReservation" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Reservations::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Reservations",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}