lesCases = document.getElementsByClassName("cell");
InitPlateau();

/**
 * Fonction qui place Aléatoirement les 2 premiers chiffres 2 sur le plateau
 */
function InitPlateau()
{
    let i=0;
    let premiereCase=0;
    while (i<2)
    {
        let nbCase = Math.floor(Math.random() * 12) + 1;
        if(nbCase!=premiereCase)
        {
            premiereCase=nbCase;
            let string='[nb=\"'+nbCase+'\"]';
            let b = document.querySelector(string);
            b.innerHTML="2";
            b.classList.add("deux");
            i++;
        }
    }
}

document.addEventListener("keydown",function(e){
     console.log(e.code);
});

