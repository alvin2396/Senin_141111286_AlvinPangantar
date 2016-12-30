-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 26, 2016 at 09:46 AM
-- Server version: 5.6.26
-- PHP Version: 5.6.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `database_latihan_pos`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbarang`
--

CREATE TABLE IF NOT EXISTS `tblbarang` (
  `id` int(10) NOT NULL,
  `kode` varchar(20) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jumlahAwal` int(10) NOT NULL,
  `hargaHpp` decimal(16,2) NOT NULL,
  `hargajual` decimal(16,2) NOT NULL,
  `tglbuatbarang` date NOT NULL,
  `tglupdatebarang` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbarang`
--

INSERT INTO `tblbarang` (`id`, `kode`, `nama`, `jumlahAwal`, `hargaHpp`, `hargajual`, `tglbuatbarang`, `tglupdatebarang`) VALUES
(1, '1d', 'd', 1, '1.00', '1.00', '0000-00-00', '0000-00-00'),
(123, 'TestingProject123', 'Testing', 1, '2555.00', '25555.00', '0000-00-00', '0000-00-00'),
(1, 'Test123', 'Testing', 2, '2000.00', '2000.00', '0000-00-00', '0000-00-00'),
(2, 'Test123Again', 'Testing', 2, '2000.00', '2000.00', '0000-00-00', '0000-00-00'),
(1, '23', 'a', 22, '222.00', '222.00', '0000-00-00', '0000-00-00'),
(1, '23', 'a', 22, '222.00', '222.00', '0000-00-00', '0000-00-00'),
(123, '123', 'Barang', 1, '200.00', '200.00', '2016-12-26', '2016-12-26'),
(1, '233', 'Nangka', 23, '2.00', '2.00', '2016-12-26', '2016-12-26');

-- --------------------------------------------------------

--
-- Table structure for table `tblcustomer`
--

CREATE TABLE IF NOT EXISTS `tblcustomer` (
  `KodeCust` int(20) NOT NULL,
  `NamaCust` varchar(100) NOT NULL,
  `AlamatCust` varchar(100) NOT NULL,
  `HpCust` int(12) NOT NULL,
  `EmailCust` varchar(100) NOT NULL,
  `Datenow` date NOT NULL,
  `DateUpdate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcustomer`
--

INSERT INTO `tblcustomer` (`KodeCust`, `NamaCust`, `AlamatCust`, `HpCust`, `EmailCust`, `Datenow`, `DateUpdate`) VALUES
(1, 'kelvin', 'jln', 23, 'we', '2016-12-26', '2016-12-26'),
(23, 'aa', 'aa', 23, 'asda', '2016-12-26', '2016-12-26');

-- --------------------------------------------------------

--
-- Table structure for table `tblsupplier`
--

CREATE TABLE IF NOT EXISTS `tblsupplier` (
  `KodeSup` int(10) NOT NULL,
  `NamaSup` varchar(100) NOT NULL,
  `AlamatSup` varchar(100) NOT NULL,
  `HpSup` int(12) NOT NULL,
  `EmailSup` varchar(100) NOT NULL,
  `Datenow` date NOT NULL,
  `DateUpdate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsupplier`
--

INSERT INTO `tblsupplier` (`KodeSup`, `NamaSup`, `AlamatSup`, `HpSup`, `EmailSup`, `Datenow`, `DateUpdate`) VALUES
(123, 'ad', 'ad', 231, 'asd', '2016-12-26', '2016-12-26');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
