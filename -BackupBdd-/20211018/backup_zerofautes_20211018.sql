-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: zerofautes
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
-- Current Database: `zerofautes`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `zerofautes` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `zerofautes`;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categories` (
  `idCategorie` int(11) NOT NULL AUTO_INCREMENT,
  `nomCategorie` varchar(50) DEFAULT NULL,
  `descriptionCategorie` varchar(100) DEFAULT NULL,
  `idSousCategorie` int(11) DEFAULT NULL,
  PRIMARY KEY (`idCategorie`),
  KEY `FK_Categories_Categories` (`idSousCategorie`),
  CONSTRAINT `FK_Categories_Categories` FOREIGN KEY (`idSousCategorie`) REFERENCES `categories` (`idCategorie`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classifications`
--

DROP TABLE IF EXISTS `classifications`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `classifications` (
  `idClassification` int(11) NOT NULL AUTO_INCREMENT,
  `idCategorie` int(11) NOT NULL,
  `idFaute` int(11) NOT NULL,
  PRIMARY KEY (`idClassification`),
  KEY `FK_Categories_Classifications` (`idCategorie`),
  KEY `FK_Fautes_Classifications` (`idFaute`),
  CONSTRAINT `FK_Categories_Classifications` FOREIGN KEY (`idCategorie`) REFERENCES `categories` (`idCategorie`),
  CONSTRAINT `FK_Fautes_Classifications` FOREIGN KEY (`idFaute`) REFERENCES `fautes` (`idFaute`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classifications`
--

LOCK TABLES `classifications` WRITE;
/*!40000 ALTER TABLE `classifications` DISABLE KEYS */;
/*!40000 ALTER TABLE `classifications` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fautes`
--

DROP TABLE IF EXISTS `fautes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fautes` (
  `idFaute` int(11) NOT NULL AUTO_INCREMENT,
  `codeFaute` varchar(50) NOT NULL,
  `titreFaute` varchar(150) NOT NULL,
  `dateDetection` date NOT NULL,
  `commentaireFaute` varchar(200) DEFAULT NULL,
  `dateReparation` date DEFAULT NULL,
  `idProduit` int(11) NOT NULL,
  `idTitre` int(11) NOT NULL,
  PRIMARY KEY (`idFaute`),
  KEY `FK_Produits_Fautes` (`idProduit`),
  KEY `FK_Titres_Fautes` (`idTitre`),
  CONSTRAINT `FK_Produits_Fautes` FOREIGN KEY (`idProduit`) REFERENCES `produits` (`idProduit`),
  CONSTRAINT `FK_Titres_Fautes` FOREIGN KEY (`idTitre`) REFERENCES `titres` (`idTitre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fautes`
--

LOCK TABLES `fautes` WRITE;
/*!40000 ALTER TABLE `fautes` DISABLE KEYS */;
/*!40000 ALTER TABLE `fautes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modeles`
--

DROP TABLE IF EXISTS `modeles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `modeles` (
  `idModele` int(11) NOT NULL AUTO_INCREMENT,
  `codeModele` varchar(50) NOT NULL,
  `nomModele` varchar(50) NOT NULL,
  `dateMiseMarche` date NOT NULL,
  PRIMARY KEY (`idModele`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modeles`
--

LOCK TABLES `modeles` WRITE;
/*!40000 ALTER TABLE `modeles` DISABLE KEYS */;
/*!40000 ALTER TABLE `modeles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produits`
--

DROP TABLE IF EXISTS `produits`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produits` (
  `idProduit` int(11) NOT NULL AUTO_INCREMENT,
  `anneeProduction` varchar(50) NOT NULL,
  `numProduit` varchar(4) NOT NULL,
  `idModele` int(11) NOT NULL,
  `idSerie` int(11) NOT NULL,
  PRIMARY KEY (`idProduit`),
  KEY `FK_Modeles_Produits` (`idModele`),
  KEY `FK_Series_Produits` (`idSerie`),
  CONSTRAINT `FK_Modeles_Produits` FOREIGN KEY (`idModele`) REFERENCES `modeles` (`idModele`),
  CONSTRAINT `FK_Series_Produits` FOREIGN KEY (`idSerie`) REFERENCES `series` (`idSerie`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produits`
--

LOCK TABLES `produits` WRITE;
/*!40000 ALTER TABLE `produits` DISABLE KEYS */;
/*!40000 ALTER TABLE `produits` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `series`
--

DROP TABLE IF EXISTS `series`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `series` (
  `idSerie` int(11) NOT NULL AUTO_INCREMENT,
  `numeroSerie` varchar(6) NOT NULL,
  PRIMARY KEY (`idSerie`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `series`
--

LOCK TABLES `series` WRITE;
/*!40000 ALTER TABLE `series` DISABLE KEYS */;
/*!40000 ALTER TABLE `series` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `titres`
--

DROP TABLE IF EXISTS `titres`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `titres` (
  `idTitre` int(11) NOT NULL AUTO_INCREMENT,
  `libelleTitre` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idTitre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `titres`
--

LOCK TABLES `titres` WRITE;
/*!40000 ALTER TABLE `titres` DISABLE KEYS */;
/*!40000 ALTER TABLE `titres` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-18 12:20:02
