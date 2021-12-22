var sousMenuOuvert; // stocke l'ement de sousMenuOuvert
var sousMenuItemActive // stocke le sous menu actif
var menuHamburger=false; //Indique l'état du menu Hamburger false->replier true->déplier

var menuItems=document.getElementsByClassName("menuItem")
// on gère le survol et le clic des menus
var listeMenus = document.getElementsByClassName("menu");
for (let i = 0; i < listeMenus.length; i++) {
    listeMenus[i].addEventListener("click", clickMenu);
    listeMenus[i].addEventListener("mouseover", clickMenu);
    /* on ferme les menus quand on quitte un menu */
    listeMenus[i].addEventListener("mouseleave", fermeMenu);
}

// on gère le survol et le clic des sous menus
var listeSousMenus = document.querySelectorAll("nav .sousMenuItem");
listeSousMenus.forEach(element => {
    element.addEventListener("click", clickSousMenu);
    element.addEventListener("mouseover", clickSousMenu);
});


function fermeMenu(event) {
    if (sousMenuItemActive != undefined) {
        sousMenuItemActive.classList.remove("sousMenuItemActive");
        sousMenuItemActive = undefined;
    }
    if (sousMenuOuvert != undefined && sousMenuOuvert != event.target.parentNode.parentNode) {
        sousMenuOuvert.previousElementSibling.classList.remove("menuItemActive");
        sousMenuOuvert.style.display = "none";
        sousMenuOuvert = undefined;
    }
}

/**
 * méthode qui gère le changement d'affichage des menus lors du survol ou du clic
 * @param {*} event  evenement qui a déclenché l'action
 */
function clickMenu(event) {
    // si on vient d'un menuItem
    if (event.target.classList.contains("menuItem")) {
        var menuClique = event.target.parentNode;
        var sousMenu = menuClique.querySelector(".sousMenu");
        /* Changer la couleur du menu sélectionné */
        event.target.classList.add("menuItemActive")
    } else { // on a cliqué sur un sousMenuItem
        sousMenu = event.target.parentNode.parentNode;
    }

    /* Fermer le sousMenu ouvert s'il est différent du menu à ouvrir*/
    if (sousMenuOuvert != undefined && sousMenuOuvert != sousMenu) {
        sousMenuOuvert.style.display = "none";
        // on enleve la couleur du menuItem
        sousMenuOuvert.previousElementSibling.classList.remove("menuItemActive");

    }
    /* Ouvrir le sous menu*/
    sousMenu.style.display = "flex";
    sousMenuOuvert = sousMenu;
}

/**
 * Gestion des sousMenus lors du clic ou du survol
 * @param {*} event 
 */
function clickSousMenu(event) {
    if (sousMenuItemActive != undefined) {
        // on enleve la couleur du menuItem
        sousMenuItemActive.classList.remove("sousMenuItemActive");
    }
    /* Changer la couleur du sous menu sélectionné*/
    event.target.classList.add("sousMenuItemActive")
    sousMenuItemActive = event.target;
}

/*********** Gestion du menu Hamburger  **************/
//on récupère le titremenu
var titreMenu=document.querySelector(".titreNav");
// on déplie le menu en cliquant sur le logo hamburger
titreMenu.addEventListener("click",ActionHamburger);
// onrécupère la nav
var nav = document.querySelector("nav");  


function ActionHamburger(event)
{
    if(menuHamburger==false)
    {
        for (let i = 0; i < menuItems.length; i++) 
        {
             menuItems[i].classList.add("afficheMenuItem");
        }
        menuHamburger=true;
        nav.addEventListener("mouseleave",ActionHamburger);
    }
    else
    {
        for (let i = 0; i < menuItems.length; i++) 
        {
            menuItems[i].classList.remove("afficheMenuItem");
        }
        menuHamburger=false;
        nav.removeEventListener("mouseleave",ActionHamburger);
    }
}