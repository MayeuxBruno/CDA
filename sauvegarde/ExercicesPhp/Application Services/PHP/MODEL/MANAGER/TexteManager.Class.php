<?php

class TexteManager
{

	public static function findByCodes($codeLangue, $codeTexte)
	{
		$text = DAO::select([$codeLangue], "texte", ["codeTexte" => $codeTexte],null,null,true,false);
		return $text[0][$codeLangue];
	}

	public static function checkIfLangExist($codeLangue)
	{
		$db = DbConnect::getDb();
		$q = $db->prepare("SHOW COLUMNS FROM texte LIKE :codeLangue");
		$q->bindValue(":codeLangue", $codeLangue, PDO::PARAM_STR);
		$q->execute();
		$results = $q->fetch(PDO::FETCH_ASSOC);
		return ($results != false); // renvoi vrai si la requete retourne des données, false sinon
	}
}
