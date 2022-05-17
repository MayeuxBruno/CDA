const requ = new XMLHttpRequest();

requ.open('POST', 'index.php?page=ListeMailAPI', true);
requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
requ.send();

/************* API Mail **************/
requ.onreadystatechange = function (event) {
    // XMLHttpRequest.DONE === 4
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("Réponse reçue: %s", this.responseText);
            reponse = JSON.parse(this.responseText);
            
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};
