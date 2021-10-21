--A.	Requêtes simples
--1.	Afficher les noms de département
    SELECT nomdep FROM DEPARTEMENT;
--2.	Afficher les numéros et noms de département
    SELECT nodep,nomdep FROM DEPARTEMENT;
--3.	Afficher toutes les propriétés des employés
    SELECT nomemp,fonction,datemb,sala,comm FROM EMPLOYE;
--4.	Afficher les fonctions des employés
    SELECT fonction FROM EMPLOYE;
--5.	Afficher les fonctions des employés sans double
    SELECT DISTINCT fonction FROM EMPLOYE;
--6.	Afficher les noms des employés avec leur date d'embauche, ainsi que la date d'embauche augmentée d'une journée
    SELECT nomemp,datemb,DATEADD(day,1,datemb) FROM EMPLOYE;
--7.	Afficher les noms des employés suivis d'un espace, suivi de leur fonction
    SELECT CONCAT(nomemp," ",fonction) FROM EMPLOYE;

    
--B.	Requêtes avec clause “where”
--
--1.	Donner la liste des numéros et noms des employés du département 30
    SELECT noemp,nomemp FROM EMPLOYE WHERE nodep=30;

--2.	Donner la liste des numéros et noms des ouvriers ainsi que leur numéro de département
    SELECT noemp, nomemp, nodep FROM EMPLOYE

--3.	Donner les noms et numéros des départements dont le numéro est supérieur ou égal à 30
    SELECT nodep, nomdep FROM DEPARTEMENT WHERE nodep >= 30;

--4.	Donner les noms, salaires et commissions des employés dont la commission excède le salaire
    SELECT nomemp, sala,comm FROM EMPLOYE WHERE comm > sala;

--5.	Donner les noms et salaires des vendeurs du département 30 dont le salaire est supérieur à 1500 €
    SELECT nomemp, sala FROM EMPLOYE WHERE LOWER(fonction)="vendeur" AND nodep=30 AND sala > 1500;

--6.	Donner la liste des noms, fonctions et salaires des directeurs et des présidents
    SELECT nomemp, fonction, sala FROM EMPLOYE WHERE LOWER(fonction)="directeur" OR LOWER(fonction)="président";

--7.	Donner la liste des noms, fonctions et salaires des directeurs et des employés qui ont un salaire > 2500 €
    SELECT nomemp, fonction, sala FROM EMPLOYE WHERE LOWER(fonction)="directeur" OR sala>2500;

--8.	Donner la liste des noms, numéros de département des directeurs et des ouvriers du département 10
    SELECT nomemp, noemp, nodep FROM EMPLOYE WHERE (LOWER(fonction)="directeur" OR LOWER(fonction)="ouvrier") AND nodep=10; 

--9.	Donner la liste des noms, fonctions et numéros de département des employés du département 10 qui ne sont ni ouvrier ni directeur
    SELECT nomemp, fonction, nodep FROM EMPLOYE WHERE nodep=10 AND LOWER(fonction) NOT IN ("ouvrier","directeur");

--10.	Donner la liste des noms, fonctions et numéros de département des directeurs qui ne sont pas directeur dans le département 30


--11.	Donner la liste des noms, fonctions et salaires des employés qui gagnent entre 1200 € et 1300 €


--12.	Donner la liste des noms, numéros de département et fonctions des employé
--      « ouvrier », « analyste » ou « vendeur »


--13.	Donner les employés qui ne sont pas "vendeur"


--14.	Donner la liste des employés dont la première lettre du nom est un "C"


--15.	Donner la liste des employés qui n'ont pas de commission


--16.	Donner la liste des employés qui ont une commission et qui sont dans le département 30 ou 20


--C.	Requêtes avec clause « order by »

--1.	Donner la liste des salaires, fonctions et noms des employés du département 30, selon l'ordre croissant des salaires
        SELECT sala, fonction, nomemp FROM employe WHERE nodep=30 ORDER BY sala;

--2.	Donner la liste des salaires, fonctions et noms des employés du département 30, selon l'ordre décroissant des salaires
        SELECT sala, fonction, nomemp FROM employe WHERE nodep=30 ORDER BY sala DESC;

--3.	Donner la liste des employés triée selon l'ordre croissant des fonctions et l'ordre décroissant des salaires
        SELECT nomemp,fonction, sala FROM employe ORDER BY fonction, sala DESC; 

--4.	Donner la liste des commissions, salaires et noms triée selon l'ordre croissant des commissions
        SELECT comm, sala, nomemp FROM employe ORDER BY comm;

--5.	Donner la liste des commissions, salaires et noms triée selon l'ordre décroissant des commissions
        SELECT comm, sala, nomemp FROM employe ORDER BY comm DESC;

F.	Requêtes avec clause « group by »

1.	Donner la moyenne des salaires pour chaque département
        SELECT nodep, AVG(sala) FROM employe GROUP BY nodep;

2.	Donner pour chaque département, le salaire annuel moyen des employés qui ne sont ni directeur ni président
        SELECT nodep as "N° Departement", AVG(sala*12) as "Moyenne salaires" FROM employe WHERE fonction NOT IN ("directeur","president") GROUP BY nodep;

3.	Donner pour chaque fonction de chaque département le nombre d''employés et le salaire annuel moyen
        SELECT nodep as "N° Departement", fonction , count(*), AVG(sala) FROM employe GROUP BY nodep,fonction;

4.	Donner la liste des salaires annuels moyens pour les fonctions comportant plus de deux employés
        SELECT AVG(sala*12) as 'moyenne annuelle', fonction FROM employe GROUP BY fonction HAVING COUNT(noemp)>2;

5.	Donner la liste des départements avec au moins deux ouvriers
        SELECT nodep as y FROM employe GROUP BY nodep HAVING COUNT("ouvrier")>=2; 
6.	Donner les salaires moyens des présidents, directeurs et responsables

