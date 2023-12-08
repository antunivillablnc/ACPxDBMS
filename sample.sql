-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 07, 2023 at 07:25 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sample`
--

-- --------------------------------------------------------

--
-- Table structure for table `agents`
--

CREATE TABLE `agents` (
  `agentID` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `gender` char(1) NOT NULL,
  `contact_info` varchar(20) NOT NULL,
  `commission_rate` decimal(10,2) NOT NULL,
  `username` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `DateCreated` varchar(50) NOT NULL DEFAULT current_timestamp(),
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `agents`
--

INSERT INTO `agents` (`agentID`, `name`, `gender`, `contact_info`, `commission_rate`, `username`, `password`, `DateCreated`, `LastLogin`) VALUES
(0, 'admin', 'M', '6789', 0.00, 'admin', 'admin123', '2023-11-17 10:53:31', '05/12/2023 11:02:16 pm'),
(1, 'Anthony Villablanca', 'M', '9634044841', 30.00, 'antunivillablnc', 'twice', '2023-11-17 16:09:47', '05/12/2023 10:56:51 pm'),
(2, 'Brian Neil Babasa ', 'M', '9568570645', 30.00, 'brian', 'babasa', '2023-11-17 17:42:00', '19/11/2023 8:00:25 am'),
(3, 'Joshua Almario', 'M', '9615751075', 30.00, 'joshua', 'almario', '2023-11-17 17:51:03', '19/11/2023 8:02:11 am');

-- --------------------------------------------------------

--
-- Table structure for table `buyers`
--

CREATE TABLE `buyers` (
  `buyerID` int(11) NOT NULL,
  `address` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `contact_number` int(11) NOT NULL,
  `budget` decimal(20,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `buyers`
--

INSERT INTO `buyers` (`buyerID`, `address`, `name`, `contact_number`, `budget`) VALUES
(1, 'Rosario', 'Jojo', 2147483647, 500000.00),
(2, 'Rosario', 'Anthony Villablanca', 2147483647, 123.00);

-- --------------------------------------------------------

--
-- Table structure for table `contracts`
--

CREATE TABLE `contracts` (
  `contractID` int(11) NOT NULL,
  `transactionID` int(11) DEFAULT NULL,
  `terms_and_conditions` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `properties`
--

CREATE TABLE `properties` (
  `propertyID` int(11) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `type_of_property` varchar(100) NOT NULL,
  `size_of_property` int(11) NOT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `properties`
--

INSERT INTO `properties` (`propertyID`, `Address`, `type_of_property`, `size_of_property`, `price`) VALUES
(1, 'Rosario, Batangas', 'Residential', 300, 500000),
(2, 'itlugan', 'resi', 12312313, 123123123),
(3, 'calamba', 'pool', 1234, 123);

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `transactionID` int(11) NOT NULL,
  `propertyID` int(11) DEFAULT NULL,
  `buyerID` int(11) DEFAULT NULL,
  `agentID` int(11) DEFAULT NULL,
  `transaction_date` date NOT NULL DEFAULT current_timestamp(),
  `transactionamount` decimal(20,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`transactionID`, `propertyID`, `buyerID`, `agentID`, `transaction_date`, `transactionamount`) VALUES
(1, 1, 1, 1, '2023-12-05', 500.00),
(2, 2, 1, 1, '2023-12-05', 123123123.00),
(3, 3, 2, 2, '2023-12-05', 123.00);

-- --------------------------------------------------------

--
-- Table structure for table `visits`
--

CREATE TABLE `visits` (
  `visitID` int(11) NOT NULL,
  `propertyID` int(11) DEFAULT NULL,
  `visitor_name` varchar(255) NOT NULL,
  `agentID` int(11) DEFAULT NULL,
  `visit_date` date NOT NULL DEFAULT current_timestamp(),
  `feedback` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `agents`
--
ALTER TABLE `agents`
  ADD PRIMARY KEY (`agentID`);

--
-- Indexes for table `buyers`
--
ALTER TABLE `buyers`
  ADD PRIMARY KEY (`buyerID`);

--
-- Indexes for table `contracts`
--
ALTER TABLE `contracts`
  ADD PRIMARY KEY (`contractID`),
  ADD KEY `transactionID` (`transactionID`);

--
-- Indexes for table `properties`
--
ALTER TABLE `properties`
  ADD PRIMARY KEY (`propertyID`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`transactionID`),
  ADD KEY `propertyID` (`propertyID`),
  ADD KEY `buyerID` (`buyerID`),
  ADD KEY `agentID` (`agentID`);

--
-- Indexes for table `visits`
--
ALTER TABLE `visits`
  ADD PRIMARY KEY (`visitID`),
  ADD KEY `visits_ibfk_1` (`propertyID`),
  ADD KEY `visits_ibfk_2` (`agentID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `contracts`
--
ALTER TABLE `contracts`
  ADD CONSTRAINT `contracts_ibfk_1` FOREIGN KEY (`transactionID`) REFERENCES `transactions` (`transactionID`),
  ADD CONSTRAINT `transactionID` FOREIGN KEY (`transactionID`) REFERENCES `transactions` (`transactionID`) ON DELETE CASCADE;

--
-- Constraints for table `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `agentID` FOREIGN KEY (`agentID`) REFERENCES `agents` (`agentID`) ON DELETE CASCADE,
  ADD CONSTRAINT `buyerID` FOREIGN KEY (`buyerID`) REFERENCES `buyers` (`buyerID`) ON DELETE CASCADE,
  ADD CONSTRAINT `propertyID` FOREIGN KEY (`propertyID`) REFERENCES `properties` (`propertyID`) ON DELETE CASCADE,
  ADD CONSTRAINT `transactions_ibfk_1` FOREIGN KEY (`propertyID`) REFERENCES `properties` (`propertyID`),
  ADD CONSTRAINT `transactions_ibfk_2` FOREIGN KEY (`buyerID`) REFERENCES `buyers` (`buyerID`),
  ADD CONSTRAINT `transactions_ibfk_3` FOREIGN KEY (`agentID`) REFERENCES `agents` (`agentID`);

--
-- Constraints for table `visits`
--
ALTER TABLE `visits`
  ADD CONSTRAINT `visits_ibfk_1` FOREIGN KEY (`propertyID`) REFERENCES `properties` (`propertyID`) ON DELETE CASCADE,
  ADD CONSTRAINT `visits_ibfk_2` FOREIGN KEY (`agentID`) REFERENCES `agents` (`agentID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
