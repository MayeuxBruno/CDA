DROP DATABASE IF EXISTS Bibliotheque;
CREATE DATABASE Bibliotheque DEFAULT CHARACTER SET utf8;
USE Bibliotheque;

#------------------------------
#--  Table EtatsReservations --
#------------------------------

CREATE TABLE EtatsReservations(
   idEtatReservation INT AUTO_INCREMENT PRIMARY KEY,
   libelleEtatReservation VARCHAR(50) 
)ENGINE=InnoDB;

#-------------------
#--  Table Themes --
#-------------------

CREATE TABLE Themes(
   idTheme INT AUTO_INCREMENT PRIMARY KEY,
   nomTheme VARCHAR(50) 
)ENGINE=InnoDB;

#--------------------
#--  Table Auteurs --
#--------------------

CREATE TABLE Auteurs(
   idAuteur INT AUTO_INCREMENT PRIMARY KEY,
   nomAuteur VARCHAR(100) 
)ENGINE=InnoDB;

#------------------
#-- Table Genres --
#------------------

CREATE TABLE Genres(
   idGenre INT AUTO_INCREMENT PRIMARY KEY,
   nomGenre VARCHAR(50) 
)ENGINE=InnoDB;

#---------------------
#--  Table Editeurs --
#---------------------

CREATE TABLE Editeurs(
   idEditeur INT AUTO_INCREMENT PRIMARY KEY,
   nomEditeur VARCHAR(100) 
)ENGINE=InnoDB;

#-------------------
#--  Table Usures --
#-------------------

CREATE TABLE Usures(
   idUsure INT AUTO_INCREMENT PRIMARY KEY,
   codeUsure VARCHAR(50) 
)ENGINE=InnoDB;

#---------------------------------------
#--  Table CategoriesProfessionnelles --
#---------------------------------------

CREATE TABLE CategoriesProfessionnelles(
   idCategorieProfessionnelle INT AUTO_INCREMENT PRIMARY KEY,
   libelleCategPro VARCHAR(50)
)ENGINE=InnoDB;

#--------------------
#-- Table MotsCles --
#--------------------

CREATE TABLE MotsCles(
   idMotCle INT AUTO_INCREMENT PRIMARY KEY,
   libelleMotCle VARCHAR(50) 
)ENGINE=InnoDB;

#-------------------
#--  Table Villes --
#-------------------

CREATE TABLE Villes(
   idVille INT AUTO_INCREMENT PRIMARY KEY,
   codePostal VARCHAR(5) ,
   nomVille VARCHAR(100) 
)ENGINE=InnoDB;

#-------------------
#--  Table Livres --
#-------------------

CREATE TABLE Livres(
   idLivre INT AUTO_INCREMENT PRIMARY KEY,
   titreLivre VARCHAR(50) ,
   codeCatalogue VARCHAR(50) ,
   idEditeur INT NOT NULL,
   idTheme INT NOT NULL
)ENGINE=InnoDB;

#------------------------
#--  Table Exemplaires --
#------------------------

CREATE TABLE Exemplaires(
   idExemplaire INT AUTO_INCREMENT PRIMARY KEY,
   dateAcquisition DATE,
   disponibilite BOOLEAN,
   codeRayon VARCHAR(50) ,
   idUsure INT NOT NULL,
   idLivre INT NOT NULL
)ENGINE=InnoDB;

#---------------------
#--  Table Abonnes  --
#---------------------

CREATE TABLE Abonnes(
   idAbonne INT AUTO_INCREMENT PRIMARY KEY,
   matriculeAbonne VARCHAR(50) ,
   nomAbonne VARCHAR(100) ,
   prenomAbonne VARCHAR(50) ,
   adresseAbonne VARCHAR(150) ,
   telephoneAbonne VARCHAR(12) ,
   dateAdhesion DATE,
   dateNaissance DATE,
   idVille INT NOT NULL,
   idCategorieProfessionnelle INT NOT NULL 
)ENGINE=InnoDB;

#--------------------------
#--  Table Reservations  --
#--------------------------

CREATE TABLE Reservations(
   idReservation INT AUTO_INCREMENT PRIMARY KEY,
   idEtatReservation INT ,
   idLivre INT,
   idAbonne INT,
   dateDebutReservation DATE,
   dateDemandeReservation DATE
)ENGINE=InnoDB;

#------------------------
#--  Table Definitions --
#------------------------

CREATE TABLE Definitions(
   idDefinition INT AUTO_INCREMENT PRIMARY KEY,
   idGenre INT,
   idLivre INT
)ENGINE=InnoDB;

#-------------------------
#--  Table Compositions --
#-------------------------

CREATE TABLE Compositions(
   idComposition INT AUTO_INCREMENT PRIMARY KEY,
   idAuteur INT,
   idLivre INT
)ENGINE=InnoDB;

#-------------------------------
#--  Table EmpruntExemplaires --
#-------------------------------

CREATE TABLE EmpruntExemplaires(
   idEmpruntExemplaire INT AUTO_INCREMENT PRIMARY KEY,
   idExemplaire INT,
   idAbonne INT,
   dateEmprunt DATE,
   dateRetourEffective DATE
)ENGINE=InnoDB;

#----------------------------
#--  Table Identifications --
#----------------------------

CREATE TABLE Identifications(
   idIdentification INT AUTO_INCREMENT PRIMARY KEY,
   idLivre INT,
   idMotCle INT
)ENGINE=InnoDB;

#------------------------------------------------------------------------------
#            Ajout des contraintes 
#------------------------------------------------------------------------------

ALTER TABLE Livres ADD CONSTRAINT FK_Livres_Editeurs FOREIGN KEY(idEditeur) REFERENCES editeurs(idEditeur);
ALTER TABLE Livres ADD CONSTRAINT FK_Livres_Themes FOREIGN KEY(idTheme) REFERENCES Themes(idTheme);
ALTER TABLE Exemplaires ADD CONSTRAINT FK_Exemplaires_Usures FOREIGN KEY(idUsure) REFERENCES Usures(idUsure);
ALTER TABLE Exemplaires ADD CONSTRAINT FK_Exemplaires_Livres FOREIGN KEY(idLivre) REFERENCES Livres(idLivre);
ALTER TABLE Abonnes ADD CONSTRAINT FK_Abonnes_Villes FOREIGN KEY(idVille) REFERENCES Villes(idVille);
ALTER TABLE Abonnes ADD CONSTRAINT FK_Abonnes_CategoriesProfessionnelles FOREIGN KEY(idCategorieProfessionnelle) REFERENCES CategoriesProfessionnelles(idCategorieProfessionnelle);
ALTER TABLE Reservations ADD CONSTRAINT FK_Reservations_EtatsReservations FOREIGN KEY(idEtatReservation) REFERENCES EtatsReservations(idEtatReservation);
ALTER TABLE Reservations ADD CONSTRAINT FK_Reservations_Livres FOREIGN KEY(idLivre) REFERENCES Livres(idLivre);
ALTER TABLE Reservations ADD CONSTRAINT FK_Reservations_Abonnes FOREIGN KEY(idAbonne) REFERENCES Abonnes(idAbonne);
ALTER TABLE Definitions ADD CONSTRAINT FK_Definitions_Genres FOREIGN KEY(idGenre) REFERENCES Genres(idGenre);
ALTER TABLE Definitions ADD CONSTRAINT FK_Definitions_Livres FOREIGN KEY(idLivre) REFERENCES Livres(idLivre);
ALTER TABLE Compositions ADD CONSTRAINT FK_Compositions_Auteurs FOREIGN KEY(idAuteur) REFERENCES Auteurs(idAuteur);
ALTER TABLE Compositions ADD CONSTRAINT FK_Compositions_Livres FOREIGN KEY(idLivre) REFERENCES Livres(idLivre);
ALTER TABLE EmpruntExemplaires ADD CONSTRAINT FK_EmpruntExemplaires_Exemplaires FOREIGN KEY(idExemplaire) REFERENCES Exemplaires(idExemplaire);
ALTER TABLE EmpruntExemplaires ADD CONSTRAINT FK_EmpruntExemplaires_Abonnes FOREIGN KEY(idAbonne) REFERENCES Abonnes(idAbonne);
ALTER TABLE Identifications ADD CONSTRAINT FK_Identifications_Livres FOREIGN KEY(idLivre) REFERENCES Livres(idLivre);
ALTER TABLE Identifications ADD CONSTRAINT FK_Identifications_MotsCles FOREIGN KEY(idMotCle) REFERENCES MotsCles(idMotCle);