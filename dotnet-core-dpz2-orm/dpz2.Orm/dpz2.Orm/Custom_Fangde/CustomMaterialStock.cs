using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Custom_Fangde {

    /// <summary>
    /// 材料库存信息
    /// 材料库存信息
    /// Version 1.0.1809.1
    /// </summary>
    public class CustomMaterialStock : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 材料库存信息 行数据操作器
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
            /// 设置相关材料
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMaterialID(string value) {
                base.Row["MaterialID"] = value;
                return this;
            }

            /// <summary>
            /// 设置变更量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetChange(string value) {
                base.Row["Change"] = value;
                return this;
            }

            /// <summary>
            /// 设置起始量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStart(string value) {
                base.Row["Start"] = value;
                return this;
            }

            /// <summary>
            /// 设置增加量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPlus(string value) {
                base.Row["Plus"] = value;
                return this;
            }

            /// <summary>
            /// 设置减少量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMinus(string value) {
                base.Row["Minus"] = value;
                return this;
            }

            /// <summary>
            /// 设置结余量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRest(string value) {
                base.Row["Rest"] = value;
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
        /// 获取相关材料字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField MaterialID { get; private set; }

        /// <summary>
        /// 获取变更量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Change { get; private set; }

        /// <summary>
        /// 获取起始量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Start { get; private set; }

        /// <summary>
        /// 获取增加量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Plus { get; private set; }

        /// <summary>
        /// 获取减少量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Minus { get; private set; }

        /// <summary>
        /// 获取结余量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Rest { get; private set; }

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
        public CustomMaterialStock() : base("CustomMaterialStock") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.MaterialID = new dpz2.db.SqlUnits.TableField(this, "MaterialID");
            this.Change = new dpz2.db.SqlUnits.TableField(this, "Change");
            this.Start = new dpz2.db.SqlUnits.TableField(this, "Start");
            this.Plus = new dpz2.db.SqlUnits.TableField(this, "Plus");
            this.Minus = new dpz2.db.SqlUnits.TableField(this, "Minus");
            this.Rest = new dpz2.db.SqlUnits.TableField(this, "Rest");
            this.OptUser = new dpz2.db.SqlUnits.TableField(this, "OptUser");
            this.OptUserID = new dpz2.db.SqlUnits.TableField(this, "OptUserID");
            this.OptTime = new dpz2.db.SqlUnits.TableField(this, "OptTime");
            this.OptRemarks = new dpz2.db.SqlUnits.TableField(this, "OptRemarks");
        }

    }

}
