DROP DATABASE IF EXISTS ZeroFautes;
CREATE DATABASE ZeroFautes;
USE ZeroFautes;

#-----------------------------------------
#   Table Categories
#-----------------------------------------

CREATE TABLE Categories(
   idCategorie INT AUTO_INCREMENT PRIMARY KEY,
   nomCategorie VARCHAR(50) ,
   descriptionCategorie VARCHAR(100) ,
   idSousCategorie INT 
)ENGINE=InnoDB;

#-----------------------------------------
#   Table Series
#-----------------------------------------

CREATE TABLE Series(
   idSerie INT AUTO_INCREMENT PRIMARY KEY,
   numeroSerie VARCHAR(6) NOT NULL
)ENGINE=InnoDB;

#-----------------------------------------
#   Table Modeles
#-----------------------------------------

CREATE TABLE Modeles(
   idModele INT AUTO_INCREMENT PRIMARY KEY,
   codeModele VARCHAR(50) NOT NULL ,
   nomModele VARCHAR(50) NOT NULL,
   dateMiseMarche DATE NOT NULL
)ENGINE=InnoDB;

#-----------------------------------------
#   Table Produits
#-----------------------------------------

CREATE TABLE Produits(
   idProduit INT AUTO_INCREMENT PRIMARY KEY,
   anneeProduction VARCHAR(50) NOT NULL,
   numProduit VARCHAR(4) NOT NULL ,
   idModele INT NOT NULL,
   idSerie INT NOT NULL
)ENGINE=InnoDB;

#-----------------------------------------
#   Table Fautes
#-----------------------------------------

CREATE TABLE Fautes(
   idFaute INT AUTO_INCREMENT PRIMARY KEY,
   codeFaute VARCHAR(50) NOT NULL ,
   titreFaute VARCHAR(150) NOT NULL ,
   dateDetection DATE NOT NULL,
   commentaireFaute VARCHAR(200) ,
   dateReparation DATE,
   idProduit INT NOT NULL
)ENGINE=InnoDB;

#-----------------------------------------
#   Table Classifications
#-----------------------------------------

CREATE TABLE Classifications(
   idClassification INT AUTO_INCREMENT PRIMARY KEY,
   idCategorie INT NOT NULL,
   idFaute INT NOT NULL
)ENGINE=InnoDB;

ALTER TABLE Categories ADD CONSTRAINT FK_Categories_Categories  FOREIGN KEY(idSousCategorie) REFERENCES Categories(idCategorie);
ALTER TABLE Produits ADD CONSTRAINT FK_Modeles_Produits FOREIGN KEY(idModele) REFERENCES Modeles(idModele);
ALTER TABLE Produits ADD CONSTRAINT FK_Series_Produits FOREIGN KEY(idSerie) REFERENCES Series(idSerie);
ALTER TABLE Fautes ADD CONSTRAINT FK_Produits_Fautes FOREIGN KEY(idProduit) REFERENCES Produits(idProduit);
ALTER TABLE Classifications ADD CONSTRAINT FK_Categories_Classifications FOREIGN KEY(idCategorie) REFERENCES Categories(idCategorie);
ALTER TABLE Classifications ADD CONSTRAINT FK_Fautes_Classifications FOREIGN KEY(idFaute) REFERENCES Fautes(idFaute);