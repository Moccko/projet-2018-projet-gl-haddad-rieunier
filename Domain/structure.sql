-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  lun. 19 nov. 2018 à 11:51
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
CREATE TABLE `coureur` (
  `id` int(11) NOT NULL,
  `annee` int(11) NOT NULL,
  `courriel` varchar(256) COLLATE utf8_bin NOT NULL,
  `nom` varchar(256) COLLATE utf8_bin NOT NULL,
  `prenom` varchar(256) COLLATE utf8_bin NOT NULL,
  `sexe` char(1) COLLATE utf8_bin NOT NULL,
  `noLicenceFFA` char(255) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Structure de la table `course`
--

DROP TABLE IF EXISTS `course`;
CREATE TABLE `course` (
  `id` int(11) NOT NULL,
  `Annee` smallint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Structure de la table `participation`
--

DROP TABLE IF EXISTS `participation`;
CREATE TABLE `participation` (
  `course` int(11) NOT NULL,
  `coureur` int(11) NOT NULL,
  `allureMoyenne` double NOT NULL,
  `numeroDeDossard` int(11) NOT NULL,
  `temps` varchar(10) COLLATE utf8_bin NOT NULL,
  `vitesseMoyenne` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE `utilisateur` (
  `id` int(11) NOT NULL,
  `motDePasse` varchar(255) COLLATE utf8_bin NOT NULL,
  `courriel` varchar(255) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `coureur`
--
ALTER TABLE `coureur`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `participation`
--
ALTER TABLE `participation`
  ADD PRIMARY KEY (`course`,`coureur`),
  ADD KEY `coureur` (`coureur`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `coureur`
--
ALTER TABLE `coureur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `course`
--
ALTER TABLE `course`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `participation`
--
ALTER TABLE `participation`
  ADD CONSTRAINT `participation_ibfk_1` FOREIGN KEY (`course`) REFERENCES `course` (`Id`),
  ADD CONSTRAINT `participation_ibfk_2` FOREIGN KEY (`coureur`) REFERENCES `coureur` (`id`);
COMMIT;
