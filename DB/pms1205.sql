/*
Navicat MySQL Data Transfer

Source Server         : pms
Source Server Version : 50716
Source Host           : localhost:3306
Source Database       : pms

Target Server Type    : MYSQL
Target Server Version : 50716
File Encoding         : 65001

Date: 2016-12-05 20:34:10
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for m_code
-- ----------------------------
DROP TABLE IF EXISTS `m_code`;
CREATE TABLE `m_code` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` int(10) NOT NULL,
  `subCode` int(10) DEFAULT NULL,
  `value1` varchar(255) DEFAULT NULL,
  `value2` varchar(255) DEFAULT NULL,
  `value3` varchar(255) DEFAULT NULL,
  `remark` varchar(255) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of m_code
-- ----------------------------
INSERT INTO `m_code` VALUES ('1', '1', null, null, null, null, '包装类型', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('2', '1', '1', '瓶装', '', '', '', '0', null, null, 'admin', '2016-11-22 10:03:18');
INSERT INTO `m_code` VALUES ('3', '1', '2', '袋装', '', '', '', '0', null, null, 'admin', '2016-11-22 10:03:18');
INSERT INTO `m_code` VALUES ('4', '1', '3', '听装', '', '', '', '0', null, null, 'admin', '2016-11-22 10:03:18');
INSERT INTO `m_code` VALUES ('5', '1', '4', '桶装', '', '', '', '0', null, null, 'admin', '2016-11-22 10:03:18');
INSERT INTO `m_code` VALUES ('6', '1', '5', '箱装', '', '', '', '0', null, null, 'admin', '2016-11-22 10:03:18');
INSERT INTO `m_code` VALUES ('7', '2', null, null, null, null, '产品形态', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('8', '2', '1', '液体', '', '', '', '0', null, null, 'admin', '2016-11-22 16:00:32');
INSERT INTO `m_code` VALUES ('9', '2', '2', '颗粒', '', '', '', '0', null, null, 'admin', '2016-11-22 16:00:32');
INSERT INTO `m_code` VALUES ('10', '2', '3', '粉末', '', '', '', '0', null, null, 'admin', '2016-11-22 16:00:32');
INSERT INTO `m_code` VALUES ('11', '2', '4', '胶质', '', '', '', '0', null, null, 'admin', '2016-11-22 16:00:32');
INSERT INTO `m_code` VALUES ('12', '2', '5', '气体', '', '', '', '0', null, null, 'admin', '2016-11-22 16:00:32');
INSERT INTO `m_code` VALUES ('13', '3', null, null, null, null, '重量单位', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('14', '3', '1', '克', '1', null, 'value2为【克】的相对值', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('15', '3', '2', '毫克', '0.001', null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('16', '3', '3', '千克', '1000', null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('17', '3', '4', '吨', '1000000', null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('18', '1', '6', 'test', '', '', '', '1', 'admin', '2016-11-22 10:02:22', 'admin', '2016-11-22 10:02:43');

-- ----------------------------
-- Table structure for m_company
-- ----------------------------
DROP TABLE IF EXISTS `m_company`;
CREATE TABLE `m_company` (
  `id` int(11) NOT NULL,
  `name` varchar(400) DEFAULT NULL,
  `address` varchar(500) DEFAULT NULL,
  `telphone` varchar(100) DEFAULT NULL,
  `homepage` varchar(200) DEFAULT NULL,
  `fax` varchar(100) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `zip` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of m_company
-- ----------------------------
INSERT INTO `m_company` VALUES ('1', '天下第一家', '中南海2', '88888888', 'http://www.test.com', '99999999', 'first@second.com', '200000');

-- ----------------------------
-- Table structure for m_factory
-- ----------------------------
DROP TABLE IF EXISTS `m_factory`;
CREATE TABLE `m_factory` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(400) DEFAULT NULL,
  `address` varchar(500) DEFAULT NULL,
  `telphone` varchar(100) DEFAULT NULL,
  `homepage` varchar(200) DEFAULT NULL,
  `fax` varchar(100) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `zip` varchar(100) DEFAULT NULL,
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of m_factory
-- ----------------------------
INSERT INTO `m_factory` VALUES ('1', 'factory1', 'address1', '11111111', '', '22222222', '', '2000000', '0', 'admin', '2016-11-19 17:45:34', 'admin', '2016-11-19 20:33:50');
INSERT INTO `m_factory` VALUES ('2', 'factory2', 'address2', '', '', '', '', '', '0', 'admin', '2016-11-19 20:13:53', 'admin', '2016-11-19 20:13:53');
INSERT INTO `m_factory` VALUES ('3', 'factory3', '', '', '', '', '', '', '1', 'admin', '2016-11-19 20:28:47', 'admin', '2016-11-19 20:28:58');

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
INSERT INTO `m_menu` VALUES ('9', '0', '退出', 'PMS.Frm.Login.FrmLogin', null, '999', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('101', '1', '用户管理', 'PMS.Frm.Sys.FrmSysUser', 'chk_sys_user', '101', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('102', '1', '角色管理', 'PMS.Frm.Sys.FrmSysRole', 'chk_sys_role', '102', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('103', '1', '库房管理', 'PMS.Frm.Sys.FrmSysFactory', 'chk_sys_factory', '103', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('104', '1', '公司信息', 'PMS.Frm.Sys.FrmSysCompany', 'chk_sys_company', '104', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('105', '1', '系统设置', 'PMS.Frm.Sys.FrmSysConfig', 'chk_sys_config', '105', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('201', '2', '商品查询', 'PMS.Frm.Product.FrmProductQuery', 'chk_product_query', '201', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('202', '2', '商品管理', 'PMS.Frm.Product.FrmProductManage', 'chk_product_set', '202', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('203', '2', '原料管理', 'PMS.Frm.Product.FrmMaterialsManage', 'chk_purchase_materials', '203', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('301', '3', '客户管理', 'PMS.Frm.Sale.FrmCustomerManage', 'chk_sale_customer', '301', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('302', '3', '订单管理', 'PMS.Frm.Sale.FrmOrderManage', 'chk_sale_order', '302', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('401', '4', '商品入库', 'PMS.Frm.Factory.FrmProductIn', 'chk_factory_product_in', '401', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('402', '4', '商品出库', 'PMS.Frm.Factory.FrmProductOut', 'chk_factory_product_o', '402', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('403', '4', '商品调拨', 'PMS.Frm.Factory.FrmProductTransfer', 'chk_factory_product_transfer', '403', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('404', '4', '原料入库', 'PMS.Frm.Factory.FrmMaterialsIn ', 'chk_factory_materials_in', '404', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('405', '4', '原来出库', 'PMS.Frm.Factory.FrmMaterialsOut', 'chk_factory_materials_out', '405', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('501', '5', '生产计划', 'PMS.Frm.Produce.FrmProducePlan', 'chk_produce_plan', '501', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('601', '6', '供应商管理', 'PMS.Frm.Purchase.FrmProviderManage', 'chk_purchase_provider', '601', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('603', '6', '采购计划', 'PMS.Frm.Purchase.FrmPurchasePlan', 'chk_purchase_plan', '603', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('604', '6', '采购订单', 'PMS.Frm.Purchase.FrmPurchaseOrder', 'chk_purchase_order', '604', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('701', '7', '销售报表', 'PMS.Frm.Finance.FrmReportSale', 'chk_finance_sale', '701', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('702', '7', '采购报表', 'PMS.Frm.Finance.FrmReportPurchase', 'chk_finance_purchase', '702', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('703', '7', '应收款', 'PMS.Frm.Finance.FrmReportReceive', 'chk_finance_receive', '703', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('704', '7', '应付款', 'PMS.Frm.Finance.FrmReportPaid', 'chk_finance_paid', '704', '0', null, null, null, null);

-- ----------------------------
-- Table structure for m_role
-- ----------------------------
DROP TABLE IF EXISTS `m_role`;
CREATE TABLE `m_role` (
  `roleId` int(11) NOT NULL AUTO_INCREMENT,
  `roleName` varchar(50) DEFAULT NULL,
  `isFinance` int(11) DEFAULT NULL COMMENT '是否处理金额（0：否；1：是）',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`roleId`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of m_role
-- ----------------------------
INSERT INTO `m_role` VALUES ('1', '系统管理', '1', '0', null, '2016-11-29 21:13:06', 'admin', '2016-12-03 15:04:12');
INSERT INTO `m_role` VALUES ('2', '商品管理', '0', '0', null, '2016-11-29 21:13:06', 'admin', '2016-12-03 15:04:41');
INSERT INTO `m_role` VALUES ('3', '销售管理', '0', '0', null, '2016-11-29 21:13:06', null, null);
INSERT INTO `m_role` VALUES ('4', '仓库管理', '0', '0', null, '2016-11-29 21:13:06', null, null);
INSERT INTO `m_role` VALUES ('5', '生产管理', '0', '0', null, '2016-11-29 21:13:06', null, null);
INSERT INTO `m_role` VALUES ('6', '采购管理', '0', '0', null, '2016-11-29 21:13:06', null, null);
INSERT INTO `m_role` VALUES ('7', '财务管理', '1', '0', null, '2016-11-29 21:13:06', null, null);
INSERT INTO `m_role` VALUES ('8', '测试角色1', '0', '1', 'admin', '2016-11-29 21:34:21', 'admin', '2016-11-29 21:40:46');

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
INSERT INTO `m_user` VALUES ('2', 'test1', 'admin', '2', '男', '', '', '', '2016-11-17', '0', 'admin', '2016-11-17 15:57:48', 'admin', '2016-11-19 12:19:05');

-- ----------------------------
-- Table structure for p_materials
-- ----------------------------
DROP TABLE IF EXISTS `p_materials`;
CREATE TABLE `p_materials` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL COMMENT '商品名称',
  `subName` varchar(255) DEFAULT NULL COMMENT '商品简称',
  `packingType` int(10) DEFAULT NULL COMMENT '包装方式（Code=001）',
  `packingRemark` varchar(100) DEFAULT NULL COMMENT '包装说明',
  `weight` decimal(10,0) DEFAULT NULL COMMENT '单位重量',
  `weightUnit` int(11) DEFAULT NULL COMMENT '重量单位（Code=003）',
  `morphology` int(10) DEFAULT NULL COMMENT '产品形态（Code=002）',
  `shelfLife` int(11) DEFAULT NULL COMMENT '保质期（天）',
  `expiredDays` int(11) DEFAULT NULL COMMENT '过期提醒天数',
  `minStockNum` int(11) DEFAULT NULL COMMENT '最少库存提醒数',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of p_materials
-- ----------------------------
INSERT INTO `p_materials` VALUES ('1', '原料1', '原料略称1', '1', '说明1', '50', '1', '1', '100', '10', '20', '0', 'admin', '2016-12-04 13:04:41', 'admin', '2016-12-04 13:26:49');

-- ----------------------------
-- Table structure for p_product
-- ----------------------------
DROP TABLE IF EXISTS `p_product`;
CREATE TABLE `p_product` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL COMMENT '商品名称',
  `subName` varchar(255) DEFAULT NULL COMMENT '商品简称',
  `packingType` int(10) DEFAULT NULL COMMENT '包装方式（Code=001）',
  `packingRemark` varchar(100) DEFAULT NULL COMMENT '包装说明',
  `weight` decimal(10,0) DEFAULT NULL COMMENT '单位重量',
  `weightUnit` int(10) DEFAULT NULL COMMENT '重量单位（Code=003）',
  `morphology` int(100) DEFAULT NULL COMMENT '产品形态（Code=002）',
  `shelfLife` int(11) DEFAULT NULL COMMENT '保质期（天）',
  `expiredDays` int(11) DEFAULT NULL COMMENT '过期提醒天数',
  `minStockNum` int(11) DEFAULT NULL COMMENT '最少库存提醒数',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of p_product
-- ----------------------------

-- ----------------------------
-- Table structure for r_materials_price
-- ----------------------------
DROP TABLE IF EXISTS `r_materials_price`;
CREATE TABLE `r_materials_price` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `materialsId` int(11) DEFAULT NULL COMMENT '原料ID',
  `price` decimal(10,0) DEFAULT NULL COMMENT '价格',
  `priceUnit` int(10) DEFAULT NULL COMMENT '单位（code=003）',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_materials_price
-- ----------------------------
INSERT INTO `r_materials_price` VALUES ('1', '1', '500', '1', '0', null, null, 'admin', '2016-12-04 13:26:49');

-- ----------------------------
-- Table structure for r_materials_search
-- ----------------------------
DROP TABLE IF EXISTS `r_materials_search`;
CREATE TABLE `r_materials_search` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `materialsId` int(11) NOT NULL,
  `materialsName` varchar(255) DEFAULT NULL,
  `searchKey` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_materials_search
-- ----------------------------

-- ----------------------------
-- Table structure for r_product_materrials
-- ----------------------------
DROP TABLE IF EXISTS `r_product_materrials`;
CREATE TABLE `r_product_materrials` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `productId` int(11) DEFAULT NULL COMMENT '产品ID',
  `materialsId` int(11) DEFAULT NULL COMMENT '原料ID',
  `materialsNum` decimal(10,0) DEFAULT NULL COMMENT '原料数量',
  `materialsUnit` varchar(10) DEFAULT NULL COMMENT '重量单位',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_product_materrials
-- ----------------------------

-- ----------------------------
-- Table structure for r_product_price
-- ----------------------------
DROP TABLE IF EXISTS `r_product_price`;
CREATE TABLE `r_product_price` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `productId` int(11) DEFAULT NULL COMMENT '产品ID',
  `minPrice` decimal(10,0) DEFAULT NULL COMMENT '最低售价',
  `advisePrice` decimal(10,0) DEFAULT NULL COMMENT '建议售价',
  `priceUnit` int(10) DEFAULT NULL COMMENT '单位（code=003）',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_product_price
-- ----------------------------

-- ----------------------------
-- Table structure for r_product_search
-- ----------------------------
DROP TABLE IF EXISTS `r_product_search`;
CREATE TABLE `r_product_search` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `productid` int(11) NOT NULL,
  `prouctName` varchar(255) DEFAULT NULL,
  `searchKey` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_product_search
-- ----------------------------

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
) ENGINE=InnoDB AUTO_INCREMENT=110 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_role_menu
-- ----------------------------
INSERT INTO `r_role_menu` VALUES ('1', '1', '7', '1', '1', '2016-11-19 12:02:44', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('2', '1', '6', '1', '1', '2016-11-19 12:03:00', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('3', '1', '5', '1', '1', '2016-11-19 12:03:00', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('4', '1', '4', '1', '1', '2016-11-19 12:03:00', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('5', '1', '3', '1', '1', '2016-11-19 12:03:00', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('6', '1', '2', '1', '1', '2016-11-19 12:03:00', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('7', '1', '1', '1', '1', '2016-11-19 12:03:00', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('8', '1', '704', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('9', '1', '703', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('10', '1', '702', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('11', '1', '701', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('12', '1', '7', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('13', '1', '604', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('14', '1', '603', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('15', '1', '602', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('16', '1', '601', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('17', '1', '6', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('18', '1', '501', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('19', '1', '5', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('20', '1', '405', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('21', '1', '404', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('22', '1', '403', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('23', '1', '0', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('24', '1', '401', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('25', '1', '4', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('26', '1', '302', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('27', '1', '301', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('28', '1', '3', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('29', '1', '2', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('30', '1', '202', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('31', '1', '201', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('32', '1', '1', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('33', '1', '102', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('34', '1', '103', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('35', '1', '104', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('36', '1', '101', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-03 15:04:17');
INSERT INTO `r_role_menu` VALUES ('37', '2', '2', '1', '1', '2016-11-19 12:18:35', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('38', '2', '202', '1', '1', '2016-11-19 12:18:35', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('39', '2', '201', '1', '1', '2016-11-19 12:18:35', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('40', '2', '302', '1', '1', '2016-11-19 12:22:49', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('41', '2', '301', '1', '1', '2016-11-19 12:22:49', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('42', '2', '3', '1', '1', '2016-11-19 12:22:49', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('43', '2', '2', '1', '1', '2016-11-19 12:22:49', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('44', '2', '202', '1', '1', '2016-11-19 12:22:49', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('45', '2', '201', '1', '1', '2016-11-19 12:22:49', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('46', '2', '2', '1', '1', '2016-11-19 12:29:36', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('47', '2', '202', '1', '1', '2016-11-19 12:29:36', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('48', '2', '201', '1', '1', '2016-11-19 12:29:36', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('49', '2', '2', '1', 'admin', '2016-11-21 14:40:13', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('50', '2', '0', '1', 'admin', '2016-11-21 14:40:13', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('51', '2', '202', '1', 'admin', '2016-11-21 14:40:13', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('52', '2', '201', '1', 'admin', '2016-11-21 14:40:13', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('53', '8', '0', '1', 'admin', '2016-11-29 21:34:21', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('54', '8', '1', '1', 'admin', '2016-11-29 21:34:21', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('55', '8', '105', '1', 'admin', '2016-11-29 21:34:21', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('56', '8', '102', '1', 'admin', '2016-11-29 21:34:21', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('57', '8', '103', '1', 'admin', '2016-11-29 21:34:21', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('58', '8', '104', '1', 'admin', '2016-11-29 21:34:21', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('59', '8', '101', '1', 'admin', '2016-11-29 21:34:21', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('60', '8', '302', '1', 'admin', '2016-11-29 21:39:43', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('61', '8', '301', '1', 'admin', '2016-11-29 21:39:43', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('62', '8', '3', '1', 'admin', '2016-11-29 21:39:43', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('63', '8', '2', '1', 'admin', '2016-11-29 21:39:43', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('64', '8', '0', '1', 'admin', '2016-11-29 21:39:43', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('65', '8', '202', '1', 'admin', '2016-11-29 21:39:43', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('66', '8', '201', '1', 'admin', '2016-11-29 21:39:43', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('67', '8', '1', '1', 'admin', '2016-11-29 21:39:43', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('68', '8', '105', '1', 'admin', '2016-11-29 21:39:43', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('69', '8', '102', '1', 'admin', '2016-11-29 21:39:43', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('70', '8', '103', '1', 'admin', '2016-11-29 21:39:43', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('71', '8', '104', '1', 'admin', '2016-11-29 21:39:43', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('72', '8', '101', '1', 'admin', '2016-11-29 21:39:43', 'admin', '2016-11-29 21:40:46');
INSERT INTO `r_role_menu` VALUES ('73', '1', '0', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('74', '1', '704', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('75', '1', '703', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('76', '1', '702', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('77', '1', '701', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('78', '1', '7', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('79', '1', '604', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('80', '1', '603', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('81', '1', '601', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('82', '1', '6', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('83', '1', '501', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('84', '1', '5', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('85', '1', '405', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('86', '1', '404', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('87', '1', '403', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('88', '1', '0', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('89', '1', '401', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('90', '1', '4', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('91', '1', '302', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('92', '1', '301', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('93', '1', '3', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('94', '1', '2', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('95', '1', '0', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('96', '1', '202', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('97', '1', '201', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('98', '1', '1', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('99', '1', '102', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('100', '1', '103', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('101', '1', '104', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('102', '1', '101', '0', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-03 15:04:12');
INSERT INTO `r_role_menu` VALUES ('103', '2', '302', '0', 'admin', '2016-12-03 15:04:41', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('104', '2', '301', '0', 'admin', '2016-12-03 15:04:41', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('105', '2', '3', '0', 'admin', '2016-12-03 15:04:41', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('106', '2', '2', '0', 'admin', '2016-12-03 15:04:41', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('107', '2', '0', '0', 'admin', '2016-12-03 15:04:41', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('108', '2', '202', '0', 'admin', '2016-12-03 15:04:41', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('109', '2', '201', '0', 'admin', '2016-12-03 15:04:41', 'admin', '2016-12-03 15:04:41');
