<?php
class TexteManager 
{
	public static function findByCodes($codeLangue,$codeTexte)
	{
		$langue=strtolower($codeLangue);
		$db=DbConnect::getDb();
		$q=$db->prepare("SELECT * FROM trad WHERE codeTexte = :codeTexte");
		$q->bindValue(":codeTexte", $codeTexte,PDO::PARAM_STR);
		$q->execute();
		$results = $q->fetch(PDO::FETCH_ASSOC);
		if($results != false)
		{
			return $results[$langue];  // on ne retourne que le texte, pas un objet
		}
		else
		{
			return false;
		}
	}
}