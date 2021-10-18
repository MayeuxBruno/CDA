DROP DATABASE IF EXISTS Noel;
CREATE DATABASE IF NOT EXISTS Noel DEFAULT CHARACTER SET utf8;
USE Noel;
#-------------------------------------------------------------------------------------------
#                      Table Enfants
#-------------------------------------------------------------------------------------------

CREATE TABLE Enfants(
   idEnfant INT AUTO_INCREMENT PRIMARY KEY,
   numEnfant VARCHAR(50)  NOT NULL,
   sexe VARCHAR(1) ,
   nomEnfant VARCHAR(50)  NOT NULL,
   prenomEnfant VARCHAR(150)  NOT NULL,
   pourcentageSagesse INT
)ENGINE=InnoDB;

#-------------------------------------------------------------------------------------------
#                      Table Lutins
#-------------------------------------------------------------------------------------------

CREATE TABLE Lutins(
   idLutin INT AUTO_INCREMENT PRIMARY KEY ,
   numLutin VARCHAR(50)  NOT NULL,
   nomLutin VARCHAR(50)  NOT NULL,
   prenomLutin VARCHAR(50)  NOT NULL
)ENGINE=InnoDB;

#-------------------------------------------------------------------------------------------
#                      Table Traineaux
#-------------------------------------------------------------------------------------------

CREATE TABLE Traineaux(
   idTraineau INT AUTO_INCREMENT PRIMARY KEY,
   numTraineau VARCHAR(10)  NOT NULL,
   tailleTraineau VARCHAR(3) ,
   dateMsTraineau DATE NOT NULL,
   dateRevisionTraineau DATE
)ENGINE=InnoDB;

#-------------------------------------------------------------------------------------------
#                      Table Tournees
#-------------------------------------------------------------------------------------------

CREATE TABLE Tournees(
   idTournee INT AUTO_INCREMENT PRIMARY KEY,
   numTournee VARCHAR(10)  NOT NULL,
   heureDepartTournee TIME,
   idLutin INT NOT NULL,
   idTraineau INT NOT NULL
)ENGINE=InnoDB;

#-------------------------------------------------------------------------------------------
#                      Table Cadeaux
#-------------------------------------------------------------------------------------------

CREATE TABLE Cadeaux(
   idCadeau INT AUTO_INCREMENT PRIMARY KEY,
   designationCadeau VARCHAR(100)  NOT NULL,
   idEnfant INT NOT NULL
)ENGINE=InnoDB;

#-------------------------------------------------------------------------------------------
#                      Table Rennes
#-------------------------------------------------------------------------------------------

CREATE TABLE Rennes(
   idRenne INT AUTO_INCREMENT PRIMARY KEY,
   nomRenne VARCHAR(50)  NOT NULL,
   sexeRenne VARCHAR(1)  NOT NULL,
   dateNaissanceRenne DATE NOT NULL
)ENGINE=InnoDB;

#-------------------------------------------------------------------------------------------
#                      Table GestionTraineaux
#-------------------------------------------------------------------------------------------

CREATE TABLE GestionTraineaux(
   idGestionTraineau INT AUTO_INCREMENT PRIMARY KEY,
   idLutin INT,
   idTraineau INT,
   dateAttribution DATE
)ENGINE=InnoDB;

#-------------------------------------------------------------------------------------------
#                      Table CompositionTournees
#-------------------------------------------------------------------------------------------

CREATE TABLE CompositionTournees(
   idCompositionTournee INT AUTO_INCREMENT PRIMARY KEY,
   idTournee INT,
   idCadeau INT,
   numCadeau VARCHAR(50)  NOT NULL
)ENGINE=InnoDB;

#-------------------------------------------------------------------------------------------
#                      Table EquipageTraineaux
#-------------------------------------------------------------------------------------------

CREATE TABLE EquipageTraineaux(
   idEquipageTraineaux INT AUTO_INCREMENT PRIMARY KEY,
   idTournee INT,
   idRenne INT
)ENGINE=InnoDB;

#-----------------------------------------------------------------------------------------
#                              Ajout des Contraintes
#-----------------------------------------------------------------------------------------

ALTER TABLE Tournees ADD CONSTRAINT FK_Tournees_Lutins FOREIGN KEY(idLutin) REFERENCES Lutins(idLutin);
ALTER TABLE Tournees ADD CONSTRAINT FK_Tournees_Traineaux FOREIGN KEY(idTraineau) REFERENCES Traineaux(idTraineau);
ALTER TABLE Cadeaux ADD CONSTRAINT FK_Cadeaux_Enfants FOREIGN KEY(idEnfant) REFERENCES Enfants(idEnfant);
ALTER TABLE GestionTraineaux ADD CONSTRAINT FK_GestionTraineaux_Lutins FOREIGN KEY(idLutin) REFERENCES Lutins(idLutin);
ALTER TABLE GestionTraineaux ADD CONSTRAINT FK_GestionTraineaux_Traineaux FOREIGN KEY(idTraineau) REFERENCES Traineaux(idTraineau);
ALTER TABLE CompositionTournees ADD CONSTRAINT FK_CompositionTournees_Tournees FOREIGN KEY(idTournee) REFERENCES Tournees(idTournee);
ALTER TABLE CompositionTournees ADD CONSTRAINT FK_CompositionTournees_Cadeaux FOREIGN KEY(idCadeau) REFERENCES Cadeaux(idCadeau);
ALTER TABLE EquipageTraineaux ADD CONSTRAINT FK_EquipageTraineaux_Tournees FOREIGN KEY(idTournee) REFERENCES Tournees(idTournee);
ALTER TABLE EquipageTraineaux ADD CONSTRAINT FK_EquipageTraineaux_Rennes FOREIGN KEY(idRenne) REFERENCES Rennes(idRenne);
