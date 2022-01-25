// Utilisation de l'Ajax pour appeler l'API et récuperer les enregistrements
var contenu = document.getElementById("contenu");
var enregs; // contient la reponse de l'API
// on définit une requete
const req = new XMLHttpRequest();

//on envoi la requête
var ville="Lille";
req.open('GET', 'https://api.openweathermap.org/data/2.5/weather?q=' + ville + '&appid=f3a403a44666a424dd3ca7da175aabce&lang=fr&units=metric', true);
req.send(null);

//on vérifie les changements d'états de la requête
req.onreadystatechange = function (event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            // la requete a abouti et a fournit une reponse
            //on décode la réponse, pour obtenir un objet
            reponse = JSON.parse(this.responseText);
            console.log(this.responseText);
            console.log(reponse);
            temp=document.getElementById("temperature");
            console.log(temp);
            temp.innerHTML=reponse.main.temp;
            // for (let i = 0; i < enregs.length; i++) {
            //     // on crée la ligne et les div internes
            //     ligne = document.createElement("div");
            //     ligne.setAttribute("class", "ligne");
            //     ligne.id = i;
            //     ville = document.createElement("div");
            //     ville.setAttribute("class", "commune");
            //     ligne.appendChild(ville);
            //     libelle = document.createElement("div");
            //     libelle.setAttribute("class", "nom");
            //     ligne.appendChild(libelle);
            //     etat = document.createElement("div");
            //     etat.setAttribute("class", "etat");
            //     ligne.appendChild(etat);
            //     contenu.appendChild(ligne);
            //     espace = document.createElement("div");
            //     espace.setAttribute("class","espaceHorizon");
            //     contenu.appendChild(espace);
            //     //on met à jour le contenu
            //     ville.innerHTML = enregs[i].fields.commune;
            //     libelle.innerHTML = enregs[i].fields.nom;
            //     etat.innerHTML = enregs[i].fields.etat;

            //     // on ajoute un evenement sur ligne pour afficher le detail
            //     ligne.addEventListener("click", afficheDetail);
            // }
            console.log("Réponse reçue: %s", this.responseText);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};


