-- phpMyAdmin SQL Dump
-- version 3.3.5
-- http://www.phpmyadmin.net
--
-- Serveur: 127.0.0.1
-- Généré le : Mer 04 Mai 2011 à 10:03
-- Version du serveur: 5.1.49
-- Version de PHP: 5.3.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `bibliotheque`
--

-- --------------------------------------------------------

--
-- Structure de la table `cd`
--

CREATE TABLE IF NOT EXISTS `cd` (
  `CODE_ELEMENT` int(2) NOT NULL AUTO_INCREMENT,
  `NOM_ARTISTE` char(32) DEFAULT NULL,
  `ANNEE_SORTIE` int(4) DEFAULT NULL,
  `NOM_ELEMENT` char(32) DEFAULT NULL,
  `DATE_AJOUT` date DEFAULT NULL,
  PRIMARY KEY (`CODE_ELEMENT`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Contenu de la table `cd`
--

INSERT INTO `cd` (`CODE_ELEMENT`, `NOM_ARTISTE`, `ANNEE_SORTIE`, `NOM_ELEMENT`, `DATE_AJOUT`) VALUES
(1, 'Metallica', 1991, 'Metallica', '2011-01-14'),
(2, 'Metallica', 1984, 'Ride The Lightning', '2011-01-14'),
(3, 'Metallica', 2008, 'Death Magnetic', '2011-01-14'),
(4, 'Michael Jackson', 1982, 'Thriller', '2011-01-14'),
(5, 'Michael Jackson', 1986, 'Bad', '2011-01-14'),
(6, 'Black Eyes Peas', 2010, 'The Beginning', '2011-03-08'),
(7, 'AC/DC', 1980, 'TNT', '2011-03-09');

-- --------------------------------------------------------

--
-- Structure de la table `film`
--

CREATE TABLE IF NOT EXISTS `film` (
  `CODE_ELEMENT` int(2) NOT NULL AUTO_INCREMENT,
  `CODE_TYPE` int(2) NOT NULL,
  `ANNEE_SORTIE` int(4) DEFAULT NULL,
  `LANGUE` char(32) DEFAULT NULL,
  `NOM_ELEMENT` char(32) DEFAULT NULL,
  `DATE_AJOUT` date DEFAULT NULL,
  PRIMARY KEY (`CODE_ELEMENT`),
  KEY `I_FK_FILM_TYPEMEDIA` (`CODE_TYPE`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Contenu de la table `film`
--

INSERT INTO `film` (`CODE_ELEMENT`, `CODE_TYPE`, `ANNEE_SORTIE`, `LANGUE`, `NOM_ELEMENT`, `DATE_AJOUT`) VALUES
(1, 2, 2003, 'Français', 'Matrix Reloaded', '2011-01-14'),
(2, 2, 1999, 'Français', 'Matrix', '2011-01-14'),
(4, 1, 2003, 'Français', 'Matrix Revolutions', '2011-01-14'),
(5, 1, 2001, 'Français', 'Star Wars: La Menace Fantôme', '2011-01-14'),
(6, 2, 2003, 'Français', 'Star Wars: L''attaque des clones', '2011-01-14'),
(7, 1, 2005, 'Français', 'Star Wars: La Revanche des Sith', '2011-01-14'),
(8, 2, 1977, 'Français', 'Star Wars: Un nouvel espoir', '2011-01-14'),
(9, 2, 1983, 'Français', 'Star Wars: Le Retour du Jedi', '2011-01-14'),
(10, 2, 1979, 'Français', 'Star Wars: L''Empire Contre-Attaq', '2011-01-14'),
(11, 1, 2010, 'Français', 'Inception', '2011-01-14'),
(12, 1, 2001, 'Français', 'La Chute du Faucon Noir', '2011-01-14'),
(13, 1, 2009, 'Français', 'X-Men Origins: Wolverine', '2011-01-14'),
(14, 1, 2008, 'Français', 'Bienvenue chez les Ch''tis', '2011-03-09');

-- --------------------------------------------------------

--
-- Structure de la table `livre`
--

CREATE TABLE IF NOT EXISTS `livre` (
  `CODE_ELEMENT` int(2) NOT NULL AUTO_INCREMENT,
  `NOM_AUTEUR` char(32) DEFAULT NULL,
  `NOMBRE_PAGES` int(4) DEFAULT NULL,
  `NOM_ELEMENT` char(32) DEFAULT NULL,
  `DATE_AJOUT` date DEFAULT NULL,
  PRIMARY KEY (`CODE_ELEMENT`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Contenu de la table `livre`
--

INSERT INTO `livre` (`CODE_ELEMENT`, `NOM_AUTEUR`, `NOMBRE_PAGES`, `NOM_ELEMENT`, `DATE_AJOUT`) VALUES
(1, 'JRR Tolkien', 800, 'LSDA La Communauté de l''Anneau', '2011-01-14'),
(2, 'JRR Tolkien', 800, 'LSDA Les 2 Tours', '2011-01-14'),
(3, 'JRR Tolkien', 800, 'LSDA Le Retour du Roi', '2011-01-14'),
(7, 'Site du Zéro', 2000, 'C++', '2011-03-24'),
(8, 'Site du Zéro', 17, 'PHP', '2011-04-07'),
(10, 'Site du Zéro', 200, 'C#', '2011-04-13');

-- --------------------------------------------------------

--
-- Structure de la table `typemedia`
--

CREATE TABLE IF NOT EXISTS `typemedia` (
  `CODE_TYPE` int(2) NOT NULL AUTO_INCREMENT,
  `LIBELLE_TYPE` char(32) DEFAULT NULL,
  PRIMARY KEY (`CODE_TYPE`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `typemedia`
--

INSERT INTO `typemedia` (`CODE_TYPE`, `LIBELLE_TYPE`) VALUES
(1, 'DVD'),
(2, 'K7'),
(3, 'Blu-ray');
