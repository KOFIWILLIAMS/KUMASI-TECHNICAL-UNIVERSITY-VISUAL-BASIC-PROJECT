-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 09, 2020 at 01:52 AM
-- Server version: 10.3.15-MariaDB
-- PHP Version: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `korona`
--

-- --------------------------------------------------------

--
-- Table structure for table `drugslist_tb`
--

CREATE TABLE `drugslist_tb` (
  `DrugsID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Quantity` int(200) NOT NULL,
  `Unit_Price` decimal(10,0) NOT NULL,
  `Purchase_Price` decimal(10,0) NOT NULL,
  `Sale_Price` decimal(10,0) NOT NULL,
  `Profit` decimal(10,0) NOT NULL,
  `SaveDeduction` decimal(10,0) NOT NULL,
  `Packing_Type` varchar(250) NOT NULL,
  `Category` varchar(250) NOT NULL,
  `Alternate_drug` varchar(250) NOT NULL,
  `Dosage` varchar(250) NOT NULL,
  `Schedule` varchar(200) NOT NULL,
  `Expiry` date NOT NULL,
  `DrugStatus` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `drugslist_tb`
--

INSERT INTO `drugslist_tb` (`DrugsID`, `Name`, `Quantity`, `Unit_Price`, `Purchase_Price`, `Sale_Price`, `Profit`, `SaveDeduction`, `Packing_Type`, `Category`, `Alternate_drug`, `Dosage`, `Schedule`, `Expiry`, `DrugStatus`) VALUES
(34, 'para', 34, '34', '3', '34', '43', '34', 'Bag', 'water', '3', '343', '0-0-0', '0000-00-00', 'Inactive'),
(565, 'fgf', 0, '54', '454', '454', '45', '54', 'fg', 'fg', 'fgf', 'fg', 'fgf', '0000-00-00', 'fg');

-- --------------------------------------------------------

--
-- Table structure for table `drug_purchased`
--

CREATE TABLE `drug_purchased` (
  `TxtCode` varchar(66) NOT NULL,
  `DRUG_NAME` varchar(50) NOT NULL,
  `DRUG_Qty` varchar(50) NOT NULL,
  `Original_Drug_Qty` int(50) NOT NULL,
  `Purchase_Unit_Price` decimal(50,2) NOT NULL,
  `Purchase_TotalAmount` decimal(50,2) NOT NULL,
  `Sale_Unit_Price` decimal(11,2) NOT NULL,
  `DrugCategory` varchar(66) NOT NULL,
  `DrugExpiryDate` date NOT NULL,
  `Sale_Qty` double NOT NULL,
  `Sale_Total_Amt` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `drug_purchased`
--

INSERT INTO `drug_purchased` (`TxtCode`, `DRUG_NAME`, `DRUG_Qty`, `Original_Drug_Qty`, `Purchase_Unit_Price`, `Purchase_TotalAmount`, `Sale_Unit_Price`, `DrugCategory`, `DrugExpiryDate`, `Sale_Qty`, `Sale_Total_Amt`) VALUES
('100', 'zincovit', '182', 0, '43.00', '108.00', '2.00', 'ds', '2020-05-19', 0, '0.00'),
('101', 'jerifan 2', '104', 0, '2.00', '-344.00', '4.00', 'SUSPENSION', '2020-05-18', 0, '0.00'),
('123', 'Paracetamol 500MG', '20', 40, '1.00', '0.00', '2.00', 'TABLET', '2021-07-29', 0, '0.00'),
('1231', 'Metoclopramide', '28', 30, '2.00', '50.00', '5.00', 'CAPSULES ', '2020-05-18', 0, '0.00'),
('12345', 'Diclofenac', '2', 0, '1.00', '-6.00', '2.00', 'CAPSULES ', '2022-05-18', 0, '0.00'),
('343', 'dfd', '56', 0, '0.00', '0.00', '0.00', 'gh', '2020-05-18', 0, '0.00'),
('452', 'Beco', '30', 0, '2.00', '40.00', '3.00', 'TABLET', '2020-03-04', 0, '0.00'),
('47847', 'amosaline', '1000', 0, '1.00', '40.00', '2.00', 'SUSPENSION', '2105-11-19', 0, '0.00'),
('585', 'Tramadol', '58', 0, '2.00', '112.00', '4.00', 'TABLET', '2045-07-20', 0, '0.00');

-- --------------------------------------------------------

--
-- Table structure for table `sales_appointment`
--

CREATE TABLE `sales_appointment` (
  `D_NAME` varchar(50) NOT NULL,
  `QUANTITY` int(50) NOT NULL,
  `SELLING_)P` decimal(50,2) NOT NULL,
  `AMOUNT` decimal(11,2) NOT NULL,
  `SALES_ID` int(99) NOT NULL,
  `QTY_IN_STOCK` int(25) NOT NULL,
  `CATEGORY` varchar(33) NOT NULL,
  `DATE` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sales_appointment`
--

INSERT INTO `sales_appointment` (`D_NAME`, `QUANTITY`, `SELLING_)P`, `AMOUNT`, `SALES_ID`, `QTY_IN_STOCK`, `CATEGORY`, `DATE`) VALUES
('zincovit', 20, '2.00', '40.00', 17, 204, 'ds', '2020-07-01'),
('Diclofenac', 2, '2.00', '4.00', 18, 3, 'CAPSULES ', '2020-07-01'),
('zincovit', 2, '2.00', '4.00', 19, 184, 'ds', '2020-07-08'),
('Diclofenac', 1, '2.00', '2.00', 20, 3, 'CAPSULES ', '2020-07-08'),
('jerifan 2', 96, '4.00', '384.00', 21, 200, 'SUSPENSION', '2020-07-08'),
('Tramadol', 2, '4.00', '8.00', 22, 60, 'TABLET', '2020-07-08'),
('Paracetamol 500MG', 20, '2.00', '40.00', 23, 40, 'TABLET', '2020-07-08'),
('Metoclopramide', 2, '5.00', '10.00', 24, 30, 'CAPSULES ', '2020-07-08');

-- --------------------------------------------------------

--
-- Table structure for table `sign_in`
--

CREATE TABLE `sign_in` (
  `First_Name` varchar(50) NOT NULL,
  `Sure_Name` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Phone_Num` int(11) NOT NULL,
  `Date_O_Birth` date NOT NULL,
  `PassWord` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sign_in`
--

INSERT INTO `sign_in` (`First_Name`, `Sure_Name`, `Email`, `Phone_Num`, `Date_O_Birth`, `PassWord`) VALUES
('NANA', 'AKUA', 'NAN@GMAIL.COM', 4, '2020-02-12', 'KKKK'),
('NELSON', 'ASOMANI', '@MAIL.C0M', 12, '2020-02-12', 'NEL'),
('WINNER', 'WILLIAMS', 'WINER@GMAIL.COM', 403930, '1988-12-26', 'WINNER');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `drugslist_tb`
--
ALTER TABLE `drugslist_tb`
  ADD PRIMARY KEY (`DrugsID`);

--
-- Indexes for table `drug_purchased`
--
ALTER TABLE `drug_purchased`
  ADD PRIMARY KEY (`TxtCode`);

--
-- Indexes for table `sales_appointment`
--
ALTER TABLE `sales_appointment`
  ADD PRIMARY KEY (`SALES_ID`);

--
-- Indexes for table `sign_in`
--
ALTER TABLE `sign_in`
  ADD PRIMARY KEY (`Phone_Num`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `drugslist_tb`
--
ALTER TABLE `drugslist_tb`
  MODIFY `DrugsID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4546;

--
-- AUTO_INCREMENT for table `sales_appointment`
--
ALTER TABLE `sales_appointment`
  MODIFY `SALES_ID` int(99) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
