<?php
require "Employe.Class.php";
require "Agence.Class.php";
require "Enfant.Class.php";

function afficherTableau($tab)
{
    echo "<br>";
    foreach ($tab as $value) {
        echo $value->toString()."<br>";
    }
    echo "<br>";
}

function verserPrime($emp)
{
    $dateActuelle=new DateTime('now');
    $DatePrime=new DateTime("01-01-".$dateActuelle->format('Y'));
    if($dateActuelle>$DatePrime)
    {
        echo "<br>Le virement va être effectué.";
        foreach ($emp as  $value) {
            echo"<br> Versement de la prime pour ".$value->getNom()." ".$value->getPrenom()." Montant : ".$value->prime();
        }
    }
    else{
        echo "<br>Virement non effectué";
    }
}

function masseSalariale($emp)
{
    $somme=0;
    foreach ($emp as $value) {
        $somme+=$value->masseSalariale();
    }
    return $somme;
}

function nbEmployes()
{
    echo "<br>Il y a ".Employe::getNbEmployes()."employes de créés.<br>";
}
$agence1 = new Agence (["nomAgence"=>"Flandres","adresse"=>"12 Boulevard Vauban","codePostal"=>"59000","ville"=>"Lille","restauration"=>true]);
$agence2 = new Agence (["nomAgence"=>"Littoral","adresse"=>"1 rue de la plage","codePostal"=>"59120","ville"=>"Dunkerque","restauration"=>false]);
$agence3 = new Agence (["nomAgence"=>"Artois","adresse"=>"28 Grand place","codePostal"=>"62000","ville"=>"Arras","restauration"=>true]);

$listeEnfant[] = new Enfant (["nom"=>"Lelong","prenom"=>"Jean","dateNaissance"=>new DateTime("12-11-2012")]);
$listeEnfant[] = new Enfant (["nom"=>"Lelong","prenom"=>"Martin","dateNaissance"=>new DateTime("12-11-2000")]);
$listeEnfant[] = new Enfant (["nom"=>"Toupin","prenom"=>"Maxence","dateNaissance"=>new DateTime("12-11-2012")]);
$listeEnfant[] = new Enfant (["nom"=>"Toupin","prenom"=>"Jean","dateNaissance"=>new DateTime("12-11-2014")]);
$listeEnfant[] = new Enfant (["nom"=>"Toupin","prenom"=>"Nicolas","dateNaissance"=>new DateTime("12-11-2016")]);

$listeEmployes[]=new Employe (["nom"=>"Lelong","prenom"=>"David","dateEmbauche"=> new DateTime("20-12-2021"),"fonction"=>"Comptable","salaireAnnuel"=>"30","service"=>"B2","agence"=>$agence1,"enfants"=>[$listeEnfant[0],$listeEnfant[1]]]);
$listeEmployes[]=new Employe (["nom"=>"Dupont","prenom"=>"Gerard","dateEmbauche"=> new DateTime("06-03-2002"),"fonction"=>"Secretaire","salaireAnnuel"=>"40","service"=>"B2","agence"=>$agence2]);
$listeEmployes[]=new Employe (["nom"=>"Honnart","prenom"=>"Nicolas","dateEmbauche"=> new DateTime("08-08-2006"),"fonction"=>"commercial","salaireAnnuel"=>"50","service"=>"B1","agence"=>$agence2]);
$listeEmployes[]=new Employe (["nom"=>"Noyelles","prenom"=>"Stephane","dateEmbauche"=> new DateTime("06-06-2010"),"fonction"=>"Agent Technique","salaireAnnuel"=>"20","service"=>"B4","agence"=>$agence1]);
$listeEmployes[]=new Employe (["nom"=>"Toupin","prenom"=>"Laurent","dateEmbauche"=> new DateTime("01-01-2000"),"fonction"=>"Directeur","salaireAnnuel"=>"60","service"=>"DIR","agence"=>$agence3,"enfants"=>[$listeEnfant[2],$listeEnfant[3]]]);

// var_dump($listeEnfant[0]);
// var_dump($listeEmployes[0]);
// $listeEmployes[0]->chequesNoel();
//echo $enfant->chequesNoel();

//echo $agence1->toString();
// usort($listeEmployes,array("Employe","triParNomPrenom"));
 afficherTableau($listeEmployes);
// 
// verserPrime($listeEmployes);
// echo "<br>Masse Salariale : ".masseSalariale($listeEmployes);
// echo $e1->ToString();
// $anciennete=$e1->anciennete();
// $prime=$e1->prime();
// var_dump($anciennete);
// var_dump($prime);