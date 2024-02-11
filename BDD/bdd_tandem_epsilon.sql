-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Jeu 29 Juin 2023 à 08:12
-- Version du serveur :  5.7.11
-- Version de PHP :  5.6.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bdd_tandem_epsilon`
--
CREATE DATABASE IF NOT EXISTS `bdd_tandem_epsilon` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `bdd_tandem_epsilon`;

-- --------------------------------------------------------

--
-- Structure de la table `tab_cpf`
--

DROP TABLE IF EXISTS `tab_cpf`;
CREATE TABLE `tab_cpf` (
  `CLP_numCPF` varchar(12) NOT NULL,
  `CLE_numNeph` varchar(20) NOT NULL,
  `CPF_nbHeure` smallint(4) NOT NULL,
  `CPF_tarif` smallint(4) NOT NULL,
  `CPF_dateDebut` datetime NOT NULL,
  `CPF_dateFin` datetime DEFAULT NULL,
  `CPF_dateCreation` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `CPF_dateDerniereModification` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `CPF_auteurDerniereModification` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `tab_cpf`
--

INSERT INTO `tab_cpf` (`CLP_numCPF`, `CLE_numNeph`, `CPF_nbHeure`, `CPF_tarif`, `CPF_dateDebut`, `CPF_dateFin`, `CPF_dateCreation`, `CPF_dateDerniereModification`, `CPF_auteurDerniereModification`) VALUES
('1', '1010101010', 10, 500, '2023-06-20 00:00:00', '2023-07-20 00:00:00', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
('10', '7777777777', 25, 1000, '2023-06-17 00:00:00', '2023-08-25 00:00:00', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
('2', '1111111111', 20, 800, '2023-06-15 00:00:00', '2023-07-30 00:00:00', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
('3', '1212121212', 15, 600, '2023-06-25 00:00:00', '2023-08-05 00:00:00', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
('4', '2222222222', 8, 400, '2023-06-18 00:00:00', '2023-07-25 00:00:00', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
('5', '2468135790', 12, 550, '2023-06-22 00:00:00', '2023-08-10 00:00:00', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
('6', '3692581470', 18, 900, '2023-06-19 00:00:00', '2023-08-15 00:00:00', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
('7', '4444444444', 7, 300, '2023-06-23 00:00:00', '2023-07-28 00:00:00', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
('8', '5555555555', 22, 950, '2023-06-16 00:00:00', '2023-08-20 00:00:00', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
('9', '7083956241', 10, 450, '2023-06-21 00:00:00', '2023-07-31 00:00:00', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib');

-- --------------------------------------------------------

--
-- Structure de la table `tab_disponibilites`
--

DROP TABLE IF EXISTS `tab_disponibilites`;
CREATE TABLE `tab_disponibilites` (
  `CLP_disponibilites` smallint(6) NOT NULL,
  `CLE_numNeph` varchar(20) NOT NULL,
  `DIS_jour` varchar(12) NOT NULL,
  `DIS_heureDebut` tinyint(2) NOT NULL,
  `DIS_heureFin` tinyint(2) NOT NULL,
  `DIS_dateCreation` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `DIS_dateDerniereModification` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `DIS_auteurDerniereModification` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Répertorie les disponibilités de l''élève';

--
-- Contenu de la table `tab_disponibilites`
--

INSERT INTO `tab_disponibilites` (`CLP_disponibilites`, `CLE_numNeph`, `DIS_jour`, `DIS_heureDebut`, `DIS_heureFin`, `DIS_dateCreation`, `DIS_dateDerniereModification`, `DIS_auteurDerniereModification`) VALUES
(3, '5555555555', '', 0, 0, '2023-06-16 09:00:00', '2023-06-16 09:00:00', 'Najib'),
(4, '9876543210', '', 0, 0, '2023-06-16 14:30:00', '2023-06-16 09:00:00', 'Najib'),
(5, '1212121212', '', 0, 0, '2023-06-17 10:15:00', '2023-06-16 09:00:00', 'Najib'),
(6, '9876543210', '', 0, 0, '2023-06-17 16:45:00', '2023-06-16 09:00:00', 'Najib'),
(7, '1111111111', '', 0, 0, '2023-06-18 08:30:00', '2023-06-16 09:00:00', 'Najib'),
(8, '9876543210', '', 0, 0, '2023-06-18 13:45:00', '2023-06-16 09:00:00', 'Najib'),
(9, '1111111111', '', 0, 0, '2023-06-19 11:00:00', '2023-06-16 09:00:00', 'Najib'),
(10, '9876543210', '', 0, 0, '2023-06-19 15:30:00', '2023-06-16 09:00:00', 'Najib'),
(11, '1212121212', '', 0, 0, '2023-06-20 09:45:00', '2023-06-16 09:00:00', 'Najib'),
(12, '9876543210', '', 0, 0, '2023-06-20 14:15:00', '2023-06-16 09:00:00', 'Najib');

-- --------------------------------------------------------

--
-- Structure de la table `tab_eleves`
--

DROP TABLE IF EXISTS `tab_eleves`;
CREATE TABLE `tab_eleves` (
  `CLP_numNeph` varchar(20) NOT NULL,
  `ELE_nom` varchar(32) NOT NULL,
  `ELE_prenom` varchar(32) NOT NULL,
  `ELE_sexe` varchar(16) NOT NULL,
  `ELE_dateNaissance` date NOT NULL,
  `ELE_adresse` varchar(256) NOT NULL,
  `ELE_ville` varchar(80) NOT NULL,
  `ELE_telephone` varchar(16) NOT NULL,
  `ELE_mail` varchar(128) DEFAULT NULL,
  `ELE_dateInscription` date DEFAULT NULL,
  `ELE_validationCode` tinyint(1) DEFAULT NULL COMMENT 'Indique si oui ou non l''élève à obtenue le code.',
  `ELE_dateValidationCode` date DEFAULT NULL,
  `ELE_handicap` varchar(128) DEFAULT NULL COMMENT 'Renseigne le handicap que pourrait avoir l''élève.',
  `ELE_correctionVision` tinyint(1) NOT NULL,
  `ELE_autreInscription` tinyint(1) DEFAULT NULL,
  `ELE_parleFrancais` tinyint(1) NOT NULL,
  `ELE_conduiteAccompagnee` tinyint(1) NOT NULL,
  `ELE_conduiteSupervisee` tinyint(1) NOT NULL,
  `ELE_approfondissement` tinyint(1) NOT NULL,
  `ELE_pensionInvalidite` tinyint(1) DEFAULT NULL,
  `ELE_dateCreation` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `ELE_dateDerniereModification` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `ELE_auteurDerniereModification` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Table principale de la BDD';

--
-- Contenu de la table `tab_eleves`
--

INSERT INTO `tab_eleves` (`CLP_numNeph`, `ELE_nom`, `ELE_prenom`, `ELE_sexe`, `ELE_dateNaissance`, `ELE_adresse`, `ELE_ville`, `ELE_telephone`, `ELE_mail`, `ELE_dateInscription`, `ELE_validationCode`, `ELE_dateValidationCode`, `ELE_handicap`, `ELE_correctionVision`, `ELE_autreInscription`, `ELE_parleFrancais`, `ELE_conduiteAccompagnee`, `ELE_conduiteSupervisee`, `ELE_approfondissement`, `ELE_pensionInvalidite`, `ELE_dateCreation`, `ELE_dateDerniereModification`, `ELE_auteurDerniereModification`) VALUES
('1010101010', 'Garnier', 'Hugo', 'homme', '2003-10-26', '7 rue Victor Hugo', 'Lyon', '04 56 78 90 12', 'hugo.garnier@gmail.com', '2022-07-05', 1, '2022-07-10', '', 0, 1, 0, 0, 0, 0, 0, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('1111111111', 'Leroy', 'Emma', 'femme', '2004-12-08', '4 rue de la Paix', 'Nantes', '02 98 76 54 32', 'emma.leroy@gmail.com', '2022-10-01', 1, '2022-10-05', '', 1, 1, 0, 0, 0, 0, 0, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('1212121212', 'Thomas', 'Manon', 'femme', '2004-03-17', '5 avenue Pasteur', 'Strasbourg', '03 87 65 43 21', 'manon.thomas@yahoo.fr', '2022-08-10', 1, '2022-08-15', '', 1, 0, 0, 0, 0, 0, 0, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('1234543212', 'Lefebvre', 'Julie', 'femme', '2004-02-07', '6 rue des Fleurs', 'Marseille', '06 54 32 10 98', 'julie.lefebvre@gmail.com', '2023-04-01', 1, '2023-04-07', '', 1, 0, 0, 1, 0, 0, 0, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('2222222222', 'Moreau', 'Camille', 'femme', '2004-06-05', '22 rue de la Liberté', 'Bordeaux', '05 43 21 65 87', 'camille.moreau@gmail.com', '2022-12-31', 1, '2023-01-05', 'Dyslexique', 1, 0, 1, 0, 0, 0, 0, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('2468135790', 'Jones', 'Michael', 'homme', '2004-08-25', '987 Maple Avenue', 'Boston', '07 54 32 10 98', 'michael.jones@example.com', '2023-02-01', 1, '2023-02-07', 'None', 0, 1, 0, 0, 1, 0, 0, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('3333333333', 'Martinez', 'Lucas', 'homme', '2003-08-22', '9 avenue des Lilas', 'Montpellier', '04 12 34 56 78', 'lucas.martinez@hotmail.com', '2022-09-15', 1, '2022-09-20', 'Autiste', 0, 0, 0, 1, 0, 0, 1, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('3692581470', 'Smith', 'John', 'homme', '2003-09-12', '123 Main Street', 'New York', '06 12 34 56 78', 'john.smith@example.com', '2023-06-01', 1, '2023-06-05', 'None', 0, 0, 1, 1, 0, 0, 1, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('4444444444', 'Dubois', 'Laura', 'femme', '2004-07-25', '8 avenue des Roses', 'Lille', '03 21 43 65 87', 'laura.dubois@yahoo.fr', '2023-02-10', 1, '2023-02-15', '', 1, 0, 0, 0, 1, 0, 0, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('5555555555', 'Martin', 'Sophie', 'femme', '2002-05-20', '10 rue Saint-Louis', 'Lyon', '04 56 78 90 12', 'sophie.martin@hotmail.com', '2023-05-10', 1, '2023-05-15', '', 1, 0, 1, 0, 0, 0, 0, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('7083956241', 'Brown', 'Sarah', 'femme', '2003-11-18', '321 Pine Street', 'San Francisco', '06 43 21 09 87', 'sarah.brown@example.com', '2023-03-15', 1, '2023-03-20', 'None', 1, 0, 1, 1, 0, 0, 0, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('7777777777', 'Roux', 'Maxime', 'homme', '2002-09-30', '12 avenue Gambetta', 'Nice', '04 98 76 54 32', 'maxime.roux@hotmail.com', '2023-01-05', 1, '2023-01-10', '', 0, 0, 0, 0, 0, 1, 0, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('8642097531', 'Johnson', 'Emily', 'femme', '2002-05-20', '456 Oak Avenue', 'Los Angeles', '07 12 34 56 78', 'emily.johnson@example.com', '2023-05-10', 1, '2023-05-15', 'None', 1, 0, 1, 0, 0, 0, 0, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('8888888888', 'Girard', 'Antoine', 'homme', '2003-04-13', '18 avenue Jean Jaurès', 'Rennes', '02 76 54 32 10', 'antoine.girard@yahoo.fr', '2022-11-15', 1, '2022-11-20', '', 0, 1, 0, 1, 0, 0, 0, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('9517532864', 'Williams', 'David', 'homme', '2004-02-07', '789 Elm Street', 'Chicago', '07 32 10 98 76', 'david.williams@example.com', '2023-04-01', 1, '2023-04-07', 'None', 1, 0, 0, 1, 0, 0, 0, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('9876543210', 'Dupont', 'Pierre', 'autre', '2003-09-12', '25 avenue Victor Hugo', 'Paris', '01 23 45 67 89', 'pierre.dupont@gmail.com', '2023-06-01', 1, '2023-06-05', 'Autiste', 0, 0, 1, 1, 0, 0, 1, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib'),
('9999999999', 'Leclerc', 'Charlotte', 'autre', '2004-11-29', '15 avenue de la République', 'Toulouse', '05 76 54 32 10', 'charlotte.leclerc@yahoo.fr', '2022-10-20', 1, '2022-10-25', '', 1, 0, 0, 0, 0, 0, 0, '2023-06-06 09:35:59', '2023-06-06 09:35:59', 'Najib');

-- --------------------------------------------------------

--
-- Structure de la table `tab_examconduite`
--

DROP TABLE IF EXISTS `tab_examconduite`;
CREATE TABLE `tab_examconduite` (
  `CLP_examConduite` smallint(6) NOT NULL,
  `CLE_numNeph` varchar(20) NOT NULL COMMENT 'Clé étrangère de la table élève, contenant le numéro d''identification Neph, unique pour chaque élèves.',
  `EXA_dateExam` datetime DEFAULT NULL COMMENT 'Date du prichain examen.',
  `EXA_reussite` tinyint(1) DEFAULT NULL COMMENT 'Indique si le dernier examen.',
  `EXA_dateCreation` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `EXA_dateDerniereModification` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `EXA_auteurDerniereModification` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Table contenant les dates des examens de permis passés.';

--
-- Contenu de la table `tab_examconduite`
--

INSERT INTO `tab_examconduite` (`CLP_examConduite`, `CLE_numNeph`, `EXA_dateExam`, `EXA_reussite`, `EXA_dateCreation`, `EXA_dateDerniereModification`, `EXA_auteurDerniereModification`) VALUES
(1, '9876543210', '2023-06-10 09:00:00', 1, '2023-06-17 09:00:00', '2023-06-17 09:00:00', 'Najib'),
(2, '5555555555', '2023-06-12 14:30:00', 0, '2023-06-17 14:30:00', '2023-06-17 14:30:00', 'Najib'),
(3, '1234543212', '2023-06-14 10:15:00', 1, '2023-06-17 10:15:00', '2023-06-17 10:15:00', 'Najib'),
(4, '9999999999', '2023-06-16 13:45:00', 1, '2023-06-17 13:45:00', '2023-06-17 13:45:00', 'Najib'),
(5, '4444444444', '2023-06-19 11:00:00', 0, '2023-06-17 11:00:00', '2023-06-17 11:00:00', 'Najib'),
(6, '7777777777', '2023-06-21 15:30:00', 1, '2023-06-17 15:30:00', '2023-06-17 15:30:00', 'Najib'),
(7, '2222222222', '2023-06-23 09:45:00', 1, '2023-06-17 09:45:00', '2023-06-17 09:45:00', 'Najib'),
(8, '8888888888', '2023-06-25 12:30:00', 0, '2023-06-17 12:30:00', '2023-06-17 12:30:00', 'Najib'),
(9, '1111111111', '2023-06-28 10:00:00', 1, '2023-06-17 10:00:00', '2023-06-17 10:00:00', 'Najib'),
(10, '3333333333', '2023-06-30 14:15:00', 1, '2023-06-17 14:15:00', '2023-06-17 14:15:00', 'Najib');

-- --------------------------------------------------------

--
-- Structure de la table `tab_heureconduite`
--

DROP TABLE IF EXISTS `tab_heureconduite`;
CREATE TABLE `tab_heureconduite` (
  `CLP_id_heureConduite` smallint(6) NOT NULL,
  `CLE_numNeph` varchar(20) NOT NULL,
  `HEU_nombreHeures` tinyint(4) DEFAULT NULL COMMENT 'Durée de la leçon de conduite.',
  `HEU_dateHeureConduite` datetime DEFAULT NULL COMMENT 'Date précise de la leçon de conduite.',
  `HEU_EtatHeureConduite` varchar(16) DEFAULT NULL COMMENT 'Indique si l''heure à étais effectuer, si elle est reportée ou autres ',
  `HEU_moniteur` varchar(64) DEFAULT NULL,
  `HEU_dateCreation` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `HEU_dateDerniereModification` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `HEU_auteurDerniereModification` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Table contenant la liste des leçons de conduite de l''élève.';

--
-- Contenu de la table `tab_heureconduite`
--

INSERT INTO `tab_heureconduite` (`CLP_id_heureConduite`, `CLE_numNeph`, `HEU_nombreHeures`, `HEU_dateHeureConduite`, `HEU_EtatHeureConduite`, `HEU_moniteur`, `HEU_dateCreation`, `HEU_dateDerniereModification`, `HEU_auteurDerniereModification`) VALUES
(1, '9876543210', 2, '2023-06-10 09:00:00', '', 'Ramia', '2023-06-17 09:00:00', '2023-06-17 09:00:00', 'Najib'),
(2, '5555555555', 1, '2023-06-12 14:30:00', '', 'Mahjouba', '2023-06-17 14:30:00', '2023-06-17 14:30:00', 'Najib'),
(3, '1234543212', 2, '2023-06-14 10:15:00', '', 'Ramia', '2023-06-17 10:15:00', '2023-06-17 10:15:00', 'Najib'),
(5, '4444444444', 2, '2023-06-19 11:00:00', '', 'Ramia', '2023-06-17 11:00:00', '2023-06-17 11:00:00', 'Najib'),
(6, '7777777777', 1, '2023-06-21 15:30:00', '', 'Mahjouba', '2023-06-17 15:30:00', '2023-06-17 15:30:00', 'Najib'),
(7, '2222222222', 2, '2023-06-23 09:45:00', '', 'Ramia', '2023-06-17 09:45:00', '2023-06-17 09:45:00', 'Najib'),
(8, '8888888888', 1, '2023-06-25 12:30:00', '', 'Mahjouba', '2023-06-17 12:30:00', '2023-06-17 12:30:00', 'Najib'),
(10, '3333333333', 1, '2023-06-30 14:15:00', '', 'Mahjouba', '2023-06-17 14:15:00', '2023-06-17 14:15:00', 'Najib'),
(11, '9876543210', 2, '2023-06-20 15:00:00', '', 'Ramia', '2023-06-19 10:49:54', '2023-06-19 10:49:54', ''),
(12, '9876543210', 2, '2023-06-21 15:00:00', '', 'Mahjouba', '2023-06-19 10:52:32', '2023-06-19 10:52:32', 'Najib'),
(13, '8888888888', 1, '2023-06-01 10:00:00', '', 'Mahjouba', '2023-06-19 10:52:32', '2023-06-19 10:52:32', 'Najib'),
(14, '9876543210', 2, '2023-06-05 09:00:00', '', '', '2023-06-19 10:55:16', '2023-06-19 10:55:16', ''),
(15, '9876543210', 1, '2023-06-06 10:00:00', '', 'Mahjouba', '2023-06-19 10:55:16', '2023-06-19 10:55:16', 'Najib');

-- --------------------------------------------------------

--
-- Structure de la table `tab_historique`
--

DROP TABLE IF EXISTS `tab_historique`;
CREATE TABLE `tab_historique` (
  `CLP_numNeph` varchar(20) NOT NULL,
  `HIS_nom` varchar(64) NOT NULL,
  `HIS_prenom` varchar(64) NOT NULL,
  `HIS_sexe` varchar(16) NOT NULL,
  `HIS_mail` varchar(128) DEFAULT NULL,
  `HIS_telephone` varchar(20) NOT NULL,
  `HIS_dateInscription` date NOT NULL,
  `HIS_dateObtentionPermis` date DEFAULT NULL,
  `HIS_adresse` varchar(256) NOT NULL,
  `HIS_ville` varchar(128) NOT NULL,
  `HIS_dateNaissance` date NOT NULL,
  `HIS_dateCreation` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `HIS_dateDerniereModification` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `HIS_auteurDerniereModification` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Table d''archivage des informations des anciens élèves.';

--
-- Contenu de la table `tab_historique`
--

INSERT INTO `tab_historique` (`CLP_numNeph`, `HIS_nom`, `HIS_prenom`, `HIS_sexe`, `HIS_mail`, `HIS_telephone`, `HIS_dateInscription`, `HIS_dateObtentionPermis`, `HIS_adresse`, `HIS_ville`, `HIS_dateNaissance`, `HIS_dateCreation`, `HIS_dateDerniereModification`, `HIS_auteurDerniereModification`) VALUES
('124589356478', 'Dupont', 'Jean', 'homme', 'jean.dupont@gmail.com', '0601020304', '2022-03-15', '2023-05-18', '15 rue de la Liberté', 'Paris', '1998-07-22', '2023-06-07 13:45:21', '2023-06-07 13:45:21', 'Najib'),
('258147036925', 'Thomas', 'Alexandre', 'homme', 'alexandre.thomas@yahoo.fr', '0678901234', '2016-02-14', '2017-03-30', '18 avenue des Champs', 'Bordeaux', '1990-08-14', '2023-06-07 18:00:51', '2023-06-07 18:00:51', 'Najib'),
('369258147036', 'Dubois', 'Sophie', 'femme', 'sophie.dubois@hotmail.com', '0612345678', '2018-05-19', '2019-08-25', '10 rue de la Paix', 'Toulouse', '1993-04-07', '2023-06-07 17:05:19', '2023-06-07 17:05:19', 'Najib'),
('456789123456', 'Martin', 'Julie', 'femme', 'julie.martin@yahoo.fr', '0678901234', '2020-06-25', '2021-12-05', '22 rue du Commerce', 'Marseille', '1995-11-03', '2023-06-07 15:20:42', '2023-06-07 15:20:42', 'Najib'),
('741852963147', 'Moreau', 'Luc', 'homme', 'luc.moreau@hotmail.com', '0612345678', '2019-08-23', '2020-10-10', '7 avenue du Lac', 'Nantes', '1997-02-18', '2023-06-07 20:45:37', '2023-06-07 20:45:37', 'Najib'),
('753951357456', 'Garcia', 'Pierre', 'homme', 'pierre.garcia@gmail.com', '0605040302', '2017-12-02', '2019-01-15', '5 avenue du Soleil', 'Nice', '1991-09-28', '2023-06-07 16:10:37', '2023-06-07 16:10:37', 'Najib'),
('852963741852', 'Petit', 'Laura', 'femme', 'laura.petit@yahoo.fr', '0678901234', '2020-01-05', '2021-03-22', '25 rue de la Plage', 'Strasbourg', '1999-05-10', '2023-06-07 21:40:22', '2023-06-07 21:40:22', 'Najib'),
('951753852741', 'Richard', 'Camille', 'femme', 'camille.richard@gmail.com', '0601020304', '2014-11-07', '2016-01-19', '2 rue de la Fontaine', 'Lille', '1988-12-29', '2023-06-07 19:55:10', '2023-06-07 19:55:10', 'Najib'),
('963741852963', 'Robert', 'Thomas', 'homme', 'thomas.robert@gmail.com', '0601020304', '2017-06-11', '2018-08-05', '14 avenue des Lilas', 'Montpellier', '1992-10-26', '2023-06-07 22:35:09', '2023-06-07 22:35:09', 'Najib'),
('987654321098', 'Leroy', 'Marie', 'autre', 'marie.leroy@hotmail.com', '0612345678', '2021-09-10', '2022-11-30', '8 avenue des Roses', 'Lyon', '2002-03-12', '2023-06-07 14:30:15', '2023-06-07 14:30:15', 'Najib');

-- --------------------------------------------------------

--
-- Structure de la table `tab_obtenir`
--

DROP TABLE IF EXISTS `tab_obtenir`;
CREATE TABLE `tab_obtenir` (
  `CLE_categorie` smallint(6) NOT NULL,
  `CLE_numNeph` varchar(20) NOT NULL,
  `OBT_dateObtention` date DEFAULT NULL,
  `OBT_centreExam` varchar(32) DEFAULT NULL,
  `OBT_dateCreation` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `OBT_dateDerniereModification` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `OBT_auteurDerniereModification` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Table associative entre la TAB_eleves et la TAB_categorie.';

--
-- Contenu de la table `tab_obtenir`
--

INSERT INTO `tab_obtenir` (`CLE_categorie`, `CLE_numNeph`, `OBT_dateObtention`, `OBT_centreExam`, `OBT_dateCreation`, `OBT_dateDerniereModification`, `OBT_auteurDerniereModification`) VALUES
(1, '1010101010', '2023-09-25', 'Amboise', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
(1, '2222222222', '2023-10-25', 'Parçay-meslay', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
(1, '3692581470', '2023-10-05', 'Amboise', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
(1, '5555555555', '0000-00-00', 'Parçay-meslay', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
(1, '9876543210', '2023-07-10', 'Amboise', '2023-06-07 11:49:06', '2023-06-07 11:49:06', 'Najib'),
(2, '1234543212', '2023-08-17', 'Parçay-meslay', '2023-06-07 11:57:43', '2023-06-07 11:57:43', 'Najib'),
(2, '3333333333', '2023-09-14', 'Parçay-meslay', '2023-06-07 11:55:43', '2023-06-07 11:55:43', 'Najib'),
(3, '1111111111', '2023-09-25', 'Amboise', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
(3, '2468135790', '2023-10-25', 'Parçay-meslay', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
(3, '4444444444', '2023-07-25', 'Amboise', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib'),
(3, '7083956241', '0000-00-00', 'Parçay-meslay', '2023-06-27 10:00:00', '2023-06-27 10:00:00', 'Najib');

-- --------------------------------------------------------

--
-- Structure de la table `tab_permis`
--

DROP TABLE IF EXISTS `tab_permis`;
CREATE TABLE `tab_permis` (
  `CLP_permis` smallint(6) NOT NULL,
  `PER_libelle` varchar(32) NOT NULL,
  `PER_description` varchar(256) NOT NULL,
  `PER_dateCreation` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `PER_dateDerniereModification` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `PER_auteurDerniereModification` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Table contenant les permis que l''élève possède déjà';

--
-- Contenu de la table `tab_permis`
--

INSERT INTO `tab_permis` (`CLP_permis`, `PER_libelle`, `PER_description`, `PER_dateCreation`, `PER_dateDerniereModification`, `PER_auteurDerniereModification`) VALUES
(1, 'Permis BM', 'Permis voiture, boîte manuel', '2023-06-07 11:45:32', '2023-06-07 11:45:32', 'Najib'),
(2, 'Permis A', 'Permis moto', '2023-06-07 11:45:56', '2023-06-07 11:45:56', 'Najib'),
(3, 'Permis BEA', 'Permis voiture Boîte automatique', '2023-06-21 11:01:06', '2023-06-21 11:01:06', 'Najib');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `tab_cpf`
--
ALTER TABLE `tab_cpf`
  ADD PRIMARY KEY (`CLP_numCPF`),
  ADD KEY `CLE_numNeph` (`CLE_numNeph`);

--
-- Index pour la table `tab_disponibilites`
--
ALTER TABLE `tab_disponibilites`
  ADD PRIMARY KEY (`CLP_disponibilites`),
  ADD KEY `CLE_disponibilites` (`CLE_numNeph`);

--
-- Index pour la table `tab_eleves`
--
ALTER TABLE `tab_eleves`
  ADD PRIMARY KEY (`CLP_numNeph`);

--
-- Index pour la table `tab_examconduite`
--
ALTER TABLE `tab_examconduite`
  ADD PRIMARY KEY (`CLP_examConduite`),
  ADD KEY `CLE_examConduite` (`CLE_numNeph`);

--
-- Index pour la table `tab_heureconduite`
--
ALTER TABLE `tab_heureconduite`
  ADD PRIMARY KEY (`CLP_id_heureConduite`),
  ADD KEY `CLE_heureConduite` (`CLE_numNeph`);

--
-- Index pour la table `tab_historique`
--
ALTER TABLE `tab_historique`
  ADD PRIMARY KEY (`CLP_numNeph`);

--
-- Index pour la table `tab_obtenir`
--
ALTER TABLE `tab_obtenir`
  ADD PRIMARY KEY (`CLE_categorie`,`CLE_numNeph`),
  ADD KEY `CLE_obtenir_eleves` (`CLE_numNeph`);

--
-- Index pour la table `tab_permis`
--
ALTER TABLE `tab_permis`
  ADD PRIMARY KEY (`CLP_permis`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `tab_disponibilites`
--
ALTER TABLE `tab_disponibilites`
  MODIFY `CLP_disponibilites` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT pour la table `tab_examconduite`
--
ALTER TABLE `tab_examconduite`
  MODIFY `CLP_examConduite` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT pour la table `tab_heureconduite`
--
ALTER TABLE `tab_heureconduite`
  MODIFY `CLP_id_heureConduite` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT pour la table `tab_permis`
--
ALTER TABLE `tab_permis`
  MODIFY `CLP_permis` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `tab_disponibilites`
--
ALTER TABLE `tab_disponibilites`
  ADD CONSTRAINT `CLE_disponibilites` FOREIGN KEY (`CLE_numNeph`) REFERENCES `tab_eleves` (`CLP_numNeph`);

--
-- Contraintes pour la table `tab_examconduite`
--
ALTER TABLE `tab_examconduite`
  ADD CONSTRAINT `CLE_examConduite` FOREIGN KEY (`CLE_numNeph`) REFERENCES `tab_eleves` (`CLP_numNeph`);

--
-- Contraintes pour la table `tab_heureconduite`
--
ALTER TABLE `tab_heureconduite`
  ADD CONSTRAINT `CLE_heureConduite` FOREIGN KEY (`CLE_numNeph`) REFERENCES `tab_eleves` (`CLP_numNeph`);

--
-- Contraintes pour la table `tab_obtenir`
--
ALTER TABLE `tab_obtenir`
  ADD CONSTRAINT `CLE_obtenir_categorie` FOREIGN KEY (`CLE_categorie`) REFERENCES `tab_permis` (`CLP_permis`),
  ADD CONSTRAINT `CLE_obtenir_eleves` FOREIGN KEY (`CLE_numNeph`) REFERENCES `tab_eleves` (`CLP_numNeph`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
