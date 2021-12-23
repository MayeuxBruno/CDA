var lesInputs=document.querySelectorAll('input:not([id*="mdp"],[id*="naissance"])');
var inputMdp = document.getElementById("mdp");
var inputNaissance = document.getElementById("naissance");
var btnValide=document.getElementById("btnsubmit");
var validation={};

lesInputs.forEach(element => {
    element.addEventListener("input",testValid);
    validation[element.name]=false;
});

inputMdp.addEventListener("input",testValidMdp);
validation["mdp"]=true;
inputNaissance.addEventListener("change",testValidNaissance);
validation["naissance"]=false;
console.log(validation);
function testValid(e)
{
    inputActif=e.target;
    inputvalidity=inputActif.checkValidity();
    voyant=e.target.parentNode.nextElementSibling;
    icone = voyant.firstElementChild;
    inputvalidity=inputActif.checkValidity();

    if(inputvalidity)
    {
        icone.classList.remove("fa-times","rouge");
        icone.classList.add("fa-check","vert");
        validation[inputActif.name]=true;
    }
    else{
        icone.classList.add("fa-times","rouge");
        icone.classList.remove("fa-check","vert");
        validation[inputActif.name]=false;
    }
    ValidForm();
    console.log(validation);
}

function testValidMdp()
{

}

function testValidNaissance(e)
{
    let inputDate=e.target;
    voyant=e.target.parentNode.nextElementSibling;
    icone = voyant.firstElementChild;
    let ladate=new Date();
    let dateNaissance=new Date(e.target.value);
    if (dateNaissance<ladate)
    {
        icone.classList.remove("fa-times","rouge");
        icone.classList.add("fa-check","vert");
        validation[inputDate.name]=true;
    }
    else{
        icone.classList.add("fa-times","rouge");
        icone.classList.remove("fa-check","vert");
        validation[inputDate.name]=false;
    }
    console.log(validation);
}
function ValidForm()
{
    btnValide.disabled=true;
    if(Object.values(validation).indexOf(false)==-1)
    {
        btnValide.disabled=false;
    }
}

