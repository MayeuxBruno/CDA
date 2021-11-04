--Question 1 --
SELECT * FROM clients;
SELECT NomClient, VilleClient FROM clients;

-- Question 2 --
SELECT NomProduit FROM produits WHERE CouleurProduit="Rouge" AND PoidsProduit > 2000;

-- Question 3 --
SELECT DISTINCT NomRepres FROM representants as r
INNER JOIN ventes as v ON v.idRepres=r.idRepres
WHERE Quantite>1;

-- Question 4 --
SELECT DISTINCT NomClient FROM clients as c
INNER JOIN ventes as v ON v.IdClient=c.IdClient
WHERE VilleClient="Paris" AND Quantite>180;

-- Question 5 --
SELECT  NomRepres, NomClient, NomProduit, Quantite FROM clients as c 
INNER JOIN ventes as v ON v.IdClient=c.IdClient
INNER JOIN produits as p ON p.IdProduit=v.IdProduit
INNER JOIN representants as r ON r.IdRepres=v.IdRepres
WHERE CouleurProduit="Rouge" AND Quantite>100;

-- Question 6 --
SELECT NomProduit, SUM(Quantite) FROM produits as p
LEFT JOIN ventes as v ON p.IdProduit=v.IdProduit
GROUP BY NomProduit; 

-- Question 7 --
SELECT NomClient, SUM(Quantite) as Total FROM clients as c
LEFT JOIN ventes as v ON c.IdClient = v.IdClient
GROUP BY NomClient
HAVING Total > (SELECT FLOOR(AVG(Quantite)) FROM ventes);

-- Question 8 --
CREATE VIEW clientsVentes
AS 
SELECT 
c.NomClient,
c.VilleClient,
p.NomProduit,
p.CouleurProduit,
p.PoidsProduit,
v.Quantite,
r.NomRepres,
r.VilleRepres
FROM clients as c
LEFT JOIN ventes as v ON c.IdClient = v.IdClient
LEFT JOIN produits as p ON v.IdProduit=p.IdProduit
LEFT JOIN representants as r ON v.IdRepres=r.IdRepres;