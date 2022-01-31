var inputPhoto=document.getElementById("inputPhoto");
var zonePhoto=document.getElementById("photoForm");

inputPhoto.addEventListener("change",chargePhoto);

function chargePhoto()
{
    var path=inputPhoto.value;
    zonePhoto.setAttribute("src", path);
}

