var lesReunions=document.getElementsByClassName("reunionagenda");
console.log(lesReunions);
for (let i=0;i<lesReunions.length;i++)
{
    let etatreunion=lesReunions[i].querySelector(".reunion").getAttribute("etat");
    lesReunions[i].classList.remove("aVenir","enCours","terminee","annulee","reportee");
    switch(etatreunion)
    {
        case "1" :
            lesReunions[i].classList.add("aVenir");
            break;
        case "2" :
            lesReunions[i].classList.add("enCours");
            break;
        case "3":
            lesReunions[i].classList.add("terminee");
            break;
        case "4":
            lesReunions[i].classList.add("reportee");
            break;
        case "5":
            lesReunions[i].classList.add("annulee");
            break;
    }
}


