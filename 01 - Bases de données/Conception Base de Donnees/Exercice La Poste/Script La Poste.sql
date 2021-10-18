DROP DATABASE IF EXISTS laposte;
CREATE DATABASE laposte;
USE laposte;

#----------------------------------
# Table Bureaux
#----------------------------------

CREATE TABLE Bureaux(
   idBureau INT AUTO_INCREMENT PRIMARY KEY,
   codePostal VARCHAR(6) 
)ENGINE=InnoDB;

#----------------------------------
# Table Types
#----------------------------------

CREATE TABLE Types(
   idType INT AUTO_INCREMENT PRIMARY KEY,
   libelleType VARCHAR(50) 
)ENGINE=InnoDB;

#----------------------------------
# Table Courriers
#----------------------------------

CREATE TABLE Courriers(
   idCourrier INT AUTO_INCREMENT PRIMARY KEY,
   rueDestinataire VARCHAR(150)  NOT NULL,
   numDestintaire VARCHAR(50)  NOT NULL,
   rueEmetteur VARCHAR(150) ,
   numEmetteur VARCHAR(50) ,
   idType INT NOT NULL
)ENGINE=InnoDB;

#----------------------------------
# Table Transports
#----------------------------------

CREATE TABLE Transports(
   idTransport INT AUTO_INCREMENT PRIMARY KEY,
   libelleTransport VARCHAR(50) ,
   taxeCarbonne INT
)ENGINE=InnoDB;

#----------------------------------
# Table Centres_de_tri
#----------------------------------

CREATE TABLE Centres_de_tri(
   idCentresDeTri INT AUTO_INCREMENT PRIMARY KEY,
   nomCentreDeTri VARCHAR(50) 
)ENGINE=InnoDB;

#----------------------------------
# Table Acheminement
#----------------------------------

CREATE TABLE Acheminement(
   idAchemine INT AUTO_INCREMENT PRIMARY KEY,
   idBureau INT,
   idTransport INT,
   idCentresDeTri INT
)ENGINE=InnoDB;

#----------------------------------
# Table Gestion
#----------------------------------

CREATE TABLE Gestion(
   idGere INT AUTO_INCREMENT PRIMARY KEY,
   idBureau INT,
   idCourrier INT,
   dateEnvoi DATE,
   dateReception DATE
)ENGINE=InnoDB;


ALTER TABLE Courriers ADD CONSTRAINT FK_Courriers_Types FOREIGN KEY(idType) REFERENCES Types(idType);
ALTER TABLE Acheminement ADD CONSTRAINT FK_Achemine_Bureau FOREIGN KEY(idBureau) REFERENCES Bureaux(idBureau);
ALTER TABLE Acheminement ADD CONSTRAINT FK_Achemine_Transport FOREIGN KEY(idTransport) REFERENCES Transports(idTransport); 
ALTER TABLE Acheminement ADD CONSTRAINT FK_Acheminement_Centres_de_tri FOREIGN KEY(idCentresDeTri) REFERENCES Centres_de_tri(idCentresDeTri); 
ALTER TABLE Gestion ADD CONSTRAINT FK_Gestion_Bureaux FOREIGN KEY(idBureau) REFERENCES Bureaux(idBureau);
ALTER TABLE Gestion ADD CONSTRAINT FK_Gestion_Courrier FOREIGN KEY(idCourrier) REFERENCES Courriers(idCourrier); 
   