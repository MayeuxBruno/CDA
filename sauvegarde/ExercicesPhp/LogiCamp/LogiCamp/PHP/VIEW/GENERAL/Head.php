<!DOCTYPE html>
<html>
<head>
<?php


//Si le titre est indiqué, on l'affiche entre les balises <title>
echo (!empty($titre)) ? '<title>LogiCamp - ' . $titre . '</title>' : '<title> LogiCamp </title>';
echo '<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<link rel="shortcut icon" type="image/png" href="IMG/logo.png"/>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.15.4/css/all.css"
    integrity="sha384-DyZ88mC6Up2uqS4h/KRgHuoeGwBcD4Ng9SiP4dIRy0EXTlnuz47vAwmeGwVChigm" crossorigin="anonymous">
<link rel="stylesheet" href="CSS/root.css">
<link rel="stylesheet" href="CSS/style.css">';
if (substr($page[1],0,4)=="Form"){
    echo '  <link rel="stylesheet" href="CSS/grids.css">
            <link rel="stylesheet" href="CSS/form.css">';
}
else if (substr($page[1],0,4)=="List"){
    echo '  <link rel="stylesheet" href="CSS/grids.css">';
}
 echo '</head>';