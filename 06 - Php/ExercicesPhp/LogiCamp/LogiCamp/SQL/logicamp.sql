DROP DATABASE IF EXISTS logicamp;
CREATE DATABASE logicamp DEFAULT CHARACTER SET utf8;
Use logicamp;

CREATE TABLE Villes(
   idVille INT AUTO_INCREMENT PRIMARY KEY,
   nomVille VARCHAR(150),
   codePostal VARCHAR(5)
)ENGINE=InnoDB;

CREATE TABLE TypesEmplacements(
   IdTypeEmplacement INT  AUTO_INCREMENT PRIMARY KEY,
   libelleTypeEmplacement VARCHAR(50)
)ENGINE=InnoDB;

CREATE TABLE Clients(
   idClient INT AUTO_INCREMENT PRIMARY KEY,
   nomClient VARCHAR(50),
   prenomClient VARCHAR(50),
   telClient VARCHAR(14) NOT NULL,
   mailClient VARCHAR(50),
   adresseClient VARCHAR(50),
   idVille INT NOT NULL
)ENGINE=InnoDB;

CREATE TABLE Emplacements(
   idEmplacement INT AUTO_INCREMENT PRIMARY KEY,
   refEmplacment VARCHAR(50) NOT NULL,
   descriptionEmplacement VARCHAR(50),
   eau BOOLEAN,
   electricite BOOLEAN,
   IdTypeEmplacement INT NOT NULL
)ENGINE=InnoDB;

CREATE TABLE Reservations(
   idReservation INT AUTO_INCREMENT PRIMARY KEY,
   idClient INT NOT NULL,
   idEmplacement INT NOT NULL,
   dateReservation DATE,
   debutSejour DATE,
   finSejour DATE
)ENGINE=InnoDB;

ALTER TABLE Clients 
    ADD CONSTRAINT FK_Clients_Villes FOREIGN KEY(idVille) REFERENCES Villes(idVille);
ALTER TABLE Emplacements
    ADD CONSTRAINT FK_Emplacement_TypesEmplacements FOREIGN KEY(IdTypeEmplacement) REFERENCES TypesEmplacements(IdTypeEmplacement);

ALTER TABLE Reservations
    ADD CONSTRAINT FK_Reservations_Clients FOREIGN KEY(idClient) REFERENCES Clients(idClient);
-- ALTER TABLE Reservations
    -- ADD CONSTRAINT FK_Reservations_Emplacements FOREIGN KEY(idEmplacement) REFERENCES Emplacements(idEmplacement);

ALTER TABLE `reservations` ADD CONSTRAINT `toto` FOREIGN KEY (`idEmplacement`) REFERENCES `emplacements`(`idEmplacement`);