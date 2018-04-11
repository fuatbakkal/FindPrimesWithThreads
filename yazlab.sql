--
-- Drop if `sayilar` exists
--
DROP TABLE IF EXISTS sayilar;

--
-- Create Table structure for table `sayilar`
--
CREATE TABLE `sayilar` (
  `no` int unsigned NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `sayi` int unsigned NOT NULL
) COLLATE 'utf8_turkish_ci';

--
-- Dumping data for table `sayilar`
--
INSERT INTO `sayilar` (`no`, `sayi`) VALUES
(1, 2),
(2, 3),
(3, 5),
(4, 7),
(5, 11),
(6, 13);