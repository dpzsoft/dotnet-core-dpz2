using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Custom_Fangde {

    /// <summary>
    /// 材料信息
    /// 材料信息
    /// Version 1.0.1809.2
    /// </summary>
    public class CustomMaterial : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 材料信息 行数据操作器
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
            /// 设置日期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDate(string value) {
                base.Row["Date"] = value;
                return this;
            }

            /// <summary>
            /// 设置产地
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPlace(string value) {
                base.Row["Place"] = value;
                return this;
            }

            /// <summary>
            /// 设置材料
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMaterial(string value) {
                base.Row["Material"] = value;
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
            /// 设置重量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWeight(string value) {
                base.Row["Weight"] = value;
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
            /// 设置其他
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOther(string value) {
                base.Row["Other"] = value;
                return this;
            }

            /// <summary>
            /// 设置备注
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRemarks(string value) {
                base.Row["Remarks"] = value;
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
        /// 获取日期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Date { get; private set; }

        /// <summary>
        /// 获取产地字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Place { get; private set; }

        /// <summary>
        /// 获取材料字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Material { get; private set; }

        /// <summary>
        /// 获取批号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Batch { get; private set; }

        /// <summary>
        /// 获取重量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Weight { get; private set; }

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
        /// 获取ZR字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ZR { get; private set; }

        /// <summary>
        /// 获取总含量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Tatol { get; private set; }

        /// <summary>
        /// 获取其他字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Other { get; private set; }

        /// <summary>
        /// 获取备注字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Remarks { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CustomMaterial() : base("CustomMaterial") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Date = new dpz2.db.SqlUnits.TableField(this, "Date");
            this.Place = new dpz2.db.SqlUnits.TableField(this, "Place");
            this.Material = new dpz2.db.SqlUnits.TableField(this, "Material");
            this.Batch = new dpz2.db.SqlUnits.TableField(this, "Batch");
            this.Weight = new dpz2.db.SqlUnits.TableField(this, "Weight");
            this.W = new dpz2.db.SqlUnits.TableField(this, "W");
            this.CO = new dpz2.db.SqlUnits.TableField(this, "CO");
            this.NI = new dpz2.db.SqlUnits.TableField(this, "NI");
            this.TI = new dpz2.db.SqlUnits.TableField(this, "TI");
            this.FE = new dpz2.db.SqlUnits.TableField(this, "FE");
            this.TA = new dpz2.db.SqlUnits.TableField(this, "TA");
            this.CR = new dpz2.db.SqlUnits.TableField(this, "CR");
            this.RE = new dpz2.db.SqlUnits.TableField(this, "RE");
            this.NB = new dpz2.db.SqlUnits.TableField(this, "NB");
            this.ZR = new dpz2.db.SqlUnits.TableField(this, "ZR");
            this.Tatol = new dpz2.db.SqlUnits.TableField(this, "Tatol");
            this.Other = new dpz2.db.SqlUnits.TableField(this, "Other");
            this.Remarks = new dpz2.db.SqlUnits.TableField(this, "Remarks");
        }

    }

}
