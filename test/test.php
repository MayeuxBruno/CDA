<?php
    $xml = simplexml_load_file("poste.xml");
    $json = json_encode($xml);
    $myArray = json_decode($json,true);
    //var_dump ($myArray['Table']);
    //var_dump (count($myArray['Table']));
    for ($i=0;$i<count($myArray['Table']);$i++)
    {
        var_dump($myArray['Table'][$i]['Name']);
        for ($j=0;$j<count($myArray['Table'][$i]['Column']);$j++)
        {
            var_dump($myArray['Table'][$i]['Column'][$j]['Name']);
        }
    }
    