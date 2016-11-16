/*
Navicat MySQL Data Transfer

Source Server         : Test
Source Server Version : 50716
Source Host           : localhost:3306
Source Database       : pms

Target Server Type    : MYSQL
Target Server Version : 50716
File Encoding         : 65001

Date: 2016-11-04 14:06:56
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for m_user
-- ----------------------------
DROP TABLE IF EXISTS `m_user`;
CREATE TABLE `m_user` (
  `userId` int(11) NOT NULL AUTO_INCREMENT,
  `userName` varchar(50) DEFAULT NULL,
  `pwd` varchar(50) DEFAULT NULL,
  `roleId` int(11) DEFAULT NULL,
  `isDelete` int(11) DEFAULT NULL,
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifeTime` datetime DEFAULT NULL,
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
