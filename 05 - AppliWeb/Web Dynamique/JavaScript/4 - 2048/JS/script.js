lesCases = document.getElementsByClassName("cell");
InitPlateau();
prochaineCase(1,1);

/* Fonction qui place Aléatoirement les 2 premiers chiffres 2 sur le plateau*/
function InitPlateau()
{
    for (let i=0;i<2;i++)
    {
        placeDeux();
    }
}

/* Fonction qui place un 2 Aléatoirement sur le plateau */
function placeDeux()
{
    let casevide=false;
    while(casevide==false)
    {
        let x = Math.floor(Math.random() * 4) + 1;
        let y = Math.floor(Math.random() * 4) + 1;
        casevide=IsVide(x,y)
        if(casevide==true)
        {
            let string='[x=\"'+x+'\"][y=\"'+y+'\"]';
            let b = document.querySelector(string);
            b.innerHTML="2";
            b.classList.add("deux");
            b.classList.add("occupe");
            b.classList.remove("vide");
        }
    }

}

/* Fonction qui test si une case est vide */
function IsVide(x,y)
{
    let vide=false;
    let casesVides = document.querySelectorAll(".vide");
    let string;
    casesVides.forEach(element => {
        if (element.getAttribute("x")==x && element.getAttribute("y")==y)
        {
            vide=true;
        }
    });
   return vide;
}

/* Fonction qui gere le deplacement */
 window.addEventListener("keydown",function(event){
     let casesOccupee=document.querySelectorAll(".occupe");
     casesOccupee.forEach(element => {
         let x = prochaineCase(element.getAttribute("x"),element.getAttribute("y"));
         let string='[x=\"'+x+'\"][y=\"'+1+'\"]';
         let b = document.querySelector(string);
         b.innerHTML="120";
     });
     console.log(casesOccupee);

 });

function prochaineCase(x,y)
{
    let nextcase=true;
    let xx=x;
    while (xx<4 && nextcase==true)
    {
        xx++;
        nextcase=IsVide(xx,y);
        if(!nextcase)xx--;
    }
    console.log(xx);
}

