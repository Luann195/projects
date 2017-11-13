-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 13, 2017 at 01:00 PM
-- Server version: 10.1.25-MariaDB
-- PHP Version: 7.1.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `reportcard`
--

-- --------------------------------------------------------

--
-- Table structure for table `ca`
--

CREATE TABLE `ca` (
  `id` int(11) NOT NULL,
  `student_id` varchar(100) NOT NULL,
  `entry_date` varchar(200) NOT NULL,
  `english_ca` varchar(100) NOT NULL,
  `maths_ca` varchar(100) NOT NULL,
  `rme_ca` varchar(100) NOT NULL,
  `science_ca` varchar(100) NOT NULL,
  `french_ca` varchar(100) NOT NULL,
  `twi_ca` varchar(100) NOT NULL,
  `ict_ca` varchar(100) NOT NULL,
  `social_ca` varchar(100) NOT NULL,
  `bdt_ca` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ca`
--

INSERT INTO `ca` (`id`, `student_id`, `entry_date`, `english_ca`, `maths_ca`, `rme_ca`, `science_ca`, `french_ca`, `twi_ca`, `ict_ca`, `social_ca`, `bdt_ca`) VALUES
(6, '2142292', '25/Oct/2017', '10', '12', '25', '10', '17', '11', '10', '18', '0'),
(7, '21456416', '30/Oct/2017', '12', '23', '30', '30', '25', '25', '24', '29', '0');

-- --------------------------------------------------------

--
-- Table structure for table `exams_marks`
--

CREATE TABLE `exams_marks` (
  `id` int(11) NOT NULL,
  `student_id` varchar(100) NOT NULL,
  `entry_date` varchar(200) NOT NULL,
  `english_m` varchar(100) NOT NULL,
  `maths_m` varchar(100) NOT NULL,
  `rme_m` varchar(100) NOT NULL,
  `science_m` varchar(100) NOT NULL,
  `french_m` varchar(100) NOT NULL,
  `twi_m` varchar(100) NOT NULL,
  `ict_m` varchar(100) NOT NULL,
  `social_m` varchar(100) NOT NULL,
  `bdt_m` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `exams_marks`
--

INSERT INTO `exams_marks` (`id`, `student_id`, `entry_date`, `english_m`, `maths_m`, `rme_m`, `science_m`, `french_m`, `twi_m`, `ict_m`, `social_m`, `bdt_m`) VALUES
(7, '2142292', '25/Oct/2017', '30', '30', '45', '17', '40', '40', '29', '50', '0'),
(8, '21456416', '30/Oct/2017', '50', '50', '60', '63', '40', '40', '50', '60', '0');

-- --------------------------------------------------------

--
-- Table structure for table `marks`
--

CREATE TABLE `marks` (
  `mark_id` int(11) NOT NULL,
  `student_id` varchar(100) NOT NULL,
  `student_name` varchar(200) NOT NULL,
  `class_form` varchar(10) NOT NULL,
  `year` varchar(40) NOT NULL,
  `term` varchar(10) NOT NULL,
  `entry_date` varchar(100) NOT NULL,
  `english_em` varchar(100) NOT NULL,
  `maths_em` varchar(100) NOT NULL,
  `rme_em` varchar(100) NOT NULL,
  `science_em` varchar(100) NOT NULL,
  `french_em` varchar(100) NOT NULL,
  `twi_em` varchar(100) NOT NULL,
  `ict_em` varchar(100) NOT NULL,
  `social_em` varchar(100) NOT NULL,
  `bdt_em` varchar(100) NOT NULL,
  `total_marks` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `marks`
--

INSERT INTO `marks` (`mark_id`, `student_id`, `student_name`, `class_form`, `year`, `term`, `entry_date`, `english_em`, `maths_em`, `rme_em`, `science_em`, `french_em`, `twi_em`, `ict_em`, `social_em`, `bdt_em`, `total_marks`) VALUES
(42, '21422972', 'Adams Iddrisu', '3', '2017/18', 'Justify', '25/Oct/2017', '40', '42', '70', '27', '57', '51', '39', '68', '0', '394'),
(43, '21456416', 'Afram Maxwell', '3', '2017/18', 'Justify', '30/Oct/2017', '62', '73', '90', '93', '65', '65', '74', '89', '0', '611');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `id` int(11) NOT NULL,
  `student_id` varchar(100) NOT NULL,
  `student_name` varchar(200) NOT NULL,
  `reg_date` varchar(100) NOT NULL,
  `add_class` varchar(60) NOT NULL,
  `res_info` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`id`, `student_id`, `student_name`, `reg_date`, `add_class`, `res_info`) VALUES
(7, '21419918', 'Amoako Yeaboah Austin ', '20/Oct/2017', '1', 'Day'),
(8, '21467115', 'Acheampong Gerrard', '20/Oct/2017', '1', 'Day'),
(9, '21447877', 'Ahmmed Abu', '20/Oct/2017', '1', 'Day'),
(10, '21422454', 'Anane Regan', '20/Oct/2017', '1', 'Hostel'),
(11, '21451697', 'Baba Amoro Asuma', '20/Oct/2017', '1', 'Day'),
(12, '21456726', 'Emmanuel K. Debra Akola', '20/Oct/2017', '1', 'Day'),
(13, '21418467', 'Gyabaa Bismark', '20/Oct/2017', '1', 'Day'),
(14, '21413979', 'Ibrahim Habibu', '20/Oct/2017', '1', 'Boarding'),
(15, '21447761', 'Kyere Godfred', '20/Oct/2017', '1', 'Day'),
(16, '21429242', 'Kwabena Obeng Frimpong', '20/Oct/2017', '1', 'Day'),
(17, '21478887', 'Kuffour Samuel', '20/Oct/2017', '1', 'Hostel'),
(18, '21436321', 'Kinsford Awua', '20/Oct/2017', '1', 'Day'),
(19, '21444271', 'Nyarko Ernest', '20/Oct/2017', '1', 'Day'),
(20, '21421885', 'Nyaw Charles', '20/Oct/2017', '1', 'Day'),
(21, '21459916', 'Opoku Koosono Seedof', '20/Oct/2017', '1', 'Day'),
(22, '21465684', 'Sakpa Chanem Pierrot', '20/Oct/2017', '1', 'Day'),
(23, '21416815', 'Siaka Mumuni', '20/Oct/2017', '1', 'Day'),
(24, '21444828', 'Obed Asamoah', '20/Oct/2017', '1', 'Boarding'),
(25, '21495258', 'Yussif Alhassan', '20/Oct/2017', '1', 'Day'),
(26, '21425885', 'Asana Alhassan', '20/Oct/2017', '1', 'Day'),
(27, '21478132', 'Akosua Cecelia', '20/Oct/2017', '1', 'Day'),
(28, '21417811', 'Ankamah Josephine', '20/Oct/2017', '1', 'Day'),
(29, '21422596', 'Asana Yakubu', '20/Oct/2017', '1', 'Day'),
(30, '21434259', 'Akuamoah Boateng Daniella', '20/Oct/2017', '1', 'Day'),
(31, '21472326', 'Aaniirekuu Jane', '20/Oct/2017', '1', 'Boarding'),
(32, '21493478', 'Abisa Felicity', '20/Oct/2017', '1', 'Day'),
(33, '21447548', 'Agyepofowaa Belinda', '20/Oct/2017', '1', 'Day'),
(34, '21437197', 'Boahemaa Josephine ', '20/Oct/2017', '1', 'Day'),
(35, '21496697', 'Bassofa Evelyn Queen', '20/Oct/2017', '1', 'Day'),
(36, '21456334', 'Fati Lagazani ', '20/Oct/2017', '1', 'Day'),
(37, '21411898', 'Fati Abdul-Raman', '20/Oct/2017', '1', 'Day'),
(38, '21422677', 'Fatima Adama', '20/Oct/2017', '1', 'Day'),
(39, '21471238', 'Fiona Boabeng Danquah', '20/Oct/2017', '1', 'Day'),
(40, '21435889', 'Jennifer Addae', '20/Oct/2017', '1', 'Hostel'),
(41, '21468658', 'Linda Adwoa Manu', '20/Oct/2017', '1', 'Day'),
(42, '21484453', 'Mariama Amidu', '20/Oct/2017', '1', 'Day'),
(43, '21441998', 'Mariama Ibrahim', '20/Oct/2017', '1', 'Day'),
(44, '21411316', 'Mariama Sule', '20/Oct/2017', '1', 'Day'),
(45, '21497778', 'Owusuwaa Ama Constance', '20/Oct/2017', '1', 'Day'),
(46, '21499136', 'Owusu Florence', '20/Oct/2017', '1', 'Hostel'),
(47, '21483599', 'Siata Issifu ', '20/Oct/2017', '1', 'Day'),
(48, '21449991', 'Sharifatu Musah', '20/Oct/2017', '1', 'Day'),
(49, '21459116', 'Sharifatu Inusah', '20/Oct/2017', '1', 'Day'),
(50, '21492214', 'Sarfowaa Sarah', '20/Oct/2017', '1', 'Boarding'),
(51, '21478486', 'Richelle Owusu Ansah', '20/Oct/2017', '1', 'Day'),
(52, '21451495', 'Yeli Abena Grace', '20/Oct/2017', '1', 'Day'),
(53, '21449424', 'Zainab Damptey', '20/Oct/2017', '1', 'Day'),
(54, '21493264', 'Abdul Kuduus Salifu', '20/Oct/2017', '1', 'Day'),
(55, '21453849', 'Alhassan Fuseini', '20/Oct/2017', '1', 'Day'),
(56, '21421451', 'Agyepomaa Natashia', '20/Oct/2017', '1', 'Day'),
(57, '21456416', 'Afram Maxwell', '22/Oct/2017', '3', 'Day'),
(58, '21422972', 'Adams Iddrisu', '22/Oct/2017', '3', 'Day'),
(59, '21493382', 'Alhassan Ibrahim ', '22/Oct/2017', '3', 'Day'),
(60, '21471624', 'Alhassan Ibrahim Barus', '22/Oct/2017', '3', 'Hostel'),
(61, '21441443', 'Akomea Corlenius', '22/Oct/2017', '3', 'Day'),
(62, '21411551', 'Alhaji Dauda', '22/Oct/2017', '3', 'Day'),
(63, '21486218', 'Abdul Rauf ', '22/Oct/2017', '3', 'Day'),
(65, '21448177', 'Asum Carlos', '22/Oct/2017', '3', 'Hostel'),
(66, '21444539', 'Amoako Benjamin', '22/Oct/2017', '3', 'Day'),
(67, '21463491', 'Amofa Kwasi Joseph ', '22/Oct/2017', '3', 'Day'),
(68, '21468754', 'Adinkra Ebenezer ', '22/Oct/2017', '3', 'Hostel'),
(69, '21459728', 'Biagah Joseph ', '22/Oct/2017', '3', 'Hostel'),
(70, '21421934', 'Sange-Mensah Cephas', '22/Oct/2017', '3', 'Day'),
(71, '21472176', 'Sah Kwame Shadrack ', '22/Oct/2017', '3', 'Day'),
(72, '21493389', 'Samiru Sule ', '22/Oct/2017', '3', 'Day'),
(73, '21458651', 'Ibrahim Faruck ', '22/Oct/2017', '3', 'Day'),
(74, '21442895', 'Foster Osei', '22/Oct/2017', '3', 'Day'),
(75, '21453274', 'Peh Sylvester ', '22/Oct/2017', '3', 'Day'),
(76, '21452949', 'Eric Adjei', '22/Oct/2017', '3', 'Day'),
(77, '21419871', 'Ntiako Clinton', '22/Oct/2017', '3', 'Hostel'),
(78, '21444534', 'Yeboah Kwabena Sule ', '22/Oct/2017', '3', 'Boarding'),
(79, '21462793', 'Ignatius Addae Adjei Yomaah', '22/Oct/2017', '3', 'Hostel'),
(80, '21433188', 'Aisha Asumah ', '22/Oct/2017', '3', 'Day'),
(81, '21493743', 'Amina Kassum', '22/Oct/2017', '3', 'Day'),
(82, '21415663', 'Aurrin Amponsah', '22/Oct/2017', '3', 'Day'),
(83, '21459745', 'Asana Habib', '22/Oct/2017', '3', 'Day'),
(84, '21422421', 'Agyeiwaa Alexandra', '22/Oct/2017', '3', 'Day'),
(85, '21468188', 'Addae Saahene Cindy', '22/Oct/2017', '3', 'Day'),
(86, '21419993', 'Adwoa Rebecca', '22/Oct/2017', '3', 'Day'),
(87, '21487272', 'Adubea Priscilla ', '22/Oct/2017', '3', 'Hostel'),
(88, '21468742', 'Bernice Demo', '22/Oct/2017', '3', 'Day'),
(89, '21489212', 'Doreen Amponsah', '22/Oct/2017', '3', 'Day'),
(90, '21488176', 'Dorithy Peyepepei', '22/Oct/2017', '3', 'Day'),
(91, '21455836', 'Firdaus Salu', '22/Oct/2017', '3', 'Day'),
(92, '21483333', 'Siata Moro', '22/Oct/2017', '3', 'Day'),
(93, '21492565', 'Fati Abu', '22/Oct/2017', '3', 'Day'),
(94, '21419835', 'Stacy Mariama Offei', '22/Oct/2017', '3', 'Day'),
(95, '21488895', 'Twenewaa Mary', '22/Oct/2017', '3', 'Day'),
(96, '21448256', 'Kuruwaa Linda', '22/Oct/2017', '3', 'Hostel'),
(97, '21488792', 'Owusuwaa Rita', '22/Oct/2017', '3', 'Day'),
(98, '21415681', 'Yeli Gloria ', '22/Oct/2017', '3', 'Day'),
(99, '21434738', 'Yeli Perpetual', '22/Oct/2017', '3', 'Day'),
(100, '21422165', 'Appiah Kubi Andy Junior ', '23/Oct/2017', '2', 'Day'),
(101, '21427566', 'Ahenkan Festus', '23/Oct/2017', '2', 'Hostel'),
(102, '21477921', 'Amadu Sule', '23/Oct/2017', '2', 'Day'),
(103, '21425678', 'Ahmmed Siaka', '23/Oct/2017', '2', 'Day'),
(104, '21498697', 'Ankamah Emmanuel', '23/Oct/2017', '2', 'Day'),
(105, '21484815', 'Asante Vincent ', '23/Oct/2017', '2', 'Boarding'),
(106, '21488918', 'Bismark Sam', '23/Oct/2017', '2', 'Day'),
(107, '21443944', 'Obed Owusu', '23/Oct/2017', '2', 'Day'),
(108, '21442742', 'Ishack Alhassan ', '23/Oct/2017', '2', 'Day'),
(109, '21438186', 'Sumaila Iddrisu', '23/Oct/2017', '2', 'Day'),
(110, '21486854', 'Sie K. Julious', '23/Oct/2017', '2', 'Day'),
(111, '21484849', 'Alfred Asare ', '23/Oct/2017', '2', 'Day'),
(112, '21496823', 'Iseal Obeng ', '23/Oct/2017', '2', 'Day'),
(113, '21466563', 'Osei Boateng Romeo ', '23/Oct/2017', '2', 'Day'),
(114, '21473923', 'Mahama Abu', '23/Oct/2017', '2', 'Day'),
(115, '21498193', 'Abdul Mumin', '23/Oct/2017', '2', 'Day'),
(116, '21458277', 'Mordo Yaw Raymond', '23/Oct/2017', '2', 'Day'),
(117, '21427319', 'Sule Mohammed', '23/Oct/2017', '2', 'Hostel'),
(118, '21445122', 'Ameyaa Jennifer ', '23/Oct/2017', '2', 'Day'),
(119, '21433345', 'Afrah Yaa Monica', '23/Oct/2017', '2', 'Day'),
(120, '21467428', 'Aisha Ibrahim', '23/Oct/2017', '2', 'Day'),
(121, '21427864', 'Asare Ama Julliet', '23/Oct/2017', '2', 'Day'),
(122, '21424342', 'Adubea Tabita', '23/Oct/2017', '2', 'Day'),
(123, '21485586', 'Ajara Kassoum ', '23/Oct/2017', '2', 'Day'),
(124, '21456548', 'Bintu Dauda', '23/Oct/2017', '2', 'Day'),
(125, '21435733', 'Linda Asante ', '23/Oct/2017', '2', 'Day'),
(126, '21434964', 'Ellen Abena Kasipe', '23/Oct/2017', '2', 'Day'),
(127, '21444216', 'Twene Amofa Eunice', '23/Oct/2017', '2', 'Day'),
(128, '21472691', 'Serwaa Ama Frimpong', '23/Oct/2017', '2', 'Day'),
(129, '21482726', 'Kusi Henewaa Stephanie ', '23/Oct/2017', '2', 'Day'),
(130, '21419896', 'Twenewaa Precious ', '23/Oct/2017', '2', 'Day'),
(131, '21425861', 'Kyerewaa Francisca', '23/Oct/2017', '2', 'Day'),
(132, '21476929', 'Sharifatu Bamba ', '23/Oct/2017', '2', 'Day'),
(133, '21449672', 'Mama Jara Asumah ', '23/Oct/2017', '2', 'Day'),
(134, '21424734', 'Latifatu Lagazani ', '23/Oct/2017', '2', 'Day'),
(135, '21414333', 'Nasibatu Kassim', '23/Oct/2017', '2', 'Day'),
(136, '21487358', 'Jennifer Incoom', '23/Oct/2017', '2', 'Day'),
(137, '21453914', 'Victoria Derry', '23/Oct/2017', '2', 'Day'),
(138, '21448318', 'Yeboah Patricia ', '23/Oct/2017', '2', 'Day'),
(139, '21497651', 'Kintor Yaa Andrea ', '23/Oct/2017', '2', 'Day'),
(140, '21494418', 'Salamatu Adama ', '23/Oct/2017', '2', 'Day'),
(141, '21427743', 'Obeng Angela ', '23/Oct/2017', '2', 'Day'),
(142, '21438417', 'Obah Akosua Vivian ', '23/Oct/2017', '2', 'Day'),
(143, '21422845', 'Suma Charlotte', '23/Oct/2017', '2', 'Day'),
(144, '21467582', 'Ofori Asubonteng Eugenia ', '23/Oct/2017', '2', 'Hostel');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `ID` int(10) NOT NULL,
  `UserID` varchar(20) NOT NULL,
  `UserType` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `Name` varchar(45) NOT NULL,
  `EmailID` varchar(100) NOT NULL,
  `ContactNo` varchar(45) NOT NULL,
  `JoiningDate` varchar(70) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`ID`, `UserID`, `UserType`, `Password`, `Name`, `EmailID`, `ContactNo`, `JoiningDate`) VALUES
(1, 'Admin', 'Administrator', 'admin', 'Admin', 'admin@gmail.com', '0545492592', '10/10/2017'),
(213716, 'Staff', 'Staff', '12345', 'Staff', 'staff@gmail.com', '0545492592', '10/16/2017');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ca`
--
ALTER TABLE `ca`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `exams_marks`
--
ALTER TABLE `exams_marks`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `marks`
--
ALTER TABLE `marks`
  ADD PRIMARY KEY (`mark_id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `ca`
--
ALTER TABLE `ca`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `exams_marks`
--
ALTER TABLE `exams_marks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `marks`
--
ALTER TABLE `marks`
  MODIFY `mark_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;
--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=145;
--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=213717;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
