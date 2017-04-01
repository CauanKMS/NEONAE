-- MySQL dump 10.13  Distrib 5.1.73, for Win64 (unknown)
--
-- Host: localhost    Database: neonae
-- ------------------------------------------------------
-- Server version	5.1.73-community

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

--
-- Current Database: `neonae`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `neonae` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `neonae`;

--
-- Temporary table structure for view `admeventos`
--

DROP TABLE IF EXISTS `admeventos`;
/*!50001 DROP VIEW IF EXISTS `admeventos`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `admeventos` (
 `id` tinyint NOT NULL,
  `nome_evento` tinyint NOT NULL,
  `tipo` tinyint NOT NULL,
  `faet` tinyint NOT NULL,
  `local` tinyint NOT NULL,
  `startdata` tinyint NOT NULL,
  `fimdata` tinyint NOT NULL,
  `starthora` tinyint NOT NULL,
  `fimhr` tinyint NOT NULL,
  `empresa` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `aud_adm`
--

DROP TABLE IF EXISTS `aud_adm`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aud_adm` (
  `id_auda` int(11) NOT NULL AUTO_INCREMENT,
  `id_adm` int(11) NOT NULL,
  `tabelamod_adm` text NOT NULL,
  `desc_adm` text NOT NULL,
  `hora_adm` text NOT NULL,
  `data_adm` text NOT NULL,
  PRIMARY KEY (`id_auda`),
  KEY `id_adm` (`id_adm`),
  CONSTRAINT `aud_adm_ibfk_1` FOREIGN KEY (`id_adm`) REFERENCES `usuario` (`id_usu`)
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aud_adm`
--

LOCK TABLES `aud_adm` WRITE;
/*!40000 ALTER TABLE `aud_adm` DISABLE KEYS */;
INSERT INTO `aud_adm` VALUES (1,1,'Usuario','O Primeiro Administrador foi cadastrado','08:00','2016/12/01'),(2,1,'Usuario','Logou na conta','08:01','2016/12/01'),(3,1,'Usuário','Atualizou as informações do seu perfil','08:02','2016/12/01'),(4,1,'Evento','Vizualizou as informações de um evento escolhido','08:24','2016/12/01'),(5,1,'Evento','Autorizou um Evento','08:24','2016/12/01'),(6,1,'Evento','Vizualizou as informações de um evento escolhido','08:31','2016/12/01'),(7,1,'Evento','Negou a Autorização do Evento','08:31','2016/12/01'),(8,1,'Evento','Enviou um Email a empresa que cadastrou o evento','08:31','2016/12/01'),(9,1,'Evento','Vizualizou as informações de um evento escolhido','08:34','2016/12/01'),(10,1,'Evento','Vizualizou as informações de um evento escolhido','08:34','2016/12/01'),(11,1,'Evento','Autorizou um Evento','08:34','2016/12/01'),(12,1,'Evento','Vizualizou as informações de um evento escolhido','08:35','2016/12/01'),(13,1,'Evento','Autorizou um Evento','08:36','2016/12/01'),(14,1,'Evento','Vizualizou as informações de um evento escolhido','08:38','2016/12/01'),(15,1,'Evento','Autorizou um Evento','08:38','2016/12/01'),(16,1,'Usuario','Logou na conta','08:58','2016/12/01'),(17,1,'Evento','Vizualizou as informações de um evento escolhido','08:58','2016/12/01'),(18,1,'Evento','Negou a Autorização do Evento','08:58','2016/12/01'),(19,1,'Evento','Enviou um Email a empresa que cadastrou o evento','08:58','2016/12/01'),(20,1,'Usuario','Logou na conta','09:00','2016/12/01'),(21,1,'Evento','Vizualizou as informações de um evento escolhido','09:01','2016/12/01'),(22,1,'Evento','Negou a Autorização do Evento','09:01','2016/12/01'),(23,1,'Evento','Enviou um Email a empresa que cadastrou o evento','09:01','2016/12/01'),(24,1,'Usuario','Logou na conta','09:07','2016/12/01'),(25,1,'Evento','Vizualizou as informações de um evento escolhido','09:07','2016/12/01'),(26,1,'Evento','Negou a Autorização do Evento','09:08','2016/12/01'),(27,1,'Evento','Enviou um Email a empresa que cadastrou o evento','09:08','2016/12/01'),(28,1,'Evento','Vizualizou as informações de um evento escolhido','09:17','2016/12/01'),(29,1,'Evento','Autorizou um Evento','09:17','2016/12/01'),(30,1,'Evento','Vizualizou as informações de um evento escolhido','09:24','2016/12/01'),(31,1,'Evento','Autorizou um Evento','09:24','2016/12/01'),(32,1,'Evento','Vizualizou as informações de um evento escolhido','09:43','2016/12/01'),(33,1,'Evento','Autorizou um Evento','09:43','2016/12/01'),(34,1,'Evento','Vizualizou as informações de um evento escolhido','09:58','2016/12/01'),(35,1,'Evento','Autorizou um Evento','09:58','2016/12/01'),(36,1,'Evento','Vizualizou as informações de um evento escolhido','10:14','2016/12/01'),(37,1,'Evento','Autorizou um Evento','10:14','2016/12/01'),(38,1,'Evento','Vizualizou as informações de um evento escolhido','11:39','2016/12/01'),(39,1,'Evento','Autorizou um Evento','11:39','2016/12/01'),(40,1,'Evento','Vizualizou as informações de um evento escolhido','11:39','2016/12/01'),(41,1,'Evento','Autorizou um Evento','11:40','2016/12/01'),(42,1,'Evento','Vizualizou as informações de um evento escolhido','11:40','2016/12/01'),(43,1,'Evento','Autorizou um Evento','11:40','2016/12/01'),(44,1,'Evento','Vizualizou as informações de um evento escolhido','11:41','2016/12/01'),(45,1,'Evento','Autorizou um Evento','11:41','2016/12/01'),(46,1,'Evento','Vizualizou as informações de um evento escolhido','14:51','2016/12/01'),(47,1,'Evento','Autorizou um Evento','14:51','2016/12/01'),(48,1,'Evento','Vizualizou as informações de um evento escolhido','16:12','2016/12/01'),(49,1,'Evento','Autorizou um Evento','16:12','2016/12/01'),(50,1,'Evento','Vizualizou as informações de um evento escolhido','17:13','2016/12/01'),(51,1,'Evento','Autorizou um Evento','17:14','2016/12/01'),(52,1,'Usuario','Logou na conta','19:00','2016/12/01'),(53,1,'Evento','Vizualizou as informações de um evento escolhido','21:02','2016/12/01'),(54,1,'Evento','Autorizou um Evento','21:02','2016/12/01'),(55,1,'Evento','Vizualizou as informações de um evento escolhido','21:18','2016/12/01'),(56,1,'Evento','Autorizou um Evento','21:18','2016/12/01'),(57,1,'Nenhuma','Fez o Backup do Banco de Dados do Projeto','21:20','2016/12/01');
/*!40000 ALTER TABLE `aud_adm` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aud_emp`
--

DROP TABLE IF EXISTS `aud_emp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aud_emp` (
  `id_aude` int(11) NOT NULL AUTO_INCREMENT,
  `id_emp` int(11) NOT NULL,
  `tabelamod_emp` text NOT NULL,
  `desc_emp` text NOT NULL,
  `hora_emp` text NOT NULL,
  `data_emp` text NOT NULL,
  PRIMARY KEY (`id_aude`),
  KEY `id_emp` (`id_emp`),
  CONSTRAINT `aud_emp_ibfk_1` FOREIGN KEY (`id_emp`) REFERENCES `cliente_emp` (`id_emp`)
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aud_emp`
--

LOCK TABLES `aud_emp` WRITE;
/*!40000 ALTER TABLE `aud_emp` DISABLE KEYS */;
INSERT INTO `aud_emp` VALUES (1,1,'cliente_emp','Criou a conta','8:06','01/12/2016'),(2,1,'cliente_emp','Logou na conta','8:06','01/12/2016'),(3,1,'cliente_emp','Saiu da conta','8:6','01/12/2016'),(4,2,'cliente_emp','Criou a conta','8:08','01/12/2016'),(5,3,'cliente_emp','Criou a conta','8:10','01/12/2016'),(6,3,'cliente_emp','Logou na conta','8:20','01/12/2016'),(7,3,'evento','Criando um evento','8:24','01/12/2016'),(8,3,'cliente_emp','Saiu da conta','8:24','01/12/2016'),(9,1,'cliente_emp','Logou na conta','8:25','01/12/2016'),(10,1,'cliente_emp','Logou na conta','8:29','01/12/2016'),(11,1,'cliente_emp','Logou na conta','8:30','01/12/2016'),(12,1,'evento','Criando um evento','8:31','01/12/2016'),(13,1,'evento','Criando um evento','8:34','01/12/2016'),(14,1,'evento','Alterou um evento','8:35','01/12/2016'),(15,1,'cliente_emp','Saiu da conta','8:36','01/12/2016'),(16,2,'cliente_emp','Logou na conta','8:36','01/12/2016'),(17,2,'evento','Criando um evento','8:38','01/12/2016'),(18,2,'cliente_emp','Saiu da conta','8:38','01/12/2016'),(19,1,'cliente_emp','Logou na conta','8:57','01/12/2016'),(20,1,'evento','Criando um evento','8:57','01/12/2016'),(21,1,'evento','Criando um evento','9:1','01/12/2016'),(22,1,'evento','Criando um evento','9:7','01/12/2016'),(23,1,'cliente_emp','Saiu da conta','9:8','01/12/2016'),(24,1,'cliente_emp','Logou na conta','9:16','01/12/2016'),(25,1,'evento','Alterou um evento','9:16','01/12/2016'),(26,1,'cliente_emp','Saiu da conta','9:18','01/12/2016'),(27,3,'cliente_emp','Logou na conta','9:22','01/12/2016'),(28,3,'evento','Alterou um evento','9:23','01/12/2016'),(29,3,'cliente_emp','Saiu da conta','9:24','01/12/2016'),(30,3,'cliente_emp','Logou na conta','9:34','01/12/2016'),(31,3,'cliente_emp','Saiu da conta','9:34','01/12/2016'),(32,3,'cliente_emp','Logou na conta','9:42','01/12/2016'),(33,3,'evento','Alterou um evento','9:42','01/12/2016'),(34,3,'cliente_emp','Saiu da conta','9:44','01/12/2016'),(35,3,'cliente_emp','Logou na conta','9:57','01/12/2016'),(36,3,'evento','Alterou um evento','9:58','01/12/2016'),(37,3,'cliente_emp','Saiu da conta','9:59','01/12/2016'),(38,2,'cliente_emp','Logou na conta','10:13','01/12/2016'),(39,2,'evento','Alterou um evento','10:14','01/12/2016'),(40,2,'cliente_emp','Saiu da conta','10:15','01/12/2016'),(41,3,'cliente_emp','Logou na conta','10:48','01/12/2016'),(42,3,'cliente_emp','Saiu da conta','10:48','01/12/2016'),(43,3,'cliente_emp','Logou na conta','11:18','01/12/2016'),(44,3,'cliente_emp','Saiu da conta','11:18','01/12/2016'),(45,3,'cliente_emp','Logou na conta','11:19','01/12/2016'),(46,3,'cliente_emp','Saiu da conta','11:20','01/12/2016'),(47,3,'cliente_emp','Logou na conta','11:32','01/12/2016'),(48,3,'evento','Criando um evento','11:35','01/12/2016'),(49,3,'evento','Criando um evento','11:36','01/12/2016'),(50,3,'cliente_emp','Saiu da conta','11:36','01/12/2016'),(51,1,'cliente_emp','Logou na conta','11:37','01/12/2016'),(52,1,'evento','Criando um evento','11:39','01/12/2016'),(53,1,'cliente_emp','Saiu da conta','11:40','01/12/2016'),(54,3,'cliente_emp','Logou na conta','11:41','01/12/2016'),(55,3,'evento','Alterou um evento','11:41','01/12/2016'),(56,3,'cliente_emp','Saiu da conta','11:41','01/12/2016'),(57,3,'cliente_emp','Logou na conta','14:50','01/12/2016'),(58,3,'evento','Alterou um evento','14:50','01/12/2016'),(59,3,'cliente_emp','Saiu da conta','14:51','01/12/2016'),(60,3,'cliente_emp','Logou na conta','16:11','01/12/2016'),(61,3,'evento','Alterou um evento','16:11','01/12/2016'),(62,3,'cliente_emp','Saiu da conta','16:13','01/12/2016'),(63,3,'cliente_emp','Logou na conta','17:13','01/12/2016'),(64,3,'evento','Alterou um evento','17:13','01/12/2016'),(65,3,'cliente_emp','Saiu da conta','17:15','01/12/2016'),(66,3,'cliente_emp','Logou na conta','21:01','01/12/2016'),(67,3,'evento','Alterou um evento','21:2','01/12/2016'),(68,3,'cliente_emp','Saiu da conta','21:3','01/12/2016'),(69,3,'cliente_emp','Logou na conta','21:17','01/12/2016'),(70,3,'evento','Alterou um evento','21:17','01/12/2016'),(71,3,'cliente_emp','Saiu da conta','21:18','01/12/2016');
/*!40000 ALTER TABLE `aud_emp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aud_func`
--

DROP TABLE IF EXISTS `aud_func`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aud_func` (
  `id_audf` int(11) NOT NULL AUTO_INCREMENT,
  `id_func` int(11) NOT NULL,
  `tabelamod_func` text NOT NULL,
  `desc_func` text NOT NULL,
  `hora_func` text NOT NULL,
  `data_func` text NOT NULL,
  PRIMARY KEY (`id_audf`),
  KEY `id_func` (`id_func`),
  CONSTRAINT `aud_func_ibfk_1` FOREIGN KEY (`id_func`) REFERENCES `usuario` (`id_usu`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aud_func`
--

LOCK TABLES `aud_func` WRITE;
/*!40000 ALTER TABLE `aud_func` DISABLE KEYS */;
/*!40000 ALTER TABLE `aud_func` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aud_usu`
--

DROP TABLE IF EXISTS `aud_usu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aud_usu` (
  `id_audu` int(11) NOT NULL AUTO_INCREMENT,
  `id_usu` int(11) NOT NULL,
  `tabelamod_usu` text NOT NULL,
  `desc_usu` text NOT NULL,
  `hora_usu` text NOT NULL,
  `data_usu` text NOT NULL,
  PRIMARY KEY (`id_audu`),
  KEY `id_usu` (`id_usu`),
  CONSTRAINT `aud_usu_ibfk_1` FOREIGN KEY (`id_usu`) REFERENCES `usuario` (`id_usu`)
) ENGINE=InnoDB AUTO_INCREMENT=130 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aud_usu`
--

LOCK TABLES `aud_usu` WRITE;
/*!40000 ALTER TABLE `aud_usu` DISABLE KEYS */;
INSERT INTO `aud_usu` VALUES (1,2,'usuario','Criou a conta','8:11','01/12/2016'),(2,3,'usuario','Criou a conta','8:18','01/12/2016'),(3,2,'usuario','Logou na conta','8:19','01/12/2016'),(4,2,'usuario','Saiu da conta','8:19','01/12/2016'),(5,4,'usuario','Criou a conta','8:42','01/12/2016'),(6,4,'usuario','Logou na conta','8:42','01/12/2016'),(7,4,'ranking','Deu HIGH FIVE em um Evento','8:42','01/12/2016'),(8,4,'fpgto','Adicionou uma Forma de Pagamento','8:43','01/12/2016'),(9,4,'ranking','Deu HIGH FIVE em um Evento','8:43','01/12/2016'),(10,4,'ranking','Deu HIGH FIVE em um Evento','8:43','01/12/2016'),(11,4,'compra','Comprou ingressos','8:43','01/12/2016'),(12,4,'usuario','Saiu da conta','8:45','01/12/2016'),(13,2,'usuario','Logou na conta','9:13','01/12/2016'),(14,2,'ranking','Deu HIGH FIVE em um Evento','9:13','01/12/2016'),(15,2,'fpgto','Adicionou uma Forma de Pagamento','9:14','01/12/2016'),(16,2,'ranking','Deu HIGH FIVE em um Evento','9:14','01/12/2016'),(17,2,'compra','Comprou ingressos','9:14','01/12/2016'),(18,2,'usuario','Saiu da conta','9:15','01/12/2016'),(19,2,'usuario','Logou na conta','9:20','01/12/2016'),(20,2,'ranking','Deu HIGH FIVE em um Evento','9:21','01/12/2016'),(21,2,'compra','Comprou ingressos','9:21','01/12/2016'),(22,2,'ranking','Deu HIGH FIVE em um Evento','9:22','01/12/2016'),(23,2,'usuario','Saiu da conta','9:22','01/12/2016'),(24,2,'usuario','Logou na conta','9:31','01/12/2016'),(25,2,'ranking','Deu HIGH FIVE em um Evento','9:32','01/12/2016'),(26,2,'compra','Comprou ingressos','9:32','01/12/2016'),(27,2,'usuario','Saiu da conta','9:33','01/12/2016'),(28,2,'usuario','Logou na conta','9:39','01/12/2016'),(29,2,'ranking','Deu HIGH FIVE em um Evento','9:40','01/12/2016'),(30,2,'compra','Comprou ingressos','9:40','01/12/2016'),(31,2,'usuario','Saiu da conta','9:41','01/12/2016'),(32,2,'usuario','Logou na conta','9:55','01/12/2016'),(33,2,'ranking','Deu HIGH FIVE em um Evento','9:55','01/12/2016'),(34,2,'compra','Comprou ingressos','9:56','01/12/2016'),(35,2,'usuario','Saiu da conta','9:57','01/12/2016'),(36,2,'usuario','Logou na conta','10:10','01/12/2016'),(37,2,'ranking','Deu HIGH FIVE em um Evento','10:10','01/12/2016'),(38,2,'ranking','Tirou HIGH FIVE de um Evento','10:11','01/12/2016'),(39,2,'ranking','Deu HIGH FIVE em um Evento','10:11','01/12/2016'),(40,2,'compra','Comprou ingressos','10:11','01/12/2016'),(41,2,'usuario','Saiu da conta','10:13','01/12/2016'),(42,2,'usuario','Logou na conta','10:45','01/12/2016'),(43,2,'ranking','Deu HIGH FIVE em um Evento','10:45','01/12/2016'),(44,2,'compra','Comprou ingressos','10:46','01/12/2016'),(45,2,'usuario','Saiu da conta','10:47','01/12/2016'),(46,2,'usuario','Logou na conta','10:48','01/12/2016'),(47,2,'compra','Limpou a lista de ingressos adquiridos','10:48','01/12/2016'),(48,2,'usuario','Saiu da conta','10:48','01/12/2016'),(49,2,'usuario','Logou na conta','11:18','01/12/2016'),(50,2,'ranking','Deu HIGH FIVE em um Evento','11:19','01/12/2016'),(51,2,'compra','Comprou ingressos','11:19','01/12/2016'),(52,2,'usuario','Saiu da conta','11:19','01/12/2016'),(53,2,'usuario','Logou na conta','11:22','01/12/2016'),(54,2,'ranking','Deu HIGH FIVE em um Evento','11:22','01/12/2016'),(55,2,'ranking','Tirou HIGH FIVE de um Evento','11:22','01/12/2016'),(56,2,'ranking','Deu HIGH FIVE em um Evento','11:22','01/12/2016'),(57,2,'ranking','Deu HIGH FIVE em um Evento','11:23','01/12/2016'),(58,2,'ranking','Deu HIGH FIVE em um Evento','11:23','01/12/2016'),(59,2,'compra','Comprou ingressos','11:23','01/12/2016'),(60,2,'usuario','Saiu da conta','11:24','01/12/2016'),(61,2,'usuario','Logou na conta','14:45','01/12/2016'),(62,2,'usuario','Saiu da conta','14:46','01/12/2016'),(63,2,'usuario','Logou na conta','14:47','01/12/2016'),(64,2,'ranking','Deu HIGH FIVE em um Evento','14:48','01/12/2016'),(65,2,'compra','Comprou ingressos','14:48','01/12/2016'),(66,2,'usuario','Saiu da conta','14:49','01/12/2016'),(67,2,'usuario','Logou na conta','16:09','01/12/2016'),(68,2,'ranking','Deu HIGH FIVE em um Evento','16:09','01/12/2016'),(69,2,'compra','Comprou ingressos','16:10','01/12/2016'),(70,2,'usuario','Saiu da conta','16:11','01/12/2016'),(71,2,'usuario','Logou na conta','16:34','01/12/2016'),(72,2,'ranking','Deu HIGH FIVE em um Evento','16:34','01/12/2016'),(73,2,'ranking','Deu HIGH FIVE em um Evento','16:35','01/12/2016'),(74,2,'compra','Comprou ingressos','16:35','01/12/2016'),(75,2,'compra','Comprou ingressos','16:35','01/12/2016'),(76,2,'usuario','Saiu da conta','16:36','01/12/2016'),(77,2,'usuario','Logou na conta','17:07','01/12/2016'),(78,2,'ranking','Deu HIGH FIVE em um Evento','17:07','01/12/2016'),(79,2,'ranking','Deu HIGH FIVE em um Evento','17:08','01/12/2016'),(80,2,'compra','Comprou ingressos','17:09','01/12/2016'),(81,2,'fpgto','Removeu a Forma de Pagamento','17:11','01/12/2016'),(82,2,'fpgto','Adicionou uma Forma de Pagamento','17:12','01/12/2016'),(83,2,'usuario','Saiu da conta','17:12','01/12/2016'),(84,2,'usuario','Logou na conta','18:58','01/12/2016'),(85,2,'usuario','Logou na conta','19:04','01/12/2016'),(86,2,'usuario','Logou na conta','19:08','01/12/2016'),(87,2,'usuario','Logou na conta','19:10','01/12/2016'),(88,2,'usuario','Saiu da conta','19:10','01/12/2016'),(89,2,'usuario','Logou na conta','19:12','01/12/2016'),(90,2,'usuario','Saiu da conta','19:12','01/12/2016'),(91,2,'usuario','Logou na conta','19:13','01/12/2016'),(92,2,'usuario','Logou na conta','19:17','01/12/2016'),(93,2,'usuario','Saiu da conta','19:17','01/12/2016'),(94,2,'usuario','Logou na conta','19:26','01/12/2016'),(95,2,'usuario','Saiu da conta','19:26','01/12/2016'),(96,2,'usuario','Logou na conta','19:27','01/12/2016'),(97,2,'usuario','Saiu da conta','19:27','01/12/2016'),(98,2,'usuario','Logou na conta','19:28','01/12/2016'),(99,2,'usuario','Saiu da conta','19:29','01/12/2016'),(100,2,'usuario','Logou na conta','19:30','01/12/2016'),(101,2,'usuario','Saiu da conta','19:31','01/12/2016'),(102,4,'usuario','Logou na conta','19:32','01/12/2016'),(103,4,'usuario','Saiu da conta','19:32','01/12/2016'),(104,4,'usuario','Logou na conta','19:33','01/12/2016'),(105,4,'usuario','Saiu da conta','19:33','01/12/2016'),(106,2,'usuario','Logou na conta','20:49','01/12/2016'),(107,2,'usuario','Logou na conta','20:49','01/12/2016'),(108,2,'usuario','Saiu da conta','20:50','01/12/2016'),(109,2,'usuario','Logou na conta','20:50','01/12/2016'),(110,2,'ranking','Deu HIGH FIVE em um Evento','20:51','01/12/2016'),(111,2,'compra','Comprou ingressos','20:51','01/12/2016'),(112,2,'usuario','Saiu da conta','20:52','01/12/2016'),(113,2,'usuario','Logou na conta','20:53','01/12/2016'),(114,2,'ranking','Deu HIGH FIVE em um Evento','20:54','01/12/2016'),(115,2,'compra','Comprou ingressos','20:54','01/12/2016'),(116,2,'usuario','Saiu da conta','20:55','01/12/2016'),(117,2,'usuario','Logou na conta','20:59','01/12/2016'),(118,2,'ranking','Deu HIGH FIVE em um Evento','20:59','01/12/2016'),(119,2,'ranking','Deu HIGH FIVE em um Evento','21:00','01/12/2016'),(120,2,'compra','Comprou ingressos','21:00','01/12/2016'),(121,2,'usuario','Saiu da conta','21:1','01/12/2016'),(122,4,'usuario','Logou na conta','21:04','01/12/2016'),(123,4,'usuario','Saiu da conta','21:4','01/12/2016'),(124,2,'usuario','Logou na conta','21:15','01/12/2016'),(125,2,'ranking','Deu HIGH FIVE em um Evento','21:15','01/12/2016'),(126,2,'compra','Comprou ingressos','21:16','01/12/2016'),(127,2,'usuario','Saiu da conta','21:17','01/12/2016'),(128,4,'usuario','Logou na conta','21:19','01/12/2016'),(129,4,'usuario','Saiu da conta','21:19','01/12/2016');
/*!40000 ALTER TABLE `aud_usu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente_emp`
--

DROP TABLE IF EXISTS `cliente_emp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente_emp` (
  `id_emp` int(11) NOT NULL AUTO_INCREMENT,
  `nome_emp` text NOT NULL,
  `cnpj_emp` text NOT NULL,
  `cep_emp` text NOT NULL,
  `numlocal_emp` text NOT NULL,
  `compl_emp` text,
  `email_emp` text NOT NULL,
  `senha_emp` text NOT NULL,
  `fone_emp` text NOT NULL,
  `cel_emp` text NOT NULL,
  `responsavel_emp` text NOT NULL,
  `img_emp` text,
  `ativo_emp` int(11) NOT NULL,
  PRIMARY KEY (`id_emp`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente_emp`
--

LOCK TABLES `cliente_emp` WRITE;
/*!40000 ALTER TABLE `cliente_emp` DISABLE KEYS */;
INSERT INTO `cliente_emp` VALUES (1,'y3EqasfMs1TDJW2JgsAH0g==','5b3b2f3uD28wu7RQoFYCg6FoLRAcOd/1Eq6hb6odVzk=','NHTbsnzhoKS7wUVxWIWHxA==','4JtvjswOwGaCIfSXYMOpQQ==','frN6U6PX2098uA19JPf2SA==','NXUarQgZTKb35alWPssvS1CVngle6Lnky/jfOWm+Q3Y=','g5XW7mJaGOMAm81bSWQ8Sg==','0DMkCjFcVElXeOTpTYsGUQ==','afpi00EP5zLj138tKoC/0A==','wBIdD03XrW1ofV1WmsAcBQ==','iYjcvtrUPX8l0lmVzHmt3A==',1),(2,'0Z0FX2bofBGeU9Ivt5JLCw==','xTIaBuVEbo/9TnNcC23vQx2wDkrUOE7t6ucxKJgfBr4=','/r56eacs5g2rC3iNWWKoCg==','4pRIJzBtyDKbkxVzZfFzxA==','frN6U6PX2098uA19JPf2SA==','jhIpHnIgX7o4ls6y5/1iIvcbA5gv3C0gJ+T2c95lL64=','CXRGkPN40FB6ZaI53hEtxg==','BRlKzDtNI8Z8VbmJ6fcjmg==','nd9MrcocFpNkXIE9xTku2A==','bw3WtyrW9NvmzObDkblQ2w==','GG6SOB8v5qak/YC/x8Raag==',1),(3,'5ZlXzSn6tm+nLM+sFMGsvA==','DPDIEGU5Zrm65W/lOnea5xAqRSPgCoMSTgyzvWua7Us=','9YaF2c3Rmnlf2LcXhTQEeQ==','S4GMdMKJBxkxLlnfG0mXLg==','ScbsBZ4s708dKTmLgGmWxA==','JhAKuNIIXoWax4NE5ixW/VZ1pgC+soWUac1Fp6nSGLs=','eEoDE4CZ1miDGp2mvQks+w==','XdkdbRmGqpwxMd+aCv8zsw==','31eQeNQ0EkGMeEwXGU/BuQ==','fsEwTkktlvnQa9J90e4tBg==','9c6fSAyqigi42IjiOxGRAA==',1);
/*!40000 ALTER TABLE `cliente_emp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compra`
--

DROP TABLE IF EXISTS `compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `compra` (
  `id_buy` int(11) NOT NULL AUTO_INCREMENT,
  `id_even` int(11) NOT NULL,
  `id_usu` int(11) NOT NULL,
  `id_pgto` int(11) NOT NULL,
  `qtding_buy` text NOT NULL,
  `precotot_buy` text NOT NULL,
  `dthr_buy` datetime NOT NULL,
  `ativo_buy` int(11) NOT NULL,
  PRIMARY KEY (`id_buy`),
  KEY `id_even` (`id_even`),
  KEY `id_usu` (`id_usu`),
  KEY `id_pgto` (`id_pgto`),
  CONSTRAINT `compra_ibfk_1` FOREIGN KEY (`id_even`) REFERENCES `evento` (`id_even`),
  CONSTRAINT `compra_ibfk_2` FOREIGN KEY (`id_usu`) REFERENCES `usuario` (`id_usu`),
  CONSTRAINT `compra_ibfk_3` FOREIGN KEY (`id_pgto`) REFERENCES `fpgto` (`id_pgto`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra`
--

LOCK TABLES `compra` WRITE;
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
INSERT INTO `compra` VALUES (1,1,4,1,'aXCDcw37oK+aKxSusrweuA==','Sqpqd4dK7luGYr0qjOy1dQ==','2016-12-01 08:43:45',1),(2,1,2,2,'mejVs343yFyvMNMa9swWnA==','9aUryVbvMBWrz4ojRDMWF9r8oHDx3lzH8KuuRruYNOg=','2016-12-01 09:14:59',0),(3,1,2,2,'XLViFcTB0ZfS256FNEwjUw==','v/dUNZYrtlAuVVJ6YXLksxgZvfuz9ZD9q2JYkzZQK5U=','2016-12-01 09:21:52',0),(4,1,2,2,'XLViFcTB0ZfS256FNEwjUw==','ALHePlWGzfBjA/+Z46tupDzc3B8sBpoCIcKUFeC+fn4=','2016-12-01 09:32:45',0),(5,4,2,2,'mejVs343yFyvMNMa9swWnA==','TJS8+5/rVu20KdMiDwcp3A==','2016-12-01 09:40:57',0),(6,1,2,2,'mejVs343yFyvMNMa9swWnA==','0sHapRucgJDpomw1a+cyow==','2016-12-01 09:56:34',0),(7,1,2,2,'XLViFcTB0ZfS256FNEwjUw==','1gQo+0/kweENKr5nMtaORVUQzGh15NjP7KRZKoN28pY=','2016-12-01 10:11:52',0),(8,1,2,2,'mejVs343yFyvMNMa9swWnA==','OE6fBeuP8sighekL/ikvYQ34mAemYuRYYnC0ptKgPas=','2016-12-01 10:46:26',0),(9,1,2,2,'aXCDcw37oK+aKxSusrweuA==','aF5WDYSwKdQ/Odd6z+lDMzUT2IgU0P/QRdHaS/kxX4A=','2016-12-01 11:19:12',1),(10,1,2,2,'mejVs343yFyvMNMa9swWnA==','B9Q3nFtl3NKG0cya8nkt7J9q3sBJa0sGVorSXHi2e04=','2016-12-01 11:23:43',1),(11,4,2,2,'mejVs343yFyvMNMa9swWnA==','FxzBBWunQ3Wh39+K9xgxPg==','2016-12-01 14:48:55',1),(12,1,2,2,'XLViFcTB0ZfS256FNEwjUw==','xd16OE+DS8b0sDVgqYCMvhMFfbkc0Dta0OQmGPPaSxk=','2016-12-01 16:10:29',1),(13,1,2,2,'XLViFcTB0ZfS256FNEwjUw==','ixoYNnyMVZ/qEYBoP27LOPkl3wxW31dVhjdFnTIMbT8=','2016-12-01 16:35:40',1),(14,1,2,2,'XLViFcTB0ZfS256FNEwjUw==','ixoYNnyMVZ/qEYBoP27LOPkl3wxW31dVhjdFnTIMbT8=','2016-12-01 16:35:44',1),(15,1,2,2,'aXCDcw37oK+aKxSusrweuA==','QOCqSR3scbQ7LVU5nMwI6Ccs9LyfEbha6FEkmdX0EAU=','2016-12-01 17:09:36',1),(16,1,2,2,'aXCDcw37oK+aKxSusrweuA==','PA38Lak5t4uAt9+RSxNbjbMqiThBWLrKUPIp3SXuxIU=','2016-12-01 20:51:30',1),(17,1,2,2,'3UFP61XHD0gYEd9GHjKtVA==','WMijCe8uHHQFScTrDQZMw7oMUCgAR3LH9I+PfiUOhd0=','2016-12-01 20:54:35',1),(18,10,2,2,'3UFP61XHD0gYEd9GHjKtVA==','zmpL243+fArwq7ilclJTSg==','2016-12-01 21:00:52',1),(19,10,2,2,'3UFP61XHD0gYEd9GHjKtVA==','TYXLQknX2f2N9WzibDB4XzPc0HlFW/LfTxVFu+M8KbU=','2016-12-01 21:16:30',1);
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `control_ing`
--

DROP TABLE IF EXISTS `control_ing`;
/*!50001 DROP VIEW IF EXISTS `control_ing`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `control_ing` (
 `qtd_even` tinyint NOT NULL,
  `id` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `control_ing2`
--

DROP TABLE IF EXISTS `control_ing2`;
/*!50001 DROP VIEW IF EXISTS `control_ing2`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `control_ing2` (
 `id_emp` tinyint NOT NULL,
  `evento` tinyint NOT NULL,
  `totaldisp` tinyint NOT NULL,
  `valtotal` tinyint NOT NULL,
  `ingvendido` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `emp_destevens`
--

DROP TABLE IF EXISTS `emp_destevens`;
/*!50001 DROP VIEW IF EXISTS `emp_destevens`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `emp_destevens` (
 `img` tinyint NOT NULL,
  `even` tinyint NOT NULL,
  `id_emp` tinyint NOT NULL,
  `qtdfav` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `emp_destevens2`
--

DROP TABLE IF EXISTS `emp_destevens2`;
/*!50001 DROP VIEW IF EXISTS `emp_destevens2`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `emp_destevens2` (
 `img` tinyint NOT NULL,
  `even` tinyint NOT NULL,
  `id_emp` tinyint NOT NULL,
  `qtdfav` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `empalteventos`
--

DROP TABLE IF EXISTS `empalteventos`;
/*!50001 DROP VIEW IF EXISTS `empalteventos`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `empalteventos` (
 `id` tinyint NOT NULL,
  `nome_evento` tinyint NOT NULL,
  `status` tinyint NOT NULL,
  `tipo` tinyint NOT NULL,
  `subtipo` tinyint NOT NULL,
  `faet` tinyint NOT NULL,
  `local` tinyint NOT NULL,
  `uf` tinyint NOT NULL,
  `cid` tinyint NOT NULL,
  `rua` tinyint NOT NULL,
  `num` tinyint NOT NULL,
  `img` tinyint NOT NULL,
  `detalhes_even` tinyint NOT NULL,
  `dt_inicio` tinyint NOT NULL,
  `hr_inicio` tinyint NOT NULL,
  `data_final` tinyint NOT NULL,
  `hr_final` tinyint NOT NULL,
  `empresa` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `empeventos`
--

DROP TABLE IF EXISTS `empeventos`;
/*!50001 DROP VIEW IF EXISTS `empeventos`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `empeventos` (
 `id` tinyint NOT NULL,
  `nome_evento` tinyint NOT NULL,
  `tipo` tinyint NOT NULL,
  `faet` tinyint NOT NULL,
  `local` tinyint NOT NULL,
  `data` tinyint NOT NULL,
  `hora` tinyint NOT NULL,
  `empresa` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `evento`
--

DROP TABLE IF EXISTS `evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `evento` (
  `id_even` int(11) NOT NULL AUTO_INCREMENT,
  `id_teve` int(11) NOT NULL,
  `id_subt` int(11) NOT NULL,
  `id_st` int(11) NOT NULL,
  `id_emp` int(11) NOT NULL,
  `nome_even` text NOT NULL,
  `uf_even` text NOT NULL,
  `cid_even` text NOT NULL,
  `rua_even` text NOT NULL,
  `numlocal_even` text NOT NULL,
  `nomelocal_even` text NOT NULL,
  `img_even` text NOT NULL,
  `detalhes_even` text NOT NULL,
  `startdt_even` date NOT NULL,
  `starthr_even` time NOT NULL,
  `fimdt_even` date NOT NULL,
  `fimhr_even` time NOT NULL,
  `ativo_even` int(11) NOT NULL,
  PRIMARY KEY (`id_even`),
  KEY `id_teve` (`id_teve`),
  KEY `id_subt` (`id_subt`),
  KEY `id_st` (`id_st`),
  KEY `id_emp` (`id_emp`),
  CONSTRAINT `evento_ibfk_1` FOREIGN KEY (`id_teve`) REFERENCES `tipo_evento` (`id_teve`),
  CONSTRAINT `evento_ibfk_2` FOREIGN KEY (`id_subt`) REFERENCES `subtipo_evento` (`id_subt`),
  CONSTRAINT `evento_ibfk_3` FOREIGN KEY (`id_st`) REFERENCES `status_evento` (`id_st`),
  CONSTRAINT `evento_ibfk_4` FOREIGN KEY (`id_emp`) REFERENCES `cliente_emp` (`id_emp`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
INSERT INTO `evento` VALUES (1,1,4,2,3,'u59AG5DCY9uzQNWDjp0wXgc0SjoRv7OwOJPHLIfG/1g=','9OK+mieVhzDgK+cfOMLVWw==','9grfFKjVFs1r/gBjSL/u4A==','OjmjmVqT5Nm2QFy2pI63Jv02KqaXVz5CL/j21gQuX48=','yZXYRuX7QWaep8QzCK+hZQ==','qIL82KYgZPi0wLgOUFgHcQ==','2taC76Bg3K1a0gvkoQREKWUFcOWKosRYqwxi4P6OLJc=','hXCgCHP5r4WBgypOm4MbQ+CNsmF/+HwkZvto2MrcKUY=','2016-12-02','20:00:00','2016-12-02','23:30:00',2),(2,1,1,1,1,'ULyu3GSBTNWSJ+8icflDLQ==','LrXbGB39l0rgPzasLDOjSg==','ULyu3GSBTNWSJ+8icflDLQ==','ULyu3GSBTNWSJ+8icflDLQ==','f4dMCp73Cdp8iZwoUc57DA==','ULyu3GSBTNWSJ+8icflDLQ==','X2+kGmVhURTOQVV6nkAM0g==','ULyu3GSBTNWSJ+8icflDLQ==','2018-11-19','11:11:00','2018-11-19','22:22:00',0),(3,6,8,1,1,'lfJnQZawxtsroKrDRUWENw==','NUGB6qUmaUdU7xylcl6RDA==','Pkz7RJe5ZJ/krk6pKahqDg==','CaoRBaAV8wyZELyb9Ho/ug==','V5pVGI5w7SdDNUaqR5cZgw==','uQVPxszrVaJbhDAKov+UDA==','yrF6gKb+yx9OILVNeK9CJD+nOQCNHS3nhS9FriDqTus=','SzAXKmzawEYbzhAbUZjXgoBCvzrg4ZVn+JWb74Dh0yL2eP1vkey+H/dOVRhh5Sy5hkc/QiE8wN53JQoo9EzCCg==','2020-06-13','18:00:00','2021-06-15','21:00:00',2),(4,5,6,2,2,'uEP7YwpenI0Owl/o0i1lEw==','9OK+mieVhzDgK+cfOMLVWw==','9grfFKjVFs1r/gBjSL/u4A==','OjmjmVqT5Nm2QFy2pI63Jv02KqaXVz5CL/j21gQuX48=','38JSjsS+rYfPlfXNZPbyGQ==','FsXECOAhBKtuWAeAZLqzSA==','GUC60aV8cLJ6QTCs44KNGmz4Y2NNQ4zXMsrIm2AxpjM=','EkkHanjO+1nNMXtKZh/CSpVcfWwrh0WnH7piSBlP2x8=','2016-12-15','22:00:00','2016-12-16','05:00:00',2),(5,1,1,1,1,'tTTVdpsv/Tf/uBiRUBT8IQ==','ywosz1zjXN33hKp7BlB1hA==','+j+KpMPjE5BMnh9yjW0ugQ==','LRqTymkfF8LCj8dShGDMyA==','WZ1nKKgC8wPBviRkFJ8vAA==','/Fd7LUeCJ7zAdlJJFSy+hw==','X2+kGmVhURTOQVV6nkAM0g==','CzFKO4PsiSvg+d4UJajJ1g==','2016-12-01','11:11:00','2016-12-01','22:22:00',0),(6,1,1,1,1,'e50TZS2qHTqnIsIlVfr5Kw==','8CdvuajifPZyNt/LPGxPOw==','dHnghD8jOxdtJVqNWotumQ==','8Y89virE5OXgU0a0o2ZQGg==','8iVbn7/6hv7ZQMVGlbfXSQ==','IuFElz74UP59VJyuQ03vZw==','X2+kGmVhURTOQVV6nkAM0g==','JlQORukY2umljN0G/km8pw==','2017-05-13','11:11:00','2017-05-13','22:22:00',0),(7,1,1,1,1,'sXnf4I3SUx3h3gIOabN/2g==','JfBVXtbMNRtBYvgMJwcI4Q==','XYaahiy6WF+ygDli7uXwbQ==','XYaahiy6WF+ygDli7uXwbQ==','nfzhg5+k1LLXnPLvGlg3pg==','88ZgqUpqdvmD0kx8Y+185Q==','X2+kGmVhURTOQVV6nkAM0g==','I/vUhIzJazt3wzkDL3SLMQ==','2016-12-01','09:30:00','2016-12-01','10:00:00',0),(8,3,8,1,3,'0kR/Rk/szT0OiaNnRfXg0uuNLKGHM4iGeFskQFemrmY=','9OK+mieVhzDgK+cfOMLVWw==','9grfFKjVFs1r/gBjSL/u4A==','OjmjmVqT5Nm2QFy2pI63Jv02KqaXVz5CL/j21gQuX48=','PNHG11NvvzxXOE3zZOwJ1g==','Q+AFOlojwUZxHMZxpm3wKw==','OFDqsXab9l3RiBEsIdM+DOuYL1ZvMtUcLysP0MqGPW8=','70bUX9Ym/vXr6b8pXaSyiXQjMn9RAsdLDPe9Z73kvT4=','2016-12-01','13:00:00','2016-12-03','12:00:00',2),(9,6,8,1,3,'3DjMbPDtoqIueGXWG7uY+A==','kTmr9/zUcsnS9iu+Ari0TQ==','7EiHtBw7gqT9/2BsQwXuDV6SLjKvroZlQtz8IxHHrl4=','OjmjmVqT5Nm2QFy2pI63Jv02KqaXVz5CL/j21gQuX48=','f5egBK/dli3bchK9Udwsww==','Q+AFOlojwUZxHMZxpm3wKw==','fnE6OB1U08IyOWGtxP+0gwBI711JvbFlYRaSlb4kf2s=','T/WCYonu/V4M6ddX3bdaUOIO3u+wFeDWpYzyyN5bSj2WXLVgq+1X5zy0KYD+wZGPaf0FVIPGiiRLd4KdT/lnl/yz5yV8eU/ufZ8USuLZ33M=','2016-12-01','14:00:00','2016-12-03','12:00:00',2),(10,1,7,2,1,'skPVa/avqOdx65F3taBFng==','7uOef359lx+2PBcOKBYG4g==','5IPNq7K4KTHYLvPpLGBa1g==','6jY/Y0lvKHoGj2atENM5uQ==','z8IPmJAt13K+x69n9IACTw==','xdW15ubxo4Dw0on4DOqW0Q==','IGDFTmi3I841xRQ+BMvsC5aiK/qx6mfBNX0GJEdbL8E=','L4OGMucwmV0nprW3KY1+rrqoXWE1hnMivhIQ7uihHT8=','2016-12-15','10:00:00','2016-12-15','16:00:00',2);
/*!40000 ALTER TABLE `evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `faixa_etaria`
--

DROP TABLE IF EXISTS `faixa_etaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `faixa_etaria` (
  `id_faet` int(11) NOT NULL AUTO_INCREMENT,
  `descr_faet` text NOT NULL,
  PRIMARY KEY (`id_faet`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faixa_etaria`
--

LOCK TABLES `faixa_etaria` WRITE;
/*!40000 ALTER TABLE `faixa_etaria` DISABLE KEYS */;
INSERT INTO `faixa_etaria` VALUES (1,'UVhSxioaMQ+3JFWYSffeFw=='),(2,'b3Ebl3zMsAznmLc5RDa9x7IHTik/QY8o/z1dzJeBBKs=');
/*!40000 ALTER TABLE `faixa_etaria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fpgto`
--

DROP TABLE IF EXISTS `fpgto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fpgto` (
  `id_pgto` int(11) NOT NULL AUTO_INCREMENT,
  `id_usu` int(11) NOT NULL,
  `cartao_pgto` text NOT NULL,
  `numcartao_pgto` text NOT NULL,
  `dataexp_pgto` text NOT NULL,
  `titular_pgto` text NOT NULL,
  `cvv_pgto` text NOT NULL,
  `ativo_pgto` int(11) NOT NULL,
  PRIMARY KEY (`id_pgto`),
  KEY `id_usu` (`id_usu`),
  CONSTRAINT `fpgto_ibfk_1` FOREIGN KEY (`id_usu`) REFERENCES `usuario` (`id_usu`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fpgto`
--

LOCK TABLES `fpgto` WRITE;
/*!40000 ALTER TABLE `fpgto` DISABLE KEYS */;
INSERT INTO `fpgto` VALUES (1,4,'TQEJ/W5n2jmqHE1gSze16w==','xxLwtPGyy1vXhnojM42op5OKN9hf9MBwBc5s7hqw1zM=','RzRZKXM2/U7vgCRhbX1xaQ==','v+9loVjnJXeh5G1HCEz7uQ==','Myc8R+YTP+PaSzIOCTkVXQ==',1),(2,2,'dE6iookDkgpsQ/2OzW9MlQ==','E2pg0uPhKssJYdMdrL1W94jwyyybTcH42/447fCQ47U=','V0jAHBpzxE3SnD0Mdpzehw==','//6Wbvb3oqOumQ20edjAr/inLfoZvbu2IfR5e6WqS6E=','3JMEOJCireaeGEy7z/PztA==',1);
/*!40000 ALTER TABLE `fpgto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `gerfunc`
--

DROP TABLE IF EXISTS `gerfunc`;
/*!50001 DROP VIEW IF EXISTS `gerfunc`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `gerfunc` (
 `id` tinyint NOT NULL,
  `nome` tinyint NOT NULL,
  `email` tinyint NOT NULL,
  `dt` tinyint NOT NULL,
  `cpf` tinyint NOT NULL,
  `cep` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `getidemp`
--

DROP TABLE IF EXISTS `getidemp`;
/*!50001 DROP VIEW IF EXISTS `getidemp`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `getidemp` (
 `id` tinyint NOT NULL,
  `email` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `getidevento`
--

DROP TABLE IF EXISTS `getidevento`;
/*!50001 DROP VIEW IF EXISTS `getidevento`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `getidevento` (
 `id` tinyint NOT NULL,
  `evento` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `getidusu`
--

DROP TABLE IF EXISTS `getidusu`;
/*!50001 DROP VIEW IF EXISTS `getidusu`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `getidusu` (
 `id` tinyint NOT NULL,
  `email` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `ingressos`
--

DROP TABLE IF EXISTS `ingressos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ingressos` (
  `id_ing` int(11) NOT NULL AUTO_INCREMENT,
  `id_even` int(11) NOT NULL,
  `qtddisp_ing` text NOT NULL,
  `precotot_ing` text NOT NULL,
  `qtdvend_ing` text NOT NULL,
  PRIMARY KEY (`id_ing`),
  KEY `id_even` (`id_even`),
  CONSTRAINT `ingressos_ibfk_1` FOREIGN KEY (`id_even`) REFERENCES `evento` (`id_even`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ingressos`
--

LOCK TABLES `ingressos` WRITE;
/*!40000 ALTER TABLE `ingressos` DISABLE KEYS */;
INSERT INTO `ingressos` VALUES (1,1,'VtzkHx93bSUDuj67PyQLig==','nUVKMq4BIsBFugs/nzkc8A==','v/B598zgTvFsSmrZLWJoVQ=='),(2,4,'PxgXyQVbvhnug48wZA6JZg==','CHA1Mq4jvYJPYo53rRcBAg==','mejVs343yFyvMNMa9swWnA=='),(3,10,'5HfYKKSOBQsBWIdiaplVQg==','PLY/Rr4lK/m7kp2RVyhN9w==','yZMzKvRR9ZsuLQgqnnUHCA==');
/*!40000 ALTER TABLE `ingressos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `login`
--

DROP TABLE IF EXISTS `login`;
/*!50001 DROP VIEW IF EXISTS `login`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `login` (
 `email` tinyint NOT NULL,
  `senha` tinyint NOT NULL,
  `tipo_usuario` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `loginemp`
--

DROP TABLE IF EXISTS `loginemp`;
/*!50001 DROP VIEW IF EXISTS `loginemp`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `loginemp` (
 `email` tinyint NOT NULL,
  `senha` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `perfilfunc`
--

DROP TABLE IF EXISTS `perfilfunc`;
/*!50001 DROP VIEW IF EXISTS `perfilfunc`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `perfilfunc` (
 `nome` tinyint NOT NULL,
  `data` tinyint NOT NULL,
  `fone` tinyint NOT NULL,
  `sexo` tinyint NOT NULL,
  `img` tinyint NOT NULL,
  `rg` tinyint NOT NULL,
  `num` tinyint NOT NULL,
  `compl` tinyint NOT NULL,
  `cpf` tinyint NOT NULL,
  `email` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `qrcode`
--

DROP TABLE IF EXISTS `qrcode`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `qrcode` (
  `id_qrc` int(11) NOT NULL AUTO_INCREMENT,
  `login_qrc` text NOT NULL,
  `senha_qrc` text NOT NULL,
  `dthr_qrc` time NOT NULL,
  `ativo_qrc` int(11) NOT NULL,
  PRIMARY KEY (`id_qrc`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `qrcode`
--

LOCK TABLES `qrcode` WRITE;
/*!40000 ALTER TABLE `qrcode` DISABLE KEYS */;
INSERT INTO `qrcode` VALUES (31,'3RkDLj5dY5SQ0dnDVaKcWsIKkC9+3qvcleVlBhvDS0Y=','V8I1O/r+qjGxWFAG6mirzw==','19:33:27',0),(32,'3RkDLj5dY5SQ0dnDVaKcWsIKkC9+3qvcleVlBhvDS0Y=','V8I1O/r+qjGxWFAG6mirzw==','21:04:14',0),(33,'3RkDLj5dY5SQ0dnDVaKcWsIKkC9+3qvcleVlBhvDS0Y=','V8I1O/r+qjGxWFAG6mirzw==','21:19:17',1);
/*!40000 ALTER TABLE `qrcode` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ranking`
--

DROP TABLE IF EXISTS `ranking`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ranking` (
  `id_rank` int(11) NOT NULL AUTO_INCREMENT,
  `id_even` int(11) NOT NULL,
  `classif_rank` text NOT NULL,
  `qtdfav_rank` text NOT NULL,
  PRIMARY KEY (`id_rank`),
  KEY `id_even` (`id_even`),
  CONSTRAINT `ranking_ibfk_1` FOREIGN KEY (`id_even`) REFERENCES `evento` (`id_even`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ranking`
--

LOCK TABLES `ranking` WRITE;
/*!40000 ALTER TABLE `ranking` DISABLE KEYS */;
INSERT INTO `ranking` VALUES (1,1,'2w9mb4YD/VVV2A3NoRFs7g==','R2CQ/PYOc0U1aOBg2CETMg=='),(2,2,'2w9mb4YD/VVV2A3NoRFs7g==','gMcO0KKCb0sV0Hvc94u79g=='),(3,3,'2w9mb4YD/VVV2A3NoRFs7g==','zyrVDPFLuw3nCzNZlWufcQ=='),(4,4,'2w9mb4YD/VVV2A3NoRFs7g==','azYTuKCYJs88lTST1JqNOQ=='),(5,5,'2w9mb4YD/VVV2A3NoRFs7g==','gMcO0KKCb0sV0Hvc94u79g=='),(6,6,'2w9mb4YD/VVV2A3NoRFs7g==','gMcO0KKCb0sV0Hvc94u79g=='),(7,7,'2w9mb4YD/VVV2A3NoRFs7g==','gMcO0KKCb0sV0Hvc94u79g=='),(8,8,'2w9mb4YD/VVV2A3NoRFs7g==','gMcO0KKCb0sV0Hvc94u79g=='),(9,9,'2w9mb4YD/VVV2A3NoRFs7g==','gMcO0KKCb0sV0Hvc94u79g=='),(10,10,'2w9mb4YD/VVV2A3NoRFs7g==','mejVs343yFyvMNMa9swWnA==');
/*!40000 ALTER TABLE `ranking` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `senhas_old`
--

DROP TABLE IF EXISTS `senhas_old`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `senhas_old` (
  `id_old` int(11) NOT NULL AUTO_INCREMENT,
  `id_usu` int(11) NOT NULL,
  `senha1_old` text,
  `senha2_old` text,
  `senha3_old` text,
  `data_old` text,
  PRIMARY KEY (`id_old`),
  KEY `id_usu` (`id_usu`),
  CONSTRAINT `senhas_old_ibfk_1` FOREIGN KEY (`id_usu`) REFERENCES `usuario` (`id_usu`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `senhas_old`
--

LOCK TABLES `senhas_old` WRITE;
/*!40000 ALTER TABLE `senhas_old` DISABLE KEYS */;
INSERT INTO `senhas_old` VALUES (1,1,'mF8g+xhhijwRZh/7k1IEuQ==','','','Uxj5PjO69sBzB1H0cix4HQ==');
/*!40000 ALTER TABLE `senhas_old` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `status_evento`
--

DROP TABLE IF EXISTS `status_evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `status_evento` (
  `id_st` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_st` text NOT NULL,
  PRIMARY KEY (`id_st`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_evento`
--

LOCK TABLES `status_evento` WRITE;
/*!40000 ALTER TABLE `status_evento` DISABLE KEYS */;
INSERT INTO `status_evento` VALUES (1,'pXdFLhDOxJ3YV5k4RhWtEQ=='),(2,'N/8jYmoEYAsD38tmlHgDtg==');
/*!40000 ALTER TABLE `status_evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subtipo_evento`
--

DROP TABLE IF EXISTS `subtipo_evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subtipo_evento` (
  `id_subt` int(11) NOT NULL AUTO_INCREMENT,
  `descr_subt` text NOT NULL,
  PRIMARY KEY (`id_subt`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subtipo_evento`
--

LOCK TABLES `subtipo_evento` WRITE;
/*!40000 ALTER TABLE `subtipo_evento` DISABLE KEYS */;
INSERT INTO `subtipo_evento` VALUES (1,'r36YB2gSVo0A2lwtuzoRoA=='),(2,'GC7npv4GZqwIrdQ0dKm5cg=='),(3,'+QXHkzohMrMV5M6YtM6RuA=='),(4,'dU0PJ7Z2+g7bNquK1rDyEQ=='),(5,'3LaO8yWV4UVD392BCJE8Pg=='),(6,'W30CNrXQthnWardbXkdESA=='),(7,'0nhJzFevrnB+XWxyMozxAw=='),(8,'Kn0wWj14+mqSyoG6iAVcoM4Pq4uen+PDKDdj36pRuGo='),(9,'jB1CU2tr+oJleixDK0fIxg=='),(10,'7mp3IDADL8EqAvmEuXiN5A==');
/*!40000 ALTER TABLE `subtipo_evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_evento`
--

DROP TABLE IF EXISTS `tipo_evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_evento` (
  `id_teve` int(11) NOT NULL AUTO_INCREMENT,
  `id_faet` int(11) NOT NULL,
  `descr_teve` text NOT NULL,
  PRIMARY KEY (`id_teve`),
  KEY `id_faet` (`id_faet`),
  CONSTRAINT `tipo_evento_ibfk_1` FOREIGN KEY (`id_faet`) REFERENCES `faixa_etaria` (`id_faet`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_evento`
--

LOCK TABLES `tipo_evento` WRITE;
/*!40000 ALTER TABLE `tipo_evento` DISABLE KEYS */;
INSERT INTO `tipo_evento` VALUES (1,1,'zYDuyXO6OQj5IMn5eO5baw=='),(2,1,'hY+4EaVQp8d8Qem4UDxXYw=='),(3,1,'Nee0XAj0P0WF417Y1TlxWg=='),(4,2,'CbNZm2eJS/YgGV3KXcAf0w=='),(5,2,'68+sDDDiGwnwvjtvQk4LgA=='),(6,2,'CC+1PIfhppKAWXlgiIzUuA=='),(7,1,'YdV7wn908ToR+9Usgrz6b2z8uIZt2gGR0BiD71idCMY='),(8,2,'BClFy8brMBDmRuWiVCXEFYoLh2+t65GakxgYsOjAW5yI4t8+RLy8kfWo8AoxyI4M'),(9,1,'CddDg7OHv+n5YVxaab+EM8DD7brlEw6D+qv9eAukGAk='),(10,2,'imal4rU1c6LtDDR+N8HB/qqigzqPXD235vyzsL+kMzbenVKHkMcTp9GsF3q5AqVe');
/*!40000 ALTER TABLE `tipo_evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_usuario`
--

DROP TABLE IF EXISTS `tipo_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_usuario` (
  `id_tusu` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_tusu` text NOT NULL,
  PRIMARY KEY (`id_tusu`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_usuario`
--

LOCK TABLES `tipo_usuario` WRITE;
/*!40000 ALTER TABLE `tipo_usuario` DISABLE KEYS */;
INSERT INTO `tipo_usuario` VALUES (1,'Os7BbbWfyBpVCtFIdD2QkQ=='),(2,'t1lu6P0YL+VOMeMviKwYhQ=='),(3,'bKLYzCpMwLhpF6KqiVHJ6w==');
/*!40000 ALTER TABLE `tipo_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `usu_compra`
--

DROP TABLE IF EXISTS `usu_compra`;
/*!50001 DROP VIEW IF EXISTS `usu_compra`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `usu_compra` (
 `id` tinyint NOT NULL,
  `evento` tinyint NOT NULL,
  `idusu` tinyint NOT NULL,
  `qtding` tinyint NOT NULL,
  `total` tinyint NOT NULL,
  `dthr` tinyint NOT NULL,
  `dtstart` tinyint NOT NULL,
  `fimdt` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `id_usu` int(11) NOT NULL AUTO_INCREMENT,
  `id_tusu` int(11) NOT NULL,
  `nome_usu` text NOT NULL,
  `dtnasc_usu` text NOT NULL,
  `email_usu` text NOT NULL,
  `senha_usu` text NOT NULL,
  `cel_usu` text,
  `sx_usu` text NOT NULL,
  `img_usu` text,
  `rg_usu` text,
  `cpf_usu` text NOT NULL,
  `cep_usu` text,
  `numcasa_usu` text,
  `compl_usu` text,
  `pergsec_usu` text,
  `respsec_usu` text,
  `primeiraentrada_usu` int(11) DEFAULT NULL,
  `ativo_usu` int(11) NOT NULL,
  PRIMARY KEY (`id_usu`),
  KEY `id_tusu` (`id_tusu`),
  CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`id_tusu`) REFERENCES `tipo_usuario` (`id_tusu`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,1,'qs9vg+YOIcJv8jZOMrv0+w==','VcAZRxrXp3jLhNarK1Cm4w==','g+WGqqhog7O302dVzvcgXPAcj3Y5YSnFmahzSnaa1tM=','mF8g+xhhijwRZh/7k1IEuQ==','WTwOZxKeU6/9xbRmbvKrXw==','ojch/7guNj+sXi591kh8UQ==','/SKS1oL+GvNSbgaJb2l9Xg==','tOQK2qg6435sJWbwF6qbnw==','ZEuiGiXeC5MCwJlJRsdu1w==','arrxxZ3AT3/IK480wleN5A==','o1xoTQqzHjJMAIRnIY5BYQ==','uuv9Mp/TivNV6llIl51YTA==','RQzjD6LB0EmapRj2h1itsaojOXEvf9sMuHsIIjFWPa6c8VfzS5AU9d1LpywvTo8V','OtkAPNnWCEsEfXAcgdQEMg==',1,1),(2,3,'z6Eb2n+rUeDdlsJGvyVuqA==','eHeOotC816B+VMIIU7v1ug==','js+A3v9v5rgQGq7RnG8XF67R5Gc4X8FaAXT0+HFsubs=','hnP9fXooGvU/X5ehK2W0zA==','hVwlxXGldG1Hx0onAfwqyw==','A3gnAgLbjJ6inuUYaRHFiQ==','9c6fSAyqigi42IjiOxGRAA==','VYMYMICunkNeo2FjmL2Btw==','wJF6rvsp0IbRG8DlHvAZow==','fvbnAdlmecAVYWucwu9IAg==','qvXr2+Jbf26FFtMcqYuavg==','frN6U6PX2098uA19JPf2SA==',NULL,NULL,NULL,1),(3,3,'TzD0l2oJ/eCIE60HbE/qxA==','+kELxQ/G8ZjpmozxN19hmA==','jmv8lA4c7VE5y271tACuN0hgxMcQlvlsuY19xaR6y6k=','nTwzIV5S/pu77n+1QTFmRw==','aYJ3v1btG8uIaUNvKy7beA==','A3gnAgLbjJ6inuUYaRHFiQ==','Px5VdhBqICgAshFckrxEE+tvkk3Z3ymj8bZ++06AOzc=','Vo+6cAPVmfKlzteVeSIRkg==','hFvWgrhzMNiDL1nkN1Nvjw==','440ziiPziVB3RPph2gRkHA==','FKRi40ovRefYsnJvLnyNAw==','3vRnVUqBZ7bPl3Nf5UpL8w==',NULL,NULL,NULL,1),(4,3,'FYY0FeV0ddp26FOZwxHoEw==','olkaJCxsB9abJGPLYO79VA==','3RkDLj5dY5SQ0dnDVaKcWsIKkC9+3qvcleVlBhvDS0Y=','V8I1O/r+qjGxWFAG6mirzw==','atHeq1KBNYq0uVfda+bzWw==','wpHE4lFpFeoEYIehRGtUlA==','ATp1MKmbPaGojK/cMyrlyg==','RCTnz2XRLrdH3gCrSqA72g==','96jaWHd5uuXbim2OSatKmA==','tL2xqRqrGEckhIgteM6VwA==','Pa6iz+abddCC83afWWta4g==','frN6U6PX2098uA19JPf2SA==',NULL,NULL,NULL,1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `usueventos`
--

DROP TABLE IF EXISTS `usueventos`;
/*!50001 DROP VIEW IF EXISTS `usueventos`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `usueventos` (
 `nome_evento` tinyint NOT NULL,
  `tipo` tinyint NOT NULL,
  `faixaet` tinyint NOT NULL,
  `empresa` tinyint NOT NULL,
  `img` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `usueventos2`
--

DROP TABLE IF EXISTS `usueventos2`;
/*!50001 DROP VIEW IF EXISTS `usueventos2`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `usueventos2` (
 `id` tinyint NOT NULL,
  `nome_evento` tinyint NOT NULL,
  `tipo` tinyint NOT NULL,
  `subtipo` tinyint NOT NULL,
  `faet` tinyint NOT NULL,
  `empresa` tinyint NOT NULL,
  `img` tinyint NOT NULL,
  `data` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `usueventos3`
--

DROP TABLE IF EXISTS `usueventos3`;
/*!50001 DROP VIEW IF EXISTS `usueventos3`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `usueventos3` (
 `id` tinyint NOT NULL,
  `nome_evento` tinyint NOT NULL,
  `status` tinyint NOT NULL,
  `tipo` tinyint NOT NULL,
  `subtipo` tinyint NOT NULL,
  `faet` tinyint NOT NULL,
  `uf` tinyint NOT NULL,
  `cid` tinyint NOT NULL,
  `rua` tinyint NOT NULL,
  `num` tinyint NOT NULL,
  `local` tinyint NOT NULL,
  `detalhes` tinyint NOT NULL,
  `empresa` tinyint NOT NULL,
  `img` tinyint NOT NULL,
  `data` tinyint NOT NULL,
  `hora` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `vercnpj`
--

DROP TABLE IF EXISTS `vercnpj`;
/*!50001 DROP VIEW IF EXISTS `vercnpj`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `vercnpj` (
 `cnpj` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `vercpf`
--

DROP TABLE IF EXISTS `vercpf`;
/*!50001 DROP VIEW IF EXISTS `vercpf`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `vercpf` (
 `cpf` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `verlogin`
--

DROP TABLE IF EXISTS `verlogin`;
/*!50001 DROP VIEW IF EXISTS `verlogin`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `verlogin` (
 `email` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `verloginemp`
--

DROP TABLE IF EXISTS `verloginemp`;
/*!50001 DROP VIEW IF EXISTS `verloginemp`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `verloginemp` (
 `email` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `vernomeeven`
--

DROP TABLE IF EXISTS `vernomeeven`;
/*!50001 DROP VIEW IF EXISTS `vernomeeven`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `vernomeeven` (
 `nome` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Current Database: `neonae`
--

USE `neonae`;

--
-- Final view structure for view `admeventos`
--

/*!50001 DROP TABLE IF EXISTS `admeventos`*/;
/*!50001 DROP VIEW IF EXISTS `admeventos`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `admeventos` AS select `e`.`id_even` AS `id`,`e`.`nome_even` AS `nome_evento`,`te`.`descr_teve` AS `tipo`,`fe`.`descr_faet` AS `faet`,`e`.`nomelocal_even` AS `local`,`e`.`startdt_even` AS `startdata`,`e`.`fimdt_even` AS `fimdata`,`e`.`starthr_even` AS `starthora`,`e`.`fimhr_even` AS `fimhr`,`c`.`nome_emp` AS `empresa` from (((`evento` `e` join `tipo_evento` `te` on((`e`.`id_teve` = `te`.`id_teve`))) join `faixa_etaria` `fe` on((`te`.`id_faet` = `fe`.`id_faet`))) join `cliente_emp` `c` on((`c`.`id_emp` = `e`.`id_emp`))) where (`e`.`ativo_even` = 1) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `control_ing`
--

/*!50001 DROP TABLE IF EXISTS `control_ing`*/;
/*!50001 DROP VIEW IF EXISTS `control_ing`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `control_ing` AS select count(`evento`.`id_even`) AS `qtd_even`,`evento`.`id_emp` AS `id` from `evento` where (`evento`.`ativo_even` = 2) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `control_ing2`
--

/*!50001 DROP TABLE IF EXISTS `control_ing2`*/;
/*!50001 DROP VIEW IF EXISTS `control_ing2`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `control_ing2` AS select `ce`.`id_emp` AS `id_emp`,`e`.`nome_even` AS `evento`,`i`.`qtddisp_ing` AS `totaldisp`,`i`.`precotot_ing` AS `valtotal`,`i`.`qtdvend_ing` AS `ingvendido` from ((`evento` `e` join `ingressos` `i` on((`i`.`id_even` = `e`.`id_even`))) join `cliente_emp` `ce` on((`ce`.`id_emp` = `e`.`id_emp`))) where (`e`.`ativo_even` = 2) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `emp_destevens`
--

/*!50001 DROP TABLE IF EXISTS `emp_destevens`*/;
/*!50001 DROP VIEW IF EXISTS `emp_destevens`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `emp_destevens` AS select `e`.`img_even` AS `img`,`e`.`nome_even` AS `even`,`ce`.`id_emp` AS `id_emp`,`r`.`qtdfav_rank` AS `qtdfav` from ((`evento` `e` join `cliente_emp` `ce` on((`e`.`id_emp` = `ce`.`id_emp`))) join `ranking` `r` on((`r`.`id_even` = `e`.`id_even`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `emp_destevens2`
--

/*!50001 DROP TABLE IF EXISTS `emp_destevens2`*/;
/*!50001 DROP VIEW IF EXISTS `emp_destevens2`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `emp_destevens2` AS select `e`.`img_even` AS `img`,`e`.`nome_even` AS `even`,`ce`.`id_emp` AS `id_emp`,`r`.`qtdfav_rank` AS `qtdfav` from ((`evento` `e` join `cliente_emp` `ce` on((`e`.`id_emp` = `ce`.`id_emp`))) join `ranking` `r` on((`r`.`id_even` = `e`.`id_even`))) where (`e`.`ativo_even` = 2) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `empalteventos`
--

/*!50001 DROP TABLE IF EXISTS `empalteventos`*/;
/*!50001 DROP VIEW IF EXISTS `empalteventos`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `empalteventos` AS select `e`.`id_even` AS `id`,`e`.`nome_even` AS `nome_evento`,`s`.`tipo_st` AS `status`,`te`.`descr_teve` AS `tipo`,`se`.`descr_subt` AS `subtipo`,`fe`.`descr_faet` AS `faet`,`e`.`nomelocal_even` AS `local`,`e`.`uf_even` AS `uf`,`e`.`cid_even` AS `cid`,`e`.`rua_even` AS `rua`,`e`.`numlocal_even` AS `num`,`e`.`img_even` AS `img`,`e`.`detalhes_even` AS `detalhes_even`,`e`.`startdt_even` AS `dt_inicio`,`e`.`starthr_even` AS `hr_inicio`,`e`.`fimdt_even` AS `data_final`,`e`.`fimhr_even` AS `hr_final`,`c`.`email_emp` AS `empresa` from (((((`evento` `e` join `tipo_evento` `te` on((`e`.`id_teve` = `te`.`id_teve`))) join `faixa_etaria` `fe` on((`te`.`id_faet` = `fe`.`id_faet`))) join `cliente_emp` `c` on((`c`.`id_emp` = `e`.`id_emp`))) join `status_evento` `s` on((`s`.`id_st` = `e`.`id_st`))) join `subtipo_evento` `se` on((`e`.`id_subt` = `se`.`id_subt`))) where (`e`.`ativo_even` = 2) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `empeventos`
--

/*!50001 DROP TABLE IF EXISTS `empeventos`*/;
/*!50001 DROP VIEW IF EXISTS `empeventos`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `empeventos` AS select `e`.`id_even` AS `id`,`e`.`nome_even` AS `nome_evento`,`te`.`descr_teve` AS `tipo`,`fe`.`descr_faet` AS `faet`,`e`.`nomelocal_even` AS `local`,`e`.`startdt_even` AS `data`,`e`.`starthr_even` AS `hora`,`c`.`email_emp` AS `empresa` from (((`evento` `e` join `tipo_evento` `te` on((`e`.`id_teve` = `te`.`id_teve`))) join `faixa_etaria` `fe` on((`te`.`id_faet` = `fe`.`id_faet`))) join `cliente_emp` `c` on((`c`.`id_emp` = `e`.`id_emp`))) where (`e`.`ativo_even` = 2) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `gerfunc`
--

/*!50001 DROP TABLE IF EXISTS `gerfunc`*/;
/*!50001 DROP VIEW IF EXISTS `gerfunc`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `gerfunc` AS select `usuario`.`id_usu` AS `id`,`usuario`.`nome_usu` AS `nome`,`usuario`.`email_usu` AS `email`,`usuario`.`dtnasc_usu` AS `dt`,`usuario`.`cpf_usu` AS `cpf`,`usuario`.`cep_usu` AS `cep` from `usuario` where (`usuario`.`id_tusu` = 2) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `getidemp`
--

/*!50001 DROP TABLE IF EXISTS `getidemp`*/;
/*!50001 DROP VIEW IF EXISTS `getidemp`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `getidemp` AS select `cliente_emp`.`id_emp` AS `id`,`cliente_emp`.`email_emp` AS `email` from `cliente_emp` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `getidevento`
--

/*!50001 DROP TABLE IF EXISTS `getidevento`*/;
/*!50001 DROP VIEW IF EXISTS `getidevento`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `getidevento` AS select `evento`.`id_even` AS `id`,`evento`.`nome_even` AS `evento` from `evento` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `getidusu`
--

/*!50001 DROP TABLE IF EXISTS `getidusu`*/;
/*!50001 DROP VIEW IF EXISTS `getidusu`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `getidusu` AS select `usuario`.`id_usu` AS `id`,`usuario`.`email_usu` AS `email` from `usuario` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `login`
--

/*!50001 DROP TABLE IF EXISTS `login`*/;
/*!50001 DROP VIEW IF EXISTS `login`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `login` AS select `u`.`email_usu` AS `email`,`u`.`senha_usu` AS `senha`,`t`.`tipo_tusu` AS `tipo_usuario` from (`usuario` `u` join `tipo_usuario` `t` on((`u`.`id_tusu` = `t`.`id_tusu`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `loginemp`
--

/*!50001 DROP TABLE IF EXISTS `loginemp`*/;
/*!50001 DROP VIEW IF EXISTS `loginemp`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `loginemp` AS select `cliente_emp`.`email_emp` AS `email`,`cliente_emp`.`senha_emp` AS `senha` from `cliente_emp` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `perfilfunc`
--

/*!50001 DROP TABLE IF EXISTS `perfilfunc`*/;
/*!50001 DROP VIEW IF EXISTS `perfilfunc`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `perfilfunc` AS select `u`.`nome_usu` AS `nome`,`u`.`dtnasc_usu` AS `data`,`u`.`cel_usu` AS `fone`,`u`.`sx_usu` AS `sexo`,`u`.`img_usu` AS `img`,`u`.`rg_usu` AS `rg`,`u`.`numcasa_usu` AS `num`,`u`.`compl_usu` AS `compl`,`u`.`cpf_usu` AS `cpf`,`u`.`email_usu` AS `email` from (`usuario` `u` join `tipo_usuario` `t` on((`u`.`id_tusu` = `t`.`id_tusu`))) where (`t`.`tipo_tusu` = 't1lu6P0YL+VOMeMviKwYhQ==') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `usu_compra`
--

/*!50001 DROP TABLE IF EXISTS `usu_compra`*/;
/*!50001 DROP VIEW IF EXISTS `usu_compra`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `usu_compra` AS select `b`.`id_buy` AS `id`,`e`.`nome_even` AS `evento`,`u`.`id_usu` AS `idusu`,`b`.`qtding_buy` AS `qtding`,`b`.`precotot_buy` AS `total`,`b`.`dthr_buy` AS `dthr`,`e`.`startdt_even` AS `dtstart`,`e`.`fimdt_even` AS `fimdt` from ((`compra` `b` join `evento` `e` on((`b`.`id_even` = `e`.`id_even`))) join `usuario` `u` on((`b`.`id_usu` = `u`.`id_usu`))) where ((`e`.`ativo_even` = 2) and (`b`.`ativo_buy` = 1)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `usueventos`
--

/*!50001 DROP TABLE IF EXISTS `usueventos`*/;
/*!50001 DROP VIEW IF EXISTS `usueventos`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `usueventos` AS select `e`.`nome_even` AS `nome_evento`,`te`.`descr_teve` AS `tipo`,`fe`.`descr_faet` AS `faixaet`,`c`.`nome_emp` AS `empresa`,`e`.`img_even` AS `img` from (((`evento` `e` join `tipo_evento` `te` on((`e`.`id_teve` = `te`.`id_teve`))) join `faixa_etaria` `fe` on((`te`.`id_faet` = `fe`.`id_faet`))) join `cliente_emp` `c` on((`c`.`id_emp` = `e`.`id_emp`))) where (`e`.`ativo_even` = 2) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `usueventos2`
--

/*!50001 DROP TABLE IF EXISTS `usueventos2`*/;
/*!50001 DROP VIEW IF EXISTS `usueventos2`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `usueventos2` AS select `e`.`id_even` AS `id`,`e`.`nome_even` AS `nome_evento`,`te`.`descr_teve` AS `tipo`,`se`.`descr_subt` AS `subtipo`,`fe`.`descr_faet` AS `faet`,`c`.`nome_emp` AS `empresa`,`e`.`img_even` AS `img`,`e`.`startdt_even` AS `data` from ((((`evento` `e` join `tipo_evento` `te` on((`e`.`id_teve` = `te`.`id_teve`))) join `faixa_etaria` `fe` on((`te`.`id_faet` = `fe`.`id_faet`))) join `cliente_emp` `c` on((`c`.`id_emp` = `e`.`id_emp`))) join `subtipo_evento` `se` on((`e`.`id_subt` = `se`.`id_subt`))) where (`e`.`ativo_even` = 2) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `usueventos3`
--

/*!50001 DROP TABLE IF EXISTS `usueventos3`*/;
/*!50001 DROP VIEW IF EXISTS `usueventos3`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `usueventos3` AS select `e`.`id_even` AS `id`,`e`.`nome_even` AS `nome_evento`,`st`.`tipo_st` AS `status`,`te`.`descr_teve` AS `tipo`,`se`.`descr_subt` AS `subtipo`,`fe`.`descr_faet` AS `faet`,`e`.`uf_even` AS `uf`,`e`.`cid_even` AS `cid`,`e`.`rua_even` AS `rua`,`e`.`numlocal_even` AS `num`,`e`.`nomelocal_even` AS `local`,`e`.`detalhes_even` AS `detalhes`,`c`.`nome_emp` AS `empresa`,`e`.`img_even` AS `img`,`e`.`startdt_even` AS `data`,`e`.`starthr_even` AS `hora` from (((((`evento` `e` join `tipo_evento` `te` on((`e`.`id_teve` = `te`.`id_teve`))) join `faixa_etaria` `fe` on((`te`.`id_faet` = `fe`.`id_faet`))) join `cliente_emp` `c` on((`c`.`id_emp` = `e`.`id_emp`))) join `subtipo_evento` `se` on((`e`.`id_subt` = `se`.`id_subt`))) join `status_evento` `st` on((`e`.`id_st` = `st`.`id_st`))) where (`e`.`ativo_even` = 2) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vercnpj`
--

/*!50001 DROP TABLE IF EXISTS `vercnpj`*/;
/*!50001 DROP VIEW IF EXISTS `vercnpj`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vercnpj` AS select `cliente_emp`.`cnpj_emp` AS `cnpj` from `cliente_emp` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vercpf`
--

/*!50001 DROP TABLE IF EXISTS `vercpf`*/;
/*!50001 DROP VIEW IF EXISTS `vercpf`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vercpf` AS select `usuario`.`cpf_usu` AS `cpf` from `usuario` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `verlogin`
--

/*!50001 DROP TABLE IF EXISTS `verlogin`*/;
/*!50001 DROP VIEW IF EXISTS `verlogin`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `verlogin` AS select `login`.`email` AS `email` from `login` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `verloginemp`
--

/*!50001 DROP TABLE IF EXISTS `verloginemp`*/;
/*!50001 DROP VIEW IF EXISTS `verloginemp`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `verloginemp` AS select `loginemp`.`email` AS `email` from `loginemp` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vernomeeven`
--

/*!50001 DROP TABLE IF EXISTS `vernomeeven`*/;
/*!50001 DROP VIEW IF EXISTS `vernomeeven`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = latin1 */;
/*!50001 SET character_set_results     = latin1 */;
/*!50001 SET collation_connection      = latin1_swedish_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vernomeeven` AS select `evento`.`nome_even` AS `nome` from `evento` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-12-01 21:20:44
