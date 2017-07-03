/*
Navicat MySQL Data Transfer

Source Server         : Test
Source Server Version : 50716
Source Host           : localhost:3306
Source Database       : pms

Target Server Type    : MYSQL
Target Server Version : 50716
File Encoding         : 65001

Date: 2016-11-16 17:07:40
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for m_menu
-- ----------------------------
DROP TABLE IF EXISTS `m_menu`;
CREATE TABLE `m_menu` (
  `menuId` int(11) NOT NULL AUTO_INCREMENT,
  `parentId` int(11) DEFAULT NULL COMMENT '上级菜单ID',
  `menuName` varchar(50) DEFAULT NULL COMMENT '菜单名',
  `formName` varchar(50) DEFAULT NULL,
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`menuId`)
) ENGINE=InnoDB AUTO_INCREMENT=705 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of m_menu
-- ----------------------------
INSERT INTO `m_menu` VALUES ('1', '0', '系统设置', '', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('2', '0', '商品管理', '', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('3', '0', '销售管理', '', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('4', '0', '库存管理', '', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('5', '0', '生产管理', '', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('6', '0', '采购管理', '', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('7', '0', '财务管理', '', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('101', '1', '用户管理', 'PMS.FrmSysUser', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('102', '1', '公司信息', 'PMS.FrmSysCompany', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('103', '1', '库房管理', 'PMS.FrmSysFactory', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('104', '1', '角色管理', 'PMS.FrmSysRole', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('201', '2', '查询销售商品', 'PMS.FrmProductQuery', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('202', '2', '设置商品信息', 'PMS.FrmProductManage', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('301', '3', '客户管理', 'PMS.FrmCustomerManage', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('302', '3', '订单管理', 'PMS.FrmOrderManage', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('401', '4', '商品入库', 'PMS.FrmProductIn', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('402', '4', '商品出库', 'PMS.FrmProductOut', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('403', '4', '商品调拨', 'PMS.FrmProductTransfer', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('404', '4', '原料入库', 'PMS.FrmMaterialsIn ', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('405', '4', '原来出库', 'PMS.FrmMaterialsOut', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('501', '5', '生产计划', 'PMS.FrmProducePlan', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('601', '6', '供应商管理', 'PMS.FrmProviderManage', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('602', '6', '原料管理', 'PMS.FrmMaterialsManage', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('603', '6', '采购计划', 'PMS.FrmPurchasePlan', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('604', '6', '采购订单', 'PMS.FrmPurchaseOrder', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('701', '7', '销售报表', 'PMS.FrmReportSale', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('702', '7', '采购报表', 'PMS.FrmReportPurchase', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('703', '7', '应收款', 'PMS.FrmReportReceive', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('704', '7', '应付款', 'PMS.FrmReportPaid', '0', null, null, null, null);

-- ----------------------------
-- Table structure for m_role
-- ----------------------------
DROP TABLE IF EXISTS `m_role`;
CREATE TABLE `m_role` (
  `roleId` int(11) NOT NULL AUTO_INCREMENT,
  `roleName` varchar(50) DEFAULT NULL,
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`roleId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of m_role
-- ----------------------------
INSERT INTO `m_role` VALUES ('1', '系统管理', '0', null, null, null, null);
INSERT INTO `m_role` VALUES ('2', '商品管理', '0', null, null, null, null);
INSERT INTO `m_role` VALUES ('3', '销售管理', '0', null, null, null, null);
INSERT INTO `m_role` VALUES ('4', '仓库管理', '0', null, null, null, null);
INSERT INTO `m_role` VALUES ('5', '生产管理', '0', null, null, null, null);
INSERT INTO `m_role` VALUES ('6', '采购管理', '0', null, null, null, null);
INSERT INTO `m_role` VALUES ('7', '财务管理', '0', null, null, null, null);

-- ----------------------------
-- Table structure for m_user
-- ----------------------------
DROP TABLE IF EXISTS `m_user`;
CREATE TABLE `m_user` (
  `userId` int(11) NOT NULL AUTO_INCREMENT,
  `userName` varchar(50) DEFAULT NULL,
  `pwd` varchar(50) DEFAULT NULL,
  `roleId` int(11) DEFAULT NULL,
  `sex` varchar(2) DEFAULT NULL COMMENT '性别',
  `position` varchar(50) DEFAULT NULL COMMENT '职位',
  `mobile` varchar(20) DEFAULT NULL COMMENT '手机',
  `email` varchar(50) DEFAULT NULL COMMENT '电子邮件',
  `birthday` date DEFAULT NULL COMMENT '出生年月日',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of m_user
-- ----------------------------
INSERT INTO `m_user` VALUES ('1', 'admin', 'admin', '1', null, null, null, null, null, '0', null, null, null, null);

-- ----------------------------
-- Table structure for r_role_menu
-- ----------------------------
DROP TABLE IF EXISTS `r_role_menu`;
CREATE TABLE `r_role_menu` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `roleId` int(11) DEFAULT NULL,
  `menuId` int(11) DEFAULT NULL,
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_role_menu
-- ----------------------------
