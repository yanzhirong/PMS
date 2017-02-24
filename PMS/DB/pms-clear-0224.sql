/*
Navicat MySQL Data Transfer

Source Server         : Test
Source Server Version : 50716
Source Host           : localhost:3306
Source Database       : pms

Target Server Type    : MYSQL
Target Server Version : 50716
File Encoding         : 65001

Date: 2017-02-24 18:04:02
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for h_inventory_materials_log
-- ----------------------------
DROP TABLE IF EXISTS `h_inventory_materials_log`;
CREATE TABLE `h_inventory_materials_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `inputCode` varchar(100) DEFAULT NULL COMMENT '入库单号',
  `factoryId` int(11) DEFAULT NULL COMMENT '仓库ID',
  `materialsId` int(11) DEFAULT NULL COMMENT '物料ID',
  `unit` int(11) DEFAULT NULL COMMENT '单位',
  `stockNumOld` decimal(10,2) DEFAULT NULL COMMENT '原库存数量',
  `stockNumNew` decimal(10,2) DEFAULT NULL COMMENT '新库存数量',
  `produceDateOld` datetime DEFAULT NULL COMMENT '原生产日期',
  `produceDateNew` datetime DEFAULT NULL COMMENT '新生产日期',
  `expiresDateOld` datetime DEFAULT NULL COMMENT '原过期日',
  `expiresDateNew` datetime DEFAULT NULL COMMENT '新过期日',
  `remark` varchar(255) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of h_inventory_materials_log
-- ----------------------------

-- ----------------------------
-- Table structure for h_inventory_product_log
-- ----------------------------
DROP TABLE IF EXISTS `h_inventory_product_log`;
CREATE TABLE `h_inventory_product_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `inputCode` varchar(100) DEFAULT NULL COMMENT '入库单号',
  `factoryId` int(11) DEFAULT NULL COMMENT '仓库ID',
  `productId` int(11) DEFAULT NULL COMMENT '商品ID',
  `stockNumOld` int(11) DEFAULT NULL COMMENT '原库存数量',
  `stockNumNew` int(11) DEFAULT NULL COMMENT '新库存数量',
  `produceDateOld` datetime DEFAULT NULL COMMENT '原生产日期',
  `produceDateNew` datetime DEFAULT NULL COMMENT '新生产日期',
  `expiresDateOld` datetime DEFAULT NULL COMMENT '原过期日',
  `expiresDateNew` datetime DEFAULT NULL COMMENT '新过期日',
  `remark` varchar(255) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of h_inventory_product_log
-- ----------------------------

-- ----------------------------
-- Table structure for h_materials_output_log
-- ----------------------------
DROP TABLE IF EXISTS `h_materials_output_log`;
CREATE TABLE `h_materials_output_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `outputCode` varchar(100) DEFAULT NULL COMMENT '出库单号',
  `inputCode` varchar(100) DEFAULT NULL COMMENT '入库单号',
  `factoryId` int(11) DEFAULT NULL COMMENT '仓库ID',
  `materialsId` int(11) DEFAULT NULL COMMENT '物料ID',
  `outputNum` decimal(10,0) DEFAULT NULL COMMENT '出库数量',
  `outputUnit` int(11) DEFAULT NULL COMMENT '单位',
  `applyMemberId` int(11) DEFAULT NULL COMMENT '申领人ID',
  `outputDate` datetime DEFAULT NULL COMMENT '出库时间',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of h_materials_output_log
-- ----------------------------

-- ----------------------------
-- Table structure for h_product_output_log
-- ----------------------------
DROP TABLE IF EXISTS `h_product_output_log`;
CREATE TABLE `h_product_output_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `outputCode` varchar(100) DEFAULT NULL COMMENT '出库单号',
  `inputCode` varchar(100) DEFAULT NULL COMMENT '入库单号',
  `factoryId` int(11) DEFAULT NULL COMMENT '仓库ID',
  `productId` int(11) DEFAULT NULL COMMENT '商品ID',
  `outputNum` int(11) DEFAULT NULL COMMENT '出库数量',
  `applyMemberId` int(11) DEFAULT NULL COMMENT '申领人ID',
  `outputDate` datetime DEFAULT NULL COMMENT '出库时间',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of h_product_output_log
-- ----------------------------

-- ----------------------------
-- Table structure for h_transfer_log
-- ----------------------------
DROP TABLE IF EXISTS `h_transfer_log`;
CREATE TABLE `h_transfer_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `transferCode` varchar(100) DEFAULT NULL COMMENT '调拨单号',
  `type` int(11) DEFAULT NULL COMMENT '类型（0：产品调拨；1：物料调拨）',
  `productId` int(11) DEFAULT NULL COMMENT '产品ID',
  `materialsId` int(11) DEFAULT NULL COMMENT '物料ID',
  `num` decimal(10,2) DEFAULT NULL COMMENT '数量',
  `unit` int(11) DEFAULT NULL COMMENT '单位',
  `fromFactoryId` int(11) DEFAULT NULL COMMENT '来源工厂',
  `toFactoryId` int(11) DEFAULT NULL COMMENT '目标工厂',
  `applyMemberId` int(11) DEFAULT NULL COMMENT '申请人ID',
  `applyDate` datetime DEFAULT NULL COMMENT '申请日',
  `transferMemberId` int(11) DEFAULT NULL COMMENT '调拨人ID',
  `transferDate` datetime DEFAULT NULL COMMENT '调拨日',
  `remark` varchar(255) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of h_transfer_log
-- ----------------------------

-- ----------------------------
-- Table structure for m_area
-- ----------------------------
DROP TABLE IF EXISTS `m_area`;
CREATE TABLE `m_area` (
  `areaId` int(11) NOT NULL,
  `areaName` varchar(200) DEFAULT NULL,
  `zipCode` varchar(100) DEFAULT NULL,
  `areaLevel` int(11) DEFAULT NULL,
  `parentId` int(11) DEFAULT NULL,
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`areaId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of m_area
-- ----------------------------
INSERT INTO `m_area` VALUES ('110000', '北京', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110100', '北京市', '', '2', '110000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110101', '东城区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110102', '西城区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110103', '崇文区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110104', '宣武区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110105', '朝阳区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110106', '丰台区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110107', '石景山区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110108', '海淀区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110109', '门头沟区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110111', '房山区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110112', '通州区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110113', '顺义区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110114', '昌平区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110115', '大兴区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110116', '怀柔区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110117', '平谷区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110228', '密云县', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110229', '延庆县', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110230', '其它区', '', '3', '110100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120000', '天津', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120100', '天津市', '', '2', '120000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120101', '和平区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120102', '河东区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120103', '河西区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120104', '南开区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120105', '河北区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120106', '红桥区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120107', '塘沽区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120108', '汉沽区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120109', '大港区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120110', '东丽区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120111', '西青区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120112', '津南区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120113', '北辰区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120114', '武清区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120115', '宝坻区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120116', '滨海新区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120221', '宁河县', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120223', '静海县', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120225', '蓟县', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120226', '其它区', '', '3', '120100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130000', '河北省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130100', '石家庄市', '', '2', '130000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130102', '长安区', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130103', '桥东区', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130104', '桥西区', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130105', '新华区', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130107', '井陉矿区', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130108', '裕华区', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130121', '井陉县', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130123', '正定县', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130124', '栾城区', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130125', '行唐县', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130126', '灵寿县', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130127', '高邑县', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130128', '深泽县', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130129', '赞皇县', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130130', '无极县', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130131', '平山县', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130132', '元氏县', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130133', '赵县', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130181', '辛集市', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130182', '藁城区', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130183', '晋州市', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130184', '新乐市', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130185', '鹿泉区', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130186', '其它区', '', '3', '130100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130200', '唐山市', '', '2', '130000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130202', '路南区', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130203', '路北区', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130204', '古冶区', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130205', '开平区', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130207', '丰南区', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130208', '丰润区', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130223', '滦县', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130224', '滦南县', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130225', '乐亭县', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130227', '迁西县', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130229', '玉田县', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130230', '曹妃甸区', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130281', '遵化市', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130283', '迁安市', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130284', '其它区', '', '3', '130200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130300', '秦皇岛市', '', '2', '130000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130302', '海港区', '', '3', '130300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130303', '山海关区', '', '3', '130300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130304', '北戴河区', '', '3', '130300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130321', '青龙满族自治县', '', '3', '130300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130322', '昌黎县', '', '3', '130300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130323', '抚宁县', '', '3', '130300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130324', '卢龙县', '', '3', '130300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130398', '其它区', '', '3', '130300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130399', '经济技术开发区', '', '3', '130300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130400', '邯郸市', '', '2', '130000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130402', '邯山区', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130403', '丛台区', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130404', '复兴区', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130406', '峰峰矿区', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130421', '邯郸县', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130423', '临漳县', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130424', '成安县', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130425', '大名县', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130426', '涉县', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130427', '磁县', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130428', '肥乡县', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130429', '永年县', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130430', '邱县', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130431', '鸡泽县', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130432', '广平县', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130433', '馆陶县', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130434', '魏县', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130435', '曲周县', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130481', '武安市', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130482', '其它区', '', '3', '130400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130500', '邢台市', '', '2', '130000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130502', '桥东区', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130503', '桥西区', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130521', '邢台县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130522', '临城县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130523', '内丘县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130524', '柏乡县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130525', '隆尧县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130526', '任县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130527', '南和县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130528', '宁晋县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130529', '巨鹿县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130530', '新河县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130531', '广宗县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130532', '平乡县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130533', '威县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130534', '清河县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130535', '临西县', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130581', '南宫市', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130582', '沙河市', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130583', '其它区', '', '3', '130500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130600', '保定市', '', '2', '130000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130602', '新市区', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130603', '北市区', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130604', '南市区', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130621', '满城县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130622', '清苑县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130623', '涞水县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130624', '阜平县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130625', '徐水县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130626', '定兴县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130627', '唐县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130628', '高阳县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130629', '容城县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130630', '涞源县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130631', '望都县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130632', '安新县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130633', '易县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130634', '曲阳县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130635', '蠡县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130636', '顺平县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130637', '博野县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130638', '雄县', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130681', '涿州市', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130682', '定州市', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130683', '安国市', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130684', '高碑店市', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130698', '高开区', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130699', '其它区', '', '3', '130600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130700', '张家口市', '', '2', '130000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130702', '桥东区', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130703', '桥西区', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130705', '宣化区', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130706', '下花园区', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130721', '宣化县', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130722', '张北县', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130723', '康保县', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130724', '沽源县', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130725', '尚义县', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130726', '蔚县', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130727', '阳原县', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130728', '怀安县', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130729', '万全县', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130730', '怀来县', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130731', '涿鹿县', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130732', '赤城县', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130733', '崇礼县', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130734', '其它区', '', '3', '130700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130800', '承德市', '', '2', '130000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130802', '双桥区', '', '3', '130800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130803', '双滦区', '', '3', '130800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130804', '鹰手营子矿区', '', '3', '130800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130821', '承德县', '', '3', '130800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130822', '兴隆县', '', '3', '130800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130823', '平泉县', '', '3', '130800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130824', '滦平县', '', '3', '130800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130825', '隆化县', '', '3', '130800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130826', '丰宁满族自治县', '', '3', '130800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130827', '宽城满族自治县', '', '3', '130800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130828', '围场满族蒙古族自治县', '', '3', '130800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130829', '其它区', '', '3', '130800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130900', '沧州市', '', '2', '130000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130902', '新华区', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130903', '运河区', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130921', '沧县', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130922', '青县', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130923', '东光县', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130924', '海兴县', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130925', '盐山县', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130926', '肃宁县', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130927', '南皮县', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130928', '吴桥县', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130929', '献县', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130930', '孟村回族自治县', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130981', '泊头市', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130982', '任丘市', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130983', '黄骅市', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130984', '河间市', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130985', '其它区', '', '3', '130900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131000', '廊坊市', '', '2', '130000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131002', '安次区', '', '3', '131000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131003', '广阳区', '', '3', '131000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131022', '固安县', '', '3', '131000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131023', '永清县', '', '3', '131000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131024', '香河县', '', '3', '131000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131025', '大城县', '', '3', '131000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131026', '文安县', '', '3', '131000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131028', '大厂回族自治县', '', '3', '131000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131051', '开发区', '', '3', '131000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131052', '燕郊经济技术开发区', '', '3', '131000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131081', '霸州市', '', '3', '131000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131082', '三河市', '', '3', '131000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131083', '其它区', '', '3', '131000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131100', '衡水市', '', '2', '130000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131102', '桃城区', '', '3', '131100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131121', '枣强县', '', '3', '131100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131122', '武邑县', '', '3', '131100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131123', '武强县', '', '3', '131100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131124', '饶阳县', '', '3', '131100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131125', '安平县', '', '3', '131100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131126', '故城县', '', '3', '131100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131127', '景县', '', '3', '131100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131128', '阜城县', '', '3', '131100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131181', '冀州市', '', '3', '131100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131182', '深州市', '', '3', '131100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131183', '其它区', '', '3', '131100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140000', '山西省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140100', '太原市', '', '2', '140000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140105', '小店区', '', '3', '140100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140106', '迎泽区', '', '3', '140100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140107', '杏花岭区', '', '3', '140100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140108', '尖草坪区', '', '3', '140100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140109', '万柏林区', '', '3', '140100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140110', '晋源区', '', '3', '140100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140121', '清徐县', '', '3', '140100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140122', '阳曲县', '', '3', '140100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140123', '娄烦县', '', '3', '140100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140181', '古交市', '', '3', '140100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140182', '其它区', '', '3', '140100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140200', '大同市', '', '2', '140000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140202', '城区', '', '3', '140200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140203', '矿区', '', '3', '140200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140211', '南郊区', '', '3', '140200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140212', '新荣区', '', '3', '140200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140221', '阳高县', '', '3', '140200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140222', '天镇县', '', '3', '140200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140223', '广灵县', '', '3', '140200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140224', '灵丘县', '', '3', '140200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140225', '浑源县', '', '3', '140200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140226', '左云县', '', '3', '140200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140227', '大同县', '', '3', '140200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140228', '其它区', '', '3', '140200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140300', '阳泉市', '', '2', '140000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140302', '城区', '', '3', '140300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140303', '矿区', '', '3', '140300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140311', '郊区', '', '3', '140300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140321', '平定县', '', '3', '140300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140322', '盂县', '', '3', '140300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140323', '其它区', '', '3', '140300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140400', '长治市', '', '2', '140000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140421', '长治县', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140423', '襄垣县', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140424', '屯留县', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140425', '平顺县', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140426', '黎城县', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140427', '壶关县', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140428', '长子县', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140429', '武乡县', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140430', '沁县', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140431', '沁源县', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140481', '潞城市', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140482', '城区', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140483', '郊区', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140484', '高新区', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140485', '其它区', '', '3', '140400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140500', '晋城市', '', '2', '140000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140502', '城区', '', '3', '140500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140521', '沁水县', '', '3', '140500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140522', '阳城县', '', '3', '140500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140524', '陵川县', '', '3', '140500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140525', '泽州县', '', '3', '140500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140581', '高平市', '', '3', '140500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140582', '其它区', '', '3', '140500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140600', '朔州市', '', '2', '140000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140602', '朔城区', '', '3', '140600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140603', '平鲁区', '', '3', '140600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140621', '山阴县', '', '3', '140600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140622', '应县', '', '3', '140600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140623', '右玉县', '', '3', '140600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140624', '怀仁县', '', '3', '140600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140625', '其它区', '', '3', '140600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140700', '晋中市', '', '2', '140000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140702', '榆次区', '', '3', '140700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140721', '榆社县', '', '3', '140700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140722', '左权县', '', '3', '140700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140723', '和顺县', '', '3', '140700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140724', '昔阳县', '', '3', '140700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140725', '寿阳县', '', '3', '140700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140726', '太谷县', '', '3', '140700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140727', '祁县', '', '3', '140700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140728', '平遥县', '', '3', '140700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140729', '灵石县', '', '3', '140700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140781', '介休市', '', '3', '140700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140782', '其它区', '', '3', '140700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140800', '运城市', '', '2', '140000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140802', '盐湖区', '', '3', '140800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140821', '临猗县', '', '3', '140800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140822', '万荣县', '', '3', '140800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140823', '闻喜县', '', '3', '140800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140824', '稷山县', '', '3', '140800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140825', '新绛县', '', '3', '140800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140826', '绛县', '', '3', '140800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140827', '垣曲县', '', '3', '140800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140828', '夏县', '', '3', '140800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140829', '平陆县', '', '3', '140800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140830', '芮城县', '', '3', '140800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140881', '永济市', '', '3', '140800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140882', '河津市', '', '3', '140800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140883', '其它区', '', '3', '140800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140900', '忻州市', '', '2', '140000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140902', '忻府区', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140921', '定襄县', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140922', '五台县', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140923', '代县', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140924', '繁峙县', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140925', '宁武县', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140926', '静乐县', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140927', '神池县', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140928', '五寨县', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140929', '岢岚县', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140930', '河曲县', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140931', '保德县', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140932', '偏关县', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140981', '原平市', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('140982', '其它区', '', '3', '140900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141000', '临汾市', '', '2', '140000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141002', '尧都区', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141021', '曲沃县', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141022', '翼城县', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141023', '襄汾县', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141024', '洪洞县', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141025', '古县', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141026', '安泽县', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141027', '浮山县', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141028', '吉县', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141029', '乡宁县', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141030', '大宁县', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141031', '隰县', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141032', '永和县', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141033', '蒲县', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141034', '汾西县', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141081', '侯马市', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141082', '霍州市', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141083', '其它区', '', '3', '141000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141100', '吕梁市', '', '2', '140000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141102', '离石区', '', '3', '141100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141121', '文水县', '', '3', '141100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141122', '交城县', '', '3', '141100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141123', '兴县', '', '3', '141100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141124', '临县', '', '3', '141100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141125', '柳林县', '', '3', '141100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141126', '石楼县', '', '3', '141100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141127', '岚县', '', '3', '141100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141128', '方山县', '', '3', '141100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141129', '中阳县', '', '3', '141100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141130', '交口县', '', '3', '141100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141181', '孝义市', '', '3', '141100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141182', '汾阳市', '', '3', '141100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('141183', '其它区', '', '3', '141100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150000', '内蒙古自治区', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150100', '呼和浩特市', '', '2', '150000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150102', '新城区', '', '3', '150100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150103', '回民区', '', '3', '150100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150104', '玉泉区', '', '3', '150100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150105', '赛罕区', '', '3', '150100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150121', '土默特左旗', '', '3', '150100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150122', '托克托县', '', '3', '150100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150123', '和林格尔县', '', '3', '150100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150124', '清水河县', '', '3', '150100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150125', '武川县', '', '3', '150100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150126', '其它区', '', '3', '150100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150200', '包头市', '', '2', '150000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150202', '东河区', '', '3', '150200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150203', '昆都仑区', '', '3', '150200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150204', '青山区', '', '3', '150200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150205', '石拐区', '', '3', '150200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150206', '白云鄂博矿区', '', '3', '150200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150207', '九原区', '', '3', '150200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150221', '土默特右旗', '', '3', '150200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150222', '固阳县', '', '3', '150200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150223', '达尔罕茂明安联合旗', '', '3', '150200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150224', '其它区', '', '3', '150200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150300', '乌海市', '', '2', '150000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150302', '海勃湾区', '', '3', '150300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150303', '海南区', '', '3', '150300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150304', '乌达区', '', '3', '150300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150305', '其它区', '', '3', '150300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150400', '赤峰市', '', '2', '150000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150402', '红山区', '', '3', '150400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150403', '元宝山区', '', '3', '150400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150404', '松山区', '', '3', '150400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150421', '阿鲁科尔沁旗', '', '3', '150400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150422', '巴林左旗', '', '3', '150400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150423', '巴林右旗', '', '3', '150400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150424', '林西县', '', '3', '150400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150425', '克什克腾旗', '', '3', '150400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150426', '翁牛特旗', '', '3', '150400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150428', '喀喇沁旗', '', '3', '150400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150429', '宁城县', '', '3', '150400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150430', '敖汉旗', '', '3', '150400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150431', '其它区', '', '3', '150400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150500', '通辽市', '', '2', '150000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150502', '科尔沁区', '', '3', '150500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150521', '科尔沁左翼中旗', '', '3', '150500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150522', '科尔沁左翼后旗', '', '3', '150500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150523', '开鲁县', '', '3', '150500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150524', '库伦旗', '', '3', '150500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150525', '奈曼旗', '', '3', '150500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150526', '扎鲁特旗', '', '3', '150500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150581', '霍林郭勒市', '', '3', '150500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150582', '其它区', '', '3', '150500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150600', '鄂尔多斯市', '', '2', '150000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150602', '东胜区', '', '3', '150600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150621', '达拉特旗', '', '3', '150600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150622', '准格尔旗', '', '3', '150600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150623', '鄂托克前旗', '', '3', '150600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150624', '鄂托克旗', '', '3', '150600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150625', '杭锦旗', '', '3', '150600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150626', '乌审旗', '', '3', '150600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150627', '伊金霍洛旗', '', '3', '150600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150628', '其它区', '', '3', '150600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150700', '呼伦贝尔市', '', '2', '150000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150702', '海拉尔区', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150703', '扎赉诺尔区', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150721', '阿荣旗', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150722', '莫力达瓦达斡尔族自治旗', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150723', '鄂伦春自治旗', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150724', '鄂温克族自治旗', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150725', '陈巴尔虎旗', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150726', '新巴尔虎左旗', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150727', '新巴尔虎右旗', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150781', '满洲里市', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150782', '牙克石市', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150783', '扎兰屯市', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150784', '额尔古纳市', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150785', '根河市', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150786', '其它区', '', '3', '150700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150800', '巴彦淖尔市', '', '2', '150000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150802', '临河区', '', '3', '150800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150821', '五原县', '', '3', '150800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150822', '磴口县', '', '3', '150800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150823', '乌拉特前旗', '', '3', '150800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150824', '乌拉特中旗', '', '3', '150800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150825', '乌拉特后旗', '', '3', '150800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150826', '杭锦后旗', '', '3', '150800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150827', '其它区', '', '3', '150800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150900', '乌兰察布市', '', '2', '150000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150902', '集宁区', '', '3', '150900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150921', '卓资县', '', '3', '150900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150922', '化德县', '', '3', '150900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150923', '商都县', '', '3', '150900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150924', '兴和县', '', '3', '150900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150925', '凉城县', '', '3', '150900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150926', '察哈尔右翼前旗', '', '3', '150900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150927', '察哈尔右翼中旗', '', '3', '150900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150928', '察哈尔右翼后旗', '', '3', '150900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150929', '四子王旗', '', '3', '150900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150981', '丰镇市', '', '3', '150900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('150982', '其它区', '', '3', '150900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152200', '兴安盟', '', '2', '150000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152201', '乌兰浩特市', '', '3', '152200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152202', '阿尔山市', '', '3', '152200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152221', '科尔沁右翼前旗', '', '3', '152200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152222', '科尔沁右翼中旗', '', '3', '152200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152223', '扎赉特旗', '', '3', '152200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152224', '突泉县', '', '3', '152200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152225', '其它区', '', '3', '152200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152500', '锡林郭勒盟', '', '2', '150000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152501', '二连浩特市', '', '3', '152500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152502', '锡林浩特市', '', '3', '152500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152522', '阿巴嘎旗', '', '3', '152500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152523', '苏尼特左旗', '', '3', '152500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152524', '苏尼特右旗', '', '3', '152500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152525', '东乌珠穆沁旗', '', '3', '152500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152526', '西乌珠穆沁旗', '', '3', '152500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152527', '太仆寺旗', '', '3', '152500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152528', '镶黄旗', '', '3', '152500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152529', '正镶白旗', '', '3', '152500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152530', '正蓝旗', '', '3', '152500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152531', '多伦县', '', '3', '152500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152532', '其它区', '', '3', '152500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152900', '阿拉善盟', '', '2', '150000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152921', '阿拉善左旗', '', '3', '152900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152922', '阿拉善右旗', '', '3', '152900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152923', '额济纳旗', '', '3', '152900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('152924', '其它区', '', '3', '152900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210000', '辽宁省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210100', '沈阳市', '', '2', '210000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210102', '和平区', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210103', '沈河区', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210104', '大东区', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210105', '皇姑区', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210106', '铁西区', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210111', '苏家屯区', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210112', '浑南区', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210113', '新城子区', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210114', '于洪区', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210122', '辽中县', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210123', '康平县', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210124', '法库县', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210181', '新民市', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210182', '浑南新区', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210183', '张士开发区', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210184', '沈北新区', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210185', '其它区', '', '3', '210100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210200', '大连市', '', '2', '210000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210202', '中山区', '', '3', '210200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210203', '西岗区', '', '3', '210200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210204', '沙河口区', '', '3', '210200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210211', '甘井子区', '', '3', '210200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210212', '旅顺口区', '', '3', '210200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210213', '金州区', '', '3', '210200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210224', '长海县', '', '3', '210200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210251', '开发区', '', '3', '210200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210281', '瓦房店市', '', '3', '210200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210282', '普兰店市', '', '3', '210200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210283', '庄河市', '', '3', '210200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210297', '岭前区', '', '3', '210200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210298', '其它区', '', '3', '210200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210300', '鞍山市', '', '2', '210000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210302', '铁东区', '', '3', '210300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210303', '铁西区', '', '3', '210300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210304', '立山区', '', '3', '210300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210311', '千山区', '', '3', '210300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210321', '台安县', '', '3', '210300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210323', '岫岩满族自治县', '', '3', '210300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210351', '高新区', '', '3', '210300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210381', '海城市', '', '3', '210300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210382', '其它区', '', '3', '210300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210400', '抚顺市', '', '2', '210000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210402', '新抚区', '', '3', '210400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210403', '东洲区', '', '3', '210400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210404', '望花区', '', '3', '210400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210411', '顺城区', '', '3', '210400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210421', '抚顺县', '', '3', '210400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210422', '新宾满族自治县', '', '3', '210400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210423', '清原满族自治县', '', '3', '210400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210424', '其它区', '', '3', '210400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210500', '本溪市', '', '2', '210000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210502', '平山区', '', '3', '210500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210503', '溪湖区', '', '3', '210500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210504', '明山区', '', '3', '210500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210505', '南芬区', '', '3', '210500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210521', '本溪满族自治县', '', '3', '210500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210522', '桓仁满族自治县', '', '3', '210500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210523', '其它区', '', '3', '210500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210600', '丹东市', '', '2', '210000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210602', '元宝区', '', '3', '210600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210603', '振兴区', '', '3', '210600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210604', '振安区', '', '3', '210600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210624', '宽甸满族自治县', '', '3', '210600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210681', '东港市', '', '3', '210600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210682', '凤城市', '', '3', '210600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210683', '其它区', '', '3', '210600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210700', '锦州市', '', '2', '210000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210702', '古塔区', '', '3', '210700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210703', '凌河区', '', '3', '210700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210711', '太和区', '', '3', '210700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210726', '黑山县', '', '3', '210700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210727', '义县', '', '3', '210700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210781', '凌海市', '', '3', '210700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210782', '北镇市', '', '3', '210700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210783', '其它区', '', '3', '210700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210800', '营口市', '', '2', '210000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210802', '站前区', '', '3', '210800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210803', '西市区', '', '3', '210800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210804', '鲅鱼圈区', '', '3', '210800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210811', '老边区', '', '3', '210800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210881', '盖州市', '', '3', '210800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210882', '大石桥市', '', '3', '210800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210883', '其它区', '', '3', '210800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210900', '阜新市', '', '2', '210000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210902', '海州区', '', '3', '210900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210903', '新邱区', '', '3', '210900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210904', '太平区', '', '3', '210900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210905', '清河门区', '', '3', '210900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210911', '细河区', '', '3', '210900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210921', '阜新蒙古族自治县', '', '3', '210900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210922', '彰武县', '', '3', '210900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('210923', '其它区', '', '3', '210900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211000', '辽阳市', '', '2', '210000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211002', '白塔区', '', '3', '211000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211003', '文圣区', '', '3', '211000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211004', '宏伟区', '', '3', '211000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211005', '弓长岭区', '', '3', '211000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211011', '太子河区', '', '3', '211000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211021', '辽阳县', '', '3', '211000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211081', '灯塔市', '', '3', '211000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211082', '其它区', '', '3', '211000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211100', '盘锦市', '', '2', '210000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211102', '双台子区', '', '3', '211100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211103', '兴隆台区', '', '3', '211100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211121', '大洼县', '', '3', '211100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211122', '盘山县', '', '3', '211100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211123', '其它区', '', '3', '211100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211200', '铁岭市', '', '2', '210000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211202', '银州区', '', '3', '211200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211204', '清河区', '', '3', '211200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211221', '铁岭县', '', '3', '211200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211223', '西丰县', '', '3', '211200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211224', '昌图县', '', '3', '211200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211281', '调兵山市', '', '3', '211200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211282', '开原市', '', '3', '211200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211283', '其它区', '', '3', '211200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211300', '朝阳市', '', '2', '210000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211302', '双塔区', '', '3', '211300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211303', '龙城区', '', '3', '211300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211321', '朝阳县', '', '3', '211300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211322', '建平县', '', '3', '211300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211324', '喀喇沁左翼蒙古族自治县', '', '3', '211300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211381', '北票市', '', '3', '211300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211382', '凌源市', '', '3', '211300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211383', '其它区', '', '3', '211300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211400', '葫芦岛市', '', '2', '210000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211402', '连山区', '', '3', '211400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211403', '龙港区', '', '3', '211400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211404', '南票区', '', '3', '211400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211421', '绥中县', '', '3', '211400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211422', '建昌县', '', '3', '211400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211481', '兴城市', '', '3', '211400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('211482', '其它区', '', '3', '211400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220000', '吉林省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220100', '长春市', '', '2', '220000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220102', '南关区', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220103', '宽城区', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220104', '朝阳区', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220105', '二道区', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220106', '绿园区', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220112', '双阳区', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220122', '农安县', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220181', '九台区', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220182', '榆树市', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220183', '德惠市', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220184', '高新技术产业开发区', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220185', '汽车产业开发区', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220186', '经济技术开发区', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220187', '净月旅游开发区', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220188', '其它区', '', '3', '220100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220200', '吉林市', '', '2', '220000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220202', '昌邑区', '', '3', '220200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220203', '龙潭区', '', '3', '220200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220204', '船营区', '', '3', '220200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220211', '丰满区', '', '3', '220200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220221', '永吉县', '', '3', '220200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220281', '蛟河市', '', '3', '220200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220282', '桦甸市', '', '3', '220200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220283', '舒兰市', '', '3', '220200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220284', '磐石市', '', '3', '220200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220285', '其它区', '', '3', '220200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220300', '四平市', '', '2', '220000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220302', '铁西区', '', '3', '220300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220303', '铁东区', '', '3', '220300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220322', '梨树县', '', '3', '220300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220323', '伊通满族自治县', '', '3', '220300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220381', '公主岭市', '', '3', '220300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220382', '双辽市', '', '3', '220300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220383', '其它区', '', '3', '220300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220400', '辽源市', '', '2', '220000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220402', '龙山区', '', '3', '220400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220403', '西安区', '', '3', '220400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220421', '东丰县', '', '3', '220400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220422', '东辽县', '', '3', '220400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220423', '其它区', '', '3', '220400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220500', '通化市', '', '2', '220000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220502', '东昌区', '', '3', '220500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220503', '二道江区', '', '3', '220500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220521', '通化县', '', '3', '220500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220523', '辉南县', '', '3', '220500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220524', '柳河县', '', '3', '220500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220581', '梅河口市', '', '3', '220500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220582', '集安市', '', '3', '220500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220583', '其它区', '', '3', '220500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220600', '白山市', '', '2', '220000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220602', '浑江区', '', '3', '220600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220621', '抚松县', '', '3', '220600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220622', '靖宇县', '', '3', '220600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220623', '长白朝鲜族自治县', '', '3', '220600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220625', '江源区', '', '3', '220600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220681', '临江市', '', '3', '220600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220682', '其它区', '', '3', '220600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220700', '松原市', '', '2', '220000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220702', '宁江区', '', '3', '220700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220721', '前郭尔罗斯蒙古族自治县', '', '3', '220700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220722', '长岭县', '', '3', '220700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220723', '乾安县', '', '3', '220700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220724', '扶余市', '', '3', '220700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220725', '其它区', '', '3', '220700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220800', '白城市', '', '2', '220000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220802', '洮北区', '', '3', '220800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220821', '镇赉县', '', '3', '220800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220822', '通榆县', '', '3', '220800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220881', '洮南市', '', '3', '220800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220882', '大安市', '', '3', '220800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('220883', '其它区', '', '3', '220800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('222400', '延边朝鲜族自治州', '', '2', '220000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('222401', '延吉市', '', '3', '222400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('222402', '图们市', '', '3', '222400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('222403', '敦化市', '', '3', '222400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('222404', '珲春市', '', '3', '222400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('222405', '龙井市', '', '3', '222400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('222406', '和龙市', '', '3', '222400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('222424', '汪清县', '', '3', '222400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('222426', '安图县', '', '3', '222400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('222427', '其它区', '', '3', '222400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230000', '黑龙江省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230100', '哈尔滨市', '', '2', '230000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230102', '道里区', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230103', '南岗区', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230104', '道外区', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230106', '香坊区', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230107', '动力区', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230108', '平房区', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230109', '松北区', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230111', '呼兰区', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230123', '依兰县', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230124', '方正县', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230125', '宾县', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230126', '巴彦县', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230127', '木兰县', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230128', '通河县', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230129', '延寿县', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230181', '阿城区', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230182', '双城区', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230183', '尚志市', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230184', '五常市', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230185', '阿城市', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230186', '其它区', '', '3', '230100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230200', '齐齐哈尔市', '', '2', '230000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230202', '龙沙区', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230203', '建华区', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230204', '铁锋区', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230205', '昂昂溪区', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230206', '富拉尔基区', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230207', '碾子山区', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230208', '梅里斯达斡尔族区', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230221', '龙江县', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230223', '依安县', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230224', '泰来县', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230225', '甘南县', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230227', '富裕县', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230229', '克山县', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230230', '克东县', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230231', '拜泉县', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230281', '讷河市', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230282', '其它区', '', '3', '230200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230300', '鸡西市', '', '2', '230000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230302', '鸡冠区', '', '3', '230300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230303', '恒山区', '', '3', '230300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230304', '滴道区', '', '3', '230300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230305', '梨树区', '', '3', '230300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230306', '城子河区', '', '3', '230300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230307', '麻山区', '', '3', '230300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230321', '鸡东县', '', '3', '230300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230381', '虎林市', '', '3', '230300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230382', '密山市', '', '3', '230300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230383', '其它区', '', '3', '230300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230400', '鹤岗市', '', '2', '230000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230402', '向阳区', '', '3', '230400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230403', '工农区', '', '3', '230400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230404', '南山区', '', '3', '230400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230405', '兴安区', '', '3', '230400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230406', '东山区', '', '3', '230400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230407', '兴山区', '', '3', '230400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230421', '萝北县', '', '3', '230400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230422', '绥滨县', '', '3', '230400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230423', '其它区', '', '3', '230400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230500', '双鸭山市', '', '2', '230000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230502', '尖山区', '', '3', '230500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230503', '岭东区', '', '3', '230500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230505', '四方台区', '', '3', '230500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230506', '宝山区', '', '3', '230500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230521', '集贤县', '', '3', '230500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230522', '友谊县', '', '3', '230500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230523', '宝清县', '', '3', '230500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230524', '饶河县', '', '3', '230500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230525', '其它区', '', '3', '230500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230600', '大庆市', '', '2', '230000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230602', '萨尔图区', '', '3', '230600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230603', '龙凤区', '', '3', '230600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230604', '让胡路区', '', '3', '230600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230605', '红岗区', '', '3', '230600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230606', '大同区', '', '3', '230600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230621', '肇州县', '', '3', '230600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230622', '肇源县', '', '3', '230600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230623', '林甸县', '', '3', '230600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230624', '杜尔伯特蒙古族自治县', '', '3', '230600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230625', '其它区', '', '3', '230600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230700', '伊春市', '', '2', '230000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230702', '伊春区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230703', '南岔区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230704', '友好区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230705', '西林区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230706', '翠峦区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230707', '新青区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230708', '美溪区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230709', '金山屯区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230710', '五营区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230711', '乌马河区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230712', '汤旺河区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230713', '带岭区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230714', '乌伊岭区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230715', '红星区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230716', '上甘岭区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230722', '嘉荫县', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230781', '铁力市', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230782', '其它区', '', '3', '230700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230800', '佳木斯市', '', '2', '230000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230802', '永红区', '', '3', '230800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230803', '向阳区', '', '3', '230800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230804', '前进区', '', '3', '230800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230805', '东风区', '', '3', '230800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230811', '郊区', '', '3', '230800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230822', '桦南县', '', '3', '230800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230826', '桦川县', '', '3', '230800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230828', '汤原县', '', '3', '230800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230833', '抚远县', '', '3', '230800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230881', '同江市', '', '3', '230800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230882', '富锦市', '', '3', '230800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230883', '其它区', '', '3', '230800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230900', '七台河市', '', '2', '230000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230902', '新兴区', '', '3', '230900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230903', '桃山区', '', '3', '230900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230904', '茄子河区', '', '3', '230900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230921', '勃利县', '', '3', '230900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('230922', '其它区', '', '3', '230900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231000', '牡丹江市', '', '2', '230000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231002', '东安区', '', '3', '231000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231003', '阳明区', '', '3', '231000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231004', '爱民区', '', '3', '231000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231005', '西安区', '', '3', '231000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231024', '东宁县', '', '3', '231000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231025', '林口县', '', '3', '231000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231081', '绥芬河市', '', '3', '231000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231083', '海林市', '', '3', '231000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231084', '宁安市', '', '3', '231000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231085', '穆棱市', '', '3', '231000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231086', '其它区', '', '3', '231000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231100', '黑河市', '', '2', '230000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231102', '爱辉区', '', '3', '231100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231121', '嫩江县', '', '3', '231100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231123', '逊克县', '', '3', '231100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231124', '孙吴县', '', '3', '231100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231181', '北安市', '', '3', '231100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231182', '五大连池市', '', '3', '231100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231183', '其它区', '', '3', '231100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231200', '绥化市', '', '2', '230000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231202', '北林区', '', '3', '231200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231221', '望奎县', '', '3', '231200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231222', '兰西县', '', '3', '231200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231223', '青冈县', '', '3', '231200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231224', '庆安县', '', '3', '231200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231225', '明水县', '', '3', '231200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231226', '绥棱县', '', '3', '231200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231281', '安达市', '', '3', '231200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231282', '肇东市', '', '3', '231200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231283', '海伦市', '', '3', '231200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('231284', '其它区', '', '3', '231200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('232700', '大兴安岭地区', '', '2', '230000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('232702', '松岭区', '', '3', '232700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('232703', '新林区', '', '3', '232700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('232704', '呼中区', '', '3', '232700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('232721', '呼玛县', '', '3', '232700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('232722', '塔河县', '', '3', '232700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('232723', '漠河县', '', '3', '232700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('232724', '加格达奇区', '', '3', '232700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('232725', '其它区', '', '3', '232700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310000', '上海', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310100', '上海市', '', '2', '310000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310101', '黄浦区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310103', '卢湾区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310104', '徐汇区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310105', '长宁区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310106', '静安区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310107', '普陀区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310108', '闸北区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310109', '虹口区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310110', '杨浦区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310112', '闵行区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310113', '宝山区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310114', '嘉定区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310115', '浦东新区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310116', '金山区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310117', '松江区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310118', '青浦区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310119', '南汇区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310120', '奉贤区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310152', '川沙区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310230', '崇明县', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('310231', '其它区', '', '3', '310100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320000', '江苏省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320100', '南京市', '', '2', '320000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320102', '玄武区', '', '3', '320100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320103', '白下区', '', '3', '320100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320104', '秦淮区', '', '3', '320100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320105', '建邺区', '', '3', '320100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320106', '鼓楼区', '', '3', '320100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320107', '下关区', '', '3', '320100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320111', '浦口区', '', '3', '320100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320113', '栖霞区', '', '3', '320100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320114', '雨花台区', '', '3', '320100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320115', '江宁区', '', '3', '320100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320116', '六合区', '', '3', '320100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320124', '溧水区', '', '3', '320100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320125', '高淳区', '', '3', '320100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320126', '其它区', '', '3', '320100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320200', '无锡市', '', '2', '320000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320202', '崇安区', '', '3', '320200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320203', '南长区', '', '3', '320200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320204', '北塘区', '', '3', '320200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320205', '锡山区', '', '3', '320200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320206', '惠山区', '', '3', '320200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320211', '滨湖区', '', '3', '320200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320281', '江阴市', '', '3', '320200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320282', '宜兴市', '', '3', '320200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320296', '新区', '', '3', '320200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320297', '其它区', '', '3', '320200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320300', '徐州市', '', '2', '320000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320302', '鼓楼区', '', '3', '320300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320303', '云龙区', '', '3', '320300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320304', '九里区', '', '3', '320300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320305', '贾汪区', '', '3', '320300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320311', '泉山区', '', '3', '320300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320321', '丰县', '', '3', '320300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320322', '沛县', '', '3', '320300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320323', '铜山区', '', '3', '320300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320324', '睢宁县', '', '3', '320300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320381', '新沂市', '', '3', '320300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320382', '邳州市', '', '3', '320300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320383', '其它区', '', '3', '320300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320400', '常州市', '', '2', '320000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320402', '天宁区', '', '3', '320400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320404', '钟楼区', '', '3', '320400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320405', '戚墅堰区', '', '3', '320400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320411', '新北区', '', '3', '320400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320412', '武进区', '', '3', '320400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320481', '溧阳市', '', '3', '320400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320482', '金坛市', '', '3', '320400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320483', '其它区', '', '3', '320400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320500', '苏州市', '', '2', '320000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320502', '沧浪区', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320503', '平江区', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320504', '金阊区', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320505', '虎丘区', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320506', '吴中区', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320507', '相城区', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320508', '姑苏区', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320581', '常熟市', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320582', '张家港市', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320583', '昆山市', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320584', '吴江区', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320585', '太仓市', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320594', '新区', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320595', '园区', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320596', '其它区', '', '3', '320500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320600', '南通市', '', '2', '320000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320602', '崇川区', '', '3', '320600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320611', '港闸区', '', '3', '320600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320612', '通州区', '', '3', '320600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320621', '海安县', '', '3', '320600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320623', '如东县', '', '3', '320600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320681', '启东市', '', '3', '320600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320682', '如皋市', '', '3', '320600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320683', '通州市', '', '3', '320600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320684', '海门市', '', '3', '320600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320693', '开发区', '', '3', '320600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320694', '其它区', '', '3', '320600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320700', '连云港市', '', '2', '320000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320703', '连云区', '', '3', '320700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320705', '新浦区', '', '3', '320700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320706', '海州区', '', '3', '320700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320721', '赣榆区', '', '3', '320700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320722', '东海县', '', '3', '320700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320723', '灌云县', '', '3', '320700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320724', '灌南县', '', '3', '320700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320725', '其它区', '', '3', '320700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320800', '淮安市', '', '2', '320000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320802', '清河区', '', '3', '320800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320803', '淮安区', '', '3', '320800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320804', '淮阴区', '', '3', '320800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320811', '清浦区', '', '3', '320800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320826', '涟水县', '', '3', '320800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320829', '洪泽县', '', '3', '320800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320830', '盱眙县', '', '3', '320800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320831', '金湖县', '', '3', '320800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320832', '其它区', '', '3', '320800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320900', '盐城市', '', '2', '320000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320902', '亭湖区', '', '3', '320900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320903', '盐都区', '', '3', '320900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320921', '响水县', '', '3', '320900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320922', '滨海县', '', '3', '320900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320923', '阜宁县', '', '3', '320900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320924', '射阳县', '', '3', '320900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320925', '建湖县', '', '3', '320900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320981', '东台市', '', '3', '320900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320982', '大丰市', '', '3', '320900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('320983', '其它区', '', '3', '320900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321000', '扬州市', '', '2', '320000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321002', '广陵区', '', '3', '321000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321003', '邗江区', '', '3', '321000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321011', '维扬区', '', '3', '321000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321023', '宝应县', '', '3', '321000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321081', '仪征市', '', '3', '321000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321084', '高邮市', '', '3', '321000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321088', '江都区', '', '3', '321000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321092', '经济开发区', '', '3', '321000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321093', '其它区', '', '3', '321000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321100', '镇江市', '', '2', '320000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321102', '京口区', '', '3', '321100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321111', '润州区', '', '3', '321100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321112', '丹徒区', '', '3', '321100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321181', '丹阳市', '', '3', '321100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321182', '扬中市', '', '3', '321100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321183', '句容市', '', '3', '321100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321184', '其它区', '', '3', '321100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321200', '泰州市', '', '2', '320000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321202', '海陵区', '', '3', '321200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321203', '高港区', '', '3', '321200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321281', '兴化市', '', '3', '321200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321282', '靖江市', '', '3', '321200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321283', '泰兴市', '', '3', '321200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321284', '姜堰区', '', '3', '321200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321285', '其它区', '', '3', '321200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321300', '宿迁市', '', '2', '320000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321302', '宿城区', '', '3', '321300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321311', '宿豫区', '', '3', '321300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321322', '沭阳县', '', '3', '321300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321323', '泗阳县', '', '3', '321300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321324', '泗洪县', '', '3', '321300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('321325', '其它区', '', '3', '321300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330000', '浙江省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330100', '杭州市', '', '2', '330000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330102', '上城区', '', '3', '330100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330103', '下城区', '', '3', '330100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330104', '江干区', '', '3', '330100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330105', '拱墅区', '', '3', '330100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330106', '西湖区', '', '3', '330100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330108', '滨江区', '', '3', '330100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330109', '萧山区', '', '3', '330100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330110', '余杭区', '', '3', '330100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330122', '桐庐县', '', '3', '330100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330127', '淳安县', '', '3', '330100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330182', '建德市', '', '3', '330100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330183', '富阳区', '', '3', '330100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330185', '临安市', '', '3', '330100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330186', '其它区', '', '3', '330100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330200', '宁波市', '', '2', '330000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330203', '海曙区', '', '3', '330200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330204', '江东区', '', '3', '330200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330205', '江北区', '', '3', '330200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330206', '北仑区', '', '3', '330200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330211', '镇海区', '', '3', '330200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330212', '鄞州区', '', '3', '330200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330225', '象山县', '', '3', '330200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330226', '宁海县', '', '3', '330200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330281', '余姚市', '', '3', '330200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330282', '慈溪市', '', '3', '330200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330283', '奉化市', '', '3', '330200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330284', '其它区', '', '3', '330200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330300', '温州市', '', '2', '330000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330302', '鹿城区', '', '3', '330300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330303', '龙湾区', '', '3', '330300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330304', '瓯海区', '', '3', '330300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330322', '洞头县', '', '3', '330300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330324', '永嘉县', '', '3', '330300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330326', '平阳县', '', '3', '330300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330327', '苍南县', '', '3', '330300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330328', '文成县', '', '3', '330300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330329', '泰顺县', '', '3', '330300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330381', '瑞安市', '', '3', '330300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330382', '乐清市', '', '3', '330300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330383', '其它区', '', '3', '330300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330400', '嘉兴市', '', '2', '330000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330402', '南湖区', '', '3', '330400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330411', '秀洲区', '', '3', '330400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330421', '嘉善县', '', '3', '330400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330424', '海盐县', '', '3', '330400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330481', '海宁市', '', '3', '330400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330482', '平湖市', '', '3', '330400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330483', '桐乡市', '', '3', '330400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330484', '其它区', '', '3', '330400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330500', '湖州市', '', '2', '330000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330502', '吴兴区', '', '3', '330500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330503', '南浔区', '', '3', '330500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330521', '德清县', '', '3', '330500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330522', '长兴县', '', '3', '330500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330523', '安吉县', '', '3', '330500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330524', '其它区', '', '3', '330500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330600', '绍兴市', '', '2', '330000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330602', '越城区', '', '3', '330600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330621', '柯桥区', '', '3', '330600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330624', '新昌县', '', '3', '330600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330681', '诸暨市', '', '3', '330600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330682', '上虞区', '', '3', '330600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330683', '嵊州市', '', '3', '330600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330684', '其它区', '', '3', '330600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330700', '金华市', '', '2', '330000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330702', '婺城区', '', '3', '330700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330703', '金东区', '', '3', '330700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330723', '武义县', '', '3', '330700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330726', '浦江县', '', '3', '330700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330727', '磐安县', '', '3', '330700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330781', '兰溪市', '', '3', '330700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330782', '义乌市', '', '3', '330700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330783', '东阳市', '', '3', '330700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330784', '永康市', '', '3', '330700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330785', '其它区', '', '3', '330700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330800', '衢州市', '', '2', '330000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330802', '柯城区', '', '3', '330800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330803', '衢江区', '', '3', '330800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330822', '常山县', '', '3', '330800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330824', '开化县', '', '3', '330800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330825', '龙游县', '', '3', '330800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330881', '江山市', '', '3', '330800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330882', '其它区', '', '3', '330800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330900', '舟山市', '', '2', '330000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330902', '定海区', '', '3', '330900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330903', '普陀区', '', '3', '330900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330921', '岱山县', '', '3', '330900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330922', '嵊泗县', '', '3', '330900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('330923', '其它区', '', '3', '330900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331000', '台州市', '', '2', '330000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331002', '椒江区', '', '3', '331000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331003', '黄岩区', '', '3', '331000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331004', '路桥区', '', '3', '331000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331021', '玉环县', '', '3', '331000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331022', '三门县', '', '3', '331000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331023', '天台县', '', '3', '331000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331024', '仙居县', '', '3', '331000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331081', '温岭市', '', '3', '331000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331082', '临海市', '', '3', '331000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331083', '其它区', '', '3', '331000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331100', '丽水市', '', '2', '330000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331102', '莲都区', '', '3', '331100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331121', '青田县', '', '3', '331100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331122', '缙云县', '', '3', '331100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331123', '遂昌县', '', '3', '331100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331124', '松阳县', '', '3', '331100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331125', '云和县', '', '3', '331100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331126', '庆元县', '', '3', '331100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331127', '景宁畲族自治县', '', '3', '331100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331181', '龙泉市', '', '3', '331100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('331182', '其它区', '', '3', '331100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340000', '安徽省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340100', '合肥市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340102', '瑶海区', '', '3', '340100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340103', '庐阳区', '', '3', '340100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340104', '蜀山区', '', '3', '340100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340111', '包河区', '', '3', '340100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340121', '长丰县', '', '3', '340100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340122', '肥东县', '', '3', '340100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340123', '肥西县', '', '3', '340100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340151', '高新区', '', '3', '340100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340191', '中区', '', '3', '340100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340192', '其它区', '', '3', '340100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340200', '芜湖市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340202', '镜湖区', '', '3', '340200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340203', '弋江区', '', '3', '340200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340207', '鸠江区', '', '3', '340200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340208', '三山区', '', '3', '340200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340221', '芜湖县', '', '3', '340200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340222', '繁昌县', '', '3', '340200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340223', '南陵县', '', '3', '340200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340224', '其它区', '', '3', '340200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340300', '蚌埠市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340302', '龙子湖区', '', '3', '340300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340303', '蚌山区', '', '3', '340300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340304', '禹会区', '', '3', '340300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340311', '淮上区', '', '3', '340300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340321', '怀远县', '', '3', '340300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340322', '五河县', '', '3', '340300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340323', '固镇县', '', '3', '340300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340324', '其它区', '', '3', '340300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340400', '淮南市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340402', '大通区', '', '3', '340400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340403', '田家庵区', '', '3', '340400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340404', '谢家集区', '', '3', '340400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340405', '八公山区', '', '3', '340400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340406', '潘集区', '', '3', '340400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340421', '凤台县', '', '3', '340400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340422', '其它区', '', '3', '340400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340500', '马鞍山市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340502', '金家庄区', '', '3', '340500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340503', '花山区', '', '3', '340500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340504', '雨山区', '', '3', '340500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340506', '博望区', '', '3', '340500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340521', '当涂县', '', '3', '340500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340522', '其它区', '', '3', '340500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340600', '淮北市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340602', '杜集区', '', '3', '340600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340603', '相山区', '', '3', '340600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340604', '烈山区', '', '3', '340600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340621', '濉溪县', '', '3', '340600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340622', '其它区', '', '3', '340600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340700', '铜陵市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340702', '铜官山区', '', '3', '340700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340703', '狮子山区', '', '3', '340700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340711', '郊区', '', '3', '340700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340721', '铜陵县', '', '3', '340700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340722', '其它区', '', '3', '340700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340800', '安庆市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340802', '迎江区', '', '3', '340800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340803', '大观区', '', '3', '340800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340811', '宜秀区', '', '3', '340800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340822', '怀宁县', '', '3', '340800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340823', '枞阳县', '', '3', '340800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340824', '潜山县', '', '3', '340800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340825', '太湖县', '', '3', '340800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340826', '宿松县', '', '3', '340800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340827', '望江县', '', '3', '340800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340828', '岳西县', '', '3', '340800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340881', '桐城市', '', '3', '340800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('340882', '其它区', '', '3', '340800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341000', '黄山市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341002', '屯溪区', '', '3', '341000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341003', '黄山区', '', '3', '341000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341004', '徽州区', '', '3', '341000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341021', '歙县', '', '3', '341000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341022', '休宁县', '', '3', '341000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341023', '黟县', '', '3', '341000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341024', '祁门县', '', '3', '341000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341025', '其它区', '', '3', '341000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341100', '滁州市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341102', '琅琊区', '', '3', '341100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341103', '南谯区', '', '3', '341100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341122', '来安县', '', '3', '341100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341124', '全椒县', '', '3', '341100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341125', '定远县', '', '3', '341100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341126', '凤阳县', '', '3', '341100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341181', '天长市', '', '3', '341100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341182', '明光市', '', '3', '341100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341183', '其它区', '', '3', '341100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341200', '阜阳市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341202', '颍州区', '', '3', '341200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341203', '颍东区', '', '3', '341200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341204', '颍泉区', '', '3', '341200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341221', '临泉县', '', '3', '341200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341222', '太和县', '', '3', '341200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341225', '阜南县', '', '3', '341200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341226', '颍上县', '', '3', '341200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341282', '界首市', '', '3', '341200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341283', '其它区', '', '3', '341200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341300', '宿州市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341302', '埇桥区', '', '3', '341300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341321', '砀山县', '', '3', '341300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341322', '萧县', '', '3', '341300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341323', '灵璧县', '', '3', '341300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341324', '泗县', '', '3', '341300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341325', '其它区', '', '3', '341300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341400', '巢湖市', '', '3', '340100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341402', '居巢区', '', '3', '340100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341421', '庐江县', '', '3', '340100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341422', '无为县', '', '3', '340200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341423', '含山县', '', '3', '340500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341424', '和县', '', '3', '340500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341500', '六安市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341502', '金安区', '', '3', '341500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341503', '裕安区', '', '3', '341500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341521', '寿县', '', '3', '341500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341522', '霍邱县', '', '3', '341500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341523', '舒城县', '', '3', '341500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341524', '金寨县', '', '3', '341500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341525', '霍山县', '', '3', '341500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341526', '其它区', '', '3', '341500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341600', '亳州市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341602', '谯城区', '', '3', '341600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341621', '涡阳县', '', '3', '341600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341622', '蒙城县', '', '3', '341600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341623', '利辛县', '', '3', '341600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341624', '其它区', '', '3', '341600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341700', '池州市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341702', '贵池区', '', '3', '341700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341721', '东至县', '', '3', '341700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341722', '石台县', '', '3', '341700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341723', '青阳县', '', '3', '341700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341724', '其它区', '', '3', '341700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341800', '宣城市', '', '2', '340000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341802', '宣州区', '', '3', '341800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341821', '郎溪县', '', '3', '341800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341822', '广德县', '', '3', '341800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341823', '泾县', '', '3', '341800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341824', '绩溪县', '', '3', '341800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341825', '旌德县', '', '3', '341800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341881', '宁国市', '', '3', '341800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('341882', '其它区', '', '3', '341800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350000', '福建省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350100', '福州市', '', '2', '350000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350102', '鼓楼区', '', '3', '350100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350103', '台江区', '', '3', '350100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350104', '仓山区', '', '3', '350100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350105', '马尾区', '', '3', '350100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350111', '晋安区', '', '3', '350100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350121', '闽侯县', '', '3', '350100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350122', '连江县', '', '3', '350100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350123', '罗源县', '', '3', '350100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350124', '闽清县', '', '3', '350100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350125', '永泰县', '', '3', '350100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350128', '平潭县', '', '3', '350100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350181', '福清市', '', '3', '350100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350182', '长乐市', '', '3', '350100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350183', '其它区', '', '3', '350100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350200', '厦门市', '', '2', '350000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350203', '思明区', '', '3', '350200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350205', '海沧区', '', '3', '350200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350206', '湖里区', '', '3', '350200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350211', '集美区', '', '3', '350200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350212', '同安区', '', '3', '350200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350213', '翔安区', '', '3', '350200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350214', '其它区', '', '3', '350200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350300', '莆田市', '', '2', '350000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350302', '城厢区', '', '3', '350300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350303', '涵江区', '', '3', '350300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350304', '荔城区', '', '3', '350300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350305', '秀屿区', '', '3', '350300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350322', '仙游县', '', '3', '350300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350323', '其它区', '', '3', '350300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350400', '三明市', '', '2', '350000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350402', '梅列区', '', '3', '350400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350403', '三元区', '', '3', '350400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350421', '明溪县', '', '3', '350400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350423', '清流县', '', '3', '350400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350424', '宁化县', '', '3', '350400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350425', '大田县', '', '3', '350400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350426', '尤溪县', '', '3', '350400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350427', '沙县', '', '3', '350400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350428', '将乐县', '', '3', '350400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350429', '泰宁县', '', '3', '350400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350430', '建宁县', '', '3', '350400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350481', '永安市', '', '3', '350400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350482', '其它区', '', '3', '350400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350500', '泉州市', '', '2', '350000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350502', '鲤城区', '', '3', '350500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350503', '丰泽区', '', '3', '350500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350504', '洛江区', '', '3', '350500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350505', '泉港区', '', '3', '350500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350521', '惠安县', '', '3', '350500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350524', '安溪县', '', '3', '350500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350525', '永春县', '', '3', '350500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350526', '德化县', '', '3', '350500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350527', '金门县', '', '3', '350500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350581', '石狮市', '', '3', '350500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350582', '晋江市', '', '3', '350500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350583', '南安市', '', '3', '350500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350584', '其它区', '', '3', '350500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350600', '漳州市', '', '2', '350000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350602', '芗城区', '', '3', '350600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350603', '龙文区', '', '3', '350600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350622', '云霄县', '', '3', '350600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350623', '漳浦县', '', '3', '350600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350624', '诏安县', '', '3', '350600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350625', '长泰县', '', '3', '350600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350626', '东山县', '', '3', '350600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350627', '南靖县', '', '3', '350600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350628', '平和县', '', '3', '350600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350629', '华安县', '', '3', '350600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350681', '龙海市', '', '3', '350600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350682', '其它区', '', '3', '350600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350700', '南平市', '', '2', '350000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350702', '延平区', '', '3', '350700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350721', '顺昌县', '', '3', '350700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350722', '浦城县', '', '3', '350700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350723', '光泽县', '', '3', '350700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350724', '松溪县', '', '3', '350700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350725', '政和县', '', '3', '350700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350781', '邵武市', '', '3', '350700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350782', '武夷山市', '', '3', '350700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350783', '建瓯市', '', '3', '350700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350784', '建阳区', '', '3', '350700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350785', '其它区', '', '3', '350700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350800', '龙岩市', '', '2', '350000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350802', '新罗区', '', '3', '350800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350821', '长汀县', '', '3', '350800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350822', '永定区', '', '3', '350800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350823', '上杭县', '', '3', '350800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350824', '武平县', '', '3', '350800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350825', '连城县', '', '3', '350800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350881', '漳平市', '', '3', '350800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350882', '其它区', '', '3', '350800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350900', '宁德市', '', '2', '350000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350902', '蕉城区', '', '3', '350900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350921', '霞浦县', '', '3', '350900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350922', '古田县', '', '3', '350900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350923', '屏南县', '', '3', '350900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350924', '寿宁县', '', '3', '350900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350925', '周宁县', '', '3', '350900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350926', '柘荣县', '', '3', '350900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350981', '福安市', '', '3', '350900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350982', '福鼎市', '', '3', '350900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('350983', '其它区', '', '3', '350900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360000', '江西省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360100', '南昌市', '', '2', '360000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360102', '东湖区', '', '3', '360100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360103', '西湖区', '', '3', '360100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360104', '青云谱区', '', '3', '360100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360105', '湾里区', '', '3', '360100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360111', '青山湖区', '', '3', '360100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360121', '南昌县', '', '3', '360100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360122', '新建县', '', '3', '360100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360123', '安义县', '', '3', '360100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360124', '进贤县', '', '3', '360100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360125', '红谷滩新区', '', '3', '360100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360126', '经济技术开发区', '', '3', '360100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360127', '昌北区', '', '3', '360100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360128', '其它区', '', '3', '360100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360200', '景德镇市', '', '2', '360000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360202', '昌江区', '', '3', '360200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360203', '珠山区', '', '3', '360200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360222', '浮梁县', '', '3', '360200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360281', '乐平市', '', '3', '360200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360282', '其它区', '', '3', '360200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360300', '萍乡市', '', '2', '360000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360302', '安源区', '', '3', '360300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360313', '湘东区', '', '3', '360300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360321', '莲花县', '', '3', '360300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360322', '上栗县', '', '3', '360300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360323', '芦溪县', '', '3', '360300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360324', '其它区', '', '3', '360300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360400', '九江市', '', '2', '360000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360402', '庐山区', '', '3', '360400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360403', '浔阳区', '', '3', '360400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360421', '九江县', '', '3', '360400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360423', '武宁县', '', '3', '360400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360424', '修水县', '', '3', '360400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360425', '永修县', '', '3', '360400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360426', '德安县', '', '3', '360400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360427', '星子县', '', '3', '360400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360428', '都昌县', '', '3', '360400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360429', '湖口县', '', '3', '360400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360430', '彭泽县', '', '3', '360400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360481', '瑞昌市', '', '3', '360400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360482', '其它区', '', '3', '360400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360483', '共青城市', '', '3', '360400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360500', '新余市', '', '2', '360000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360502', '渝水区', '', '3', '360500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360521', '分宜县', '', '3', '360500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360522', '其它区', '', '3', '360500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360600', '鹰潭市', '', '2', '360000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360602', '月湖区', '', '3', '360600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360622', '余江县', '', '3', '360600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360681', '贵溪市', '', '3', '360600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360682', '其它区', '', '3', '360600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360700', '赣州市', '', '2', '360000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360702', '章贡区', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360721', '赣县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360722', '信丰县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360723', '大余县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360724', '上犹县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360725', '崇义县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360726', '安远县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360727', '龙南县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360728', '定南县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360729', '全南县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360730', '宁都县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360731', '于都县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360732', '兴国县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360733', '会昌县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360734', '寻乌县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360735', '石城县', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360751', '黄金区', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360781', '瑞金市', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360782', '南康区', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360783', '其它区', '', '3', '360700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360800', '吉安市', '', '2', '360000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360802', '吉州区', '', '3', '360800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360803', '青原区', '', '3', '360800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360821', '吉安县', '', '3', '360800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360822', '吉水县', '', '3', '360800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360823', '峡江县', '', '3', '360800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360824', '新干县', '', '3', '360800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360825', '永丰县', '', '3', '360800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360826', '泰和县', '', '3', '360800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360827', '遂川县', '', '3', '360800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360828', '万安县', '', '3', '360800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360829', '安福县', '', '3', '360800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360830', '永新县', '', '3', '360800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360881', '井冈山市', '', '3', '360800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360882', '其它区', '', '3', '360800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360900', '宜春市', '', '2', '360000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360902', '袁州区', '', '3', '360900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360921', '奉新县', '', '3', '360900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360922', '万载县', '', '3', '360900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360923', '上高县', '', '3', '360900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360924', '宜丰县', '', '3', '360900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360925', '靖安县', '', '3', '360900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360926', '铜鼓县', '', '3', '360900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360981', '丰城市', '', '3', '360900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360982', '樟树市', '', '3', '360900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360983', '高安市', '', '3', '360900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('360984', '其它区', '', '3', '360900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361000', '抚州市', '', '2', '360000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361002', '临川区', '', '3', '361000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361021', '南城县', '', '3', '361000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361022', '黎川县', '', '3', '361000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361023', '南丰县', '', '3', '361000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361024', '崇仁县', '', '3', '361000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361025', '乐安县', '', '3', '361000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361026', '宜黄县', '', '3', '361000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361027', '金溪县', '', '3', '361000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361028', '资溪县', '', '3', '361000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361029', '东乡县', '', '3', '361000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361030', '广昌县', '', '3', '361000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361031', '其它区', '', '3', '361000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361100', '上饶市', '', '2', '360000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361102', '信州区', '', '3', '361100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361121', '上饶县', '', '3', '361100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361122', '广丰区', '', '3', '361100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361123', '玉山县', '', '3', '361100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361124', '铅山县', '', '3', '361100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361125', '横峰县', '', '3', '361100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361126', '弋阳县', '', '3', '361100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361127', '余干县', '', '3', '361100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361128', '鄱阳县', '', '3', '361100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361129', '万年县', '', '3', '361100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361130', '婺源县', '', '3', '361100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361181', '德兴市', '', '3', '361100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('361182', '其它区', '', '3', '361100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370000', '山东省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370100', '济南市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370102', '历下区', '', '3', '370100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370103', '市中区', '', '3', '370100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370104', '槐荫区', '', '3', '370100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370105', '天桥区', '', '3', '370100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370112', '历城区', '', '3', '370100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370113', '长清区', '', '3', '370100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370124', '平阴县', '', '3', '370100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370125', '济阳县', '', '3', '370100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370126', '商河县', '', '3', '370100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370181', '章丘市', '', '3', '370100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370182', '其它区', '', '3', '370100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370200', '青岛市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370202', '市南区', '', '3', '370200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370203', '市北区', '', '3', '370200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370205', '四方区', '', '3', '370200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370211', '黄岛区', '', '3', '370200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370212', '崂山区', '', '3', '370200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370213', '李沧区', '', '3', '370200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370214', '城阳区', '', '3', '370200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370251', '开发区', '', '3', '370200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370281', '胶州市', '', '3', '370200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370282', '即墨市', '', '3', '370200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370283', '平度市', '', '3', '370200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370284', '胶南市', '', '3', '370200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370285', '莱西市', '', '3', '370200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370286', '其它区', '', '3', '370200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370300', '淄博市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370302', '淄川区', '', '3', '370300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370303', '张店区', '', '3', '370300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370304', '博山区', '', '3', '370300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370305', '临淄区', '', '3', '370300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370306', '周村区', '', '3', '370300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370321', '桓台县', '', '3', '370300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370322', '高青县', '', '3', '370300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370323', '沂源县', '', '3', '370300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370324', '其它区', '', '3', '370300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370400', '枣庄市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370402', '市中区', '', '3', '370400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370403', '薛城区', '', '3', '370400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370404', '峄城区', '', '3', '370400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370405', '台儿庄区', '', '3', '370400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370406', '山亭区', '', '3', '370400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370481', '滕州市', '', '3', '370400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370482', '其它区', '', '3', '370400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370500', '东营市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370502', '东营区', '', '3', '370500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370503', '河口区', '', '3', '370500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370521', '垦利县', '', '3', '370500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370522', '利津县', '', '3', '370500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370523', '广饶县', '', '3', '370500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370589', '西城区', '', '3', '370500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370590', '东城区', '', '3', '370500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370591', '其它区', '', '3', '370500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370600', '烟台市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370602', '芝罘区', '', '3', '370600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370611', '福山区', '', '3', '370600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370612', '牟平区', '', '3', '370600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370613', '莱山区', '', '3', '370600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370634', '长岛县', '', '3', '370600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370681', '龙口市', '', '3', '370600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370682', '莱阳市', '', '3', '370600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370683', '莱州市', '', '3', '370600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370684', '蓬莱市', '', '3', '370600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370685', '招远市', '', '3', '370600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370686', '栖霞市', '', '3', '370600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370687', '海阳市', '', '3', '370600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370688', '其它区', '', '3', '370600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370700', '潍坊市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370702', '潍城区', '', '3', '370700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370703', '寒亭区', '', '3', '370700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370704', '坊子区', '', '3', '370700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370705', '奎文区', '', '3', '370700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370724', '临朐县', '', '3', '370700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370725', '昌乐县', '', '3', '370700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370751', '开发区', '', '3', '370700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370781', '青州市', '', '3', '370700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370782', '诸城市', '', '3', '370700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370783', '寿光市', '', '3', '370700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370784', '安丘市', '', '3', '370700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370785', '高密市', '', '3', '370700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370786', '昌邑市', '', '3', '370700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370787', '其它区', '', '3', '370700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370800', '济宁市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370802', '市中区', '', '3', '370800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370811', '任城区', '', '3', '370800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370826', '微山县', '', '3', '370800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370827', '鱼台县', '', '3', '370800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370828', '金乡县', '', '3', '370800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370829', '嘉祥县', '', '3', '370800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370830', '汶上县', '', '3', '370800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370831', '泗水县', '', '3', '370800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370832', '梁山县', '', '3', '370800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370881', '曲阜市', '', '3', '370800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370882', '兖州区', '', '3', '370800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370883', '邹城市', '', '3', '370800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370884', '其它区', '', '3', '370800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370900', '泰安市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370902', '泰山区', '', '3', '370900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370903', '岱岳区', '', '3', '370900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370921', '宁阳县', '', '3', '370900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370923', '东平县', '', '3', '370900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370982', '新泰市', '', '3', '370900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370983', '肥城市', '', '3', '370900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('370984', '其它区', '', '3', '370900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371000', '威海市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371002', '环翠区', '', '3', '371000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371081', '文登区', '', '3', '371000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371082', '荣成市', '', '3', '371000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371083', '乳山市', '', '3', '371000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371084', '其它区', '', '3', '371000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371100', '日照市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371102', '东港区', '', '3', '371100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371103', '岚山区', '', '3', '371100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371121', '五莲县', '', '3', '371100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371122', '莒县', '', '3', '371100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371123', '其它区', '', '3', '371100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371200', '莱芜市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371202', '莱城区', '', '3', '371200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371203', '钢城区', '', '3', '371200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371204', '其它区', '', '3', '371200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371300', '临沂市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371302', '兰山区', '', '3', '371300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371311', '罗庄区', '', '3', '371300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371312', '河东区', '', '3', '371300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371321', '沂南县', '', '3', '371300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371322', '郯城县', '', '3', '371300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371323', '沂水县', '', '3', '371300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371324', '兰陵县', '', '3', '371300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371325', '费县', '', '3', '371300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371326', '平邑县', '', '3', '371300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371327', '莒南县', '', '3', '371300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371328', '蒙阴县', '', '3', '371300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371329', '临沭县', '', '3', '371300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371330', '其它区', '', '3', '371300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371400', '德州市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371402', '德城区', '', '3', '371400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371421', '陵城区', '', '3', '371400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371422', '宁津县', '', '3', '371400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371423', '庆云县', '', '3', '371400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371424', '临邑县', '', '3', '371400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371425', '齐河县', '', '3', '371400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371426', '平原县', '', '3', '371400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371427', '夏津县', '', '3', '371400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371428', '武城县', '', '3', '371400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371451', '开发区', '', '3', '371400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371481', '乐陵市', '', '3', '371400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371482', '禹城市', '', '3', '371400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371483', '其它区', '', '3', '371400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371500', '聊城市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371502', '东昌府区', '', '3', '371500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371521', '阳谷县', '', '3', '371500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371522', '莘县', '', '3', '371500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371523', '茌平县', '', '3', '371500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371524', '东阿县', '', '3', '371500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371525', '冠县', '', '3', '371500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371526', '高唐县', '', '3', '371500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371581', '临清市', '', '3', '371500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371582', '其它区', '', '3', '371500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371600', '滨州市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371602', '滨城区', '', '3', '371600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371621', '惠民县', '', '3', '371600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371622', '阳信县', '', '3', '371600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371623', '无棣县', '', '3', '371600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371624', '沾化区', '', '3', '371600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371625', '博兴县', '', '3', '371600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371626', '邹平县', '', '3', '371600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371627', '其它区', '', '3', '371600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371700', '菏泽市', '', '2', '370000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371702', '牡丹区', '', '3', '371700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371721', '曹县', '', '3', '371700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371722', '单县', '', '3', '371700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371723', '成武县', '', '3', '371700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371724', '巨野县', '', '3', '371700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371725', '郓城县', '', '3', '371700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371726', '鄄城县', '', '3', '371700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371727', '定陶县', '', '3', '371700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371728', '东明县', '', '3', '371700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('371729', '其它区', '', '3', '371700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410000', '河南省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410100', '郑州市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410102', '中原区', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410103', '二七区', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410104', '管城回族区', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410105', '金水区', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410106', '上街区', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410108', '惠济区', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410122', '中牟县', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410181', '巩义市', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410182', '荥阳市', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410183', '新密市', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410184', '新郑市', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410185', '登封市', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410186', '郑东新区', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410187', '高新区', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410188', '其它区', '', '3', '410100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410200', '开封市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410202', '龙亭区', '', '3', '410200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410203', '顺河回族区', '', '3', '410200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410204', '鼓楼区', '', '3', '410200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410205', '禹王台区', '', '3', '410200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410211', '金明区', '', '3', '410200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410221', '杞县', '', '3', '410200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410222', '通许县', '', '3', '410200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410223', '尉氏县', '', '3', '410200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410224', '祥符区', '', '3', '410200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410225', '兰考县', '', '3', '410200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410226', '其它区', '', '3', '410200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410300', '洛阳市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410302', '老城区', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410303', '西工区', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410304', '瀍河回族区', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410305', '涧西区', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410306', '吉利区', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410307', '洛龙区', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410322', '孟津县', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410323', '新安县', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410324', '栾川县', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410325', '嵩县', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410326', '汝阳县', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410327', '宜阳县', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410328', '洛宁县', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410329', '伊川县', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410381', '偃师市', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410400', '平顶山市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410402', '新华区', '', '3', '410400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410403', '卫东区', '', '3', '410400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410404', '石龙区', '', '3', '410400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410411', '湛河区', '', '3', '410400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410421', '宝丰县', '', '3', '410400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410422', '叶县', '', '3', '410400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410423', '鲁山县', '', '3', '410400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410425', '郏县', '', '3', '410400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410481', '舞钢市', '', '3', '410400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410482', '汝州市', '', '3', '410400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410483', '其它区', '', '3', '410400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410500', '安阳市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410502', '文峰区', '', '3', '410500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410503', '北关区', '', '3', '410500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410505', '殷都区', '', '3', '410500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410506', '龙安区', '', '3', '410500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410522', '安阳县', '', '3', '410500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410523', '汤阴县', '', '3', '410500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410526', '滑县', '', '3', '410500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410527', '内黄县', '', '3', '410500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410581', '林州市', '', '3', '410500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410582', '其它区', '', '3', '410500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410600', '鹤壁市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410602', '鹤山区', '', '3', '410600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410603', '山城区', '', '3', '410600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410611', '淇滨区', '', '3', '410600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410621', '浚县', '', '3', '410600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410622', '淇县', '', '3', '410600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410623', '其它区', '', '3', '410600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410700', '新乡市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410702', '红旗区', '', '3', '410700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410703', '卫滨区', '', '3', '410700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410704', '凤泉区', '', '3', '410700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410711', '牧野区', '', '3', '410700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410721', '新乡县', '', '3', '410700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410724', '获嘉县', '', '3', '410700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410725', '原阳县', '', '3', '410700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410726', '延津县', '', '3', '410700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410727', '封丘县', '', '3', '410700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410728', '长垣县', '', '3', '410700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410781', '卫辉市', '', '3', '410700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410782', '辉县市', '', '3', '410700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410783', '其它区', '', '3', '410700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410800', '焦作市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410802', '解放区', '', '3', '410800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410803', '中站区', '', '3', '410800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410804', '马村区', '', '3', '410800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410811', '山阳区', '', '3', '410800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410821', '修武县', '', '3', '410800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410822', '博爱县', '', '3', '410800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410823', '武陟县', '', '3', '410800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410825', '温县', '', '3', '410800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881', '济源市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410882', '沁阳市', '', '3', '410800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410883', '孟州市', '', '3', '410800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410884', '其它区', '', '3', '410800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410900', '濮阳市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410902', '华龙区', '', '3', '410900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410922', '清丰县', '', '3', '410900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410923', '南乐县', '', '3', '410900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410926', '范县', '', '3', '410900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410927', '台前县', '', '3', '410900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410928', '濮阳县', '', '3', '410900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410929', '其它区', '', '3', '410900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411000', '许昌市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411002', '魏都区', '', '3', '411000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411023', '许昌县', '', '3', '411000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411024', '鄢陵县', '', '3', '411000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411025', '襄城县', '', '3', '411000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411081', '禹州市', '', '3', '411000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411082', '长葛市', '', '3', '411000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411083', '其它区', '', '3', '411000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411100', '漯河市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411102', '源汇区', '', '3', '411100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411103', '郾城区', '', '3', '411100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411104', '召陵区', '', '3', '411100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411121', '舞阳县', '', '3', '411100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411122', '临颍县', '', '3', '411100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411123', '其它区', '', '3', '411100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411200', '三门峡市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411202', '湖滨区', '', '3', '411200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411221', '渑池县', '', '3', '411200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411222', '陕州区', '', '3', '411200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411224', '卢氏县', '', '3', '411200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411281', '义马市', '', '3', '411200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411282', '灵宝市', '', '3', '411200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411283', '其它区', '', '3', '411200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411300', '南阳市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411302', '宛城区', '', '3', '411300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411303', '卧龙区', '', '3', '411300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411321', '南召县', '', '3', '411300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411322', '方城县', '', '3', '411300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411323', '西峡县', '', '3', '411300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411324', '镇平县', '', '3', '411300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411325', '内乡县', '', '3', '411300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411326', '淅川县', '', '3', '411300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411327', '社旗县', '', '3', '411300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411328', '唐河县', '', '3', '411300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411329', '新野县', '', '3', '411300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411330', '桐柏县', '', '3', '411300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411381', '邓州市', '', '3', '411300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411382', '其它区', '', '3', '411300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411400', '商丘市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411402', '梁园区', '', '3', '411400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411403', '睢阳区', '', '3', '411400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411421', '民权县', '', '3', '411400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411422', '睢县', '', '3', '411400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411423', '宁陵县', '', '3', '411400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411424', '柘城县', '', '3', '411400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411425', '虞城县', '', '3', '411400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411426', '夏邑县', '', '3', '411400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411481', '永城市', '', '3', '411400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411482', '其它区', '', '3', '411400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411500', '信阳市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411502', '浉河区', '', '3', '411500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411503', '平桥区', '', '3', '411500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411521', '罗山县', '', '3', '411500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411522', '光山县', '', '3', '411500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411523', '新县', '', '3', '411500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411524', '商城县', '', '3', '411500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411525', '固始县', '', '3', '411500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411526', '潢川县', '', '3', '411500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411527', '淮滨县', '', '3', '411500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411528', '息县', '', '3', '411500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411529', '其它区', '', '3', '411500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411600', '周口市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411602', '川汇区', '', '3', '411600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411621', '扶沟县', '', '3', '411600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411622', '西华县', '', '3', '411600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411623', '商水县', '', '3', '411600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411624', '沈丘县', '', '3', '411600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411625', '郸城县', '', '3', '411600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411626', '淮阳县', '', '3', '411600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411627', '太康县', '', '3', '411600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411628', '鹿邑县', '', '3', '411600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411681', '项城市', '', '3', '411600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411682', '其它区', '', '3', '411600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411700', '驻马店市', '', '2', '410000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411702', '驿城区', '', '3', '411700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411721', '西平县', '', '3', '411700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411722', '上蔡县', '', '3', '411700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411723', '平舆县', '', '3', '411700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411724', '正阳县', '', '3', '411700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411725', '确山县', '', '3', '411700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411726', '泌阳县', '', '3', '411700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411727', '汝南县', '', '3', '411700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411728', '遂平县', '', '3', '411700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411729', '新蔡县', '', '3', '411700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('411730', '其它区', '', '3', '411700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420000', '湖北省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420100', '武汉市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420102', '江岸区', '', '3', '420100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420103', '江汉区', '', '3', '420100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420104', '硚口区', '', '3', '420100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420105', '汉阳区', '', '3', '420100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420106', '武昌区', '', '3', '420100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420107', '青山区', '', '3', '420100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420111', '洪山区', '', '3', '420100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420112', '东西湖区', '', '3', '420100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420113', '汉南区', '', '3', '420100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420114', '蔡甸区', '', '3', '420100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420115', '江夏区', '', '3', '420100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420116', '黄陂区', '', '3', '420100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420117', '新洲区', '', '3', '420100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420118', '其它区', '', '3', '420100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420200', '黄石市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420202', '黄石港区', '', '3', '420200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420203', '西塞山区', '', '3', '420200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420204', '下陆区', '', '3', '420200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420205', '铁山区', '', '3', '420200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420222', '阳新县', '', '3', '420200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420281', '大冶市', '', '3', '420200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420282', '其它区', '', '3', '420200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420300', '十堰市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420302', '茅箭区', '', '3', '420300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420303', '张湾区', '', '3', '420300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420321', '郧阳区', '', '3', '420300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420322', '郧西县', '', '3', '420300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420323', '竹山县', '', '3', '420300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420324', '竹溪县', '', '3', '420300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420325', '房县', '', '3', '420300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420381', '丹江口市', '', '3', '420300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420382', '城区', '', '3', '420300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420383', '其它区', '', '3', '420300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420500', '宜昌市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420502', '西陵区', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420503', '伍家岗区', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420504', '点军区', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420505', '猇亭区', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420506', '夷陵区', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420525', '远安县', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420526', '兴山县', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420527', '秭归县', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420528', '长阳土家族自治县', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420529', '五峰土家族自治县', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420551', '葛洲坝区', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420552', '开发区', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420581', '宜都市', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420582', '当阳市', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420583', '枝江市', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420584', '其它区', '', '3', '420500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420600', '襄阳市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420602', '襄城区', '', '3', '420600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420606', '樊城区', '', '3', '420600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420607', '襄州区', '', '3', '420600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420624', '南漳县', '', '3', '420600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420625', '谷城县', '', '3', '420600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420626', '保康县', '', '3', '420600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420682', '老河口市', '', '3', '420600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420683', '枣阳市', '', '3', '420600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420684', '宜城市', '', '3', '420600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420685', '其它区', '', '3', '420600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420700', '鄂州市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420702', '梁子湖区', '', '3', '420700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420703', '华容区', '', '3', '420700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420704', '鄂城区', '', '3', '420700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420705', '其它区', '', '3', '420700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420800', '荆门市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420802', '东宝区', '', '3', '420800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420804', '掇刀区', '', '3', '420800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420821', '京山县', '', '3', '420800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420822', '沙洋县', '', '3', '420800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420881', '钟祥市', '', '3', '420800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420882', '其它区', '', '3', '420800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420900', '孝感市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420902', '孝南区', '', '3', '420900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420921', '孝昌县', '', '3', '420900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420922', '大悟县', '', '3', '420900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420923', '云梦县', '', '3', '420900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420981', '应城市', '', '3', '420900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420982', '安陆市', '', '3', '420900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420984', '汉川市', '', '3', '420900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('420985', '其它区', '', '3', '420900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421000', '荆州市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421002', '沙市区', '', '3', '421000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421003', '荆州区', '', '3', '421000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421022', '公安县', '', '3', '421000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421023', '监利县', '', '3', '421000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421024', '江陵县', '', '3', '421000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421081', '石首市', '', '3', '421000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421083', '洪湖市', '', '3', '421000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421087', '松滋市', '', '3', '421000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421088', '其它区', '', '3', '421000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421100', '黄冈市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421102', '黄州区', '', '3', '421100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421121', '团风县', '', '3', '421100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421122', '红安县', '', '3', '421100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421123', '罗田县', '', '3', '421100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421124', '英山县', '', '3', '421100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421125', '浠水县', '', '3', '421100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421126', '蕲春县', '', '3', '421100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421127', '黄梅县', '', '3', '421100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421181', '麻城市', '', '3', '421100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421182', '武穴市', '', '3', '421100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421183', '其它区', '', '3', '421100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421200', '咸宁市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421202', '咸安区', '', '3', '421200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421221', '嘉鱼县', '', '3', '421200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421222', '通城县', '', '3', '421200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421223', '崇阳县', '', '3', '421200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421224', '通山县', '', '3', '421200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421281', '赤壁市', '', '3', '421200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421282', '温泉城区', '', '3', '421200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421283', '其它区', '', '3', '421200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421300', '随州市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421302', '曾都区', '', '3', '421300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421321', '随县', '', '3', '421300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421381', '广水市', '', '3', '421300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('421382', '其它区', '', '3', '421300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('422800', '恩施土家族苗族自治州', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('422801', '恩施市', '', '3', '422800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('422802', '利川市', '', '3', '422800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('422822', '建始县', '', '3', '422800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('422823', '巴东县', '', '3', '422800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('422825', '宣恩县', '', '3', '422800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('422826', '咸丰县', '', '3', '422800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('422827', '来凤县', '', '3', '422800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('422828', '鹤峰县', '', '3', '422800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('422829', '其它区', '', '3', '422800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004', '仙桃市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005', '潜江市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006', '天门市', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429021', '神农架林区', '', '2', '420000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430000', '湖南省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430100', '长沙市', '', '2', '430000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430102', '芙蓉区', '', '3', '430100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430103', '天心区', '', '3', '430100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430104', '岳麓区', '', '3', '430100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430105', '开福区', '', '3', '430100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430111', '雨花区', '', '3', '430100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430121', '长沙县', '', '3', '430100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430122', '望城区', '', '3', '430100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430124', '宁乡县', '', '3', '430100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430181', '浏阳市', '', '3', '430100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430182', '其它区', '', '3', '430100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430200', '株洲市', '', '2', '430000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430202', '荷塘区', '', '3', '430200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430203', '芦淞区', '', '3', '430200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430204', '石峰区', '', '3', '430200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430211', '天元区', '', '3', '430200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430221', '株洲县', '', '3', '430200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430223', '攸县', '', '3', '430200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430224', '茶陵县', '', '3', '430200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430225', '炎陵县', '', '3', '430200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430281', '醴陵市', '', '3', '430200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430282', '其它区', '', '3', '430200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430300', '湘潭市', '', '2', '430000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430302', '雨湖区', '', '3', '430300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430304', '岳塘区', '', '3', '430300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430321', '湘潭县', '', '3', '430300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430381', '湘乡市', '', '3', '430300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430382', '韶山市', '', '3', '430300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430383', '其它区', '', '3', '430300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430400', '衡阳市', '', '2', '430000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430405', '珠晖区', '', '3', '430400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430406', '雁峰区', '', '3', '430400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430407', '石鼓区', '', '3', '430400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430408', '蒸湘区', '', '3', '430400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430412', '南岳区', '', '3', '430400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430421', '衡阳县', '', '3', '430400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430422', '衡南县', '', '3', '430400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430423', '衡山县', '', '3', '430400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430424', '衡东县', '', '3', '430400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430426', '祁东县', '', '3', '430400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430481', '耒阳市', '', '3', '430400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430482', '常宁市', '', '3', '430400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430483', '其它区', '', '3', '430400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430500', '邵阳市', '', '2', '430000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430502', '双清区', '', '3', '430500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430503', '大祥区', '', '3', '430500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430511', '北塔区', '', '3', '430500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430521', '邵东县', '', '3', '430500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430522', '新邵县', '', '3', '430500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430523', '邵阳县', '', '3', '430500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430524', '隆回县', '', '3', '430500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430525', '洞口县', '', '3', '430500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430527', '绥宁县', '', '3', '430500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430528', '新宁县', '', '3', '430500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430529', '城步苗族自治县', '', '3', '430500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430581', '武冈市', '', '3', '430500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430582', '其它区', '', '3', '430500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430600', '岳阳市', '', '2', '430000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430602', '岳阳楼区', '', '3', '430600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430603', '云溪区', '', '3', '430600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430611', '君山区', '', '3', '430600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430621', '岳阳县', '', '3', '430600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430623', '华容县', '', '3', '430600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430624', '湘阴县', '', '3', '430600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430626', '平江县', '', '3', '430600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430681', '汨罗市', '', '3', '430600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430682', '临湘市', '', '3', '430600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430683', '其它区', '', '3', '430600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430700', '常德市', '', '2', '430000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430702', '武陵区', '', '3', '430700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430703', '鼎城区', '', '3', '430700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430721', '安乡县', '', '3', '430700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430722', '汉寿县', '', '3', '430700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430723', '澧县', '', '3', '430700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430724', '临澧县', '', '3', '430700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430725', '桃源县', '', '3', '430700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430726', '石门县', '', '3', '430700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430781', '津市市', '', '3', '430700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430782', '其它区', '', '3', '430700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430800', '张家界市', '', '2', '430000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430802', '永定区', '', '3', '430800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430811', '武陵源区', '', '3', '430800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430821', '慈利县', '', '3', '430800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430822', '桑植县', '', '3', '430800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430823', '其它区', '', '3', '430800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430900', '益阳市', '', '2', '430000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430902', '资阳区', '', '3', '430900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430903', '赫山区', '', '3', '430900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430921', '南县', '', '3', '430900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430922', '桃江县', '', '3', '430900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430923', '安化县', '', '3', '430900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430981', '沅江市', '', '3', '430900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('430982', '其它区', '', '3', '430900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431000', '郴州市', '', '2', '430000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431002', '北湖区', '', '3', '431000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431003', '苏仙区', '', '3', '431000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431021', '桂阳县', '', '3', '431000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431022', '宜章县', '', '3', '431000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431023', '永兴县', '', '3', '431000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431024', '嘉禾县', '', '3', '431000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431025', '临武县', '', '3', '431000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431026', '汝城县', '', '3', '431000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431027', '桂东县', '', '3', '431000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431028', '安仁县', '', '3', '431000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431081', '资兴市', '', '3', '431000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431082', '其它区', '', '3', '431000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431100', '永州市', '', '2', '430000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431102', '零陵区', '', '3', '431100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431103', '冷水滩区', '', '3', '431100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431121', '祁阳县', '', '3', '431100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431122', '东安县', '', '3', '431100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431123', '双牌县', '', '3', '431100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431124', '道县', '', '3', '431100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431125', '江永县', '', '3', '431100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431126', '宁远县', '', '3', '431100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431127', '蓝山县', '', '3', '431100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431128', '新田县', '', '3', '431100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431129', '江华瑶族自治县', '', '3', '431100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431130', '其它区', '', '3', '431100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431200', '怀化市', '', '2', '430000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431202', '鹤城区', '', '3', '431200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431221', '中方县', '', '3', '431200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431222', '沅陵县', '', '3', '431200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431223', '辰溪县', '', '3', '431200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431224', '溆浦县', '', '3', '431200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431225', '会同县', '', '3', '431200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431226', '麻阳苗族自治县', '', '3', '431200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431227', '新晃侗族自治县', '', '3', '431200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431228', '芷江侗族自治县', '', '3', '431200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431229', '靖州苗族侗族自治县', '', '3', '431200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431230', '通道侗族自治县', '', '3', '431200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431281', '洪江市', '', '3', '431200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431282', '其它区', '', '3', '431200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431300', '娄底市', '', '2', '430000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431302', '娄星区', '', '3', '431300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431321', '双峰县', '', '3', '431300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431322', '新化县', '', '3', '431300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431381', '冷水江市', '', '3', '431300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431382', '涟源市', '', '3', '431300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('431383', '其它区', '', '3', '431300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('433100', '湘西土家族苗族自治州', '', '2', '430000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('433101', '吉首市', '', '3', '433100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('433122', '泸溪县', '', '3', '433100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('433123', '凤凰县', '', '3', '433100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('433124', '花垣县', '', '3', '433100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('433125', '保靖县', '', '3', '433100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('433126', '古丈县', '', '3', '433100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('433127', '永顺县', '', '3', '433100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('433130', '龙山县', '', '3', '433100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('433131', '其它区', '', '3', '433100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440000', '广东省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440100', '广州市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440103', '荔湾区', '', '3', '440100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440104', '越秀区', '', '3', '440100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440105', '海珠区', '', '3', '440100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440106', '天河区', '', '3', '440100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440111', '白云区', '', '3', '440100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440112', '黄埔区', '', '3', '440100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440113', '番禺区', '', '3', '440100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440114', '花都区', '', '3', '440100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440115', '南沙区', '', '3', '440100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440116', '萝岗区', '', '3', '440100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440183', '增城区', '', '3', '440100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440184', '从化区', '', '3', '440100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440188', '东山区', '', '3', '440100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440189', '其它区', '', '3', '440100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440200', '韶关市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440203', '武江区', '', '3', '440200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440204', '浈江区', '', '3', '440200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440205', '曲江区', '', '3', '440200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440222', '始兴县', '', '3', '440200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440224', '仁化县', '', '3', '440200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440229', '翁源县', '', '3', '440200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440232', '乳源瑶族自治县', '', '3', '440200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440233', '新丰县', '', '3', '440200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440281', '乐昌市', '', '3', '440200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440282', '南雄市', '', '3', '440200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440283', '其它区', '', '3', '440200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440300', '深圳市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440303', '罗湖区', '', '3', '440300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440304', '福田区', '', '3', '440300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440305', '南山区', '', '3', '440300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440306', '宝安区', '', '3', '440300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440307', '龙岗区', '', '3', '440300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440308', '盐田区', '', '3', '440300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440309', '其它区', '', '3', '440300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440320', '光明新区', '', '3', '440300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440321', '坪山新区', '', '3', '440300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440322', '大鹏新区', '', '3', '440300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440323', '龙华新区', '', '3', '440300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440400', '珠海市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440402', '香洲区', '', '3', '440400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440403', '斗门区', '', '3', '440400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440404', '金湾区', '', '3', '440400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440486', '金唐区', '', '3', '440400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440487', '南湾区', '', '3', '440400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440488', '其它区', '', '3', '440400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440500', '汕头市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440507', '龙湖区', '', '3', '440500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440511', '金平区', '', '3', '440500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440512', '濠江区', '', '3', '440500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440513', '潮阳区', '', '3', '440500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440514', '潮南区', '', '3', '440500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440515', '澄海区', '', '3', '440500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440523', '南澳县', '', '3', '440500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440524', '其它区', '', '3', '440500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440600', '佛山市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440604', '禅城区', '', '3', '440600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440605', '南海区', '', '3', '440600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440606', '顺德区', '', '3', '440600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440607', '三水区', '', '3', '440600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440608', '高明区', '', '3', '440600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440609', '其它区', '', '3', '440600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440700', '江门市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440703', '蓬江区', '', '3', '440700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440704', '江海区', '', '3', '440700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440705', '新会区', '', '3', '440700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440781', '台山市', '', '3', '440700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440783', '开平市', '', '3', '440700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440784', '鹤山市', '', '3', '440700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440785', '恩平市', '', '3', '440700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440786', '其它区', '', '3', '440700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440800', '湛江市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440802', '赤坎区', '', '3', '440800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440803', '霞山区', '', '3', '440800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440804', '坡头区', '', '3', '440800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440811', '麻章区', '', '3', '440800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440823', '遂溪县', '', '3', '440800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440825', '徐闻县', '', '3', '440800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440881', '廉江市', '', '3', '440800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440882', '雷州市', '', '3', '440800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440883', '吴川市', '', '3', '440800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440884', '其它区', '', '3', '440800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440900', '茂名市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440902', '茂南区', '', '3', '440900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440903', '电白区', '', '3', '440900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440923', '电白县', '', '3', '440900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440981', '高州市', '', '3', '440900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440982', '化州市', '', '3', '440900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440983', '信宜市', '', '3', '440900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('440984', '其它区', '', '3', '440900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441200', '肇庆市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441202', '端州区', '', '3', '441200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441203', '鼎湖区', '', '3', '441200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441223', '广宁县', '', '3', '441200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441224', '怀集县', '', '3', '441200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441225', '封开县', '', '3', '441200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441226', '德庆县', '', '3', '441200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441283', '高要市', '', '3', '441200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441284', '四会市', '', '3', '441200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441285', '其它区', '', '3', '441200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441300', '惠州市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441302', '惠城区', '', '3', '441300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441303', '惠阳区', '', '3', '441300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441322', '博罗县', '', '3', '441300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441323', '惠东县', '', '3', '441300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441324', '龙门县', '', '3', '441300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441325', '其它区', '', '3', '441300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441400', '梅州市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441402', '梅江区', '', '3', '441400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441421', '梅县区', '', '3', '441400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441422', '大埔县', '', '3', '441400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441423', '丰顺县', '', '3', '441400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441424', '五华县', '', '3', '441400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441426', '平远县', '', '3', '441400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441427', '蕉岭县', '', '3', '441400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441481', '兴宁市', '', '3', '441400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441482', '其它区', '', '3', '441400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441500', '汕尾市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441502', '城区', '', '3', '441500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441521', '海丰县', '', '3', '441500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441523', '陆河县', '', '3', '441500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441581', '陆丰市', '', '3', '441500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441582', '其它区', '', '3', '441500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441600', '河源市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441602', '源城区', '', '3', '441600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441621', '紫金县', '', '3', '441600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441622', '龙川县', '', '3', '441600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441623', '连平县', '', '3', '441600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441624', '和平县', '', '3', '441600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441625', '东源县', '', '3', '441600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441626', '其它区', '', '3', '441600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441700', '阳江市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441702', '江城区', '', '3', '441700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441721', '阳西县', '', '3', '441700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441723', '阳东区', '', '3', '441700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441781', '阳春市', '', '3', '441700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441782', '其它区', '', '3', '441700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441800', '清远市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441802', '清城区', '', '3', '441800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441821', '佛冈县', '', '3', '441800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441823', '阳山县', '', '3', '441800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441825', '连山壮族瑶族自治县', '', '3', '441800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441826', '连南瑶族自治县', '', '3', '441800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441827', '清新区', '', '3', '441800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441881', '英德市', '', '3', '441800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441882', '连州市', '', '3', '441800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441883', '其它区', '', '3', '441800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441900', '东莞市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441901', '中堂镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441902', '东坑镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441903', '道滘镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441904', '沙田镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441905', '高埗镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441906', '石龙镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441907', '石排镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441908', '企石镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441909', '石碣镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441910', '洪梅镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441911', '麻涌镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441912', '桥头镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441913', '望牛墩镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441914', '茶山镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441915', '谢岗镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441916', '松山湖', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441917', '莞城区', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441918', '南城区', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441919', '长安镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441920', '寮步镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441921', '大岭山镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441922', '常平镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441923', '厚街镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441924', '万江区', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441925', '樟木头镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441926', '大朗镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441927', '塘厦镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441928', '凤岗镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441929', '清溪镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441930', '横沥镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441931', '东城区', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441932', '黄江镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('441933', '虎门镇', '', '3', '441900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442000', '中山市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442001', '南朗镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442002', '古镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442003', '三乡镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442004', '板芙镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442005', '五桂山镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442006', '民众镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442007', '沙溪镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442008', '阜沙镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442009', '港口镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442010', '东升镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442011', '城区', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442012', '横栏镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442013', '黄圃镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442014', '东凤镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442015', '坦洲镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442016', '小榄镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442017', '南头镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442018', '沙朗镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442019', '大涌镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442020', '三角镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442021', '火炬开发区', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442022', '神湾镇', '', '3', '442000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('442101', '东沙群岛', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445100', '潮州市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445102', '湘桥区', '', '3', '445100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445121', '潮安区', '', '3', '445100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445122', '饶平县', '', '3', '445100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445185', '枫溪区', '', '3', '445100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445186', '其它区', '', '3', '445100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445200', '揭阳市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445202', '榕城区', '', '3', '445200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445221', '揭东区', '', '3', '445200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445222', '揭西县', '', '3', '445200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445224', '惠来县', '', '3', '445200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445281', '普宁市', '', '3', '445200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445284', '东山区', '', '3', '445200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445285', '其它区', '', '3', '445200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445300', '云浮市', '', '2', '440000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445302', '云城区', '', '3', '445300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445321', '新兴县', '', '3', '445300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445322', '郁南县', '', '3', '445300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445323', '云安区', '', '3', '445300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445381', '罗定市', '', '3', '445300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('445382', '其它区', '', '3', '445300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450000', '广西壮族自治区', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450100', '南宁市', '', '2', '450000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450102', '兴宁区', '', '3', '450100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450103', '青秀区', '', '3', '450100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450105', '江南区', '', '3', '450100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450107', '西乡塘区', '', '3', '450100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450108', '良庆区', '', '3', '450100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450109', '邕宁区', '', '3', '450100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450122', '武鸣区', '', '3', '450100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450123', '隆安县', '', '3', '450100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450124', '马山县', '', '3', '450100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450125', '上林县', '', '3', '450100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450126', '宾阳县', '', '3', '450100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450127', '横县', '', '3', '450100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450128', '其它区', '', '3', '450100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450200', '柳州市', '', '2', '450000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450202', '城中区', '', '3', '450200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450203', '鱼峰区', '', '3', '450200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450204', '柳南区', '', '3', '450200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450205', '柳北区', '', '3', '450200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450221', '柳江县', '', '3', '450200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450222', '柳城县', '', '3', '450200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450223', '鹿寨县', '', '3', '450200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450224', '融安县', '', '3', '450200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450225', '融水苗族自治县', '', '3', '450200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450226', '三江侗族自治县', '', '3', '450200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450227', '其它区', '', '3', '450200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450300', '桂林市', '', '2', '450000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450302', '秀峰区', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450303', '叠彩区', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450304', '象山区', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450305', '七星区', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450311', '雁山区', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450321', '阳朔县', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450322', '临桂区', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450323', '灵川县', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450324', '全州县', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450325', '兴安县', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450326', '永福县', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450327', '灌阳县', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450328', '龙胜各族自治县', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450329', '资源县', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450330', '平乐县', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450331', '荔浦县', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450332', '恭城瑶族自治县', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450333', '其它区', '', '3', '450300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450400', '梧州市', '', '2', '450000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450403', '万秀区', '', '3', '450400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450404', '蝶山区', '', '3', '450400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450405', '长洲区', '', '3', '450400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450406', '龙圩区', '', '3', '450400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450421', '苍梧县', '', '3', '450400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450422', '藤县', '', '3', '450400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450423', '蒙山县', '', '3', '450400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450481', '岑溪市', '', '3', '450400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450482', '其它区', '', '3', '450400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450500', '北海市', '', '2', '450000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450502', '海城区', '', '3', '450500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450503', '银海区', '', '3', '450500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450512', '铁山港区', '', '3', '450500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450521', '合浦县', '', '3', '450500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450522', '其它区', '', '3', '450500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450600', '防城港市', '', '2', '450000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450602', '港口区', '', '3', '450600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450603', '防城区', '', '3', '450600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450621', '上思县', '', '3', '450600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450681', '东兴市', '', '3', '450600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450682', '其它区', '', '3', '450600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450700', '钦州市', '', '2', '450000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450702', '钦南区', '', '3', '450700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450703', '钦北区', '', '3', '450700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450721', '灵山县', '', '3', '450700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450722', '浦北县', '', '3', '450700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450723', '其它区', '', '3', '450700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450800', '贵港市', '', '2', '450000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450802', '港北区', '', '3', '450800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450803', '港南区', '', '3', '450800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450804', '覃塘区', '', '3', '450800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450821', '平南县', '', '3', '450800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450881', '桂平市', '', '3', '450800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450882', '其它区', '', '3', '450800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450900', '玉林市', '', '2', '450000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450902', '玉州区', '', '3', '450900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450903', '福绵区', '', '3', '450900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450921', '容县', '', '3', '450900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450922', '陆川县', '', '3', '450900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450923', '博白县', '', '3', '450900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450924', '兴业县', '', '3', '450900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450981', '北流市', '', '3', '450900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('450982', '其它区', '', '3', '450900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451000', '百色市', '', '2', '450000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451002', '右江区', '', '3', '451000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451021', '田阳县', '', '3', '451000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451022', '田东县', '', '3', '451000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451023', '平果县', '', '3', '451000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451024', '德保县', '', '3', '451000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451025', '靖西县', '', '3', '451000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451026', '那坡县', '', '3', '451000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451027', '凌云县', '', '3', '451000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451028', '乐业县', '', '3', '451000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451029', '田林县', '', '3', '451000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451030', '西林县', '', '3', '451000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451031', '隆林各族自治县', '', '3', '451000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451032', '其它区', '', '3', '451000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451100', '贺州市', '', '2', '450000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451102', '八步区', '', '3', '451100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451119', '平桂管理区', '', '3', '451100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451121', '昭平县', '', '3', '451100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451122', '钟山县', '', '3', '451100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451123', '富川瑶族自治县', '', '3', '451100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451124', '其它区', '', '3', '451100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451200', '河池市', '', '2', '450000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451202', '金城江区', '', '3', '451200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451221', '南丹县', '', '3', '451200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451222', '天峨县', '', '3', '451200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451223', '凤山县', '', '3', '451200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451224', '东兰县', '', '3', '451200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451225', '罗城仫佬族自治县', '', '3', '451200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451226', '环江毛南族自治县', '', '3', '451200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451227', '巴马瑶族自治县', '', '3', '451200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451228', '都安瑶族自治县', '', '3', '451200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451229', '大化瑶族自治县', '', '3', '451200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451281', '宜州市', '', '3', '451200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451282', '其它区', '', '3', '451200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451300', '来宾市', '', '2', '450000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451302', '兴宾区', '', '3', '451300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451321', '忻城县', '', '3', '451300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451322', '象州县', '', '3', '451300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451323', '武宣县', '', '3', '451300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451324', '金秀瑶族自治县', '', '3', '451300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451381', '合山市', '', '3', '451300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451382', '其它区', '', '3', '451300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451400', '崇左市', '', '2', '450000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451402', '江州区', '', '3', '451400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451421', '扶绥县', '', '3', '451400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451422', '宁明县', '', '3', '451400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451423', '龙州县', '', '3', '451400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451424', '大新县', '', '3', '451400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451425', '天等县', '', '3', '451400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451481', '凭祥市', '', '3', '451400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('451482', '其它区', '', '3', '451400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('460000', '海南省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('460100', '海口市', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('460105', '秀英区', '', '3', '460100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('460106', '龙华区', '', '3', '460100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('460107', '琼山区', '', '3', '460100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('460108', '美兰区', '', '3', '460100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('460109', '其它区', '', '3', '460100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('460200', '三亚市', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('460300', '三沙市', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('460321', '西沙群岛', '', '3', '460300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('460322', '南沙群岛', '', '3', '460300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('460323', '中沙群岛的岛礁及其海域', '', '3', '460300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469001', '五指山市', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002', '琼海市', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003', '儋州市', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005', '文昌市', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469006', '万宁市', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469007', '东方市', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469025', '定安县', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469026', '屯昌县', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469027', '澄迈县', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469028', '临高县', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030', '白沙黎族自治县', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469031', '昌江黎族自治县', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033', '乐东黎族自治县', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034', '陵水黎族自治县', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469035', '保亭黎族苗族自治县', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036', '琼中黎族苗族自治县', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469037', '西沙群岛', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469038', '南沙群岛', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469039', '中沙群岛的岛礁及其海域', '', '2', '460000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('471004', '高新区', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('471005', '其它区', '', '3', '410300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500000', '重庆', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500100', '重庆市', '', '2', '500000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500101', '万州区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500102', '涪陵区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500103', '渝中区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500104', '大渡口区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500105', '江北区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500106', '沙坪坝区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500107', '九龙坡区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500108', '南岸区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500109', '北碚区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500110', '万盛区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500111', '双桥区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500112', '渝北区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500113', '巴南区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500114', '黔江区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500115', '长寿区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500222', '綦江区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500223', '潼南县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500224', '铜梁区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500225', '大足区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500226', '荣昌县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500227', '璧山区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500228', '梁平县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500229', '城口县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500230', '丰都县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500231', '垫江县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500232', '武隆县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500233', '忠县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500234', '开县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500235', '云阳县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500236', '奉节县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500237', '巫山县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500238', '巫溪县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500240', '石柱土家族自治县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500241', '秀山土家族苗族自治县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500242', '酉阳土家族苗族自治县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500243', '彭水苗族土家族自治县', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500381', '江津区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500382', '合川区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500383', '永川区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500384', '南川区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('500385', '其它区', '', '3', '500100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510000', '四川省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510100', '成都市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510104', '锦江区', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510105', '青羊区', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510106', '金牛区', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510107', '武侯区', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510108', '成华区', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510112', '龙泉驿区', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510113', '青白江区', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510114', '新都区', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510115', '温江区', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510121', '金堂县', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510122', '双流县', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510124', '郫县', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510129', '大邑县', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510131', '蒲江县', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510132', '新津县', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510181', '都江堰市', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510182', '彭州市', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510183', '邛崃市', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510184', '崇州市', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510185', '其它区', '', '3', '510100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510300', '自贡市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510302', '自流井区', '', '3', '510300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510303', '贡井区', '', '3', '510300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510304', '大安区', '', '3', '510300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510311', '沿滩区', '', '3', '510300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510321', '荣县', '', '3', '510300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510322', '富顺县', '', '3', '510300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510323', '其它区', '', '3', '510300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510400', '攀枝花市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510402', '东区', '', '3', '510400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510403', '西区', '', '3', '510400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510411', '仁和区', '', '3', '510400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510421', '米易县', '', '3', '510400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510422', '盐边县', '', '3', '510400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510423', '其它区', '', '3', '510400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510500', '泸州市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510502', '江阳区', '', '3', '510500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510503', '纳溪区', '', '3', '510500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510504', '龙马潭区', '', '3', '510500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510521', '泸县', '', '3', '510500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510522', '合江县', '', '3', '510500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510524', '叙永县', '', '3', '510500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510525', '古蔺县', '', '3', '510500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510526', '其它区', '', '3', '510500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510600', '德阳市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510603', '旌阳区', '', '3', '510600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510623', '中江县', '', '3', '510600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510626', '罗江县', '', '3', '510600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510681', '广汉市', '', '3', '510600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510682', '什邡市', '', '3', '510600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510683', '绵竹市', '', '3', '510600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510684', '其它区', '', '3', '510600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510700', '绵阳市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510703', '涪城区', '', '3', '510700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510704', '游仙区', '', '3', '510700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510722', '三台县', '', '3', '510700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510723', '盐亭县', '', '3', '510700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510724', '安县', '', '3', '510700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510725', '梓潼县', '', '3', '510700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510726', '北川羌族自治县', '', '3', '510700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510727', '平武县', '', '3', '510700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510751', '高新区', '', '3', '510700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510781', '江油市', '', '3', '510700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510782', '其它区', '', '3', '510700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510800', '广元市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510802', '利州区', '', '3', '510800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510811', '昭化区', '', '3', '510800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510812', '朝天区', '', '3', '510800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510821', '旺苍县', '', '3', '510800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510822', '青川县', '', '3', '510800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510823', '剑阁县', '', '3', '510800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510824', '苍溪县', '', '3', '510800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510825', '其它区', '', '3', '510800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510900', '遂宁市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510903', '船山区', '', '3', '510900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510904', '安居区', '', '3', '510900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510921', '蓬溪县', '', '3', '510900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510922', '射洪县', '', '3', '510900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510923', '大英县', '', '3', '510900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('510924', '其它区', '', '3', '510900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511000', '内江市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511002', '市中区', '', '3', '511000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511011', '东兴区', '', '3', '511000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511024', '威远县', '', '3', '511000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511025', '资中县', '', '3', '511000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511028', '隆昌县', '', '3', '511000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511029', '其它区', '', '3', '511000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511100', '乐山市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511102', '市中区', '', '3', '511100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511111', '沙湾区', '', '3', '511100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511112', '五通桥区', '', '3', '511100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511113', '金口河区', '', '3', '511100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511123', '犍为县', '', '3', '511100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511124', '井研县', '', '3', '511100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511126', '夹江县', '', '3', '511100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511129', '沐川县', '', '3', '511100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511132', '峨边彝族自治县', '', '3', '511100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511133', '马边彝族自治县', '', '3', '511100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511181', '峨眉山市', '', '3', '511100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511182', '其它区', '', '3', '511100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511300', '南充市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511302', '顺庆区', '', '3', '511300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511303', '高坪区', '', '3', '511300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511304', '嘉陵区', '', '3', '511300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511321', '南部县', '', '3', '511300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511322', '营山县', '', '3', '511300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511323', '蓬安县', '', '3', '511300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511324', '仪陇县', '', '3', '511300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511325', '西充县', '', '3', '511300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511381', '阆中市', '', '3', '511300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511382', '其它区', '', '3', '511300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511400', '眉山市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511402', '东坡区', '', '3', '511400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511421', '仁寿县', '', '3', '511400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511422', '彭山区', '', '3', '511400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511423', '洪雅县', '', '3', '511400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511424', '丹棱县', '', '3', '511400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511425', '青神县', '', '3', '511400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511426', '其它区', '', '3', '511400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511500', '宜宾市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511502', '翠屏区', '', '3', '511500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511521', '宜宾县', '', '3', '511500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511522', '南溪区', '', '3', '511500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511523', '江安县', '', '3', '511500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511524', '长宁县', '', '3', '511500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511525', '高县', '', '3', '511500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511526', '珙县', '', '3', '511500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511527', '筠连县', '', '3', '511500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511528', '兴文县', '', '3', '511500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511529', '屏山县', '', '3', '511500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511530', '其它区', '', '3', '511500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511600', '广安市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511602', '广安区', '', '3', '511600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511603', '前锋区', '', '3', '511600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511621', '岳池县', '', '3', '511600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511622', '武胜县', '', '3', '511600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511623', '邻水县', '', '3', '511600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511681', '华蓥市', '', '3', '511600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511682', '市辖区', '', '3', '511600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511683', '其它区', '', '3', '511600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511700', '达州市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511702', '通川区', '', '3', '511700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511721', '达川区', '', '3', '511700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511722', '宣汉县', '', '3', '511700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511723', '开江县', '', '3', '511700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511724', '大竹县', '', '3', '511700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511725', '渠县', '', '3', '511700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511781', '万源市', '', '3', '511700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511782', '其它区', '', '3', '511700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511800', '雅安市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511802', '雨城区', '', '3', '511800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511821', '名山区', '', '3', '511800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511822', '荥经县', '', '3', '511800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511823', '汉源县', '', '3', '511800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511824', '石棉县', '', '3', '511800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511825', '天全县', '', '3', '511800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511826', '芦山县', '', '3', '511800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511827', '宝兴县', '', '3', '511800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511828', '其它区', '', '3', '511800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511900', '巴中市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511902', '巴州区', '', '3', '511900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511903', '恩阳区', '', '3', '511900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511921', '通江县', '', '3', '511900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511922', '南江县', '', '3', '511900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511923', '平昌县', '', '3', '511900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('511924', '其它区', '', '3', '511900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('512000', '资阳市', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('512002', '雁江区', '', '3', '512000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('512021', '安岳县', '', '3', '512000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('512022', '乐至县', '', '3', '512000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('512081', '简阳市', '', '3', '512000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('512082', '其它区', '', '3', '512000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513200', '阿坝藏族羌族自治州', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513221', '汶川县', '', '3', '513200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513222', '理县', '', '3', '513200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513223', '茂县', '', '3', '513200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513224', '松潘县', '', '3', '513200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513225', '九寨沟县', '', '3', '513200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513226', '金川县', '', '3', '513200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513227', '小金县', '', '3', '513200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513228', '黑水县', '', '3', '513200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513229', '马尔康县', '', '3', '513200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513230', '壤塘县', '', '3', '513200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513231', '阿坝县', '', '3', '513200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513232', '若尔盖县', '', '3', '513200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513233', '红原县', '', '3', '513200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513234', '其它区', '', '3', '513200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513300', '甘孜藏族自治州', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513321', '康定市', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513322', '泸定县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513323', '丹巴县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513324', '九龙县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513325', '雅江县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513326', '道孚县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513327', '炉霍县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513328', '甘孜县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513329', '新龙县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513330', '德格县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513331', '白玉县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513332', '石渠县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513333', '色达县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513334', '理塘县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513335', '巴塘县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513336', '乡城县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513337', '稻城县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513338', '得荣县', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513339', '其它区', '', '3', '513300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513400', '凉山彝族自治州', '', '2', '510000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513401', '西昌市', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513422', '木里藏族自治县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513423', '盐源县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513424', '德昌县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513425', '会理县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513426', '会东县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513427', '宁南县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513428', '普格县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513429', '布拖县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513430', '金阳县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513431', '昭觉县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513432', '喜德县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513433', '冕宁县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513434', '越西县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513435', '甘洛县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513436', '美姑县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513437', '雷波县', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('513438', '其它区', '', '3', '513400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520000', '贵州省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520100', '贵阳市', '', '2', '520000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520102', '南明区', '', '3', '520100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520103', '云岩区', '', '3', '520100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520111', '花溪区', '', '3', '520100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520112', '乌当区', '', '3', '520100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520113', '白云区', '', '3', '520100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520114', '小河区', '', '3', '520100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520121', '开阳县', '', '3', '520100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520122', '息烽县', '', '3', '520100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520123', '修文县', '', '3', '520100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520151', '观山湖区', '', '3', '520100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520181', '清镇市', '', '3', '520100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520182', '其它区', '', '3', '520100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520200', '六盘水市', '', '2', '520000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520201', '钟山区', '', '3', '520200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520203', '六枝特区', '', '3', '520200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520221', '水城县', '', '3', '520200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520222', '盘县', '', '3', '520200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520223', '其它区', '', '3', '520200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520300', '遵义市', '', '2', '520000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520302', '红花岗区', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520303', '汇川区', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520321', '遵义县', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520322', '桐梓县', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520323', '绥阳县', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520324', '正安县', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520325', '道真仡佬族苗族自治县', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520326', '务川仡佬族苗族自治县', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520327', '凤冈县', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520328', '湄潭县', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520329', '余庆县', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520330', '习水县', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520381', '赤水市', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520382', '仁怀市', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520383', '其它区', '', '3', '520300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520400', '安顺市', '', '2', '520000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520402', '西秀区', '', '3', '520400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520421', '平坝区', '', '3', '520400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520422', '普定县', '', '3', '520400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520423', '镇宁布依族苗族自治县', '', '3', '520400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520424', '关岭布依族苗族自治县', '', '3', '520400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520425', '紫云苗族布依族自治县', '', '3', '520400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('520426', '其它区', '', '3', '520400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522200', '铜仁市', '', '2', '520000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522201', '碧江区', '', '3', '522200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522222', '江口县', '', '3', '522200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522223', '玉屏侗族自治县', '', '3', '522200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522224', '石阡县', '', '3', '522200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522225', '思南县', '', '3', '522200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522226', '印江土家族苗族自治县', '', '3', '522200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522227', '德江县', '', '3', '522200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522228', '沿河土家族自治县', '', '3', '522200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522229', '松桃苗族自治县', '', '3', '522200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522230', '万山区', '', '3', '522200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522231', '其它区', '', '3', '522200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522300', '黔西南布依族苗族自治州', '', '2', '520000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522301', '兴义市', '', '3', '522300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522322', '兴仁县', '', '3', '522300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522323', '普安县', '', '3', '522300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522324', '晴隆县', '', '3', '522300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522325', '贞丰县', '', '3', '522300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522326', '望谟县', '', '3', '522300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522327', '册亨县', '', '3', '522300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522328', '安龙县', '', '3', '522300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522329', '其它区', '', '3', '522300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522400', '毕节市', '', '2', '520000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522401', '七星关区', '', '3', '522400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522422', '大方县', '', '3', '522400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522423', '黔西县', '', '3', '522400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522424', '金沙县', '', '3', '522400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522425', '织金县', '', '3', '522400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522426', '纳雍县', '', '3', '522400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522427', '威宁彝族回族苗族自治县', '', '3', '522400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522428', '赫章县', '', '3', '522400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522429', '其它区', '', '3', '522400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522600', '黔东南苗族侗族自治州', '', '2', '520000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522601', '凯里市', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522622', '黄平县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522623', '施秉县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522624', '三穗县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522625', '镇远县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522626', '岑巩县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522627', '天柱县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522628', '锦屏县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522629', '剑河县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522630', '台江县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522631', '黎平县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522632', '榕江县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522633', '从江县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522634', '雷山县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522635', '麻江县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522636', '丹寨县', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522637', '其它区', '', '3', '522600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522700', '黔南布依族苗族自治州', '', '2', '520000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522701', '都匀市', '', '3', '522700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522702', '福泉市', '', '3', '522700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522722', '荔波县', '', '3', '522700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522723', '贵定县', '', '3', '522700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522725', '瓮安县', '', '3', '522700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522726', '独山县', '', '3', '522700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522727', '平塘县', '', '3', '522700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522728', '罗甸县', '', '3', '522700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522729', '长顺县', '', '3', '522700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522730', '龙里县', '', '3', '522700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522731', '惠水县', '', '3', '522700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522732', '三都水族自治县', '', '3', '522700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('522733', '其它区', '', '3', '522700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530000', '云南省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530100', '昆明市', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530102', '五华区', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530103', '盘龙区', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530111', '官渡区', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530112', '西山区', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530113', '东川区', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530121', '呈贡区', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530122', '晋宁县', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530124', '富民县', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530125', '宜良县', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530126', '石林彝族自治县', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530127', '嵩明县', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530128', '禄劝彝族苗族自治县', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530129', '寻甸回族彝族自治县', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530181', '安宁市', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530182', '其它区', '', '3', '530100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530300', '曲靖市', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530302', '麒麟区', '', '3', '530300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530321', '马龙县', '', '3', '530300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530322', '陆良县', '', '3', '530300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530323', '师宗县', '', '3', '530300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530324', '罗平县', '', '3', '530300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530325', '富源县', '', '3', '530300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530326', '会泽县', '', '3', '530300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530328', '沾益县', '', '3', '530300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530381', '宣威市', '', '3', '530300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530382', '其它区', '', '3', '530300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530400', '玉溪市', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530402', '红塔区', '', '3', '530400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530421', '江川县', '', '3', '530400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530422', '澄江县', '', '3', '530400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530423', '通海县', '', '3', '530400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530424', '华宁县', '', '3', '530400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530425', '易门县', '', '3', '530400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530426', '峨山彝族自治县', '', '3', '530400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530427', '新平彝族傣族自治县', '', '3', '530400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530428', '元江哈尼族彝族傣族自治县', '', '3', '530400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530429', '其它区', '', '3', '530400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530500', '保山市', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530502', '隆阳区', '', '3', '530500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530521', '施甸县', '', '3', '530500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530522', '腾冲县', '', '3', '530500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530523', '龙陵县', '', '3', '530500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530524', '昌宁县', '', '3', '530500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530525', '其它区', '', '3', '530500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530600', '昭通市', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530602', '昭阳区', '', '3', '530600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530621', '鲁甸县', '', '3', '530600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530622', '巧家县', '', '3', '530600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530623', '盐津县', '', '3', '530600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530624', '大关县', '', '3', '530600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530625', '永善县', '', '3', '530600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530626', '绥江县', '', '3', '530600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530627', '镇雄县', '', '3', '530600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530628', '彝良县', '', '3', '530600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530629', '威信县', '', '3', '530600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530630', '水富县', '', '3', '530600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530631', '其它区', '', '3', '530600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530700', '丽江市', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530702', '古城区', '', '3', '530700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530721', '玉龙纳西族自治县', '', '3', '530700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530722', '永胜县', '', '3', '530700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530723', '华坪县', '', '3', '530700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530724', '宁蒗彝族自治县', '', '3', '530700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530725', '其它区', '', '3', '530700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530800', '普洱市', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530802', '思茅区', '', '3', '530800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530821', '宁洱哈尼族彝族自治县', '', '3', '530800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530822', '墨江哈尼族自治县', '', '3', '530800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530823', '景东彝族自治县', '', '3', '530800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530824', '景谷傣族彝族自治县', '', '3', '530800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530825', '镇沅彝族哈尼族拉祜族自治县', '', '3', '530800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530826', '江城哈尼族彝族自治县', '', '3', '530800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530827', '孟连傣族拉祜族佤族自治县', '', '3', '530800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530828', '澜沧拉祜族自治县', '', '3', '530800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530829', '西盟佤族自治县', '', '3', '530800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530830', '其它区', '', '3', '530800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530900', '临沧市', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530902', '临翔区', '', '3', '530900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530921', '凤庆县', '', '3', '530900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530922', '云县', '', '3', '530900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530923', '永德县', '', '3', '530900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530924', '镇康县', '', '3', '530900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530925', '双江拉祜族佤族布朗族傣族自治县', '', '3', '530900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530926', '耿马傣族佤族自治县', '', '3', '530900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530927', '沧源佤族自治县', '', '3', '530900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('530928', '其它区', '', '3', '530900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532300', '楚雄彝族自治州', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532301', '楚雄市', '', '3', '532300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532322', '双柏县', '', '3', '532300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532323', '牟定县', '', '3', '532300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532324', '南华县', '', '3', '532300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532325', '姚安县', '', '3', '532300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532326', '大姚县', '', '3', '532300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532327', '永仁县', '', '3', '532300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532328', '元谋县', '', '3', '532300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532329', '武定县', '', '3', '532300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532331', '禄丰县', '', '3', '532300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532332', '其它区', '', '3', '532300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532500', '红河哈尼族彝族自治州', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532501', '个旧市', '', '3', '532500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532502', '开远市', '', '3', '532500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532522', '蒙自市', '', '3', '532500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532523', '屏边苗族自治县', '', '3', '532500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532524', '建水县', '', '3', '532500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532525', '石屏县', '', '3', '532500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532526', '弥勒市', '', '3', '532500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532527', '泸西县', '', '3', '532500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532528', '元阳县', '', '3', '532500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532529', '红河县', '', '3', '532500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532530', '金平苗族瑶族傣族自治县', '', '3', '532500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532531', '绿春县', '', '3', '532500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532532', '河口瑶族自治县', '', '3', '532500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532533', '其它区', '', '3', '532500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532600', '文山壮族苗族自治州', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532621', '文山市', '', '3', '532600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532622', '砚山县', '', '3', '532600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532623', '西畴县', '', '3', '532600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532624', '麻栗坡县', '', '3', '532600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532625', '马关县', '', '3', '532600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532626', '丘北县', '', '3', '532600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532627', '广南县', '', '3', '532600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532628', '富宁县', '', '3', '532600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532629', '其它区', '', '3', '532600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532800', '西双版纳傣族自治州', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532801', '景洪市', '', '3', '532800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532822', '勐海县', '', '3', '532800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532823', '勐腊县', '', '3', '532800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532824', '其它区', '', '3', '532800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532900', '大理白族自治州', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532901', '大理市', '', '3', '532900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532922', '漾濞彝族自治县', '', '3', '532900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532923', '祥云县', '', '3', '532900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532924', '宾川县', '', '3', '532900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532925', '弥渡县', '', '3', '532900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532926', '南涧彝族自治县', '', '3', '532900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532927', '巍山彝族回族自治县', '', '3', '532900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532928', '永平县', '', '3', '532900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532929', '云龙县', '', '3', '532900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532930', '洱源县', '', '3', '532900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532931', '剑川县', '', '3', '532900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532932', '鹤庆县', '', '3', '532900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('532933', '其它区', '', '3', '532900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533100', '德宏傣族景颇族自治州', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533102', '瑞丽市', '', '3', '533100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533103', '芒市', '', '3', '533100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533122', '梁河县', '', '3', '533100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533123', '盈江县', '', '3', '533100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533124', '陇川县', '', '3', '533100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533125', '其它区', '', '3', '533100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533300', '怒江傈僳族自治州', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533321', '泸水县', '', '3', '533300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533323', '福贡县', '', '3', '533300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533324', '贡山独龙族怒族自治县', '', '3', '533300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533325', '兰坪白族普米族自治县', '', '3', '533300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533326', '其它区', '', '3', '533300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533400', '迪庆藏族自治州', '', '2', '530000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533421', '香格里拉市', '', '3', '533400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533422', '德钦县', '', '3', '533400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533423', '维西傈僳族自治县', '', '3', '533400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('533424', '其它区', '', '3', '533400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('540000', '西藏自治区', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('540100', '拉萨市', '', '2', '540000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('540102', '城关区', '', '3', '540100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('540121', '林周县', '', '3', '540100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('540122', '当雄县', '', '3', '540100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('540123', '尼木县', '', '3', '540100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('540124', '曲水县', '', '3', '540100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('540125', '堆龙德庆县', '', '3', '540100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('540126', '达孜县', '', '3', '540100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('540127', '墨竹工卡县', '', '3', '540100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('540128', '其它区', '', '3', '540100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542100', '昌都市', '', '2', '540000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542121', '卡若区', '', '3', '542100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542122', '江达县', '', '3', '542100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542123', '贡觉县', '', '3', '542100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542124', '类乌齐县', '', '3', '542100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542125', '丁青县', '', '3', '542100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542126', '察雅县', '', '3', '542100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542127', '八宿县', '', '3', '542100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542128', '左贡县', '', '3', '542100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542129', '芒康县', '', '3', '542100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542132', '洛隆县', '', '3', '542100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542133', '边坝县', '', '3', '542100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542134', '其它区', '', '3', '542100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542200', '山南地区', '', '2', '540000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542221', '乃东县', '', '3', '542200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542222', '扎囊县', '', '3', '542200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542223', '贡嘎县', '', '3', '542200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542224', '桑日县', '', '3', '542200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542225', '琼结县', '', '3', '542200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542226', '曲松县', '', '3', '542200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542227', '措美县', '', '3', '542200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542228', '洛扎县', '', '3', '542200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542229', '加查县', '', '3', '542200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542231', '隆子县', '', '3', '542200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542232', '错那县', '', '3', '542200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542233', '浪卡子县', '', '3', '542200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542234', '其它区', '', '3', '542200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542300', '日喀则市', '', '2', '540000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542301', '桑珠孜区', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542322', '南木林县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542323', '江孜县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542324', '定日县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542325', '萨迦县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542326', '拉孜县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542327', '昂仁县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542328', '谢通门县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542329', '白朗县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542330', '仁布县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542331', '康马县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542332', '定结县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542333', '仲巴县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542334', '亚东县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542335', '吉隆县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542336', '聂拉木县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542337', '萨嘎县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542338', '岗巴县', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542339', '其它区', '', '3', '542300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542400', '那曲地区', '', '2', '540000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542421', '那曲县', '', '3', '542400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542422', '嘉黎县', '', '3', '542400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542423', '比如县', '', '3', '542400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542424', '聂荣县', '', '3', '542400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542425', '安多县', '', '3', '542400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542426', '申扎县', '', '3', '542400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542427', '索县', '', '3', '542400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542428', '班戈县', '', '3', '542400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542429', '巴青县', '', '3', '542400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542430', '尼玛县', '', '3', '542400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542431', '其它区', '', '3', '542400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542432', '双湖县', '', '3', '542400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542500', '阿里地区', '', '2', '540000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542521', '普兰县', '', '3', '542500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542522', '札达县', '', '3', '542500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542523', '噶尔县', '', '3', '542500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542524', '日土县', '', '3', '542500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542525', '革吉县', '', '3', '542500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542526', '改则县', '', '3', '542500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542527', '措勤县', '', '3', '542500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542528', '其它区', '', '3', '542500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542600', '林芝市', '', '2', '540000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542621', '巴宜区', '', '3', '542600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542622', '工布江达县', '', '3', '542600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542623', '米林县', '', '3', '542600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542624', '墨脱县', '', '3', '542600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542625', '波密县', '', '3', '542600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542626', '察隅县', '', '3', '542600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542627', '朗县', '', '3', '542600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('542628', '其它区', '', '3', '542600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610000', '陕西省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610100', '西安市', '', '2', '610000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610102', '新城区', '', '3', '610100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610103', '碑林区', '', '3', '610100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610104', '莲湖区', '', '3', '610100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610111', '灞桥区', '', '3', '610100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610112', '未央区', '', '3', '610100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610113', '雁塔区', '', '3', '610100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610114', '阎良区', '', '3', '610100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610115', '临潼区', '', '3', '610100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610116', '长安区', '', '3', '610100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610122', '蓝田县', '', '3', '610100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610124', '周至县', '', '3', '610100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610125', '户县', '', '3', '610100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610126', '高陵区', '', '3', '610100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610127', '其它区', '', '3', '610100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610200', '铜川市', '', '2', '610000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610202', '王益区', '', '3', '610200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610203', '印台区', '', '3', '610200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610204', '耀州区', '', '3', '610200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610222', '宜君县', '', '3', '610200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610223', '其它区', '', '3', '610200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610300', '宝鸡市', '', '2', '610000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610302', '渭滨区', '', '3', '610300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610303', '金台区', '', '3', '610300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610304', '陈仓区', '', '3', '610300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610322', '凤翔县', '', '3', '610300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610323', '岐山县', '', '3', '610300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610324', '扶风县', '', '3', '610300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610326', '眉县', '', '3', '610300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610327', '陇县', '', '3', '610300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610328', '千阳县', '', '3', '610300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610329', '麟游县', '', '3', '610300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610330', '凤县', '', '3', '610300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610331', '太白县', '', '3', '610300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610332', '其它区', '', '3', '610300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610400', '咸阳市', '', '2', '610000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610402', '秦都区', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610403', '杨陵区', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610404', '渭城区', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610422', '三原县', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610423', '泾阳县', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610424', '乾县', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610425', '礼泉县', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610426', '永寿县', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610427', '彬县', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610428', '长武县', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610429', '旬邑县', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610430', '淳化县', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610431', '武功县', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610481', '兴平市', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610482', '其它区', '', '3', '610400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610500', '渭南市', '', '2', '610000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610502', '临渭区', '', '3', '610500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610521', '华县', '', '3', '610500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610522', '潼关县', '', '3', '610500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610523', '大荔县', '', '3', '610500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610524', '合阳县', '', '3', '610500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610525', '澄城县', '', '3', '610500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610526', '蒲城县', '', '3', '610500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610527', '白水县', '', '3', '610500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610528', '富平县', '', '3', '610500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610581', '韩城市', '', '3', '610500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610582', '华阴市', '', '3', '610500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610583', '其它区', '', '3', '610500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610600', '延安市', '', '2', '610000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610602', '宝塔区', '', '3', '610600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610621', '延长县', '', '3', '610600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610622', '延川县', '', '3', '610600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610623', '子长县', '', '3', '610600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610624', '安塞县', '', '3', '610600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610625', '志丹县', '', '3', '610600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610626', '吴起县', '', '3', '610600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610627', '甘泉县', '', '3', '610600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610628', '富县', '', '3', '610600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610629', '洛川县', '', '3', '610600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610630', '宜川县', '', '3', '610600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610631', '黄龙县', '', '3', '610600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610632', '黄陵县', '', '3', '610600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610633', '其它区', '', '3', '610600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610700', '汉中市', '', '2', '610000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610702', '汉台区', '', '3', '610700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610721', '南郑县', '', '3', '610700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610722', '城固县', '', '3', '610700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610723', '洋县', '', '3', '610700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610724', '西乡县', '', '3', '610700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610725', '勉县', '', '3', '610700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610726', '宁强县', '', '3', '610700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610727', '略阳县', '', '3', '610700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610728', '镇巴县', '', '3', '610700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610729', '留坝县', '', '3', '610700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610730', '佛坪县', '', '3', '610700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610731', '其它区', '', '3', '610700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610800', '榆林市', '', '2', '610000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610802', '榆阳区', '', '3', '610800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610821', '神木县', '', '3', '610800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610822', '府谷县', '', '3', '610800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610823', '横山县', '', '3', '610800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610824', '靖边县', '', '3', '610800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610825', '定边县', '', '3', '610800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610826', '绥德县', '', '3', '610800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610827', '米脂县', '', '3', '610800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610828', '佳县', '', '3', '610800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610829', '吴堡县', '', '3', '610800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610830', '清涧县', '', '3', '610800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610831', '子洲县', '', '3', '610800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610832', '其它区', '', '3', '610800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610900', '安康市', '', '2', '610000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610902', '汉滨区', '', '3', '610900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610921', '汉阴县', '', '3', '610900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610922', '石泉县', '', '3', '610900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610923', '宁陕县', '', '3', '610900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610924', '紫阳县', '', '3', '610900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610925', '岚皋县', '', '3', '610900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610926', '平利县', '', '3', '610900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610927', '镇坪县', '', '3', '610900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610928', '旬阳县', '', '3', '610900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610929', '白河县', '', '3', '610900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('610930', '其它区', '', '3', '610900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('611000', '商洛市', '', '2', '610000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('611002', '商州区', '', '3', '611000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('611021', '洛南县', '', '3', '611000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('611022', '丹凤县', '', '3', '611000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('611023', '商南县', '', '3', '611000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('611024', '山阳县', '', '3', '611000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('611025', '镇安县', '', '3', '611000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('611026', '柞水县', '', '3', '611000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('611027', '其它区', '', '3', '611000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620000', '甘肃省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620100', '兰州市', '', '2', '620000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620102', '城关区', '', '3', '620100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620103', '七里河区', '', '3', '620100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620104', '西固区', '', '3', '620100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620105', '安宁区', '', '3', '620100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620111', '红古区', '', '3', '620100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620121', '永登县', '', '3', '620100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620122', '皋兰县', '', '3', '620100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620123', '榆中县', '', '3', '620100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620124', '其它区', '', '3', '620100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620200', '嘉峪关市', '', '2', '620000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620300', '金昌市', '', '2', '620000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620302', '金川区', '', '3', '620300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620321', '永昌县', '', '3', '620300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620322', '其它区', '', '3', '620300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620400', '白银市', '', '2', '620000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620402', '白银区', '', '3', '620400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620403', '平川区', '', '3', '620400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620421', '靖远县', '', '3', '620400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620422', '会宁县', '', '3', '620400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620423', '景泰县', '', '3', '620400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620424', '其它区', '', '3', '620400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620500', '天水市', '', '2', '620000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620502', '秦州区', '', '3', '620500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620503', '麦积区', '', '3', '620500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620521', '清水县', '', '3', '620500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620522', '秦安县', '', '3', '620500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620523', '甘谷县', '', '3', '620500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620524', '武山县', '', '3', '620500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620525', '张家川回族自治县', '', '3', '620500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620526', '其它区', '', '3', '620500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620600', '武威市', '', '2', '620000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620602', '凉州区', '', '3', '620600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620621', '民勤县', '', '3', '620600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620622', '古浪县', '', '3', '620600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620623', '天祝藏族自治县', '', '3', '620600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620624', '其它区', '', '3', '620600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620700', '张掖市', '', '2', '620000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620702', '甘州区', '', '3', '620700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620721', '肃南裕固族自治县', '', '3', '620700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620722', '民乐县', '', '3', '620700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620723', '临泽县', '', '3', '620700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620724', '高台县', '', '3', '620700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620725', '山丹县', '', '3', '620700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620726', '其它区', '', '3', '620700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620800', '平凉市', '', '2', '620000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620802', '崆峒区', '', '3', '620800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620821', '泾川县', '', '3', '620800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620822', '灵台县', '', '3', '620800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620823', '崇信县', '', '3', '620800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620824', '华亭县', '', '3', '620800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620825', '庄浪县', '', '3', '620800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620826', '静宁县', '', '3', '620800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620827', '其它区', '', '3', '620800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620900', '酒泉市', '', '2', '620000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620902', '肃州区', '', '3', '620900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620921', '金塔县', '', '3', '620900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620922', '瓜州县', '', '3', '620900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620923', '肃北蒙古族自治县', '', '3', '620900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620924', '阿克塞哈萨克族自治县', '', '3', '620900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620981', '玉门市', '', '3', '620900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620982', '敦煌市', '', '3', '620900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('620983', '其它区', '', '3', '620900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621000', '庆阳市', '', '2', '620000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621002', '西峰区', '', '3', '621000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621021', '庆城县', '', '3', '621000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621022', '环县', '', '3', '621000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621023', '华池县', '', '3', '621000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621024', '合水县', '', '3', '621000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621025', '正宁县', '', '3', '621000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621026', '宁县', '', '3', '621000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621027', '镇原县', '', '3', '621000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621028', '其它区', '', '3', '621000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621100', '定西市', '', '2', '620000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621102', '安定区', '', '3', '621100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621121', '通渭县', '', '3', '621100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621122', '陇西县', '', '3', '621100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621123', '渭源县', '', '3', '621100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621124', '临洮县', '', '3', '621100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621125', '漳县', '', '3', '621100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621126', '岷县', '', '3', '621100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621127', '其它区', '', '3', '621100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621200', '陇南市', '', '2', '620000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621202', '武都区', '', '3', '621200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621221', '成县', '', '3', '621200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621222', '文县', '', '3', '621200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621223', '宕昌县', '', '3', '621200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621224', '康县', '', '3', '621200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621225', '西和县', '', '3', '621200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621226', '礼县', '', '3', '621200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621227', '徽县', '', '3', '621200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621228', '两当县', '', '3', '621200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('621229', '其它区', '', '3', '621200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('622900', '临夏回族自治州', '', '2', '620000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('622901', '临夏市', '', '3', '622900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('622921', '临夏县', '', '3', '622900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('622922', '康乐县', '', '3', '622900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('622923', '永靖县', '', '3', '622900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('622924', '广河县', '', '3', '622900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('622925', '和政县', '', '3', '622900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('622926', '东乡族自治县', '', '3', '622900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('622927', '积石山保安族东乡族撒拉族自治县', '', '3', '622900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('622928', '其它区', '', '3', '622900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('623000', '甘南藏族自治州', '', '2', '620000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('623001', '合作市', '', '3', '623000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('623021', '临潭县', '', '3', '623000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('623022', '卓尼县', '', '3', '623000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('623023', '舟曲县', '', '3', '623000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('623024', '迭部县', '', '3', '623000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('623025', '玛曲县', '', '3', '623000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('623026', '碌曲县', '', '3', '623000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('623027', '夏河县', '', '3', '623000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('623028', '其它区', '', '3', '623000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('630000', '青海省', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('630100', '西宁市', '', '2', '630000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('630102', '城东区', '', '3', '630100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('630103', '城中区', '', '3', '630100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('630104', '城西区', '', '3', '630100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('630105', '城北区', '', '3', '630100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('630121', '大通回族土族自治县', '', '3', '630100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('630122', '湟中县', '', '3', '630100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('630123', '湟源县', '', '3', '630100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('630124', '其它区', '', '3', '630100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632100', '海东市', '', '2', '630000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632121', '平安区', '', '3', '632100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632122', '民和回族土族自治县', '', '3', '632100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632123', '乐都区', '', '3', '632100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632126', '互助土族自治县', '', '3', '632100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632127', '化隆回族自治县', '', '3', '632100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632128', '循化撒拉族自治县', '', '3', '632100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632129', '其它区', '', '3', '632100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632200', '海北藏族自治州', '', '2', '630000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632221', '门源回族自治县', '', '3', '632200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632222', '祁连县', '', '3', '632200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632223', '海晏县', '', '3', '632200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632224', '刚察县', '', '3', '632200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632225', '其它区', '', '3', '632200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632300', '黄南藏族自治州', '', '2', '630000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632321', '同仁县', '', '3', '632300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632322', '尖扎县', '', '3', '632300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632323', '泽库县', '', '3', '632300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632324', '河南蒙古族自治县', '', '3', '632300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632325', '其它区', '', '3', '632300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632500', '海南藏族自治州', '', '2', '630000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632521', '共和县', '', '3', '632500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632522', '同德县', '', '3', '632500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632523', '贵德县', '', '3', '632500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632524', '兴海县', '', '3', '632500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632525', '贵南县', '', '3', '632500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632526', '其它区', '', '3', '632500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632600', '果洛藏族自治州', '', '2', '630000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632621', '玛沁县', '', '3', '632600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632622', '班玛县', '', '3', '632600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632623', '甘德县', '', '3', '632600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632624', '达日县', '', '3', '632600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632625', '久治县', '', '3', '632600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632626', '玛多县', '', '3', '632600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632627', '其它区', '', '3', '632600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632700', '玉树藏族自治州', '', '2', '630000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632721', '玉树市', '', '3', '632700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632722', '杂多县', '', '3', '632700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632723', '称多县', '', '3', '632700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632724', '治多县', '', '3', '632700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632725', '囊谦县', '', '3', '632700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632726', '曲麻莱县', '', '3', '632700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632727', '其它区', '', '3', '632700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632800', '海西蒙古族藏族自治州', '', '2', '630000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632801', '格尔木市', '', '3', '632800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632802', '德令哈市', '', '3', '632800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632821', '乌兰县', '', '3', '632800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632822', '都兰县', '', '3', '632800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632823', '天峻县', '', '3', '632800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('632824', '其它区', '', '3', '632800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640000', '宁夏回族自治区', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640100', '银川市', '', '2', '640000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640104', '兴庆区', '', '3', '640100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640105', '西夏区', '', '3', '640100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640106', '金凤区', '', '3', '640100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640121', '永宁县', '', '3', '640100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640122', '贺兰县', '', '3', '640100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640181', '灵武市', '', '3', '640100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640182', '其它区', '', '3', '640100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640200', '石嘴山市', '', '2', '640000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640202', '大武口区', '', '3', '640200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640205', '惠农区', '', '3', '640200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640221', '平罗县', '', '3', '640200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640222', '其它区', '', '3', '640200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640300', '吴忠市', '', '2', '640000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640302', '利通区', '', '3', '640300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640303', '红寺堡区', '', '3', '640300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640323', '盐池县', '', '3', '640300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640324', '同心县', '', '3', '640300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640381', '青铜峡市', '', '3', '640300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640382', '其它区', '', '3', '640300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640400', '固原市', '', '2', '640000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640402', '原州区', '', '3', '640400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640422', '西吉县', '', '3', '640400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640423', '隆德县', '', '3', '640400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640424', '泾源县', '', '3', '640400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640425', '彭阳县', '', '3', '640400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640426', '其它区', '', '3', '640400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640500', '中卫市', '', '2', '640000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640502', '沙坡头区', '', '3', '640500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640521', '中宁县', '', '3', '640500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640522', '海原县', '', '3', '640500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('640523', '其它区', '', '3', '640500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650000', '新疆维吾尔自治区', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650100', '乌鲁木齐市', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650102', '天山区', '', '3', '650100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650103', '沙依巴克区', '', '3', '650100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650104', '新市区', '', '3', '650100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650105', '水磨沟区', '', '3', '650100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650106', '头屯河区', '', '3', '650100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650107', '达坂城区', '', '3', '650100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650108', '东山区', '', '3', '650100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650109', '米东区', '', '3', '650100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650121', '乌鲁木齐县', '', '3', '650100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650122', '其它区', '', '3', '650100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650200', '克拉玛依市', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650202', '独山子区', '', '3', '650200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650203', '克拉玛依区', '', '3', '650200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650204', '白碱滩区', '', '3', '650200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650205', '乌尔禾区', '', '3', '650200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('650206', '其它区', '', '3', '650200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652100', '吐鲁番市', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652101', '高昌区', '', '3', '652100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652122', '鄯善县', '', '3', '652100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652123', '托克逊县', '', '3', '652100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652124', '其它区', '', '3', '652100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652200', '哈密地区', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652201', '哈密市', '', '3', '652200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652222', '巴里坤哈萨克自治县', '', '3', '652200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652223', '伊吾县', '', '3', '652200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652224', '其它区', '', '3', '652200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652300', '昌吉回族自治州', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652301', '昌吉市', '', '3', '652300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652302', '阜康市', '', '3', '652300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652303', '米泉市', '', '3', '652300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652323', '呼图壁县', '', '3', '652300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652324', '玛纳斯县', '', '3', '652300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652325', '奇台县', '', '3', '652300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652327', '吉木萨尔县', '', '3', '652300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652328', '木垒哈萨克自治县', '', '3', '652300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652329', '其它区', '', '3', '652300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652700', '博尔塔拉蒙古自治州', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652701', '博乐市', '', '3', '652700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652702', '阿拉山口市', '', '3', '652700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652722', '精河县', '', '3', '652700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652723', '温泉县', '', '3', '652700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652724', '其它区', '', '3', '652700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652800', '巴音郭楞蒙古自治州', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652801', '库尔勒市', '', '3', '652800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652822', '轮台县', '', '3', '652800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652823', '尉犁县', '', '3', '652800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652824', '若羌县', '', '3', '652800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652825', '且末县', '', '3', '652800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652826', '焉耆回族自治县', '', '3', '652800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652827', '和静县', '', '3', '652800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652828', '和硕县', '', '3', '652800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652829', '博湖县', '', '3', '652800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652830', '其它区', '', '3', '652800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652900', '阿克苏地区', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652901', '阿克苏市', '', '3', '652900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652922', '温宿县', '', '3', '652900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652923', '库车县', '', '3', '652900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652924', '沙雅县', '', '3', '652900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652925', '新和县', '', '3', '652900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652926', '拜城县', '', '3', '652900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652927', '乌什县', '', '3', '652900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652928', '阿瓦提县', '', '3', '652900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652929', '柯坪县', '', '3', '652900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('652930', '其它区', '', '3', '652900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653000', '克孜勒苏柯尔克孜自治州', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653001', '阿图什市', '', '3', '653000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653022', '阿克陶县', '', '3', '653000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653023', '阿合奇县', '', '3', '653000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653024', '乌恰县', '', '3', '653000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653025', '其它区', '', '3', '653000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653100', '喀什地区', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653101', '喀什市', '', '3', '653100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653121', '疏附县', '', '3', '653100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653122', '疏勒县', '', '3', '653100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653123', '英吉沙县', '', '3', '653100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653124', '泽普县', '', '3', '653100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653125', '莎车县', '', '3', '653100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653126', '叶城县', '', '3', '653100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653127', '麦盖提县', '', '3', '653100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653128', '岳普湖县', '', '3', '653100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653129', '伽师县', '', '3', '653100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653130', '巴楚县', '', '3', '653100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653131', '塔什库尔干塔吉克自治县', '', '3', '653100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653132', '其它区', '', '3', '653100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653200', '和田地区', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653201', '和田市', '', '3', '653200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653221', '和田县', '', '3', '653200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653222', '墨玉县', '', '3', '653200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653223', '皮山县', '', '3', '653200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653224', '洛浦县', '', '3', '653200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653225', '策勒县', '', '3', '653200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653226', '于田县', '', '3', '653200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653227', '民丰县', '', '3', '653200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('653228', '其它区', '', '3', '653200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654000', '伊犁哈萨克自治州', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654002', '伊宁市', '', '3', '654000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654003', '奎屯市', '', '3', '654000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654021', '伊宁县', '', '3', '654000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654022', '察布查尔锡伯自治县', '', '3', '654000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654023', '霍城县', '', '3', '654000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654024', '巩留县', '', '3', '654000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654025', '新源县', '', '3', '654000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654026', '昭苏县', '', '3', '654000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654027', '特克斯县', '', '3', '654000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654028', '尼勒克县', '', '3', '654000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654029', '其它区', '', '3', '654000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654200', '塔城地区', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654201', '塔城市', '', '3', '654200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654202', '乌苏市', '', '3', '654200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654221', '额敏县', '', '3', '654200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654223', '沙湾县', '', '3', '654200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654224', '托里县', '', '3', '654200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654225', '裕民县', '', '3', '654200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654226', '和布克赛尔蒙古自治县', '', '3', '654200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654227', '其它区', '', '3', '654200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654300', '阿勒泰地区', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654301', '阿勒泰市', '', '3', '654300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654321', '布尔津县', '', '3', '654300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654322', '富蕴县', '', '3', '654300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654323', '福海县', '', '3', '654300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654324', '哈巴河县', '', '3', '654300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654325', '青河县', '', '3', '654300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654326', '吉木乃县', '', '3', '654300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('654327', '其它区', '', '3', '654300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659001', '石河子市', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002', '阿拉尔市', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659003', '图木舒克市', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659004', '五家渠市', '', '2', '650000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710000', '台湾', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710100', '台北市', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710101', '中正区', '', '3', '710100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710102', '大同区', '', '3', '710100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710103', '中山区', '', '3', '710100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710104', '松山区', '', '3', '710100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710105', '大安区', '', '3', '710100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710106', '万华区', '', '3', '710100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710107', '信义区', '', '3', '710100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710108', '士林区', '', '3', '710100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710109', '北投区', '', '3', '710100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710110', '内湖区', '', '3', '710100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710111', '南港区', '', '3', '710100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710112', '文山区', '', '3', '710100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710113', '其它区', '', '3', '710100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710200', '高雄市', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710201', '新兴区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710202', '前金区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710203', '芩雅区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710204', '盐埕区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710205', '鼓山区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710206', '旗津区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710207', '前镇区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710208', '三民区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710209', '左营区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710210', '楠梓区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710211', '小港区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710212', '其它区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710241', '苓雅区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710242', '仁武区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710243', '大社区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710244', '冈山区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710245', '路竹区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710246', '阿莲区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710247', '田寮区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710248', '燕巢区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710249', '桥头区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710250', '梓官区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710251', '弥陀区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710252', '永安区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710253', '湖内区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710254', '凤山区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710255', '大寮区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710256', '林园区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710257', '鸟松区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710258', '大树区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710259', '旗山区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710260', '美浓区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710261', '六龟区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710262', '内门区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710263', '杉林区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710264', '甲仙区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710265', '桃源区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710266', '那玛夏区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710267', '茂林区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710268', '茄萣区', '', '3', '710200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710300', '台南市', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710301', '中西区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710302', '东区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710303', '南区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710304', '北区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710305', '安平区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710306', '安南区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710307', '其它区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710339', '永康区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710340', '归仁区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710341', '新化区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710342', '左镇区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710343', '玉井区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710344', '楠西区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710345', '南化区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710346', '仁德区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710347', '关庙区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710348', '龙崎区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710349', '官田区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710350', '麻豆区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710351', '佳里区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710352', '西港区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710353', '七股区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710354', '将军区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710355', '学甲区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710356', '北门区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710357', '新营区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710358', '后壁区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710359', '白河区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710360', '东山区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710361', '六甲区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710362', '下营区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710363', '柳营区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710364', '盐水区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710365', '善化区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710366', '大内区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710367', '山上区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710368', '新市区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710369', '安定区', '', '3', '710300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710400', '台中市', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710401', '中区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710402', '东区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710403', '南区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710404', '西区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710405', '北区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710406', '北屯区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710407', '西屯区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710408', '南屯区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710409', '其它区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710431', '太平区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710432', '大里区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710433', '雾峰区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710434', '乌日区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710435', '丰原区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710436', '后里区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710437', '石冈区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710438', '东势区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710439', '和平区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710440', '新社区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710441', '潭子区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710442', '大雅区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710443', '神冈区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710444', '大肚区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710445', '沙鹿区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710446', '龙井区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710447', '梧栖区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710448', '清水区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710449', '大甲区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710450', '外埔区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710451', '大安区', '', '3', '710400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710500', '金门县', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710507', '金沙镇', '', '3', '710500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710508', '金湖镇', '', '3', '710500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710509', '金宁乡', '', '3', '710500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710510', '金城镇', '', '3', '710500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710511', '烈屿乡', '', '3', '710500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710512', '乌坵乡', '', '3', '710500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710600', '南投县', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710614', '南投市', '', '3', '710600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710615', '中寮乡', '', '3', '710600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710616', '草屯镇', '', '3', '710600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710617', '国姓乡', '', '3', '710600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710618', '埔里镇', '', '3', '710600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710619', '仁爱乡', '', '3', '710600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710620', '名间乡', '', '3', '710600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710621', '集集镇', '', '3', '710600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710622', '水里乡', '', '3', '710600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710623', '鱼池乡', '', '3', '710600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710624', '信义乡', '', '3', '710600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710625', '竹山镇', '', '3', '710600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710626', '鹿谷乡', '', '3', '710600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710700', '基隆市', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710701', '仁爱区', '', '3', '710700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710702', '信义区', '', '3', '710700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710703', '中正区', '', '3', '710700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710704', '中山区', '', '3', '710700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710705', '安乐区', '', '3', '710700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710706', '暖暖区', '', '3', '710700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710707', '七堵区', '', '3', '710700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710708', '其它区', '', '3', '710700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710800', '新竹市', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710801', '东区', '', '3', '710800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710802', '北区', '', '3', '710800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710803', '香山区', '', '3', '710800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710804', '其它区', '', '3', '710800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710900', '嘉义市', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710901', '东区', '', '3', '710900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710902', '西区', '', '3', '710900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('710903', '其它区', '', '3', '710900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711100', '新北市', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711130', '万里区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711131', '金山区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711132', '板桥区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711133', '汐止区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711134', '深坑区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711135', '石碇区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711136', '瑞芳区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711137', '平溪区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711138', '双溪区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711139', '贡寮区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711140', '新店区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711141', '坪林区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711142', '乌来区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711143', '永和区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711144', '中和区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711145', '土城区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711146', '三峡区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711147', '树林区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711148', '莺歌区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711149', '三重区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711150', '新庄区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711151', '泰山区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711152', '林口区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711153', '芦洲区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711154', '五股区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711155', '八里区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711156', '淡水区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711157', '三芝区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711158', '石门区', '', '3', '711100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711200', '宜兰县', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711214', '宜兰市', '', '3', '711200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711215', '头城镇', '', '3', '711200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711216', '礁溪乡', '', '3', '711200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711217', '壮围乡', '', '3', '711200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711218', '员山乡', '', '3', '711200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711219', '罗东镇', '', '3', '711200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711220', '三星乡', '', '3', '711200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711221', '大同乡', '', '3', '711200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711222', '五结乡', '', '3', '711200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711223', '冬山乡', '', '3', '711200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711224', '苏澳镇', '', '3', '711200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711225', '南澳乡', '', '3', '711200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711226', '钓鱼台', '', '3', '711200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711300', '新竹县', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711314', '竹北市', '', '3', '711300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711315', '湖口乡', '', '3', '711300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711316', '新丰乡', '', '3', '711300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711317', '新埔镇', '', '3', '711300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711318', '关西镇', '', '3', '711300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711319', '芎林乡', '', '3', '711300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711320', '宝山乡', '', '3', '711300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711321', '竹东镇', '', '3', '711300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711322', '五峰乡', '', '3', '711300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711323', '横山乡', '', '3', '711300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711324', '尖石乡', '', '3', '711300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711325', '北埔乡', '', '3', '711300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711326', '峨眉乡', '', '3', '711300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711400', '桃园县', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711414', '中坜市', '', '3', '711400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711415', '平镇市', '', '3', '711400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711416', '龙潭乡', '', '3', '711400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711417', '杨梅市', '', '3', '711400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711418', '新屋乡', '', '3', '711400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711419', '观音乡', '', '3', '711400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711420', '桃园市', '', '3', '711400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711421', '龟山乡', '', '3', '711400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711422', '八德市', '', '3', '711400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711423', '大溪镇', '', '3', '711400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711424', '复兴乡', '', '3', '711400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711425', '大园乡', '', '3', '711400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711426', '芦竹乡', '', '3', '711400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711500', '苗栗县', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711519', '竹南镇', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711520', '头份镇', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711521', '三湾乡', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711522', '南庄乡', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711523', '狮潭乡', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711524', '后龙镇', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711525', '通霄镇', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711526', '苑里镇', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711527', '苗栗市', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711528', '造桥乡', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711529', '头屋乡', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711530', '公馆乡', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711531', '大湖乡', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711532', '泰安乡', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711533', '铜锣乡', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711534', '三义乡', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711535', '西湖乡', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711536', '卓兰镇', '', '3', '711500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711700', '彰化县', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711727', '彰化市', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711728', '芬园乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711729', '花坛乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711730', '秀水乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711731', '鹿港镇', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711732', '福兴乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711733', '线西乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711734', '和美镇', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711735', '伸港乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711736', '员林镇', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711737', '社头乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711738', '永靖乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711739', '埔心乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711740', '溪湖镇', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711741', '大村乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711742', '埔盐乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711743', '田中镇', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711744', '北斗镇', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711745', '田尾乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711746', '埤头乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711747', '溪州乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711748', '竹塘乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711749', '二林镇', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711750', '大城乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711751', '芳苑乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711752', '二水乡', '', '3', '711700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711900', '嘉义县', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711919', '番路乡', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711920', '梅山乡', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711921', '竹崎乡', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711922', '阿里山乡', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711923', '中埔乡', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711924', '大埔乡', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711925', '水上乡', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711926', '鹿草乡', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711927', '太保市', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711928', '朴子市', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711929', '东石乡', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711930', '六脚乡', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711931', '新港乡', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711932', '民雄乡', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711933', '大林镇', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711934', '溪口乡', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711935', '义竹乡', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('711936', '布袋镇', '', '3', '711900', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712100', '云林县', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712121', '斗南镇', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712122', '大埤乡', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712123', '虎尾镇', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712124', '土库镇', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712125', '褒忠乡', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712126', '东势乡', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712127', '台西乡', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712128', '仑背乡', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712129', '麦寮乡', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712130', '斗六市', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712131', '林内乡', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712132', '古坑乡', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712133', '莿桐乡', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712134', '西螺镇', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712135', '二仑乡', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712136', '北港镇', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712137', '水林乡', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712138', '口湖乡', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712139', '四湖乡', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712140', '元长乡', '', '3', '712100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712400', '屏东县', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712434', '屏东市', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712435', '三地门乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712436', '雾台乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712437', '玛家乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712438', '九如乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712439', '里港乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712440', '高树乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712441', '盐埔乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712442', '长治乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712443', '麟洛乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712444', '竹田乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712445', '内埔乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712446', '万丹乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712447', '潮州镇', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712448', '泰武乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712449', '来义乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712450', '万峦乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712451', '崁顶乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712452', '新埤乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712453', '南州乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712454', '林边乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712455', '东港镇', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712456', '琉球乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712457', '佳冬乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712458', '新园乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712459', '枋寮乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712460', '枋山乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712461', '春日乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712462', '狮子乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712463', '车城乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712464', '牡丹乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712465', '恒春镇', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712466', '满州乡', '', '3', '712400', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712500', '台东县', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712517', '台东市', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712518', '绿岛乡', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712519', '兰屿乡', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712520', '延平乡', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712521', '卑南乡', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712522', '鹿野乡', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712523', '关山镇', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712524', '海端乡', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712525', '池上乡', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712526', '东河乡', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712527', '成功镇', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712528', '长滨乡', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712529', '金峰乡', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712530', '大武乡', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712531', '达仁乡', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712532', '太麻里乡', '', '3', '712500', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712600', '花莲县', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712615', '花莲市', '', '3', '712600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712616', '新城乡', '', '3', '712600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712617', '太鲁阁', '', '3', '712600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712618', '秀林乡', '', '3', '712600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712619', '吉安乡', '', '3', '712600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712620', '寿丰乡', '', '3', '712600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712621', '凤林镇', '', '3', '712600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712622', '光复乡', '', '3', '712600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712623', '丰滨乡', '', '3', '712600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712624', '瑞穗乡', '', '3', '712600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712625', '万荣乡', '', '3', '712600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712626', '玉里镇', '', '3', '712600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712627', '卓溪乡', '', '3', '712600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712628', '富里乡', '', '3', '712600', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712700', '澎湖县', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712707', '马公市', '', '3', '712700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712708', '西屿乡', '', '3', '712700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712709', '望安乡', '', '3', '712700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712710', '七美乡', '', '3', '712700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712711', '白沙乡', '', '3', '712700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712712', '湖西乡', '', '3', '712700', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712800', '连江县', '', '2', '710000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712805', '南竿乡', '', '3', '712800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712806', '北竿乡', '', '3', '712800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712807', '莒光乡', '', '3', '712800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('712808', '东引乡', '', '3', '712800', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810000', '香港特别行政区', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810100', '香港岛', '', '2', '810000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810101', '中西区', '', '3', '810100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810102', '湾仔', '', '3', '810100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810103', '东区', '', '3', '810100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810104', '南区', '', '3', '810100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810200', '九龙', '', '2', '810000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810201', '九龙城区', '', '3', '810200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810202', '油尖旺区', '', '3', '810200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810203', '深水埗区', '', '3', '810200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810204', '黄大仙区', '', '3', '810200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810205', '观塘区', '', '3', '810200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810300', '新界', '', '2', '810000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810301', '北区', '', '3', '810300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810302', '大埔区', '', '3', '810300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810303', '沙田区', '', '3', '810300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810304', '西贡区', '', '3', '810300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810305', '元朗区', '', '3', '810300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810306', '屯门区', '', '3', '810300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810307', '荃湾区', '', '3', '810300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810308', '葵青区', '', '3', '810300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('810309', '离岛区', '', '3', '810300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('820000', '澳门特别行政区', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('820100', '澳门半岛', '', '2', '820000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('820200', '离岛', '', '2', '820000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('990000', '海外', '', '1', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('990100', '海外', '', '2', '990000', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881001', '沁园街道', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881002', '济水街道', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881003', '北海街道', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881004', '天坛街道', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881005', '玉泉街道', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881006', '克井镇', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881007', '五龙口镇', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881008', '轵城镇', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881009', '承留镇', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881010', '邵原镇', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881011', '坡头镇', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881012', '梨林镇', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881013', '大峪镇', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881014', '思礼镇', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881015', '王屋镇', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('410881016', '下冶镇', '', '3', '410881', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004001', '沙嘴街道', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004002', '干河街道', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004003', '龙华山办事处', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004004', '郑场镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004005', '毛嘴镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004006', '豆河镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004007', '三伏潭镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004008', '胡场镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004009', '长倘口镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004010', '西流河镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004011', '沙湖镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004012', '杨林尾镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004013', '彭场镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004014', '张沟镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004015', '郭河镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004016', '沔城回族镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004017', '通海口镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004018', '陈场镇', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004019', '工业园区', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004020', '九合垸原种场', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004021', '沙湖原种场', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004022', '五湖渔场', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004023', '赵西垸林场', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004024', '畜禽良种场', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429004025', '排湖风景区', '', '3', '429004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005001', '园林办事处', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005002', '杨市办事处', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005003', '周矶办事处', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005004', '广华办事处', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005005', '泰丰办事处', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005006', '高场办事处', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005007', '竹根滩镇', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005008', '渔洋镇', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005009', '王场镇', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005010', '高石碑镇', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005011', '熊口镇', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005012', '老新镇', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005013', '浩口镇', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005014', '积玉口镇', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005015', '张金镇', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005016', '龙湾镇', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005017', '江汉石油管理局', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005018', '潜江经济开发区', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005019', '周矶管理区', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005020', '后湖管理区', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005021', '熊口管理区', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005022', '总口管理区', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005023', '白鹭湖管理区', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005024', '运粮湖管理区', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429005025', '浩口原种场', '', '3', '429005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006001', '竟陵街道', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006002', '侨乡街道开发区', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006003', '杨林街道', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006004', '多宝镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006005', '拖市镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006006', '张港镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006007', '蒋场镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006008', '汪场镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006009', '渔薪镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006010', '黄潭镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006011', '岳口镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006012', '横林镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006013', '彭市镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006014', '麻洋镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006015', '多祥镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006016', '干驿镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006017', '马湾镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006018', '卢市镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006019', '小板镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006020', '九真镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006021', '皂市镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006022', '胡市镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006023', '石河镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006024', '佛子山镇', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006025', '净潭乡', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006026', '蒋湖农场', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006027', '白茅湖农场', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429006028', '沉湖管委会', '', '3', '429006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429021001', '松柏镇', '', '3', '429021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429021002', '阳日镇', '', '3', '429021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429021003', '木鱼镇', '', '3', '429021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429021004', '红坪镇', '', '3', '429021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429021005', '新华镇', '', '3', '429021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429021006', '九湖镇', '', '3', '429021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429021007', '宋洛乡', '', '3', '429021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('429021008', '下谷坪土家族乡', '', '3', '429021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469001001', '通什镇', '', '3', '469001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469001002', '南圣镇', '', '3', '469001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469001003', '毛阳镇', '', '3', '469001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469001004', '番阳镇', '', '3', '469001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469001005', '畅好乡', '', '3', '469001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469001006', '毛道乡', '', '3', '469001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469001007', '水满乡', '', '3', '469001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469001008', '国营畅好农场', '', '3', '469001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002001', '嘉积镇', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002002', '万泉镇', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002003', '石壁镇', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002004', '中原镇', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002005', '博鳌镇', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002006', '阳江镇', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002007', '龙江镇', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002008', '潭门镇', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002009', '塔洋镇', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002010', '长坡镇', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002011', '大路镇', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002012', '会山镇', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002013', '国营东太农场', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002014', '国营东红农场', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002015', '国营东升农场', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469002016', '彬村山华侨农场', '', '3', '469002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003001', '那大镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003002', '和庆镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003003', '南丰镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003004', '大成镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003005', '雅星镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003006', '兰洋镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003007', '光村镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003008', '木棠镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003009', '海头镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003010', '峨蔓镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003011', '三都镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003012', '王五镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003013', '白马井镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003014', '中和镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003015', '排浦镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003016', '东成镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003017', '新州镇', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003018', '国营西培农场', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003019', '国营西联农场', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003020', '国营蓝洋农场', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003021', '国营八一农场', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003022', '洋浦经济开发区', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469003023', '华南热作学院', '', '3', '469003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005001', '文城镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005002', '重兴镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005003', '蓬莱镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005004', '会文镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005005', '东路镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005006', '潭牛镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005007', '东阁镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005008', '文教镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005009', '东郊镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005010', '龙楼镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005011', '昌洒镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005012', '翁田镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005013', '抱罗镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005014', '冯坡镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005015', '锦山镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005016', '铺前镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005017', '公坡镇', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005018', '国营东路农场', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005019', '国营南阳农场', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469005020', '国营罗豆农场', '', '3', '469005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469007001', '八所镇', '', '3', '469007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469007002', '东河镇', '', '3', '469007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469007003', '大田镇', '', '3', '469007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469007004', '感城镇', '', '3', '469007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469007005', '板桥镇', '', '3', '469007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469007006', '三家镇', '', '3', '469007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469007007', '四更镇', '', '3', '469007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469007008', '新龙镇', '', '3', '469007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469007009', '天安乡', '', '3', '469007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469007010', '江边乡', '', '3', '469007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469007011', '国营广坝农场', '', '3', '469007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469007012', '东方华侨农场', '', '3', '469007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469025001', '定城镇', '', '3', '469025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469025002', '新竹镇', '', '3', '469025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469025003', '龙湖镇', '', '3', '469025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469025004', '黄竹镇', '', '3', '469025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469025005', '雷鸣镇', '', '3', '469025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469025006', '龙门镇', '', '3', '469025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469025007', '龙河镇', '', '3', '469025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469025008', '岭口镇', '', '3', '469025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469025009', '翰林镇', '', '3', '469025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469025010', '富文镇', '', '3', '469025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469025011', '国营中瑞农场', '', '3', '469025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469025012', '国营南海农场', '', '3', '469025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469025013', '国营金鸡岭农场', '', '3', '469025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469026001', '屯城镇', '', '3', '469026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469026002', '新兴镇', '', '3', '469026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469026003', '枫木镇', '', '3', '469026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469026004', '乌坡镇', '', '3', '469026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469026005', '南吕镇', '', '3', '469026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469026006', '南坤镇', '', '3', '469026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469026007', '坡心镇', '', '3', '469026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469026008', '西昌镇', '', '3', '469026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469026009', '国营中建农场', '', '3', '469026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469026010', '国营中坤农场', '', '3', '469026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469028001', '临城镇', '', '3', '469028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469028002', '波莲镇', '', '3', '469028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469028003', '东英镇', '', '3', '469028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469028004', '博厚镇', '', '3', '469028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469028005', '皇桐镇', '', '3', '469028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469028006', '多文镇', '', '3', '469028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469028007', '和舍镇', '', '3', '469028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469028008', '南宝镇', '', '3', '469028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469028009', '新盈镇', '', '3', '469028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469028010', '调楼镇', '', '3', '469028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469028011', '国营红华农场', '', '3', '469028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469028012', '国营加来农场', '', '3', '469028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030001', '牙叉镇', '', '3', '469030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030002', '七坊镇', '', '3', '469030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030003', '邦溪镇', '', '3', '469030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030004', '打安镇', '', '3', '469030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030005', '细水乡', '', '3', '469030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030006', '元门乡', '', '3', '469030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030007', '南开乡', '', '3', '469030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030008', '阜龙乡', '', '3', '469030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030009', '青松乡', '', '3', '469030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030010', '金波乡', '', '3', '469030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030011', '荣邦乡', '', '3', '469030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030012', '国营白沙农场', '', '3', '469030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030013', '国营龙江农场', '', '3', '469030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469030014', '国营邦溪农场', '', '3', '469030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469031001', '石碌镇', '', '3', '469031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469031002', '叉河镇', '', '3', '469031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469031003', '十月田镇', '', '3', '469031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469031004', '乌烈镇', '', '3', '469031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469031005', '昌化镇', '', '3', '469031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469031006', '海尾镇', '', '3', '469031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469031007', '七叉镇', '', '3', '469031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469031008', '王下乡', '', '3', '469031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469031009', '国营红林农场', '', '3', '469031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469031010', '国营霸王岭林场', '', '3', '469031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469031011', '海南矿业联合有限公司', '', '3', '469031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033001', '抱由镇', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033002', '万冲镇', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033003', '大安镇', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033004', '志仲镇', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033005', '千家镇', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033006', '九所镇', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033007', '利国镇', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033008', '黄流镇', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033009', '佛罗镇', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033010', '尖峰镇', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033011', '莺歌海镇', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033012', '国营山荣农场', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033013', '国营乐光农场', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033014', '国营保国农场', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033015', '国营尖峰岭林业公司', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469033016', '国营莺歌海盐场', '', '3', '469033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034001', '椰林镇', '', '3', '469034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034002', '光坡镇', '', '3', '469034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034003', '三才镇', '', '3', '469034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034004', '英州镇', '', '3', '469034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034005', '隆广镇', '', '3', '469034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034006', '文罗镇', '', '3', '469034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034007', '本号镇', '', '3', '469034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034008', '新村镇', '', '3', '469034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034009', '黎安镇', '', '3', '469034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034010', '提蒙乡', '', '3', '469034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034011', '群英乡', '', '3', '469034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034012', '国营岭门农场', '', '3', '469034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034013', '国营南平农场', '', '3', '469034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469034014', '国营吊罗山林业公司', '', '3', '469034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469035001', '保城镇', '', '3', '469035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469035002', '什玲镇', '', '3', '469035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469035003', '加茂镇', '', '3', '469035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469035004', '响水镇', '', '3', '469035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469035005', '新政镇', '', '3', '469035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469035006', '三道镇', '', '3', '469035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469035007', '六弓乡', '', '3', '469035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469035008', '南林乡', '', '3', '469035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469035009', '毛感乡', '', '3', '469035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469035010', '国营新星农场', '', '3', '469035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469035011', '海南保亭热带作物研究所', '', '3', '469035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469035012', '国营金江农场', '', '3', '469035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469035013', '国营三道农场', '', '3', '469035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036001', '营根镇', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036002', '湾岭镇', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036003', '黎母山镇', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036004', '和平镇', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036005', '长征镇', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036006', '红毛镇', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036007', '中平镇', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036008', '吊罗山乡', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036009', '上安乡', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036010', '什运乡', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036011', '国营阳江农场', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036012', '国营乌石农场', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036013', '国营加钗农场', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036014', '国营长征农场', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469036015', '国营黎母山林业公司', '', '3', '469036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469037001', '永兴岛', '', '3', '469037', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469038001', '永暑岛', '', '3', '469038', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('469039001', '中沙岛礁', '', '3', '469039', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659001001', '新城街道', '', '3', '659001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659001002', '向阳街道', '', '3', '659001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659001003', '红山街道', '', '3', '659001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659001004', '老街街道', '', '3', '659001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659001005', '东城街道', '', '3', '659001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659001006', '北泉镇', '', '3', '659001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659001007', '石河子乡', '', '3', '659001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659001008', '兵团一五二团', '', '3', '659001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002001', '金银川路街道', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002002', '幸福路街道', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002003', '青松路街道', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002004', '南口街道', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002005', '托喀依乡', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002006', '工业园区', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002007', '兵团七团', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002008', '兵团八团', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002009', '兵团十团', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002010', '兵团十一团', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002011', '兵团十二团', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002012', '兵团十三团', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002013', '兵团十四团', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002014', '兵团十六团', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002015', '兵团第一师水利水电工程处', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002016', '兵团第一师塔里木灌区水利管理处', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002017', '阿拉尔农场', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002018', '兵团第一师幸福农场', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659002019', '中心监狱', '', '3', '659002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659003001', '齐干却勒街道', '', '3', '659003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659003002', '前海街道', '', '3', '659003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659003003', '永安坝街道', '', '3', '659003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659003004', '兵团四十四团', '', '3', '659003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659003005', '兵团四十九团', '', '3', '659003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659003006', '兵团五十团', '', '3', '659003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659003007', '兵团五十一团', '', '3', '659003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659003008', '兵团五十三团', '', '3', '659003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659003009', '兵团图木舒克市喀拉拜勒镇', '', '3', '659003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659003010', '兵团图木舒克市永安坝', '', '3', '659003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659004001', '军垦路街道', '', '3', '659004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659004002', '青湖路街道', '', '3', '659004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659004003', '人民路街道', '', '3', '659004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659004004', '兵团一零一团', '', '3', '659004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659004005', '兵团一零二团', '', '3', '659004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('659004006', '兵团一零三团', '', '3', '659004', '0', null, null, null, null);

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
) ENGINE=InnoDB AUTO_INCREMENT=76 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of m_code
-- ----------------------------
INSERT INTO `m_code` VALUES ('1', '1', null, null, null, null, '包装类型', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('2', '1', '1', '瓶装', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('3', '1', '2', '袋装', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('4', '1', '3', '听装', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('5', '1', '4', '桶装', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('6', '1', '5', '箱装', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('7', '1', '6', '其他', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('8', '2', null, null, null, null, '产品形态', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('9', '2', '1', '液体', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('10', '2', '2', '颗粒', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('11', '2', '3', '粉末', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('12', '2', '4', '胶质', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('13', '2', '5', '气体', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('14', '2', '6', '其他', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('15', '3', null, null, null, null, '重量单位', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('16', '3', '1', '克', '1', null, 'value2为【克】的相对值', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('17', '3', '2', '毫克', '0.001', null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('18', '3', '3', '千克', '1000', null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('19', '3', '4', '吨', '1000000', null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('20', '4', null, null, null, null, '角色类型', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('21', '4', '1', '销售', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('22', '4', '2', '采购', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('23', '4', '3', '财务', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('24', '4', '99', '系统管理', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('25', '5', null, null, null, null, '结算方式', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('26', '5', '1', '现金', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('27', '5', '2', '现金支票', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('28', '5', '3', '转帐支票', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('29', '5', '4', '电汇', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('30', '5', '5', '银行汇票', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('31', '5', '6', '承兑汇票', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('32', '5', '7', '网上银行', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('33', '5', '8', '其他方式', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('34', '6', null, null, null, null, '支付状态', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('35', '6', '1', '未支付', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('36', '6', '2', '部分支付', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('37', '6', '3', '全部支付', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('38', '7', null, null, null, null, '销售订单状态', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('39', '7', '1', '待确认', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('40', '7', '2', '生产中', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('41', '7', '3', '待配送', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('42', '7', '4', '已完成', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('43', '7', '5', '财务取消', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('44', '8', null, null, null, null, '运输方式', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('45', '8', '1', '快递公司', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('46', '8', '2', '公司运输', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('47', '8', '3', '货运公司', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('48', '8', '4', '客户自提', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('49', '8', '5', '其他情况', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('50', '9', null, null, null, null, '商品入库类别', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('51', '9', '1', '生产', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('52', '9', '2', '退回', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('53', '9', '3', '其他', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('54', '10', null, null, null, null, '原料入库类别', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('55', '10', '1', '采购', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('56', '10', '2', '退回', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('57', '10', '3', '其他', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('58', '11', null, null, null, null, '生产订单状态', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('59', '11', '1', '生产中', '', '', '', '0', null, null, 'admin', '2017-02-23 14:54:06');
INSERT INTO `m_code` VALUES ('60', '11', '2', '采购中', '', '', '', '0', null, null, 'admin', '2017-02-23 14:54:06');
INSERT INTO `m_code` VALUES ('61', '11', '3', '已生产', '', '', '', '0', null, null, 'admin', '2017-02-23 14:54:06');
INSERT INTO `m_code` VALUES ('62', '11', '4', '已入库', '', '', '', '0', null, null, 'admin', '2017-02-23 14:54:06');
INSERT INTO `m_code` VALUES ('63', '12', null, null, null, null, '采购订单状态', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('64', '12', '1', '财务待确认', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('65', '12', '2', '财务已确认', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('66', '12', '3', '原料已入库', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('67', '12', '4', '财务已取消', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('68', '13', null, null, null, null, '收款状态', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('69', '13', '1', '未收款', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('70', '13', '2', '部分收款', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('71', '13', '3', '收款完成', null, null, null, '0', null, null, null, null);

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
INSERT INTO `m_factory` VALUES ('1', '上海工厂', 'address1', '11111111', '', '22222222', '', '2000000', '0', 'admin', '2016-11-19 17:45:34', 'admin', '2017-02-09 15:21:29');
INSERT INTO `m_factory` VALUES ('2', '浙江工厂', 'address2', '', '', '', '', '', '0', 'admin', '2016-11-19 20:13:53', 'admin', '2017-02-09 15:21:41');
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
  `iconPath` varchar(100) DEFAULT NULL COMMENT '图标文件',
  `sort` int(11) DEFAULT NULL COMMENT '排序',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`menuId`)
) ENGINE=InnoDB AUTO_INCREMENT=903 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of m_menu
-- ----------------------------
INSERT INTO `m_menu` VALUES ('1', '0', '系统设置', '', 'chk_sys', 'icon\\\\sys.png', '1', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('2', '0', '产品管理', '', 'chk_product', 'icon\\\\product.png', '2', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('3', '0', '销售管理', '', 'chk_sale', 'icon\\\\sale.png', '3', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('4', '0', '库存管理', '', 'chk_store', 'icon\\\\store.png', '4', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('5', '0', '生产管理', '', 'chk_produce', 'icon\\\\produce.png', '5', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('6', '0', '采购管理', '', 'chk_purchase', 'icon\\\\purchase.png', '6', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('7', '0', '财务管理', '', 'chk_finance', 'icon\\\\finance.png', '7', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('9', '0', '退出', '', null, null, '9', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('101', '1', '用户管理', 'PMS.Frm.Sys.FrmSysUser', 'chk_sys_user', 'icon\\\\sys-user.png', '101', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('102', '1', '角色管理', 'PMS.Frm.Sys.FrmSysRole', 'chk_sys_role', 'icon\\\\sys-role.png', '102', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('103', '1', '工厂管理', 'PMS.Frm.Sys.FrmSysFactory', 'chk_sys_factory', 'icon\\\\sys-factory.png', '103', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('104', '1', '公司信息', 'PMS.Frm.Sys.FrmSysCompany', 'chk_sys_company', 'icon\\\\sys-company.png', '104', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('105', '1', '系统设置', 'PMS.Frm.Sys.FrmSysConfig', 'chk_sys_config', null, '105', '1', null, null, null, null);
INSERT INTO `m_menu` VALUES ('201', '2', '产品查询', 'PMS.Frm.Product.FrmProductQuery', 'chk_product_query', 'icon\\\\product-search.png', '201', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('202', '2', '产品管理', 'PMS.Frm.Product.FrmProductManage', 'chk_product_set', 'icon\\\\product-list.png', '202', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('203', '2', '物料管理', 'PMS.Frm.Product.FrmMaterialsManage', 'chk_purchase_materials', 'icon\\\\product-material.png', '203', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('301', '3', '客户管理', 'PMS.Frm.Sale.FrmCustomerManage', 'chk_sale_customer', 'icon\\\\sale-customer.png', '301', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('302', '3', '订单管理', 'PMS.Frm.Sale.FrmOrderManage', 'chk_sale_order', 'icon\\\\sale-order.png', '302', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('401', '4', '产品入库', 'PMS.Frm.Store.FrmProductIn', 'chk_store_product_in', 'icon\\\\store-product-in.png', '401', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('402', '4', '产品出库', 'PMS.Frm.Store.FrmProductOut', 'chk_store_product_out', 'icon\\\\store-product-out.png', '402', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('403', '4', '调拨管理', 'PMS.Frm.Store.FrmTransfer', 'chk_store_transfer', null, '406', '1', null, null, null, null);
INSERT INTO `m_menu` VALUES ('404', '4', '物料入库', 'PMS.Frm.Store.FrmMaterialsIn', 'chk_store_materials_in', 'icon\\\\store-materials-in.png', '404', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('405', '4', '物料出库', 'PMS.Frm.Store.FrmMaterialsOut', 'chk_store_materials_out', 'icon\\\\store-materials-out.png', '405', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('406', '4', '库存盘点', 'PMS.Frm.Store.FrmInventory', 'chk_store_nventory', 'icon\\\\store-inventory.png', '407', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('501', '5', '生产计划', 'PMS.Frm.Produce.FrmProducePlan', 'chk_produce_plan', 'icon\\\\produce-plan.png', '501', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('502', '5', '生产管理', 'PMS.Frm.Produce.FrmProduceManage', 'chk_produce_manage', 'icon\\\\produce-list.png', '502', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('601', '6', '采购计划', 'PMS.Frm.Purchase.FrmPurchasePlan', 'chk_purchase_plan', 'icon\\\\purchase-plan.png', '601', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('602', '6', '采购管理', 'PMS.Frm.Purchase.FrmPurchaseManage', 'chk_purchase_manage', 'icon\\\\purchase-list.png', '602', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('603', '6', '供应商管理', 'PMS.Frm.Sale.FrmCustomerManage', 'chk_purchase_provider', 'icon\\\\sale-customer.png', '603', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('701', '7', '销售订单', 'PMS.Frm.Finance.FrmSaleOrder', 'chk_finance_sale', 'icon\\\\finance-sale.png', '701', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('702', '7', '采购订单', 'PMS.Frm.Finance.FrmPurchaseOrder', 'chk_finance_purchase', 'icon\\\\finance-purchase.png', '702', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('703', '7', '应收款', 'PMS.Frm.Finance.FrmReceived', 'chk_finance_receive', 'icon\\\\finance-received.png', '703', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('704', '7', '应付款', 'PMS.Frm.Finance.FrmPaid', 'chk_finance_paid', 'icon\\\\finance-paid.png', '704', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('901', '9', '返回主菜单', 'PMS.Frm.Main.FrmMain', null, null, '901', '0', null, null, null, null);
INSERT INTO `m_menu` VALUES ('902', '9', '返回登录页', 'PMS.Frm.Login.FrmLogin', null, null, '902', '0', null, null, null, null);

-- ----------------------------
-- Table structure for m_role
-- ----------------------------
DROP TABLE IF EXISTS `m_role`;
CREATE TABLE `m_role` (
  `roleId` int(11) NOT NULL AUTO_INCREMENT,
  `roleName` varchar(50) DEFAULT NULL,
  `roleType` int(11) DEFAULT NULL COMMENT '角色类型（1：销售；2：采购；3：财务）',
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
INSERT INTO `m_role` VALUES ('1', '系统管理', '99', '0', null, '2016-11-29 21:13:06', 'admin', '2016-12-21 16:18:01');
INSERT INTO `m_role` VALUES ('2', '商品管理', '0', '0', null, '2016-11-29 21:13:06', 'admin', '2017-02-18 12:49:25');
INSERT INTO `m_role` VALUES ('3', '销售管理', '1', '0', null, '2016-11-29 21:13:06', 'admin', '2016-12-21 13:55:08');
INSERT INTO `m_role` VALUES ('4', '仓库管理', '0', '0', null, '2016-11-29 21:13:06', 'admin', '2017-02-18 12:47:02');
INSERT INTO `m_role` VALUES ('5', '生产管理', '0', '0', null, '2016-11-29 21:13:06', 'admin', '2017-01-24 10:36:24');
INSERT INTO `m_role` VALUES ('6', '采购管理', '2', '0', null, '2016-11-29 21:13:06', 'admin', '2017-02-03 15:07:14');
INSERT INTO `m_role` VALUES ('7', '财务管理', '3', '0', null, '2016-11-29 21:13:06', 'admin', '2017-02-22 10:03:56');
INSERT INTO `m_role` VALUES ('8', '测试角色1', null, '1', 'admin', '2016-11-29 21:34:21', 'admin', '2016-11-29 21:40:46');

-- ----------------------------
-- Table structure for m_sequence
-- ----------------------------
DROP TABLE IF EXISTS `m_sequence`;
CREATE TABLE `m_sequence` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `key` varchar(255) DEFAULT NULL COMMENT '键',
  `sequence` int(255) DEFAULT NULL COMMENT '序号',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of m_sequence
-- ----------------------------

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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of m_user
-- ----------------------------
INSERT INTO `m_user` VALUES ('1', 'admin', 'admin', '1', '', 'boss', '1333333333', 'admin@admin.com', '2016-11-01', '0', 'sys', '2016-11-01 14:35:26', 'admin', '2017-02-15 16:37:33');
INSERT INTO `m_user` VALUES ('2', 'sp1', 'admin', '2', '', '', '', '', '2016-11-17', '0', 'admin', '2016-11-17 15:57:48', 'admin', '2017-01-03 15:43:53');
INSERT INTO `m_user` VALUES ('3', 'xs2', 'admin', '3', '', '', '', '', '2016-12-21', '0', 'admin', '2016-12-21 13:56:01', 'admin', '2017-01-03 15:43:44');
INSERT INTO `m_user` VALUES ('4', 'xs1', 'admin', '3', '', '', '', '', '2016-12-21', '0', 'admin', '2016-12-21 14:53:04', 'admin', '2017-01-03 15:44:04');
INSERT INTO `m_user` VALUES ('5', 'cw1', 'admin', '7', '', '', '', '', '2016-12-21', '0', 'admin', '2016-12-21 16:05:48', 'admin', '2017-01-03 15:44:23');
INSERT INTO `m_user` VALUES ('6', 'ck1', 'admin', '4', '', '', '', '', '2017-01-03', '0', 'admin', '2017-01-03 10:53:03', 'admin', '2017-01-03 15:44:14');
INSERT INTO `m_user` VALUES ('7', 'sc1', 'admin', '5', '', '', '', '', '2017-01-24', '0', 'admin', '2017-01-24 10:34:58', 'admin', '2017-01-24 10:34:58');
INSERT INTO `m_user` VALUES ('8', 'cg1', 'admin', '6', '', '', '', '', '2017-02-03', '0', 'admin', '2017-02-03 14:23:30', 'admin', '2017-02-03 14:23:30');

-- ----------------------------
-- Table structure for p_customer
-- ----------------------------
DROP TABLE IF EXISTS `p_customer`;
CREATE TABLE `p_customer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(50) DEFAULT NULL COMMENT '客户代码',
  `name` varchar(100) DEFAULT NULL COMMENT '客户名称',
  `country` varchar(10) DEFAULT NULL COMMENT '国家',
  `province` int(10) DEFAULT NULL COMMENT '省',
  `provinceName` varchar(30) DEFAULT NULL COMMENT '省名',
  `city` int(10) DEFAULT NULL COMMENT '市',
  `cityName` varchar(30) DEFAULT NULL COMMENT '市名',
  `district` int(10) DEFAULT NULL COMMENT '区',
  `districtName` varchar(30) DEFAULT NULL COMMENT '区名',
  `address` varchar(300) DEFAULT NULL COMMENT '客户地址',
  `zip` varchar(20) DEFAULT NULL COMMENT '邮编',
  `fax` varchar(20) DEFAULT NULL COMMENT '传真',
  `telephone1` varchar(30) DEFAULT NULL,
  `telephone2` varchar(30) DEFAULT NULL,
  `manager` varchar(20) DEFAULT NULL COMMENT '负责人姓名',
  `position` varchar(20) DEFAULT NULL COMMENT '负责人职位',
  `mobile` varchar(30) DEFAULT NULL COMMENT '负责人电话',
  `type` int(11) DEFAULT NULL COMMENT '客户类型（1：销售客户；2：供应商）',
  `salerId` int(11) DEFAULT NULL COMMENT '销售',
  `remark` varchar(255) DEFAULT NULL,
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of p_customer
-- ----------------------------
INSERT INTO `p_customer` VALUES ('1', 'sc0001', '销售客户1', '', '101', '北京市', '1001', '北京市', '10001', '东城区', 'test address1', '200000', '20001', '10001', '10002', 'Kevin', 'Boss', '110', '1', '3', 'null', '0', 'admin', '2016-12-21 14:49:32', 'admin', '2016-12-21 14:51:51');
INSERT INTO `p_customer` VALUES ('2', 'sc002', 'sale customer 2', '', '104', '山西省', '1016', '阳泉市', '10232', '郊区', 'test address 2', '', '', '', '', '', '', '', '1', '4', '', '1', 'saler2', '2016-12-21 14:54:05', 'admin', '2016-12-21 15:04:43');
INSERT INTO `p_customer` VALUES ('3', 'cs002', '销售客户2', '', '110000', '北京', '110100', '北京市', '110102', '西城区', '测试地址2', '', '', '11111111111111', '111111111111111111', '', '', '', '1', '4', '', '0', 'xs1', '2017-01-22 15:26:41', 'cw1', '2017-02-21 22:12:48');
INSERT INTO `p_customer` VALUES ('4', 'gys1', '供应商1', '', '310000', '上海', '310100', '上海市', '310101', '黄浦区', '供应商1地址', '2', '1', '111111111111111', '', 'BOSS', 'BOSS', '', '2', '0', '', '0', 'cg1', '2017-02-06 14:05:06', 'cg1', '2017-02-06 16:42:06');
INSERT INTO `p_customer` VALUES ('5', 'sc003', '销售客户3', '', '310000', '上海', '310100', '上海市', '310115', '浦东新区', '沪南公路8888号', '', '', '888888888', '', '', '', '', '1', '4', '', '0', 'xs1', '2017-02-17 15:58:28', 'cw1', '2017-02-23 09:46:04');

-- ----------------------------
-- Table structure for p_finance_paid
-- ----------------------------
DROP TABLE IF EXISTS `p_finance_paid`;
CREATE TABLE `p_finance_paid` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `customerId` int(11) DEFAULT NULL COMMENT '供应商ID',
  `factoryId` int(11) DEFAULT NULL COMMENT '库房ID',
  `materialsId` int(11) DEFAULT NULL COMMENT '商品ID',
  `num` decimal(10,2) DEFAULT NULL COMMENT '数量',
  `unit` int(11) DEFAULT NULL COMMENT '单位',
  `orderPrice` decimal(10,2) DEFAULT NULL COMMENT '应付金额',
  `purchaseCode` varchar(100) DEFAULT NULL COMMENT '采购单号',
  `purchaseBy` varchar(50) DEFAULT NULL COMMENT '采购人',
  `purchaseDate` datetime DEFAULT NULL COMMENT '采购日期',
  `paidPrice` decimal(10,2) DEFAULT NULL COMMENT '已支付金额',
  `paidStatus` int(11) DEFAULT '0' COMMENT '支付状态（code：6）',
  `remark` varchar(200) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of p_finance_paid
-- ----------------------------

-- ----------------------------
-- Table structure for p_finance_receive
-- ----------------------------
DROP TABLE IF EXISTS `p_finance_receive`;
CREATE TABLE `p_finance_receive` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `customerId` int(11) DEFAULT NULL COMMENT '供应商ID',
  `factoryId` int(11) DEFAULT NULL COMMENT '库房ID',
  `orderCode` varchar(100) DEFAULT NULL COMMENT '销售单号',
  `orderPrice` decimal(10,2) DEFAULT NULL COMMENT '应收金额',
  `salerId` int(11) DEFAULT NULL COMMENT '销售ID',
  `financeId` int(11) DEFAULT NULL COMMENT '财务ID',
  `deliveryDate` datetime DEFAULT NULL COMMENT '交货日期',
  `receivedPrice` decimal(10,2) DEFAULT NULL COMMENT '已收金额',
  `receivedStatus` int(11) DEFAULT '0' COMMENT '收款状态（0：未收款；1：收款未完成；2：已完成）',
  `remark` varchar(200) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of p_finance_receive
-- ----------------------------

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
  `weight` decimal(10,2) DEFAULT NULL COMMENT '重量',
  `weightUnit` int(11) DEFAULT NULL COMMENT '重量单位（Code=003）',
  `morphology` int(10) DEFAULT NULL COMMENT '产品形态（Code=002）',
  `shelfLife` int(11) DEFAULT NULL COMMENT '保质期（天）',
  `expiredDays` int(11) DEFAULT NULL COMMENT '过期提醒天数',
  `minStockNum` int(11) DEFAULT NULL COMMENT '最少库存提醒数',
  `type` int(11) DEFAULT NULL COMMENT '原料种类（0：一般原料；1：自制原料；2：其他）',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of p_materials
-- ----------------------------

-- ----------------------------
-- Table structure for p_materials_input
-- ----------------------------
DROP TABLE IF EXISTS `p_materials_input`;
CREATE TABLE `p_materials_input` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `inputCode` varchar(100) DEFAULT NULL COMMENT '入库单号',
  `factoryId` int(11) DEFAULT NULL COMMENT '库房ID',
  `materialsId` int(11) DEFAULT NULL COMMENT '商品ID',
  `inputNum` decimal(10,2) DEFAULT NULL COMMENT '入库数量',
  `inputUnit` int(11) DEFAULT NULL COMMENT '入库单位',
  `stockNum` decimal(10,2) DEFAULT NULL COMMENT '库存数',
  `produceDate` datetime DEFAULT NULL COMMENT '生产日期',
  `expiresDate` datetime DEFAULT NULL COMMENT '过期日期',
  `customerId` int(11) DEFAULT NULL COMMENT '供应商ID',
  `purchaseCode` varchar(100) DEFAULT NULL COMMENT '采购编号',
  `purchaseBy` varchar(50) DEFAULT NULL COMMENT '采购员',
  `purchaseDate` datetime DEFAULT NULL COMMENT '采购日期',
  `purchaseNum` decimal(10,2) DEFAULT NULL COMMENT '采购数量',
  `purchaseUnit` int(11) DEFAULT NULL COMMENT '采购单位',
  `inputType` int(11) DEFAULT NULL COMMENT '入库类型（code::10）',
  `inputStatus` int(11) DEFAULT NULL COMMENT '状态（0：请求入库；1：完成入库）',
  `inputDate` datetime DEFAULT NULL COMMENT '入库日期',
  `remark` varchar(200) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of p_materials_input
-- ----------------------------

-- ----------------------------
-- Table structure for p_materials_output
-- ----------------------------
DROP TABLE IF EXISTS `p_materials_output`;
CREATE TABLE `p_materials_output` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `outputCode` varchar(30) DEFAULT NULL COMMENT '出库ID',
  `produceCode` varchar(100) DEFAULT NULL COMMENT '生产单号',
  `factoryId` int(11) DEFAULT NULL COMMENT '仓库ID',
  `materialsId` int(11) DEFAULT NULL COMMENT '商品ID',
  `outputNum` decimal(10,2) DEFAULT NULL COMMENT '出库数量',
  `outputUnit` int(11) DEFAULT NULL COMMENT '出库数量单位',
  `outputStatus` int(11) DEFAULT NULL COMMENT '状态（0：请求出库；1：完成出库）',
  `outputDate` datetime DEFAULT NULL COMMENT '完成出库时间',
  `outputType` int(11) DEFAULT NULL COMMENT '出库单类型（0：生产订单；1：特殊申请）',
  `applyMemberId` int(11) DEFAULT NULL COMMENT '申请者ID',
  `applyDate` datetime DEFAULT NULL COMMENT '申请日期',
  `realityOutputNum` decimal(10,2) DEFAULT NULL,
  `remark` varchar(255) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of p_materials_output
-- ----------------------------

-- ----------------------------
-- Table structure for p_produce
-- ----------------------------
DROP TABLE IF EXISTS `p_produce`;
CREATE TABLE `p_produce` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `produceCode` varchar(100) DEFAULT NULL,
  `factoryId` int(11) DEFAULT NULL COMMENT '库房ID',
  `productId` int(11) DEFAULT NULL COMMENT '产品ID',
  `num` int(11) DEFAULT NULL COMMENT '生产数量',
  `deliveryDate` datetime DEFAULT NULL COMMENT '交货日期',
  `status` int(11) DEFAULT NULL COMMENT '状态（1：生产中；2：原料采购中；3：待入库；4：完成）',
  `applyBy` varchar(100) DEFAULT NULL COMMENT '申请者',
  `applyDate` datetime DEFAULT NULL COMMENT '申请日期',
  `remark` varchar(255) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of p_produce
-- ----------------------------

-- ----------------------------
-- Table structure for p_produce_apply
-- ----------------------------
DROP TABLE IF EXISTS `p_produce_apply`;
CREATE TABLE `p_produce_apply` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `factoryId` int(11) DEFAULT NULL COMMENT '库房ID',
  `productId` int(11) DEFAULT NULL COMMENT '产品ID',
  `num` int(11) DEFAULT NULL COMMENT '生产数量',
  `saleOrderCode` varchar(100) DEFAULT NULL COMMENT '销售订单编号',
  `outputCode` varchar(100) DEFAULT NULL COMMENT '出库单编号',
  `deliveryDate` datetime DEFAULT NULL COMMENT '交货日期',
  `applyType` int(11) DEFAULT NULL COMMENT '申请类型（0：销售订单；1：特殊申请）',
  `applyBy` varchar(100) DEFAULT NULL COMMENT '申请者',
  `applyDate` datetime DEFAULT NULL COMMENT '申请日期',
  `produceCode` varchar(100) DEFAULT NULL COMMENT '生产单号',
  `status` int(11) DEFAULT NULL COMMENT '状态（0：未确认；1：已确认；2：已取消）',
  `remark` varchar(255) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of p_produce_apply
-- ----------------------------

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
  `weight` decimal(10,2) DEFAULT NULL COMMENT '重量',
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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of p_product
-- ----------------------------
INSERT INTO `p_product` VALUES ('4', '商品1', '', '1', '', '1.00', '3', '1', '100', '10', '1', '0', 'admin', '2016-12-08 16:59:48', 'admin', '2017-02-17 16:46:10');
INSERT INTO `p_product` VALUES ('7', '商品2', '', '3', '', '2.00', '3', '3', '200', '20', '2', '0', 'admin', '2016-12-13 21:43:45', 'admin', '2017-02-17 12:02:05');

-- ----------------------------
-- Table structure for p_product_input
-- ----------------------------
DROP TABLE IF EXISTS `p_product_input`;
CREATE TABLE `p_product_input` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `inputCode` varchar(100) DEFAULT NULL COMMENT '入库单号',
  `factoryId` int(11) DEFAULT NULL COMMENT '库房ID',
  `productId` int(11) DEFAULT NULL COMMENT '商品ID',
  `inputNum` int(11) DEFAULT NULL COMMENT '数量',
  `stockNum` int(11) DEFAULT NULL,
  `produceDate` datetime DEFAULT NULL COMMENT '生产日期',
  `expiresDate` datetime DEFAULT NULL COMMENT '过期时间(yyyy-MM-dd)',
  `produceCode` varchar(100) DEFAULT NULL COMMENT '生产单号',
  `inputType` int(11) DEFAULT NULL COMMENT '入库类型（code:9）',
  `inputStatus` int(11) DEFAULT NULL COMMENT '状态（0：请求入库；1：完成入库）',
  `inputDate` datetime DEFAULT NULL COMMENT '入库时间',
  `remark` varchar(200) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of p_product_input
-- ----------------------------

-- ----------------------------
-- Table structure for p_product_output
-- ----------------------------
DROP TABLE IF EXISTS `p_product_output`;
CREATE TABLE `p_product_output` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `outputCode` varchar(30) DEFAULT NULL COMMENT '出库ID',
  `orderCode` varchar(100) DEFAULT NULL COMMENT '订单ID',
  `factoryId` int(11) DEFAULT NULL COMMENT '仓库ID',
  `customerId` int(11) DEFAULT NULL COMMENT '客户ID',
  `salerId` int(11) DEFAULT NULL COMMENT '销售ID',
  `deliveryDate` datetime DEFAULT NULL COMMENT '交货日期',
  `country` int(10) DEFAULT NULL COMMENT '国家',
  `province` int(10) DEFAULT NULL COMMENT '省',
  `provinceName` varchar(30) DEFAULT NULL COMMENT '省名',
  `city` int(10) DEFAULT NULL COMMENT '市',
  `cityName` varchar(30) DEFAULT NULL COMMENT '市名',
  `district` int(10) DEFAULT NULL COMMENT '区',
  `districtName` varchar(30) DEFAULT NULL COMMENT '区名',
  `address` varchar(300) DEFAULT NULL COMMENT '客户地址',
  `manager` varchar(20) DEFAULT NULL COMMENT '联系人姓名',
  `telephone` varchar(30) DEFAULT NULL COMMENT '联系人电话',
  `outputStatus` int(11) DEFAULT NULL COMMENT '状态（0：请求出库；1：完成出库）',
  `outputDate` datetime DEFAULT NULL COMMENT '完成出库时间',
  `outputType` int(11) DEFAULT NULL COMMENT '出库单类型（0：销售订单；1：特殊申请）',
  `applyMemberId` int(11) DEFAULT NULL COMMENT '申请者ID',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of p_product_output
-- ----------------------------

-- ----------------------------
-- Table structure for p_purchase
-- ----------------------------
DROP TABLE IF EXISTS `p_purchase`;
CREATE TABLE `p_purchase` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `purchaseCode` varchar(100) DEFAULT NULL COMMENT '采购单号',
  `factoryId` int(11) DEFAULT NULL COMMENT '库房ID',
  `materialsId` int(11) DEFAULT NULL COMMENT '商品ID',
  `num` decimal(10,2) DEFAULT NULL COMMENT '数量',
  `unit` int(11) DEFAULT NULL COMMENT '单位',
  `deliveryDate` datetime DEFAULT NULL COMMENT '交货日期',
  `status` int(11) DEFAULT NULL COMMENT '状态（code：12）',
  `produceCode` varchar(100) DEFAULT NULL COMMENT '生产单号',
  `applyType` int(11) DEFAULT NULL COMMENT '申请类型（0：生产订单；1：特殊申请）',
  `applyBy` varchar(50) DEFAULT NULL COMMENT '申请人',
  `applyDate` datetime DEFAULT NULL COMMENT '申请日期',
  `customerId` int(11) DEFAULT NULL COMMENT '供应商ID',
  `country` int(10) DEFAULT NULL COMMENT '国家',
  `province` int(10) DEFAULT NULL COMMENT '省',
  `provinceName` varchar(30) DEFAULT NULL COMMENT '省名',
  `city` int(10) DEFAULT NULL COMMENT '市',
  `cityName` varchar(30) DEFAULT NULL COMMENT '市名',
  `district` int(10) DEFAULT NULL COMMENT '区',
  `districtName` varchar(30) DEFAULT NULL COMMENT '区名',
  `address` varchar(300) DEFAULT NULL COMMENT '客户地址',
  `manager` varchar(20) DEFAULT NULL COMMENT '联系人姓名',
  `telephone` varchar(30) DEFAULT NULL COMMENT '联系人电话',
  `price` decimal(10,2) DEFAULT NULL COMMENT '采购金额',
  `purchaserId` int(11) DEFAULT NULL COMMENT '采购ID',
  `cancelReason` varchar(200) DEFAULT NULL COMMENT '取消原因',
  `remark` varchar(200) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of p_purchase
-- ----------------------------

-- ----------------------------
-- Table structure for p_purchase_apply
-- ----------------------------
DROP TABLE IF EXISTS `p_purchase_apply`;
CREATE TABLE `p_purchase_apply` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `factoryId` int(11) DEFAULT NULL COMMENT '库房ID',
  `materialsId` int(11) DEFAULT NULL COMMENT '商品ID',
  `num` decimal(10,2) DEFAULT NULL COMMENT '数量',
  `unit` int(11) DEFAULT NULL COMMENT '单位',
  `deliveryDate` datetime DEFAULT NULL COMMENT '交货日期',
  `status` int(11) DEFAULT NULL COMMENT '状态（0：未确认；1：已确认）',
  `purchaseCode` varchar(100) DEFAULT NULL COMMENT '采购单号',
  `produceCode` varchar(100) DEFAULT NULL COMMENT '生产单号',
  `applyType` int(11) DEFAULT NULL COMMENT '申请类型（0：生产订单；1：特殊申请）',
  `applyBy` varchar(50) DEFAULT NULL COMMENT '申请人',
  `applyDate` datetime DEFAULT NULL COMMENT '申请日期',
  `remark` varchar(200) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of p_purchase_apply
-- ----------------------------

-- ----------------------------
-- Table structure for p_saleorder
-- ----------------------------
DROP TABLE IF EXISTS `p_saleorder`;
CREATE TABLE `p_saleorder` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `orderCode` varchar(50) DEFAULT NULL,
  `customerId` int(11) DEFAULT NULL COMMENT '客户ID',
  `salerId` int(11) DEFAULT NULL COMMENT '销售ID',
  `price` decimal(10,0) DEFAULT NULL COMMENT '订单金额',
  `priceRemark` varchar(300) DEFAULT NULL COMMENT '销售价格说明',
  `factoryId` int(11) DEFAULT NULL COMMENT '库房ID',
  `payStatus` int(10) DEFAULT NULL COMMENT '支付状态(code：6）',
  `country` int(10) DEFAULT NULL COMMENT '国家',
  `province` int(10) DEFAULT NULL COMMENT '省',
  `provinceName` varchar(30) DEFAULT NULL COMMENT '省名',
  `city` int(10) DEFAULT NULL COMMENT '市',
  `cityName` varchar(30) DEFAULT NULL COMMENT '市名',
  `district` int(10) DEFAULT NULL COMMENT '区',
  `districtName` varchar(30) DEFAULT NULL COMMENT '区名',
  `address` varchar(300) DEFAULT NULL COMMENT '客户地址',
  `manager` varchar(20) DEFAULT NULL COMMENT '联系人姓名',
  `telephone` varchar(30) DEFAULT NULL COMMENT '联系人电话',
  `deliveryDate` datetime DEFAULT NULL COMMENT '交货日期',
  `orderStatus` int(11) DEFAULT NULL COMMENT '订单状态（Code：7）',
  `cancelReason` varchar(255) DEFAULT NULL COMMENT '取消理由',
  `remark` varchar(255) DEFAULT NULL,
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of p_saleorder
-- ----------------------------

-- ----------------------------
-- Table structure for r_customer_paid
-- ----------------------------
DROP TABLE IF EXISTS `r_customer_paid`;
CREATE TABLE `r_customer_paid` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `customerId` int(11) DEFAULT NULL COMMENT '客户代码',
  `customerName` varchar(100) DEFAULT NULL COMMENT '客户名称',
  `bank` varchar(100) DEFAULT NULL COMMENT '开户行',
  `subBank` varchar(100) DEFAULT NULL COMMENT '支行',
  `bankAccount` varchar(100) DEFAULT NULL COMMENT '银行账号',
  `bankAccountName` varchar(100) DEFAULT NULL COMMENT '账户姓名',
  `bankAccountMobile` varchar(100) DEFAULT NULL COMMENT '账户手机号',
  `alipayName` varchar(100) DEFAULT NULL COMMENT '支付宝姓名',
  `alipayAccount` varchar(100) DEFAULT NULL COMMENT '支付宝账号',
  `alipayMobile` varchar(100) DEFAULT NULL COMMENT '支付宝手机号',
  `creditLimit` decimal(10,2) DEFAULT NULL COMMENT '信用额',
  `remark` varchar(255) DEFAULT NULL,
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of r_customer_paid
-- ----------------------------

-- ----------------------------
-- Table structure for r_finance_paid_detail
-- ----------------------------
DROP TABLE IF EXISTS `r_finance_paid_detail`;
CREATE TABLE `r_finance_paid_detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `purchaseCode` varchar(100) DEFAULT NULL COMMENT '销售单号',
  `paidMoney` decimal(10,2) DEFAULT NULL COMMENT '支付金额',
  `paidDate` datetime DEFAULT '0000-00-00 00:00:00' COMMENT '支付日期',
  `paidType` int(11) DEFAULT NULL COMMENT '结算方式（code：5）',
  `otherType` varchar(100) DEFAULT NULL COMMENT '其他结算方式',
  `remark` varchar(200) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of r_finance_paid_detail
-- ----------------------------

-- ----------------------------
-- Table structure for r_finance_receive_detail
-- ----------------------------
DROP TABLE IF EXISTS `r_finance_receive_detail`;
CREATE TABLE `r_finance_receive_detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `orderCode` varchar(100) DEFAULT NULL COMMENT '销售单号',
  `receivedMoney` decimal(10,2) DEFAULT NULL COMMENT '已收金额',
  `receivedDate` datetime DEFAULT '0000-00-00 00:00:00' COMMENT '收款日期',
  `receivedType` int(11) DEFAULT NULL COMMENT '结算方式（code：5）',
  `otherType` varchar(100) DEFAULT NULL COMMENT '其他结算方式',
  `remark` varchar(200) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of r_finance_receive_detail
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_materials_price
-- ----------------------------

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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_materials_search
-- ----------------------------
INSERT INTO `r_materials_search` VALUES ('2', '1', '原料1', 'm1');
INSERT INTO `r_materials_search` VALUES ('6', '2', '原料2', 'm2');
INSERT INTO `r_materials_search` VALUES ('7', '3', '自制原料1', 'zzyl1');
INSERT INTO `r_materials_search` VALUES ('8', '4', '其他原料1', 'qtyl1');
INSERT INTO `r_materials_search` VALUES ('9', '5', '其它原料2', 'qtyl2');

-- ----------------------------
-- Table structure for r_product_materials
-- ----------------------------
DROP TABLE IF EXISTS `r_product_materials`;
CREATE TABLE `r_product_materials` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `productId` int(11) DEFAULT NULL COMMENT '产品ID',
  `materialsId` int(11) DEFAULT NULL COMMENT '原料ID',
  `searchKey` varchar(50) DEFAULT NULL,
  `materialsName` varchar(100) DEFAULT NULL,
  `percent` decimal(10,2) DEFAULT NULL COMMENT '原料百分比',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=55 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_product_materials
-- ----------------------------
INSERT INTO `r_product_materials` VALUES ('50', '7', '2', 'm2', '', '60.00', '0', 'admin', '2017-02-17 12:02:05', 'admin', '2017-02-17 12:02:05');
INSERT INTO `r_product_materials` VALUES ('51', '7', '1', 'm1', '', '30.00', '0', 'admin', '2017-02-17 12:02:05', 'admin', '2017-02-17 12:02:05');
INSERT INTO `r_product_materials` VALUES ('52', '7', '3', 'zz', '', '5.00', '0', 'admin', '2017-02-17 12:02:05', 'admin', '2017-02-17 12:02:05');
INSERT INTO `r_product_materials` VALUES ('53', '7', '4', 'qt', '', '5.00', '0', 'admin', '2017-02-17 12:02:05', 'admin', '2017-02-17 12:02:05');
INSERT INTO `r_product_materials` VALUES ('54', '4', '1', 'm1', '', '100.00', '0', 'admin', '2017-02-17 16:46:10', 'admin', '2017-02-17 16:46:10');

-- ----------------------------
-- Table structure for r_product_output_detail
-- ----------------------------
DROP TABLE IF EXISTS `r_product_output_detail`;
CREATE TABLE `r_product_output_detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `outputCode` varchar(30) DEFAULT NULL COMMENT '出库ID',
  `productId` int(11) DEFAULT NULL COMMENT '出库商品ID',
  `productNum` int(11) DEFAULT NULL COMMENT '出库商品数量',
  `realityOutputNum` int(11) DEFAULT NULL COMMENT '实际出库数',
  `outputStatus` int(11) DEFAULT NULL COMMENT '状态（0：请求出库；1：完成出库）',
  `outputDate` datetime DEFAULT NULL COMMENT '出库时间',
  `outputType` int(11) DEFAULT NULL COMMENT '运输方式（code：8）',
  `logisticsOrder` varchar(100) DEFAULT NULL COMMENT '物流单号',
  `remark` varchar(200) DEFAULT NULL COMMENT '备注',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_product_output_detail
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

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
  `productName` varchar(255) DEFAULT NULL,
  `searchKey` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_product_search
-- ----------------------------
INSERT INTO `r_product_search` VALUES ('1', '4', '商品1', 'p1');
INSERT INTO `r_product_search` VALUES ('4', '7', '商品2', 'p2');

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
) ENGINE=InnoDB AUTO_INCREMENT=234 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_role_menu
-- ----------------------------
INSERT INTO `r_role_menu` VALUES ('1', '1', '7', '1', '1', '2016-11-19 12:02:44', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('2', '1', '6', '1', '1', '2016-11-19 12:03:00', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('3', '1', '5', '1', '1', '2016-11-19 12:03:00', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('4', '1', '4', '1', '1', '2016-11-19 12:03:00', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('5', '1', '3', '1', '1', '2016-11-19 12:03:00', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('6', '1', '2', '1', '1', '2016-11-19 12:03:00', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('7', '1', '1', '1', '1', '2016-11-19 12:03:00', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('8', '1', '704', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('9', '1', '703', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('10', '1', '702', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('11', '1', '701', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('12', '1', '7', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('13', '1', '604', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('14', '1', '603', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('15', '1', '602', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('16', '1', '601', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('17', '1', '6', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('18', '1', '501', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('19', '1', '5', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('20', '1', '405', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('21', '1', '404', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('22', '1', '403', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('23', '1', '0', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('24', '1', '401', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('25', '1', '4', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('26', '1', '302', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('27', '1', '301', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('28', '1', '3', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('29', '1', '2', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('30', '1', '202', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('31', '1', '201', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('32', '1', '1', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('33', '1', '102', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('34', '1', '103', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('35', '1', '104', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('36', '1', '101', '1', '1', '2016-11-19 12:17:58', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('37', '2', '2', '1', '1', '2016-11-19 12:18:35', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('38', '2', '202', '1', '1', '2016-11-19 12:18:35', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('39', '2', '201', '1', '1', '2016-11-19 12:18:35', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('40', '2', '302', '1', '1', '2016-11-19 12:22:49', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('41', '2', '301', '1', '1', '2016-11-19 12:22:49', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('42', '2', '3', '1', '1', '2016-11-19 12:22:49', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('43', '2', '2', '1', '1', '2016-11-19 12:22:49', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('44', '2', '202', '1', '1', '2016-11-19 12:22:49', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('45', '2', '201', '1', '1', '2016-11-19 12:22:49', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('46', '2', '2', '1', '1', '2016-11-19 12:29:36', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('47', '2', '202', '1', '1', '2016-11-19 12:29:36', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('48', '2', '201', '1', '1', '2016-11-19 12:29:36', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('49', '2', '2', '1', 'admin', '2016-11-21 14:40:13', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('50', '2', '0', '1', 'admin', '2016-11-21 14:40:13', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('51', '2', '202', '1', 'admin', '2016-11-21 14:40:13', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('52', '2', '201', '1', 'admin', '2016-11-21 14:40:13', 'admin', '2017-02-18 12:49:25');
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
INSERT INTO `r_role_menu` VALUES ('73', '1', '0', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('74', '1', '704', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('75', '1', '703', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('76', '1', '702', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('77', '1', '701', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('78', '1', '7', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('79', '1', '604', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('80', '1', '603', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('81', '1', '601', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('82', '1', '6', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('83', '1', '501', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('84', '1', '5', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('85', '1', '405', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('86', '1', '404', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('87', '1', '403', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('88', '1', '0', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('89', '1', '401', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('90', '1', '4', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('91', '1', '302', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('92', '1', '301', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('93', '1', '3', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('94', '1', '2', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('95', '1', '0', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('96', '1', '202', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('97', '1', '201', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('98', '1', '1', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('99', '1', '102', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('100', '1', '103', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('101', '1', '104', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('102', '1', '101', '1', 'admin', '2016-12-03 15:04:12', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('103', '2', '302', '1', 'admin', '2016-12-03 15:04:41', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('104', '2', '301', '1', 'admin', '2016-12-03 15:04:41', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('105', '2', '3', '1', 'admin', '2016-12-03 15:04:41', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('106', '2', '2', '1', 'admin', '2016-12-03 15:04:41', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('107', '2', '0', '1', 'admin', '2016-12-03 15:04:41', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('108', '2', '202', '1', 'admin', '2016-12-03 15:04:41', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('109', '2', '201', '1', 'admin', '2016-12-03 15:04:41', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('110', '3', '0', '0', 'admin', '2016-12-21 13:55:08', 'admin', '2016-12-21 13:55:08');
INSERT INTO `r_role_menu` VALUES ('111', '3', '302', '0', 'admin', '2016-12-21 13:55:08', 'admin', '2016-12-21 13:55:08');
INSERT INTO `r_role_menu` VALUES ('112', '3', '301', '0', 'admin', '2016-12-21 13:55:08', 'admin', '2016-12-21 13:55:08');
INSERT INTO `r_role_menu` VALUES ('113', '3', '3', '0', 'admin', '2016-12-21 13:55:08', 'admin', '2016-12-21 13:55:08');
INSERT INTO `r_role_menu` VALUES ('114', '3', '2', '0', 'admin', '2016-12-21 13:55:08', 'admin', '2016-12-21 13:55:08');
INSERT INTO `r_role_menu` VALUES ('115', '3', '201', '0', 'admin', '2016-12-21 13:55:08', 'admin', '2016-12-21 13:55:08');
INSERT INTO `r_role_menu` VALUES ('116', '6', '604', '1', 'admin', '2016-12-21 16:01:40', 'admin', '2017-02-03 15:07:14');
INSERT INTO `r_role_menu` VALUES ('117', '6', '603', '1', 'admin', '2016-12-21 16:01:40', 'admin', '2017-02-03 15:07:14');
INSERT INTO `r_role_menu` VALUES ('118', '6', '601', '1', 'admin', '2016-12-21 16:01:40', 'admin', '2017-02-03 15:07:14');
INSERT INTO `r_role_menu` VALUES ('119', '6', '6', '1', 'admin', '2016-12-21 16:01:40', 'admin', '2017-02-03 15:07:14');
INSERT INTO `r_role_menu` VALUES ('120', '6', '604', '1', 'admin', '2016-12-21 16:02:50', 'admin', '2017-02-03 15:07:14');
INSERT INTO `r_role_menu` VALUES ('121', '6', '603', '1', 'admin', '2016-12-21 16:02:50', 'admin', '2017-02-03 15:07:14');
INSERT INTO `r_role_menu` VALUES ('122', '6', '601', '1', 'admin', '2016-12-21 16:02:50', 'admin', '2017-02-03 15:07:14');
INSERT INTO `r_role_menu` VALUES ('123', '6', '6', '1', 'admin', '2016-12-21 16:02:50', 'admin', '2017-02-03 15:07:14');
INSERT INTO `r_role_menu` VALUES ('124', '7', '704', '1', 'admin', '2016-12-21 16:03:07', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('125', '7', '703', '1', 'admin', '2016-12-21 16:03:07', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('126', '7', '702', '1', 'admin', '2016-12-21 16:03:07', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('127', '7', '701', '1', 'admin', '2016-12-21 16:03:07', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('128', '7', '7', '1', 'admin', '2016-12-21 16:03:07', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('129', '7', '704', '1', 'admin', '2016-12-21 16:06:30', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('130', '7', '703', '1', 'admin', '2016-12-21 16:06:30', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('131', '7', '702', '1', 'admin', '2016-12-21 16:06:30', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('132', '7', '701', '1', 'admin', '2016-12-21 16:06:30', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('133', '7', '7', '1', 'admin', '2016-12-21 16:06:30', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('134', '7', '2', '1', 'admin', '2016-12-21 16:06:30', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('135', '7', '0', '1', 'admin', '2016-12-21 16:06:30', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('136', '7', '202', '1', 'admin', '2016-12-21 16:06:30', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('137', '7', '201', '1', 'admin', '2016-12-21 16:06:30', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('138', '1', '704', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('139', '1', '703', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('140', '1', '702', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('141', '1', '701', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('142', '1', '7', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('143', '1', '604', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('144', '1', '603', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('145', '1', '601', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('146', '1', '6', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('147', '1', '501', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('148', '1', '5', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('149', '1', '405', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('150', '1', '404', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('151', '1', '403', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('152', '1', '0', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('153', '1', '401', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('154', '1', '4', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('155', '1', '302', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('156', '1', '301', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('157', '1', '3', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('158', '1', '2', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('159', '1', '0', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('160', '1', '202', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('161', '1', '201', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('162', '1', '1', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('163', '1', '102', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('164', '1', '103', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('165', '1', '104', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('166', '1', '101', '0', 'admin', '2016-12-21 16:18:01', 'admin', '2016-12-21 16:18:01');
INSERT INTO `r_role_menu` VALUES ('167', '7', '704', '1', 'admin', '2017-01-03 10:55:35', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('168', '7', '703', '1', 'admin', '2017-01-03 10:55:35', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('169', '7', '702', '1', 'admin', '2017-01-03 10:55:35', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('170', '7', '701', '1', 'admin', '2017-01-03 10:55:35', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('171', '7', '7', '1', 'admin', '2017-01-03 10:55:35', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('172', '7', '302', '1', 'admin', '2017-01-03 10:55:35', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('173', '7', '3', '1', 'admin', '2017-01-03 10:55:35', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('174', '7', '2', '1', 'admin', '2017-01-03 10:55:35', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('175', '7', '0', '1', 'admin', '2017-01-03 10:55:35', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('176', '7', '202', '1', 'admin', '2017-01-03 10:55:35', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('177', '7', '201', '1', 'admin', '2017-01-03 10:55:35', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('178', '4', '405', '1', 'admin', '2017-01-03 14:29:20', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('179', '4', '404', '1', 'admin', '2017-01-03 14:29:20', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('180', '4', '403', '1', 'admin', '2017-01-03 14:29:20', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('181', '4', '0', '1', 'admin', '2017-01-03 14:29:20', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('182', '4', '401', '1', 'admin', '2017-01-03 14:29:20', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('183', '4', '4', '1', 'admin', '2017-01-03 14:29:20', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('184', '4', '405', '1', 'admin', '2017-01-22 14:17:26', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('185', '4', '404', '1', 'admin', '2017-01-22 14:17:26', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('186', '4', '403', '1', 'admin', '2017-01-22 14:17:26', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('187', '4', '402', '1', 'admin', '2017-01-22 14:17:26', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('188', '4', '401', '1', 'admin', '2017-01-22 14:17:26', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('189', '4', '4', '1', 'admin', '2017-01-22 14:17:26', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('190', '5', '502', '0', 'admin', '2017-01-24 10:36:24', 'admin', '2017-01-24 10:36:24');
INSERT INTO `r_role_menu` VALUES ('191', '5', '501', '0', 'admin', '2017-01-24 10:36:24', 'admin', '2017-01-24 10:36:24');
INSERT INTO `r_role_menu` VALUES ('192', '5', '5', '0', 'admin', '2017-01-24 10:36:24', 'admin', '2017-01-24 10:36:24');
INSERT INTO `r_role_menu` VALUES ('193', '6', '602', '0', 'admin', '2017-02-03 15:07:14', 'admin', '2017-02-03 15:07:14');
INSERT INTO `r_role_menu` VALUES ('194', '6', '601', '0', 'admin', '2017-02-03 15:07:14', 'admin', '2017-02-03 15:07:14');
INSERT INTO `r_role_menu` VALUES ('195', '6', '603', '0', 'admin', '2017-02-03 15:07:14', 'admin', '2017-02-03 15:07:14');
INSERT INTO `r_role_menu` VALUES ('196', '6', '6', '0', 'admin', '2017-02-03 15:07:14', 'admin', '2017-02-03 15:07:14');
INSERT INTO `r_role_menu` VALUES ('197', '7', '704', '1', 'admin', '2017-02-06 14:11:25', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('198', '7', '703', '1', 'admin', '2017-02-06 14:11:25', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('199', '7', '702', '1', 'admin', '2017-02-06 14:11:25', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('200', '7', '701', '1', 'admin', '2017-02-06 14:11:25', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('201', '7', '7', '1', 'admin', '2017-02-06 14:11:25', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('202', '7', '602', '1', 'admin', '2017-02-06 14:11:25', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('203', '7', '6', '1', 'admin', '2017-02-06 14:11:25', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('204', '7', '302', '1', 'admin', '2017-02-06 14:11:25', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('205', '7', '3', '1', 'admin', '2017-02-06 14:11:25', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('206', '7', '2', '1', 'admin', '2017-02-06 14:11:25', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('207', '7', '0', '1', 'admin', '2017-02-06 14:11:25', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('208', '7', '202', '1', 'admin', '2017-02-06 14:11:25', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('209', '7', '201', '1', 'admin', '2017-02-06 14:11:25', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('210', '4', '406', '0', 'admin', '2017-02-18 12:47:02', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('211', '4', '405', '0', 'admin', '2017-02-18 12:47:02', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('212', '4', '404', '0', 'admin', '2017-02-18 12:47:02', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('213', '4', '403', '0', 'admin', '2017-02-18 12:47:02', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('214', '4', '402', '0', 'admin', '2017-02-18 12:47:02', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('215', '4', '401', '0', 'admin', '2017-02-18 12:47:02', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('216', '4', '4', '0', 'admin', '2017-02-18 12:47:02', 'admin', '2017-02-18 12:47:02');
INSERT INTO `r_role_menu` VALUES ('217', '2', '2', '1', 'admin', '2017-02-18 12:49:13', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('218', '2', '0', '1', 'admin', '2017-02-18 12:49:13', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('219', '2', '202', '1', 'admin', '2017-02-18 12:49:13', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('220', '2', '201', '1', 'admin', '2017-02-18 12:49:13', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('221', '2', '2', '0', 'admin', '2017-02-18 12:49:25', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('222', '2', '0', '0', 'admin', '2017-02-18 12:49:25', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('223', '2', '202', '0', 'admin', '2017-02-18 12:49:25', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('224', '2', '201', '0', 'admin', '2017-02-18 12:49:25', 'admin', '2017-02-18 12:49:25');
INSERT INTO `r_role_menu` VALUES ('225', '7', '704', '0', 'admin', '2017-02-22 10:03:56', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('226', '7', '703', '0', 'admin', '2017-02-22 10:03:56', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('227', '7', '702', '0', 'admin', '2017-02-22 10:03:56', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('228', '7', '701', '0', 'admin', '2017-02-22 10:03:56', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('229', '7', '7', '0', 'admin', '2017-02-22 10:03:56', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('230', '7', '2', '0', 'admin', '2017-02-22 10:03:56', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('231', '7', '0', '0', 'admin', '2017-02-22 10:03:56', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('232', '7', '202', '0', 'admin', '2017-02-22 10:03:56', 'admin', '2017-02-22 10:03:56');
INSERT INTO `r_role_menu` VALUES ('233', '7', '201', '0', 'admin', '2017-02-22 10:03:56', 'admin', '2017-02-22 10:03:56');

-- ----------------------------
-- Table structure for r_saleorder_detail
-- ----------------------------
DROP TABLE IF EXISTS `r_saleorder_detail`;
CREATE TABLE `r_saleorder_detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `orderCode` varchar(50) DEFAULT NULL,
  `searchKey` varchar(100) DEFAULT NULL,
  `productId` int(10) DEFAULT NULL COMMENT '产品ID',
  `num` int(11) DEFAULT NULL COMMENT '数量',
  `price` decimal(10,0) DEFAULT NULL COMMENT '销售金额',
  `remark` varchar(255) DEFAULT NULL,
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of r_saleorder_detail
-- ----------------------------

-- ----------------------------
-- Table structure for r_saleorder_pay
-- ----------------------------
DROP TABLE IF EXISTS `r_saleorder_pay`;
CREATE TABLE `r_saleorder_pay` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `orderCode` varchar(50) DEFAULT NULL,
  `payMoney` decimal(10,0) DEFAULT NULL COMMENT '支付金额',
  `payType` int(255) DEFAULT NULL COMMENT '支付方式（code：5）',
  `payTime` datetime DEFAULT NULL COMMENT '支付时间',
  `payCode` varchar(50) DEFAULT NULL COMMENT '支付流水号',
  `bankAccout` varchar(100) DEFAULT NULL COMMENT '收款账号',
  `payee` varchar(100) DEFAULT NULL COMMENT '收款人',
  `remark` varchar(255) DEFAULT NULL,
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of r_saleorder_pay
-- ----------------------------

-- ----------------------------
-- Procedure structure for p_GetSeq
-- ----------------------------
DROP PROCEDURE IF EXISTS `p_GetSeq`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `p_GetSeq`(in key_in varchar(20),out seq_out int)
BEGIN
	SELECT
			sequence INTO seq_out
		FROM
			m_sequence
		WHERE
			`key` = key_in;

	IF (seq_out IS NULL OR seq_out <= 0) THEN
		INSERT INTO m_sequence (`key`, sequence)
		VALUES(key_in, 1);
		SET seq_out = 1;
	ELSE
		UPDATE m_sequence
		SET sequence = sequence + 1
		WHERE	`key` = key_in;
		SET seq_out = seq_out + 1;
	END IF;
END
;;
DELIMITER ;
