DROP DATABASE IF EXISTS employes;
CREATE DATABASE IF NOT EXISTS employes DEFAULT CHARACTER SET utf8;
USE employes;
#--------------------------------------------------------------------------------------------
#                      Table DEPARTEMENT
#-------------------------------------------------------------------------------------------

CREATE TABLE DEPARTEMENT(
   nodep INT PRIMARY KEY ,
   nomdep VARCHAR(50) ,
   ville VARCHAR(150) 
)ENGINE=InnoDB;

#--------------------------------------------------------------------------------------------
#                      Table EMPLOYE
#-------------------------------------------------------------------------------------------

CREATE TABLE EMPLOYE(
   noemp INT AUTO_INCREMENT PRIMARY KEY,
   nomemp VARCHAR(50) ,
   fonction VARCHAR(50) ,
   datemb DATE,
   sala DECIMAL(5,2)  ,
   comm DECIMAL(5,2)  ,
   noresp INT,
   nodep INT NOT NULL
)ENGINE=InnoDB;

#--------------------------------------------------------------------------------------------
#                      Table GRADE
#-------------------------------------------------------------------------------------------

CREATE TABLE GRADE(
   nograde INT AUTO_INCREMENT PRIMARY KEY,
   salmin DECIMAL(5,2)  ,
   salmax DECIMAL(5,2)  
)ENGINE=InnoDB;

#--------------------------------------------------------------------------------------------
#                      Table HISTOFONCTION
#-------------------------------------------------------------------------------------------

CREATE TABLE HISTOFONCTION(
   noemp INT,
   date_nom DATE,
   fonction VARCHAR(50) ,
   PRIMARY KEY(noemp, date_nom)
)ENGINE=InnoDB;


ALTER TABLE EMPLOYE ADD CONSTRAINT FK_EMPLOYE_EMPLOYE FOREIGN KEY(noresp) REFERENCES EMPLOYE(noemp);
ALTER TABLE EMPLOYE ADD CONSTRAINT FK_EMPLOYE_DEPARTEMENT FOREIGN KEY(nodep) REFERENCES DEPARTEMENT(nodep);
ALTER TABLE HISTOFONCTION ADD CONSTRAINT FK_HISTOFONCTION_DEPARTEMENT FOREIGN KEY(noemp) REFERENCES EMPLOYE(noemp);