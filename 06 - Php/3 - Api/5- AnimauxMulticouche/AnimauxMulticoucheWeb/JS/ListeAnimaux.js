const requ = new XMLHttpRequest();
var contenu=document.getElementById("contenu");

/************* API Liste Animaux **************/

requ.open('GET', 'https://localhost:44321/api/Animal', true);
requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
requ.send();

requ.onreadystatechange = function (event) {
    // XMLHttpRequest.DONE === 4
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            //console.log("Réponse reçue: %s", this.responseText);
            reponse = JSON.parse(this.responseText);
            AfficheListe(reponse);
            
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

/************ Affichage de la liste des animaux ***********/
function AfficheListe(liste)
{
    for(i=0;i<liste.length;i++)
    {
        nom=document.createElement("div");
        nom.setAttribute("class","caseListe");
        contenu.appendChild(nom);
        habitat=document.createElement("div");
        habitat.setAttribute("class","caseListe");
        contenu.appendChild(habitat);
        regime=document.createElement("div");
        regime.setAttribute("class","caseListe");
        contenu.appendChild(regime);

        editer=document.createElement("div");
        editer.setAttribute("class","caseListe");
        liens=document.createElement("a");
        liens.href="index.php?page=FormAnimaux&mode=Afficher&id="+liste[i].idAnimal;
        icone=document.createElement("i");
        icone.setAttribute("class","fas fa-file-contract");
        liens.appendChild(icone);
        editer.appendChild(liens);
        contenu.appendChild(editer);

        modifier=document.createElement("div");
        modifier.setAttribute("class","caseListe");
        liens=document.createElement("a");
        liens.href="index.php?page=FormAnimaux&mode=Modifier&id="+liste[i].idAnimal;
        icone=document.createElement("i");
        icone.setAttribute("class","fas fa-pen");
        liens.appendChild(icone);
        modifier.appendChild(liens);
        contenu.appendChild(modifier);
        
        suprimmer=document.createElement("div");
        suprimmer.setAttribute("class","caseListe");
        liens=document.createElement("a");
        liens.href="index.php?page=FormAnimaux&mode=Supprimer&id="+liste[i].idAnimal;
        icone=document.createElement("i");
        icone.setAttribute("class","fas fa-trash-alt");
        liens.appendChild(icone);
        suprimmer.appendChild(liens);
        contenu.appendChild(suprimmer);
        
        nom.innerHTML=liste[i].nomAnimal;
        habitat.innerHTML=liste[i].sonHabitat.libelleHabitat;
        regime.innerHTML=liste[i].sonRegimeAlimentaire.libelleRegimeAlimentaire;
    }
    divmere=document.createElement("div");
    divmere.setAttribute("class","caseListe grid-columns-span-6");
    
    vide=document.createElement("div");
    divmere.appendChild(vide);

    liens=document.createElement("a");
    liens.href="index.php?page=Accueil";

    bouton=document.createElement("button");
    icone=document.createElement("i");
    icone.setAttribute("class","fas fa-sign-out-alt fa-rotate-180");
    bouton.appendChild(icone);

    liens.appendChild(bouton);
    divmere.appendChild(liens);
    vide=document.createElement("div");
    divmere.appendChild(vide);

    contenu.appendChild(divmere);
}


