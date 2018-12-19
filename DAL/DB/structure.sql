DROP TABLE IF EXISTS `coureur`;
CREATE TABLE `coureur` (
  `id` int(11) NOT NULL,
  `prenom` varchar(100) COLLATE utf8_bin NOT NULL,
  `nom` varchar(100) COLLATE utf8_bin NOT NULL,
  `sexe` char(1) COLLATE utf8_bin NOT NULL,
  `date_naissance` date NOT NULL,
  `courriel` varchar(256) COLLATE utf8_bin DEFAULT NULL,
  `licence_ffa` char(8) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

DROP TABLE IF EXISTS `course`;
CREATE TABLE `course` (
  `id` int(11) NOT NULL,
  `nom` varchar(256) COLLATE utf8_bin NOT NULL,
  `distance` double NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

DROP TABLE IF EXISTS `participation`;
CREATE TABLE `participation` (
  `id` int(11) NOT NULL,
  `course` int(11) NOT NULL,
  `coureur` int(11) NOT NULL,
  `temps` varchar(8) COLLATE utf8_bin NOT NULL,
  `numero_dossard` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE `utilisateur` (
  `id` int(11) NOT NULL,
  `prenom` varchar(100) COLLATE utf8_bin NOT NULL,
  `nom` varchar(100) COLLATE utf8_bin NOT NULL,
  `courriel` varchar(255) COLLATE utf8_bin NOT NULL,
  `mot_de_passe` varchar(255) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

ALTER TABLE `coureur`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `licence_ffa` (`licence_ffa`);

ALTER TABLE `course`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `participation`
  ADD PRIMARY KEY (`id`),
  ADD KEY `participation_ibfk_1` (`course`),
  ADD KEY `participation_ibfk_2` (`coureur`);

ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nom` (`nom`),
  ADD UNIQUE KEY `courriel` (`courriel`);


ALTER TABLE `coureur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

ALTER TABLE `course`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

ALTER TABLE `participation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

ALTER TABLE `utilisateur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;


ALTER TABLE `participation`
  ADD CONSTRAINT `participation_ibfk_1` FOREIGN KEY (`course`) REFERENCES `course` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `participation_ibfk_2` FOREIGN KEY (`coureur`) REFERENCES `coureur` (`id`) ON DELETE CASCADE;
COMMIT;

GRANT USAGE ON *.* TO 'nulos'@'localhost' IDENTIFIED BY PASSWORD '*D189472C6E132B03A74616FC405BE58B0321C095';

GRANT ALL PRIVILEGES ON `lagestiondecoursespourlesnuls`.* TO 'nulos'@'localhost' WITH GRANT OPTION;