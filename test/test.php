<?php
    $xml = simplexml_load_file("poste.xml");
    $json = json_encode($xml);
    $myArray = json_decode($json,true);
    var_dump ($myArray['Table'][0]['Column'][0]);
    