-- 1 --
SELECT ville_nom from villes_france WHERE LENGTH(ville_nom)>=40;

-- 2 --
SELECT departement_nom from departements WHERE departement_code LIKE "97%";

-- 3 --
SELECT departement_nom FROM departements WHERE departement_regionID = 7;

-- 4 --
SELECT ville_nom as "Ville", departement_nom as "Département", ville_population_2012 as "Population 2012" 
FROM villes_france as v 
INNER JOIN departements as d ON v.ville_departement=d.departement_code 
ORDER BY ville_population_2012 DESC;

-- 5 --
SELECT d.departement_nom as "Département", d.departement_code as "Code Département",(SELECT COUNT(*)  FROM villes_france WHERE ville_departement= d.departement_code ) as NbVilles
FROM departements as d
ORDER BY NbVilles DESC;

-- 6 -- 
SELECT departement_nom as "Nom Département", (SELECT SUM(ville_surface) as Surface FROM villes_france WHERE ville_departement=departement_code) as Superficie
FROM departements 
ORDER BY Superficie DESC;

-- 7 --
SELECT COUNT(*) as "Nb Villes" FROM villes_france WHERE ville_nom LIKE "Saint%";

-- 8 -- 
SELECT ville_nom as Ville, count(ville_nom) as NbExistant 
FROM villes_france
GROUP BY ville_nom
HAVING  NbExistant>1
ORDER BY NbExistant DESC;

-- 9 -- 
SELECT ville_nom as Ville, ville_surface,AVG(ville_surface)
FROM villes_france
GROUP BY ville_nom
HAVING ville_surface > AVG(ville_surface);

-- 10 -- 
SELECT departement_nom , (SELECT SUM(ville_population_2012) FROM villes_france WHERE ville_departement=departement_code ) as "Population"
FROM departements
WHERE (SELECT SUM(ville_population_2012) FROM villes_france WHERE ville_departement=departement_code ) > 1500000;

-- 11 --
UPDATE villes_france SET ville_nom = replace(ville_nom, "-", " ")
WHERE ville_nom LIKE "SAINT%";

-- 12 -- 
SELECT departement_nom as "Nom Département", (SELECT SUM(ville_surface) as Surface FROM villes_france WHERE ville_departement = departement_code) as Superficie
FROM departements 
ORDER BY Superficie
LIMIT 50;

-- 13 --
ALTER TABLE departements
ADD region_nbDepartement INT;

--14 -- 
DELIMITER |
CREATE PROCEDURE MajRegion
BEGIN
    UPDATE region_nom 
    SET region_nom = " Paris";
END
|

-- 15 --
CREATE VIEW VillesDepRegions
AS 
SELECT 
      r.region_id,
      r.region_nom,
      d.departement_code,
      d.departement_nom,
      d.departement_nom_uppercase,
      d.departement_slug,
      d.departement_nom_soundex,
      d.departement_regionId,
      d.region_nbDepartement,
      v.ville_departement,
      v.ville_slug,
      v.ville_nom,
      v.ville_nom_simple,
      v.ville_nom_reel,
      v.ville_nom_soundex,
      v.ville_nom_metaphone,
      v.ville_code_postal,
      v.ville_commune,
      v.ville_code_commune,
      v.ville_arrondissement,
      v.ville_canton,
      v.ville_amdi,
      v.ville_population_2010,
      v.ville_population_1999,
      v.ville_population_2012,
      v.ville_densite_2010,
      v.ville_surface,
      v.ville_longitude_deg,
      v.ville_latitude_deg,
      v.ville_longitude_grd,
      v.ville_latitude_grd,
      v.ville_longitude_dms,
      v.ville_latitude_dms,
      v.ville_zmin,
      v.ville_zmax
FROM villes_france as v
INNER JOIN departements as d ON v.ville_departement=d.departement_code
INNER JOIN regions as r ON  d.departement_regionId=r.region_id;

       

