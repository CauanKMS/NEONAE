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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aud_adm`
--

LOCK TABLES `aud_adm` WRITE;
/*!40000 ALTER TABLE `aud_adm` DISABLE KEYS */;
INSERT INTO `aud_adm` VALUES (1,1,'bKLYzCpMwLhpF6KqiVHJ6w==','J27V10y9CeTdK59ga98wdiFQxplOsgH6+LxNm+bzizlFinndyuMATJZW6w0Edgha','p50ditDNFacAEUfsF6ZWBg==','rhabkhwwtKWX/LLw3wPoDw=='),(2,1,'bKLYzCpMwLhpF6KqiVHJ6w==','NLK3wICGQyaX0+FMLHnG+A==','p50ditDNFacAEUfsF6ZWBg==','rhabkhwwtKWX/LLw3wPoDw=='),(3,1,'8bG9Wh+QKmPqbV7DuqUPlA==','pjyHXp7OxWWZ9vHWI6XCWHn661rV1P3dswXLQMTjMa+LJtAsbWy2hiCZefGQ4GU2dV8d0sMsFR5a4La0qOKPuA==','8GQTxXYpfv2gfxQstdDiGA==','rhabkhwwtKWX/LLw3wPoDw=='),(4,1,'8bG9Wh+QKmPqbV7DuqUPlA==','pjyHXp7OxWWZ9vHWI6XCWHn661rV1P3dswXLQMTjMa+LJtAsbWy2hiCZefGQ4GU2dV8d0sMsFR5a4La0qOKPuA==','8GQTxXYpfv2gfxQstdDiGA==','rhabkhwwtKWX/LLw3wPoDw=='),(5,1,'8bG9Wh+QKmPqbV7DuqUPlA==','pjyHXp7OxWWZ9vHWI6XCWHn661rV1P3dswXLQMTjMa+LJtAsbWy2hiCZefGQ4GU2dV8d0sMsFR5a4La0qOKPuA==','8GQTxXYpfv2gfxQstdDiGA==','rhabkhwwtKWX/LLw3wPoDw=='),(6,1,'8bG9Wh+QKmPqbV7DuqUPlA==','pjyHXp7OxWWZ9vHWI6XCWHn661rV1P3dswXLQMTjMa+LJtAsbWy2hiCZefGQ4GU2dV8d0sMsFR5a4La0qOKPuA==','Mht4zxCA5ETssIWeJERZmw==','rhabkhwwtKWX/LLw3wPoDw=='),(7,1,'8bG9Wh+QKmPqbV7DuqUPlA==','msNvMwnbsgabUiz6V4NRI1R0k2d5Ee1KbVsgdzuJ9Ww=','Mht4zxCA5ETssIWeJERZmw==','rhabkhwwtKWX/LLw3wPoDw=='),(8,1,'riuTN2/0Wkm+f0YaPAQfpQ==','K0KdQUWJ5KEUwo8qhxrK/mcjfTO3Vl0oh7ik8BUsmyDnMsvNOw10dEx02Hey4dXq','6mbvNTi6s4gUpCEjtDqnMw==','rhabkhwwtKWX/LLw3wPoDw==');
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aud_emp`
--

LOCK TABLES `aud_emp` WRITE;
/*!40000 ALTER TABLE `aud_emp` DISABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aud_usu`
--

LOCK TABLES `aud_usu` WRITE;
/*!40000 ALTER TABLE `aud_usu` DISABLE KEYS */;
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
INSERT INTO `cliente_emp` VALUES (1,'5/UP3iKgENxLiuSJpVqKCw==','jdZL99IsxvMJ3X3o6yZXLQ==','q2bwx6TAzY92hYSPx0EdKA==','6Q+0V/HEi6QlqeKFPDBpfg==','oZ0VMmoIMRTi40lLnGEZrA==','uBVw8UCF97uFe7XQfbQxem7w/eQWqFMfb9BryrLoBls=','XX3tMPX+cgMeF7r7/cLOig==','GXOK0SzvYxTZjAl2Zkz2Zw==','cT225qm9p9rP6pr8AJ01eA==','b0xJVQgI/2HsIuDKBlb9cw==','yqV7ADErPeDY4uCX0weuJw==',1),(2,'X1fOSuUY0oNYlHwQRdL63Q==','ZlRAEisnoQ4qkns6hJlY8A==','q2bwx6TAzY92hYSPx0EdKA==','aAdDF4CnklF0IuttdhsU/A==','M8tgRRH4UG9UI4gG3ErN5A==','CaXl7ep61manqLyfJLp0SSo4F5VtTbA5L63+DTgJFDw=','1YUn8wAfcMiTYpPBBbRI7A==','iqw7Ze1bYjK6PPSXKTeDRg==','i0GRiaebQ1zNEE6Kxe/SNw==','H1GtHnXpQhCEBpJNFW2cfQ==','yqV7ADErPeDY4uCX0weuJw==',1),(3,'oFkrZ9GhahkB06U+khgXGA==','K8USQ/ITOSlxSUyB8Mkl8w==','q2bwx6TAzY92hYSPx0EdKA==','D96gKNvLPtx1BxTJZHMF1w==','oZ0VMmoIMRTi40lLnGEZrA==','h7w3I0jxekOz97HMftcO7w==','xyweBlx+pRAOX4GqNDAQhA==','1XKmW9Pcd3CO5Qz+Y6YuYg==','0cCNNB1pS8kuFlEr4CrQHA==','KjMOHg7oTOMF+m2s7X3mGw==','yqV7ADErPeDY4uCX0weuJw==',1);
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra`
--

LOCK TABLES `compra` WRITE;
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
INSERT INTO `evento` VALUES (1,2,8,1,1,'XwdYuB4bYiCJuX3FidKLYA==','9OK+mieVhzDgK+cfOMLVWw==','9grfFKjVFs1r/gBjSL/u4A==','pVy25LPlelSMngruRj/noQ==','PJa/Vkez6ZfyyJGuwQXG0g==','RmknhXhHHItws97XiZFs5Q==','yqV7ADErPeDY4uCX0weuJw==','CC4X9cvFVH4Tr9pir2etjaaXaXIkThsYZPurX3kMk9zhIpw6s9apdbz89JB49gA7','2017-02-15','22:00:00','2017-02-19','18:00:00',1),(2,1,9,2,1,'CYYjzMUfkpIoAN5L+hft9w==','9OK+mieVhzDgK+cfOMLVWw==','9OK+mieVhzDgK+cfOMLVWw==','/jf5PctDDW/Pryg4OwRpAA==','DDVVwsuzrMN7LJW3n+vR3A==','+ibhG4XFummTpzCxZ+XqpllMp7/NAd5P5y+dhvdIoJk=','yqV7ADErPeDY4uCX0weuJw==','T/WCYonu/V4M6ddX3bdaUEsVPfKuyXtSOlPjtzHru8i104xTxB+ty1Bym8Lardpo1oA8tTpaGb0G4rzhGiE4Y7HR9yIBJnHLF1X3hmPDlJKbHHXwUTh999KKFyQ/JuMN','2016-12-15','16:00:00','2016-12-15','22:00:00',2),(3,3,4,1,2,'tgRHek4UTzvwH6WleLpgqs8hyd0vX4iVJdWuHhUYqYI=','9OK+mieVhzDgK+cfOMLVWw==','9OK+mieVhzDgK+cfOMLVWw==','0J9vrTARCmiOy32DJXpoF/YgC/bryMJ2TA1lJTNXM3w=','LQXropEXkXORhWc+B7FzPA==','kM1Cvi94jwCTB6eXLi31Ln3cocpR7F738bq4id6EyKI=','yqV7ADErPeDY4uCX0weuJw==','CC4X9cvFVH4Tr9pir2etjaaXaXIkThsYZPurX3kMk9zhIpw6s9apdbz89JB49gA7','2017-01-29','19:00:00','2017-01-29','22:00:00',1),(4,5,3,2,2,'mkKoetzh+CphhVMUD6cnug==','l3wAHV11Yp3KhR+ss15JWw==','tP+Disc9M9zRQYNBKA2f4Q==','fjs4WW3Bydtxbk3W/O/PszJre2kvsA4DqLZk0pXBoDLFSgDWf2s2iFVdu/5pKFep','Eh6zO1RdhWfGqeYTiNMMug==','wSukgb6vlr/B8ooXQ392WlECjV8mw5Hfe/60dSByrDQ=','yqV7ADErPeDY4uCX0weuJw==','CC4X9cvFVH4Tr9pir2etjaaXaXIkThsYZPurX3kMk9zhIpw6s9apdbz89JB49gA7','2017-05-13','22:00:00','2017-05-14','01:00:00',1),(5,10,7,2,3,'yqxQrYSAyOIUiOqMLSjVLnvD6gErg1VV30rX1YriKiw=','9OK+mieVhzDgK+cfOMLVWw==','9grfFKjVFs1r/gBjSL/u4A==','DoDpi3PdA8SeG79kdVdw4vCDZqP0vKaeaQA9oOyW29w=','YiPBTkSzptwGoqVR59bm0Q==','nCi2TjcZv4Bu1uDcEtufjIhH3vOPXtDSPvsYd0R4yuU=','yqV7ADErPeDY4uCX0weuJw==','qCMGdmqpnzgoo8UOKca2eE3lqTfLzlKUXGzjV0VEcIU/tLXiLLDZb5+TFVB4fG/t','2016-12-05','23:30:00','2017-12-06','02:30:00',1);
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fpgto`
--

LOCK TABLES `fpgto` WRITE;
/*!40000 ALTER TABLE `fpgto` DISABLE KEYS */;
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
INSERT INTO `ingressos` VALUES (1,2,'odCGDNjFMqSzRUivnkfouw==','xvs8LUXj9wIYYg8cN8xg1w==','gMcO0KKCb0sV0Hvc94u79g=='),(2,4,'d4QmXuXQePkpi65rv8z70A==','qQH+UKPIcGLxACeCQNJtzA==','gMcO0KKCb0sV0Hvc94u79g=='),(3,5,'GoczbelKxLPmF0Ia4v+f7w==','BgWHBsdD1dptgegZ1LH8eA==','gMcO0KKCb0sV0Hvc94u79g==');
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `qrcode`
--

LOCK TABLES `qrcode` WRITE;
/*!40000 ALTER TABLE `qrcode` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ranking`
--

LOCK TABLES `ranking` WRITE;
/*!40000 ALTER TABLE `ranking` DISABLE KEYS */;
INSERT INTO `ranking` VALUES (1,1,'2w9mb4YD/VVV2A3NoRFs7g==','gMcO0KKCb0sV0Hvc94u79g=='),(2,2,'2w9mb4YD/VVV2A3NoRFs7g==','gMcO0KKCb0sV0Hvc94u79g=='),(3,3,'2w9mb4YD/VVV2A3NoRFs7g==','gMcO0KKCb0sV0Hvc94u79g=='),(4,4,'2w9mb4YD/VVV2A3NoRFs7g==','gMcO0KKCb0sV0Hvc94u79g=='),(5,5,'2w9mb4YD/VVV2A3NoRFs7g==','gMcO0KKCb0sV0Hvc94u79g==');
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
INSERT INTO `senhas_old` VALUES (1,1,'mF8g+xhhijwRZh/7k1IEuQ==','','','kvRP5ahm0J6I3V52SJTQJQ==');
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,1,'Fo1WNMzzOTzdrmDmLwh4LQ==','VcAZRxrXp3jLhNarK1Cm4w==','g+WGqqhog7O302dVzvcgXPAcj3Y5YSnFmahzSnaa1tM=','mF8g+xhhijwRZh/7k1IEuQ==','Z+tvUWgmRVMlg9wrJqEvtw==','ojch/7guNj+sXi591kh8UQ==','LJ0iHy+7BdY6Z2Zxnl/T8VESgkrU6KbqYFCPaveVReU=','cNaJRttPPxHS3lm9lpShQw==','tS3bfclLHuBFGB6nunspZg==','IO1okX2oZ0spt0DdyEPGOQ==','GoczbelKxLPmF0Ia4v+f7w==','6aKLPez2w18SQVPSygIxIQ==','RQzjD6LB0EmapRj2h1itsXA3tTnCYLMQbs+lo/u+UGE=','coAtKvDmwj0IeWRG6su8fw==',1,1);
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

-- Dump completed on 2016-11-16 13:39:11
