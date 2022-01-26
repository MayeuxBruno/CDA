<?php
//fichier pour appel AJAX
//var_dump($_POST);
$id=$_POST["idPersonne"];
echo json_encode(StudentsManager::getById($id,true));
