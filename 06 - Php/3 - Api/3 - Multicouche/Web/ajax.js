var contenu = document.querySelector(".contenu");
const requ = new XMLHttpRequest();
requ.open('POST', 'https://localhost:44398/api/Departements', true);
//requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
requ.setRequestHeader("Content-Type", "application/json");
var args = {
    "idDepartement": 0,
    "libelle": "test"
  }
requ.send(JSON.stringify(args));
//requ.send();

requ.onreadystatechange = function(event) {
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
