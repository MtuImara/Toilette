-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 24, 2022 at 04:41 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bd_toilette`
--

-- --------------------------------------------------------

--
-- Table structure for table `caisse`
--

CREATE TABLE `caisse` (
  `id_caisse` int(11) NOT NULL,
  `numero` varchar(100) DEFAULT NULL,
  `montant` double DEFAULT NULL,
  `date_heure` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `montantRetourne` double DEFAULT NULL,
  `user` varchar(100) NOT NULL,
  `sorte` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `caisse`
--

INSERT INTO `caisse` (`id_caisse`, `numero`, `montant`, `date_heure`, `montantRetourne`, `user`, `sorte`) VALUES
(72, 'U1', 500, '2021-06-09 20:34:11', 0, 'Ngabe', 'urinoire'),
(73, 'U1', 500, '2021-06-09 20:35:20', 0, 'Ngabe', 'urinoire'),
(74, 't1', 500, '2021-06-10 14:54:06', 0, 'Imara', 'Toilette'),
(75, 'T0', 500, '2021-06-10 14:54:20', 0, 'Imara', 'Urinoire'),
(76, 't3', 500, '2021-06-10 15:02:30', 0, 'Imara', 'Toilette'),
(77, 't3', 500, '2021-06-10 15:02:44', 0, 'Imara', 'Toilette'),
(78, 't2', 500, '2021-06-10 15:19:01', 0, 'Imara', 'Toilette'),
(79, 'U1', 500, '2021-06-11 09:52:50', 0, 'kab', 'urinoire'),
(80, 'T2000', 500, '2021-11-15 13:03:59', 0, 'Nad', 'Toilette'),
(81, 'T2000', 500, '2021-11-25 12:12:00', 0, 'bobj', 'Toilette'),
(82, 't3', 500, '2022-02-16 12:09:08', 0, 'imara', 'Toilette'),
(83, 't2', 500, '2022-03-17 17:31:59', 0, 'Toilette', 'Toilette'),
(84, 't1', 500, '2022-03-17 17:33:41', 0, 'imara', 'Toilette');

-- --------------------------------------------------------

--
-- Table structure for table `depense`
--

CREATE TABLE `depense` (
  `id_depense` int(11) NOT NULL,
  `montant_sortie` double DEFAULT NULL,
  `nom_utilisateur` text DEFAULT NULL,
  `motif` text DEFAULT NULL,
  `date_sortie` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `echec` text DEFAULT NULL,
  `user` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `depense`
--

INSERT INTO `depense` (`id_depense`, `montant_sortie`, `nom_utilisateur`, `motif`, `date_sortie`, `echec`, `user`) VALUES
(1, 535, 'hhj', 'bnn', '2021-04-19 21:11:38', 'Echec', ''),
(2, 5000, 'kab', 'jus', '2021-05-09 18:31:02', NULL, ''),
(3, 10000, 'chef', 'bus', '2021-05-09 18:45:57', NULL, 'ngabe'),
(4, 5000, 'ghj', 'produit nettoyage', '2021-05-15 09:34:43', 'Echec', 'lionel '),
(5, 600, 'admin princ', 'fanta', '2021-05-15 21:05:15', NULL, 'j'),
(6, 200, 'admin princ', 'Soda', '2021-11-15 13:08:44', 'Echec', 'Nad');

-- --------------------------------------------------------

--
-- Table structure for table `site`
--

CREATE TABLE `site` (
  `id_site` int(11) NOT NULL,
  `nom` text DEFAULT NULL,
  `localisation` text DEFAULT NULL,
  `quartier` text DEFAULT NULL,
  `user` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `site`
--

INSERT INTO `site` (`id_site`, `nom`, `localisation`, `quartier`, `user`) VALUES
(1, 'Lushi', 'Ibanda', 'Centre', ''),
(2, 'kasapa', 'lingwala', 'lumumba', 'imara'),
(3, 'marche express', 'kampemba', 'express', 'lionel '),
(4, 'Kavumu', 'Ntahangwa', 'Songa', 'Nad');

-- --------------------------------------------------------

--
-- Table structure for table `toilette`
--

CREATE TABLE `toilette` (
  `id_toilette` int(11) NOT NULL,
  `numero` varchar(100) DEFAULT NULL,
  `site` text DEFAULT NULL,
  `etat` varchar(100) DEFAULT NULL,
  `prix` double DEFAULT NULL,
  `type` varchar(100) DEFAULT NULL,
  `user` varchar(100) NOT NULL,
  `sorte` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `toilette`
--

INSERT INTO `toilette` (`id_toilette`, `numero`, `site`, `etat`, `prix`, `type`, `user`, `sorte`) VALUES
(1, 'T0', 'Lushi', 'Libre', 500, 'Homme', 'chris', 'Urinoire'),
(2, 't2', 'Lushi', 'Occupee', 500, 'Femme', '', 'Toilette'),
(3, 't1', 'Lushi', 'Occupee', 500, 'Homme', '', 'Toilette'),
(4, 't3', 'Lushi', 'Occupee', 500, 'Homme', 'imara', 'Toilette'),
(5, '01', 'marche express', 'Libre', 500, 'Homme', 'lionel ', 'Urinoire'),
(6, 'U1', 'marche express', 'Occupee', 500, 'Homme', 'gh', 'urinoire'),
(7, 'T2000', 'Kavumu', 'Occupee', 500, 'Femme', 'Nad', 'Toilette');

-- --------------------------------------------------------

--
-- Table structure for table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `id_utilisateur` int(11) NOT NULL,
  `nom` text DEFAULT NULL,
  `prenom` text DEFAULT NULL,
  `login` varchar(100) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `statut` varchar(100) DEFAULT NULL,
  `user` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `utilisateur`
--

INSERT INTO `utilisateur` (`id_utilisateur`, `nom`, `prenom`, `login`, `password`, `statut`, `user`) VALUES
(1, 'imara', NULL, 'imara', '00', NULL, ''),
(2, 'ngabe', 'christian', 'admin', 'admin', 'chef', ''),
(3, 'ngabe K', 'chris', 'admin princ', 'admin', 'chef', ''),
(4, 'Gerard', 't', 'Gt', '000', 'chef', 'imara'),
(5, 'Bob', 'junior', 'bobj', '000', 'sec', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `caisse`
--
ALTER TABLE `caisse`
  ADD PRIMARY KEY (`id_caisse`);

--
-- Indexes for table `depense`
--
ALTER TABLE `depense`
  ADD PRIMARY KEY (`id_depense`);

--
-- Indexes for table `site`
--
ALTER TABLE `site`
  ADD PRIMARY KEY (`id_site`);

--
-- Indexes for table `toilette`
--
ALTER TABLE `toilette`
  ADD PRIMARY KEY (`id_toilette`),
  ADD UNIQUE KEY `unique_et` (`numero`);

--
-- Indexes for table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`id_utilisateur`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `caisse`
--
ALTER TABLE `caisse`
  MODIFY `id_caisse` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=85;

--
-- AUTO_INCREMENT for table `depense`
--
ALTER TABLE `depense`
  MODIFY `id_depense` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `site`
--
ALTER TABLE `site`
  MODIFY `id_site` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `toilette`
--
ALTER TABLE `toilette`
  MODIFY `id_toilette` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `id_utilisateur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
