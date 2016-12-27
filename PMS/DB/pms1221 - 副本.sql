/*
Navicat MySQL Data Transfer

Source Server         : Test
Source Server Version : 50716
Source Host           : localhost:3306
Source Database       : pms

Target Server Type    : MYSQL
Target Server Version : 50716
File Encoding         : 65001

Date: 2016-12-21 17:03:29
*/

SET FOREIGN_KEY_CHECKS=0;

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
INSERT INTO `m_area` VALUES ('1', '中华人民共和国', '', '0', '0', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('101', '北京市', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('102', '天津市', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('103', '河北省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('104', '山西省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('105', '内蒙古自治区', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('106', '辽宁省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('107', '吉林省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('108', '黑龙江省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('109', '上海市', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('110', '江苏省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('111', '浙江省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('112', '安徽省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('113', '福建省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('114', '江西省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('115', '山东省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('116', '河南省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('117', '湖北省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('118', '湖南省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('119', '广东省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('120', '广西壮族自治区', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('121', '海南省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('122', '重庆市', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('123', '四川省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('124', '贵州省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('125', '云南省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('126', '西藏自治区', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('127', '陕西省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('128', '甘肃省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('129', '青海省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('130', '宁夏回族自治区', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('131', '新疆维吾尔自治区', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('132', '香港特别行政区', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('133', '澳门特别行政区', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('134', '台湾省', '', '1', '1', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1001', '北京市', '100000', '2', '101', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1002', '天津市', '100000', '2', '102', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1003', '石家庄市', '050000', '2', '103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1004', '唐山市', '063000', '2', '103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1005', '秦皇岛市', '066000', '2', '103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1006', '邯郸市', '056000', '2', '103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1007', '邢台市', '054000', '2', '103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1008', '保定市', '071000', '2', '103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1009', '张家口市', '075000', '2', '103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1010', '承德市', '067000', '2', '103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1011', '沧州市', '061000', '2', '103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1012', '廊坊市', '065000', '2', '103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1013', '衡水市', '053000', '2', '103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1014', '太原市', '030000', '2', '104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1015', '大同市', '037000', '2', '104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1016', '阳泉市', '045000', '2', '104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1017', '长治市', '046000', '2', '104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1018', '晋城市', '048000', '2', '104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1019', '朔州市', '036000', '2', '104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1020', '晋中市', '030600', '2', '104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1021', '运城市', '044000', '2', '104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1022', '忻州市', '034000', '2', '104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1023', '临汾市', '041000', '2', '104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1024', '吕梁市', '030500', '2', '104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1025', '呼和浩特市', '010000', '2', '105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1026', '包头市', '014000', '2', '105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1027', '乌海市', '016000', '2', '105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1028', '赤峰市', '024000', '2', '105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1029', '通辽市', '028000', '2', '105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1030', '鄂尔多斯市', '010300', '2', '105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1031', '呼伦贝尔市', '021000', '2', '105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1032', '巴彦淖尔市', '014400', '2', '105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1033', '乌兰察布市', '011800', '2', '105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1034', '兴安盟', '137500', '2', '105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1035', '锡林郭勒盟', '011100', '2', '105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1036', '阿拉善盟', '016000', '2', '105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1037', '沈阳市', '110000', '2', '106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1038', '大连市', '116000', '2', '106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1039', '鞍山市', '114000', '2', '106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1040', '抚顺市', '113000', '2', '106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1041', '本溪市', '117000', '2', '106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1042', '丹东市', '118000', '2', '106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1043', '锦州市', '121000', '2', '106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1044', '营口市', '115000', '2', '106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1045', '阜新市', '123000', '2', '106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1046', '辽阳市', '111000', '2', '106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1047', '盘锦市', '124000', '2', '106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1048', '铁岭市', '112000', '2', '106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1049', '朝阳市', '122000', '2', '106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1050', '葫芦岛市', '125000', '2', '106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1051', '长春市', '130000', '2', '107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1052', '吉林市', '132000', '2', '107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1053', '四平市', '136000', '2', '107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1054', '辽源市', '136200', '2', '107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1055', '通化市', '134000', '2', '107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1056', '白山市', '134300', '2', '107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1057', '松原市', '131100', '2', '107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1058', '白城市', '137000', '2', '107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1059', '延边朝鲜族自治州', '133000', '2', '107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1060', '哈尔滨市', '150000', '2', '108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1061', '齐齐哈尔市', '161000', '2', '108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1062', '鸡西市', '158100', '2', '108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1063', '鹤岗市', '154100', '2', '108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1064', '双鸭山市', '155100', '2', '108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1065', '大庆市', '163000', '2', '108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1066', '伊春市', '152300', '2', '108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1067', '佳木斯市', '154000', '2', '108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1068', '七台河市', '154600', '2', '108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1069', '牡丹江市', '157000', '2', '108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1070', '黑河市', '164300', '2', '108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1071', '绥化市', '152000', '2', '108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1072', '大兴安岭地区', '165000', '2', '108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1073', '上海市', '200000', '2', '109', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1074', '南京市', '210000', '2', '110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1075', '无锡市', '214000', '2', '110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1076', '徐州市', '221000', '2', '110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1077', '常州市', '213000', '2', '110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1078', '苏州市', '215000', '2', '110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1079', '南通市', '226000', '2', '110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1080', '连云港市', '222000', '2', '110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1081', '淮安市', '223200', '2', '110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1082', '盐城市', '224000', '2', '110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1083', '扬州市', '225000', '2', '110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1084', '镇江市', '212000', '2', '110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1085', '泰州市', '225300', '2', '110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1086', '宿迁市', '223800', '2', '110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1087', '杭州市', '310000', '2', '111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1088', '宁波市', '315000', '2', '111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1089', '温州市', '325000', '2', '111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1090', '嘉兴市', '314000', '2', '111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1091', '湖州市', '313000', '2', '111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1092', '绍兴市', '312000', '2', '111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1093', '金华市', '321000', '2', '111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1094', '衢州市', '324000', '2', '111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1095', '舟山市', '316000', '2', '111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1096', '台州市', '318000', '2', '111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1097', '丽水市', '323000', '2', '111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1098', '合肥市', '230000', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1099', '芜湖市', '241000', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1100', '蚌埠市', '233000', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1101', '淮南市', '232000', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1102', '马鞍山市', '243000', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1103', '淮北市', '235000', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1104', '铜陵市', '244000', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1105', '安庆市', '246000', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1106', '黄山市', '242700', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1107', '滁州市', '239000', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1108', '阜阳市', '236100', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1109', '宿州市', '234100', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1110', '巢湖市', '238000', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1111', '六安市', '237000', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1112', '亳州市', '236800', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1113', '池州市', '247100', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1114', '宣城市', '366000', '2', '112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1115', '福州市', '350000', '2', '113', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1116', '厦门市', '361000', '2', '113', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1117', '莆田市', '351100', '2', '113', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1118', '三明市', '365000', '2', '113', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1119', '泉州市', '362000', '2', '113', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1120', '漳州市', '363000', '2', '113', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1121', '南平市', '353000', '2', '113', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1122', '龙岩市', '364000', '2', '113', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1123', '宁德市', '352100', '2', '113', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1124', '南昌市', '330000', '2', '114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1125', '景德镇市', '333000', '2', '114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1126', '萍乡市', '337000', '2', '114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1127', '九江市', '332000', '2', '114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1128', '新余市', '338000', '2', '114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1129', '鹰潭市', '335000', '2', '114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1130', '赣州市', '341000', '2', '114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1131', '吉安市', '343000', '2', '114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1132', '宜春市', '336000', '2', '114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1133', '抚州市', '332900', '2', '114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1134', '上饶市', '334000', '2', '114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1135', '济南市', '250000', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1136', '青岛市', '266000', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1137', '淄博市', '255000', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1138', '枣庄市', '277100', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1139', '东营市', '257000', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1140', '烟台市', '264000', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1141', '潍坊市', '261000', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1142', '济宁市', '272100', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1143', '泰安市', '271000', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1144', '威海市', '265700', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1145', '日照市', '276800', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1146', '莱芜市', '271100', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1147', '临沂市', '276000', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1148', '德州市', '253000', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1149', '聊城市', '252000', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1150', '滨州市', '256600', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1151', '荷泽市', '255000', '2', '115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1152', '郑州市', '450000', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1153', '开封市', '475000', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1154', '洛阳市', '471000', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1155', '平顶山市', '467000', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1156', '安阳市', '454900', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1157', '鹤壁市', '456600', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1158', '新乡市', '453000', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1159', '焦作市', '454100', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1160', '濮阳市', '457000', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1161', '许昌市', '461000', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1162', '漯河市', '462000', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1163', '三门峡市', '472000', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1164', '南阳市', '473000', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1165', '商丘市', '476000', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1166', '信阳市', '464000', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1167', '周口市', '466000', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1168', '驻马店市', '463000', '2', '116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1169', '武汉市', '430000', '2', '117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1170', '黄石市', '435000', '2', '117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1171', '十堰市', '442000', '2', '117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1172', '宜昌市', '443000', '2', '117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1173', '襄樊市', '441000', '2', '117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1174', '鄂州市', '436000', '2', '117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1175', '荆门市', '448000', '2', '117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1176', '孝感市', '432100', '2', '117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1177', '荆州市', '434000', '2', '117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1178', '黄冈市', '438000', '2', '117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1179', '咸宁市', '437000', '2', '117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1180', '随州市', '441300', '2', '117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1181', '恩施土家族苗族自治州', '445000', '2', '117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1182', '神农架', '442400', '2', '117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1183', '长沙市', '410000', '2', '118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1184', '株洲市', '412000', '2', '118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1185', '湘潭市', '411100', '2', '118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1186', '衡阳市', '421000', '2', '118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1187', '邵阳市', '422000', '2', '118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1188', '岳阳市', '414000', '2', '118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1189', '常德市', '415000', '2', '118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1190', '张家界市', '427000', '2', '118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1191', '益阳市', '413000', '2', '118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1192', '郴州市', '423000', '2', '118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1193', '永州市', '425000', '2', '118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1194', '怀化市', '418000', '2', '118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1195', '娄底市', '417000', '2', '118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1196', '湘西土家族苗族自治州', '416000', '2', '118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1197', '广州市', '510000', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1198', '韶关市', '521000', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1199', '深圳市', '518000', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1200', '珠海市', '519000', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1201', '汕头市', '515000', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1202', '佛山市', '528000', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1203', '江门市', '529000', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1204', '湛江市', '524000', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1205', '茂名市', '525000', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1206', '肇庆市', '526000', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1207', '惠州市', '516000', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1208', '梅州市', '514000', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1209', '汕尾市', '516600', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1210', '河源市', '517000', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1211', '阳江市', '529500', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1212', '清远市', '511500', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1213', '东莞市', '511700', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1214', '中山市', '528400', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1215', '潮州市', '515600', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1216', '揭阳市', '522000', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1217', '云浮市', '527300', '2', '119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1218', '南宁市', '530000', '2', '120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1219', '柳州市', '545000', '2', '120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1220', '桂林市', '541000', '2', '120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1221', '梧州市', '543000', '2', '120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1222', '北海市', '536000', '2', '120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1223', '防城港市', '538000', '2', '120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1224', '钦州市', '535000', '2', '120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1225', '贵港市', '537100', '2', '120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1226', '玉林市', '537000', '2', '120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1227', '百色市', '533000', '2', '120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1228', '贺州市', '542800', '2', '120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1229', '河池市', '547000', '2', '120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1230', '来宾市', '546100', '2', '120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1231', '崇左市', '532200', '2', '120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1232', '海口市', '570000', '2', '121', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1233', '三亚市', '572000', '2', '121', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1234', '重庆市', '400000', '2', '122', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1235', '成都市', '610000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1236', '自贡市', '643000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1237', '攀枝花市', '617000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1238', '泸州市', '646100', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1239', '德阳市', '618000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1240', '绵阳市', '621000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1241', '广元市', '628000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1242', '遂宁市', '629000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1243', '内江市', '641000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1244', '乐山市', '614000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1245', '南充市', '637000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1246', '眉山市', '612100', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1247', '宜宾市', '644000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1248', '广安市', '638000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1249', '达州市', '635000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1250', '雅安市', '625000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1251', '巴中市', '635500', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1252', '资阳市', '641300', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1253', '阿坝藏族羌族自治州', '624600', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1254', '甘孜藏族自治州', '626000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1255', '凉山彝族自治州', '615000', '2', '123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1256', '贵阳市', '55000', '2', '124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1257', '六盘水市', '553000', '2', '124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1258', '遵义市', '563000', '2', '124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1259', '安顺市', '561000', '2', '124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1260', '铜仁地区', '554300', '2', '124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1261', '黔西南布依族苗族自治州', '551500', '2', '124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1262', '毕节地区', '551700', '2', '124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1263', '黔东南苗族侗族自治州', '551500', '2', '124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1264', '黔南布依族苗族自治州', '550100', '2', '124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1265', '昆明市', '650000', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1266', '曲靖市', '655000', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1267', '玉溪市', '653100', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1268', '保山市', '678000', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1269', '昭通市', '657000', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1270', '丽江市', '674100', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1271', '思茅市', '665000', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1272', '临沧市', '677000', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1273', '楚雄彝族自治州', '675000', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1274', '红河哈尼族彝族自治州', '654400', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1275', '文山壮族苗族自治州', '663000', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1276', '西双版纳傣族自治州', '666200', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1277', '大理白族自治州', '671000', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1278', '德宏傣族景颇族自治州', '678400', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1279', '怒江傈僳族自治州', '671400', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1280', '迪庆藏族自治州', '674400', '2', '125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1281', '拉萨市', '850000', '2', '126', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1282', '昌都地区', '854000', '2', '126', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1283', '山南地区', '856000', '2', '126', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1284', '日喀则地区', '857000', '2', '126', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1285', '那曲地区', '852000', '2', '126', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1286', '阿里地区', '859100', '2', '126', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1287', '林芝地区', '860100', '2', '126', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1288', '西安市', '710000', '2', '127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1289', '铜川市', '727000', '2', '127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1290', '宝鸡市', '721000', '2', '127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1291', '咸阳市', '712000', '2', '127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1292', '渭南市', '714000', '2', '127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1293', '延安市', '716000', '2', '127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1294', '汉中市', '723000', '2', '127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1295', '榆林市', '719000', '2', '127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1296', '安康市', '725000', '2', '127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1297', '商洛市', '711500', '2', '127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1298', '兰州市', '730000', '2', '128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1299', '嘉峪关市', '735100', '2', '128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1300', '金昌市', '737100', '2', '128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1301', '白银市', '730900', '2', '128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1302', '天水市', '741000', '2', '128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1303', '武威市', '733000', '2', '128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1304', '张掖市', '734000', '2', '128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1305', '平凉市', '744000', '2', '128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1306', '酒泉市', '735000', '2', '128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1307', '庆阳市', '744500', '2', '128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1308', '定西市', '743000', '2', '128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1309', '陇南市', '742100', '2', '128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1310', '临夏回族自治州', '731100', '2', '128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1311', '甘南藏族自治州', '747000', '2', '128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1312', '西宁市', '810000', '2', '129', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1313', '海东地区', '810600', '2', '129', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1314', '海北藏族自治州', '810300', '2', '129', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1315', '黄南藏族自治州', '811300', '2', '129', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1316', '海南藏族自治州', '813000', '2', '129', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1317', '果洛藏族自治州', '814000', '2', '129', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1318', '玉树藏族自治州', '815000', '2', '129', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1319', '海西蒙古族藏族自治州', '817000', '2', '129', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1320', '银川市', '750000', '2', '130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1321', '石嘴山市', '753000', '2', '130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1322', '吴忠市', '751100', '2', '130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1323', '固原市', '756000', '2', '130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1324', '中卫市', '751700', '2', '130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1325', '乌鲁木齐市', '830000', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1326', '克拉玛依市', '834000', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1327', '吐鲁番地区', '838000', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1328', '哈密地区', '839000', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1329', '昌吉回族自治州', '831100', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1330', '博尔塔拉蒙古自治州', '833400', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1331', '巴音郭楞蒙古自治州', '841000', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1332', '阿克苏地区', '843000', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1333', '克孜勒苏柯尔克孜自治州', '835600', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1334', '喀什地区', '844000', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1335', '和田地区', '848000', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1336', '伊犁哈萨克自治州', '833200', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1337', '塔城地区', '834700', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1338', '阿勒泰地区', '836500', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1339', '石河子市', '832000', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1340', '阿拉尔市', '843300', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1341', '图木舒克市', '843900', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1342', '五家渠市', '831300', '2', '131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1343', '香港特别行政区', '000000', '2', '132', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1344', '澳门特别行政区', '000000', '2', '133', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('1345', '台湾省', '000000', '2', '134', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10001', '东城区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10002', '西城区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10003', '崇文区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10004', '宣武区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10005', '朝阳区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10006', '丰台区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10007', '石景山区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10008', '海淀区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10009', '门头沟区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10010', '房山区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10011', '通州区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10012', '顺义区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10013', '昌平区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10014', '大兴区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10015', '怀柔区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10016', '平谷区', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10017', '密云县', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10018', '延庆县', '', '3', '1001', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10019', '和平区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10020', '河东区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10021', '河西区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10022', '南开区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10023', '河北区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10024', '红桥区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10025', '塘沽区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10026', '汉沽区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10027', '大港区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10028', '东丽区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10029', '西青区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10030', '津南区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10031', '北辰区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10032', '武清区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10033', '宝坻区', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10034', '宁河县', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10035', '静海县', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10036', '蓟县', '', '3', '1002', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10037', '长安区', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10038', '桥东区', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10039', '桥西区', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10040', '新华区', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10041', '井陉矿区', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10042', '裕华区', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10043', '井陉县', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10044', '正定县', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10045', '栾城县', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10046', '行唐县', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10047', '灵寿县', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10048', '高邑县', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10049', '深泽县', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10050', '赞皇县', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10051', '无极县', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10052', '平山县', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10053', '元氏县', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10054', '赵县', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10055', '辛集市', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10056', '藁城市', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10057', '晋州市', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10058', '新乐市', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10059', '鹿泉市', '', '3', '1003', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10060', '路南区', '', '3', '1004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10061', '路北区', '', '3', '1004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10062', '古冶区', '', '3', '1004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10063', '开平区', '', '3', '1004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10064', '丰南区', '', '3', '1004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10065', '丰润区', '', '3', '1004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10066', '滦县', '', '3', '1004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10067', '滦南县', '', '3', '1004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10068', '乐亭县', '', '3', '1004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10069', '迁西县', '', '3', '1004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10070', '玉田县', '', '3', '1004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10071', '唐海县', '', '3', '1004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10072', '遵化市', '', '3', '1004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10073', '迁安市', '', '3', '1004', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10074', '海港区', '', '3', '1005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10075', '山海关区', '', '3', '1005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10076', '北戴河区', '', '3', '1005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10077', '青龙满族自治县', '', '3', '1005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10078', '昌黎县', '', '3', '1005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10079', '抚宁县', '', '3', '1005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10080', '卢龙县', '', '3', '1005', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10081', '邯山区', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10082', '丛台区', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10083', '复兴区', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10084', '峰峰矿区', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10085', '邯郸县', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10086', '临漳县', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10087', '成安县', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10088', '大名县', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10089', '涉县', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10090', '磁县', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10091', '肥乡县', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10092', '永年县', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10093', '邱县', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10094', '鸡泽县', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10095', '广平县', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10096', '馆陶县', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10097', '魏县', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10098', '曲周县', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10099', '武安市', '', '3', '1006', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10100', '桥东区', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10101', '桥西区', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10102', '邢台县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10103', '临城县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10104', '内丘县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10105', '柏乡县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10106', '隆尧县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10107', '任县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10108', '南和县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10109', '宁晋县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10110', '巨鹿县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10111', '新河县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10112', '广宗县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10113', '平乡县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10114', '威县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10115', '清河县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10116', '临西县', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10117', '南宫市', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10118', '沙河市', '', '3', '1007', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10119', '新市区', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10120', '北市区', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10121', '南市区', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10122', '满城县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10123', '清苑县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10124', '涞水县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10125', '阜平县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10126', '徐水县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10127', '定兴县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10128', '唐县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10129', '高阳县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10130', '容城县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10131', '涞源县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10132', '望都县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10133', '安新县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10134', '易县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10135', '曲阳县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10136', '蠡县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10137', '顺平县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10138', '博野县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10139', '雄县', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10140', '涿州市', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10141', '定州市', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10142', '安国市', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10143', '高碑店市', '', '3', '1008', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10144', '桥东区', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10145', '桥西区', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10146', '宣化区', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10147', '下花园区', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10148', '宣化县', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10149', '张北县', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10150', '康保县', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10151', '沽源县', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10152', '尚义县', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10153', '蔚县', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10154', '阳原县', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10155', '怀安县', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10156', '万全县', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10157', '怀来县', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10158', '涿鹿县', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10159', '赤城县', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10160', '崇礼县', '', '3', '1009', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10161', '双桥区', '', '3', '1010', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10162', '双滦区', '', '3', '1010', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10163', '鹰手营子矿区', '', '3', '1010', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10164', '承德县', '', '3', '1010', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10165', '兴隆县', '', '3', '1010', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10166', '平泉县', '', '3', '1010', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10167', '滦平县', '', '3', '1010', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10168', '隆化县', '', '3', '1010', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10169', '丰宁满族自治县', '', '3', '1010', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10170', '宽城满族自治县', '', '3', '1010', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10171', '围场满族蒙古族自治县', '', '3', '1010', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10172', '新华区', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10173', '运河区', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10174', '沧县', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10175', '青县', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10176', '东光县', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10177', '海兴县', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10178', '盐山县', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10179', '肃宁县', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10180', '南皮县', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10181', '吴桥县', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10182', '献县', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10183', '孟村回族自治县', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10184', '泊头市', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10185', '任丘市', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10186', '黄骅市', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10187', '河间市', '', '3', '1011', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10188', '安次区', '', '3', '1012', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10189', '广阳区', '', '3', '1012', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10190', '固安县', '', '3', '1012', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10191', '永清县', '', '3', '1012', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10192', '香河县', '', '3', '1012', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10193', '大城县', '', '3', '1012', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10194', '文安县', '', '3', '1012', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10195', '大厂回族自治县', '', '3', '1012', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10196', '霸州市', '', '3', '1012', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10197', '三河市', '', '3', '1012', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10198', '桃城区', '', '3', '1013', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10199', '枣强县', '', '3', '1013', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10200', '武邑县', '', '3', '1013', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10201', '武强县', '', '3', '1013', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10202', '饶阳县', '', '3', '1013', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10203', '安平县', '', '3', '1013', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10204', '故城县', '', '3', '1013', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10205', '景县', '', '3', '1013', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10206', '阜城县', '', '3', '1013', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10207', '冀州市', '', '3', '1013', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10208', '深州市', '', '3', '1013', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10209', '小店区', '', '3', '1014', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10210', '迎泽区', '', '3', '1014', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10211', '杏花岭区', '', '3', '1014', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10212', '尖草坪区', '', '3', '1014', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10213', '万柏林区', '', '3', '1014', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10214', '晋源区', '', '3', '1014', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10215', '清徐县', '', '3', '1014', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10216', '阳曲县', '', '3', '1014', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10217', '娄烦县', '', '3', '1014', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10218', '古交市', '', '3', '1014', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10219', '城区', '', '3', '1015', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10220', '矿区', '', '3', '1015', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10221', '南郊区', '', '3', '1015', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10222', '新荣区', '', '3', '1015', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10223', '阳高县', '', '3', '1015', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10224', '天镇县', '', '3', '1015', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10225', '广灵县', '', '3', '1015', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10226', '灵丘县', '', '3', '1015', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10227', '浑源县', '', '3', '1015', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10228', '左云县', '', '3', '1015', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10229', '大同县', '', '3', '1015', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10230', '城区', '', '3', '1016', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10231', '矿区', '', '3', '1016', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10232', '郊区', '', '3', '1016', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10233', '平定县', '', '3', '1016', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10234', '盂县', '', '3', '1016', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10235', '城区', '', '3', '1017', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10236', '郊区', '', '3', '1017', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10237', '长治县', '', '3', '1017', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10238', '襄垣县', '', '3', '1017', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10239', '屯留县', '', '3', '1017', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10240', '平顺县', '', '3', '1017', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10241', '黎城县', '', '3', '1017', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10242', '壶关县', '', '3', '1017', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10243', '长子县', '', '3', '1017', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10244', '武乡县', '', '3', '1017', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10245', '沁县', '', '3', '1017', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10246', '沁源县', '', '3', '1017', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10247', '潞城市', '', '3', '1017', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10248', '城区', '', '3', '1018', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10249', '沁水县', '', '3', '1018', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10250', '阳城县', '', '3', '1018', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10251', '陵川县', '', '3', '1018', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10252', '泽州县', '', '3', '1018', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10253', '高平市', '', '3', '1018', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10254', '朔城区', '', '3', '1019', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10255', '平鲁区', '', '3', '1019', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10256', '山阴县', '', '3', '1019', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10257', '应县', '', '3', '1019', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10258', '右玉县', '', '3', '1019', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10259', '怀仁县', '', '3', '1019', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10260', '榆次区', '', '3', '1020', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10261', '榆社县', '', '3', '1020', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10262', '左权县', '', '3', '1020', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10263', '和顺县', '', '3', '1020', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10264', '昔阳县', '', '3', '1020', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10265', '寿阳县', '', '3', '1020', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10266', '太谷县', '', '3', '1020', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10267', '祁县', '', '3', '1020', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10268', '平遥县', '', '3', '1020', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10269', '灵石县', '', '3', '1020', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10270', '介休市', '', '3', '1020', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10271', '盐湖区', '', '3', '1021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10272', '临猗县', '', '3', '1021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10273', '万荣县', '', '3', '1021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10274', '闻喜县', '', '3', '1021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10275', '稷山县', '', '3', '1021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10276', '新绛县', '', '3', '1021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10277', '绛县', '', '3', '1021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10278', '垣曲县', '', '3', '1021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10279', '夏县', '', '3', '1021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10280', '平陆县', '', '3', '1021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10281', '芮城县', '', '3', '1021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10282', '永济市', '', '3', '1021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10283', '河津市', '', '3', '1021', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10284', '忻府区', '', '3', '1022', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10285', '定襄县', '', '3', '1022', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10286', '五台县', '', '3', '1022', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10287', '代县', '', '3', '1022', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10288', '繁峙县', '', '3', '1022', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10289', '宁武县', '', '3', '1022', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10290', '静乐县', '', '3', '1022', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10291', '神池县', '', '3', '1022', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10292', '五寨县', '', '3', '1022', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10293', '岢岚县', '', '3', '1022', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10294', '河曲县', '', '3', '1022', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10295', '保德县', '', '3', '1022', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10296', '偏关县', '', '3', '1022', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10297', '原平市', '', '3', '1022', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10298', '尧都区', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10299', '曲沃县', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10300', '翼城县', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10301', '襄汾县', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10302', '洪洞县', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10303', '古县', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10304', '安泽县', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10305', '浮山县', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10306', '吉县', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10307', '乡宁县', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10308', '大宁县', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10309', '隰县', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10310', '永和县', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10311', '蒲县', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10312', '汾西县', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10313', '侯马市', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10314', '霍州市', '', '3', '1023', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10315', '离石区', '', '3', '1024', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10316', '文水县', '', '3', '1024', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10317', '交城县', '', '3', '1024', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10318', '兴县', '', '3', '1024', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10319', '临县', '', '3', '1024', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10320', '柳林县', '', '3', '1024', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10321', '石楼县', '', '3', '1024', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10322', '岚县', '', '3', '1024', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10323', '方山县', '', '3', '1024', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10324', '中阳县', '', '3', '1024', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10325', '交口县', '', '3', '1024', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10326', '孝义市', '', '3', '1024', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10327', '汾阳市', '', '3', '1024', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10328', '新城区', '', '3', '1025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10329', '回民区', '', '3', '1025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10330', '玉泉区', '', '3', '1025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10331', '赛罕区', '', '3', '1025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10332', '土默特左旗', '', '3', '1025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10333', '托克托县', '', '3', '1025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10334', '和林格尔县', '', '3', '1025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10335', '清水河县', '', '3', '1025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10336', '武川县', '', '3', '1025', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10337', '东河区', '', '3', '1026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10338', '昆都仑区', '', '3', '1026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10339', '青山区', '', '3', '1026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10340', '石拐区', '', '3', '1026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10341', '白云矿区', '', '3', '1026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10342', '九原区', '', '3', '1026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10343', '土默特右旗', '', '3', '1026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10344', '固阳县', '', '3', '1026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10345', '达尔罕茂明安联合旗', '', '3', '1026', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10346', '海勃湾区', '', '3', '1027', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10347', '海南区', '', '3', '1027', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10348', '乌达区', '', '3', '1027', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10349', '红山区', '', '3', '1028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10350', '元宝山区', '', '3', '1028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10351', '松山区', '', '3', '1028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10352', '阿鲁科尔沁旗', '', '3', '1028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10353', '巴林左旗', '', '3', '1028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10354', '巴林右旗', '', '3', '1028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10355', '林西县', '', '3', '1028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10356', '克什克腾旗', '', '3', '1028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10357', '翁牛特旗', '', '3', '1028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10358', '喀喇沁旗', '', '3', '1028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10359', '宁城县', '', '3', '1028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10360', '敖汉旗', '', '3', '1028', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10361', '科尔沁区', '', '3', '1029', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10362', '科尔沁左翼中旗', '', '3', '1029', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10363', '科尔沁左翼后旗', '', '3', '1029', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10364', '开鲁县', '', '3', '1029', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10365', '库伦旗', '', '3', '1029', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10366', '奈曼旗', '', '3', '1029', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10367', '扎鲁特旗', '', '3', '1029', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10368', '霍林郭勒市', '', '3', '1029', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10369', '东胜区', '', '3', '1030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10370', '达拉特旗', '', '3', '1030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10371', '准格尔旗', '', '3', '1030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10372', '鄂托克前旗', '', '3', '1030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10373', '鄂托克旗', '', '3', '1030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10374', '杭锦旗', '', '3', '1030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10375', '乌审旗', '', '3', '1030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10376', '伊金霍洛旗', '', '3', '1030', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10377', '海拉尔区', '', '3', '1031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10378', '阿荣旗', '', '3', '1031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10379', '莫力达瓦达斡尔族自治旗', '', '3', '1031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10380', '鄂伦春自治旗', '', '3', '1031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10381', '鄂温克族自治旗', '', '3', '1031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10382', '陈巴尔虎旗', '', '3', '1031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10383', '新巴尔虎左旗', '', '3', '1031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10384', '新巴尔虎右旗', '', '3', '1031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10385', '满洲里市', '', '3', '1031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10386', '牙克石市', '', '3', '1031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10387', '扎兰屯市', '', '3', '1031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10388', '额尔古纳市', '', '3', '1031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10389', '根河市', '', '3', '1031', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10390', '临河区', '', '3', '1032', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10391', '五原县', '', '3', '1032', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10392', '磴口县', '', '3', '1032', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10393', '乌拉特前旗', '', '3', '1032', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10394', '乌拉特中旗', '', '3', '1032', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10395', '乌拉特后旗', '', '3', '1032', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10396', '杭锦后旗', '', '3', '1032', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10397', '集宁区', '', '3', '1033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10398', '卓资县', '', '3', '1033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10399', '化德县', '', '3', '1033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10400', '商都县', '', '3', '1033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10401', '兴和县', '', '3', '1033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10402', '凉城县', '', '3', '1033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10403', '察哈尔右翼前旗', '', '3', '1033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10404', '察哈尔右翼中旗', '', '3', '1033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10405', '察哈尔右翼后旗', '', '3', '1033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10406', '四子王旗', '', '3', '1033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10407', '丰镇市', '', '3', '1033', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10408', '乌兰浩特市', '', '3', '1034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10409', '阿尔山市', '', '3', '1034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10410', '科尔沁右翼前旗', '', '3', '1034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10411', '科尔沁右翼中旗', '', '3', '1034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10412', '扎赉特旗', '', '3', '1034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10413', '突泉县', '', '3', '1034', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10414', '二连浩特市', '', '3', '1035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10415', '锡林浩特市', '', '3', '1035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10416', '阿巴嘎旗', '', '3', '1035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10417', '苏尼特左旗', '', '3', '1035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10418', '苏尼特右旗', '', '3', '1035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10419', '东乌珠穆沁旗', '', '3', '1035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10420', '西乌珠穆沁旗', '', '3', '1035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10421', '太仆寺旗', '', '3', '1035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10422', '镶黄旗', '', '3', '1035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10423', '正镶白旗', '', '3', '1035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10424', '正蓝旗', '', '3', '1035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10425', '多伦县', '', '3', '1035', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10426', '阿拉善左旗', '', '3', '1036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10427', '阿拉善右旗', '', '3', '1036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10428', '额济纳旗', '', '3', '1036', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10429', '和平区', '', '3', '1037', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10430', '沈河区', '', '3', '1037', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10431', '大东区', '', '3', '1037', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10432', '皇姑区', '', '3', '1037', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10433', '铁西区', '', '3', '1037', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10434', '苏家屯区', '', '3', '1037', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10435', '东陵区', '', '3', '1037', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10436', '新城子区', '', '3', '1037', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10437', '于洪区', '', '3', '1037', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10438', '辽中县', '', '3', '1037', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10439', '康平县', '', '3', '1037', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10440', '法库县', '', '3', '1037', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10441', '新民市', '', '3', '1037', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10442', '中山区', '', '3', '1038', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10443', '西岗区', '', '3', '1038', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10444', '沙河口区', '', '3', '1038', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10445', '甘井子区', '', '3', '1038', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10446', '旅顺口区', '', '3', '1038', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10447', '金州区', '', '3', '1038', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10448', '长海县', '', '3', '1038', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10449', '瓦房店市', '', '3', '1038', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10450', '普兰店市', '', '3', '1038', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10451', '庄河市', '', '3', '1038', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10452', '铁东区', '', '3', '1039', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10453', '铁西区', '', '3', '1039', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10454', '立山区', '', '3', '1039', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10455', '千山区', '', '3', '1039', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10456', '台安县', '', '3', '1039', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10457', '岫岩满族自治县', '', '3', '1039', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10458', '海城市', '', '3', '1039', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10459', '新抚区', '', '3', '1040', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10460', '东洲区', '', '3', '1040', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10461', '望花区', '', '3', '1040', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10462', '顺城区', '', '3', '1040', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10463', '抚顺县', '', '3', '1040', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10464', '新宾满族自治县', '', '3', '1040', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10465', '清原满族自治县', '', '3', '1040', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10466', '平山区', '', '3', '1041', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10467', '溪湖区', '', '3', '1041', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10468', '明山区', '', '3', '1041', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10469', '南芬区', '', '3', '1041', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10470', '本溪满族自治县', '', '3', '1041', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10471', '桓仁满族自治县', '', '3', '1041', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10472', '元宝区', '', '3', '1042', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10473', '振兴区', '', '3', '1042', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10474', '振安区', '', '3', '1042', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10475', '宽甸满族自治县', '', '3', '1042', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10476', '东港市', '', '3', '1042', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10477', '凤城市', '', '3', '1042', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10478', '古塔区', '', '3', '1043', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10479', '凌河区', '', '3', '1043', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10480', '太和区', '', '3', '1043', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10481', '黑山县', '', '3', '1043', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10482', '义县', '', '3', '1043', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10483', '凌海市', '', '3', '1043', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10484', '北宁市', '', '3', '1043', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10485', '站前区', '', '3', '1044', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10486', '西市区', '', '3', '1044', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10487', '鲅鱼圈区', '', '3', '1044', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10488', '老边区', '', '3', '1044', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10489', '盖州市', '', '3', '1044', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10490', '大石桥市', '', '3', '1044', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10491', '海州区', '', '3', '1045', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10492', '新邱区', '', '3', '1045', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10493', '太平区', '', '3', '1045', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10494', '清河门区', '', '3', '1045', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10495', '细河区', '', '3', '1045', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10496', '阜新蒙古族自治县', '', '3', '1045', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10497', '彰武县', '', '3', '1045', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10498', '白塔区', '', '3', '1046', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10499', '文圣区', '', '3', '1046', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10500', '宏伟区', '', '3', '1046', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10501', '弓长岭区', '', '3', '1046', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10502', '太子河区', '', '3', '1046', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10503', '辽阳县', '', '3', '1046', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10504', '灯塔市', '', '3', '1046', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10505', '双台子区', '', '3', '1047', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10506', '兴隆台区', '', '3', '1047', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10507', '大洼县', '', '3', '1047', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10508', '盘山县', '', '3', '1047', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10509', '银州区', '', '3', '1048', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10510', '清河区', '', '3', '1048', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10511', '铁岭县', '', '3', '1048', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10512', '西丰县', '', '3', '1048', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10513', '昌图县', '', '3', '1048', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10514', '调兵山市', '', '3', '1048', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10515', '开原市', '', '3', '1048', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10516', '双塔区', '', '3', '1049', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10517', '龙城区', '', '3', '1049', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10518', '朝阳县', '', '3', '1049', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10519', '建平县', '', '3', '1049', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10520', '喀喇沁左翼蒙古族自治县', '', '3', '1049', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10521', '北票市', '', '3', '1049', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10522', '凌源市', '', '3', '1049', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10523', '连山区', '', '3', '1050', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10524', '龙港区', '', '3', '1050', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10525', '南票区', '', '3', '1050', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10526', '绥中县', '', '3', '1050', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10527', '建昌县', '', '3', '1050', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10528', '兴城市', '', '3', '1050', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10529', '南关区', '', '3', '1051', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10530', '宽城区', '', '3', '1051', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10531', '朝阳区', '', '3', '1051', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10532', '二道区', '', '3', '1051', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10533', '绿园区', '', '3', '1051', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10534', '双阳区', '', '3', '1051', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10535', '农安县', '', '3', '1051', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10536', '九台市', '', '3', '1051', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10537', '榆树市', '', '3', '1051', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10538', '德惠市', '', '3', '1051', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10539', '昌邑区', '', '3', '1052', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10540', '龙潭区', '', '3', '1052', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10541', '船营区', '', '3', '1052', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10542', '丰满区', '', '3', '1052', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10543', '永吉县', '', '3', '1052', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10544', '蛟河市', '', '3', '1052', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10545', '桦甸市', '', '3', '1052', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10546', '舒兰市', '', '3', '1052', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10547', '磐石市', '', '3', '1052', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10548', '铁西区', '', '3', '1053', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10549', '铁东区', '', '3', '1053', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10550', '梨树县', '', '3', '1053', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10551', '伊通满族自治县', '', '3', '1053', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10552', '公主岭市', '', '3', '1053', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10553', '双辽市', '', '3', '1053', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10554', '龙山区', '', '3', '1054', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10555', '西安区', '', '3', '1054', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10556', '东丰县', '', '3', '1054', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10557', '东辽县', '', '3', '1054', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10558', '东昌区', '', '3', '1055', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10559', '二道江区', '', '3', '1055', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10560', '通化县', '', '3', '1055', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10561', '辉南县', '', '3', '1055', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10562', '柳河县', '', '3', '1055', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10563', '梅河口市', '', '3', '1055', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10564', '集安市', '', '3', '1055', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10565', '八道江区', '', '3', '1056', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10566', '抚松县', '', '3', '1056', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10567', '靖宇县', '', '3', '1056', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10568', '长白朝鲜族自治县', '', '3', '1056', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10569', '江源县', '', '3', '1056', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10570', '临江市', '', '3', '1056', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10571', '宁江区', '', '3', '1057', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10572', '前郭尔罗斯蒙古族自治县', '', '3', '1057', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10573', '长岭县', '', '3', '1057', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10574', '乾安县', '', '3', '1057', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10575', '扶余县', '', '3', '1057', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10576', '洮北区', '', '3', '1058', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10577', '镇赉县', '', '3', '1058', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10578', '通榆县', '', '3', '1058', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10579', '洮南市', '', '3', '1058', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10580', '大安市', '', '3', '1058', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10581', '延吉市', '', '3', '1059', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10582', '图们市', '', '3', '1059', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10583', '敦化市', '', '3', '1059', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10584', '珲春市', '', '3', '1059', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10585', '龙井市', '', '3', '1059', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10586', '和龙市', '', '3', '1059', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10587', '汪清县', '', '3', '1059', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10588', '安图县', '', '3', '1059', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10589', '道里区', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10590', '南岗区', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10591', '道外区', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10592', '香坊区', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10593', '动力区', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10594', '平房区', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10595', '松北区', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10596', '呼兰区', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10597', '依兰县', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10598', '方正县', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10599', '宾县', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10600', '巴彦县', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10601', '木兰县', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10602', '通河县', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10603', '延寿县', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10604', '阿城市', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10605', '双城市', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10606', '尚志市', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10607', '五常市', '', '3', '1060', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10608', '龙沙区', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10609', '建华区', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10610', '铁锋区', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10611', '昂昂溪区', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10612', '富拉尔基区', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10613', '碾子山区', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10614', '梅里斯达斡尔族区', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10615', '龙江县', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10616', '依安县', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10617', '泰来县', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10618', '甘南县', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10619', '富裕县', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10620', '克山县', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10621', '克东县', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10622', '拜泉县', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10623', '讷河市', '', '3', '1061', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10624', '鸡冠区', '', '3', '1062', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10625', '恒山区', '', '3', '1062', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10626', '滴道区', '', '3', '1062', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10627', '梨树区', '', '3', '1062', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10628', '城子河区', '', '3', '1062', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10629', '麻山区', '', '3', '1062', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10630', '鸡东县', '', '3', '1062', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10631', '虎林市', '', '3', '1062', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10632', '密山市', '', '3', '1062', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10633', '向阳区', '', '3', '1063', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10634', '工农区', '', '3', '1063', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10635', '南山区', '', '3', '1063', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10636', '兴安区', '', '3', '1063', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10637', '东山区', '', '3', '1063', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10638', '兴山区', '', '3', '1063', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10639', '萝北县', '', '3', '1063', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10640', '绥滨县', '', '3', '1063', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10641', '尖山区', '', '3', '1064', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10642', '岭东区', '', '3', '1064', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10643', '四方台区', '', '3', '1064', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10644', '宝山区', '', '3', '1064', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10645', '集贤县', '', '3', '1064', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10646', '友谊县', '', '3', '1064', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10647', '宝清县', '', '3', '1064', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10648', '饶河县', '', '3', '1064', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10649', '萨尔图区', '', '3', '1065', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10650', '龙凤区', '', '3', '1065', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10651', '让胡路区', '', '3', '1065', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10652', '红岗区', '', '3', '1065', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10653', '大同区', '', '3', '1065', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10654', '肇州县', '', '3', '1065', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10655', '肇源县', '', '3', '1065', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10656', '林甸县', '', '3', '1065', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10657', '杜尔伯特蒙古族自治县', '', '3', '1065', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10658', '伊春区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10659', '南岔区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10660', '友好区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10661', '西林区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10662', '翠峦区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10663', '新青区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10664', '美溪区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10665', '金山屯区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10666', '五营区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10667', '乌马河区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10668', '汤旺河区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10669', '带岭区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10670', '乌伊岭区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10671', '红星区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10672', '上甘岭区', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10673', '嘉荫县', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10674', '铁力市', '', '3', '1066', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10675', '永红区', '', '3', '1067', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10676', '向阳区', '', '3', '1067', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10677', '前进区', '', '3', '1067', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10678', '东风区', '', '3', '1067', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10679', '郊区', '', '3', '1067', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10680', '桦南县', '', '3', '1067', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10681', '桦川县', '', '3', '1067', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10682', '汤原县', '', '3', '1067', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10683', '抚远县', '', '3', '1067', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10684', '同江市', '', '3', '1067', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10685', '富锦市', '', '3', '1067', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10686', '新兴区', '', '3', '1068', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10687', '桃山区', '', '3', '1068', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10688', '茄子河区', '', '3', '1068', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10689', '勃利县', '', '3', '1068', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10690', '东安区', '', '3', '1069', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10691', '阳明区', '', '3', '1069', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10692', '爱民区', '', '3', '1069', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10693', '西安区', '', '3', '1069', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10694', '东宁县', '', '3', '1069', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10695', '林口县', '', '3', '1069', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10696', '绥芬河市', '', '3', '1069', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10697', '海林市', '', '3', '1069', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10698', '宁安市', '', '3', '1069', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10699', '穆棱市', '', '3', '1069', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10700', '爱辉区', '', '3', '1070', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10701', '嫩江县', '', '3', '1070', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10702', '逊克县', '', '3', '1070', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10703', '孙吴县', '', '3', '1070', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10704', '北安市', '', '3', '1070', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10705', '五大连池市', '', '3', '1070', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10706', '北林区', '', '3', '1071', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10707', '望奎县', '', '3', '1071', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10708', '兰西县', '', '3', '1071', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10709', '青冈县', '', '3', '1071', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10710', '庆安县', '', '3', '1071', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10711', '明水县', '', '3', '1071', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10712', '绥棱县', '', '3', '1071', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10713', '安达市', '', '3', '1071', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10714', '肇东市', '', '3', '1071', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10715', '海伦市', '', '3', '1071', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10716', '呼玛县', '', '3', '1072', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10717', '塔河县', '', '3', '1072', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10718', '漠河县', '', '3', '1072', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10719', '黄浦区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10720', '卢湾区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10721', '徐汇区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10722', '长宁区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10723', '静安区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10724', '普陀区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10725', '闸北区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10726', '虹口区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10727', '杨浦区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10728', '闵行区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10729', '宝山区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10730', '嘉定区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10731', '浦东新区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10732', '金山区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10733', '松江区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10734', '青浦区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10735', '南汇区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10736', '奉贤区', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10737', '崇明县', '', '3', '1073', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10738', '玄武区', '', '3', '1074', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10739', '白下区', '', '3', '1074', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10740', '秦淮区', '', '3', '1074', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10741', '建邺区', '', '3', '1074', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10742', '鼓楼区', '', '3', '1074', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10743', '下关区', '', '3', '1074', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10744', '浦口区', '', '3', '1074', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10745', '栖霞区', '', '3', '1074', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10746', '雨花台区', '', '3', '1074', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10747', '江宁区', '', '3', '1074', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10748', '六合区', '', '3', '1074', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10749', '溧水县', '', '3', '1074', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10750', '高淳县', '', '3', '1074', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10751', '崇安区', '', '3', '1075', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10752', '南长区', '', '3', '1075', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10753', '北塘区', '', '3', '1075', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10754', '锡山区', '', '3', '1075', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10755', '惠山区', '', '3', '1075', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10756', '滨湖区', '', '3', '1075', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10757', '江阴市', '', '3', '1075', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10758', '宜兴市', '', '3', '1075', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10759', '鼓楼区', '', '3', '1076', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10760', '云龙区', '', '3', '1076', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10761', '九里区', '', '3', '1076', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10762', '贾汪区', '', '3', '1076', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10763', '泉山区', '', '3', '1076', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10764', '丰县', '', '3', '1076', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10765', '沛县', '', '3', '1076', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10766', '铜山县', '', '3', '1076', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10767', '睢宁县', '', '3', '1076', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10768', '新沂市', '', '3', '1076', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10769', '邳州市', '', '3', '1076', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10770', '天宁区', '', '3', '1077', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10771', '钟楼区', '', '3', '1077', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10772', '戚墅堰区', '', '3', '1077', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10773', '新北区', '', '3', '1077', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10774', '武进区', '', '3', '1077', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10775', '溧阳市', '', '3', '1077', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10776', '金坛市', '', '3', '1077', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10777', '沧浪区', '', '3', '1078', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10778', '平江区', '', '3', '1078', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10779', '金阊区', '', '3', '1078', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10780', '虎丘区', '', '3', '1078', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10781', '吴中区', '', '3', '1078', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10782', '相城区', '', '3', '1078', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10783', '常熟市', '', '3', '1078', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10784', '张家港市', '', '3', '1078', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10785', '昆山市', '', '3', '1078', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10786', '吴江市', '', '3', '1078', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10787', '太仓市', '', '3', '1078', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10788', '崇川区', '', '3', '1079', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10789', '港闸区', '', '3', '1079', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10790', '海安县', '', '3', '1079', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10791', '如东县', '', '3', '1079', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10792', '启东市', '', '3', '1079', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10793', '如皋市', '', '3', '1079', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10794', '通州市', '', '3', '1079', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10795', '海门市', '', '3', '1079', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10796', '连云区', '', '3', '1080', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10797', '新浦区', '', '3', '1080', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10798', '海州区', '', '3', '1080', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10799', '赣榆县', '', '3', '1080', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10800', '东海县', '', '3', '1080', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10801', '灌云县', '', '3', '1080', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10802', '灌南县', '', '3', '1080', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10803', '清河区', '', '3', '1081', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10804', '楚州区', '', '3', '1081', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10805', '淮阴区', '', '3', '1081', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10806', '清浦区', '', '3', '1081', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10807', '涟水县', '', '3', '1081', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10808', '洪泽县', '', '3', '1081', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10809', '盱眙县', '', '3', '1081', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10810', '金湖县', '', '3', '1081', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10811', '亭湖区', '', '3', '1082', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10812', '盐都区', '', '3', '1082', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10813', '响水县', '', '3', '1082', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10814', '滨海县', '', '3', '1082', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10815', '阜宁县', '', '3', '1082', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10816', '射阳县', '', '3', '1082', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10817', '建湖县', '', '3', '1082', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10818', '东台市', '', '3', '1082', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10819', '大丰市', '', '3', '1082', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10820', '广陵区', '', '3', '1083', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10821', '邗江区', '', '3', '1083', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10822', '维扬区', '', '3', '1083', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10823', '宝应县', '', '3', '1083', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10824', '仪征市', '', '3', '1083', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10825', '高邮市', '', '3', '1083', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10826', '江都市', '', '3', '1083', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10827', '京口区', '', '3', '1084', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10828', '润州区', '', '3', '1084', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10829', '丹徒区', '', '3', '1084', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10830', '丹阳市', '', '3', '1084', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10831', '扬中市', '', '3', '1084', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10832', '句容市', '', '3', '1084', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10833', '海陵区', '', '3', '1085', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10834', '高港区', '', '3', '1085', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10835', '兴化市', '', '3', '1085', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10836', '靖江市', '', '3', '1085', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10837', '泰兴市', '', '3', '1085', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10838', '姜堰市', '', '3', '1085', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10839', '宿城区', '', '3', '1086', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10840', '宿豫区', '', '3', '1086', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10841', '沭阳县', '', '3', '1086', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10842', '泗阳县', '', '3', '1086', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10843', '泗洪县', '', '3', '1086', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10844', '上城区', '', '3', '1087', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10845', '下城区', '', '3', '1087', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10846', '江干区', '', '3', '1087', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10847', '拱墅区', '', '3', '1087', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10848', '西湖区', '', '3', '1087', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10849', '滨江区', '', '3', '1087', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10850', '萧山区', '', '3', '1087', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10851', '余杭区', '', '3', '1087', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10852', '桐庐县', '', '3', '1087', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10853', '淳安县', '', '3', '1087', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10854', '建德市', '', '3', '1087', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10855', '富阳市', '', '3', '1087', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10856', '临安市', '', '3', '1087', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10857', '海曙区', '', '3', '1088', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10858', '江东区', '', '3', '1088', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10859', '江北区', '', '3', '1088', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10860', '北仑区', '', '3', '1088', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10861', '镇海区', '', '3', '1088', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10862', '鄞州区', '', '3', '1088', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10863', '象山县', '', '3', '1088', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10864', '宁海县', '', '3', '1088', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10865', '余姚市', '', '3', '1088', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10866', '慈溪市', '', '3', '1088', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10867', '奉化市', '', '3', '1088', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10868', '鹿城区', '', '3', '1089', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10869', '龙湾区', '', '3', '1089', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10870', '瓯海区', '', '3', '1089', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10871', '洞头县', '', '3', '1089', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10872', '永嘉县', '', '3', '1089', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10873', '平阳县', '', '3', '1089', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10874', '苍南县', '', '3', '1089', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10875', '文成县', '', '3', '1089', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10876', '泰顺县', '', '3', '1089', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10877', '瑞安市', '', '3', '1089', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10878', '乐清市', '', '3', '1089', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10879', '秀城区', '', '3', '1090', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10880', '秀洲区', '', '3', '1090', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10881', '嘉善县', '', '3', '1090', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10882', '海盐县', '', '3', '1090', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10883', '海宁市', '', '3', '1090', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10884', '平湖市', '', '3', '1090', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10885', '桐乡市', '', '3', '1090', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10886', '吴兴区', '', '3', '1091', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10887', '南浔区', '', '3', '1091', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10888', '德清县', '', '3', '1091', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10889', '长兴县', '', '3', '1091', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10890', '安吉县', '', '3', '1091', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10891', '越城区', '', '3', '1092', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10892', '绍兴县', '', '3', '1092', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10893', '新昌县', '', '3', '1092', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10894', '诸暨市', '', '3', '1092', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10895', '上虞市', '', '3', '1092', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10896', '嵊州市', '', '3', '1092', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10897', '婺城区', '', '3', '1093', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10898', '金东区', '', '3', '1093', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10899', '武义县', '', '3', '1093', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10900', '浦江县', '', '3', '1093', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10901', '磐安县', '', '3', '1093', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10902', '兰溪市', '', '3', '1093', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10903', '义乌市', '', '3', '1093', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10904', '东阳市', '', '3', '1093', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10905', '永康市', '', '3', '1093', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10906', '柯城区', '', '3', '1094', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10907', '衢江区', '', '3', '1094', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10908', '常山县', '', '3', '1094', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10909', '开化县', '', '3', '1094', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10910', '龙游县', '', '3', '1094', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10911', '江山市', '', '3', '1094', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10912', '定海区', '', '3', '1095', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10913', '普陀区', '', '3', '1095', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10914', '岱山县', '', '3', '1095', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10915', '嵊泗县', '', '3', '1095', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10916', '椒江区', '', '3', '1096', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10917', '黄岩区', '', '3', '1096', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10918', '路桥区', '', '3', '1096', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10919', '玉环县', '', '3', '1096', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10920', '三门县', '', '3', '1096', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10921', '天台县', '', '3', '1096', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10922', '仙居县', '', '3', '1096', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10923', '温岭市', '', '3', '1096', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10924', '临海市', '', '3', '1096', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10925', '莲都区', '', '3', '1097', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10926', '青田县', '', '3', '1097', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10927', '缙云县', '', '3', '1097', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10928', '遂昌县', '', '3', '1097', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10929', '松阳县', '', '3', '1097', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10930', '云和县', '', '3', '1097', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10931', '庆元县', '', '3', '1097', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10932', '景宁畲族自治县', '', '3', '1097', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10933', '龙泉市', '', '3', '1097', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10934', '瑶海区', '', '3', '1098', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10935', '庐阳区', '', '3', '1098', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10936', '蜀山区', '', '3', '1098', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10937', '包河区', '', '3', '1098', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10938', '长丰县', '', '3', '1098', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10939', '肥东县', '', '3', '1098', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10940', '肥西县', '', '3', '1098', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10941', '镜湖区', '', '3', '1099', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10942', '马塘区', '', '3', '1099', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10943', '新芜区', '', '3', '1099', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10944', '鸠江区', '', '3', '1099', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10945', '芜湖县', '', '3', '1099', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10946', '繁昌县', '', '3', '1099', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10947', '南陵县', '', '3', '1099', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10948', '龙子湖区', '', '3', '1100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10949', '蚌山区', '', '3', '1100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10950', '禹会区', '', '3', '1100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10951', '淮上区', '', '3', '1100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10952', '怀远县', '', '3', '1100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10953', '五河县', '', '3', '1100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10954', '固镇县', '', '3', '1100', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10955', '大通区', '', '3', '1101', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10956', '田家庵区', '', '3', '1101', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10957', '谢家集区', '', '3', '1101', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10958', '八公山区', '', '3', '1101', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10959', '潘集区', '', '3', '1101', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10960', '凤台县', '', '3', '1101', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10961', '金家庄区', '', '3', '1102', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10962', '花山区', '', '3', '1102', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10963', '雨山区', '', '3', '1102', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10964', '当涂县', '', '3', '1102', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10965', '杜集区', '', '3', '1103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10966', '相山区', '', '3', '1103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10967', '烈山区', '', '3', '1103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10968', '濉溪县', '', '3', '1103', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10969', '铜官山区', '', '3', '1104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10970', '狮子山区', '', '3', '1104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10971', '郊区', '', '3', '1104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10972', '铜陵县', '', '3', '1104', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10973', '迎江区', '', '3', '1105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10974', '大观区', '', '3', '1105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10975', '郊区', '', '3', '1105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10976', '怀宁县', '', '3', '1105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10977', '枞阳县', '', '3', '1105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10978', '潜山县', '', '3', '1105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10979', '太湖县', '', '3', '1105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10980', '宿松县', '', '3', '1105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10981', '望江县', '', '3', '1105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10982', '岳西县', '', '3', '1105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10983', '桐城市', '', '3', '1105', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10984', '屯溪区', '', '3', '1106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10985', '黄山区', '', '3', '1106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10986', '徽州区', '', '3', '1106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10987', '歙县', '', '3', '1106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10988', '休宁县', '', '3', '1106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10989', '黟县', '', '3', '1106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10990', '祁门县', '', '3', '1106', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10991', '琅琊区', '', '3', '1107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10992', '南谯区', '', '3', '1107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10993', '来安县', '', '3', '1107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10994', '全椒县', '', '3', '1107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10995', '定远县', '', '3', '1107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10996', '凤阳县', '', '3', '1107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10997', '天长市', '', '3', '1107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10998', '明光市', '', '3', '1107', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('10999', '颍州区', '', '3', '1108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11000', '颍东区', '', '3', '1108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11001', '颍泉区', '', '3', '1108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11002', '临泉县', '', '3', '1108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11003', '太和县', '', '3', '1108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11004', '阜南县', '', '3', '1108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11005', '颍上县', '', '3', '1108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11006', '界首市', '', '3', '1108', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11007', '埇桥区', '', '3', '1109', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11008', '砀山县', '', '3', '1109', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11009', '萧县', '', '3', '1109', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11010', '灵璧县', '', '3', '1109', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11011', '泗县', '', '3', '1109', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11012', '居巢区', '', '3', '1110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11013', '庐江县', '', '3', '1110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11014', '无为县', '', '3', '1110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11015', '含山县', '', '3', '1110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11016', '和县', '', '3', '1110', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11017', '金安区', '', '3', '1111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11018', '裕安区', '', '3', '1111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11019', '寿县', '', '3', '1111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11020', '霍邱县', '', '3', '1111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11021', '舒城县', '', '3', '1111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11022', '金寨县', '', '3', '1111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11023', '霍山县', '', '3', '1111', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11024', '谯城区', '', '3', '1112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11025', '涡阳县', '', '3', '1112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11026', '蒙城县', '', '3', '1112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11027', '利辛县', '', '3', '1112', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11028', '贵池区', '', '3', '1113', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11029', '东至县', '', '3', '1113', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11030', '石台县', '', '3', '1113', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11031', '青阳县', '', '3', '1113', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11032', '宣州区', '', '3', '1114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11033', '郎溪县', '', '3', '1114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11034', '广德县', '', '3', '1114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11035', '泾县', '', '3', '1114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11036', '绩溪县', '', '3', '1114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11037', '旌德县', '', '3', '1114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11038', '宁国市', '', '3', '1114', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11039', '鼓楼区', '', '3', '1115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11040', '台江区', '', '3', '1115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11041', '仓山区', '', '3', '1115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11042', '马尾区', '', '3', '1115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11043', '晋安区', '', '3', '1115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11044', '闽侯县', '', '3', '1115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11045', '连江县', '', '3', '1115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11046', '罗源县', '', '3', '1115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11047', '闽清县', '', '3', '1115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11048', '永泰县', '', '3', '1115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11049', '平潭县', '', '3', '1115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11050', '福清市', '', '3', '1115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11051', '长乐市', '', '3', '1115', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11052', '思明区', '', '3', '1116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11053', '海沧区', '', '3', '1116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11054', '湖里区', '', '3', '1116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11055', '集美区', '', '3', '1116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11056', '同安区', '', '3', '1116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11057', '翔安区', '', '3', '1116', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11058', '城厢区', '', '3', '1117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11059', '涵江区', '', '3', '1117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11060', '荔城区', '', '3', '1117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11061', '秀屿区', '', '3', '1117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11062', '仙游县', '', '3', '1117', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11063', '梅列区', '', '3', '1118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11064', '三元区', '', '3', '1118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11065', '明溪县', '', '3', '1118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11066', '清流县', '', '3', '1118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11067', '宁化县', '', '3', '1118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11068', '大田县', '', '3', '1118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11069', '尤溪县', '', '3', '1118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11070', '沙县', '', '3', '1118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11071', '将乐县', '', '3', '1118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11072', '泰宁县', '', '3', '1118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11073', '建宁县', '', '3', '1118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11074', '永安市', '', '3', '1118', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11075', '鲤城区', '', '3', '1119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11076', '丰泽区', '', '3', '1119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11077', '洛江区', '', '3', '1119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11078', '泉港区', '', '3', '1119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11079', '惠安县', '', '3', '1119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11080', '安溪县', '', '3', '1119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11081', '永春县', '', '3', '1119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11082', '德化县', '', '3', '1119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11083', '金门县', '', '3', '1119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11084', '石狮市', '', '3', '1119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11085', '晋江市', '', '3', '1119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11086', '南安市', '', '3', '1119', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11087', '芗城区', '', '3', '1120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11088', '龙文区', '', '3', '1120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11089', '云霄县', '', '3', '1120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11090', '漳浦县', '', '3', '1120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11091', '诏安县', '', '3', '1120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11092', '长泰县', '', '3', '1120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11093', '东山县', '', '3', '1120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11094', '南靖县', '', '3', '1120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11095', '平和县', '', '3', '1120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11096', '华安县', '', '3', '1120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11097', '龙海市', '', '3', '1120', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11098', '延平区', '', '3', '1121', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11099', '顺昌县', '', '3', '1121', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11100', '浦城县', '', '3', '1121', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11101', '光泽县', '', '3', '1121', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11102', '松溪县', '', '3', '1121', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11103', '政和县', '', '3', '1121', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11104', '邵武市', '', '3', '1121', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11105', '武夷山市', '', '3', '1121', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11106', '建瓯市', '', '3', '1121', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11107', '建阳市', '', '3', '1121', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11108', '新罗区', '', '3', '1122', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11109', '长汀县', '', '3', '1122', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11110', '永定县', '', '3', '1122', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11111', '上杭县', '', '3', '1122', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11112', '武平县', '', '3', '1122', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11113', '连城县', '', '3', '1122', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11114', '漳平市', '', '3', '1122', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11115', '蕉城区', '', '3', '1123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11116', '霞浦县', '', '3', '1123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11117', '古田县', '', '3', '1123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11118', '屏南县', '', '3', '1123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11119', '寿宁县', '', '3', '1123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11120', '周宁县', '', '3', '1123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11121', '柘荣县', '', '3', '1123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11122', '福安市', '', '3', '1123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11123', '福鼎市', '', '3', '1123', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11124', '东湖区', '', '3', '1124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11125', '西湖区', '', '3', '1124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11126', '青云谱区', '', '3', '1124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11127', '湾里区', '', '3', '1124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11128', '青山湖区', '', '3', '1124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11129', '南昌县', '', '3', '1124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11130', '新建县', '', '3', '1124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11131', '安义县', '', '3', '1124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11132', '进贤县', '', '3', '1124', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11133', '昌江区', '', '3', '1125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11134', '珠山区', '', '3', '1125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11135', '浮梁县', '', '3', '1125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11136', '乐平市', '', '3', '1125', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11137', '安源区', '', '3', '1126', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11138', '湘东区', '', '3', '1126', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11139', '莲花县', '', '3', '1126', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11140', '上栗县', '', '3', '1126', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11141', '芦溪县', '', '3', '1126', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11142', '庐山区', '', '3', '1127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11143', '浔阳区', '', '3', '1127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11144', '九江县', '', '3', '1127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11145', '武宁县', '', '3', '1127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11146', '修水县', '', '3', '1127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11147', '永修县', '', '3', '1127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11148', '德安县', '', '3', '1127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11149', '星子县', '', '3', '1127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11150', '都昌县', '', '3', '1127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11151', '湖口县', '', '3', '1127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11152', '彭泽县', '', '3', '1127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11153', '瑞昌市', '', '3', '1127', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11154', '渝水区', '', '3', '1128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11155', '分宜县', '', '3', '1128', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11156', '月湖区', '', '3', '1129', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11157', '余江县', '', '3', '1129', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11158', '贵溪市', '', '3', '1129', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11159', '章贡区', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11160', '赣县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11161', '信丰县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11162', '大余县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11163', '上犹县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11164', '崇义县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11165', '安远县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11166', '龙南县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11167', '定南县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11168', '全南县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11169', '宁都县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11170', '于都县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11171', '兴国县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11172', '会昌县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11173', '寻乌县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11174', '石城县', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11175', '瑞金市', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11176', '南康市', '', '3', '1130', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11177', '吉州区', '', '3', '1131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11178', '青原区', '', '3', '1131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11179', '吉安县', '', '3', '1131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11180', '吉水县', '', '3', '1131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11181', '峡江县', '', '3', '1131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11182', '新干县', '', '3', '1131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11183', '永丰县', '', '3', '1131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11184', '泰和县', '', '3', '1131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11185', '遂川县', '', '3', '1131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11186', '万安县', '', '3', '1131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11187', '安福县', '', '3', '1131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11188', '永新县', '', '3', '1131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11189', '井冈山市', '', '3', '1131', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11190', '袁州区', '', '3', '1132', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11191', '奉新县', '', '3', '1132', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11192', '万载县', '', '3', '1132', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11193', '上高县', '', '3', '1132', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11194', '宜丰县', '', '3', '1132', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11195', '靖安县', '', '3', '1132', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11196', '铜鼓县', '', '3', '1132', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11197', '丰城市', '', '3', '1132', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11198', '樟树市', '', '3', '1132', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11199', '高安市', '', '3', '1132', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11200', '临川区', '', '3', '1133', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11201', '南城县', '', '3', '1133', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11202', '黎川县', '', '3', '1133', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11203', '南丰县', '', '3', '1133', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11204', '崇仁县', '', '3', '1133', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11205', '乐安县', '', '3', '1133', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11206', '宜黄县', '', '3', '1133', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11207', '金溪县', '', '3', '1133', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11208', '资溪县', '', '3', '1133', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11209', '东乡县', '', '3', '1133', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11210', '广昌县', '', '3', '1133', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11211', '信州区', '', '3', '1134', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11212', '上饶县', '', '3', '1134', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11213', '广丰县', '', '3', '1134', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11214', '玉山县', '', '3', '1134', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11215', '铅山县', '', '3', '1134', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11216', '横峰县', '', '3', '1134', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11217', '弋阳县', '', '3', '1134', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11218', '余干县', '', '3', '1134', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11219', '鄱阳县', '', '3', '1134', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11220', '万年县', '', '3', '1134', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11221', '婺源县', '', '3', '1134', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11222', '德兴市', '', '3', '1134', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11223', '历下区', '', '3', '1135', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11224', '市中区', '', '3', '1135', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11225', '槐荫区', '', '3', '1135', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11226', '天桥区', '', '3', '1135', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11227', '历城区', '', '3', '1135', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11228', '长清区', '', '3', '1135', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11229', '平阴县', '', '3', '1135', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11230', '济阳县', '', '3', '1135', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11231', '商河县', '', '3', '1135', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11232', '章丘市', '', '3', '1135', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11233', '市南区', '', '3', '1136', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11234', '市北区', '', '3', '1136', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11235', '四方区', '', '3', '1136', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11236', '黄岛区', '', '3', '1136', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11237', '崂山区', '', '3', '1136', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11238', '李沧区', '', '3', '1136', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11239', '城阳区', '', '3', '1136', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11240', '胶州市', '', '3', '1136', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11241', '即墨市', '', '3', '1136', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11242', '平度市', '', '3', '1136', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11243', '胶南市', '', '3', '1136', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11244', '莱西市', '', '3', '1136', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11245', '淄川区', '', '3', '1137', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11246', '张店区', '', '3', '1137', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11247', '博山区', '', '3', '1137', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11248', '临淄区', '', '3', '1137', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11249', '周村区', '', '3', '1137', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11250', '桓台县', '', '3', '1137', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11251', '高青县', '', '3', '1137', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11252', '沂源县', '', '3', '1137', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11253', '市中区', '', '3', '1138', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11254', '薛城区', '', '3', '1138', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11255', '峄城区', '', '3', '1138', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11256', '台儿庄区', '', '3', '1138', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11257', '山亭区', '', '3', '1138', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11258', '滕州市', '', '3', '1138', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11259', '东营区', '', '3', '1139', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11260', '河口区', '', '3', '1139', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11261', '垦利县', '', '3', '1139', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11262', '利津县', '', '3', '1139', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11263', '广饶县', '', '3', '1139', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11264', '芝罘区', '', '3', '1140', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11265', '福山区', '', '3', '1140', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11266', '牟平区', '', '3', '1140', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11267', '莱山区', '', '3', '1140', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11268', '长岛县', '', '3', '1140', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11269', '龙口市', '', '3', '1140', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11270', '莱阳市', '', '3', '1140', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11271', '莱州市', '', '3', '1140', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11272', '蓬莱市', '', '3', '1140', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11273', '招远市', '', '3', '1140', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11274', '栖霞市', '', '3', '1140', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11275', '海阳市', '', '3', '1140', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11276', '潍城区', '', '3', '1141', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11277', '寒亭区', '', '3', '1141', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11278', '坊子区', '', '3', '1141', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11279', '奎文区', '', '3', '1141', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11280', '临朐县', '', '3', '1141', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11281', '昌乐县', '', '3', '1141', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11282', '青州市', '', '3', '1141', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11283', '诸城市', '', '3', '1141', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11284', '寿光市', '', '3', '1141', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11285', '安丘市', '', '3', '1141', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11286', '高密市', '', '3', '1141', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11287', '昌邑市', '', '3', '1141', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11288', '市中区', '', '3', '1142', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11289', '任城区', '', '3', '1142', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11290', '微山县', '', '3', '1142', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11291', '鱼台县', '', '3', '1142', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11292', '金乡县', '', '3', '1142', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11293', '嘉祥县', '', '3', '1142', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11294', '汶上县', '', '3', '1142', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11295', '泗水县', '', '3', '1142', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11296', '梁山县', '', '3', '1142', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11297', '曲阜市', '', '3', '1142', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11298', '兖州市', '', '3', '1142', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11299', '邹城市', '', '3', '1142', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11300', '泰山区', '', '3', '1143', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11301', '岱岳区', '', '3', '1143', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11302', '宁阳县', '', '3', '1143', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11303', '东平县', '', '3', '1143', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11304', '新泰市', '', '3', '1143', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11305', '肥城市', '', '3', '1143', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11306', '环翠区', '', '3', '1144', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11307', '文登市', '', '3', '1144', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11308', '荣成市', '', '3', '1144', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11309', '乳山市', '', '3', '1144', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11310', '东港区', '', '3', '1145', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11311', '岚山区', '', '3', '1145', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11312', '五莲县', '', '3', '1145', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11313', '莒县', '', '3', '1145', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11314', '莱城区', '', '3', '1146', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11315', '钢城区', '', '3', '1146', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11316', '兰山区', '', '3', '1147', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11317', '罗庄区', '', '3', '1147', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11318', '河东区', '', '3', '1147', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11319', '沂南县', '', '3', '1147', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11320', '郯城县', '', '3', '1147', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11321', '沂水县', '', '3', '1147', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11322', '苍山县', '', '3', '1147', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11323', '费县', '', '3', '1147', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11324', '平邑县', '', '3', '1147', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11325', '莒南县', '', '3', '1147', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11326', '蒙阴县', '', '3', '1147', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11327', '临沭县', '', '3', '1147', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11328', '德城区', '', '3', '1148', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11329', '陵县', '', '3', '1148', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11330', '宁津县', '', '3', '1148', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11331', '庆云县', '', '3', '1148', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11332', '临邑县', '', '3', '1148', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11333', '齐河县', '', '3', '1148', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11334', '平原县', '', '3', '1148', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11335', '夏津县', '', '3', '1148', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11336', '武城县', '', '3', '1148', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11337', '乐陵市', '', '3', '1148', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11338', '禹城市', '', '3', '1148', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11339', '东昌府区', '', '3', '1149', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11340', '阳谷县', '', '3', '1149', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11341', '莘县', '', '3', '1149', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11342', '茌平县', '', '3', '1149', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11343', '东阿县', '', '3', '1149', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11344', '冠县', '', '3', '1149', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11345', '高唐县', '', '3', '1149', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11346', '临清市', '', '3', '1149', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11347', '滨城区', '', '3', '1150', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11348', '惠民县', '', '3', '1150', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11349', '阳信县', '', '3', '1150', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11350', '无棣县', '', '3', '1150', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11351', '沾化县', '', '3', '1150', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11352', '博兴县', '', '3', '1150', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11353', '邹平县', '', '3', '1150', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11354', '牡丹区', '', '3', '1151', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11355', '曹县', '', '3', '1151', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11356', '单县', '', '3', '1151', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11357', '成武县', '', '3', '1151', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11358', '巨野县', '', '3', '1151', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11359', '郓城县', '', '3', '1151', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11360', '鄄城县', '', '3', '1151', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11361', '定陶县', '', '3', '1151', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11362', '东明县', '', '3', '1151', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11363', '中原区', '', '3', '1152', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11364', '二七区', '', '3', '1152', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11365', '管城回族区', '', '3', '1152', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11366', '金水区', '', '3', '1152', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11367', '上街区', '', '3', '1152', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11368', '惠济区', '', '3', '1152', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11369', '中牟县', '', '3', '1152', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11370', '巩义市', '', '3', '1152', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11371', '荥阳市', '', '3', '1152', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11372', '新密市', '', '3', '1152', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11373', '新郑市', '', '3', '1152', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11374', '登封市', '', '3', '1152', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11375', '龙亭区', '', '3', '1153', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11376', '顺河回族区', '', '3', '1153', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11377', '鼓楼区', '', '3', '1153', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11378', '南关区', '', '3', '1153', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11379', '郊区', '', '3', '1153', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11380', '杞县', '', '3', '1153', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11381', '通许县', '', '3', '1153', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11382', '尉氏县', '', '3', '1153', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11383', '开封县', '', '3', '1153', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11384', '兰考县', '', '3', '1153', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11385', '老城区', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11386', '西工区', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11387', '廛河回族区', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11388', '涧西区', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11389', '吉利区', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11390', '洛龙区', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11391', '孟津县', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11392', '新安县', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11393', '栾川县', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11394', '嵩县', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11395', '汝阳县', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11396', '宜阳县', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11397', '洛宁县', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11398', '伊川县', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11399', '偃师市', '', '3', '1154', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11400', '新华区', '', '3', '1155', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11401', '卫东区', '', '3', '1155', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11402', '石龙区', '', '3', '1155', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11403', '湛河区', '', '3', '1155', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11404', '宝丰县', '', '3', '1155', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11405', '叶县', '', '3', '1155', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11406', '鲁山县', '', '3', '1155', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11407', '郏县', '', '3', '1155', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11408', '舞钢市', '', '3', '1155', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11409', '汝州市', '', '3', '1155', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11410', '文峰区', '', '3', '1156', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11411', '北关区', '', '3', '1156', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11412', '殷都区', '', '3', '1156', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11413', '龙安区', '', '3', '1156', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11414', '安阳县', '', '3', '1156', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11415', '汤阴县', '', '3', '1156', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11416', '滑县', '', '3', '1156', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11417', '内黄县', '', '3', '1156', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11418', '林州市', '', '3', '1156', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11419', '鹤山区', '', '3', '1157', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11420', '山城区', '', '3', '1157', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11421', '淇滨区', '', '3', '1157', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11422', '浚县', '', '3', '1157', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11423', '淇县', '', '3', '1157', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11424', '红旗区', '', '3', '1158', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11425', '卫滨区', '', '3', '1158', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11426', '凤泉区', '', '3', '1158', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11427', '牧野区', '', '3', '1158', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11428', '新乡县', '', '3', '1158', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11429', '获嘉县', '', '3', '1158', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11430', '原阳县', '', '3', '1158', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11431', '延津县', '', '3', '1158', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11432', '封丘县', '', '3', '1158', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11433', '长垣县', '', '3', '1158', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11434', '卫辉市', '', '3', '1158', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11435', '辉县市', '', '3', '1158', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11436', '解放区', '', '3', '1159', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11437', '中站区', '', '3', '1159', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11438', '马村区', '', '3', '1159', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11439', '山阳区', '', '3', '1159', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11440', '修武县', '', '3', '1159', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11441', '博爱县', '', '3', '1159', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11442', '武陟县', '', '3', '1159', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11443', '温县', '', '3', '1159', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11444', '济源市', '', '3', '1159', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11445', '沁阳市', '', '3', '1159', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11446', '孟州市', '', '3', '1159', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11447', '华龙区', '', '3', '1160', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11448', '清丰县', '', '3', '1160', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11449', '南乐县', '', '3', '1160', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11450', '范县', '', '3', '1160', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11451', '台前县', '', '3', '1160', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11452', '濮阳县', '', '3', '1160', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11453', '魏都区', '', '3', '1161', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11454', '许昌县', '', '3', '1161', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11455', '鄢陵县', '', '3', '1161', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11456', '襄城县', '', '3', '1161', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11457', '禹州市', '', '3', '1161', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11458', '长葛市', '', '3', '1161', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11459', '源汇区', '', '3', '1162', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11460', '郾城区', '', '3', '1162', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11461', '召陵区', '', '3', '1162', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11462', '舞阳县', '', '3', '1162', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11463', '临颍县', '', '3', '1162', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11464', '市辖区', '', '3', '1163', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11465', '湖滨区', '', '3', '1163', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11466', '渑池县', '', '3', '1163', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11467', '陕县', '', '3', '1163', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11468', '卢氏县', '', '3', '1163', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11469', '义马市', '', '3', '1163', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11470', '灵宝市', '', '3', '1163', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11471', '宛城区', '', '3', '1164', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11472', '卧龙区', '', '3', '1164', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11473', '南召县', '', '3', '1164', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11474', '方城县', '', '3', '1164', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11475', '西峡县', '', '3', '1164', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11476', '镇平县', '', '3', '1164', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11477', '内乡县', '', '3', '1164', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11478', '淅川县', '', '3', '1164', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11479', '社旗县', '', '3', '1164', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11480', '唐河县', '', '3', '1164', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11481', '新野县', '', '3', '1164', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11482', '桐柏县', '', '3', '1164', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11483', '邓州市', '', '3', '1164', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11484', '梁园区', '', '3', '1165', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11485', '睢阳区', '', '3', '1165', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11486', '民权县', '', '3', '1165', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11487', '睢县', '', '3', '1165', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11488', '宁陵县', '', '3', '1165', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11489', '柘城县', '', '3', '1165', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11490', '虞城县', '', '3', '1165', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11491', '夏邑县', '', '3', '1165', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11492', '永城市', '', '3', '1165', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11493', '浉河区', '', '3', '1166', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11494', '平桥区', '', '3', '1166', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11495', '罗山县', '', '3', '1166', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11496', '光山县', '', '3', '1166', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11497', '新县', '', '3', '1166', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11498', '商城县', '', '3', '1166', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11499', '固始县', '', '3', '1166', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11500', '潢川县', '', '3', '1166', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11501', '淮滨县', '', '3', '1166', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11502', '息县', '', '3', '1166', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11503', '川汇区', '', '3', '1167', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11504', '扶沟县', '', '3', '1167', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11505', '西华县', '', '3', '1167', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11506', '商水县', '', '3', '1167', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11507', '沈丘县', '', '3', '1167', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11508', '郸城县', '', '3', '1167', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11509', '淮阳县', '', '3', '1167', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11510', '太康县', '', '3', '1167', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11511', '鹿邑县', '', '3', '1167', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11512', '项城市', '', '3', '1167', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11513', '驿城区', '', '3', '1168', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11514', '西平县', '', '3', '1168', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11515', '上蔡县', '', '3', '1168', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11516', '平舆县', '', '3', '1168', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11517', '正阳县', '', '3', '1168', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11518', '确山县', '', '3', '1168', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11519', '泌阳县', '', '3', '1168', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11520', '汝南县', '', '3', '1168', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11521', '遂平县', '', '3', '1168', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11522', '新蔡县', '', '3', '1168', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11523', '江岸区', '', '3', '1169', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11524', '江汉区', '', '3', '1169', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11525', '硚口区', '', '3', '1169', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11526', '汉阳区', '', '3', '1169', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11527', '武昌区', '', '3', '1169', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11528', '青山区', '', '3', '1169', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11529', '洪山区', '', '3', '1169', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11530', '东西湖区', '', '3', '1169', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11531', '汉南区', '', '3', '1169', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11532', '蔡甸区', '', '3', '1169', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11533', '江夏区', '', '3', '1169', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11534', '黄陂区', '', '3', '1169', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11535', '新洲区', '', '3', '1169', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11536', '黄石港区', '', '3', '1170', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11537', '西塞山区', '', '3', '1170', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11538', '下陆区', '', '3', '1170', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11539', '铁山区', '', '3', '1170', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11540', '阳新县', '', '3', '1170', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11541', '大冶市', '', '3', '1170', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11542', '茅箭区', '', '3', '1171', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11543', '张湾区', '', '3', '1171', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11544', '郧县', '', '3', '1171', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11545', '郧西县', '', '3', '1171', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11546', '竹山县', '', '3', '1171', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11547', '竹溪县', '', '3', '1171', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11548', '房县', '', '3', '1171', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11549', '丹江口市', '', '3', '1171', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11550', '西陵区', '', '3', '1172', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11551', '伍家岗区', '', '3', '1172', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11552', '点军区', '', '3', '1172', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11553', '猇亭区', '', '3', '1172', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11554', '夷陵区', '', '3', '1172', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11555', '远安县', '', '3', '1172', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11556', '兴山县', '', '3', '1172', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11557', '秭归县', '', '3', '1172', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11558', '长阳土家族自治县', '', '3', '1172', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11559', '五峰土家族自治县', '', '3', '1172', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11560', '宜都市', '', '3', '1172', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11561', '当阳市', '', '3', '1172', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11562', '枝江市', '', '3', '1172', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11563', '襄城区', '', '3', '1173', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11564', '樊城区', '', '3', '1173', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11565', '襄阳区', '', '3', '1173', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11566', '南漳县', '', '3', '1173', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11567', '谷城县', '', '3', '1173', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11568', '保康县', '', '3', '1173', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11569', '老河口市', '', '3', '1173', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11570', '枣阳市', '', '3', '1173', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11571', '宜城市', '', '3', '1173', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11572', '梁子湖区', '', '3', '1174', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11573', '华容区', '', '3', '1174', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11574', '鄂城区', '', '3', '1174', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11575', '东宝区', '', '3', '1175', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11576', '掇刀区', '', '3', '1175', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11577', '京山县', '', '3', '1175', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11578', '沙洋县', '', '3', '1175', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11579', '钟祥市', '', '3', '1175', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11580', '孝南区', '', '3', '1176', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11581', '孝昌县', '', '3', '1176', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11582', '大悟县', '', '3', '1176', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11583', '云梦县', '', '3', '1176', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11584', '应城市', '', '3', '1176', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11585', '安陆市', '', '3', '1176', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11586', '汉川市', '', '3', '1176', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11587', '沙市区', '', '3', '1177', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11588', '荆州区', '', '3', '1177', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11589', '公安县', '', '3', '1177', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11590', '监利县', '', '3', '1177', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11591', '江陵县', '', '3', '1177', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11592', '石首市', '', '3', '1177', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11593', '洪湖市', '', '3', '1177', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11594', '松滋市', '', '3', '1177', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11595', '黄州区', '', '3', '1178', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11596', '团风县', '', '3', '1178', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11597', '红安县', '', '3', '1178', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11598', '罗田县', '', '3', '1178', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11599', '英山县', '', '3', '1178', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11600', '浠水县', '', '3', '1178', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11601', '蕲春县', '', '3', '1178', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11602', '黄梅县', '', '3', '1178', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11603', '麻城市', '', '3', '1178', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11604', '武穴市', '', '3', '1178', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11605', '咸安区', '', '3', '1179', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11606', '嘉鱼县', '', '3', '1179', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11607', '通城县', '', '3', '1179', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11608', '崇阳县', '', '3', '1179', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11609', '通山县', '', '3', '1179', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11610', '赤壁市', '', '3', '1179', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11611', '曾都区', '', '3', '1180', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11612', '广水市', '', '3', '1180', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11613', '恩施市', '', '3', '1181', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11614', '利川市', '', '3', '1181', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11615', '建始县', '', '3', '1181', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11616', '巴东县', '', '3', '1181', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11617', '宣恩县', '', '3', '1181', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11618', '咸丰县', '', '3', '1181', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11619', '来凤县', '', '3', '1181', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11620', '鹤峰县', '', '3', '1181', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11621', '仙桃市', '', '3', '1182', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11622', '潜江市', '', '3', '1182', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11623', '天门市', '', '3', '1182', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11624', '神农架林区', '', '3', '1182', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11625', '芙蓉区', '', '3', '1183', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11626', '天心区', '', '3', '1183', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11627', '岳麓区', '', '3', '1183', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11628', '开福区', '', '3', '1183', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11629', '雨花区', '', '3', '1183', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11630', '长沙县', '', '3', '1183', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11631', '望城县', '', '3', '1183', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11632', '宁乡县', '', '3', '1183', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11633', '浏阳市', '', '3', '1183', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11634', '荷塘区', '', '3', '1184', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11635', '芦淞区', '', '3', '1184', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11636', '石峰区', '', '3', '1184', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11637', '天元区', '', '3', '1184', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11638', '株洲县', '', '3', '1184', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11639', '攸县', '', '3', '1184', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11640', '茶陵县', '', '3', '1184', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11641', '炎陵县', '', '3', '1184', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11642', '醴陵市', '', '3', '1184', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11643', '雨湖区', '', '3', '1185', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11644', '岳塘区', '', '3', '1185', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11645', '湘潭县', '', '3', '1185', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11646', '湘乡市', '', '3', '1185', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11647', '韶山市', '', '3', '1185', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11648', '珠晖区', '', '3', '1186', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11649', '雁峰区', '', '3', '1186', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11650', '石鼓区', '', '3', '1186', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11651', '蒸湘区', '', '3', '1186', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11652', '南岳区', '', '3', '1186', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11653', '衡阳县', '', '3', '1186', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11654', '衡南县', '', '3', '1186', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11655', '衡山县', '', '3', '1186', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11656', '衡东县', '', '3', '1186', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11657', '祁东县', '', '3', '1186', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11658', '耒阳市', '', '3', '1186', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11659', '常宁市', '', '3', '1186', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11660', '双清区', '', '3', '1187', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11661', '大祥区', '', '3', '1187', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11662', '北塔区', '', '3', '1187', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11663', '邵东县', '', '3', '1187', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11664', '新邵县', '', '3', '1187', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11665', '邵阳县', '', '3', '1187', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11666', '隆回县', '', '3', '1187', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11667', '洞口县', '', '3', '1187', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11668', '绥宁县', '', '3', '1187', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11669', '新宁县', '', '3', '1187', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11670', '城步苗族自治县', '', '3', '1187', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11671', '武冈市', '', '3', '1187', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11672', '岳阳楼区', '', '3', '1188', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11673', '云溪区', '', '3', '1188', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11674', '君山区', '', '3', '1188', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11675', '岳阳县', '', '3', '1188', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11676', '华容县', '', '3', '1188', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11677', '湘阴县', '', '3', '1188', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11678', '平江县', '', '3', '1188', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11679', '汨罗市', '', '3', '1188', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11680', '临湘市', '', '3', '1188', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11681', '武陵区', '', '3', '1189', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11682', '鼎城区', '', '3', '1189', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11683', '安乡县', '', '3', '1189', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11684', '汉寿县', '', '3', '1189', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11685', '澧县', '', '3', '1189', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11686', '临澧县', '', '3', '1189', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11687', '桃源县', '', '3', '1189', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11688', '石门县', '', '3', '1189', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11689', '津市市', '', '3', '1189', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11690', '永定区', '', '3', '1190', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11691', '武陵源区', '', '3', '1190', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11692', '慈利县', '', '3', '1190', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11693', '桑植县', '', '3', '1190', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11694', '资阳区', '', '3', '1191', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11695', '赫山区', '', '3', '1191', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11696', '南县', '', '3', '1191', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11697', '桃江县', '', '3', '1191', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11698', '安化县', '', '3', '1191', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11699', '沅江市', '', '3', '1191', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11700', '北湖区', '', '3', '1192', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11701', '苏仙区', '', '3', '1192', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11702', '桂阳县', '', '3', '1192', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11703', '宜章县', '', '3', '1192', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11704', '永兴县', '', '3', '1192', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11705', '嘉禾县', '', '3', '1192', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11706', '临武县', '', '3', '1192', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11707', '汝城县', '', '3', '1192', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11708', '桂东县', '', '3', '1192', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11709', '安仁县', '', '3', '1192', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11710', '资兴市', '', '3', '1192', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11711', '芝山区', '', '3', '1193', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11712', '冷水滩区', '', '3', '1193', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11713', '祁阳县', '', '3', '1193', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11714', '东安县', '', '3', '1193', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11715', '双牌县', '', '3', '1193', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11716', '道县', '', '3', '1193', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11717', '江永县', '', '3', '1193', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11718', '宁远县', '', '3', '1193', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11719', '蓝山县', '', '3', '1193', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11720', '新田县', '', '3', '1193', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11721', '江华瑶族自治县', '', '3', '1193', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11722', '鹤城区', '', '3', '1194', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11723', '中方县', '', '3', '1194', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11724', '沅陵县', '', '3', '1194', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11725', '辰溪县', '', '3', '1194', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11726', '溆浦县', '', '3', '1194', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11727', '会同县', '', '3', '1194', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11728', '麻阳苗族自治县', '', '3', '1194', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11729', '新晃侗族自治县', '', '3', '1194', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11730', '芷江侗族自治县', '', '3', '1194', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11731', '靖州苗族侗族自治县', '', '3', '1194', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11732', '通道侗族自治县', '', '3', '1194', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11733', '洪江市', '', '3', '1194', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11734', '娄星区', '', '3', '1195', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11735', '双峰县', '', '3', '1195', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11736', '新化县', '', '3', '1195', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11737', '冷水江市', '', '3', '1195', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11738', '涟源市', '', '3', '1195', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11739', '吉首市', '', '3', '1196', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11740', '泸溪县', '', '3', '1196', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11741', '凤凰县', '', '3', '1196', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11742', '花垣县', '', '3', '1196', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11743', '保靖县', '', '3', '1196', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11744', '古丈县', '', '3', '1196', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11745', '永顺县', '', '3', '1196', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11746', '龙山县', '', '3', '1196', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11747', '东山区', '', '3', '1197', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11748', '荔湾区', '', '3', '1197', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11749', '越秀区', '', '3', '1197', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11750', '海珠区', '', '3', '1197', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11751', '天河区', '', '3', '1197', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11752', '芳村区', '', '3', '1197', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11753', '白云区', '', '3', '1197', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11754', '黄埔区', '', '3', '1197', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11755', '番禺区', '', '3', '1197', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11756', '花都区', '', '3', '1197', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11757', '增城市', '', '3', '1197', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11758', '从化市', '', '3', '1197', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11759', '武江区', '', '3', '1198', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11760', '浈江区', '', '3', '1198', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11761', '曲江区', '', '3', '1198', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11762', '始兴县', '', '3', '1198', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11763', '仁化县', '', '3', '1198', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11764', '翁源县', '', '3', '1198', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11765', '乳源瑶族自治县', '', '3', '1198', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11766', '新丰县', '', '3', '1198', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11767', '乐昌市', '', '3', '1198', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11768', '南雄市', '', '3', '1198', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11769', '罗湖区', '', '3', '1199', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11770', '福田区', '', '3', '1199', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11771', '南山区', '', '3', '1199', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11772', '宝安区', '', '3', '1199', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11773', '龙岗区', '', '3', '1199', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11774', '盐田区', '', '3', '1199', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11775', '香洲区', '', '3', '1200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11776', '斗门区', '', '3', '1200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11777', '金湾区', '', '3', '1200', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11778', '龙湖区', '', '3', '1201', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11779', '金平区', '', '3', '1201', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11780', '濠江区', '', '3', '1201', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11781', '潮阳区', '', '3', '1201', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11782', '潮南区', '', '3', '1201', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11783', '澄海区', '', '3', '1201', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11784', '南澳县', '', '3', '1201', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11785', '禅城区', '', '3', '1202', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11786', '南海区', '', '3', '1202', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11787', '顺德区', '', '3', '1202', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11788', '三水区', '', '3', '1202', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11789', '高明区', '', '3', '1202', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11790', '蓬江区', '', '3', '1203', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11791', '江海区', '', '3', '1203', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11792', '新会区', '', '3', '1203', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11793', '台山市', '', '3', '1203', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11794', '开平市', '', '3', '1203', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11795', '鹤山市', '', '3', '1203', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11796', '恩平市', '', '3', '1203', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11797', '赤坎区', '', '3', '1204', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11798', '霞山区', '', '3', '1204', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11799', '坡头区', '', '3', '1204', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11800', '麻章区', '', '3', '1204', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11801', '遂溪县', '', '3', '1204', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11802', '徐闻县', '', '3', '1204', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11803', '廉江市', '', '3', '1204', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11804', '雷州市', '', '3', '1204', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11805', '吴川市', '', '3', '1204', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11806', '茂南区', '', '3', '1205', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11807', '茂港区', '', '3', '1205', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11808', '电白县', '', '3', '1205', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11809', '高州市', '', '3', '1205', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11810', '化州市', '', '3', '1205', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11811', '信宜市', '', '3', '1205', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11812', '端州区', '', '3', '1206', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11813', '鼎湖区', '', '3', '1206', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11814', '广宁县', '', '3', '1206', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11815', '怀集县', '', '3', '1206', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11816', '封开县', '', '3', '1206', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11817', '德庆县', '', '3', '1206', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11818', '高要市', '', '3', '1206', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11819', '四会市', '', '3', '1206', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11820', '惠城区', '', '3', '1207', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11821', '惠阳区', '', '3', '1207', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11822', '博罗县', '', '3', '1207', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11823', '惠东县', '', '3', '1207', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11824', '龙门县', '', '3', '1207', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11825', '梅江区', '', '3', '1208', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11826', '梅县', '', '3', '1208', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11827', '大埔县', '', '3', '1208', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11828', '丰顺县', '', '3', '1208', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11829', '五华县', '', '3', '1208', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11830', '平远县', '', '3', '1208', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11831', '蕉岭县', '', '3', '1208', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11832', '兴宁市', '', '3', '1208', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11833', '城区', '', '3', '1209', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11834', '海丰县', '', '3', '1209', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11835', '陆河县', '', '3', '1209', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11836', '陆丰市', '', '3', '1209', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11837', '源城区', '', '3', '1210', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11838', '紫金县', '', '3', '1210', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11839', '龙川县', '', '3', '1210', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11840', '连平县', '', '3', '1210', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11841', '和平县', '', '3', '1210', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11842', '东源县', '', '3', '1210', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11843', '江城区', '', '3', '1211', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11844', '阳西县', '', '3', '1211', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11845', '阳东县', '', '3', '1211', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11846', '阳春市', '', '3', '1211', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11847', '清城区', '', '3', '1212', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11848', '佛冈县', '', '3', '1212', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11849', '阳山县', '', '3', '1212', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11850', '连山壮族瑶族自治县', '', '3', '1212', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11851', '连南瑶族自治县', '', '3', '1212', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11852', '清新县', '', '3', '1212', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11853', '英德市', '', '3', '1212', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11854', '连州市', '', '3', '1212', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11855', '湘桥区', '', '3', '1215', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11856', '潮安县', '', '3', '1215', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11857', '饶平县', '', '3', '1215', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11858', '榕城区', '', '3', '1216', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11859', '揭东县', '', '3', '1216', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11860', '揭西县', '', '3', '1216', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11861', '惠来县', '', '3', '1216', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11862', '普宁市', '', '3', '1216', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11863', '云城区', '', '3', '1217', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11864', '新兴县', '', '3', '1217', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11865', '郁南县', '', '3', '1217', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11866', '云安县', '', '3', '1217', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11867', '罗定市', '', '3', '1217', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11868', '兴宁区', '', '3', '1218', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11869', '青秀区', '', '3', '1218', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11870', '江南区', '', '3', '1218', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11871', '西乡塘区', '', '3', '1218', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11872', '良庆区', '', '3', '1218', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11873', '邕宁区', '', '3', '1218', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11874', '武鸣县', '', '3', '1218', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11875', '隆安县', '', '3', '1218', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11876', '马山县', '', '3', '1218', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11877', '上林县', '', '3', '1218', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11878', '宾阳县', '', '3', '1218', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11879', '横县', '', '3', '1218', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11880', '城中区', '', '3', '1219', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11881', '鱼峰区', '', '3', '1219', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11882', '柳南区', '', '3', '1219', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11883', '柳北区', '', '3', '1219', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11884', '柳江县', '', '3', '1219', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11885', '柳城县', '', '3', '1219', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11886', '鹿寨县', '', '3', '1219', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11887', '融安县', '', '3', '1219', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11888', '融水苗族自治县', '', '3', '1219', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11889', '三江侗族自治县', '', '3', '1219', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11890', '秀峰区', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11891', '叠彩区', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11892', '象山区', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11893', '七星区', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11894', '雁山区', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11895', '阳朔县', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11896', '临桂县', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11897', '灵川县', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11898', '全州县', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11899', '兴安县', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11900', '永福县', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11901', '灌阳县', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11902', '龙胜各族自治县', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11903', '资源县', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11904', '平乐县', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11905', '荔蒲县', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11906', '恭城瑶族自治县', '', '3', '1220', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11907', '万秀区', '', '3', '1221', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11908', '蝶山区', '', '3', '1221', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11909', '长洲区', '', '3', '1221', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11910', '苍梧县', '', '3', '1221', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11911', '藤县', '', '3', '1221', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11912', '蒙山县', '', '3', '1221', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11913', '岑溪市', '', '3', '1221', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11914', '海城区', '', '3', '1222', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11915', '银海区', '', '3', '1222', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11916', '铁山港区', '', '3', '1222', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11917', '合浦县', '', '3', '1222', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11918', '港口区', '', '3', '1223', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11919', '防城区', '', '3', '1223', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11920', '上思县', '', '3', '1223', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11921', '东兴市', '', '3', '1223', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11922', '钦南区', '', '3', '1224', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11923', '钦北区', '', '3', '1224', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11924', '灵山县', '', '3', '1224', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11925', '浦北县', '', '3', '1224', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11926', '港北区', '', '3', '1225', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11927', '港南区', '', '3', '1225', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11928', '覃塘区', '', '3', '1225', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11929', '平南县', '', '3', '1225', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11930', '桂平市', '', '3', '1225', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11931', '玉州区', '', '3', '1226', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11932', '容县', '', '3', '1226', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11933', '陆川县', '', '3', '1226', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11934', '博白县', '', '3', '1226', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11935', '兴业县', '', '3', '1226', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11936', '北流市', '', '3', '1226', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11937', '右江区', '', '3', '1227', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11938', '田阳县', '', '3', '1227', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11939', '田东县', '', '3', '1227', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11940', '平果县', '', '3', '1227', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11941', '德保县', '', '3', '1227', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11942', '靖西县', '', '3', '1227', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11943', '那坡县', '', '3', '1227', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11944', '凌云县', '', '3', '1227', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11945', '乐业县', '', '3', '1227', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11946', '田林县', '', '3', '1227', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11947', '西林县', '', '3', '1227', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11948', '隆林各族自治县', '', '3', '1227', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11949', '八步区', '', '3', '1228', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11950', '昭平县', '', '3', '1228', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11951', '钟山县', '', '3', '1228', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11952', '富川瑶族自治县', '', '3', '1228', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11953', '金城江区', '', '3', '1229', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11954', '南丹县', '', '3', '1229', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11955', '天峨县', '', '3', '1229', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11956', '凤山县', '', '3', '1229', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11957', '东兰县', '', '3', '1229', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11958', '罗城仫佬族自治县', '', '3', '1229', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11959', '环江毛南族自治县', '', '3', '1229', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11960', '巴马瑶族自治县', '', '3', '1229', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11961', '都安瑶族自治县', '', '3', '1229', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11962', '大化瑶族自治县', '', '3', '1229', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11963', '宜州市', '', '3', '1229', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11964', '兴宾区', '', '3', '1230', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11965', '忻城县', '', '3', '1230', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11966', '象州县', '', '3', '1230', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11967', '武宣县', '', '3', '1230', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11968', '金秀瑶族自治县', '', '3', '1230', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11969', '合山市', '', '3', '1230', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11970', '江洲区', '', '3', '1231', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11971', '扶绥县', '', '3', '1231', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11972', '宁明县', '', '3', '1231', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11973', '龙州县', '', '3', '1231', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11974', '大新县', '', '3', '1231', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11975', '天等县', '', '3', '1231', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11976', '凭祥市', '', '3', '1231', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11977', '秀英区', '', '3', '1232', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11978', '龙华区', '', '3', '1232', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11979', '琼山区', '', '3', '1232', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11980', '美兰区', '', '3', '1232', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11981', '五指山市', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11982', '琼海市', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11983', '儋州市', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11984', '文昌市', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11985', '万宁市', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11986', '东方市', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11987', '定安县', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11988', '屯昌县', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11989', '澄迈县', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11990', '临高县', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11991', '白沙黎族自治县', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11992', '昌江黎族自治县', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11993', '乐东黎族自治县', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11994', '陵水黎族自治县', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11995', '保亭黎族苗族自治县', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11996', '琼中黎族苗族自治县', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11997', '西沙群岛', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11998', '南沙群岛', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('11999', '中沙群岛的岛礁及其海域', '', '3', '1233', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12000', '万州区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12001', '涪陵区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12002', '渝中区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12003', '大渡口区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12004', '江北区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12005', '沙坪坝区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12006', '九龙坡区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12007', '南岸区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12008', '北碚区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12009', '万盛区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12010', '双桥区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12011', '渝北区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12012', '巴南区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12013', '黔江区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12014', '长寿区', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12015', '綦江县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12016', '潼南县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12017', '铜梁县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12018', '大足县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12019', '荣昌县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12020', '璧山县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12021', '梁平县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12022', '城口县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12023', '丰都县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12024', '垫江县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12025', '武隆县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12026', '忠县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12027', '开县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12028', '云阳县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12029', '奉节县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12030', '巫山县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12031', '巫溪县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12032', '石柱土家族自治县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12033', '秀山土家族苗族自治县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12034', '酉阳土家族苗族自治县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12035', '彭水苗族土家族自治县', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12036', '江津市', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12037', '合川市', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12038', '永川市', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12039', '南川市', '', '3', '1234', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12040', '锦江区', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12041', '青羊区', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12042', '金牛区', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12043', '武侯区', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12044', '成华区', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12045', '龙泉驿区', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12046', '青白江区', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12047', '新都区', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12048', '温江区', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12049', '金堂县', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12050', '双流县', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12051', '郫县', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12052', '大邑县', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12053', '蒲江县', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12054', '新津县', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12055', '都江堰市', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12056', '彭州市', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12057', '邛崃市', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12058', '崇州市', '', '3', '1235', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12059', '自流井区', '', '3', '1236', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12060', '贡井区', '', '3', '1236', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12061', '大安区', '', '3', '1236', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12062', '沿滩区', '', '3', '1236', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12063', '荣县', '', '3', '1236', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12064', '富顺县', '', '3', '1236', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12065', '东区', '', '3', '1237', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12066', '西区', '', '3', '1237', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12067', '仁和区', '', '3', '1237', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12068', '米易县', '', '3', '1237', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12069', '盐边县', '', '3', '1237', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12070', '江阳区', '', '3', '1238', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12071', '纳溪区', '', '3', '1238', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12072', '龙马潭区', '', '3', '1238', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12073', '泸县', '', '3', '1238', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12074', '合江县', '', '3', '1238', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12075', '叙永县', '', '3', '1238', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12076', '古蔺县', '', '3', '1238', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12077', '旌阳区', '', '3', '1239', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12078', '中江县', '', '3', '1239', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12079', '罗江县', '', '3', '1239', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12080', '广汉市', '', '3', '1239', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12081', '什邡市', '', '3', '1239', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12082', '绵竹市', '', '3', '1239', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12083', '涪城区', '', '3', '1240', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12084', '游仙区', '', '3', '1240', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12085', '三台县', '', '3', '1240', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12086', '盐亭县', '', '3', '1240', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12087', '安县', '', '3', '1240', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12088', '梓潼县', '', '3', '1240', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12089', '北川羌族自治县', '', '3', '1240', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12090', '平武县', '', '3', '1240', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12091', '江油市', '', '3', '1240', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12092', '市中区', '', '3', '1241', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12093', '元坝区', '', '3', '1241', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12094', '朝天区', '', '3', '1241', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12095', '旺苍县', '', '3', '1241', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12096', '青川县', '', '3', '1241', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12097', '剑阁县', '', '3', '1241', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12098', '苍溪县', '', '3', '1241', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12099', '船山区', '', '3', '1242', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12100', '安居区', '', '3', '1242', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12101', '蓬溪县', '', '3', '1242', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12102', '射洪县', '', '3', '1242', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12103', '大英县', '', '3', '1242', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12104', '市中区', '', '3', '1243', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12105', '东兴区', '', '3', '1243', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12106', '威远县', '', '3', '1243', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12107', '资中县', '', '3', '1243', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12108', '隆昌县', '', '3', '1243', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12109', '市中区', '', '3', '1244', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12110', '沙湾区', '', '3', '1244', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12111', '五通桥区', '', '3', '1244', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12112', '金口河区', '', '3', '1244', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12113', '犍为县', '', '3', '1244', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12114', '井研县', '', '3', '1244', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12115', '夹江县', '', '3', '1244', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12116', '沐川县', '', '3', '1244', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12117', '峨边彝族自治县', '', '3', '1244', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12118', '马边彝族自治县', '', '3', '1244', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12119', '峨眉山市', '', '3', '1244', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12120', '顺庆区', '', '3', '1245', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12121', '高坪区', '', '3', '1245', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12122', '嘉陵区', '', '3', '1245', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12123', '南部县', '', '3', '1245', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12124', '营山县', '', '3', '1245', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12125', '蓬安县', '', '3', '1245', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12126', '仪陇县', '', '3', '1245', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12127', '西充县', '', '3', '1245', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12128', '阆中市', '', '3', '1245', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12129', '东坡区', '', '3', '1246', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12130', '仁寿县', '', '3', '1246', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12131', '彭山县', '', '3', '1246', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12132', '洪雅县', '', '3', '1246', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12133', '丹棱县', '', '3', '1246', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12134', '青神县', '', '3', '1246', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12135', '翠屏区', '', '3', '1247', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12136', '宜宾县', '', '3', '1247', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12137', '南溪县', '', '3', '1247', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12138', '江安县', '', '3', '1247', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12139', '长宁县', '', '3', '1247', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12140', '高县', '', '3', '1247', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12141', '珙县', '', '3', '1247', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12142', '筠连县', '', '3', '1247', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12143', '兴文县', '', '3', '1247', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12144', '屏山县', '', '3', '1247', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12145', '广安区', '', '3', '1248', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12146', '岳池县', '', '3', '1248', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12147', '武胜县', '', '3', '1248', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12148', '邻水县', '', '3', '1248', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12149', '华蓥市', '', '3', '1248', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12150', '通川区', '', '3', '1249', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12151', '达县', '', '3', '1249', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12152', '宣汉县', '', '3', '1249', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12153', '开江县', '', '3', '1249', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12154', '大竹县', '', '3', '1249', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12155', '渠县', '', '3', '1249', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12156', '万源市', '', '3', '1249', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12157', '雨城区', '', '3', '1250', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12158', '名山县', '', '3', '1250', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12159', '荥经县', '', '3', '1250', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12160', '汉源县', '', '3', '1250', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12161', '石棉县', '', '3', '1250', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12162', '天全县', '', '3', '1250', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12163', '芦山县', '', '3', '1250', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12164', '宝兴县', '', '3', '1250', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12165', '巴州区', '', '3', '1251', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12166', '通江县', '', '3', '1251', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12167', '南江县', '', '3', '1251', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12168', '平昌县', '', '3', '1251', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12169', '雁江区', '', '3', '1252', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12170', '安岳县', '', '3', '1252', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12171', '乐至县', '', '3', '1252', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12172', '简阳市', '', '3', '1252', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12173', '汶川县', '', '3', '1253', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12174', '理县', '', '3', '1253', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12175', '茂县', '', '3', '1253', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12176', '松潘县', '', '3', '1253', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12177', '九寨沟县', '', '3', '1253', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12178', '金川县', '', '3', '1253', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12179', '小金县', '', '3', '1253', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12180', '黑水县', '', '3', '1253', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12181', '马尔康县', '', '3', '1253', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12182', '壤塘县', '', '3', '1253', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12183', '阿坝县', '', '3', '1253', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12184', '若尔盖县', '', '3', '1253', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12185', '红原县', '', '3', '1253', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12186', '康定县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12187', '泸定县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12188', '丹巴县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12189', '九龙县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12190', '雅江县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12191', '道孚县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12192', '炉霍县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12193', '甘孜县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12194', '新龙县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12195', '德格县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12196', '白玉县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12197', '石渠县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12198', '色达县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12199', '理塘县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12200', '巴塘县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12201', '乡城县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12202', '稻城县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12203', '得荣县', '', '3', '1254', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12204', '西昌市', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12205', '木里藏族自治县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12206', '盐源县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12207', '德昌县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12208', '会理县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12209', '会东县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12210', '宁南县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12211', '普格县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12212', '布拖县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12213', '金阳县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12214', '昭觉县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12215', '喜德县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12216', '冕宁县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12217', '越西县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12218', '甘洛县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12219', '美姑县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12220', '雷波县', '', '3', '1255', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12221', '南明区', '', '3', '1256', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12222', '云岩区', '', '3', '1256', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12223', '花溪区', '', '3', '1256', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12224', '乌当区', '', '3', '1256', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12225', '白云区', '', '3', '1256', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12226', '小河区', '', '3', '1256', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12227', '开阳县', '', '3', '1256', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12228', '息烽县', '', '3', '1256', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12229', '修文县', '', '3', '1256', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12230', '清镇市', '', '3', '1256', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12231', '钟山区', '', '3', '1257', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12232', '六枝特区', '', '3', '1257', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12233', '水城县', '', '3', '1257', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12234', '盘县', '', '3', '1257', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12235', '红花岗区', '', '3', '1258', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12236', '汇川区', '', '3', '1258', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12237', '遵义县', '', '3', '1258', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12238', '桐梓县', '', '3', '1258', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12239', '绥阳县', '', '3', '1258', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12240', '正安县', '', '3', '1258', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12241', '道真仡佬族苗族自治县', '', '3', '1258', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12242', '务川仡佬族苗族自治县', '', '3', '1258', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12243', '凤冈县', '', '3', '1258', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12244', '湄潭县', '', '3', '1258', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12245', '余庆县', '', '3', '1258', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12246', '习水县', '', '3', '1258', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12247', '赤水市', '', '3', '1258', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12248', '仁怀市', '', '3', '1258', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12249', '西秀区', '', '3', '1259', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12250', '平坝县', '', '3', '1259', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12251', '普定县', '', '3', '1259', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12252', '镇宁布依族苗族自治县', '', '3', '1259', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12253', '关岭布依族苗族自治县', '', '3', '1259', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12254', '紫云苗族布依族自治县', '', '3', '1259', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12255', '铜仁市', '', '3', '1260', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12256', '江口县', '', '3', '1260', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12257', '玉屏侗族自治县', '', '3', '1260', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12258', '石阡县', '', '3', '1260', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12259', '思南县', '', '3', '1260', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12260', '印江土家族苗族自治县', '', '3', '1260', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12261', '德江县', '', '3', '1260', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12262', '沿河土家族自治县', '', '3', '1260', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12263', '松桃苗族自治县', '', '3', '1260', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12264', '万山特区', '', '3', '1260', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12265', '兴义市', '', '3', '1261', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12266', '兴仁县', '', '3', '1261', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12267', '普安县', '', '3', '1261', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12268', '晴隆县', '', '3', '1261', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12269', '贞丰县', '', '3', '1261', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12270', '望谟县', '', '3', '1261', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12271', '册亨县', '', '3', '1261', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12272', '安龙县', '', '3', '1261', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12273', '毕节市', '', '3', '1262', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12274', '大方县', '', '3', '1262', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12275', '黔西县', '', '3', '1262', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12276', '金沙县', '', '3', '1262', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12277', '织金县', '', '3', '1262', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12278', '纳雍县', '', '3', '1262', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12279', '威宁彝族回族苗族自治县', '', '3', '1262', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12280', '赫章县', '', '3', '1262', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12281', '凯里市', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12282', '黄平县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12283', '施秉县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12284', '三穗县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12285', '镇远县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12286', '岑巩县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12287', '天柱县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12288', '锦屏县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12289', '剑河县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12290', '台江县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12291', '黎平县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12292', '榕江县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12293', '从江县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12294', '雷山县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12295', '麻江县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12296', '丹寨县', '', '3', '1263', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12297', '都匀市', '', '3', '1264', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12298', '福泉市', '', '3', '1264', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12299', '荔波县', '', '3', '1264', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12300', '贵定县', '', '3', '1264', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12301', '瓮安县', '', '3', '1264', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12302', '独山县', '', '3', '1264', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12303', '平塘县', '', '3', '1264', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12304', '罗甸县', '', '3', '1264', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12305', '长顺县', '', '3', '1264', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12306', '龙里县', '', '3', '1264', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12307', '惠水县', '', '3', '1264', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12308', '三都水族自治县', '', '3', '1264', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12309', '五华区', '', '3', '1265', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12310', '盘龙区', '', '3', '1265', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12311', '官渡区', '', '3', '1265', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12312', '西山区', '', '3', '1265', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12313', '东川区', '', '3', '1265', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12314', '呈贡县', '', '3', '1265', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12315', '晋宁县', '', '3', '1265', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12316', '富民县', '', '3', '1265', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12317', '宜良县', '', '3', '1265', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12318', '石林彝族自治县', '', '3', '1265', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12319', '嵩明县', '', '3', '1265', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12320', '禄劝彝族苗族自治县', '', '3', '1265', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12321', '寻甸回族彝族自治县', '', '3', '1265', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12322', '安宁市', '', '3', '1265', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12323', '麒麟区', '', '3', '1266', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12324', '马龙县', '', '3', '1266', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12325', '陆良县', '', '3', '1266', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12326', '师宗县', '', '3', '1266', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12327', '罗平县', '', '3', '1266', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12328', '富源县', '', '3', '1266', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12329', '会泽县', '', '3', '1266', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12330', '沾益县', '', '3', '1266', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12331', '宣威市', '', '3', '1266', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12332', '红塔区', '', '3', '1267', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12333', '江川县', '', '3', '1267', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12334', '澄江县', '', '3', '1267', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12335', '通海县', '', '3', '1267', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12336', '华宁县', '', '3', '1267', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12337', '易门县', '', '3', '1267', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12338', '峨山彝族自治县', '', '3', '1267', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12339', '新平彝族傣族自治县', '', '3', '1267', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12340', '元江哈尼族彝族傣族自治县', '', '3', '1267', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12341', '隆阳区', '', '3', '1268', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12342', '施甸县', '', '3', '1268', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12343', '腾冲县', '', '3', '1268', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12344', '龙陵县', '', '3', '1268', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12345', '昌宁县', '', '3', '1268', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12346', '昭阳区', '', '3', '1269', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12347', '鲁甸县', '', '3', '1269', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12348', '巧家县', '', '3', '1269', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12349', '盐津县', '', '3', '1269', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12350', '大关县', '', '3', '1269', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12351', '永善县', '', '3', '1269', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12352', '绥江县', '', '3', '1269', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12353', '镇雄县', '', '3', '1269', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12354', '彝良县', '', '3', '1269', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12355', '威信县', '', '3', '1269', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12356', '水富县', '', '3', '1269', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12357', '古城区', '', '3', '1270', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12358', '玉龙纳西族自治县', '', '3', '1270', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12359', '永胜县', '', '3', '1270', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12360', '华坪县', '', '3', '1270', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12361', '宁蒗彝族自治县', '', '3', '1270', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12362', '翠云区', '', '3', '1271', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12363', '普洱哈尼族彝族自治县', '', '3', '1271', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12364', '墨江哈尼族自治县', '', '3', '1271', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12365', '景东彝族自治县', '', '3', '1271', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12366', '景谷傣族彝族自治县', '', '3', '1271', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12367', '镇沅彝族哈尼族拉祜族自治县', '', '3', '1271', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12368', '江城哈尼族彝族自治县', '', '3', '1271', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12369', '孟连傣族拉祜族佤族自治县', '', '3', '1271', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12370', '澜沧拉祜族自治县', '', '3', '1271', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12371', '西盟佤族自治县', '', '3', '1271', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12372', '临翔区', '', '3', '1272', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12373', '凤庆县', '', '3', '1272', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12374', '云县', '', '3', '1272', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12375', '永德县', '', '3', '1272', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12376', '镇康县', '', '3', '1272', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12377', '双江拉祜族佤族布朗族傣族自治县', '', '3', '1272', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12378', '耿马傣族佤族自治县', '', '3', '1272', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12379', '沧源佤族自治县', '', '3', '1272', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12380', '楚雄市', '', '3', '1273', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12381', '双柏县', '', '3', '1273', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12382', '牟定县', '', '3', '1273', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12383', '南华县', '', '3', '1273', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12384', '姚安县', '', '3', '1273', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12385', '大姚县', '', '3', '1273', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12386', '永仁县', '', '3', '1273', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12387', '元谋县', '', '3', '1273', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12388', '武定县', '', '3', '1273', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12389', '禄丰县', '', '3', '1273', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12390', '个旧市', '', '3', '1274', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12391', '开远市', '', '3', '1274', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12392', '蒙自县', '', '3', '1274', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12393', '屏边苗族自治县', '', '3', '1274', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12394', '建水县', '', '3', '1274', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12395', '石屏县', '', '3', '1274', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12396', '弥勒县', '', '3', '1274', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12397', '泸西县', '', '3', '1274', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12398', '元阳县', '', '3', '1274', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12399', '红河县', '', '3', '1274', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12400', '金平苗族瑶族傣族自治县', '', '3', '1274', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12401', '绿春县', '', '3', '1274', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12402', '河口瑶族自治县', '', '3', '1274', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12403', '文山县', '', '3', '1275', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12404', '砚山县', '', '3', '1275', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12405', '西畴县', '', '3', '1275', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12406', '麻栗坡县', '', '3', '1275', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12407', '马关县', '', '3', '1275', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12408', '丘北县', '', '3', '1275', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12409', '广南县', '', '3', '1275', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12410', '富宁县', '', '3', '1275', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12411', '景洪市', '', '3', '1276', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12412', '勐海县', '', '3', '1276', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12413', '勐腊县', '', '3', '1276', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12414', '大理市', '', '3', '1277', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12415', '漾濞彝族自治县', '', '3', '1277', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12416', '祥云县', '', '3', '1277', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12417', '宾川县', '', '3', '1277', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12418', '弥渡县', '', '3', '1277', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12419', '南涧彝族自治县', '', '3', '1277', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12420', '巍山彝族回族自治县', '', '3', '1277', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12421', '永平县', '', '3', '1277', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12422', '云龙县', '', '3', '1277', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12423', '洱源县', '', '3', '1277', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12424', '剑川县', '', '3', '1277', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12425', '鹤庆县', '', '3', '1277', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12426', '瑞丽市', '', '3', '1278', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12427', '潞西市', '', '3', '1278', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12428', '梁河县', '', '3', '1278', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12429', '盈江县', '', '3', '1278', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12430', '陇川县', '', '3', '1278', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12431', '泸水县', '', '3', '1279', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12432', '福贡县', '', '3', '1279', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12433', '贡山独龙族怒族自治县', '', '3', '1279', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12434', '兰坪白族普米族自治县', '', '3', '1279', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12435', '香格里拉县', '', '3', '1280', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12436', '德钦县', '', '3', '1280', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12437', '维西傈僳族自治县', '', '3', '1280', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12438', '城关区', '', '3', '1281', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12439', '林周县', '', '3', '1281', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12440', '当雄县', '', '3', '1281', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12441', '尼木县', '', '3', '1281', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12442', '曲水县', '', '3', '1281', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12443', '堆龙德庆县', '', '3', '1281', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12444', '达孜县', '', '3', '1281', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12445', '墨竹工卡县', '', '3', '1281', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12446', '昌都县', '', '3', '1282', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12447', '江达县', '', '3', '1282', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12448', '贡觉县', '', '3', '1282', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12449', '类乌齐县', '', '3', '1282', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12450', '丁青县', '', '3', '1282', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12451', '察雅县', '', '3', '1282', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12452', '八宿县', '', '3', '1282', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12453', '左贡县', '', '3', '1282', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12454', '芒康县', '', '3', '1282', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12455', '洛隆县', '', '3', '1282', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12456', '边坝县', '', '3', '1282', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12457', '乃东县', '', '3', '1283', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12458', '扎囊县', '', '3', '1283', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12459', '贡嘎县', '', '3', '1283', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12460', '桑日县', '', '3', '1283', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12461', '琼结县', '', '3', '1283', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12462', '曲松县', '', '3', '1283', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12463', '措美县', '', '3', '1283', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12464', '洛扎县', '', '3', '1283', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12465', '加查县', '', '3', '1283', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12466', '隆子县', '', '3', '1283', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12467', '错那县', '', '3', '1283', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12468', '浪卡子县', '', '3', '1283', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12469', '日喀则市', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12470', '南木林县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12471', '江孜县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12472', '定日县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12473', '萨迦县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12474', '拉孜县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12475', '昂仁县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12476', '谢通门县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12477', '白朗县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12478', '仁布县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12479', '康马县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12480', '定结县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12481', '仲巴县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12482', '亚东县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12483', '吉隆县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12484', '聂拉木县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12485', '萨嘎县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12486', '岗巴县', '', '3', '1284', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12487', '那曲县', '', '3', '1285', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12488', '嘉黎县', '', '3', '1285', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12489', '比如县', '', '3', '1285', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12490', '聂荣县', '', '3', '1285', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12491', '安多县', '', '3', '1285', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12492', '申扎县', '', '3', '1285', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12493', '索县', '', '3', '1285', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12494', '班戈县', '', '3', '1285', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12495', '巴青县', '', '3', '1285', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12496', '尼玛县', '', '3', '1285', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12497', '普兰县', '', '3', '1286', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12498', '札达县', '', '3', '1286', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12499', '噶尔县', '', '3', '1286', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12500', '日土县', '', '3', '1286', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12501', '革吉县', '', '3', '1286', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12502', '改则县', '', '3', '1286', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12503', '措勤县', '', '3', '1286', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12504', '林芝县', '', '3', '1287', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12505', '工布江达县', '', '3', '1287', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12506', '米林县', '', '3', '1287', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12507', '墨脱县', '', '3', '1287', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12508', '波密县', '', '3', '1287', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12509', '察隅县', '', '3', '1287', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12510', '朗县', '', '3', '1287', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12511', '新城区', '', '3', '1288', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12512', '碑林区', '', '3', '1288', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12513', '莲湖区', '', '3', '1288', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12514', '灞桥区', '', '3', '1288', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12515', '未央区', '', '3', '1288', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12516', '雁塔区', '', '3', '1288', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12517', '阎良区', '', '3', '1288', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12518', '临潼区', '', '3', '1288', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12519', '长安区', '', '3', '1288', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12520', '蓝田县', '', '3', '1288', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12521', '周至县', '', '3', '1288', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12522', '户县', '', '3', '1288', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12523', '高陵县', '', '3', '1288', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12524', '王益区', '', '3', '1289', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12525', '印台区', '', '3', '1289', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12526', '耀州区', '', '3', '1289', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12527', '宜君县', '', '3', '1289', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12528', '渭滨区', '', '3', '1290', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12529', '金台区', '', '3', '1290', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12530', '陈仓区', '', '3', '1290', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12531', '凤翔县', '', '3', '1290', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12532', '岐山县', '', '3', '1290', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12533', '扶风县', '', '3', '1290', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12534', '眉县', '', '3', '1290', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12535', '陇县', '', '3', '1290', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12536', '千阳县', '', '3', '1290', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12537', '麟游县', '', '3', '1290', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12538', '凤县', '', '3', '1290', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12539', '太白县', '', '3', '1290', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12540', '秦都区', '', '3', '1291', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12541', '杨凌区', '', '3', '1291', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12542', '渭城区', '', '3', '1291', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12543', '三原县', '', '3', '1291', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12544', '泾阳县', '', '3', '1291', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12545', '乾县', '', '3', '1291', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12546', '礼泉县', '', '3', '1291', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12547', '永寿县', '', '3', '1291', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12548', '彬县', '', '3', '1291', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12549', '长武县', '', '3', '1291', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12550', '旬邑县', '', '3', '1291', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12551', '淳化县', '', '3', '1291', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12552', '武功县', '', '3', '1291', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12553', '兴平市', '', '3', '1291', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12554', '临渭区', '', '3', '1292', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12555', '华县', '', '3', '1292', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12556', '潼关县', '', '3', '1292', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12557', '大荔县', '', '3', '1292', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12558', '合阳县', '', '3', '1292', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12559', '澄城县', '', '3', '1292', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12560', '蒲城县', '', '3', '1292', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12561', '白水县', '', '3', '1292', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12562', '富平县', '', '3', '1292', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12563', '韩城市', '', '3', '1292', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12564', '华阴市', '', '3', '1292', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12565', '宝塔区', '', '3', '1293', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12566', '延长县', '', '3', '1293', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12567', '延川县', '', '3', '1293', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12568', '子长县', '', '3', '1293', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12569', '安塞县', '', '3', '1293', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12570', '志丹县', '', '3', '1293', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12571', '吴旗县', '', '3', '1293', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12572', '甘泉县', '', '3', '1293', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12573', '富县', '', '3', '1293', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12574', '洛川县', '', '3', '1293', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12575', '宜川县', '', '3', '1293', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12576', '黄龙县', '', '3', '1293', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12577', '黄陵县', '', '3', '1293', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12578', '汉台区', '', '3', '1294', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12579', '南郑县', '', '3', '1294', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12580', '城固县', '', '3', '1294', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12581', '洋县', '', '3', '1294', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12582', '西乡县', '', '3', '1294', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12583', '勉县', '', '3', '1294', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12584', '宁强县', '', '3', '1294', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12585', '略阳县', '', '3', '1294', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12586', '镇巴县', '', '3', '1294', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12587', '留坝县', '', '3', '1294', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12588', '佛坪县', '', '3', '1294', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12589', '榆阳区', '', '3', '1295', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12590', '神木县', '', '3', '1295', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12591', '府谷县', '', '3', '1295', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12592', '横山县', '', '3', '1295', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12593', '靖边县', '', '3', '1295', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12594', '定边县', '', '3', '1295', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12595', '绥德县', '', '3', '1295', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12596', '米脂县', '', '3', '1295', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12597', '佳县', '', '3', '1295', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12598', '吴堡县', '', '3', '1295', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12599', '清涧县', '', '3', '1295', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12600', '子洲县', '', '3', '1295', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12601', '汉滨区', '', '3', '1296', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12602', '汉阴县', '', '3', '1296', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12603', '石泉县', '', '3', '1296', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12604', '宁陕县', '', '3', '1296', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12605', '紫阳县', '', '3', '1296', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12606', '岚皋县', '', '3', '1296', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12607', '平利县', '', '3', '1296', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12608', '镇坪县', '', '3', '1296', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12609', '旬阳县', '', '3', '1296', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12610', '白河县', '', '3', '1296', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12611', '商州区', '', '3', '1297', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12612', '洛南县', '', '3', '1297', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12613', '丹凤县', '', '3', '1297', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12614', '商南县', '', '3', '1297', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12615', '山阳县', '', '3', '1297', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12616', '镇安县', '', '3', '1297', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12617', '柞水县', '', '3', '1297', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12618', '城关区', '', '3', '1298', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12619', '七里河区', '', '3', '1298', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12620', '西固区', '', '3', '1298', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12621', '安宁区', '', '3', '1298', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12622', '红古区', '', '3', '1298', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12623', '永登县', '', '3', '1298', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12624', '皋兰县', '', '3', '1298', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12625', '榆中县', '', '3', '1298', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12626', '金川区', '', '3', '1300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12627', '永昌县', '', '3', '1300', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12628', '白银区', '', '3', '1301', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12629', '平川区', '', '3', '1301', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12630', '靖远县', '', '3', '1301', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12631', '会宁县', '', '3', '1301', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12632', '景泰县', '', '3', '1301', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12633', '秦城区', '', '3', '1302', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12634', '北道区', '', '3', '1302', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12635', '清水县', '', '3', '1302', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12636', '秦安县', '', '3', '1302', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12637', '甘谷县', '', '3', '1302', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12638', '武山县', '', '3', '1302', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12639', '张家川回族自治县', '', '3', '1302', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12640', '凉州区', '', '3', '1303', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12641', '民勤县', '', '3', '1303', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12642', '古浪县', '', '3', '1303', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12643', '天祝藏族自治县', '', '3', '1303', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12644', '甘州区', '', '3', '1304', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12645', '肃南裕固族自治县', '', '3', '1304', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12646', '民乐县', '', '3', '1304', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12647', '临泽县', '', '3', '1304', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12648', '高台县', '', '3', '1304', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12649', '山丹县', '', '3', '1304', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12650', '崆峒区', '', '3', '1305', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12651', '泾川县', '', '3', '1305', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12652', '灵台县', '', '3', '1305', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12653', '崇信县', '', '3', '1305', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12654', '华亭县', '', '3', '1305', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12655', '庄浪县', '', '3', '1305', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12656', '静宁县', '', '3', '1305', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12657', '肃州区', '', '3', '1306', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12658', '金塔县', '', '3', '1306', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12659', '安西县', '', '3', '1306', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12660', '肃北蒙古族自治县', '', '3', '1306', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12661', '阿克塞哈萨克族自治县', '', '3', '1306', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12662', '玉门市', '', '3', '1306', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12663', '敦煌市', '', '3', '1306', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12664', '西峰区', '', '3', '1307', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12665', '庆城县', '', '3', '1307', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12666', '环县', '', '3', '1307', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12667', '华池县', '', '3', '1307', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12668', '合水县', '', '3', '1307', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12669', '正宁县', '', '3', '1307', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12670', '宁县', '', '3', '1307', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12671', '镇原县', '', '3', '1307', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12672', '安定区', '', '3', '1308', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12673', '通渭县', '', '3', '1308', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12674', '陇西县', '', '3', '1308', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12675', '渭源县', '', '3', '1308', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12676', '临洮县', '', '3', '1308', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12677', '漳县', '', '3', '1308', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12678', '岷县', '', '3', '1308', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12679', '武都区', '', '3', '1309', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12680', '成县', '', '3', '1309', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12681', '文县', '', '3', '1309', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12682', '宕昌县', '', '3', '1309', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12683', '康县', '', '3', '1309', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12684', '西和县', '', '3', '1309', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12685', '礼县', '', '3', '1309', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12686', '徽县', '', '3', '1309', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12687', '两当县', '', '3', '1309', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12688', '临夏市', '', '3', '1310', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12689', '临夏县', '', '3', '1310', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12690', '康乐县', '', '3', '1310', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12691', '永靖县', '', '3', '1310', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12692', '广河县', '', '3', '1310', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12693', '和政县', '', '3', '1310', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12694', '东乡族自治县', '', '3', '1310', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12695', '积石山保安族东乡族撒拉族自治县', '', '3', '1310', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12696', '合作市', '', '3', '1311', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12697', '临潭县', '', '3', '1311', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12698', '卓尼县', '', '3', '1311', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12699', '舟曲县', '', '3', '1311', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12700', '迭部县', '', '3', '1311', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12701', '玛曲县', '', '3', '1311', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12702', '碌曲县', '', '3', '1311', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12703', '夏河县', '', '3', '1311', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12704', '城东区', '', '3', '1312', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12705', '城中区', '', '3', '1312', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12706', '城西区', '', '3', '1312', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12707', '城北区', '', '3', '1312', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12708', '大通回族土族自治县', '', '3', '1312', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12709', '湟中县', '', '3', '1312', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12710', '湟源县', '', '3', '1312', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12711', '平安县', '', '3', '1313', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12712', '民和回族土族自治县', '', '3', '1313', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12713', '乐都县', '', '3', '1313', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12714', '互助土族自治县', '', '3', '1313', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12715', '化隆回族自治县', '', '3', '1313', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12716', '循化撒拉族自治县', '', '3', '1313', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12717', '门源回族自治县', '', '3', '1314', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12718', '祁连县', '', '3', '1314', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12719', '海晏县', '', '3', '1314', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12720', '刚察县', '', '3', '1314', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12721', '同仁县', '', '3', '1315', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12722', '尖扎县', '', '3', '1315', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12723', '泽库县', '', '3', '1315', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12724', '河南蒙古族自治县', '', '3', '1315', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12725', '共和县', '', '3', '1316', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12726', '同德县', '', '3', '1316', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12727', '贵德县', '', '3', '1316', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12728', '兴海县', '', '3', '1316', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12729', '贵南县', '', '3', '1316', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12730', '玛沁县', '', '3', '1317', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12731', '班玛县', '', '3', '1317', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12732', '甘德县', '', '3', '1317', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12733', '达日县', '', '3', '1317', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12734', '久治县', '', '3', '1317', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12735', '玛多县', '', '3', '1317', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12736', '玉树县', '', '3', '1318', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12737', '杂多县', '', '3', '1318', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12738', '称多县', '', '3', '1318', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12739', '治多县', '', '3', '1318', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12740', '囊谦县', '', '3', '1318', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12741', '曲麻莱县', '', '3', '1318', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12742', '格尔木市', '', '3', '1319', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12743', '德令哈市', '', '3', '1319', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12744', '乌兰县', '', '3', '1319', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12745', '都兰县', '', '3', '1319', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12746', '天峻县', '', '3', '1319', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12747', '兴庆区', '', '3', '1320', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12748', '西夏区', '', '3', '1320', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12749', '金凤区', '', '3', '1320', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12750', '永宁县', '', '3', '1320', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12751', '贺兰县', '', '3', '1320', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12752', '灵武市', '', '3', '1320', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12753', '大武口区', '', '3', '1321', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12754', '惠农区', '', '3', '1321', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12755', '平罗县', '', '3', '1321', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12756', '利通区', '', '3', '1322', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12757', '盐池县', '', '3', '1322', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12758', '同心县', '', '3', '1322', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12759', '青铜峡市', '', '3', '1322', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12760', '原州区', '', '3', '1323', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12761', '西吉县', '', '3', '1323', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12762', '隆德县', '', '3', '1323', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12763', '泾源县', '', '3', '1323', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12764', '彭阳县', '', '3', '1323', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12765', '沙坡头区', '', '3', '1324', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12766', '中宁县', '', '3', '1324', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12767', '海原县', '', '3', '1324', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12768', '天山区', '', '3', '1325', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12769', '沙依巴克区', '', '3', '1325', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12770', '新市区', '', '3', '1325', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12771', '水磨沟区', '', '3', '1325', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12772', '头屯河区', '', '3', '1325', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12773', '达坂城区', '', '3', '1325', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12774', '东山区', '', '3', '1325', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12775', '乌鲁木齐县', '', '3', '1325', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12776', '独山子区', '', '3', '1326', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12777', '克拉玛依区', '', '3', '1326', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12778', '白碱滩区', '', '3', '1326', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12779', '乌尔禾区', '', '3', '1326', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12780', '吐鲁番市', '', '3', '1327', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12781', '鄯善县', '', '3', '1327', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12782', '托克逊县', '', '3', '1327', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12783', '哈密市', '', '3', '1328', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12784', '巴里坤哈萨克自治县', '', '3', '1328', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12785', '伊吾县', '', '3', '1328', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12786', '昌吉市', '', '3', '1329', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12787', '阜康市', '', '3', '1329', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12788', '米泉市', '', '3', '1329', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12789', '呼图壁县', '', '3', '1329', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12790', '玛纳斯县', '', '3', '1329', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12791', '奇台县', '', '3', '1329', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12792', '吉木萨尔县', '', '3', '1329', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12793', '木垒哈萨克自治县', '', '3', '1329', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12794', '博乐市', '', '3', '1330', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12795', '精河县', '', '3', '1330', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12796', '温泉县', '', '3', '1330', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12797', '库尔勒市', '', '3', '1331', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12798', '轮台县', '', '3', '1331', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12799', '尉犁县', '', '3', '1331', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12800', '若羌县', '', '3', '1331', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12801', '且末县', '', '3', '1331', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12802', '焉耆回族自治县', '', '3', '1331', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12803', '和静县', '', '3', '1331', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12804', '和硕县', '', '3', '1331', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12805', '博湖县', '', '3', '1331', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12806', '阿克苏市', '', '3', '1332', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12807', '温宿县', '', '3', '1332', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12808', '库车县', '', '3', '1332', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12809', '沙雅县', '', '3', '1332', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12810', '新和县', '', '3', '1332', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12811', '拜城县', '', '3', '1332', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12812', '乌什县', '', '3', '1332', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12813', '阿瓦提县', '', '3', '1332', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12814', '柯坪县', '', '3', '1332', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12815', '阿图什市', '', '3', '1333', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12816', '阿克陶县', '', '3', '1333', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12817', '阿合奇县', '', '3', '1333', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12818', '乌恰县', '', '3', '1333', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12819', '喀什市', '', '3', '1334', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12820', '疏附县', '', '3', '1334', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12821', '疏勒县', '', '3', '1334', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12822', '英吉沙县', '', '3', '1334', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12823', '泽普县', '', '3', '1334', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12824', '莎车县', '', '3', '1334', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12825', '叶城县', '', '3', '1334', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12826', '麦盖提县', '', '3', '1334', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12827', '岳普湖县', '', '3', '1334', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12828', '伽师县', '', '3', '1334', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12829', '巴楚县', '', '3', '1334', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12830', '塔什库尔干塔吉克自治县', '', '3', '1334', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12831', '和田市', '', '3', '1335', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12832', '和田县', '', '3', '1335', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12833', '墨玉县', '', '3', '1335', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12834', '皮山县', '', '3', '1335', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12835', '洛浦县', '', '3', '1335', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12836', '策勒县', '', '3', '1335', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12837', '于田县', '', '3', '1335', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12838', '民丰县', '', '3', '1335', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12839', '伊宁市', '', '3', '1336', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12840', '奎屯市', '', '3', '1336', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12841', '伊宁县', '', '3', '1336', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12842', '察布查尔锡伯自治县', '', '3', '1336', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12843', '霍城县', '', '3', '1336', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12844', '巩留县', '', '3', '1336', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12845', '新源县', '', '3', '1336', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12846', '昭苏县', '', '3', '1336', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12847', '特克斯县', '', '3', '1336', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12848', '尼勒克县', '', '3', '1336', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12849', '塔城市', '', '3', '1337', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12850', '乌苏市', '', '3', '1337', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12851', '额敏县', '', '3', '1337', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12852', '沙湾县', '', '3', '1337', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12853', '托里县', '', '3', '1337', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12854', '裕民县', '', '3', '1337', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12855', '和布克赛尔蒙古自治县', '', '3', '1337', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12856', '阿勒泰市', '', '3', '1338', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12857', '布尔津县', '', '3', '1338', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12858', '富蕴县', '', '3', '1338', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12859', '福海县', '', '3', '1338', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12860', '哈巴河县', '', '3', '1338', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12861', '青河县', '', '3', '1338', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('12862', '吉木乃县', '', '3', '1338', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13001', '台北市', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13002', '新北市', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13003', '桃园市', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13004', '台中市', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13005', '台南市', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13006', '高雄市', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13007', '基隆市', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13008', '新竹市', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13009', '嘉义市', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13010', '宜兰县', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13011', '新竹县', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13012', '苗栗县', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13013', '彰化县', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13014', '南投县', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13015', '嘉义县', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13016', '云林县', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13017', '屏东县', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13018', '台东县', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13019', '花莲县', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('13020', '澎湖县', '', '3', '1345', '0', null, null, null, null);
INSERT INTO `m_area` VALUES ('121401', '港口镇', '528400', '3', '1214', '0', null, null, null, null);

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
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8;

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
INSERT INTO `m_code` VALUES ('20', '4', null, null, null, null, '角色类型', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('21', '4', '1', '销售', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('22', '4', '2', '采购', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('23', '4', '3', '财务', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('24', '4', '99', '系统管理', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('25', '5', null, null, null, null, '支付方式', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('26', '5', '1', '转账', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('27', '5', '2', '现金', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('28', '6', null, null, null, null, '支付状态', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('29', '6', '1', '未支付', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('30', '6', '2', '部分支付', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('31', '6', '3', '全部支付', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('32', '7', null, null, null, null, '订单状态', '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('33', '7', '1', '已下单', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('34', '7', '2', '生产中', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('35', '7', '3', '配送中', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('36', '7', '4', '已收货', null, null, null, '0', null, null, null, null);
INSERT INTO `m_code` VALUES ('38', '7', '5', '已完成', null, null, null, '0', null, null, null, null);

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
INSERT INTO `m_menu` VALUES ('601', '6', '供应商管理', 'PMS.Frm.Sale.FrmCustomerManage', 'chk_purchase_provider', '601', '0', null, null, null, null);
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
INSERT INTO `m_role` VALUES ('2', '商品管理', null, '0', null, '2016-11-29 21:13:06', 'admin', '2016-12-03 15:04:41');
INSERT INTO `m_role` VALUES ('3', '销售管理', '1', '0', null, '2016-11-29 21:13:06', 'admin', '2016-12-21 13:55:08');
INSERT INTO `m_role` VALUES ('4', '仓库管理', null, '0', null, '2016-11-29 21:13:06', null, null);
INSERT INTO `m_role` VALUES ('5', '生产管理', null, '0', null, '2016-11-29 21:13:06', null, null);
INSERT INTO `m_role` VALUES ('6', '采购管理', '2', '0', null, '2016-11-29 21:13:06', 'admin', '2016-12-21 16:02:50');
INSERT INTO `m_role` VALUES ('7', '财务管理', '3', '0', null, '2016-11-29 21:13:06', 'admin', '2016-12-21 16:06:30');
INSERT INTO `m_role` VALUES ('8', '测试角色1', null, '1', 'admin', '2016-11-29 21:34:21', 'admin', '2016-11-29 21:40:46');

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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of m_user
-- ----------------------------
INSERT INTO `m_user` VALUES ('1', 'admin', 'admin', '1', '男', 'boss', '1333333333', 'admin@admin.com', '2016-11-01', '0', 'sys', '2016-11-01 14:35:26', 'admin', '2016-11-17 15:31:15');
INSERT INTO `m_user` VALUES ('2', 'test1', 'admin', '2', '男', '', '', '', '2016-11-17', '0', 'admin', '2016-11-17 15:57:48', 'admin', '2016-11-19 12:19:05');
INSERT INTO `m_user` VALUES ('3', 'saler1', 'saler1', '3', '男', '', '', '', '2016-12-21', '0', 'admin', '2016-12-21 13:56:01', 'admin', '2016-12-21 13:56:01');
INSERT INTO `m_user` VALUES ('4', 'saler2', 'saler2', '3', '男', '', '', '', '2016-12-21', '0', 'admin', '2016-12-21 14:53:04', 'admin', '2016-12-21 14:53:04');
INSERT INTO `m_user` VALUES ('5', 'cw1', 'cw1', '7', '', '', '', '', '2016-12-21', '0', 'admin', '2016-12-21 16:05:48', 'admin', '2016-12-21 16:05:48');

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
  `creditLimit` decimal(20,0) DEFAULT NULL COMMENT '信用额',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of p_customer
-- ----------------------------
INSERT INTO `p_customer` VALUES ('1', 'sc0001', 'sale customer1', '', '101', '北京市', '1001', '北京市', '10001', '东城区', 'test address1', '200000', '20001', '10001', '10002', 'Kevin', 'Boss', '110', '1', '3', 'null', '1000', '0', 'admin', '2016-12-21 14:49:32', 'admin', '2016-12-21 14:51:51');
INSERT INTO `p_customer` VALUES ('2', 'sc002', 'sale customer 2', '', '104', '山西省', '1016', '阳泉市', '10232', '郊区', 'test address 2', '', '', '', '', '', '', '', '1', '4', '', '0', '1', 'saler2', '2016-12-21 14:54:05', 'admin', '2016-12-21 15:04:43');

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
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of p_materials
-- ----------------------------
INSERT INTO `p_materials` VALUES ('1', '原料1', '原料略称1', '1', '说明1', '50.00', '1', '1', '100', '10', '20', '0', 'admin', '2016-12-04 13:04:41', 'admin', '2016-12-04 13:26:49');
INSERT INTO `p_materials` VALUES ('2', '原料2', '', '2', '', '1.00', '1', '3', '1', '1', '1', '0', 'admin', '2016-12-13 21:58:50', 'admin', '2016-12-13 21:58:50');

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
INSERT INTO `p_product` VALUES ('4', '商品1', '', '1', '', '1.00', '1', '1', '1', '1', '1', '0', 'admin', '2016-12-08 16:59:48', 'admin', '2016-12-13 21:55:02');
INSERT INTO `p_product` VALUES ('6', 'test2', '', '1', '', '2.00', '1', '1', '2', '2', '2', '1', 'admin', '2016-12-13 21:31:24', 'admin', '2016-12-13 21:33:58');
INSERT INTO `p_product` VALUES ('7', '商品2', '', '3', '', '2.00', '3', '3', '2', '2', '2', '0', 'admin', '2016-12-13 21:43:45', 'admin', '2016-12-13 22:00:57');

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
  `payStatus` int(10) DEFAULT NULL COMMENT '支付状态(code：6）',
  `country` varchar(10) DEFAULT NULL COMMENT '国家',
  `province` int(10) DEFAULT NULL COMMENT '省',
  `provinceName` varchar(30) DEFAULT NULL COMMENT '省名',
  `city` int(10) DEFAULT NULL COMMENT '市',
  `cityName` varchar(30) DEFAULT NULL COMMENT '市名',
  `district` int(10) DEFAULT NULL COMMENT '区',
  `districtName` varchar(30) DEFAULT NULL COMMENT '区名',
  `address` varchar(300) DEFAULT NULL COMMENT '客户地址',
  `manager` varchar(20) DEFAULT NULL COMMENT '联系人姓名',
  `telephone` varchar(30) DEFAULT NULL COMMENT '联系人电话',
  `deliverDate` datetime DEFAULT NULL COMMENT '交货日期',
  `orderStaus` int(255) DEFAULT NULL COMMENT '订单状态（Code：7）',
  `remark` varchar(255) DEFAULT NULL,
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of p_saleorder
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_materials_price
-- ----------------------------
INSERT INTO `r_materials_price` VALUES ('1', '1', '500', '1', '0', null, null, 'admin', '2016-12-04 13:26:49');
INSERT INTO `r_materials_price` VALUES ('2', '2', '1', '1', '0', null, null, null, null);

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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_materials_search
-- ----------------------------
INSERT INTO `r_materials_search` VALUES ('2', '1', '原料1', 'm1');
INSERT INTO `r_materials_search` VALUES ('6', '2', '原料2', 'm2');

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
  `materialsNum` decimal(10,2) DEFAULT NULL COMMENT '原料重量',
  `materialsUnit` int(10) DEFAULT NULL COMMENT '重量单位',
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of r_product_materials
-- ----------------------------
INSERT INTO `r_product_materials` VALUES ('32', '4', '1', '', '', '1.00', '1', '0', 'admin', '2016-12-13 21:55:02', 'admin', '2016-12-13 21:55:02');
INSERT INTO `r_product_materials` VALUES ('34', '7', '2', 'm2', '', '2.00', '3', '0', 'admin', '2016-12-13 22:00:57', 'admin', '2016-12-13 22:00:57');

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
INSERT INTO `r_product_price` VALUES ('1', '4', '1', '1', '1', '0', null, null, 'admin', '2016-12-13 21:55:02');
INSERT INTO `r_product_price` VALUES ('3', '6', '2', '2', '1', '1', null, null, 'admin', '2016-12-13 21:33:58');
INSERT INTO `r_product_price` VALUES ('4', '7', '2', '2', '3', '0', null, null, 'admin', '2016-12-13 22:00:57');

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
INSERT INTO `r_product_search` VALUES ('1', '4', 'product1', 'p1');
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
) ENGINE=InnoDB AUTO_INCREMENT=167 DEFAULT CHARSET=utf8;

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
INSERT INTO `r_role_menu` VALUES ('103', '2', '302', '0', 'admin', '2016-12-03 15:04:41', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('104', '2', '301', '0', 'admin', '2016-12-03 15:04:41', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('105', '2', '3', '0', 'admin', '2016-12-03 15:04:41', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('106', '2', '2', '0', 'admin', '2016-12-03 15:04:41', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('107', '2', '0', '0', 'admin', '2016-12-03 15:04:41', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('108', '2', '202', '0', 'admin', '2016-12-03 15:04:41', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('109', '2', '201', '0', 'admin', '2016-12-03 15:04:41', 'admin', '2016-12-03 15:04:41');
INSERT INTO `r_role_menu` VALUES ('110', '3', '0', '0', 'admin', '2016-12-21 13:55:08', 'admin', '2016-12-21 13:55:08');
INSERT INTO `r_role_menu` VALUES ('111', '3', '302', '0', 'admin', '2016-12-21 13:55:08', 'admin', '2016-12-21 13:55:08');
INSERT INTO `r_role_menu` VALUES ('112', '3', '301', '0', 'admin', '2016-12-21 13:55:08', 'admin', '2016-12-21 13:55:08');
INSERT INTO `r_role_menu` VALUES ('113', '3', '3', '0', 'admin', '2016-12-21 13:55:08', 'admin', '2016-12-21 13:55:08');
INSERT INTO `r_role_menu` VALUES ('114', '3', '2', '0', 'admin', '2016-12-21 13:55:08', 'admin', '2016-12-21 13:55:08');
INSERT INTO `r_role_menu` VALUES ('115', '3', '201', '0', 'admin', '2016-12-21 13:55:08', 'admin', '2016-12-21 13:55:08');
INSERT INTO `r_role_menu` VALUES ('116', '6', '604', '1', 'admin', '2016-12-21 16:01:40', 'admin', '2016-12-21 16:02:50');
INSERT INTO `r_role_menu` VALUES ('117', '6', '603', '1', 'admin', '2016-12-21 16:01:40', 'admin', '2016-12-21 16:02:50');
INSERT INTO `r_role_menu` VALUES ('118', '6', '601', '1', 'admin', '2016-12-21 16:01:40', 'admin', '2016-12-21 16:02:50');
INSERT INTO `r_role_menu` VALUES ('119', '6', '6', '1', 'admin', '2016-12-21 16:01:40', 'admin', '2016-12-21 16:02:50');
INSERT INTO `r_role_menu` VALUES ('120', '6', '604', '0', 'admin', '2016-12-21 16:02:50', 'admin', '2016-12-21 16:02:50');
INSERT INTO `r_role_menu` VALUES ('121', '6', '603', '0', 'admin', '2016-12-21 16:02:50', 'admin', '2016-12-21 16:02:50');
INSERT INTO `r_role_menu` VALUES ('122', '6', '601', '0', 'admin', '2016-12-21 16:02:50', 'admin', '2016-12-21 16:02:50');
INSERT INTO `r_role_menu` VALUES ('123', '6', '6', '0', 'admin', '2016-12-21 16:02:50', 'admin', '2016-12-21 16:02:50');
INSERT INTO `r_role_menu` VALUES ('124', '7', '704', '1', 'admin', '2016-12-21 16:03:07', 'admin', '2016-12-21 16:06:30');
INSERT INTO `r_role_menu` VALUES ('125', '7', '703', '1', 'admin', '2016-12-21 16:03:07', 'admin', '2016-12-21 16:06:30');
INSERT INTO `r_role_menu` VALUES ('126', '7', '702', '1', 'admin', '2016-12-21 16:03:07', 'admin', '2016-12-21 16:06:30');
INSERT INTO `r_role_menu` VALUES ('127', '7', '701', '1', 'admin', '2016-12-21 16:03:07', 'admin', '2016-12-21 16:06:30');
INSERT INTO `r_role_menu` VALUES ('128', '7', '7', '1', 'admin', '2016-12-21 16:03:07', 'admin', '2016-12-21 16:06:30');
INSERT INTO `r_role_menu` VALUES ('129', '7', '704', '0', 'admin', '2016-12-21 16:06:30', 'admin', '2016-12-21 16:06:30');
INSERT INTO `r_role_menu` VALUES ('130', '7', '703', '0', 'admin', '2016-12-21 16:06:30', 'admin', '2016-12-21 16:06:30');
INSERT INTO `r_role_menu` VALUES ('131', '7', '702', '0', 'admin', '2016-12-21 16:06:30', 'admin', '2016-12-21 16:06:30');
INSERT INTO `r_role_menu` VALUES ('132', '7', '701', '0', 'admin', '2016-12-21 16:06:30', 'admin', '2016-12-21 16:06:30');
INSERT INTO `r_role_menu` VALUES ('133', '7', '7', '0', 'admin', '2016-12-21 16:06:30', 'admin', '2016-12-21 16:06:30');
INSERT INTO `r_role_menu` VALUES ('134', '7', '2', '0', 'admin', '2016-12-21 16:06:30', 'admin', '2016-12-21 16:06:30');
INSERT INTO `r_role_menu` VALUES ('135', '7', '0', '0', 'admin', '2016-12-21 16:06:30', 'admin', '2016-12-21 16:06:30');
INSERT INTO `r_role_menu` VALUES ('136', '7', '202', '0', 'admin', '2016-12-21 16:06:30', 'admin', '2016-12-21 16:06:30');
INSERT INTO `r_role_menu` VALUES ('137', '7', '201', '0', 'admin', '2016-12-21 16:06:30', 'admin', '2016-12-21 16:06:30');
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

-- ----------------------------
-- Table structure for r_saleorder_detail
-- ----------------------------
DROP TABLE IF EXISTS `r_saleorder_detail`;
CREATE TABLE `r_saleorder_detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `orderCode` varchar(50) DEFAULT NULL,
  `productId` int(10) DEFAULT NULL COMMENT '产品ID',
  `num` decimal(10,0) DEFAULT NULL COMMENT '数量',
  `price` datetime DEFAULT NULL COMMENT '销售金额',
  `remark` varchar(255) DEFAULT NULL,
  `isDelete` int(11) DEFAULT '0',
  `createBy` varchar(50) DEFAULT NULL,
  `createTime` datetime DEFAULT NULL,
  `modifyBy` varchar(50) DEFAULT NULL,
  `modifyTime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

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
