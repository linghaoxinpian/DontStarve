-- MySQL dump 10.13  Distrib 5.7.15, for Win64 (x86_64)
--
-- Host: localhost    Database: dontstarve
-- ------------------------------------------------------
-- Server version	5.7.15-log

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
-- Table structure for table `actioninfo`
--

DROP TABLE IF EXISTS `actioninfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `actioninfo` (
  `Guid_id` char(36) NOT NULL COMMENT 'Guid_id',
  PRIMARY KEY (`Guid_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='权限';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `categoryinfo`
--

DROP TABLE IF EXISTS `categoryinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoryinfo` (
  `Auto_id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` char(10) NOT NULL COMMENT '名称',
  `Level` tinyint(3) unsigned DEFAULT '1' COMMENT '分类等级',
  PRIMARY KEY (`Auto_id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8 COMMENT='总分类';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cookcommentinfo`
--

DROP TABLE IF EXISTS `cookcommentinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cookcommentinfo` (
  `Guid_id` char(36) NOT NULL COMMENT 'id',
  `CookId` char(36) DEFAULT NULL COMMENT '菜 id',
  `UserId` char(36) DEFAULT NULL COMMENT '用户id',
  `Content` varchar(600) DEFAULT NULL COMMENT 'Content',
  `PraiseNum` int(10) unsigned NOT NULL DEFAULT '0' COMMENT '点赞数',
  PRIMARY KEY (`Guid_id`),
  KEY `FK_Reference_15` (`UserId`),
  KEY `FK_Reference_11` (`CookId`),
  CONSTRAINT `FK_Reference_11` FOREIGN KEY (`CookId`) REFERENCES `cookinfo` (`Guid_id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Reference_15` FOREIGN KEY (`UserId`) REFERENCES `userinfo` (`Guid_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='菜的评论';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cookinfo`
--

DROP TABLE IF EXISTS `cookinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cookinfo` (
  `Guid_id` char(36) NOT NULL COMMENT 'id',
  `Name` varchar(30) NOT NULL COMMENT '菜名',
  `Level` tinyint(3) unsigned NOT NULL DEFAULT '1' COMMENT '难度',
  `DelFlag` bit(1) NOT NULL DEFAULT b'0' COMMENT '是否删除',
  `Rating` tinyint(3) unsigned NOT NULL DEFAULT '0' COMMENT '好评度',
  `PraiseNum` int(10) unsigned NOT NULL DEFAULT '0' COMMENT '点赞数',
  `pic` mediumblob,
  `VideoPath` varchar(100) DEFAULT NULL COMMENT '做法视频',
  `Remark` text COMMENT '备注',
  `Func` text NOT NULL,
  PRIMARY KEY (`Guid_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='菜';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `everydayrecommendinfo`
--

DROP TABLE IF EXISTS `everydayrecommendinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `everydayrecommendinfo` (
  `CookId` char(36) NOT NULL COMMENT 'CookId',
  `SubAdmin` char(36) NOT NULL COMMENT '提交人Id',
  `RecommendTime` bigint(20) NOT NULL COMMENT '推荐日期',
  `OurRatings` char(2) NOT NULL COMMENT '推荐指数',
  `Reason` varchar(300) NOT NULL COMMENT '推荐理由',
  `Subtime` bigint(20) NOT NULL COMMENT '提交日期',
  PRIMARY KEY (`CookId`,`RecommendTime`),
  KEY `FK_Reference_18` (`SubAdmin`),
  CONSTRAINT `FK_Reference_17` FOREIGN KEY (`CookId`) REFERENCES `cookinfo` (`Guid_id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Reference_18` FOREIGN KEY (`SubAdmin`) REFERENCES `userinfo` (`Guid_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='每日推荐';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `friendinfo`
--

DROP TABLE IF EXISTS `friendinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `friendinfo` (
  `UserId` char(36) NOT NULL COMMENT '用户id',
  `FriendId` char(36) NOT NULL COMMENT '好友id',
  `SubTime` bigint(20) NOT NULL COMMENT '开始时间',
  PRIMARY KEY (`UserId`,`FriendId`),
  CONSTRAINT `FK_Reference_16` FOREIGN KEY (`UserId`) REFERENCES `userinfo` (`Guid_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='好友';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `leavenoteinfo`
--

DROP TABLE IF EXISTS `leavenoteinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `leavenoteinfo` (
  `Auto_id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` char(36) NOT NULL COMMENT '用户id',
  `Context` text NOT NULL COMMENT '内容',
  `Subtime` bigint(20) NOT NULL COMMENT '时间',
  PRIMARY KEY (`Auto_id`),
  KEY `FK_Reference_19` (`UserId`),
  CONSTRAINT `FK_Reference_19` FOREIGN KEY (`UserId`) REFERENCES `userinfo` (`Guid_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COMMENT='留言';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `materialinfo`
--

DROP TABLE IF EXISTS `materialinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `materialinfo` (
  `auto_id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(30) NOT NULL COMMENT '名称',
  `Remark` varchar(200) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`auto_id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8 COMMENT='原料';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `r_category_cookinfo`
--

DROP TABLE IF EXISTS `r_category_cookinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `r_category_cookinfo` (
  `CategoryId` int(11) NOT NULL,
  `CookId` char(36) NOT NULL COMMENT '菜id',
  PRIMARY KEY (`CategoryId`,`CookId`),
  KEY `FK_Reference_2` (`CookId`),
  CONSTRAINT `FK_Reference_1` FOREIGN KEY (`CategoryId`) REFERENCES `categoryinfo` (`Auto_id`),
  CONSTRAINT `FK_Reference_2` FOREIGN KEY (`CookId`) REFERENCES `cookinfo` (`Guid_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='R_Category_CookInfo';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `r_material_cookinfo`
--

DROP TABLE IF EXISTS `r_material_cookinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `r_material_cookinfo` (
  `CookId` char(36) NOT NULL COMMENT '菜id',
  `MaterialId` int(11) NOT NULL,
  `Num` char(10) NOT NULL DEFAULT '1份' COMMENT '份量',
  PRIMARY KEY (`CookId`,`MaterialId`),
  KEY `FK_Reference_3` (`MaterialId`),
  CONSTRAINT `FK_Reference_3` FOREIGN KEY (`MaterialId`) REFERENCES `materialinfo` (`auto_id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Reference_4` FOREIGN KEY (`CookId`) REFERENCES `cookinfo` (`Guid_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='R_Material_CookInfo';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `r_role_actioninfo`
--

DROP TABLE IF EXISTS `r_role_actioninfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `r_role_actioninfo` (
  `Guid_id` char(36) NOT NULL COMMENT 'Guid_id',
  `Rol_Guid_id` char(36) NOT NULL COMMENT '角色_Guid_id',
  PRIMARY KEY (`Guid_id`,`Rol_Guid_id`),
  KEY `FK_Reference_7` (`Rol_Guid_id`),
  CONSTRAINT `FK_Reference_7` FOREIGN KEY (`Rol_Guid_id`) REFERENCES `roleinfo` (`Guid_id`),
  CONSTRAINT `FK_Reference_8` FOREIGN KEY (`Guid_id`) REFERENCES `actioninfo` (`Guid_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='R_Role_ActionInfo';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `r_user_actioninfo`
--

DROP TABLE IF EXISTS `r_user_actioninfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `r_user_actioninfo` (
  `UserId` char(36) NOT NULL COMMENT 'User_Id',
  `ActionId` char(36) NOT NULL COMMENT 'Action_id',
  `IsPass` bit(1) DEFAULT b'1' COMMENT '是否允许',
  PRIMARY KEY (`UserId`,`ActionId`),
  KEY `FK_Reference_9` (`ActionId`),
  CONSTRAINT `FK_Reference_10` FOREIGN KEY (`UserId`) REFERENCES `userinfo` (`Guid_id`),
  CONSTRAINT `FK_Reference_9` FOREIGN KEY (`ActionId`) REFERENCES `actioninfo` (`Guid_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='R_User_ActionInfo';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `r_user_roleinfo`
--

DROP TABLE IF EXISTS `r_user_roleinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `r_user_roleinfo` (
  `Guid_id` char(36) NOT NULL COMMENT 'Guid_id',
  `Rol_Guid_id` char(36) NOT NULL COMMENT '角色_Guid_id',
  PRIMARY KEY (`Guid_id`,`Rol_Guid_id`),
  KEY `FK_Reference_6` (`Rol_Guid_id`),
  CONSTRAINT `FK_Reference_5` FOREIGN KEY (`Guid_id`) REFERENCES `userinfo` (`Guid_id`),
  CONSTRAINT `FK_Reference_6` FOREIGN KEY (`Rol_Guid_id`) REFERENCES `roleinfo` (`Guid_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='R_User_RoleInfo';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `roleinfo`
--

DROP TABLE IF EXISTS `roleinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `roleinfo` (
  `Guid_id` char(36) NOT NULL COMMENT 'Guid_id',
  `Name` varchar(20) NOT NULL COMMENT '角色名称',
  PRIMARY KEY (`Guid_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='角色';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `saysaycommentinfo`
--

DROP TABLE IF EXISTS `saysaycommentinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `saysaycommentinfo` (
  `Guid_id` char(36) NOT NULL COMMENT 'Guid_id',
  `SaysayId` char(36) NOT NULL COMMENT '说说id',
  `UserId` char(36) NOT NULL COMMENT '对回复用户id',
  `ToUserId` char(36) NOT NULL,
  `Content` text COMMENT 'Content',
  `Subtime` bigint(20) NOT NULL COMMENT '回复时间',
  PRIMARY KEY (`Guid_id`),
  KEY `FK_Reference_13` (`SaysayId`),
  CONSTRAINT `FK_Reference_13` FOREIGN KEY (`SaysayId`) REFERENCES `saysayinfo` (`Guid_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='说说评论';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `saysayinfo`
--

DROP TABLE IF EXISTS `saysayinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `saysayinfo` (
  `Guid_id` char(36) NOT NULL COMMENT 'Guid_id',
  `UserId` char(36) NOT NULL COMMENT '用户id',
  `Content` text NOT NULL COMMENT 'Content',
  `Subtime` bigint(20) NOT NULL COMMENT '发表时间',
  `Pic` mediumblob COMMENT '图片',
  `DelFlag` bit(1) NOT NULL DEFAULT b'0' COMMENT '删除',
  `IsAllUserCanSee` bit(1) NOT NULL DEFAULT b'0' COMMENT '所有人可见',
  `PraiseNum` int(10) unsigned NOT NULL,
  PRIMARY KEY (`Guid_id`),
  KEY `FK_Reference_14` (`UserId`),
  CONSTRAINT `FK_Reference_14` FOREIGN KEY (`UserId`) REFERENCES `userinfo` (`Guid_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='说说';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `userinfo`
--

DROP TABLE IF EXISTS `userinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `userinfo` (
  `Guid_id` char(36) NOT NULL COMMENT 'Guid_id',
  `Name` varchar(32) NOT NULL COMMENT '名字',
  `pwd` char(32) DEFAULT NULL,
  `Remark` varchar(256) DEFAULT NULL COMMENT '备注',
  `Pic` mediumblob COMMENT '头像',
  `SubTime` bigint(20) NOT NULL COMMENT '注册时间',
  `Signature` varchar(32) DEFAULT NULL COMMENT '签名',
  `QQ` char(13) DEFAULT NULL COMMENT 'QQ',
  `Phone` char(11) DEFAULT NULL COMMENT 'Phone',
  `DelFlag` bit(1) NOT NULL DEFAULT b'0' COMMENT '删除标识',
  `IdCard` char(18) DEFAULT NULL COMMENT 'IdCard',
  PRIMARY KEY (`Guid_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='用户';
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-01-03  1:26:16
