<?php
 // $r = new Regions(["libelleRegion"=>"test","numeroRegion"=>3]);
  //var_dump(RegionsManager::add($r));
//   $r = RegionsManager::findById(15);
//  $r2 = RegionsManager::findById(16);
 //$r->setLibelleRegion("toto");
// var_dump($r);
 //var_dump(RegionsManager::update($r));
// var_dump( RegionsManager::delete($r));
//$d = DepartementsManager::getList(null,["idRegion"=>[7,2,3],"LibelleDepartement"=>"%i%"],"libelleDepartement DESC",null,true,true);
//var_dump($d);

// $cours=new Courses(["CourseName"=>"Dessin","Description"=>"Cours de dessin"]);
// CoursesManager::add($cours);
// $d = CoursesManager::getList(null,null,"CourseName",null,true,true);
// var_dump($d);

// $cours=new Students(["Name"=>"Gorriez","LastName"=>"Joelle","GradeId"=>2]);
// StudentsManager::add($cours);
// $d = StudentsManager::getList(null,null,"Name",null,true,true);
// var_dump($d);

// $d = GradesManager::getList(null,null,null,null,true,true);
// var_dump($d);

$cours=new StudentsCourses(["StudentId"=>1,"COurseId"=>2]);
StudentsCoursesManager::add($cours);
$d = StudentsCoursesManager::getList(null,null,null,null,true,true);
var_dump($d);