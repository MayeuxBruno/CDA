var validation={};
var btnValide=document.getElementById("btnsubmit");
var majuscule = document.getElementById("maj");
var minuscule = document.getElementById("min");
var chiffre = document.getElementById("chiffre");
var caracspe = document.getElementById("carSpe");
var taille = document.getElementById("taille");

var lesInputs=document.querySelectorAll('input');
lesInputs.forEach(element => {
    element.addEventListener("input",testValid);
    validation[element.name]=false;
});
console.log(validation);
function testValid(e)
{
    inputActif=e.target;
    inputvalidity=inputActif.checkValidity();
    voyant=e.target.parentNode.nextElementSibling;
    icone = voyant.firstElementChild;
    inputvalidity=inputActif.checkValidity();

    switch(inputActif.id)
    {
        case "nom" :    
        case "prenom":
        case "telephone":
        case "mail":
            if(inputvalidity)
            {
                voyantvert(icone);
                validation[inputActif.name]=true;
            }
            else{
                voyantrouge(icone);
                validation[inputActif.name]=false;
            }
        break;
        case "naissance":
            let ladate=new Date();
            let dateNaissance=new Date(e.target.value);
            if (dateNaissance<ladate)
            {
                voyantvert(icone);
                validation[inputActif.name]=true;
            }
            else{
                voyantrouge(icone);
                validation[inputActif.name]=false;
            }
        break;
        case "mdp":
            mdp=inputActif.value;
            mdpOk=true;
            if(/[A-Z]/.test(mdp))
            {
                 voyantvert(majuscule);
            }
            else{
                voyantrouge(majuscule);
                mdpOk=false;
            }
            if(/[a-z]/.test(mdp))
            {
                voyantvert(minuscule);
            }
            else{
                voyantrouge(minuscule);
                mdpOk=false;
            }
            if(/[0-9]/.test(mdp))
            {
               voyantvert(chiffre);
            }
            else{
               voyantrouge(chiffre);
                mdpOk=false;
            }
            if(/\W/.test(mdp))
            {
                voyantvert(caracspe);
            }
            else{
               voyantrouge(caracspe);
               mdpOk=false;
            }
            if(mdp.length>7)
            {
                voyantvert(taille);
            }
            else{
               voyantrouge(taille);
               mdpOk=false;
            }
           if(mdpOk)
           {
            validation["mdp"]=true;
           }
           else{
            validation["mdp"]=false;
           }
        break;
        case "confirmation":
            confirm=e.target;
            mdp=document.getElementById("mdp").value;
            if (confirm.value==mdp)
            {
               voyantvert(icone);
                validation["confirmation"]=true;
            }
            else{
                voyantrouge(icone);
                validation["confirmation"]=false;
            }
            break;
        default:
        break;
    }
    ValidForm();
}

function voyantvert(voyant)
{
    voyant.classList.remove("fa-times","rouge");
    voyant.classList.add("fa-check","vert");
}

function voyantrouge(voyant)
{
    voyant.classList.add("fa-times","rouge");
    voyant.classList.remove("fa-check","vert");
}

function ValidForm()
{
    console.log(validation);
    btnValide.disabled=true;
    if(Object.values(validation).indexOf(false)==-1)
    {
        btnValide.disabled=false;
    }
}

