/*
Navicat MySQL Data Transfer

Source Server         : Test
Source Server Version : 50716
Source Host           : localhost:3306
Source Database       : pms

Target Server Type    : MYSQL
Target Server Version : 50716
File Encoding         : 65001

Date: 2016-11-18 17:12:21
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
  `checkBoxName` varchar(50) DEFAULT NULL COMMENT '多选框名',
  `sort` int(11) DEFAULT NULL COMMENT '排序',
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
INSERT INTO `m_menu` VALUES ('1', '0', '系统设置', '', 'chk_sys', '1', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('2', '0', '商品管理', '', 'chk_product', '2', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('3', '0', '销售管理', '', 'chk_sale', '3', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('4', '0', '库存管理', '', 'chk_factory', '4', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('5', '0', '生产管理', '', 'chk_produce', '5', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('6', '0', '采购管理', '', 'chk_purchase', '6', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('7', '0', '财务管理', '', 'chk_finance', '7', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('101', '1', '用户管理', 'PMS.FrmSysUser', 'chk_sys_user', '8', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('102', '1', '角色管理', 'PMS.FrmSysRoleDetail', 'chk_sys_role', '9', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('103', '1', '库房管理', 'PMS.FrmSysFactory', 'chk_sys_factory', '10', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('104', '1', '公司信息', 'PMS.FrmSysCompany', 'chk_sys_company', '11', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('201', '2', '查询销售商品', 'PMS.FrmProductQuery', 'chk_product_query', '12', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('202', '2', '设置商品信息', 'PMS.FrmProductManage', 'chk_product_set', '13', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('301', '3', '客户管理', 'PMS.FrmCustomerManage', 'chk_sale_customer', '14', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('302', '3', '订单管理', 'PMS.FrmOrderManage', 'chk_sale_order', '15', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('401', '4', '商品入库', 'PMS.FrmProductIn', 'chk_factory_product_in', '16', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('402', '4', '商品出库', 'PMS.FrmProductOut', 'chk_factory_product_o', '17', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('403', '4', '商品调拨', 'PMS.FrmProductTransfer', 'chk_factory_product_transfer', '18', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('404', '4', '原料入库', 'PMS.FrmMaterialsIn ', 'chk_factory_materials_in', '19', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('405', '4', '原来出库', 'PMS.FrmMaterialsOut', 'chk_factory_materials_out', '20', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('501', '5', '生产计划', 'PMS.FrmProducePlan', 'chk_produce_plan', '21', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('601', '6', '供应商管理', 'PMS.FrmProviderManage', 'chk_purchase_provider', '22', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('602', '6', '原料管理', 'PMS.FrmMaterialsManage', 'chk_purchase_materials', '23', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('603', '6', '采购计划', 'PMS.FrmPurchasePlan', 'chk_purchase_plan', '24', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('604', '6', '采购订单', 'PMS.FrmPurchaseOrder', 'chk_purchase_order', '25', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('701', '7', '销售报表', 'PMS.FrmReportSale', 'chk_finance_sale', '26', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('702', '7', '采购报表', 'PMS.FrmReportPurchase', 'chk_finance_purchase', '27', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('703', '7', '应收款', 'PMS.FrmReportReceive', 'chk_finance_receive', '28', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('704', '7', '应付款', 'PMS.FrmReportPaid', 'chk_finance_paid', '29', '0', null, null, null, null);

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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of m_user
-- ----------------------------
INSERT INTO `m_user` VALUES ('1', 'admin', 'admin', '1', '男', 'boss', '1333333333', 'admin@admin.com', '2016-11-01', '0', 'sys', '2016-11-01 14:35:26', 'admin', '2016-11-17 15:31:15');
INSERT INTO `m_user` VALUES ('2', 'test1', 'admin', '3', '男', '', '', '', '2016-11-17', '0', 'admin', '2016-11-17 15:57:48', 'admin', '2016-11-17 16:03:48');

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
