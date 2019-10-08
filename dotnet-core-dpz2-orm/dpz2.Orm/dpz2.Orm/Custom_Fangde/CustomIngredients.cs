using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Custom_Fangde {

    /// <summary>
    /// 配料信息
    /// 配料信息
    /// Version 1.0.1809.5
    /// </summary>
    public class CustomIngredients : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 配料信息 行数据操作器
        /// </summary>
        public class RowOperator : dpz2.db.RowOperator {

            /// <summary>
            /// 对象实例化
            /// </summary>
            /// <param name="row">行数据对象</param>
            public RowOperator(dpz2.db.Row row) : base(row) { }

            /// <summary>
            /// 设置ID
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetID(string value) {
                base.Row["ID"] = value;
                return this;
            }

            /// <summary>
            /// 设置牌号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBrand(string value) {
                base.Row["Brand"] = value;
                return this;
            }

            /// <summary>
            /// 设置批号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBatch(string value) {
                base.Row["Batch"] = value;
                return this;
            }

            /// <summary>
            /// 设置尺寸
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSize(string value) {
                base.Row["Size"] = value;
                return this;
            }

            /// <summary>
            /// 设置比重
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator Setfm_bizhong(string value) {
                base.Row["fm_bizhong"] = value;
                return this;
            }

            /// <summary>
            /// 设置密度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDensity(string value) {
                base.Row["Density"] = value;
                return this;
            }

            /// <summary>
            /// 设置强度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStrength(string value) {
                base.Row["Strength"] = value;
                return this;
            }

            /// <summary>
            /// 设置硬度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHardness(string value) {
                base.Row["Hardness"] = value;
                return this;
            }

            /// <summary>
            /// 设置磁力
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMagnetic(string value) {
                base.Row["Magnetic"] = value;
                return this;
            }

            /// <summary>
            /// 设置磁饱和
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMagneticSaturation(string value) {
                base.Row["MagneticSaturation"] = value;
                return this;
            }

            /// <summary>
            /// 设置孔隙
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPorosity(string value) {
                base.Row["Porosity"] = value;
                return this;
            }

            /// <summary>
            /// 设置低倍
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLowMagnification(string value) {
                base.Row["LowMagnification"] = value;
                return this;
            }

            /// <summary>
            /// 设置晶粒
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGrain(string value) {
                base.Row["Grain"] = value;
                return this;
            }

            /// <summary>
            /// 设置高倍
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHighMagnification(string value) {
                base.Row["HighMagnification"] = value;
                return this;
            }

            /// <summary>
            /// 设置系数
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCoefficient(string value) {
                base.Row["Coefficient"] = value;
                return this;
            }

            /// <summary>
            /// 设置W
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetW(string value) {
                base.Row["W"] = value;
                return this;
            }

            /// <summary>
            /// 设置CO
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCO(string value) {
                base.Row["CO"] = value;
                return this;
            }

            /// <summary>
            /// 设置NI
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetNI(string value) {
                base.Row["NI"] = value;
                return this;
            }

            /// <summary>
            /// 设置TI
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTI(string value) {
                base.Row["TI"] = value;
                return this;
            }

            /// <summary>
            /// 设置FE
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFE(string value) {
                base.Row["FE"] = value;
                return this;
            }

            /// <summary>
            /// 设置TA
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTA(string value) {
                base.Row["TA"] = value;
                return this;
            }

            /// <summary>
            /// 设置CR
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCR(string value) {
                base.Row["CR"] = value;
                return this;
            }

            /// <summary>
            /// 设置RE
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRE(string value) {
                base.Row["RE"] = value;
                return this;
            }

            /// <summary>
            /// 设置NB铌
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetNB(string value) {
                base.Row["NB"] = value;
                return this;
            }

            /// <summary>
            /// 设置CU
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCU(string value) {
                base.Row["CU"] = value;
                return this;
            }

            /// <summary>
            /// 设置ZR
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetZR(string value) {
                base.Row["ZR"] = value;
                return this;
            }

            /// <summary>
            /// 设置总含量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTatol(string value) {
                base.Row["Tatol"] = value;
                return this;
            }

            /// <summary>
            /// 设置材料重量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMaterialWeight(string value) {
                base.Row["MaterialWeight"] = value;
                return this;
            }

            /// <summary>
            /// 设置损耗重量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLossWeight(string value) {
                base.Row["LossWeight"] = value;
                return this;
            }

            /// <summary>
            /// 设置粉末重量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPowderWeight(string value) {
                base.Row["PowderWeight"] = value;
                return this;
            }

            /// <summary>
            /// 设置状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOptStatus(string value) {
                base.Row["OptStatus"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOptUser(string value) {
                base.Row["OptUser"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOptUserID(string value) {
                base.Row["OptUserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOptTime(string value) {
                base.Row["OptTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作备注
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOptRemarks(string value) {
                base.Row["OptRemarks"] = value;
                return this;
            }

        }

        /// <summary>
        /// 获取*字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField All { get; private set; }

        /// <summary>
        /// 获取ID字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ID { get; private set; }

        /// <summary>
        /// 获取牌号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Brand { get; private set; }

        /// <summary>
        /// 获取批号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Batch { get; private set; }

        /// <summary>
        /// 获取尺寸字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Size { get; private set; }

        /// <summary>
        /// 获取比重字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField fm_bizhong { get; private set; }

        /// <summary>
        /// 获取密度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Density { get; private set; }

        /// <summary>
        /// 获取强度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Strength { get; private set; }

        /// <summary>
        /// 获取硬度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Hardness { get; private set; }

        /// <summary>
        /// 获取磁力字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Magnetic { get; private set; }

        /// <summary>
        /// 获取磁饱和字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField MagneticSaturation { get; private set; }

        /// <summary>
        /// 获取孔隙字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Porosity { get; private set; }

        /// <summary>
        /// 获取低倍字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LowMagnification { get; private set; }

        /// <summary>
        /// 获取晶粒字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Grain { get; private set; }

        /// <summary>
        /// 获取高倍字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField HighMagnification { get; private set; }

        /// <summary>
        /// 获取系数字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Coefficient { get; private set; }

        /// <summary>
        /// 获取W字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField W { get; private set; }

        /// <summary>
        /// 获取CO字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CO { get; private set; }

        /// <summary>
        /// 获取NI字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField NI { get; private set; }

        /// <summary>
        /// 获取TI字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TI { get; private set; }

        /// <summary>
        /// 获取FE字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FE { get; private set; }

        /// <summary>
        /// 获取TA字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TA { get; private set; }

        /// <summary>
        /// 获取CR字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CR { get; private set; }

        /// <summary>
        /// 获取RE字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RE { get; private set; }

        /// <summary>
        /// 获取NB铌字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField NB { get; private set; }

        /// <summary>
        /// 获取CU字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CU { get; private set; }

        /// <summary>
        /// 获取ZR字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ZR { get; private set; }

        /// <summary>
        /// 获取总含量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Tatol { get; private set; }

        /// <summary>
        /// 获取材料重量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField MaterialWeight { get; private set; }

        /// <summary>
        /// 获取损耗重量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LossWeight { get; private set; }

        /// <summary>
        /// 获取粉末重量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PowderWeight { get; private set; }

        /// <summary>
        /// 获取状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OptStatus { get; private set; }

        /// <summary>
        /// 获取操作用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OptUser { get; private set; }

        /// <summary>
        /// 获取操作用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OptUserID { get; private set; }

        /// <summary>
        /// 获取操作时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OptTime { get; private set; }

        /// <summary>
        /// 获取操作备注字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OptRemarks { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CustomIngredients() : base("CustomIngredients") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Brand = new dpz2.db.SqlUnits.TableField(this, "Brand");
            this.Batch = new dpz2.db.SqlUnits.TableField(this, "Batch");
            this.Size = new dpz2.db.SqlUnits.TableField(this, "Size");
            this.fm_bizhong = new dpz2.db.SqlUnits.TableField(this, "fm_bizhong");
            this.Density = new dpz2.db.SqlUnits.TableField(this, "Density");
            this.Strength = new dpz2.db.SqlUnits.TableField(this, "Strength");
            this.Hardness = new dpz2.db.SqlUnits.TableField(this, "Hardness");
            this.Magnetic = new dpz2.db.SqlUnits.TableField(this, "Magnetic");
            this.MagneticSaturation = new dpz2.db.SqlUnits.TableField(this, "MagneticSaturation");
            this.Porosity = new dpz2.db.SqlUnits.TableField(this, "Porosity");
            this.LowMagnification = new dpz2.db.SqlUnits.TableField(this, "LowMagnification");
            this.Grain = new dpz2.db.SqlUnits.TableField(this, "Grain");
            this.HighMagnification = new dpz2.db.SqlUnits.TableField(this, "HighMagnification");
            this.Coefficient = new dpz2.db.SqlUnits.TableField(this, "Coefficient");
            this.W = new dpz2.db.SqlUnits.TableField(this, "W");
            this.CO = new dpz2.db.SqlUnits.TableField(this, "CO");
            this.NI = new dpz2.db.SqlUnits.TableField(this, "NI");
            this.TI = new dpz2.db.SqlUnits.TableField(this, "TI");
            this.FE = new dpz2.db.SqlUnits.TableField(this, "FE");
            this.TA = new dpz2.db.SqlUnits.TableField(this, "TA");
            this.CR = new dpz2.db.SqlUnits.TableField(this, "CR");
            this.RE = new dpz2.db.SqlUnits.TableField(this, "RE");
            this.NB = new dpz2.db.SqlUnits.TableField(this, "NB");
            this.CU = new dpz2.db.SqlUnits.TableField(this, "CU");
            this.ZR = new dpz2.db.SqlUnits.TableField(this, "ZR");
            this.Tatol = new dpz2.db.SqlUnits.TableField(this, "Tatol");
            this.MaterialWeight = new dpz2.db.SqlUnits.TableField(this, "MaterialWeight");
            this.LossWeight = new dpz2.db.SqlUnits.TableField(this, "LossWeight");
            this.PowderWeight = new dpz2.db.SqlUnits.TableField(this, "PowderWeight");
            this.OptStatus = new dpz2.db.SqlUnits.TableField(this, "OptStatus");
            this.OptUser = new dpz2.db.SqlUnits.TableField(this, "OptUser");
            this.OptUserID = new dpz2.db.SqlUnits.TableField(this, "OptUserID");
            this.OptTime = new dpz2.db.SqlUnits.TableField(this, "OptTime");
            this.OptRemarks = new dpz2.db.SqlUnits.TableField(this, "OptRemarks");
        }

    }

}
