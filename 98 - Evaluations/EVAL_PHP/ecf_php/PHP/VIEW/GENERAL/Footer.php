
<footer class="colonne">
   <div class="espace"></div>
   <div>
      <div class="colonne center txtAlign">Services et Garanties<br><span class="txtPetit">Garanties et assurances<br>Mon espace Client<br>Nos Magasins</span></div>
      <div class="colonne center txtAlign">Livraison et paiement<br><span class="txtPetit">Les modes et frais de livraison<br>Livraison en europe<br>Livraisons à l'international</span></div>
      <div class="colonne center txtAlign">Contactez nous<br><span class="txtPetit">Contact Service Client<br>Contact publicité<br>Recrutement</span></div>
   </div>
   <div class="espace"></div>
</footer>
<?php
 if (substr($page[1],0,4)=="Form"){
    echo ' <script src="./JS/VerifForm.js"></script>';
 }
 echo ' <script src="./JS/script.js"></script>';
echo '</body>
</html>';