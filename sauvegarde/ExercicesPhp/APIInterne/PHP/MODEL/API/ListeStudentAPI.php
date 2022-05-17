<?php
die(var_dump(StudentsManager::getList(['Name','LastName'],null,null,null,true,false)));
// echo json_encode(StudentsManager::getList(['Name','LastName'],null,null,null,true,false));