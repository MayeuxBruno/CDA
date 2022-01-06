<?php
class Services
{
    public static function add($obj)
    {
        $db=DbConnect::getDb();
        $classes=get_class($obj);
    }
    
}