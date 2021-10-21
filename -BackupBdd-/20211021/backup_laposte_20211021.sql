-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: laposte
-- ------------------------------------------------------
-- Server version	5.7.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `laposte`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `laposte` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `laposte`;

--
-- Table structure for table `acheminement`
--

DROP TABLE IF EXISTS `acheminement`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `acheminement` (
  `idAchemine` int(11) NOT NULL AUTO_INCREMENT,
  `idBureau` int(11) DEFAULT NULL,
  `idTransport` int(11) DEFAULT NULL,
  `idCentresDeTri` int(11) DEFAULT NULL,
  PRIMARY KEY (`idAchemine`),
  KEY `FK_Achemine_Bureau` (`idBureau`),
  KEY `FK_Achemine_Transport` (`idTransport`),
  KEY `FK_Acheminement_Centres_de_tri` (`idCentresDeTri`),
  CONSTRAINT `FK_Achemine_Bureau` FOREIGN KEY (`idBureau`) REFERENCES `bureaux` (`idBureau`),
  CONSTRAINT `FK_Achemine_Transport` FOREIGN KEY (`idTransport`) REFERENCES `transports` (`idTransport`),
  CONSTRAINT `FK_Acheminement_Centres_de_tri` FOREIGN KEY (`idCentresDeTri`) REFERENCES `centres_de_tri` (`idCentresDeTri`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acheminement`
--

LOCK TABLES `acheminement` WRITE;
/*!40000 ALTER TABLE `acheminement` DISABLE KEYS */;
INSERT INTO `acheminement` VALUES (1,1,1,1),(2,3,1,1),(3,2,3,3),(4,5,2,2);
/*!40000 ALTER TABLE `acheminement` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bureaux`
--

DROP TABLE IF EXISTS `bureaux`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bureaux` (
  `idBureau` int(11) NOT NULL AUTO_INCREMENT,
  `codePostal` varchar(6) DEFAULT NULL,
  PRIMARY KEY (`idBureau`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bureaux`
--

LOCK TABLES `bureaux` WRITE;
/*!40000 ALTER TABLE `bureaux` DISABLE KEYS */;
INSERT INTO `bureaux` VALUES (1,'62100'),(2,'62150'),(3,'62200'),(4,'62250'),(5,'62300'),(6,'62350'),(7,'62400');
/*!40000 ALTER TABLE `bureaux` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `centres_de_tri`
--

DROP TABLE IF EXISTS `centres_de_tri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `centres_de_tri` (
  `idCentresDeTri` int(11) NOT NULL AUTO_INCREMENT,
  `nomCentreDeTri` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idCentresDeTri`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `centres_de_tri`
--

LOCK TABLES `centres_de_tri` WRITE;
/*!40000 ALTER TABLE `centres_de_tri` DISABLE KEYS */;
INSERT INTO `centres_de_tri` VALUES (1,'ARRAS'),(2,'LILLE'),(3,'DUNKERQUE');
/*!40000 ALTER TABLE `centres_de_tri` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `courriers`
--

DROP TABLE IF EXISTS `courriers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `courriers` (
  `idCourrier` int(11) NOT NULL AUTO_INCREMENT,
  `rueDestinataire` varchar(150) NOT NULL,
  `numDestintaire` varchar(50) NOT NULL,
  `rueEmetteur` varchar(150) DEFAULT NULL,
  `numEmetteur` varchar(50) DEFAULT NULL,
  `idType` int(11) NOT NULL,
  PRIMARY KEY (`idCourrier`),
  KEY `FK_Courriers_Types` (`idType`),
  CONSTRAINT `FK_Courriers_Types` FOREIGN KEY (`idType`) REFERENCES `types` (`idType`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courriers`
--

LOCK TABLES `courriers` WRITE;
/*!40000 ALTER TABLE `courriers` DISABLE KEYS */;
INSERT INTO `courriers` VALUES (1,'rue de lille','12','rue des chenes','25',2),(2,'rue de Dunkerque','59','rue de Bétune','225',2),(3,'rue Jean Jaures','115',NULL,NULL,1),(4,'rue de la mairie','11',NULL,NULL,1);
/*!40000 ALTER TABLE `courriers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gestion`
--

DROP TABLE IF EXISTS `gestion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gestion` (
  `idGere` int(11) NOT NULL AUTO_INCREMENT,
  `idBureau` int(11) DEFAULT NULL,
  `idCourrier` int(11) DEFAULT NULL,
  `dateEnvoi` date DEFAULT NULL,
  `dateReception` date DEFAULT NULL,
  PRIMARY KEY (`idGere`),
  KEY `FK_Gestion_Bureaux` (`idBureau`),
  KEY `FK_Gestion_Courrier` (`idCourrier`),
  CONSTRAINT `FK_Gestion_Bureaux` FOREIGN KEY (`idBureau`) REFERENCES `bureaux` (`idBureau`),
  CONSTRAINT `FK_Gestion_Courrier` FOREIGN KEY (`idCourrier`) REFERENCES `courriers` (`idCourrier`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gestion`
--

LOCK TABLES `gestion` WRITE;
/*!40000 ALTER TABLE `gestion` DISABLE KEYS */;
INSERT INTO `gestion` VALUES (1,1,1,'2021-09-01','2021-09-09'),(2,5,2,'2021-10-01','2021-10-07'),(3,6,3,NULL,NULL),(4,7,4,NULL,NULL);
/*!40000 ALTER TABLE `gestion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transports`
--

DROP TABLE IF EXISTS `transports`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transports` (
  `idTransport` int(11) NOT NULL AUTO_INCREMENT,
  `libelleTransport` varchar(50) DEFAULT NULL,
  `taxeCarbonne` int(11) DEFAULT NULL,
  PRIMARY KEY (`idTransport`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transports`
--

LOCK TABLES `transports` WRITE;
/*!40000 ALTER TABLE `transports` DISABLE KEYS */;
INSERT INTO `transports` VALUES (1,'Camion',20),(2,'Train',5),(3,'Avion',10),(4,'Bateau',15);
/*!40000 ALTER TABLE `transports` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `types`
--

DROP TABLE IF EXISTS `types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `types` (
  `idType` int(11) NOT NULL AUTO_INCREMENT,
  `libelleType` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idType`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `types`
--

LOCK TABLES `types` WRITE;
/*!40000 ALTER TABLE `types` DISABLE KEYS */;
INSERT INTO `types` VALUES (1,'Lettre'),(2,'Colis');
/*!40000 ALTER TABLE `types` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-21 17:20:02
