DROP DATABASE IF EXISTS greenvillage ;

CREATE DATABASE IF NOT EXISTS greenvillage DEFAULT CHARACTER SET utf8 ;

USE greenvillage;


#--
#-- Table structure for table `Rubriques`
#--
CREATE TABLE Rubriques(
   IdRubrique INT AUTO_INCREMENT PRIMARY KEY,
   libelleRubrique VARCHAR(150)  NOT NULL,
   IdRubrique_1 INT NOT NULL,
   FOREIGN KEY(IdRubrique_1) REFERENCES Rubriques(IdRubrique)
)ENGINE=InnoDB;


--
-- Table structure for table `Fournisseurs`
--
CREATE TABLE Fournisseurs(
   IdFournisseur INT AUTO_INCREMENT PRIMARY KEY,
   nomFournisseur VARCHAR(150)  NOT NULL
)ENGINE=InnoDB;

--
-- Table structure for table `CategoriesClient`
--
CREATE TABLE CategoriesClient(
   IdCategorieClient INT AUTO_INCREMENT PRIMARY KEY,
   libelleCategClient VARCHAR(150)  NOT NULL,
   infoReglement VARCHAR(50)  NOT NULL,
   coefCategClient INT NOT NULL
)ENGINE=InnoDB;

--
-- Table structure for table `Reglements`
--
CREATE TABLE Reglements(
   IdReglement INT AUTO_INCREMENT PRIMARY KEY,
   typePaiement VARCHAR(50)  NOT NULL
)ENGINE=InnoDB;

--
-- Table structure for table `TVA`
--
CREATE TABLE TVA(
   IdTVA INT AUTO_INCREMENT PRIMARY KEY,
   tauxTVA INT
)ENGINE=InnoDB;

--
-- Table structure for table `Roles`
--
CREATE TABLE Roles(
   IdRole INT AUTO_INCREMENT PRIMARY KEY,
   libelleRole VARCHAR(50) 
)ENGINE=InnoDB;

--
-- Table structure for table `Pays`
--
CREATE TABLE Pays(
   IdPays INT AUTO_INCREMENT PRIMARY KEY,
   nomPays VARCHAR(50)  NOT NULL,
   UNIQUE(nomPays)
)ENGINE=InnoDB;

--
-- Table structure for table `EtatsCommande`
--
CREATE TABLE EtatsCommande(
   IdEtatCommande INT AUTO_INCREMENT PRIMARY KEY,
   libelleEtatCommande VARCHAR(50)  NOT NULL
)ENGINE=InnoDB;

--
-- Table structure for table `Produits`
--
CREATE TABLE Produits(
   IdProduit INT AUTO_INCREMENT PRIMARY KEY,
   libelleProduit VARCHAR(150)  NOT NULL,
   description TEXT NOT NULL,
   refProduit VARCHAR(5)  NOT NULL,
   prixHorsTaxe DECIMAL(19,4) NOT NULL,
   photo VARCHAR(150) ,
   stock INT NOT NULL,
   IdRubrique INT NOT NULL,
   UNIQUE(refProduit),
   FOREIGN KEY(IdRubrique) REFERENCES Rubriques(IdRubrique)
)ENGINE=InnoDB;

--
-- Table structure for table `Clients`
--
CREATE TABLE Clients(
   IdUtilisateur INT PRIMARY KEY,
   refClient VARCHAR(5)  NOT NULL,
   coefClient INT NOT NULL,
   IdCategorieClient INT NOT NULL,
   UNIQUE(refClient),
   FOREIGN KEY(IdCategorieClient) REFERENCES CategoriesClient(IdCategorieClient)
)ENGINE=InnoDB;

--
-- Table structure for table `Utilisateurs`
--
CREATE TABLE Utilisateurs(
   IdUtilisateur INT AUTO_INCREMENT PRIMARY KEY,
   nomUser VARCHAR(150)  NOT NULL,
   prenom VARCHAR(150)  NOT NULL,
   EmailUser VARCHAR(150)  NOT NULL,
   mdpUser VARCHAR(50)  NOT NULL,
   IdRole INT NOT NULL,
   UNIQUE(EmailUser),
   FOREIGN KEY(IdRole) REFERENCES Roles(IdRole)
)ENGINE=InnoDB;

--
-- Table structure for table `Villes`
--
CREATE TABLE Villes(
   IdVille INT AUTO_INCREMENT PRIMARY KEY,
   libelleVIlle VARCHAR(150)  NOT NULL,
   codePostal VARCHAR(6)  NOT NULL,
   IdPays INT NOT NULL,
   FOREIGN KEY(IdPays) REFERENCES Pays(IdPays)
)ENGINE=InnoDB;

--
-- Table structure for table `Adresses`
--
CREATE TABLE Adresses(
   IdAdresse INT AUTO_INCREMENT PRIMARY KEY,
   emailAdresse VARCHAR(150)  NOT NULL,
   telMobile VARCHAR(12)  NOT NULL,
   telFixe VARCHAR(12) ,
   adresse VARCHAR(50)  NOT NULL,
   province VARCHAR(50) ,
   complementAdresse VARCHAR(50) ,
   IdVille INT NOT NULL,
   FOREIGN KEY(IdVille) REFERENCES Villes(IdVille)
)ENGINE=InnoDB;

--
-- Table structure for table `Commandes`
--
CREATE TABLE Commandes(
   IdCommande INT AUTO_INCREMENT PRIMARY KEY,
   NumeroCommande VARCHAR(10) ,
   dateCommande DATE,
   IdUtilisateur INT NOT NULL,
   IdAdresse INT NOT NULL,
   UNIQUE(NumeroCommande),
   FOREIGN KEY(IdUtilisateur) REFERENCES Clients(IdUtilisateur),
   FOREIGN KEY(IdAdresse) REFERENCES Adresses(IdAdresse)
)ENGINE=InnoDB;

--
-- Table structure for table `LignesCommande`
--
CREATE TABLE LignesCommande(
   IdLigneCommande INT AUTO_INCREMENT PRIMARY KEY,
   IdProduit INT,
   IdCommande INT,
   quantiteProduit INT,
   FOREIGN KEY(IdProduit) REFERENCES Produits(IdProduit),
   FOREIGN KEY(IdCommande) REFERENCES Commandes(IdCommande)
)ENGINE=InnoDB;

--
-- Table structure for table `Livraisons`
--
CREATE TABLE Livraisons(
   IdLivraison INT AUTO_INCREMENT PRIMARY KEY,
   IdCommande INT,
   IdAdresse INT,
   dateLivraison DATE,
   quantiteLivraison VARCHAR(50)  NOT NULL,
   FOREIGN KEY(IdCommande) REFERENCES Commandes(IdCommande),
   FOREIGN KEY(IdAdresse) REFERENCES Adresses(IdAdresse)
)ENGINE=InnoDB;

--
-- Table structure for table `Approvisionnements`
--
CREATE TABLE Approvisionnements(
   IdApprovisionnement INT AUTO_INCREMENT PRIMARY KEY,
   IdProduit INT,
   IdFournisseur INT,
   refFournisseur VARCHAR(5)  NOT NULL,
   FOREIGN KEY(IdProduit) REFERENCES Produits(IdProduit),
   FOREIGN KEY(IdFournisseur) REFERENCES Fournisseurs(IdFournisseur)
)ENGINE=InnoDB;

--
-- Table structure for table `Factures`
--
CREATE TABLE Factures(
   IdReglement INT,
   IdCommande INT,
   datePaiement DATE NOT NULL,
   montantPaiement DECIMAL(19,4) NOT NULL,
   PRIMARY KEY(IdReglement, IdCommande),
   FOREIGN KEY(IdReglement) REFERENCES Reglements(IdReglement),
   FOREIGN KEY(IdCommande) REFERENCES Commandes(IdCommande)
)ENGINE=InnoDB;

--
-- Table structure for table `HistoriqueTVA`
--
CREATE TABLE HistoriqueTVA(
   IdProduit INT,
   IdTVA INT,
   dateTVA DATE NOT NULL,
   PRIMARY KEY(IdProduit, IdTVA),
   FOREIGN KEY(IdProduit) REFERENCES Produits(IdProduit),
   FOREIGN KEY(IdTVA) REFERENCES TVA(IdTVA)
)ENGINE=InnoDB;

--
-- Table structure for table `ProgressionsCommande`
--
CREATE TABLE ProgressionsCommande(
   IdCommande INT,
   IdEtatCommande INT,
   dateEtatCommande DATE NOT NULL,
   PRIMARY KEY(IdCommande, IdEtatCommande),
   FOREIGN KEY(IdCommande) REFERENCES Commandes(IdCommande),
   FOREIGN KEY(IdEtatCommande) REFERENCES EtatsCommande(IdEtatCommande)
)ENGINE=InnoDB;
