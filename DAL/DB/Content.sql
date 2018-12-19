INSERT INTO `coureur` (`id`, `prenom`, `nom`, `sexe`, `date_naissance`, `courriel`, `licence_ffa`) VALUES
(1, 'Rime', 'Haddad', 'F', '1996-06-19', 'rhaddad@ensc.fr', '1234567A'),
(2, 'Roman', 'Rieunier', 'M', '1997-09-22', 'rrieunier@ensc.fr', '7894561B'),
(4, 'Maxime', 'Adolphe', 'M', '1997-02-27', 'madolphe@ensc.fr', '5338940L');

INSERT INTO `course` (`id`, `nom`, `distance`, `date`) VALUES
(1, 'Rallye des apparts', 5.2, '2017-12-08'),
(2, 'Marathon de Bordeaux', 42.2, '2019-04-29');

INSERT INTO `participation` (`id`, `course`, `coureur`, `temps`, `numero_dossard`) VALUES
(1, 2, 1, '02:23:54', 455651),
(2, 1, 1, '4:35:56', 123),
(3, 1, 2, '4:36:24', 122),
(7, 1, 4, '01:23:22', 535353);

INSERT INTO `utilisateur` (`id`, `prenom`, `nom`, `courriel`, `mot_de_passe`) VALUES
(1, 'Roman', 'Rieunier', 'rrieunier@ensc.fr', 'rider'),
(2, 'Baptiste', 'Pesquet', 'bpesquet@ensc.fr', 'visual_studio'),
(3, 'Rime', 'Haddad', 'rhaddad@ensc.fr', 'jenerentrepasdansceconflit');

