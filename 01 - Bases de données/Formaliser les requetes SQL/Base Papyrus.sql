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
    ORDER BY "Département" DESC,nomfou;

-- 6. Quelles sont les commandes passées au mois de mars et avril ?
    SELECT numcom AS "Num commande" FROM entcom WHERE MONTH(datcom) IN ("04","05") ;

-- 7. Quelles sont les commandes du jour qui ont des observations particulières ?
-- (Affichage numéro de commande, date de commande)
    SELECT numcom AS "Num commande", 
           DATE(datcom) AS "Date de Commande" 
    FROM entcom 
    WHERE DATE(datcom) = DATE(NOW()) 
         AND obscom<>"";

-- 8. Lister le total de chaque commande par total décroissant
-- (Affichage numéro de commande et total)
    SELECT numcom , SUM(qtecde*priuni) as total  FROM ligcom GROUP BY numcom ORDER BY total DESC

-- 9. Lister les commandes dont le total est supérieur à 10 000€ ; on exclura dans le
-- calcul du total les articles commandés en quantité supérieure ou égale à 1000.
-- (Affichage numéro de commande et total)
    SELECT x.Commande, 
           SUM(x.Prix) as Total 
    FROM (SELECT numcom as "Commande", qtecde*priuni as Prix FROM ligcom WHERE qtecde<1000 ) as x 
    GROUP BY Commande 
    HAVING Total > 10000;

-- 10.Lister les commandes par nom fournisseur
-- (Afficher le nom du fournisseur, le numéro de commande et la date)
    SELECT nomfou as Fournisseur ,
           numcom as "N° Commande",
           DATE(datcom) as "Date de commande" 
           FROM fournis as f INNER JOIN entcom as e ON e.numfou=f.numfou
           ORDER BY Fournisseur;

-- 11.Sortir les produits des commandes ayant le mot "urgent' en observation?
-- (Afficher le numéro de commande, le nom du fournisseur, le libellé du produit et
-- le sous total = quantité commandée * Prix unitaire
    SELECT entcom.numcom, 
           fournis.nomfou, 
           produit.libart, 
           entcom.obscom, 
           (qtecde * priuni) AS"sous total" 
    FROM entcom 
    INNER JOIN ligcom ON entcom.numcom = ligcom.numcom 
    INNER JOIN fournis ON entcom.numfou = fournis.numfou 
    INNER JOIN produit ON ligcom.codart = produit.codart 
    WHERE entcom.obscom LIKE "%urgent%"
   
-- 12.Coder de 2 manières différentes la requête suivante :
-- Lister le nom des fournisseurs susceptibles de livrer au moins un article
    SELECT f.nomfou
    FROM fournis as f
    INNER JOIN vente as v ON v.numfou=f.numfou 
    INNER JOIN produit as p ON p.codart=v.codart
    GROUP BY f.nomfou HAVING p.stkphy>1;

-- 13.Coder de 2 manières différentes la requête suivante
-- Lister les commandes (Numéro et date) dont le fournisseur est celui de la 
-- commande 70210 :
   SELECT numcom, DATE(datcom) 
   FROM entcom 
   WHERE numfou=(SELECT numfou FROM entcom WHERE numcom="70210") AND numcom <> "70210"; 

-- 14.Dans les articles susceptibles d’être vendus, lister les articles moins chers (basés 
-- sur Prix1) que le moins cher des rubans (article dont le premier caractère 
-- commence par R). On affichera le libellé de l’article et prix1
    SELECT libart,prix1 
    FROM vente as v 
    INNER JOIN produit as p on p.codart=v.codart
    WHERE prix1< (SELECT MIN(prix1) 
                  FROM vente as v 
                  WHERE codart LIKE "r%");

-- 15.Editer la liste des fournisseurs susceptibles de livrer les produits dont le stock est 
-- inférieur ou égal à 150 % du stock d'alerte. La liste est triée par produit puis 
-- fournisseur

    SELECT numfou,codart FROM vente 
    INNER JOIN produit ON vente.codart=produit.codart
    INNER JOIN fournis ON vente.numfou=fournis.numfou  
    WHERE stkphy<=1.5*stkale
    ORDER BY codart,numfou

-- 16.Éditer la liste des fournisseurs susceptibles de livrer les produit dont le stock est 
-- inférieur ou égal à 150 % du stock d'alerte et un délai de livraison d'au plus 30 
-- jours. La liste est triée par fournisseur puis produit
    SELECT f.nomfou as "Fournisseur",
           p.libart as "Article" 
    FROM fournis as f
    INNER JOIN entcom as e ON e.numfou=f.numfou 
    INNER JOIN ligcom as l ON l.numcom=e.numcom
    INNER JOIN produit as p ON l.codart=p.codart 
    INNER JOIN vente as v ON p.codart=v.codart
    WHERE p.stkphy < p.stkale*1.5  AND v.delliv <= 30
    ORDER BY p.libart,f.nomfou

   
-- 17.Avec le même type de sélection que ci-dessus, sortir un total des stocks par 
-- fournisseur trié par total décroissant
    SELECT nomfou, sum(stkphy) as stockTotal
    FROM fournis
    INNER JOIN vente on fournis.numfou=vente.numfou
    INNER JOIN produit on vente.codart=produit.codart
    GROUP BY fournis.numfou
    ORDER BY stockTotal DESC

-- 18.En fin d'année, sortir la liste des produits dont la quantité réellement commandée 
-- dépasse 90% de la quantité annuelle prévue.
    SELECT p.libart as "Produit", qteann*0.9
    FROM produit as p
    INNER JOIN ligcom as l ON l.codart=p.codart
    GROUP BY p.libart HAVING SUM(l.qtecde) > qteann*0.9;

-- 19.Calculer le chiffre d'affaire par fournisseur pour l'année 93 sachant que les prix 
-- indiqués sont hors taxes et que le taux de TVA est 20%.
    Select f.nomfou,sum((l.priuni*l.qteliv)*1.20) as "Chiffre d'affaire par fournisseur pour l'année 93"
    from entcom as e
    inner join ligcom as l on e.numcom = l.numcom
    INNER JOIN fournis as f ON e.numfou=f.numfou
    where year(e.datcom)="1993"
    group by e.numfou


-- 20.Existe-t-il des lignes de commande non cohérentes avec les produits vendus par 
-- les fournisseurs. ?


--1. Application d'une augmentation de tarif de 4% pour le prix 1, 2% pour le prix2 pour le fournisseur 9180
    UPDATE vente
    SET prix1=prix1+(prix1*0.04),
        prix2=prix2+(prix2*0.02)
    WHERE numfou=9180;

--2. Dans la table vente, mettre à jour le prix2 des articles dont le prix2 est null, en affectant a valeur de prix.
    UPDATE vente
    set prix2=prix1
    WHERE prix2=0;

--3. Mettre à jour le champ obscom en positionnant '*****' pour toutes les commandes dont le fournisseur a un indice de satisfaction <5
    UPDATE entcom 
    SET obscom="*****"
    WHERE numfou IN (SELECT numfou FROM fournis WHERE satisf<5);

--4. Suppression du produit I110
    DELETE CASCADE FROM produit 
    WHERE codart="I110";

--5. Suppression des entête de commande qui n'ont aucune ligne
    DELETE FROM entcom 
    WHERE numcom NOT IN (SELECT DISTINCT numcom FROM ligcom)

-- TEST SUR LES VUES --
CREATE VIEW fournisseurCommandeTable
AS 
SELECT f.nomfou as "Fournisseur",
       f.ruefou as "Adresse", 
       f.posfou as "Code Postal",
       f.vilfou as Ville, 
       e.numcom,
       e.obscom,
       DATE(e.datcom) 
FROM fournisseurs as f
LEFT JOIN entcom as e ON f.numfou=e.numfou;

CREATE VIEW commandesLignes
AS
SELECT e.numcom as "N° Commande",,
       e.obscom as "Observations",
       DATE (e.datcom)as "Date de commande",
       p.libart as "Article",
       l.qtecde as "Quantité",
       l.priuni as "Prix unitaire" 
FROM entcom as e
LEFT JOIN ligcom as l ON l.numcom=e.numcom
INNER JOIN fournis as f ON e.numfou=f.numfou
INNER JOIN produit as p ON l.codart=p.codart;
