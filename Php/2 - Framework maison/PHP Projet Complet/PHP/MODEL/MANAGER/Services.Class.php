<?php
class Services
{
    public static function add($obj)
    {
        $db=DbConnect::getDb();
        $classe=get_class($obj);
        $colonnes=$classe::getAttributes();
        $request="INSERT INTO ".$classe." (";
        $value="";
        for ($i=1; $i <count($colonnes) ; $i++) { 
            $request.=$colonnes[$i].",";
            $value.=":".$colonnes[$i].",";
        }
        $request=substr($request,0,strlen($request)-1);
        $value=substr($value,0,strlen($value)-1);
        $request.=") VALUES (".$value.")";
        $q=$db->prepare($request);
        for ($i=1; $i <count($colonnes) ; $i++) { 
            $meth="get".ucfirst($colonnes[$i]);
            $q->bindValue(":".$colonnes[$i],$obj->$meth());
        }
        $q->execute();
    }
    public static function update($obj)
    {
        $db=DbConnect::getDb();
        $classe=get_class($obj);
        $colonnes=$classe::getAttributes();
        $request="UPDATE ".$classe." SET ";
        for ($i=1; $i <count($colonnes) ; $i++) { 
            $request.=$colonnes[$i]."=:".$colonnes[$i].",";
        }
        $request=substr($request,0,strlen($request)-1);
        $request.=" WHERE ".$colonnes[0]."=:".$colonnes[0];
        $q=$db->prepare($request);
        for ($i=0; $i <count($colonnes) ; $i++) 
        { 
            $meth="get".ucfirst($colonnes[$i]);
            $q->bindValue(":".$colonnes[$i],$obj->$meth());
        }
        $q->execute();
    }
    public static function delete($obj)
    {
        $db=DbConnect::getDb();
        $classe=get_class($obj);
        $colonnes=$classe::getAttributes();
        $request="DELETE FROM ".$classe." WHERE ";
        $meth="get".ucFirst($colonnes[0]);
        $request.=$colonnes[0]."=".$obj->$meth();
        $db->exec($request);
    }
    public static function getListe($table)
	{
 		$db=DbConnect::getDb();
		$liste = [];
        $request="SELECT * FROM ".$table;
        $q=$db->query($request);
		while($donnees = $q->fetch(PDO::FETCH_ASSOC))
		{
			if($donnees != false)
			{
				$liste[] = new $table ($donnees);
			}
		}
		return $liste;
	}
}
