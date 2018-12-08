-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  sam. 08 déc. 2018 à 16:51
-- Version du serveur :  10.1.31-MariaDB
-- Version de PHP :  5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

--
-- Base de données :  `lagestiondecoursespourlesnuls`
--
CREATE DATABASE IF NOT EXISTS `lagestiondecoursespourlesnuls` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin;
USE `lagestiondecoursespourlesnuls`;

-- --------------------------------------------------------

--
-- Structure de la table `coureur`
--

DROP TABLE IF EXISTS `coureur`;
CREATE TABLE IF NOT EXISTS `coureur` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `annee` int(11) NOT NULL,
  `courriel` varchar(256) COLLATE utf8_bin NOT NULL,
  `nom` varchar(256) COLLATE utf8_bin NOT NULL,
  `prenom` varchar(256) COLLATE utf8_bin NOT NULL,
  `sexe` char(1) COLLATE utf8_bin NOT NULL,
  `noLicenceFFA` varchar(30) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Structure de la table `course`
--

DROP TABLE IF EXISTS `course`;
CREATE TABLE IF NOT EXISTS `course` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(256) COLLATE utf8_bin NOT NULL,
  `Annee` smallint(4) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Structure de la table `participation`
--

DROP TABLE IF EXISTS `participation`;
CREATE TABLE IF NOT EXISTS `participation` (
  `course` int(11) NOT NULL,
  `coureur` int(11) NOT NULL,
  `allureMoyenne` double NOT NULL,
  `numeroDossard` int(11) NOT NULL,
  `temps` varchar(10) COLLATE utf8_bin NOT NULL,
  `vitesseMoyenne` double NOT NULL,
  PRIMARY KEY (`course`,`coureur`),
  KEY `coureur` (`coureur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(100) COLLATE utf8_bin NOT NULL,
  `motDePasse` varchar(255) COLLATE utf8_bin NOT NULL,
  `courriel` varchar(255) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nom` (`nom`),
  UNIQUE KEY `courriel` (`courriel`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `participation`
--
ALTER TABLE `participation`
  ADD CONSTRAINT `participation_ibfk_1` FOREIGN KEY (`course`) REFERENCES `course` (`id`),
  ADD CONSTRAINT `participation_ibfk_2` FOREIGN KEY (`coureur`) REFERENCES `coureur` (`id`);
COMMIT;
