DROP DATABASE IF EXISTS gestionstock;
CREATE DATABASE gestionstock;
USE gestionstock;

CREATE TABLE TypesProduits(
   idTypeProduit INT AUTO_INCREMENT PRIMARY KEY,
   libelleTypeProduit VARCHAR(100)
)ENGINE=InnoDB;

CREATE TABLE Categories(
   idCategorie INT AUTO_INCREMENT PRIMARY KEY ,
   libelleCategorie VARCHAR(100) ,
   idTypeProduit INT NOT NULL
)ENGINE=InnoDB;

CREATE TABLE Articles(
   idArticle INT AUTO_INCREMENT PRIMARY KEY,
   libelleArticle VARCHAR(100) ,
   quantiteStockee INT,
   idCategorie INT  NOT NULL
)ENGINE=InnoDB;

ALTER TABLE Categories ADD CONSTRAINT FK_Categories_TypesProduits FOREIGN KEY(idTypeProduit) REFERENCES TypesProduits(idTypeProduit);
ALTER TABLE Articles ADD CONSTRAINT FK_Categories_Articles FOREIGN KEY(idCategorie) REFERENCES Categories(idCategorie);
