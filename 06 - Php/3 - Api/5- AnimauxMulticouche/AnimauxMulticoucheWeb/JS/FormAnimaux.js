const requ = new XMLHttpRequest();
const requ1 = new XMLHttpRequest();
const requ2 = new XMLHttpRequest();
const requ4 = new XMLHttpRequest();
var nomAnimal=document.getElementById("nomAnimal");
var selectRegime=document.getElementById("SelectRegime");
var selectHabitat=document.getElementById("SelectHabitat");
var url=document.location.href;
var mode=getParamByName('mode',url);
var idAnimal =getParamByName('id',url);
var animalSelect;

/********* Fonction qui permet de récupérer le $_GET *********/
function getParamByName(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}

/********** Recupère l'annimal dont l'id est passe en parametre ********/
if (mode!="Ajouter")
{
    var stringreq='https://localhost:44321/api/Animal/'.concat(idAnimal);
    requ.open('GET',stringreq, true);
    requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    requ.send();

    requ.onreadystatechange = function (event) {
        // XMLHttpRequest.DONE === 4
        if (this.readyState === XMLHttpRequest.DONE) {
            if (this.status === 200) {
                //console.log("Réponse reçue: %s", this.responseText);
                animalSelect = JSON.parse(this.responseText);
                nomAnimal.value=animalSelect.nomAnimal;
                recupRegimes();
                recupHabitats();
                
            } else {
                console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
            }
        }
    };
}
else{
    recupRegimes(); 
    recupHabitats();
}

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
                console.log(animalSelect);
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
    combo=document.createElement("select");
    combo.setAttribute("name","IdRegimeAlimentaire");
    combo.setAttribute("id","toto");
    for (i=0;i<options.length;i++)
    {
        option=document.createElement("option");
        option.value=options[i].idRegimeAlimentaire;
        if (mode!="Ajouter")
        {
            if(options[i].idRegimeAlimentaire==animalSelect.idRegimeAlimentaire)
            {
                option.selected=true;
            }
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
    combo.setAttribute("id","tata");
    for (i=0;i<options.length;i++)
    {
        option=document.createElement("option");
        option.value=options[i].idHabitat;
        if (mode!="Ajouter")
        {    
            if(options[i].idHabitat==animalSelect.idHabitat)
            {
                option.selected=true;
            }
        }
        combo.appendChild(option);
        option.innerHTML=options[i].libelleHabitat;
    }
    divMere.appendChild(combo);
}


/********** Gestion des actions *********/
btnSubmit=document.getElementById("submit");

btnSubmit.addEventListener("click",actionForm);

function actionForm()
{
    var regime=document.getElementById("toto").value;
    var habitat=document.getElementById("tata").value;
    switch(mode)
{
    case "Ajouter":
        requ4.open('POST', 'https://localhost:44321/api/Animal', true);
        requ4.setRequestHeader("Content-Type", "application/json");
        var args={
            "nomAnimal":nomAnimal.value,
            "idRegimeAlimentaire": parseInt(regime),
            "idHabitat": parseInt(habitat)
         }
        requ4.send(JSON.stringify(args));
            break;
    case "Modifier":
        requ4.open('PUT', 'https://localhost:44321/api/Animal/'.concat(idAnimal), true);
        requ4.setRequestHeader("Content-Type", "application/json");
        var args={
            "idAnimal":parseInt(idAnimal),
            "nomAnimal":nomAnimal.value,
            "idRegimeAlimentaire": parseInt(regime),
            "idHabitat": parseInt(habitat)
         }
         requ4.send(JSON.stringify(args));
            break;
    case "Supprimer":
        requ4.open('DELETE', 'https://localhost:44321/api/Animal/'.concat(idAnimal), true);
        requ4.setRequestHeader("Content-Type",  "application/x-www-form-urlencoded");
        requ4.send();
            break;
}
}
requ4.onreadystatechange = function(event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("Réponse reçue: %s", this.responseText);;
            console.log(this.responseText);
            reponse=JSON.parse(this.responseText);
            
            
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

