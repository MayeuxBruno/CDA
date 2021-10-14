-- 1. Quelles sont les commandes du fournisseur 09120 ?
    SELECT numcom AS "numéro de commande" FROM entcom WHERE numfou="09120";

-- 2. Afficher le code des fournisseurs pour lesquels des commandes ont été passées.
    SELECT DISTINCT numfou FROM entcom;

-- 3. Afficher le nombre de commandes fournisseurs passées, et le nombre de
--    fournisseur concernés.
    SELECT COUNT(numcom) AS "Nb Commandes", COUNT(DISTINCT numfou) AS "Nb FOurnisseurs" FROM entcom;

-- 4. Editer les produits ayant un stock inférieur ou égal au stock d'alerte et dont la
--    quantité annuelle est inférieur est inférieure à 1000
--    (informations à fournir : n° produit, libellé produit, stock, stock actuel d'alerte,
--     quantité annuelle)
    SELECT codart As "N° Produit", 
           libart AS "Libelle Produit", 
           stkphy AS "Stock", 
           stkale AS "Stock Alerte", 
           qteann AS "Quantité Annuelle" 
    FROM produit
    WHERE stkphy <= stkale AND qteann < 1000;

-- 5. Quels sont les fournisseurs situés dans les départements 75 78 92 77 ?
-- L’affichage (département, nom fournisseur) sera effectué par département
-- décroissant, puis par ordre alphabétique
    SELECT nomfou AS "nomFournisseur", 
           SUBSTRING(posfou,1,2) AS "Département" 
    FROM fournis 
    WHERE SUBSTRING(posfou,1,2) IN ("75","78","92","77") 
    ORDER BY posfou DESC,nomfou;

-- 6. Quelles sont les commandes passées au mois de mars et avril ?
    SELECT numcom AS "Num commande", SUBSTRING(datcom,6,2) AS "Mois" FROM entcom WHERE SUBSTRING(datcom,6,2) IN ("04","05") ;

-- 7. Quelles sont les commandes du jour qui ont des observations particulières ?
-- (Affichage numéro de commande, date de commande)
    SELECT numcom AS "Num commande", 
           SUBSTRING(datcom,1,10) AS "Date de Commande" 
    FROM entcom 
    WHERE SUBSTRING(datcom,1,10)=SUBSTRING(NOW(),1,10) 
         AND LENGTH(obscom)!=0;

-- 8. Lister le total de chaque commande par total décroissant
-- (Affichage numéro de commande et total)

-- 9. Lister les commandes dont le total est supérieur à 10 000€ ; on exclura dans le
-- calcul du total les articles commandés en quantité supérieure ou égale à 1000.
-- (Affichage numéro de commande et total)

-- 10.Lister les commandes par nom fournisseur
-- (Afficher le nom du fournisseur, le numéro de commande et la date)

-- 11.Sortir les produits des commandes ayant le mot "urgent' en observation?
-- (Afficher le numéro de commande, le nom du fournisseur, le libellé du produit et
-- le sous total = quantité commandée * Prix unitaire)