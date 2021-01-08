use `session2_xx`;
/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


DROP TABLE IF EXISTS `aircrafts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aircrafts` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) COLLATE utf8_bin NOT NULL,
  `MakeModel` varchar(10) COLLATE utf8_bin DEFAULT NULL,
  `TotalSeats` int(11) NOT NULL,
  `EconomySeats` int(11) NOT NULL,
  `BusinessSeats` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;



LOCK TABLES `aircrafts` WRITE;
/*!40000 ALTER TABLE `aircrafts` DISABLE KEYS */;
INSERT INTO `aircrafts` VALUES (1,'Boeing 738','B738-1950',176,162,12),(2,'Boeing 739','B739-1954',169,96,51);
/*!40000 ALTER TABLE `aircrafts` ENABLE KEYS */;
UNLOCK TABLES;



DROP TABLE IF EXISTS `airports`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `airports` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CountryID` int(11) NOT NULL,
  `IATACode` varchar(3) COLLATE utf8_bin NOT NULL,
  `Name` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_AirPort_Country` (`CountryID`),
  CONSTRAINT `FK_AirPort_Country` FOREIGN KEY (`CountryID`) REFERENCES `countries` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;



LOCK TABLES `airports` WRITE;
/*!40000 ALTER TABLE `airports` DISABLE KEYS */;
INSERT INTO `airports` VALUES (2,185,'AUH','Abu Dhabi'),(3,52,'CAI','Cairo'),(4,13,'BAH','Bahrain'),(5,194,'ADE','Aden'),(6,142,'DOH','Doha'),(7,152,'RUH','Riyadh');
/*!40000 ALTER TABLE `airports` ENABLE KEYS */;
UNLOCK TABLES;



DROP TABLE IF EXISTS `countries`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `countries` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=197 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;


LOCK TABLES `countries` WRITE;
/*!40000 ALTER TABLE `countries` DISABLE KEYS */;
INSERT INTO `countries` VALUES (1,'Afghanistan'),(2,'Albania'),(3,'Algeria'),(4,'Andorra'),(5,'Angola'),(6,'Antigua & Deps'),(7,'Argentina'),(8,'Armenia'),(9,'Australia'),(10,'Austria'),(11,'Azerbaijan'),(12,'Bahamas'),(13,'Bahrain'),(14,'Bangladesh'),(15,'Barbados'),(16,'Belarus'),(17,'Belgium'),(18,'Belize'),(19,'Benin'),(20,'Bhutan'),(21,'Bolivia'),(22,'Bosnia Herzegovina'),(23,'Botswana'),(24,'Brazil'),(25,'Brunei'),(26,'Bulgaria'),(27,'Burkina'),(28,'Burundi'),(29,'Cambodia'),(30,'Cameroon'),(31,'Canada'),(32,'Cape Verde'),(33,'Central African Rep'),(34,'Chad'),(35,'Chile'),(36,'China'),(37,'Colombia'),(38,'Comoros'),(39,'Congo'),(40,'Congo {Democratic Rep}'),(41,'Costa Rica'),(42,'Croatia'),(43,'Cuba'),(44,'Cyprus'),(45,'Czech Republic'),(46,'Denmark'),(47,'Djibouti'),(48,'Dominica'),(49,'Dominican Republic'),(50,'East Timor'),(51,'Ecuador'),(52,'Egypt'),(53,'El Salvador'),(54,'Equatorial Guinea'),(55,'Eritrea'),(56,'Estonia'),(57,'Ethiopia'),(58,'Fiji'),(59,'Finland'),(60,'France'),(61,'Gabon'),(62,'Gambia'),(63,'Georgia'),(64,'Germany'),(65,'Ghana'),(66,'Greece'),(67,'Grenada'),(68,'Guatemala'),(69,'Guinea'),(70,'Guinea-Bissau'),(71,'Guyana'),(72,'Haiti'),(73,'Honduras'),(74,'Hungary'),(75,'Iceland'),(76,'India'),(77,'Indonesia'),(78,'Iran'),(79,'Iraq'),(80,'Ireland {Republic}'),(81,'Israel'),(82,'Italy'),(83,'Ivory Coast'),(84,'Jamaica'),(85,'Japan'),(86,'Jordan'),(87,'Kazakhstan'),(88,'Kenya'),(89,'Kiribati'),(90,'Korea North'),(91,'Korea South'),(92,'Kosovo'),(93,'Kuwait'),(94,'Kyrgyzstan'),(95,'Laos'),(96,'Latvia'),(97,'Lebanon'),(98,'Lesotho'),(99,'Liberia'),(100,'Libya'),(101,'Liechtenstein'),(102,'Lithuania'),(103,'Luxembourg'),(104,'Macedonia'),(105,'Madagascar'),(106,'Malawi'),(107,'Malaysia'),(108,'Maldives'),(109,'Mali'),(110,'Malta'),(111,'Marshall Islands'),(112,'Mauritania'),(113,'Mauritius'),(114,'Mexico'),(115,'Micronesia'),(116,'Moldova'),(117,'Monaco'),(118,'Mongolia'),(119,'Montenegro'),(120,'Morocco'),(121,'Mozambique'),(122,'Myanmar, {Burma}'),(123,'Namibia'),(124,'Nauru'),(125,'Nepal'),(126,'Netherlands'),(127,'New Zealand'),(128,'Nicaragua'),(129,'Niger'),(130,'Nigeria'),(131,'Norway'),(132,'Oman'),(133,'Pakistan'),(134,'Palau'),(135,'Panama'),(136,'Papua New Guinea'),(137,'Paraguay'),(138,'Peru'),(139,'Philippines'),(140,'Poland'),(141,'Portugal'),(142,'Qatar'),(143,'Romania'),(144,'Russian Federation'),(145,'Rwanda'),(146,'St Kitts & Nevis'),(147,'St Lucia'),(148,'Saint Vincent & the Grenadines'),(149,'Samoa'),(150,'San Marino'),(151,'Sao Tome & Principe'),(152,'Saudi Arabia'),(153,'Senegal'),(154,'Serbia'),(155,'Seychelles'),(156,'Sierra Leone'),(157,'Singapore'),(158,'Slovakia'),(159,'Slovenia'),(160,'Solomon Islands'),(161,'Somalia'),(162,'South Africa'),(163,'South Sudan'),(164,'Spain'),(165,'Sri Lanka'),(166,'Sudan'),(167,'Suriname'),(168,'Swaziland'),(169,'Sweden'),(170,'Switzerland'),(171,'Syria'),(172,'Taiwan'),(173,'Tajikistan'),(174,'Tanzania'),(175,'Thailand'),(176,'Togo'),(177,'Tonga'),(178,'Trinidad & Tobago'),(179,'Tunisia'),(180,'Turkey'),(181,'Turkmenistan'),(182,'Tuvalu'),(183,'Uganda'),(184,'Ukraine'),(185,'United Arab Emirates'),(186,'United Kingdom'),(187,'United States'),(188,'Uruguay'),(189,'Uzbekistan'),(190,'Vanuatu'),(191,'Vatican City'),(192,'Venezuela'),(193,'Vietnam'),(194,'Yemen'),(195,'Zambia'),(196,'Zimbabwe');
/*!40000 ALTER TABLE `countries` ENABLE KEYS */;
UNLOCK TABLES;



DROP TABLE IF EXISTS `offices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `offices` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CountryID` int(11) NOT NULL,
  `Title` varchar(50) COLLATE utf8_bin NOT NULL,
  `Phone` varchar(50) COLLATE utf8_bin NOT NULL,
  `Contact` varchar(250) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_Office_Country` (`CountryID`),
  CONSTRAINT `FK_Office_Country` FOREIGN KEY (`CountryID`) REFERENCES `countries` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;



LOCK TABLES `offices` WRITE;
/*!40000 ALTER TABLE `offices` DISABLE KEYS */;
INSERT INTO `offices` VALUES (1,185,'Abu dhabi','638-757-8582\r\n','MIchael Malki'),(3,52,'Cairo','252-224-8525','David Johns'),(4,13,'Bahrain','542-227-5825','Katie Ballmer'),(5,142,'Doha','758-278-9597','Ariel Levy'),(6,152,'Riyadh','285-285-1474','Andrew Hobart');
/*!40000 ALTER TABLE `offices` ENABLE KEYS */;
UNLOCK TABLES;



DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `roles` (
  `ID` int(11) NOT NULL,
  `Title` varchar(50) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;



LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Administrator'),(2,'User');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;



DROP TABLE IF EXISTS `routes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `routes` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `DepartureAirportID` int(11) NOT NULL,
  `ArrivalAirportID` int(11) NOT NULL,
  `Distance` int(11) NOT NULL,
  `FlightTime` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_Routes_Airports2` (`DepartureAirportID`),
  KEY `FK_Routes_Airports3` (`ArrivalAirportID`),
  CONSTRAINT `FK_Routes_Airports2` FOREIGN KEY (`DepartureAirportID`) REFERENCES `airports` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Routes_Airports3` FOREIGN KEY (`ArrivalAirportID`) REFERENCES `airports` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;


LOCK TABLES `routes` WRITE;
/*!40000 ALTER TABLE `routes` DISABLE KEYS */;
INSERT INTO `routes` VALUES (1,2,4,453,64),(2,4,2,455,69),(3,2,5,1636,152),(5,5,2,1632,150),(6,2,7,807,90),(7,7,2,810,89),(8,2,6,325,54),(9,6,2,325,54),(10,6,3,2057,183),(11,3,6,2050,177),(12,2,3,2381,264),(13,3,2,2385,274),(14,2,3,2381,208),(15,3,2,2381,211);
/*!40000 ALTER TABLE `routes` ENABLE KEYS */;
UNLOCK TABLES;



DROP TABLE IF EXISTS `schedules`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `schedules` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Date` date NOT NULL,
  `Time` time NOT NULL,
  `AircraftID` int(11) NOT NULL,
  `RouteID` int(11) NOT NULL,
  `EconomyPrice` double NOT NULL,
  `Confirmed` tinyint(1) NOT NULL,
  `FlightNumber` varchar(10) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_Schedule_AirCraft` (`AircraftID`),
  KEY `FK_Schedule_Routes` (`RouteID`),
  CONSTRAINT `FK_Schedule_AirCraft` FOREIGN KEY (`AircraftID`) REFERENCES `aircrafts` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Schedule_Routes` FOREIGN KEY (`RouteID`) REFERENCES `routes` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;


LOCK TABLES `schedules` WRITE;
/*!40000 ALTER TABLE `schedules` DISABLE KEYS */;
INSERT INTO `schedules` VALUES (1,'2017-10-04','17:00:00',1,1,620,1,'49'),(2,'2017-10-04','21:09:00',1,2,590,1,'50'),(3,'2017-10-05','17:00:00',1,1,448,1,'49'),(4,'2017-10-05','21:09:00',1,2,500,1,'50'),(5,'2017-10-06','17:00:00',1,1,697,1,'49'),(6,'2017-10-06','21:09:00',1,2,504,1,'50'),(7,'2017-10-07','17:00:00',1,1,449,1,'49'),(8,'2017-10-07','21:09:00',1,2,405,1,'50'),(9,'2017-10-08','17:00:00',1,1,494,1,'49'),(10,'2017-10-08','21:09:00',1,2,429,1,'50'),(11,'2017-10-09','17:00:00',1,1,627,1,'49'),(12,'2017-10-09','21:09:00',1,2,545,1,'50'),(13,'2017-10-10','17:00:00',1,1,637,1,'49'),(14,'2017-10-10','21:09:00',1,2,489,1,'50'),(15,'2017-10-11','17:00:00',1,1,421,1,'49'),(16,'2017-10-11','21:09:00',1,2,476,1,'50'),(17,'2017-10-12','17:00:00',1,1,484,1,'49'),(18,'2017-10-12','21:09:00',1,2,440,1,'50'),(19,'2017-10-13','17:00:00',1,1,464,1,'49'),(20,'2017-10-13','21:09:00',1,2,661,1,'50'),(21,'2017-10-14','17:00:00',1,1,437,1,'49'),(22,'2017-10-14','21:09:00',1,2,493,1,'50'),(23,'2017-10-15','17:00:00',1,1,699,1,'49'),(24,'2017-10-15','21:09:00',1,2,608,1,'50'),(25,'2017-10-16','17:00:00',1,1,417,1,'49'),(26,'2017-10-16','21:09:00',1,2,577,1,'50'),(27,'2017-10-17','17:00:00',1,1,458,1,'49'),(28,'2017-10-17','21:09:00',1,2,429,1,'50'),(29,'2017-10-18','17:00:00',1,1,686,1,'49'),(30,'2017-10-18','21:09:00',1,2,692,1,'50'),(31,'2017-10-19','17:00:00',1,1,482,1,'49'),(32,'2017-10-19','21:09:00',1,2,612,1,'50'),(33,'2017-10-20','17:00:00',1,1,620,1,'49'),(34,'2017-10-20','21:09:00',1,2,432,1,'50'),(35,'2017-10-21','17:00:00',1,1,480,1,'49'),(36,'2017-10-21','21:09:00',1,2,582,1,'50'),(37,'2017-10-22','17:00:00',1,1,453,1,'49'),(38,'2017-10-22','21:09:00',1,2,537,1,'50'),(39,'2017-10-23','17:00:00',1,1,537,1,'49'),(40,'2017-10-23','21:09:00',1,2,578,1,'50'),(41,'2017-10-24','17:00:00',1,1,571,1,'49'),(42,'2017-10-24','21:09:00',1,2,532,1,'50'),(43,'2017-10-25','17:00:00',1,1,544,1,'49'),(44,'2017-10-25','21:09:00',1,2,634,1,'50'),(45,'2017-10-26','17:00:00',1,1,494,1,'49'),(46,'2017-10-26','21:09:00',1,2,625,1,'50'),(47,'2017-10-27','17:00:00',1,1,406,1,'49'),(48,'2017-10-27','21:09:00',1,2,578,1,'50'),(49,'2017-10-28','17:00:00',1,1,537,1,'49'),(50,'2017-10-28','21:09:00',1,2,440,1,'50');
/*!40000 ALTER TABLE `schedules` ENABLE KEYS */;
UNLOCK TABLES;

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `ID` int(11) NOT NULL,
  `RoleID` int(11) NOT NULL,
  `Email` varchar(150) COLLATE utf8_bin NOT NULL,
  `Password` varchar(50) COLLATE utf8_bin NOT NULL,
  `FirstName` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `LastName` varchar(50) COLLATE utf8_bin NOT NULL,
  `OfficeID` int(11) DEFAULT NULL,
  `Birthdate` date DEFAULT NULL,
  `Active` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_Users_Offices` (`OfficeID`),
  KEY `FK_Users_Roles` (`RoleID`),
  CONSTRAINT `FK_Users_Offices` FOREIGN KEY (`OfficeID`) REFERENCES `offices` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Users_Roles` FOREIGN KEY (`RoleID`) REFERENCES `roles` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;


LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,1,'j.doe@amonic.com','123','John','Doe',1,'1983-01-13',1),(2,2,'k.omar@amonic.com','4258','Karim','Omar',1,'1980-03-19',1),(3,2,'h.saeed@amonic.com','2020','Hannan','Saeed',3,'1989-12-20',1),(4,2,'a.hobart@amonic.com','6996','Andrew','Hobart',6,'1990-01-30',1),(5,2,'k.anderson@amonic.com','4570','Katrin','Anderson',5,'1992-11-10',1),(6,2,'h.wyrick@amonic.com','1199','Hava','Wyrick',1,'1988-08-08',1),(7,2,'marie.horn@amonic.com','55555','Marie','Horn',4,'1981-04-06',1),(8,2,'m.osteen@amonic.com','9800','Milagros','Osteen',1,'1991-02-03',1);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
