INSERT INTO `types`(`libelleType`) VALUES ("Lettre");
INSERT INTO `types`(`libelleType`) VALUES ("Colis");

INSERT INTO `bureaux`(`codePostal`) VALUES ("62100");
INSERT INTO `bureaux`(`codePostal`) VALUES ("62150");
INSERT INTO `bureaux`(`codePostal`) VALUES ("62200");
INSERT INTO `bureaux`(`codePostal`) VALUES ("62250");
INSERT INTO `bureaux`(`codePostal`) VALUES ("62300");
INSERT INTO `bureaux`(`codePostal`) VALUES ("62350");
INSERT INTO `bureaux`(`codePostal`) VALUES ("62400");

INSERT INTO `centres_de_tri`(`nomCentreDeTri`) VALUES ("ARRAS");
INSERT INTO `centres_de_tri`(`nomCentreDeTri`) VALUES ("LILLE");
INSERT INTO `centres_de_tri`(`nomCentreDeTri`) VALUES ("DUNKERQUE");

INSERT INTO `transports`(`libelleTransport`, `taxeCarbonne`) VALUES ("Camion",20);
INSERT INTO `transports`(`libelleTransport`, `taxeCarbonne`) VALUES ("Train",5);
INSERT INTO `transports`(`libelleTransport`, `taxeCarbonne`) VALUES ("Avion",10);
INSERT INTO `transports`(`libelleTransport`, `taxeCarbonne`) VALUES ("Bateau",15);

INSERT INTO `courriers` (`rueDestinataire`, `numDestintaire`, `rueEmetteur`, `numEmetteur`, `idType`) VALUES ('rue de lille', '12', 'rue des chenes', '25', 2);
INSERT INTO `courriers` (`rueDestinataire`, `numDestintaire`, `rueEmetteur`, `numEmetteur`, `idType`) VALUES ('rue de Dunkerque', '59', 'rue de Bétune', '225', 2);
INSERT INTO `courriers` (`rueDestinataire`, `numDestintaire`, `idType`) VALUES ('rue Jean Jaures', '115', 1);
INSERT INTO `courriers` (`rueDestinataire`, `numDestintaire`, `idType`) VALUES ('rue de la mairie', '11', 1);

INSERT INTO `gestion` (`idBureau`, `idCourrier`, `dateEnvoi`, `dateReception`) VALUES ('1', '1', '2021-09-01', '2021-09-09');
INSERT INTO `gestion` (`idBureau`, `idCourrier`, `dateEnvoi`, `dateReception`) VALUES ('5', '2', '2021-10-01', '2021-10-07');
INSERT INTO `gestion` (`idBureau`, `idCourrier`) VALUES ('6', '3');
INSERT INTO `gestion` (`idBureau`, `idCourrier`) VALUES ('7', '4');

INSERT INTO `acheminement` (`idBureau`, `idTransport`, `idCentresDeTri`) VALUES ('1', '1', '3');
INSERT INTO `acheminement` (`idBureau`, `idTransport`, `idCentresDeTri`) VALUES ('3', '1', '3');
INSERT INTO `acheminement` (`idBureau`, `idTransport`, `idCentresDeTri`) VALUES ('2', '1', '3');
INSERT INTO `acheminement` (`idBureau`, `idTransport`, `idCentresDeTri`) VALUES ('1', '1', '3');
