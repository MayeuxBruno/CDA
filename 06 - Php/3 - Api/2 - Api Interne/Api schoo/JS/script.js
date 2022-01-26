const requ = new XMLHttpRequest();

var select=document.getElementById("selectCours");
var contenu=document.getElementById("contenu");

select.addEventListener("change",changeCours);

/************* API Mail **************/
requ.onreadystatechange = function (event) {
    // XMLHttpRequest.DONE === 4
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("Réponse reçue: %s", this.responseText);
            reponse = JSON.parse(this.responseText);
            contenu.innerHTML="";
            for (let i=0; i<reponse.length;i++)
            {
                nom = document.createElement("div");
                nom.setAttribute("class","caseListe");
                contenu.appendChild(nom);
                grade = document.createElement("div");
                grade.setAttribute("class","caseListe");
                contenu.appendChild(grade);
                vide1 = document.createElement("div");
                vide1.setAttribute("class","caseListe");
                contenu.appendChild(vide1);
                vide2 = document.createElement("div");
                vide2.setAttribute("class","caseListe");
                contenu.appendChild(vide2);
                vide3 = document.createElement("div");
                vide3.setAttribute("class","caseListe");
                contenu.appendChild(vide3);

                nom.innerHTML=reponse[i].Name;
                grade.innerHTML=reponse[i].GradeName;
            }
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

function changeCours(){
    if(select.value!="default")
    {
        requ.open('POST', 'index.php?page=ListeStudentsAPI', true);
        requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        var id=select.value;
        var args="idCours="+id;
        requ.send(args);
    }
}