var tabmenu = document.getElementsByClassName("menu");

for(i=0;i<tabmenu.length;i++)
{
    tabmenu[i].addEventListener('click',AffSousMenu);
}

function AffSousMenu (e)
{
    var listesousmenu=document.getElementsByClassName("sousmenu");
    for (let i=0;i<listesousmenu.length;i++)
    {
        listesousmenu[i].style.display="none";
    }
    var sousmenu=e.target.parentNode.getElementsByClassName("sousmenu")[0];
    if (sousmenu!=null)
    {
        sousmenu.style.display="block";
    }
}
