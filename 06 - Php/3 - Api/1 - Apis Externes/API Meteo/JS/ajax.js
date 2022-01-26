// Utilisation de l'Ajax pour appeler l'API et récuperer les enregistrements
var contenu = document.getElementById("station");
var enregs; // contient la reponse de l'API
var input=document.getElementById("ville");
var bouton=document.getElementById("bouton");
// on définit une requete
const req = new XMLHttpRequest();

bouton.addEventListener("click",rechercheMeteo);

//on envoi la requête


//on vérifie les changements d'états de la requête
req.onreadystatechange = function (event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            // la requete a abouti et a fournit une reponse
            //on décode la réponse, pour obtenir un objet
            reponse = JSON.parse(this.responseText);
            console.log(this.responseText);
            console.log(reponse);
            AfficheMeteo(reponse);

            
            console.log("Réponse reçue: %s", this.responseText);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

function rechercheMeteo()
{
    var ville=input.value;
    req.open('GET', 'https://api.openweathermap.org/data/2.5/weather?q=' + ville + '&appid=f3a403a44666a424dd3ca7da175aabce&lang=fr&units=metric', true);
    req.send(null);
}

function AfficheMeteo(tabMeteo)
{
    document.getElementById("tempMax").innerHTML=tabMeteo.main.temp_max+"°C";
    document.getElementById("temp").innerHTML=tabMeteo.main.temp+"°C";
    document.getElementById("pression").innerHTML=tabMeteo.main.pressure+" hPa";
    document.getElementById("tempMin").innerHTML=tabMeteo.main.temp_min+"°C";
    document.getElementById("humidite").innerHTML=tabMeteo.main.humidity+" %";
    document.getElementById("img").src="Images/"+reponse.weather[0].icon+".png";
    document.getElementById("leve").innerHTML=RecupHeure(tabMeteo.sys.sunrise);
    document.getElementById("couche").innerHTML=RecupHeure(tabMeteo.sys.sunset);
    document.getElementById("vent").innerHTML=tabMeteo.wind.speed+" KM/H";
}

function RecupHeure(date)
{
    let timeTemp=new Date(date*1000)
    let heures=timeTemp.getHours();
    if(heures<10){heures="0"+heures}
    let minutes=timeTemp.getMinutes();
    if(minutes<10){minutes="0"+minutes}
    affichage=heures+" h "+minutes+" mns";
    console.log(affichage);
    return affichage;
}



