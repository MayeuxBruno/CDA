// Utilisation de l'Ajax pour appeler l'API et récuperer les enregistrements
var contenu = document.getElementById("contenu");
var enregs; // contient la reponse de l'API
// on définit une requete
const req = new XMLHttpRequest();

//on envoi la requête
req.open('GET',  'https://ressources.data.sncf.com/api/records/1.0/search/?dataset=objets-trouves-restitution&q=&rows=70&sort=date&facet=date&facet=gc_obo_date_heure_restitution_c&facet=gc_obo_gare_origine_r_name&facet=gc_obo_nature_c&facet=gc_obo_type_c&facet=gc_obo_nom_recordtype_sc_c', true);
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
            enregs = reponse.records;
            console.log(enregs);
            for (let i = 0; i < enregs.length; i++) {
            //     // on crée la ligne et les div internes
            //     // je recupere le template
                var templLigne = document.getElementById("ligne");
            //     // on clone le template pour avoir une nouvelle structure
                nouvElt = templLigne.content.cloneNode(true);
            //     //ajoute à la stucture
                 contenu.appendChild(nouvElt);
                 ligne = contenu.querySelectorAll(".ligne")[i];
                 ligne.id = i;
                 enfant1 = ligne.querySelector(".gare");
                 espace = document.getElementById("espace");
                 contenu.appendChild(espace.content.cloneNode(true));
            //     //on met à jour le contenu
                 enfant1.innerHTML = enregs[i].fields.gc_obo_gare_origine_r_name;
                 enfant1.nextElementSibling.innerHTML = enregs[i].fields.gc_obo_type_c;
                 enfant1.nextElementSibling.nextElementSibling.innerHTML = enregs[i].fields.gc_obo_nature_c;
             }
            console.log("Réponse reçue: %s", this.responseText);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

var actu=document.getElementById("actu");

actu.addEventListener("click",function(){
    req.open('GET', 'https://ressources.data.sncf.com/api/records/1.0/search/?dataset=objets-trouves-restitution&q=&rows=70&sort=date&facet=date&facet=gc_obo_date_heure_restitution_c&facet=gc_obo_gare_origine_r_name&facet=gc_obo_nature_c&facet=gc_obo_type_c&facet=gc_obo_nom_recordtype_sc_c', true);
    req.send(null);
});

