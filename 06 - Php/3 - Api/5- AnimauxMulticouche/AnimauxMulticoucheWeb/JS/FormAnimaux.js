const requ = new XMLHttpRequest();
const requ1 = new XMLHttpRequest();
const requ2 = new XMLHttpRequest();
var contenu=document.getElementById("contenu");
var nomAnimal=document.getElementById("nomAnimal");
var selectRegime=document.getElementById("SelectRegime");
var selectHabitat=document.getElementById("SelectHabitat");
var url=document.location.href;
var mode=getParamByName('mode',url);
var idAnimal =getParamByName('id',url);

/************* API Liste Animaux **************/
var stringreq='https://localhost:44321/api/Animal/'.concat(idAnimal);
requ.open('GET',stringreq, true);
requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
requ.send();

requ.onreadystatechange = function (event) {
    // XMLHttpRequest.DONE === 4
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            //console.log("Réponse reçue: %s", this.responseText);
            console.log(animalSelect = JSON.parse(this.responseText));
            console.log(nomAnimal.value=animalSelect.nomAnimal);
            recupRegimes();
            recupHabitats();
            
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

/****************** API Regimes ************************/
function recupRegimes()
{
    requ1.open('GET', 'https://localhost:44321/api/RegimeAlimentaire', true);
    requ1.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    requ1.send();

    requ1.onreadystatechange = function (event) {
        // XMLHttpRequest.DONE === 4
        if (this.readyState === XMLHttpRequest.DONE) {
            if (this.status === 200) {
                //console.log("Réponse reçue: %s", this.responseText);
                console.log(reponse = JSON.parse(this.responseText));
                creerComboBoxRegime(reponse,selectRegime);
                
            } else {
                console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
            }
        }
};
}

/****************** API Habitats **********************/
function recupHabitats()
{
    requ2.open('GET', 'https://localhost:44321/api/Habitat', true);
    requ2.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    requ2.send();
}

requ2.onreadystatechange = function (event) {
    // XMLHttpRequest.DONE === 4
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            //console.log("Réponse reçue: %s", this.responseText);
            console.log(reponse1 = JSON.parse(this.responseText));
            creerComboBoxHabitat(reponse1,selectHabitat);
            
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

/****************** Creation combo box ******************/

function creerComboBoxRegime(options,divMere)
{
   console.log(animalSelect.sonRegimeAlimentaire.idRegimeAlimentaire);
    combo=document.createElement("select");
    combo.setAttribute("name","IdRegimeAlimentaire");
    for (i=0;i<options.length;i++)
    {
        option=document.createElement("option");
        option.value=options[i].idRegimeAlimentaire;
        if(options[i].idRegimeAlimentaire==animalSelect.sonRegimeAlimentaire.idRegimeAlimentaire)
        {
            option.selected=true;
        }
        combo.appendChild(option);
        option.innerHTML=options[i].libelleRegimeAlimentaire;
    }
    divMere.appendChild(combo);
}

function creerComboBoxHabitat(options,divMere)
{
    combo=document.createElement("select");
    combo.setAttribute("name","IdHabitat");
    for (i=0;i<options.length;i++)
    {
        option=document.createElement("option");
        option.value=options[i].idHabitat;
        if(options[i].idHabitat==animalSelect.sonHabitat.idHabitat)
        {
            option.selected=true;
        }
        combo.appendChild(option);
        option.innerHTML=options[i].libelleHabitat;
    }
    divMere.appendChild(combo);
}

function getParamByName(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}

/********** Gestion des actions *********/
btnSubmit=document.getElementById("submit");

btnSubmit.addEventListener("click",actionForm);

function actionForm()
{
    console.log("Action Form");
}
