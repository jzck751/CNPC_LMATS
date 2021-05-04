/*
 Navicat Premium Data Transfer

 Source Server         : localhost_3306
 Source Server Type    : MySQL
 Source Server Version : 80022
 Source Host           : localhost:3306
 Source Schema         : cnpc_lmats

 Target Server Type    : MySQL
 Target Server Version : 80022
 File Encoding         : 65001

 Date: 04/05/2021 11:47:17
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for mc_after-effect-gas-detection
-- ----------------------------
DROP TABLE IF EXISTS `mc_after-effect-gas-detection`;
CREATE TABLE `mc_after-effect-gas-detection`  (
  `date` datetime NOT NULL COMMENT '日期',
  `wellDepth` double NOT NULL COMMENT '井深',
  `drillLocation` double NOT NULL COMMENT '钻头位置',
  `standstillTimeOfOakbowl` datetime NOT NULL COMMENT '井筒静止时间',
  `timeLag` datetime NOT NULL COMMENT '迟到时间',
  `replaceTheInterval` double NOT NULL COMMENT '归为井段',
  `theHightOfUp` double NOT NULL COMMENT '上窜高度',
  `theSpeedOfUp` double NOT NULL COMMENT '上窜速度',
  `grooveFaceShows` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '槽面显示',
  `drillWellLiquidDensity` double NOT NULL COMMENT '钻井液密度',
  `drillWellLiquidViscosity` double NOT NULL COMMENT '钻井液粘度',
  `thePeakOfHydrocarbonBeginTime` datetime NOT NULL COMMENT '全烃出峰开始时间',
  `thePeakOfHydrocarbonPeakTime` datetime NOT NULL COMMENT '高峰时间',
  `thePeakOfHydrocarbonOverTime` datetime NOT NULL COMMENT '结束时间',
  `thePeakOfHydrocarbonBeginValue` double NOT NULL COMMENT '开始值',
  `thePeakOfHydrocarbonPeakValue` double NOT NULL COMMENT '高峰值',
  `thePeakOfHydrocarbonOverValue` double NOT NULL COMMENT '结束值'
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_annular-tubes-record
-- ----------------------------
DROP TABLE IF EXISTS `mc_annular-tubes-record`;
CREATE TABLE `mc_annular-tubes-record`  (
  `serialNumber` int NOT NULL AUTO_INCREMENT COMMENT '序号',
  `size` double NOT NULL COMMENT '尺寸',
  `totalOfLength` double NOT NULL COMMENT '累长',
  `underTheDepth` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '下深',
  `placeOfOrigin` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '产地',
  `steelThickness` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '钢级',
  `wallThickness` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '壁厚',
  `soloLength` double NOT NULL COMMENT '单根长',
  `remark` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`serialNumber`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_carbonate-rock-content-analyse
-- ----------------------------
DROP TABLE IF EXISTS `mc_carbonate-rock-content-analyse`;
CREATE TABLE `mc_carbonate-rock-content-analyse`  (
  `serialNumber` int NOT NULL AUTO_INCREMENT COMMENT '序号',
  `wellDepth` double NOT NULL COMMENT '井深',
  `sampleType` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '样品类型',
  `caCo3Content` double NOT NULL COMMENT '碳酸盐含量',
  `magnesiumAndCalciumCarbonateContent` double NOT NULL COMMENT '碳酸镁含量',
  `otherMineralSubstance` double NOT NULL COMMENT '其它矿物质含量',
  PRIMARY KEY (`serialNumber`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_core-block-length-and-well-depth-corrected
-- ----------------------------
DROP TABLE IF EXISTS `mc_core-block-length-and-well-depth-corrected`;
CREATE TABLE `mc_core-block-length-and-well-depth-corrected`  (
  `theNumberOfCoring` int NOT NULL AUTO_INCREMENT COMMENT '取芯次数',
  `totalBlockNumber` int NOT NULL COMMENT '总块号',
  `blockNumber` int NOT NULL COMMENT '块号',
  `blockLength` double NOT NULL COMMENT '块长',
  `theCumulativeLengthOfTheCylinder` double NOT NULL COMMENT '本筒累计长度',
  `crushedAndPolishedSurface` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '破碎及磨光面',
  `drillingBoundaryDepth` double NOT NULL COMMENT '钻井底界深度',
  `corredtedValue` double NOT NULL COMMENT '矫正值',
  `loggingBottonDepth` double NOT NULL COMMENT '测井底界深度',
  `lithologicSegmentNumber` int NOT NULL COMMENT '岩性分段序号',
  `lithologicSectionThickness` double NOT NULL COMMENT '言行段厚度',
  `compressedLength` double NOT NULL COMMENT '压缩（拉伸）长度',
  `theLithologyNamed` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性定名',
  PRIMARY KEY (`theNumberOfCoring`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_drill-wall-and-take-core-record
-- ----------------------------
DROP TABLE IF EXISTS `mc_drill-wall-and-take-core-record`;
CREATE TABLE `mc_drill-wall-and-take-core-record`  (
  `canisterNumber` int NOT NULL COMMENT '筒次',
  `wellTopDepth` double NOT NULL COMMENT '井段顶深',
  `wllBottomDepth` double NOT NULL COMMENT '井段底神',
  `measureInto` double NOT NULL COMMENT '进尺',
  `rockCoreLength` double NOT NULL COMMENT '岩心长度',
  `harvestRate` double NOT NULL COMMENT '收获率',
  `position` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '层位',
  `containOil` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '饱含油',
  `beRichOil` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '富含油',
  `oilImmersion` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '油浸',
  `oilPatch` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '油斑',
  `oilStains` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '油迹',
  `fluorescence` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '荧光',
  `containGas` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '含气',
  `totalContainOilGasCoreLeng` double NOT NULL COMMENT '累计含油气岩心长度',
  `coreNumber` int NOT NULL AUTO_INCREMENT COMMENT '岩心编号',
  `damageCircumstance` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '磨损情况',
  `totalLength` double NOT NULL COMMENT '累计长度',
  `rockSampleNumber` int NOT NULL COMMENT '岩样编号',
  `color` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '颜色',
  `oilLevel` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '含油级别',
  `oilLithology` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性',
  `lithologyAndDescriptionOfHydrocarbonAndWater` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性及含油气水描述',
  `wetAccordingToColor` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '湿照颜色',
  `accordingToTheColor` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '滴照颜色',
  `contrastLevel` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '对比级别',
  PRIMARY KEY (`coreNumber`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_five-peak
-- ----------------------------
DROP TABLE IF EXISTS `mc_five-peak`;
CREATE TABLE `mc_five-peak`  (
  `parameterS11` double NOT NULL COMMENT '参数S11',
  `parameterS21` double NOT NULL COMMENT '参数S21',
  `parameterS22` double NOT NULL COMMENT '参数S22',
  `parameterS23` double NOT NULL COMMENT '参数S23',
  `parameterS4` double NOT NULL COMMENT '参数S4'
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_light-dydrocarbon-log-well-analyse
-- ----------------------------
DROP TABLE IF EXISTS `mc_light-dydrocarbon-log-well-analyse`;
CREATE TABLE `mc_light-dydrocarbon-log-well-analyse`  (
  `wellDepth` double NOT NULL COMMENT '井深',
  `position` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '层位',
  `theLithologyNamed` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性定名',
  `ingredients` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '组分',
  `peakAreas` double NOT NULL COMMENT '峰面积'
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_log-well-blackboard-newspaper
-- ----------------------------
DROP TABLE IF EXISTS `mc_log-well-blackboard-newspaper`;
CREATE TABLE `mc_log-well-blackboard-newspaper`  (
  `date` datetime NOT NULL COMMENT '日期',
  `classes` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '班次',
  `watch` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '值班人',
  `handsTheWellDepth` double NOT NULL COMMENT '交班井深',
  `position` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '层位',
  `drillingFootage` double NOT NULL COMMENT '进尺',
  `drillingToolStructure` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '钻具结构',
  `gasAndWaterDisplay` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性及油气水显示',
  `instrumentOperationAndCalibration` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '仪器运行及校验',
  `loggingCaptain` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '录井队长签字',
  `geologicalSupervision` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '地质监督签字',
  `drillingWellSituationDate` datetime NOT NULL COMMENT '钻井工况时间',
  `constructionBrief` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '施工简况',
  `drillNumber` int NOT NULL COMMENT '钻头序号',
  `drillSize` double NOT NULL COMMENT '钻头尺寸',
  `drillType` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '钻头类型',
  `drillTheCumulativePenetration` double NOT NULL COMMENT '钻头累计进尺',
  `drillAccumulatedNetDrillingTime` datetime NOT NULL COMMENT '累计纯钻时间',
  `drillPresure` double NOT NULL COMMENT '钻压',
  `wheelRebolutions` double NOT NULL COMMENT '转盘转数',
  `displacement` double NOT NULL COMMENT '排量',
  `pumpingPresure` double NOT NULL COMMENT '泵压',
  `torque` double NOT NULL COMMENT '扭矩',
  `hangingLoad` double NOT NULL COMMENT '悬重',
  `drillingFluidType` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '钻井液类型',
  `drillingFluiddensity` double NOT NULL COMMENT '钻井液密度',
  `drillingFluidViscosity` double NOT NULL COMMENT '钻井液粘度',
  `drillingFluidWaterLoss` double NOT NULL COMMENT '钻井液失水',
  `drillingFluidMudCake` double NOT NULL COMMENT '泥饼',
  `drillingFluidForCutting` double NOT NULL COMMENT '补切',
  `drillingFluidEgress` double NOT NULL COMMENT '终切',
  `drillingFluidSandContent` double NOT NULL COMMENT '含沙',
  `drillingFluidCoefficientOfFrictionResistance` double NOT NULL COMMENT '摩阻系数',
  `drillingFluid_300_revolutions` double NOT NULL COMMENT '300转读数',
  `drillingFluid_600_revolutions` double NOT NULL COMMENT '600转读数',
  `drillingFluidHTTPWaterLoss` double NOT NULL COMMENT 'HTTP失水',
  `drillingFluidPhValue` double NOT NULL COMMENT 'ph值',
  `drillingFluidLikeTheContent` double NOT NULL COMMENT '般土含量',
  `drillingFluidSolidContent` double NOT NULL COMMENT '固相含量',
  `drillingFluidChloridion` double NOT NULL COMMENT '氯离子',
  `drillingFluidTotalSalinity` double NOT NULL COMMENT '总矿化度',
  `drillingFluidAffectsLoggingTreatmentAgents` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '影响录井处理剂',
  `measureTheHoleDepth` double NOT NULL COMMENT '测量井深',
  `delayTime` datetime NOT NULL COMMENT '迟到时间',
  `loggingProjects` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '录井项目',
  `wellDepthToDepth` double NOT NULL COMMENT '井段',
  `analyseSampleNumber` int NOT NULL COMMENT '分析样品个数',
  `remark` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '备注',
  `exceptionReportTime` datetime NOT NULL COMMENT '异常报告时间',
  `exceptionReportWellDepth` double NOT NULL COMMENT '异常报告井深',
  `exceptionType` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '异常类型',
  `adaptSituation` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '采纳情况',
  `surveyWellDepth` double NOT NULL COMMENT '测斜井深',
  `holeDriftAngle` double NOT NULL COMMENT '井斜角',
  `azimuthalAngle` double NOT NULL COMMENT '方位角',
  `drillTakeCoreCanister` int NOT NULL COMMENT '钻井取芯筒次',
  `drillTakeCorePosition` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '钻井取芯层位',
  `drillTakeCoreDepthToDepth` double NOT NULL COMMENT '钻井取芯井段',
  `drillTakeCoreFootage` double NOT NULL COMMENT '钻井取芯进尺',
  `drillTakeCoreCrockCoringLength` double NOT NULL COMMENT '钻井取芯岩心长度',
  `drillTakeCoreYieldRate` double NOT NULL COMMENT '钻井取芯收获率',
  `wellWallTakeCoredate` datetime NOT NULL COMMENT '井壁取芯时间',
  `wellWallTakeCoreWay` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '井壁取芯方式',
  `wellWallTakeCoreDesignNumber` int NOT NULL COMMENT '井壁取芯设计颗数',
  `wellWallTakeCoreYieldRate` double NOT NULL COMMENT '井壁取芯收获率',
  `afterEffectGasDetectionDate` datetime NOT NULL COMMENT '后效气检测时间',
  `afterEffectGasDetectionDrillLocation` double NOT NULL COMMENT '后效气检测钻头位置',
  `afterEffectGasDetectionThePeakOfHudrocarbon` double NOT NULL COMMENT '后效气检测全烃峰值',
  `afterEffectGasDetectionSoarSpeed` double NOT NULL COMMENT '后效气检测上窜速度',
  `afterEffectGasDetectionDensity` double NOT NULL COMMENT '后效气检测密度',
  `afterEffectGasDetectionViscosity` double NOT NULL COMMENT '后效气检测粘度',
  `afterEffectGasDetectionGrooveFaceShows` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '后效气检测槽面显示',
  `drillDifficultOrAcidentAndHandleProcess_WellDepth` double NOT NULL COMMENT '钻井复杂或事故及处理过程之井深',
  `drillDifficultOrAcidentAndHandleProcess_date` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '钻井复杂或事故及处理过程之时间',
  `drillDifficultOrAcidentAndHandleProcess_stratum` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '钻井复杂或事故及处理过程之地层',
  `drillDifficultOrAcidentAndHandleProcess_Type` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '钻井复杂或事故及处理过程之类型',
  `drillDifficultOrAcidentAndHandleProcess_HandleProcess` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '钻井复杂或事故及处理过程之处理过程',
  `drillDifficultOrAcidentAndHandleProcess_RelieveTime` datetime NOT NULL COMMENT '钻井复杂或事故及处理过程之解除时间',
  `drillDifficultOrAcidentAndHandleProcess_Remark` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '钻井复杂或事故及处理过程之备注',
  `measureWell_Projects` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '测井之项目',
  `measureWell_Rate` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '测井之比例',
  `measureWell_WellDepthToDepth` double NOT NULL COMMENT '测井之井段',
  `measureWell_Remark` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '测井之备注',
  `downAnnularTubes_Type` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '套管类型',
  `downAnnularTubes_PlaceOfOrigin` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '套管产地',
  `downAnnularTubes_SteelGrade` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '套管钢级',
  `downAnnularTubes_ExternalDiametery` double NOT NULL COMMENT '套管外径',
  `downAnnularTubes_WallThickness` double NOT NULL COMMENT '套管壁厚',
  `downAnnularTubes_UnderTheDeep` double NOT NULL COMMENT '套管下深',
  `downAnnularTubes_ChokeRingPosition` double NOT NULL COMMENT '套管组留环位置',
  `downAnnularTubes_ShortDrivepipePosition` double NOT NULL COMMENT '短套管位置',
  `downAnnularTubes_HangerPosition` double NOT NULL COMMENT '悬挂器位置',
  `downAnnularTubes_GraingRingPosition` double NOT NULL COMMENT '分级箍位置',
  `downAnnularTubes_AccessTo` double NOT NULL COMMENT '联入',
  `solidWell_CementBrand` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '固井之水泥品牌',
  `solidWell_CementType` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '固井之水泥类型',
  `solidWell_CementPasteInjectionNumber` double NOT NULL COMMENT '固井之水泥浆注入量',
  `solidWell_CementPasteAverageDensitu` double NOT NULL COMMENT '固井之水泥浆平均密度',
  `solidWell_CementPasteBackHeight` double NOT NULL COMMENT '固井之水泥返高',
  `solidWell_PressureTest` double NOT NULL COMMENT '固井之试压',
  `solidWell_ReplaceCementPasteNumber` double NOT NULL COMMENT '固井之替泥浆量',
  `solidWell_TouchThePressureTime` datetime NOT NULL COMMENT '固井之碰压时间',
  `solidWell_TouchThePressureValue` double NOT NULL COMMENT '固井之碰压值',
  `solidWell_SpacerFluidInjectionNumber` double NOT NULL COMMENT '隔离液注入量',
  `solidWell_CementationQuality` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '固井质量',
  `testOil_WellDepthToDepth` double NOT NULL COMMENT '试油之井段',
  `testOil_Position` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '试油之层位',
  `testOil_ToolsStructure` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '试油之工具结构',
  `testOil_StratumPressure` double NOT NULL COMMENT '试油之地层压力',
  `testOil_WorkFluidType` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '试油之工作液类型',
  `testOil_TestTechnology` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '试油之测试工艺',
  `testOil_SealingPositionOfTester` double NOT NULL COMMENT '试油之测试器座封位置',
  `testOilSeatSealingTime` datetime NOT NULL COMMENT '座封时间',
  `testOil_UnlockTime` datetime NOT NULL COMMENT '解封时间',
  `testOil_OpenOrCloseWellTime` datetime NOT NULL COMMENT '试油之开关井时间',
  `testOil_OpenWellDisplaySituation` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '试油之开井时显示情况',
  `testOil_RecycleFluidNumber` double NOT NULL COMMENT '试油试回收流体量',
  `testOil_PreliminaryConversionDailyFluidProduction` double NOT NULL COMMENT '试油之初步折算流体日产量',
  `testOil_FluidProperty` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '试油之流体性质',
  `testOil_TestOilConclusion` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '试油之试油结论',
  `signature_WellLogHeader` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '签字之录井队长签字',
  `signature_GeologySupervise` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '签字之地质监督签字'
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_mri-log-well-analyse
-- ----------------------------
DROP TABLE IF EXISTS `mc_mri-log-well-analyse`;
CREATE TABLE `mc_mri-log-well-analyse`  (
  `serialNumber` int NOT NULL AUTO_INCREMENT COMMENT '序号',
  `wellDepth` double NOT NULL COMMENT '井深',
  `position` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '层位',
  `theLithologyNamed` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性定名',
  `porosity` double NOT NULL COMMENT '孔隙度',
  `permeability` double NOT NULL COMMENT '渗透率',
  `oilSaturation` double NOT NULL COMMENT '含油饱和度',
  `theMovableFluid` double NOT NULL COMMENT '可动流体',
  `boundFluid` double NOT NULL COMMENT '束缚流体',
  `movableWaterSaturation` double NOT NULL COMMENT '可动水饱和度',
  PRIMARY KEY (`serialNumber`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_nature-gamma-power-spectrum-log-well-analyse
-- ----------------------------
DROP TABLE IF EXISTS `mc_nature-gamma-power-spectrum-log-well-analyse`;
CREATE TABLE `mc_nature-gamma-power-spectrum-log-well-analyse`  (
  `serialNumber` int NOT NULL AUTO_INCREMENT COMMENT '序号',
  `position` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '层位',
  `wellDepth` double NOT NULL COMMENT '井深',
  `sampleWeight` double NOT NULL COMMENT '样品重量',
  `U` double NOT NULL COMMENT 'U',
  `TH` double NOT NULL COMMENT 'TH',
  `K` double NOT NULL COMMENT 'K',
  `theTotalRate` double NOT NULL COMMENT '总计数率',
  `totalGamma` double NOT NULL COMMENT '总伽马',
  `TOC` double NOT NULL COMMENT 'TOC',
  PRIMARY KEY (`serialNumber`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_project-exception-report
-- ----------------------------
DROP TABLE IF EXISTS `mc_project-exception-report`;
CREATE TABLE `mc_project-exception-report`  (
  `serialNumber` int NOT NULL COMMENT '井号',
  `dateTime` datetime NOT NULL COMMENT '日期',
  `wellLogTeam` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '录井队',
  `wellDrillTeam` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '钻井队',
  `drillToTheDepth` double NOT NULL COMMENT '钻达井深',
  `exceptionPosition` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '异常层位',
  `exceptionStartTime` datetime NOT NULL COMMENT '异常开始时间',
  `reportTime` datetime NOT NULL COMMENT '报告时间',
  `exceptionWellDepthToDepth` double NOT NULL COMMENT '异常井段',
  `exceptionParameterChangeSituation` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '异常参数变化情况',
  `analyseResultReport` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '分析结果报告',
  `suggestHandleMeasure` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '建议处理错书',
  `adaptSituation` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '采纳情况',
  `trueResult` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '实际结果',
  `reportAccordSituation` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '报告符合情况',
  `wellLogReporter` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '录井报告人',
  `wellLogHeaderSignature` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '录井队长签字',
  `wellDrillTeamOrTheSupervise` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '钻井队或监督签字',
  `geologySuperviseSignature` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '地质监督签字',
  PRIMARY KEY (`serialNumber`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_ration-fluorescence-analyse
-- ----------------------------
DROP TABLE IF EXISTS `mc_ration-fluorescence-analyse`;
CREATE TABLE `mc_ration-fluorescence-analyse`  (
  `serialNumber` int NOT NULL AUTO_INCREMENT COMMENT '序号',
  `wellNumber` int NOT NULL COMMENT '井号',
  `wellDepth` double NOT NULL COMMENT '井深',
  `sampleType` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '样品类型',
  `theLithologyNamed` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性定名',
  `analyseParameterExcitationWavelength` double NOT NULL COMMENT '激发波长',
  `analyseParameterFluorescenceWavelength` double NOT NULL COMMENT '荧光波长',
  `analyseParameterFluorescenceIntnsity` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '荧光强度',
  `analyseParameterEquivalentOilContent` double NOT NULL COMMENT '相当油含量',
  `analyseParameterContrastLevel` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '对比级别',
  `analyseParameterOilIndex` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '油性指数',
  PRIMARY KEY (`serialNumber`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_rock-describe-record
-- ----------------------------
DROP TABLE IF EXISTS `mc_rock-describe-record`;
CREATE TABLE `mc_rock-describe-record`  (
  `serialNumber` int NOT NULL AUTO_INCREMENT COMMENT '序号',
  `position` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '层位',
  `topDepth` double NOT NULL COMMENT '顶深',
  `bottomDepth` double NOT NULL COMMENT '底深',
  `color` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '颜色',
  `oilLevel` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '含油级别',
  `lithology` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性',
  `lithologyAndDescriptionOfHydrocarbonAndWater` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性及含油气水描述',
  `wetAccordingToColor` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '湿照颜色',
  `accordingToTheColor` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '滴照颜色',
  `dryAccordingToColor` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '干照颜色',
  `contrastLevel` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '对比级别',
  `oilBearingCuttingsAreNamedCuttings` double NOT NULL COMMENT '含油岩屑占定名岩屑',
  `designatedCuttingsOfCuttings` double NOT NULL COMMENT '定名岩屑占岩屑',
  PRIMARY KEY (`serialNumber`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_rock-hot-evaporation-hydrocarbon-gas-chromatography
-- ----------------------------
DROP TABLE IF EXISTS `mc_rock-hot-evaporation-hydrocarbon-gas-chromatography`;
CREATE TABLE `mc_rock-hot-evaporation-hydrocarbon-gas-chromatography`  (
  `wellDepth` double NOT NULL COMMENT '井深',
  `position` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '层位',
  `theLithologyNamed` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性定名',
  `sampleNumber` int NOT NULL AUTO_INCREMENT COMMENT '样品编号',
  `sampleType` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '样品类别',
  `sampleMass` double NOT NULL COMMENT '样品质量',
  `ingredients` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '组分',
  `peakAreas` double NOT NULL COMMENT '峰面积',
  PRIMARY KEY (`sampleNumber`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_seam-statistics
-- ----------------------------
DROP TABLE IF EXISTS `mc_seam-statistics`;
CREATE TABLE `mc_seam-statistics`  (
  `takeCoreCanisterNumber` int NOT NULL COMMENT '取芯筒次',
  `wellSection` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '井段',
  `coreNumber` int NOT NULL AUTO_INCREMENT COMMENT '岩心编号',
  `length` double NOT NULL COMMENT '长度',
  `rockLithologyNamed` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性定名',
  `totalNumber` int NOT NULL COMMENT '总条数',
  `totalDestiny` double NOT NULL COMMENT '总密度',
  `seamNumber` int NOT NULL COMMENT '条数',
  `destiny` double NOT NULL COMMENT '密度',
  `widthGreaterThan5` tinyint NULL DEFAULT NULL COMMENT '大于5',
  `width1To5` tinyint NULL DEFAULT NULL COMMENT '1~5',
  `widthLessThan1` tinyint NULL DEFAULT NULL COMMENT '小于等于1',
  `verticalSram` tinyint NULL DEFAULT NULL COMMENT '立缝',
  `inclinedSeam` tinyint NULL DEFAULT NULL COMMENT '斜缝',
  `flatSeam` tinyint NULL DEFAULT NULL COMMENT '平缝',
  `seamDegreeOfFilling` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '缝填充程度',
  `seamFillingThing` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '缝填充物',
  `sutureLine` int NOT NULL COMMENT '缝合线',
  `karstCaveNumber` int NOT NULL COMMENT '溶洞个数',
  `karstCarveDestiny` double NOT NULL COMMENT '溶洞密度',
  `diameterGreaterThan10` tinyint NOT NULL COMMENT '直径大于5',
  `diameter5To10` tinyint NOT NULL COMMENT '直径5~10',
  `diameterLessThan5` tinyint NOT NULL COMMENT '直径小于10',
  `karstCarveFillingThing` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '溶洞填充物',
  `karstCarveDegreeOfFilling` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '溶洞填充程度',
  `patchNumber` int NOT NULL COMMENT '斑块',
  ` smokingLocation` int NOT NULL COMMENT '冒起处数',
  `connectedSituation` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '连通情况',
  PRIMARY KEY (`coreNumber`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_shale-destiny-analyse
-- ----------------------------
DROP TABLE IF EXISTS `mc_shale-destiny-analyse`;
CREATE TABLE `mc_shale-destiny-analyse`  (
  `serialNumber` int NOT NULL AUTO_INCREMENT COMMENT '序号',
  `position` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '层位',
  `wellDepth` double NOT NULL COMMENT '井深',
  `theLithologyNamed` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性定名',
  `measureValueL1` double NOT NULL COMMENT '测量值L1',
  `measureValueL2` double NOT NULL COMMENT '测量值L2',
  `measureValueDestiny` double NOT NULL COMMENT '测量值密度',
  PRIMARY KEY (`serialNumber`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_three-peak
-- ----------------------------
DROP TABLE IF EXISTS `mc_three-peak`;
CREATE TABLE `mc_three-peak`  (
  `parameterS1` double NOT NULL COMMENT '参数S1',
  `parameterS2` double NOT NULL COMMENT '参数S2',
  `parameterS3` double NOT NULL COMMENT '参数S3',
  `maxTemperature` double NOT NULL COMMENT '最大温度'
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_three-peak-and-five-peak-base-class
-- ----------------------------
DROP TABLE IF EXISTS `mc_three-peak-and-five-peak-base-class`;
CREATE TABLE `mc_three-peak-and-five-peak-base-class`  (
  `serialNumber` int NOT NULL COMMENT '序号',
  `wellDepth` double NOT NULL COMMENT '井深',
  `theLithologyNamed` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性定名',
  `sampleType` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '样品类型',
  `parameterS0` double NOT NULL COMMENT '参数S0',
  PRIMARY KEY (`serialNumber`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_well-wall-take-core
-- ----------------------------
DROP TABLE IF EXISTS `mc_well-wall-take-core`;
CREATE TABLE `mc_well-wall-take-core`  (
  `serialNumber` int NOT NULL AUTO_INCREMENT COMMENT '序号',
  `position` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '层位',
  `wellDepth` double NOT NULL COMMENT '井深',
  `color` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '颜色',
  `oilLevel` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '含油级别',
  `lithology` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性',
  `lithologyAndDescriptionOfHydrocarbonAndWater` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性及含油气水描述',
  `wetAccordingToColor` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '湿照颜色',
  `AccordingToTheColor` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '滴照颜色',
  `contrastLevel` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '对比级别',
  PRIMARY KEY (`serialNumber`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_x-ray-diffraction-mineral-log-well-analyse
-- ----------------------------
DROP TABLE IF EXISTS `mc_x-ray-diffraction-mineral-log-well-analyse`;
CREATE TABLE `mc_x-ray-diffraction-mineral-log-well-analyse`  (
  `serialNumber` int NOT NULL AUTO_INCREMENT COMMENT '序号',
  `wellDepth` double NOT NULL COMMENT '井深',
  `theLithology` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '岩性定名',
  `mineral_1_Content` double NULL DEFAULT NULL COMMENT '矿物1含量',
  `mineral_2_Content` double NULL DEFAULT NULL COMMENT '矿物2含量',
  `mineral_3_Content` double NULL DEFAULT NULL COMMENT '矿物3含量',
  `mineral_4_Content` double NULL DEFAULT NULL COMMENT '矿物4含量',
  `mineral_5_Content` double NULL DEFAULT NULL COMMENT '矿物5含量',
  `mineral_6_Content` double NULL DEFAULT NULL COMMENT '矿物6含量',
  `mineral_7_Content` double NULL DEFAULT NULL COMMENT '矿物7含量',
  `mineral_8_Content` double NULL DEFAULT NULL COMMENT '矿物8含量',
  PRIMARY KEY (`serialNumber`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mc_x-ray-fluorescence-element-log-well-analyse
-- ----------------------------
DROP TABLE IF EXISTS `mc_x-ray-fluorescence-element-log-well-analyse`;
CREATE TABLE `mc_x-ray-fluorescence-element-log-well-analyse`  (
  `wellDepth` double NOT NULL COMMENT '井深',
  `elementContent` double NOT NULL COMMENT '元素含量'
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users`  (
  `Account` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Time` datetime NOT NULL,
  `UserId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
