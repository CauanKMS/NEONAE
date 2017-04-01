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
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aud_adm`
--

LOCK TABLES `aud_adm` WRITE;
/*!40000 ALTER TABLE `aud_adm` DISABLE KEYS */;
INSERT INTO `aud_adm` VALUES (1,4,'bKLYzCpMwLhpF6KqiVHJ6w==','NLK3wICGQyaX0+FMLHnG+A==','Gc4xxYQjuQDEEe3aiP4Riw==','4DVNvxgqzpUO7gwmQAUlfA=='),(2,4,'8bG9Wh+QKmPqbV7DuqUPlA==','pjyHXp7OxWWZ9vHWI6XCWHn661rV1P3dswXLQMTjMa+LJtAsbWy2hiCZefGQ4GU2dV8d0sMsFR5a4La0qOKPuA==','YhvlISdA6KagRrF3Q/SenA==','4DVNvxgqzpUO7gwmQAUlfA=='),(3,4,'8bG9Wh+QKmPqbV7DuqUPlA==','pjyHXp7OxWWZ9vHWI6XCWHn661rV1P3dswXLQMTjMa+LJtAsbWy2hiCZefGQ4GU2dV8d0sMsFR5a4La0qOKPuA==','YhvlISdA6KagRrF3Q/SenA==','4DVNvxgqzpUO7gwmQAUlfA=='),(4,4,'8bG9Wh+QKmPqbV7DuqUPlA==','pjyHXp7OxWWZ9vHWI6XCWHn661rV1P3dswXLQMTjMa+LJtAsbWy2hiCZefGQ4GU2dV8d0sMsFR5a4La0qOKPuA==','YhvlISdA6KagRrF3Q/SenA==','4DVNvxgqzpUO7gwmQAUlfA=='),(5,4,'8bG9Wh+QKmPqbV7DuqUPlA==','pjyHXp7OxWWZ9vHWI6XCWHn661rV1P3dswXLQMTjMa+LJtAsbWy2hiCZefGQ4GU2dV8d0sMsFR5a4La0qOKPuA==','YhvlISdA6KagRrF3Q/SenA==','4DVNvxgqzpUO7gwmQAUlfA=='),(6,4,'8bG9Wh+QKmPqbV7DuqUPlA==','pjyHXp7OxWWZ9vHWI6XCWHn661rV1P3dswXLQMTjMa+LJtAsbWy2hiCZefGQ4GU2dV8d0sMsFR5a4La0qOKPuA==','YhvlISdA6KagRrF3Q/SenA==','4DVNvxgqzpUO7gwmQAUlfA=='),(7,4,'8bG9Wh+QKmPqbV7DuqUPlA==','pjyHXp7OxWWZ9vHWI6XCWHn661rV1P3dswXLQMTjMa+LJtAsbWy2hiCZefGQ4GU2dV8d0sMsFR5a4La0qOKPuA==','5NU90KA150QbSFWxD5MYYw==','4DVNvxgqzpUO7gwmQAUlfA=='),(8,4,'8bG9Wh+QKmPqbV7DuqUPlA==','pjyHXp7OxWWZ9vHWI6XCWHn661rV1P3dswXLQMTjMa+LJtAsbWy2hiCZefGQ4GU2dV8d0sMsFR5a4La0qOKPuA==','5NU90KA150QbSFWxD5MYYw==','4DVNvxgqzpUO7gwmQAUlfA=='),(9,4,'8bG9Wh+QKmPqbV7DuqUPlA==','pjyHXp7OxWWZ9vHWI6XCWHn661rV1P3dswXLQMTjMa+LJtAsbWy2hiCZefGQ4GU2dV8d0sMsFR5a4La0qOKPuA==','5NU90KA150QbSFWxD5MYYw==','4DVNvxgqzpUO7gwmQAUlfA=='),(10,4,'8bG9Wh+QKmPqbV7DuqUPlA==','pjyHXp7OxWWZ9vHWI6XCWHn661rV1P3dswXLQMTjMa+LJtAsbWy2hiCZefGQ4GU2dV8d0sMsFR5a4La0qOKPuA==','5NU90KA150QbSFWxD5MYYw==','4DVNvxgqzpUO7gwmQAUlfA==');
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
INSERT INTO `cliente_emp` VALUES (1,'5/UP3iKgENxLiuSJpVqKCw==','jdZL99IsxvMJ3X3o6yZXLQ==','q2bwx6TAzY92hYSPx0EdKA==','6Q+0V/HEi6QlqeKFPDBpfg==','','uBVw8UCF97uFe7XQfbQxem7w/eQWqFMfb9BryrLoBls=','XX3tMPX+cgMeF7r7/cLOig==','GXOK0SzvYxTZjAl2Zkz2Zw==','cT225qm9p9rP6pr8AJ01eA==','b0xJVQgI/2HsIuDKBlb9cw==','aMKvzPZ3KGrmsedlzvtYgz+O2hPSMEnVd1sC2N0VS2k=',1),(2,'X1fOSuUY0oNYlHwQRdL63Q==','ZlRAEisnoQ4qkns6hJlY8A==','q2bwx6TAzY92hYSPx0EdKA==','aAdDF4CnklF0IuttdhsU/A==','M8tgRRH4UG9UI4gG3ErN5A==','CaXl7ep61manqLyfJLp0SSo4F5VtTbA5L63+DTgJFDw=','1YUn8wAfcMiTYpPBBbRI7A==','iqw7Ze1bYjK6PPSXKTeDRg==','i0GRiaebQ1zNEE6Kxe/SNw==','H1GtHnXpQhCEBpJNFW2cfQ==','aMKvzPZ3KGrmsedlzvtYgz+O2hPSMEnVd1sC2N0VS2k=',1),(3,'oFkrZ9GhahkB06U+khgXGA==','K8USQ/ITOSlxSUyB8Mkl8w==','q2bwx6TAzY92hYSPx0EdKA==','D96gKNvLPtx1BxTJZHMF1w==','','h7w3I0jxekOz97HMftcO7w==','xyweBlx+pRAOX4GqNDAQhA==','1XKmW9Pcd3CO5Qz+Y6YuYg==','0cCNNB1pS8kuFlEr4CrQHA==','KjMOHg7oTOMF+m2s7X3mGw==','aMKvzPZ3KGrmsedlzvtYgz+O2hPSMEnVd1sC2N0VS2k=',1);
/*!40000 ALTER TABLE `cliente_emp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `comentarios`
--

DROP TABLE IF EXISTS `comentarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `comentarios` (
  `id_com` int(11) NOT NULL AUTO_INCREMENT,
  `id_usu` int(11) NOT NULL,
  `nota_com` text NOT NULL,
  `comentario_com` text NOT NULL,
  `ativo_com` int(11) NOT NULL,
  PRIMARY KEY (`id_com`),
  KEY `id_usu` (`id_usu`),
  CONSTRAINT `comentarios_ibfk_1` FOREIGN KEY (`id_usu`) REFERENCES `usuario` (`id_usu`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comentarios`
--

LOCK TABLES `comentarios` WRITE;
/*!40000 ALTER TABLE `comentarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `comentarios` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
INSERT INTO `evento` VALUES (1,1,9,1,1,'Lnkkp/QVHmXFqtIYgj5amPaXWDd8eA41DT16WoHu7g0=','9OK+mieVhzDgK+cfOMLVWw==','7EiHtBw7gqT9/2BsQwXuDR20eAWGhSc0FxnXJlDbQ4A=','LIAtJxtFDYfPrUJR2045iePrxXKNqdrVxi27p35sGXM=','2jGEWGb9j+kdKwd8ZS9Nag==','mwpIPwxSZ17b3gHQcYrpLw8G+t2xR7bdXiBI718Uthk=','A9O9nlcnanOcpTmtNOj4HA==','Lnkkp/QVHmXFqtIYgj5amPQEXBYwML5IHn1U285ff/78yujyJ476S7r2/VPV8GPp5wjza9nILfNNWiXt2kQ7I2w28XTi9iUcSoJEysPYAlor/1goVdVlAIjU08YwomMY','2010-04-10','23:00:00','2010-04-11','05:00:00',1),(2,2,8,2,2,'xeE2zrLs+rEgV8xqSV6BuA==','9OK+mieVhzDgK+cfOMLVWw==','7EiHtBw7gqT9/2BsQwXuDR20eAWGhSc0FxnXJlDbQ4A=','1r9fhkdaQDVUw8CY2rHUgSKISv9omb5HQcNQ1EeNmvY=','pkWSjuGA/qPYWVfZ3LKbxg==','WbeIgyvWsrrrPZoXX6Dix2w/C6AUkgcjRevmsUosgwk=','A9O9nlcnanOcpTmtNOj4HA==','qugEIBgkTrhyzfNn5ioJbXMH2D9TcRsSg/KR5WsDTNwq5K3lQVydid6w+g1Yv0EdgY+B/DItzMgIjfkHyOohe8lfhGe1n3eGqQz9R0q3vsBe/01YazxYNOhD98245SV++w2EGYeKgfjF0E1XhrupIA==','2012-04-16','00:00:00','2012-04-17','10:00:00',1),(3,4,6,2,3,'6O/yPStbEpVRMnVDEktegII5kahJCjTCKjuJrfFAJjM=','VF5UjYnUVmFueeG7/pmL+A==','lAe+5mIpyMnOjBzZtprUdA==','HzEKnaEe/I89Jx2jdRwDgw==','5onijlL2tsXbMPbVWRUVEA==','GE4SyHdEHznkWmFQbVre2Q==','A9O9nlcnanOcpTmtNOj4HA==','qI+1uTCHqnJBZ1DBbCYdQQ7zsnwhVwOn8DamXdJy3WF3ZS+tG/DQBBEJ2u052B3yIgFQRWdwOcxNUbXYBAtmBMwrjLbcKTJEDlHAeT5sd9v5KuhaguIOMYvGemfwHCxlmJpiJ3O4XkG/xf2ylabbf96vM4m+7l7xvnRpy2zzUGg=','2016-08-13','22:00:00','2017-09-13','22:00:00',1);
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ingressos`
--

LOCK TABLES `ingressos` WRITE;
/*!40000 ALTER TABLE `ingressos` DISABLE KEYS */;
/*!40000 ALTER TABLE `ingressos` ENABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ranking`
--

LOCK TABLES `ranking` WRITE;
/*!40000 ALTER TABLE `ranking` DISABLE KEYS */;
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
INSERT INTO `senhas_old` VALUES (1,4,'mF8g+xhhijwRZh/7k1IEuQ==','','','08/11/2016');
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,3,'M6yG/3zG0H60QYY8V8C4ew==','7XETBLeKSR4Fo9ZA/Wcy+w==','ZPuRwiqP8/8/PxVWKFs0uw==','FuVszYWzjPyYYDuk1vs1EQ==','O6vBVzC5RaG5g9CgH/zJGQ==','A3gnAgLbjJ6inuUYaRHFiQ==','aMKvzPZ3KGrmsedlzvtYgz+O2hPSMEnVd1sC2N0VS2k=','YXg4dSycvOOeazaCSZg+Aw==','8E2Ot2etqv1jleX+pvAAaw==','uPVXhVABlkOqawvZS5WXXg==','2EdL2ILFHsv7n8iZE3gzsw==','r/RF7Zz9qNTqdPZWAts4ig==','pXdFLhDOxJ3YV5k4RhWtEQ==','qFvTQvRbfb5Ic+C717GqNQ==',1,1),(2,3,'ieGAI89Okz8NXGUlTd6oNg==','pBMS83SPXHf4S/R6NacHMg==','KetWbOUPy/GmVsrVm3c15g==','nF2eIxnYW90I18ZdrbZQ0g==','vs8ygPhf2TGggxxBgl+Ukg==','wpHE4lFpFeoEYIehRGtUlA==','aMKvzPZ3KGrmsedlzvtYgz+O2hPSMEnVd1sC2N0VS2k=','nqUWm234dE8RPXYKX34E2A==','0y5Ps2T51Asd8YLKDa16pA==','KgQPeC3gb86OVC4mgkFLQQ==','SQ9kLzOms67cuT5zvJK5yA==','','aWsU7fqeNjoqzxth41Rt7A==','govkEZH3dcjeIsUWH4HfZw==',1,1),(3,3,'pUnBlJVRIcf2lJF+RDa/Aw==','ZBAVU9R6apBDbrCKlebAFw==','3fYCkRiH+63muelFRnc0Gw==','z8B0wvs5SyPw2rVd1vYFRw==','wAMChsvse7p/fDfzgQ7Cqg==','A3gnAgLbjJ6inuUYaRHFiQ==','aMKvzPZ3KGrmsedlzvtYgz+O2hPSMEnVd1sC2N0VS2k=','uLakuTNKGURna0UqI2eblw==','o13CEh0YwNFFNdGIPuEgTA==','eScJ/oRUpoXK2OWBq8WZBA==','48xw9J5dVYjXjpE9JoA3Cg==','6aKLPez2w18SQVPSygIxIQ==','SUJjOyt7ukkpqxdDFskCpQ==','7UF4G5QjCiybTC3EbR5qoQ==',1,1),(4,1,'b+ANrN5aBdWVzReeC44dlg==','dfq6zPjRqMq69PZ9CLetuA==','V09HLWWkR25enzYwAHuHdQ==','mF8g+xhhijwRZh/7k1IEuQ==','gRHEzRdbjGR5Ctmrbb2hsg==','A3gnAgLbjJ6inuUYaRHFiQ==','aMKvzPZ3KGrmsedlzvtYgz+O2hPSMEnVd1sC2N0VS2k=','csdXP+HqXnDmmdu20hB+Cw==','thjpMdMP0fARzAEi1dK4XA==','RIBAI+KI2zFfg2fc3hA66g==','6Q+0V/HEi6QlqeKFPDBpfg==','Iai0T6HKwf6TNGnspPWCRA==','RQzjD6LB0EmapRj2h1itsXA3tTnCYLMQbs+lo/u+UGE=','REetCLN7TOQ70HPJKmQ4Gg==',1,1),(5,2,'si4do1PSyiXTs3XWJDQG2Q==','Mkdv9Hqqr4rVVhAJ4fNnOA==','a02lpcUQm1qiykZK8gUxJg==','C1wB4QGBYFVwBdrHWYJX3g==','CruhcGlr9cC7uRaHUNJdXw==','A3gnAgLbjJ6inuUYaRHFiQ==','aMKvzPZ3KGrmsedlzvtYgz+O2hPSMEnVd1sC2N0VS2k=','pC8JDncEffXfea0ojUg0iQ==','czSUMoaC2dPm+pVr1SUuOA==','sFW1LGUUF89bxO8kgdcGsg==','MI0aT/+82MoCDVsE6d6L7A==','oZ0VMmoIMRTi40lLnGEZrA==','aHzRIWpvFereFC5lpD9MpdADSV8aLd07zJEs2pfTQwtx4wJnZ+KvMvefJiNrZFcU','GhK2i6zZlrSK9MKgWgLGYA==',0,1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-11-08 15:43:41
