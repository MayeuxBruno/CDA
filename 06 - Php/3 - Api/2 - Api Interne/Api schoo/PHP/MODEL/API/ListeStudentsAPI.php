<?php
$idCour=intval($_POST['idCours']);
// *** Gestion avec vue *** //
echo json_encode((StudentsGradesCoursesManager::getList(['Name','GradeName'],['CourseId' => $idCour],null,null,true,false)));

// *** Gestion sans vue *** //
// $listeEleves=StudentsCoursesManager::getList(['StudentId'], ['CourseId' => $idCour],null,null,true,false);
// for($i=0;$i<count($listeEleves);$i++)
// {
//     $eleve=StudentManager::findById(intval($listeEleves[$i]['StudentId']));
//     $listeEleves[$i]['Name']=$eleve->getName();
//     $listeEleves[$i]['GradeId']=GradeManager::findById(intval($eleve->getGradeId()))->getGradeName();
//}
//echo json_encode($listeEleves);

// $listeStudent=StudentManager::getList(['Name','GradeId'],null,null,null,true,false);
// for($i=0;$i<count($listeStudent);$i++)
// {
//     $classe=GradeManager::findById(intval($listeStudent[$i]['GradeId']))->getGradeName();
//     $listeStudent[$i]['GradeId']=$classe;
// }
// echo json_encode($listeStudent);
?>