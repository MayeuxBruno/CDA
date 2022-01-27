const requ = new XMLHttpRequest();
const requ1 = new XMLHttpRequest();
const requ2 = new XMLHttpRequest();
var contenu=document.getElementById("contenu");
var idAnimal=parseInt(document.getElementById("idAnimal").value,8);
var selectRegime=document.getElementById("SelectRegime");
var selectHabitat=document.getElementById("SelectHabitat");
var animalSelect;
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
            //remplirForm(reponse);
            
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

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

requ2.open('GET', 'https://localhost:44321/api/Habitat', true);
requ2.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
requ2.send();

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

function creerComboBoxRegime(options,divMere)
{
   console.log(animalSelect.sonRegimeAlimentaire.idRegimeAlimentaire);
    combo=document.createElement("select");
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
    for (i=0;i<options.length;i++)
    {
        option=document.createElement("option");
        option.value=options[i].idHabitat;
        combo.appendChild(option);
        option.innerHTML=options[i].libelleHabitat;
    }
    divMere.appendChild(combo);
}
