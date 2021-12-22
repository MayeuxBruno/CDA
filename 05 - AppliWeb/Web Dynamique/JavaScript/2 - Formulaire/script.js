var inputNom = document.getElementById("nom");
var inputPrenom = document.getElementById("prenom");
var inputMail = document.getElementById("mail");
var inputPhone = document.getElementById("telephone");
var inputMdp = document.getElementById("mdp");
inputNom.addEventListener("input",testValid);
inputPrenom.addEventListener("input",testValid);
inputMail.addEventListener("input",testValid);
inputPhone.addEventListener("input",testValid);
inputMdp.addEventListener("input",testValid);



function testValid(e)
{
    var inputvalidity=e.target.checkValidity();
    if(inputvalidity)
    {
        e.target.parentNode.parentNode.querySelector(".ok").style.display="flex";
        e.target.parentNode.parentNode.querySelector(".ko").style.display="none";
    }
    else{
        e.target.parentNode.parentNode.querySelector(".ko").style.display="flex";
        e.target.parentNode.parentNode.querySelector(".ok").style.display="none";
    }
}
