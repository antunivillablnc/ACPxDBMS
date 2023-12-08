-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 08, 2023 at 03:53 PM
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
(0, 'admin', 'M', '6789', 0.00, 'HomeSeeker', 'Group3', '2023-11-17 10:53:31', '08/12/2023 12:12:39 pm'),
(1, 'Anthony Villablanca', 'M', '9634044841', 30.00, 'antunivillablnc', 'twice', '2023-11-17 16:09:47', '08/12/2023 10:46:39 pm'),
(2, 'Brian Neil Babasa ', 'M', '9568570645', 30.00, 'brian', 'babasa', '2023-11-17 17:42:00', '19/11/2023 8:00:25 am'),
(3, 'Joshua Almario', 'M', '9615751075', 30.00, 'joshua', 'almario', '2023-11-17 17:51:03', '19/11/2023 8:02:11 am'),
(4, 'Juan Dela Cruz', 'M', '09235467812', 30.00, 'Juan', 'Juanforall', '2023-12-08 21:14:24', '08/12/2023 10:16:47 pm'),
(5, 'Kylie Montero', 'F', '09501278563', 30.00, 'kylie', 'Montero', '2023-12-08 21:15:33', '08/12/2023 9:16:55 pm'),
(6, 'Amore Mondragon', 'F', '09671267328', 30.00, 'Amore', 'Mondragon', '2023-12-08 21:16:10', '08/12/2023 10:17:04 pm'),
(7, 'Tina Dela Cruz', 'F', '09508967453', 30.00, 'Tina', 'DelaCruz', '2023-12-08 21:16:45', '08/12/2023 10:17:16 pm'),
(8, 'Daryl Tiquio', 'M', '0963498760', 30.00, 'Daryl', 'Tiquio', '2023-12-08 21:18:19', '08/12/2023 10:17:44 pm'),
(9, 'Francis Balazon', 'M', '09501273826', 30.00, 'Francis', 'Balazon', '2023-12-08 21:19:16', '08/12/2023 10:17:55 pm'),
(10, 'James Red', 'M', '09365114521', 30.00, 'James', 'Red', '2023-12-08 22:16:16', '08/12/2023 10:18:02 pm');

-- --------------------------------------------------------

--
-- Table structure for table `buyers`
--

CREATE TABLE `buyers` (
  `buyerID` int(11) NOT NULL,
  `address` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `contact_number` bigint(255) NOT NULL,
  `budget` decimal(20,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `buyers`
--

INSERT INTO `buyers` (`buyerID`, `address`, `name`, `contact_number`, `budget`) VALUES
(1, 'Rosario, Batangas', 'Joshua', 9548958372, 500000.00),
(2, 'Rosario', 'Anthony Villablanca', 9283746392, 100000000.00),
(3, 'Padre Garcia', 'Brian Babasa', 9767812342, 50000000.00),
(4, 'Lipa City', 'Kurt Isaac', 9867896453, 90500000.00),
(5, 'Batangas City', 'Antonio Culas', 2147483647, 150000000.00),
(6, 'Calamba, Laguna', 'Super Mario', 9782763932, 300500000.00),
(7, 'Lipa City', 'Luigi', 9485739283, 100500000.00),
(8, 'Padre Garcia', 'Lebron James', 9872736891, 500000000.00),
(9, 'Lipa City', 'Spiderman', 90235647521, 350575000.00),
(10, 'Batangas City', 'Asian Cutie', 9635421897, 250000000.00);

-- --------------------------------------------------------

--
-- Table structure for table `contracts`
--

CREATE TABLE `contracts` (
  `contractID` int(11) NOT NULL,
  `transactionID` int(11) DEFAULT NULL,
  `terms_and_conditions` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `contracts`
--

INSERT INTO `contracts` (`contractID`, `transactionID`, `terms_and_conditions`) VALUES
(1, 1, '\r\nTerms and Conditions\r\nIntroduction\r\n\r\nThese Terms and Conditions apply to all real estate transactions facilitated by [Your Company Name] (“Company”). By accessing or using our services, you (“Client”) agree to be bound by these terms. Please read them carefully before engaging in any real estate transaction with us.\r\n\r\nServices Offered\r\n\r\nThe Company provides a range of real estate services, including:\r\n\r\nMarketing and listing properties\r\nFinding and showing properties to potential buyers or tenants\r\nNegotiating purchase or rental agreements\r\nAssisting with closing procedures\r\nManaging property for owners\r\nClient Responsibilities\r\n\r\nAs a client, you are responsible for:\r\n\r\nProviding accurate and complete information about your property or desired property.\r\nCooperating with the Company and any third-party professionals involved in the transaction.\r\nReviewing and signing all necessary documents.\r\nPaying all fees and charges associated with the transaction.\r\nCompany Responsibilities\r\n\r\nThe Company agrees to:\r\n\r\nAct in your best interests and with the highest ethical standards.\r\nProvide you with all necessary information and updates about your transaction.\r\nNegotiate the best possible terms on your behalf.\r\nRespect your confidentiality and privacy.\r\nFees and Commissions\r\n\r\nThe Company charges a fee for its services. The fee structure will be clearly communicated to you before you engage in any transaction. You are responsible for paying all fees and commissions associated with your transaction.\r\n\r\nTermination\r\n\r\nYou may terminate your agreement with the Company at any time. The Company may also terminate your agreement for any reason, including but not limited to:\r\n\r\nFailure to provide accurate information.\r\nFailure to cooperate with the Company or third-party professionals.\r\nFailure to pay fees or charges.\r\nViolation of these Terms and Conditions.\r\nDisclaimer\r\n\r\nThe Company provides its services \"as is\" and makes no warranties, express or implied. The Company is not responsible for any damages arising from the use of its services.\r\n\r\nIndemnification\r\n\r\nYou agree to indemnify and hold harmless the Company, its officers, directors, employees, and agents from and against any and all claims, liabilities, losses, expenses, damages, and costs (including attorneys fees) arising out of or relating to your use of the Companys services.\r\n\r\nDispute Resolution\r\n\r\nAny dispute arising out of or relating to these Terms and Conditions shall be settled by binding arbitration in accordance with the rules of the American Arbitration Association.\r\n\r\nGoverning Law\r\n\r\nThese Terms and Conditions shall be governed by and construed in accordance with the laws of the State of [State].\r\n\r\nEntire Agreement\r\n\r\nThese Terms and Conditions constitute the entire agreement between you and the Company and supersede all prior or contemporaneous communications, representations, or agreements, whether oral or written.\r\n\r\nModification\r\n\r\nThe Company may modify these Terms and Conditions at any time by posting the amended terms on its website. You are responsible for reviewing the Terms and Conditions periodically for changes. Your continued use of the Companys services following the posting of amended terms constitutes your acceptance of the amended terms.\r\n\r\nContact Information\r\n\r\nIf you have any questions about these Terms and Conditions, please contact us at:\r\n\r\nHomeSeeker Company\r\nLipa City\r\n09632145216\r\nHomeSeeker@email.Com'),
(2, 2, '\r\nTerms and Conditions\r\nIntroduction\r\n\r\nThese Terms and Conditions apply to all real estate transactions facilitated by [Your Company Name] (“Company”). By accessing or using our services, you (“Client”) agree to be bound by these terms. Please read them carefully before engaging in any real estate transaction with us.\r\n\r\nServices Offered\r\n\r\nThe Company provides a range of real estate services, including:\r\n\r\nMarketing and listing properties\r\nFinding and showing properties to potential buyers or tenants\r\nNegotiating purchase or rental agreements\r\nAssisting with closing procedures\r\nManaging property for owners\r\nClient Responsibilities\r\n\r\nAs a client, you are responsible for:\r\n\r\nProviding accurate and complete information about your property or desired property.\r\nCooperating with the Company and any third-party professionals involved in the transaction.\r\nReviewing and signing all necessary documents.\r\nPaying all fees and charges associated with the transaction.\r\nCompany Responsibilities\r\n\r\nThe Company agrees to:\r\n\r\nAct in your best interests and with the highest ethical standards.\r\nProvide you with all necessary information and updates about your transaction.\r\nNegotiate the best possible terms on your behalf.\r\nRespect your confidentiality and privacy.\r\nFees and Commissions\r\n\r\nThe Company charges a fee for its services. The fee structure will be clearly communicated to you before you engage in any transaction. You are responsible for paying all fees and commissions associated with your transaction.\r\n\r\nTermination\r\n\r\nYou may terminate your agreement with the Company at any time. The Company may also terminate your agreement for any reason, including but not limited to:\r\n\r\nFailure to provide accurate information.\r\nFailure to cooperate with the Company or third-party professionals.\r\nFailure to pay fees or charges.\r\nViolation of these Terms and Conditions.\r\nDisclaimer\r\n\r\nThe Company provides its services \"as is\" and makes no warranties, express or implied. The Company is not responsible for any damages arising from the use of its services.\r\n\r\nIndemnification\r\n\r\nYou agree to indemnify and hold harmless the Company, its officers, directors, employees, and agents from and against any and all claims, liabilities, losses, expenses, damages, and costs (including attorneys fees) arising out of or relating to your use of the Companys services.\r\n\r\nDispute Resolution\r\n\r\nAny dispute arising out of or relating to these Terms and Conditions shall be settled by binding arbitration in accordance with the rules of the American Arbitration Association.\r\n\r\nGoverning Law\r\n\r\nThese Terms and Conditions shall be governed by and construed in accordance with the laws of the State of [State].\r\n\r\nEntire Agreement\r\n\r\nThese Terms and Conditions constitute the entire agreement between you and the Company and supersede all prior or contemporaneous communications, representations, or agreements, whether oral or written.\r\n\r\nModification\r\n\r\nThe Company may modify these Terms and Conditions at any time by posting the amended terms on its website. You are responsible for reviewing the Terms and Conditions periodically for changes. Your continued use of the Companys services following the posting of amended terms constitutes your acceptance of the amended terms.\r\n\r\nContact Information\r\n\r\nIf you have any questions about these Terms and Conditions, please contact us at:\r\n\r\nHomeSeeker Company\r\nLipa City\r\n09632145216\r\nHomeSeeker@email.Com'),
(3, 3, '\r\nTerms and Conditions\r\nIntroduction\r\n\r\nThese Terms and Conditions apply to all real estate transactions facilitated by [Your Company Name] (“Company”). By accessing or using our services, you (“Client”) agree to be bound by these terms. Please read them carefully before engaging in any real estate transaction with us.\r\n\r\nServices Offered\r\n\r\nThe Company provides a range of real estate services, including:\r\n\r\nMarketing and listing properties\r\nFinding and showing properties to potential buyers or tenants\r\nNegotiating purchase or rental agreements\r\nAssisting with closing procedures\r\nManaging property for owners\r\nClient Responsibilities\r\n\r\nAs a client, you are responsible for:\r\n\r\nProviding accurate and complete information about your property or desired property.\r\nCooperating with the Company and any third-party professionals involved in the transaction.\r\nReviewing and signing all necessary documents.\r\nPaying all fees and charges associated with the transaction.\r\nCompany Responsibilities\r\n\r\nThe Company agrees to:\r\n\r\nAct in your best interests and with the highest ethical standards.\r\nProvide you with all necessary information and updates about your transaction.\r\nNegotiate the best possible terms on your behalf.\r\nRespect your confidentiality and privacy.\r\nFees and Commissions\r\n\r\nThe Company charges a fee for its services. The fee structure will be clearly communicated to you before you engage in any transaction. You are responsible for paying all fees and commissions associated with your transaction.\r\n\r\nTermination\r\n\r\nYou may terminate your agreement with the Company at any time. The Company may also terminate your agreement for any reason, including but not limited to:\r\n\r\nFailure to provide accurate information.\r\nFailure to cooperate with the Company or third-party professionals.\r\nFailure to pay fees or charges.\r\nViolation of these Terms and Conditions.\r\nDisclaimer\r\n\r\nThe Company provides its services \"as is\" and makes no warranties, express or implied. The Company is not responsible for any damages arising from the use of its services.\r\n\r\nIndemnification\r\n\r\nYou agree to indemnify and hold harmless the Company, its officers, directors, employees, and agents from and against any and all claims, liabilities, losses, expenses, damages, and costs (including attorneys fees) arising out of or relating to your use of the Companys services.\r\n\r\nDispute Resolution\r\n\r\nAny dispute arising out of or relating to these Terms and Conditions shall be settled by binding arbitration in accordance with the rules of the American Arbitration Association.\r\n\r\nGoverning Law\r\n\r\nThese Terms and Conditions shall be governed by and construed in accordance with the laws of the State of [State].\r\n\r\nEntire Agreement\r\n\r\nThese Terms and Conditions constitute the entire agreement between you and the Company and supersede all prior or contemporaneous communications, representations, or agreements, whether oral or written.\r\n\r\nModification\r\n\r\nThe Company may modify these Terms and Conditions at any time by posting the amended terms on its website. You are responsible for reviewing the Terms and Conditions periodically for changes. Your continued use of the Companys services following the posting of amended terms constitutes your acceptance of the amended terms.\r\n\r\nContact Information\r\n\r\nIf you have any questions about these Terms and Conditions, please contact us at:\r\n\r\nHomeSeeker Company\r\nLipa City\r\n09632145216\r\nHomeSeeker@email.Com'),
(4, 4, '\r\nTerms and Conditions\r\nIntroduction\r\n\r\nThese Terms and Conditions apply to all real estate transactions facilitated by [Your Company Name] (“Company”). By accessing or using our services, you (“Client”) agree to be bound by these terms. Please read them carefully before engaging in any real estate transaction with us.\r\n\r\nServices Offered\r\n\r\nThe Company provides a range of real estate services, including:\r\n\r\nMarketing and listing properties\r\nFinding and showing properties to potential buyers or tenants\r\nNegotiating purchase or rental agreements\r\nAssisting with closing procedures\r\nManaging property for owners\r\nClient Responsibilities\r\n\r\nAs a client, you are responsible for:\r\n\r\nProviding accurate and complete information about your property or desired property.\r\nCooperating with the Company and any third-party professionals involved in the transaction.\r\nReviewing and signing all necessary documents.\r\nPaying all fees and charges associated with the transaction.\r\nCompany Responsibilities\r\n\r\nThe Company agrees to:\r\n\r\nAct in your best interests and with the highest ethical standards.\r\nProvide you with all necessary information and updates about your transaction.\r\nNegotiate the best possible terms on your behalf.\r\nRespect your confidentiality and privacy.\r\nFees and Commissions\r\n\r\nThe Company charges a fee for its services. The fee structure will be clearly communicated to you before you engage in any transaction. You are responsible for paying all fees and commissions associated with your transaction.\r\n\r\nTermination\r\n\r\nYou may terminate your agreement with the Company at any time. The Company may also terminate your agreement for any reason, including but not limited to:\r\n\r\nFailure to provide accurate information.\r\nFailure to cooperate with the Company or third-party professionals.\r\nFailure to pay fees or charges.\r\nViolation of these Terms and Conditions.\r\nDisclaimer\r\n\r\nThe Company provides its services \"as is\" and makes no warranties, express or implied. The Company is not responsible for any damages arising from the use of its services.\r\n\r\nIndemnification\r\n\r\nYou agree to indemnify and hold harmless the Company, its officers, directors, employees, and agents from and against any and all claims, liabilities, losses, expenses, damages, and costs (including attorneys fees) arising out of or relating to your use of the Companys services.\r\n\r\nDispute Resolution\r\n\r\nAny dispute arising out of or relating to these Terms and Conditions shall be settled by binding arbitration in accordance with the rules of the American Arbitration Association.\r\n\r\nGoverning Law\r\n\r\nThese Terms and Conditions shall be governed by and construed in accordance with the laws of the State of [State].\r\n\r\nEntire Agreement\r\n\r\nThese Terms and Conditions constitute the entire agreement between you and the Company and supersede all prior or contemporaneous communications, representations, or agreements, whether oral or written.\r\n\r\nModification\r\n\r\nThe Company may modify these Terms and Conditions at any time by posting the amended terms on its website. You are responsible for reviewing the Terms and Conditions periodically for changes. Your continued use of the Companys services following the posting of amended terms constitutes your acceptance of the amended terms.\r\n\r\nContact Information\r\n\r\nIf you have any questions about these Terms and Conditions, please contact us at:\r\n\r\nHomeSeeker Company\r\nLipa City\r\n09632145216\r\nHomeSeeker@email.Com'),
(5, 5, '\r\nTerms and Conditions\r\nIntroduction\r\n\r\nThese Terms and Conditions apply to all real estate transactions facilitated by [Your Company Name] (“Company”). By accessing or using our services, you (“Client”) agree to be bound by these terms. Please read them carefully before engaging in any real estate transaction with us.\r\n\r\nServices Offered\r\n\r\nThe Company provides a range of real estate services, including:\r\n\r\nMarketing and listing properties\r\nFinding and showing properties to potential buyers or tenants\r\nNegotiating purchase or rental agreements\r\nAssisting with closing procedures\r\nManaging property for owners\r\nClient Responsibilities\r\n\r\nAs a client, you are responsible for:\r\n\r\nProviding accurate and complete information about your property or desired property.\r\nCooperating with the Company and any third-party professionals involved in the transaction.\r\nReviewing and signing all necessary documents.\r\nPaying all fees and charges associated with the transaction.\r\nCompany Responsibilities\r\n\r\nThe Company agrees to:\r\n\r\nAct in your best interests and with the highest ethical standards.\r\nProvide you with all necessary information and updates about your transaction.\r\nNegotiate the best possible terms on your behalf.\r\nRespect your confidentiality and privacy.\r\nFees and Commissions\r\n\r\nThe Company charges a fee for its services. The fee structure will be clearly communicated to you before you engage in any transaction. You are responsible for paying all fees and commissions associated with your transaction.\r\n\r\nTermination\r\n\r\nYou may terminate your agreement with the Company at any time. The Company may also terminate your agreement for any reason, including but not limited to:\r\n\r\nFailure to provide accurate information.\r\nFailure to cooperate with the Company or third-party professionals.\r\nFailure to pay fees or charges.\r\nViolation of these Terms and Conditions.\r\nDisclaimer\r\n\r\nThe Company provides its services \"as is\" and makes no warranties, express or implied. The Company is not responsible for any damages arising from the use of its services.\r\n\r\nIndemnification\r\n\r\nYou agree to indemnify and hold harmless the Company, its officers, directors, employees, and agents from and against any and all claims, liabilities, losses, expenses, damages, and costs (including attorneys fees) arising out of or relating to your use of the Companys services.\r\n\r\nDispute Resolution\r\n\r\nAny dispute arising out of or relating to these Terms and Conditions shall be settled by binding arbitration in accordance with the rules of the American Arbitration Association.\r\n\r\nGoverning Law\r\n\r\nThese Terms and Conditions shall be governed by and construed in accordance with the laws of the State of [State].\r\n\r\nEntire Agreement\r\n\r\nThese Terms and Conditions constitute the entire agreement between you and the Company and supersede all prior or contemporaneous communications, representations, or agreements, whether oral or written.\r\n\r\nModification\r\n\r\nThe Company may modify these Terms and Conditions at any time by posting the amended terms on its website. You are responsible for reviewing the Terms and Conditions periodically for changes. Your continued use of the Companys services following the posting of amended terms constitutes your acceptance of the amended terms.\r\n\r\nContact Information\r\n\r\nIf you have any questions about these Terms and Conditions, please contact us at:\r\n\r\nHomeSeeker Company\r\nLipa City\r\n09632145216\r\nHomeSeeker@email.Com'),
(6, 6, '\r\nTerms and Conditions\r\nIntroduction\r\n\r\nThese Terms and Conditions apply to all real estate transactions facilitated by [Your Company Name] (“Company”). By accessing or using our services, you (“Client”) agree to be bound by these terms. Please read them carefully before engaging in any real estate transaction with us.\r\n\r\nServices Offered\r\n\r\nThe Company provides a range of real estate services, including:\r\n\r\nMarketing and listing properties\r\nFinding and showing properties to potential buyers or tenants\r\nNegotiating purchase or rental agreements\r\nAssisting with closing procedures\r\nManaging property for owners\r\nClient Responsibilities\r\n\r\nAs a client, you are responsible for:\r\n\r\nProviding accurate and complete information about your property or desired property.\r\nCooperating with the Company and any third-party professionals involved in the transaction.\r\nReviewing and signing all necessary documents.\r\nPaying all fees and charges associated with the transaction.\r\nCompany Responsibilities\r\n\r\nThe Company agrees to:\r\n\r\nAct in your best interests and with the highest ethical standards.\r\nProvide you with all necessary information and updates about your transaction.\r\nNegotiate the best possible terms on your behalf.\r\nRespect your confidentiality and privacy.\r\nFees and Commissions\r\n\r\nThe Company charges a fee for its services. The fee structure will be clearly communicated to you before you engage in any transaction. You are responsible for paying all fees and commissions associated with your transaction.\r\n\r\nTermination\r\n\r\nYou may terminate your agreement with the Company at any time. The Company may also terminate your agreement for any reason, including but not limited to:\r\n\r\nFailure to provide accurate information.\r\nFailure to cooperate with the Company or third-party professionals.\r\nFailure to pay fees or charges.\r\nViolation of these Terms and Conditions.\r\nDisclaimer\r\n\r\nThe Company provides its services \"as is\" and makes no warranties, express or implied. The Company is not responsible for any damages arising from the use of its services.\r\n\r\nIndemnification\r\n\r\nYou agree to indemnify and hold harmless the Company, its officers, directors, employees, and agents from and against any and all claims, liabilities, losses, expenses, damages, and costs (including attorneys fees) arising out of or relating to your use of the Companys services.\r\n\r\nDispute Resolution\r\n\r\nAny dispute arising out of or relating to these Terms and Conditions shall be settled by binding arbitration in accordance with the rules of the American Arbitration Association.\r\n\r\nGoverning Law\r\n\r\nThese Terms and Conditions shall be governed by and construed in accordance with the laws of the State of [State].\r\n\r\nEntire Agreement\r\n\r\nThese Terms and Conditions constitute the entire agreement between you and the Company and supersede all prior or contemporaneous communications, representations, or agreements, whether oral or written.\r\n\r\nModification\r\n\r\nThe Company may modify these Terms and Conditions at any time by posting the amended terms on its website. You are responsible for reviewing the Terms and Conditions periodically for changes. Your continued use of the Companys services following the posting of amended terms constitutes your acceptance of the amended terms.\r\n\r\nContact Information\r\n\r\nIf you have any questions about these Terms and Conditions, please contact us at:\r\n\r\nHomeSeeker Company\r\nLipa City\r\n09632145216\r\nHomeSeeker@email.Com'),
(7, 7, '\r\nTerms and Conditions\r\nIntroduction\r\n\r\nThese Terms and Conditions apply to all real estate transactions facilitated by [Your Company Name] (“Company”). By accessing or using our services, you (“Client”) agree to be bound by these terms. Please read them carefully before engaging in any real estate transaction with us.\r\n\r\nServices Offered\r\n\r\nThe Company provides a range of real estate services, including:\r\n\r\nMarketing and listing properties\r\nFinding and showing properties to potential buyers or tenants\r\nNegotiating purchase or rental agreements\r\nAssisting with closing procedures\r\nManaging property for owners\r\nClient Responsibilities\r\n\r\nAs a client, you are responsible for:\r\n\r\nProviding accurate and complete information about your property or desired property.\r\nCooperating with the Company and any third-party professionals involved in the transaction.\r\nReviewing and signing all necessary documents.\r\nPaying all fees and charges associated with the transaction.\r\nCompany Responsibilities\r\n\r\nThe Company agrees to:\r\n\r\nAct in your best interests and with the highest ethical standards.\r\nProvide you with all necessary information and updates about your transaction.\r\nNegotiate the best possible terms on your behalf.\r\nRespect your confidentiality and privacy.\r\nFees and Commissions\r\n\r\nThe Company charges a fee for its services. The fee structure will be clearly communicated to you before you engage in any transaction. You are responsible for paying all fees and commissions associated with your transaction.\r\n\r\nTermination\r\n\r\nYou may terminate your agreement with the Company at any time. The Company may also terminate your agreement for any reason, including but not limited to:\r\n\r\nFailure to provide accurate information.\r\nFailure to cooperate with the Company or third-party professionals.\r\nFailure to pay fees or charges.\r\nViolation of these Terms and Conditions.\r\nDisclaimer\r\n\r\nThe Company provides its services \"as is\" and makes no warranties, express or implied. The Company is not responsible for any damages arising from the use of its services.\r\n\r\nIndemnification\r\n\r\nYou agree to indemnify and hold harmless the Company, its officers, directors, employees, and agents from and against any and all claims, liabilities, losses, expenses, damages, and costs (including attorneys fees) arising out of or relating to your use of the Companys services.\r\n\r\nDispute Resolution\r\n\r\nAny dispute arising out of or relating to these Terms and Conditions shall be settled by binding arbitration in accordance with the rules of the American Arbitration Association.\r\n\r\nGoverning Law\r\n\r\nThese Terms and Conditions shall be governed by and construed in accordance with the laws of the State of [State].\r\n\r\nEntire Agreement\r\n\r\nThese Terms and Conditions constitute the entire agreement between you and the Company and supersede all prior or contemporaneous communications, representations, or agreements, whether oral or written.\r\n\r\nModification\r\n\r\nThe Company may modify these Terms and Conditions at any time by posting the amended terms on its website. You are responsible for reviewing the Terms and Conditions periodically for changes. Your continued use of the Companys services following the posting of amended terms constitutes your acceptance of the amended terms.\r\n\r\nContact Information\r\n\r\nIf you have any questions about these Terms and Conditions, please contact us at:\r\n\r\nHomeSeeker Company\r\nLipa City\r\n09632145216\r\nHomeSeeker@email.Com'),
(8, 8, '\r\nTerms and Conditions\r\nIntroduction\r\n\r\nThese Terms and Conditions apply to all real estate transactions facilitated by [Your Company Name] (“Company”). By accessing or using our services, you (“Client”) agree to be bound by these terms. Please read them carefully before engaging in any real estate transaction with us.\r\n\r\nServices Offered\r\n\r\nThe Company provides a range of real estate services, including:\r\n\r\nMarketing and listing properties\r\nFinding and showing properties to potential buyers or tenants\r\nNegotiating purchase or rental agreements\r\nAssisting with closing procedures\r\nManaging property for owners\r\nClient Responsibilities\r\n\r\nAs a client, you are responsible for:\r\n\r\nProviding accurate and complete information about your property or desired property.\r\nCooperating with the Company and any third-party professionals involved in the transaction.\r\nReviewing and signing all necessary documents.\r\nPaying all fees and charges associated with the transaction.\r\nCompany Responsibilities\r\n\r\nThe Company agrees to:\r\n\r\nAct in your best interests and with the highest ethical standards.\r\nProvide you with all necessary information and updates about your transaction.\r\nNegotiate the best possible terms on your behalf.\r\nRespect your confidentiality and privacy.\r\nFees and Commissions\r\n\r\nThe Company charges a fee for its services. The fee structure will be clearly communicated to you before you engage in any transaction. You are responsible for paying all fees and commissions associated with your transaction.\r\n\r\nTermination\r\n\r\nYou may terminate your agreement with the Company at any time. The Company may also terminate your agreement for any reason, including but not limited to:\r\n\r\nFailure to provide accurate information.\r\nFailure to cooperate with the Company or third-party professionals.\r\nFailure to pay fees or charges.\r\nViolation of these Terms and Conditions.\r\nDisclaimer\r\n\r\nThe Company provides its services \"as is\" and makes no warranties, express or implied. The Company is not responsible for any damages arising from the use of its services.\r\n\r\nIndemnification\r\n\r\nYou agree to indemnify and hold harmless the Company, its officers, directors, employees, and agents from and against any and all claims, liabilities, losses, expenses, damages, and costs (including attorneys fees) arising out of or relating to your use of the Companys services.\r\n\r\nDispute Resolution\r\n\r\nAny dispute arising out of or relating to these Terms and Conditions shall be settled by binding arbitration in accordance with the rules of the American Arbitration Association.\r\n\r\nGoverning Law\r\n\r\nThese Terms and Conditions shall be governed by and construed in accordance with the laws of the State of [State].\r\n\r\nEntire Agreement\r\n\r\nThese Terms and Conditions constitute the entire agreement between you and the Company and supersede all prior or contemporaneous communications, representations, or agreements, whether oral or written.\r\n\r\nModification\r\n\r\nThe Company may modify these Terms and Conditions at any time by posting the amended terms on its website. You are responsible for reviewing the Terms and Conditions periodically for changes. Your continued use of the Companys services following the posting of amended terms constitutes your acceptance of the amended terms.\r\n\r\nContact Information\r\n\r\nIf you have any questions about these Terms and Conditions, please contact us at:\r\n\r\nHomeSeeker Company\r\nLipa City\r\n09632145216\r\nHomeSeeker@email.Com'),
(9, 9, '\r\nTerms and Conditions\r\nIntroduction\r\n\r\nThese Terms and Conditions apply to all real estate transactions facilitated by [Your Company Name] (“Company”). By accessing or using our services, you (“Client”) agree to be bound by these terms. Please read them carefully before engaging in any real estate transaction with us.\r\n\r\nServices Offered\r\n\r\nThe Company provides a range of real estate services, including:\r\n\r\nMarketing and listing properties\r\nFinding and showing properties to potential buyers or tenants\r\nNegotiating purchase or rental agreements\r\nAssisting with closing procedures\r\nManaging property for owners\r\nClient Responsibilities\r\n\r\nAs a client, you are responsible for:\r\n\r\nProviding accurate and complete information about your property or desired property.\r\nCooperating with the Company and any third-party professionals involved in the transaction.\r\nReviewing and signing all necessary documents.\r\nPaying all fees and charges associated with the transaction.\r\nCompany Responsibilities\r\n\r\nThe Company agrees to:\r\n\r\nAct in your best interests and with the highest ethical standards.\r\nProvide you with all necessary information and updates about your transaction.\r\nNegotiate the best possible terms on your behalf.\r\nRespect your confidentiality and privacy.\r\nFees and Commissions\r\n\r\nThe Company charges a fee for its services. The fee structure will be clearly communicated to you before you engage in any transaction. You are responsible for paying all fees and commissions associated with your transaction.\r\n\r\nTermination\r\n\r\nYou may terminate your agreement with the Company at any time. The Company may also terminate your agreement for any reason, including but not limited to:\r\n\r\nFailure to provide accurate information.\r\nFailure to cooperate with the Company or third-party professionals.\r\nFailure to pay fees or charges.\r\nViolation of these Terms and Conditions.\r\nDisclaimer\r\n\r\nThe Company provides its services \"as is\" and makes no warranties, express or implied. The Company is not responsible for any damages arising from the use of its services.\r\n\r\nIndemnification\r\n\r\nYou agree to indemnify and hold harmless the Company, its officers, directors, employees, and agents from and against any and all claims, liabilities, losses, expenses, damages, and costs (including attorneys fees) arising out of or relating to your use of the Companys services.\r\n\r\nDispute Resolution\r\n\r\nAny dispute arising out of or relating to these Terms and Conditions shall be settled by binding arbitration in accordance with the rules of the American Arbitration Association.\r\n\r\nGoverning Law\r\n\r\nThese Terms and Conditions shall be governed by and construed in accordance with the laws of the State of [State].\r\n\r\nEntire Agreement\r\n\r\nThese Terms and Conditions constitute the entire agreement between you and the Company and supersede all prior or contemporaneous communications, representations, or agreements, whether oral or written.\r\n\r\nModification\r\n\r\nThe Company may modify these Terms and Conditions at any time by posting the amended terms on its website. You are responsible for reviewing the Terms and Conditions periodically for changes. Your continued use of the Companys services following the posting of amended terms constitutes your acceptance of the amended terms.\r\n\r\nContact Information\r\n\r\nIf you have any questions about these Terms and Conditions, please contact us at:\r\n\r\nHomeSeeker Company\r\nLipa City\r\n09632145216\r\nHomeSeeker@email.Com'),
(10, 10, '\r\nTerms and Conditions\r\nIntroduction\r\n\r\nThese Terms and Conditions apply to all real estate transactions facilitated by [Your Company Name] (“Company”). By accessing or using our services, you (“Client”) agree to be bound by these terms. Please read them carefully before engaging in any real estate transaction with us.\r\n\r\nServices Offered\r\n\r\nThe Company provides a range of real estate services, including:\r\n\r\nMarketing and listing properties\r\nFinding and showing properties to potential buyers or tenants\r\nNegotiating purchase or rental agreements\r\nAssisting with closing procedures\r\nManaging property for owners\r\nClient Responsibilities\r\n\r\nAs a client, you are responsible for:\r\n\r\nProviding accurate and complete information about your property or desired property.\r\nCooperating with the Company and any third-party professionals involved in the transaction.\r\nReviewing and signing all necessary documents.\r\nPaying all fees and charges associated with the transaction.\r\nCompany Responsibilities\r\n\r\nThe Company agrees to:\r\n\r\nAct in your best interests and with the highest ethical standards.\r\nProvide you with all necessary information and updates about your transaction.\r\nNegotiate the best possible terms on your behalf.\r\nRespect your confidentiality and privacy.\r\nFees and Commissions\r\n\r\nThe Company charges a fee for its services. The fee structure will be clearly communicated to you before you engage in any transaction. You are responsible for paying all fees and commissions associated with your transaction.\r\n\r\nTermination\r\n\r\nYou may terminate your agreement with the Company at any time. The Company may also terminate your agreement for any reason, including but not limited to:\r\n\r\nFailure to provide accurate information.\r\nFailure to cooperate with the Company or third-party professionals.\r\nFailure to pay fees or charges.\r\nViolation of these Terms and Conditions.\r\nDisclaimer\r\n\r\nThe Company provides its services \"as is\" and makes no warranties, express or implied. The Company is not responsible for any damages arising from the use of its services.\r\n\r\nIndemnification\r\n\r\nYou agree to indemnify and hold harmless the Company, its officers, directors, employees, and agents from and against any and all claims, liabilities, losses, expenses, damages, and costs (including attorneys fees) arising out of or relating to your use of the Companys services.\r\n\r\nDispute Resolution\r\n\r\nAny dispute arising out of or relating to these Terms and Conditions shall be settled by binding arbitration in accordance with the rules of the American Arbitration Association.\r\n\r\nGoverning Law\r\n\r\nThese Terms and Conditions shall be governed by and construed in accordance with the laws of the State of [State].\r\n\r\nEntire Agreement\r\n\r\nThese Terms and Conditions constitute the entire agreement between you and the Company and supersede all prior or contemporaneous communications, representations, or agreements, whether oral or written.\r\n\r\nModification\r\n\r\nThe Company may modify these Terms and Conditions at any time by posting the amended terms on its website. You are responsible for reviewing the Terms and Conditions periodically for changes. Your continued use of the Companys services following the posting of amended terms constitutes your acceptance of the amended terms.\r\n\r\nContact Information\r\n\r\nIf you have any questions about these Terms and Conditions, please contact us at:\r\n\r\nHomeSeeker Company\r\nLipa City\r\n09632145216\r\nHomeSeeker@email.Com');

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
(1, 'Rosario, Batangas', 'Lot', 7200, 21600000),
(2, 'Padre Garcia', 'Residential', 200, 14400000),
(3, 'Pansol, Calamba', 'Private Resort', 7000, 35000000),
(4, 'Lipa City', 'Commercial Space (For Rent)', 574, 16898),
(5, 'Batangas City', 'Commercial Space (For Rent)', 600, 180000),
(6, 'Rosario, Batangas', 'Lot', 3000, 9000000),
(7, 'Lipa City', 'Lot', 9300, 32550000),
(8, 'Padre Garcia', 'Commercial Space (For Rent)', 120, 36000),
(9, 'Rosario, Batangas', 'Commercial Space (For Rent)', 200, 600000),
(10, 'Padre Garcia', 'Lot', 7300, 21900000);

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
(1, 8, 1, 1, '2023-12-05', 40000.00),
(2, 1, 2, 2, '2023-12-05', 22000000.00),
(3, 2, 3, 3, '2023-12-05', 35000000.00),
(4, 3, 4, 4, '2023-12-08', 35000000.00),
(5, 4, 5, 5, '2023-12-08', 33796.00),
(6, 5, 6, 6, '2023-12-08', 36000.00),
(7, 6, 7, 7, '2023-12-08', 9000000.00),
(8, 7, 8, 8, '2023-12-08', 32550000.00),
(9, 9, 9, 9, '2023-12-08', 600000.00),
(10, 10, 10, 1, '2023-12-08', 35000000.00);

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
-- Dumping data for table `visits`
--

INSERT INTO `visits` (`visitID`, `propertyID`, `visitor_name`, `agentID`, `visit_date`, `feedback`) VALUES
(1, 1, 'Daryl', 1, '2023-12-08', 'none'),
(2, 2, 'Francis', 2, '2023-12-08', 'none'),
(3, 3, 'Toni', 3, '2023-12-08', 'none'),
(4, 4, 'Jojo', 4, '2023-12-08', 'none'),
(5, 5, 'Brianna', 5, '2023-12-08', 'Nice'),
(6, 6, 'Kylla', 6, '2023-12-08', 'none'),
(7, 7, 'Yvonne', 7, '2023-12-08', 'BASERS BASERS'),
(8, 8, 'Rez', 8, '2023-12-08', 'none'),
(9, 9, 'Sesa', 9, '2023-12-08', 'Wow, Amazing'),
(10, 10, 'Super Mario', 10, '2023-12-08', 'Here we go');

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
