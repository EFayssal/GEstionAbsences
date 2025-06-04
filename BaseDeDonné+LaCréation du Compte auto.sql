-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 03 juin 2025 à 19:55
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestion_absences`
--
CREATE DATABASE IF NOT EXISTS `gestion_absences` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `gestion_absences`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idabsence` int NOT NULL AUTO_INCREMENT,
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idabsence`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=63 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idabsence`, `idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(1, 1, '2024-01-05 00:00:00', '2024-01-07 00:00:00', 2),
(2, 4, '2024-02-10 00:00:00', '2024-02-14 00:00:00', 1),
(3, 7, '2024-03-20 00:00:00', '2024-03-22 00:00:00', 3),
(4, 2, '2024-04-01 00:00:00', '2024-04-03 00:00:00', 4),
(5, 9, '2024-05-15 00:00:00', '2024-05-18 00:00:00', 2),
(6, 5, '2024-12-20 00:00:00', '2024-12-25 00:00:00', 1),
(7, 1, '2024-01-01 00:00:00', '2024-01-02 00:00:00', 1),
(8, 2, '2024-01-08 00:00:00', '2024-01-10 00:00:00', 2),
(9, 3, '2024-01-15 00:00:00', '2024-01-18 00:00:00', 3),
(10, 4, '2024-01-22 00:00:00', '2024-01-26 00:00:00', 4),
(11, 5, '2024-01-29 00:00:00', '2024-02-03 00:00:00', 1),
(12, 6, '2024-02-05 00:00:00', '2024-02-11 00:00:00', 2),
(13, 7, '2024-02-12 00:00:00', '2024-02-19 00:00:00', 3),
(14, 8, '2024-02-19 00:00:00', '2024-02-27 00:00:00', 4),
(15, 9, '2024-02-26 00:00:00', '2024-03-06 00:00:00', 1),
(16, 10, '2024-03-04 00:00:00', '2024-03-14 00:00:00', 2),
(17, 1, '2024-03-11 00:00:00', '2024-03-12 00:00:00', 3),
(18, 2, '2024-03-18 00:00:00', '2024-03-20 00:00:00', 4),
(19, 3, '2024-03-25 00:00:00', '2024-03-28 00:00:00', 1),
(20, 4, '2024-04-01 00:00:00', '2024-04-05 00:00:00', 2),
(21, 5, '2024-04-08 00:00:00', '2024-04-13 00:00:00', 3),
(22, 6, '2024-04-15 00:00:00', '2024-04-21 00:00:00', 4),
(23, 7, '2024-04-22 00:00:00', '2024-04-29 00:00:00', 1),
(24, 8, '2024-04-29 00:00:00', '2024-05-07 00:00:00', 2),
(25, 9, '2024-05-06 00:00:00', '2024-05-15 00:00:00', 3),
(26, 10, '2024-05-13 00:00:00', '2024-05-23 00:00:00', 4),
(27, 1, '2024-05-20 00:00:00', '2024-05-21 00:00:00', 1),
(28, 2, '2024-05-27 00:00:00', '2024-05-29 00:00:00', 2),
(29, 3, '2024-06-03 00:00:00', '2024-06-06 00:00:00', 3),
(30, 4, '2024-06-10 00:00:00', '2024-06-14 00:00:00', 4),
(31, 5, '2024-06-17 00:00:00', '2024-06-22 00:00:00', 1),
(32, 6, '2024-06-24 00:00:00', '2024-06-30 00:00:00', 2),
(33, 7, '2024-07-01 00:00:00', '2024-07-08 00:00:00', 3),
(34, 8, '2024-07-08 00:00:00', '2024-07-16 00:00:00', 4),
(35, 9, '2024-07-15 00:00:00', '2024-07-24 00:00:00', 1),
(36, 10, '2024-07-22 00:00:00', '2024-08-01 00:00:00', 2),
(37, 1, '2024-07-29 00:00:00', '2024-07-30 00:00:00', 3),
(38, 2, '2024-08-05 00:00:00', '2024-08-07 00:00:00', 4),
(39, 3, '2024-08-12 00:00:00', '2024-08-15 00:00:00', 1),
(40, 4, '2024-08-19 00:00:00', '2024-08-23 00:00:00', 2),
(41, 5, '2024-08-26 00:00:00', '2024-08-31 00:00:00', 3),
(42, 6, '2024-09-02 00:00:00', '2024-09-08 00:00:00', 4),
(43, 7, '2024-09-09 00:00:00', '2024-09-16 00:00:00', 1),
(44, 8, '2024-09-16 00:00:00', '2024-09-24 00:00:00', 2),
(45, 9, '2024-09-23 00:00:00', '2024-10-02 00:00:00', 3),
(46, 10, '2024-09-30 00:00:00', '2024-10-10 00:00:00', 4),
(47, 1, '2024-10-07 00:00:00', '2024-10-08 00:00:00', 1),
(48, 2, '2024-10-14 00:00:00', '2024-10-16 00:00:00', 2),
(49, 3, '2024-10-21 00:00:00', '2024-10-24 00:00:00', 3),
(50, 4, '2024-10-28 00:00:00', '2024-11-01 00:00:00', 4),
(51, 5, '2024-11-04 00:00:00', '2024-11-09 00:00:00', 1),
(52, 6, '2024-11-11 00:00:00', '2024-11-17 00:00:00', 2),
(53, 7, '2024-11-18 00:00:00', '2024-11-25 00:00:00', 3),
(54, 8, '2024-11-25 00:00:00', '2024-12-03 00:00:00', 4),
(55, 9, '2024-12-02 00:00:00', '2024-12-11 00:00:00', 1),
(56, 10, '2024-12-09 00:00:00', '2024-12-19 00:00:00', 2),
(62, 14, '2025-06-09 00:00:00', '2025-06-13 00:00:00', 1),
(60, 2, '2025-06-03 00:00:00', '2025-06-05 00:00:00', 0);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Dupont', 'Alice', '0601020304', 'jean.dupont@example.com', 1),
(2, 'Durand', 'Bruno', '0605060708', 'marie.durand@example.com', 2),
(3, 'Martin', 'Claire', '0610101010', 'paul.moreau@example.com', 3),
(4, 'Petit', 'David', '0623456789', 'emma.leclerc@example.com', 1),
(5, 'Leroy', 'Émilie', '0634567890', 'luc.martin@example.com', 2),
(6, 'Moreau', 'François', '0645678901', 'sophie.lambert@example.com', 3),
(7, 'Simon', 'Gabrielle', '0656789012', 'thomas.robert@example.com', 1),
(8, 'Laurent', 'Hugo', '0667890123', 'julie.giraud@example.com', 2),
(9, 'Michel', 'Isabelle', '0678901234', 'nicolas.benoit@example.com', 3),
(10, 'Garcia', 'Julien', '0689012345', 'camille.perrin@example.com', 1),
(14, 'Github', 'Teste', '07 59 44 86 75 ', 'Test@Github.com', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(50) NOT NULL,
  `pwd` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`login`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('resp_app', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),
('fayssal', '9af15b336e6a9619928537df30b2e6a2376569fcf9d7e773eccede65606529a0');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
--
-- Base de données : `habilitations`
--
CREATE DATABASE IF NOT EXISTS `habilitations` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE `habilitations`;

-- --------------------------------------------------------
-- Création de l'utilisateur et attribution des droits
CREATE USER 'resp_app2'@'localhost' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON gestion_absences2.* TO 'resp_app'@'localhost';
FLUSH PRIVILEGES;
--
-- Structure de la table `developpeur`
--

DROP TABLE IF EXISTS `developpeur`;
CREATE TABLE IF NOT EXISTS `developpeur` (
  `iddeveloppeur` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `pwd` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idprofil` int NOT NULL,
  PRIMARY KEY (`iddeveloppeur`),
  KEY `idprofil` (`idprofil`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `developpeur`
--

INSERT INTO `developpeur` (`iddeveloppeur`, `nom`, `prenom`, `tel`, `mail`, `pwd`, `idprofil`) VALUES
(1, 'Nolan', 'Rooney', '09 65 36 85 44', 'Vivamus.non@egestasSedpharetra.org', '71f90b7c03aad530eafa769b2ad97cb333ca6dd455fce1080bc0b302e4231220', 5),
(2, 'Good', 'Lucy', '03 03 67 71 47', 'a.scelerisque@NullafacilisiSed.org', 'c939327ca16dcf97ca32521d8b834bf1de16573d21deda3bb2a337cf403787a6', 2),
(3, 'Blevins', 'Abel', '06 21 51 89 92', 'ipsum.Phasellus@sociosqu.edu', '3b17e2b513a94fc551bcaa6f8abba00f4cb52db9f5828689b8f8fefd9aaaba48', 3),
(4, 'Levine', 'Ira', '02 04 78 08 64', 'ridiculus.mus@ligulaelitpretium.net', '3a0eb3ea56e7f5e8f6f87aa9710717f8f0330060f8517b4249dab182d9b9d9c8', 2),
(5, 'Bailey', 'Burton', '09 70 53 44 50', 'Nunc.commodo.auctor@sollicitudinorci.org', 'ceb32b93931ce2ef0af1fcefb67c2e5ea38d67d3fb9424c53d53a0688381636f', 1),
(6, 'Delacruz', 'Owen', '04 60 51 48 15', 'in.aliquet@risusodio.edu', '6bf96b25f549f6dc3ef7f491c7ed763357a9baae5f392dfa0bb5b5c92747b954', 3),
(7, 'Garza', 'Jillian', '08 86 47 61 67', 'sem.eget.massa@hendreritconsectetuer.org', '2d49cda934944bfb136364f82d151585edfe3a78c9c988da451ea12a56fb956c', 4),
(8, 'West', 'Quintessa', '02 70 51 65 26', 'morbi.tristique@neque.net', '41a6741e9a0faee34fec1fce082d6c634d48b44aee0d15bee819d12917073df8', 1),
(9, 'Booth', 'Ryder', '08 53 71 05 71', 'porttitor.tellus@risusvariusorci.net', '59a286a9bbb686814b08ffc09917162dd03cafd0f90982a7d37abbbd809a9e7e', 3),
(10, 'Blackwell', 'Martena', '08 94 29 37 55', 'pellentesque@NulladignissimMaecenas.net', '1d39692d4ee10540bc02074e58a7fedcf00ec356a3f19ccd6d909bd9370394a8', 2),
(11, 'Paul', 'Harding', '02 79 83 05 14', 'placerat.augue.Sed@Donecfelis.edu', '818b5cc5f21d3e6e4e6071c06294528d44595022218446d8b79304d2b766327a', 1),
(12, 'Justice', 'Hamilton', '05 12 98 01 13', 'eros@sedpede.net', '5f9740dd7874801f460dfe0f92e5be0cf2cfd04088d7d5ab996c92a428d3ee8b', 5),
(13, 'Lawson', 'Yolanda', '05 69 69 73 20', 'elit@laciniaorci.edu', '9950fd2c5b1854dcf27d5f1c8cfcec3563c57694ba3ce6e4c3871c22836f8a50', 1),
(14, 'Moon', 'Kaseem', '09 46 08 25 44', 'auctor@eu.edu', '5fc165254f4f817ba6f8b6f80c08b3174c0fea225398b5b84c17c0af975feacf', 1),
(15, 'Solis', 'Justine', '03 82 07 14 43', 'penatibus@Utnec.co.uk', '7fc5e56ec97a6943a8e656a0b2480b92ed6bd25c8da6ec1775220ef925d79b7c', 4),
(16, 'Stuart', 'Ingrid', '09 29 08 45 60', 'consectetuer.adipiscing@eget.edu', '74452134eb5884242a688cd5214e50595e950b8ac83de37d4c75ff7582b5a798', 3),
(17, 'Barr', 'Wanda', '05 49 47 03 82', 'odio@Crasdolor.org', 'c0e17070d53e6b3362fa17221c1d501f7d7a76cacf69174d0a312a8159be6471', 4),
(18, 'Parker', 'Brooke', '05 33 06 99 16', 'dui@ipsumcursus.co.uk', '92039f1a7ad82575787e314975b24ac559b72031e5b7f84702e75821225f2929', 5),
(19, 'Valentine', 'Clinton', '05 08 28 27 67', 'id@atfringillapurus.edu', 'cef5c43e526793983cbd17f5c53ab76e48dc92584a83cbfa63820e82190fd8a5', 5),
(20, 'Hendrix', 'Christian', '08 09 24 53 25', 'Nunc.quis@tinciduntDonec.ca', '0ceec16c3d3170168bd3acfd48748d95eb98992c15399cd9a495ec2212f71bc2', 1);

-- --------------------------------------------------------

--
-- Structure de la table `fonctionnalite`
--

DROP TABLE IF EXISTS `fonctionnalite`;
CREATE TABLE IF NOT EXISTS `fonctionnalite` (
  `idfonctionnalite` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idfonctionnalite`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `fonctionnalite`
--

INSERT INTO `fonctionnalite` (`idfonctionnalite`, `nom`) VALUES
(1, 'CSS'),
(2, 'HTML'),
(3, 'JavaScript'),
(4, 'PHP');

-- --------------------------------------------------------

--
-- Structure de la table `habilitation`
--

DROP TABLE IF EXISTS `habilitation`;
CREATE TABLE IF NOT EXISTS `habilitation` (
  `idfonctionnalite` int NOT NULL,
  `idoperation` int NOT NULL,
  `idprofil` int NOT NULL,
  PRIMARY KEY (`idfonctionnalite`,`idoperation`,`idprofil`),
  KEY `idoperation` (`idoperation`),
  KEY `idprofil` (`idprofil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `habilitation`
--

INSERT INTO `habilitation` (`idfonctionnalite`, `idoperation`, `idprofil`) VALUES
(1, 1, 1),
(1, 1, 2),
(1, 1, 3),
(1, 1, 4),
(2, 1, 1),
(2, 1, 2),
(2, 1, 3),
(2, 1, 4),
(3, 1, 1),
(3, 1, 2),
(3, 1, 3),
(3, 1, 4),
(4, 1, 1),
(4, 1, 2),
(4, 1, 3),
(4, 1, 4),
(1, 2, 2),
(1, 2, 3),
(2, 2, 3),
(2, 2, 4),
(3, 2, 3),
(3, 2, 4),
(4, 2, 4),
(1, 3, 5),
(2, 3, 5),
(3, 3, 5),
(4, 3, 5);

-- --------------------------------------------------------

--
-- Structure de la table `operation`
--

DROP TABLE IF EXISTS `operation`;
CREATE TABLE IF NOT EXISTS `operation` (
  `idoperation` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idoperation`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `operation`
--

INSERT INTO `operation` (`idoperation`, `nom`) VALUES
(1, 'consulter'),
(2, 'modifier'),
(3, 'administrer');

-- --------------------------------------------------------

--
-- Structure de la table `profil`
--

DROP TABLE IF EXISTS `profil`;
CREATE TABLE IF NOT EXISTS `profil` (
  `idprofil` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idprofil`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `profil`
--

INSERT INTO `profil` (`idprofil`, `nom`) VALUES
(1, 'stagiaire'),
(2, 'designer'),
(3, 'dev-front'),
(4, 'dev-back'),
(5, 'admin');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
