using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Table {

    /// <summary>
    /// 表格筛选定义
    /// 表格筛选定义
    /// Version 2016.0201
    /// </summary>
    public class TabFilterPremises : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 表格筛选定义 行数据操作器
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
            /// 设置筛选编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFilterID(string value) {
                base.Row["FilterID"] = value;
                return this;
            }

            /// <summary>
            /// 设置排序
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIndex(string value) {
                base.Row["Index"] = value;
                return this;
            }

            /// <summary>
            /// 设置组织逻辑
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGroupType(string value) {
                base.Row["GroupType"] = value;
                return this;
            }

            /// <summary>
            /// 设置列名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetColumnName(string value) {
                base.Row["ColumnName"] = value;
                return this;
            }

            /// <summary>
            /// 设置条件类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPremiseType(string value) {
                base.Row["PremiseType"] = value;
                return this;
            }

            /// <summary>
            /// 设置值类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetValueType(string value) {
                base.Row["ValueType"] = value;
                return this;
            }

            /// <summary>
            /// 设置值
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetValue(string value) {
                base.Row["Value"] = value;
                return this;
            }

            /// <summary>
            /// 设置列名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetValueColumnName(string value) {
                base.Row["ValueColumnName"] = value;
                return this;
            }

            /// <summary>
            /// 设置绑定数据编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetValueID(string value) {
                base.Row["ValueID"] = value;
                return this;
            }

            /// <summary>
            /// 设置绑定DS脚本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetValueDScript(string value) {
                base.Row["ValueDScript"] = value;
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
        /// 获取筛选编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FilterID { get; private set; }

        /// <summary>
        /// 获取排序字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Index { get; private set; }

        /// <summary>
        /// 获取组织逻辑字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField GroupType { get; private set; }

        /// <summary>
        /// 获取列名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ColumnName { get; private set; }

        /// <summary>
        /// 获取条件类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PremiseType { get; private set; }

        /// <summary>
        /// 获取值类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ValueType { get; private set; }

        /// <summary>
        /// 获取值字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Value { get; private set; }

        /// <summary>
        /// 获取列名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ValueColumnName { get; private set; }

        /// <summary>
        /// 获取绑定数据编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ValueID { get; private set; }

        /// <summary>
        /// 获取绑定DS脚本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ValueDScript { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public TabFilterPremises() : base("TabFilterPremises") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.FilterID = new dpz2.db.SqlUnits.TableField(this, "FilterID");
            this.Index = new dpz2.db.SqlUnits.TableField(this, "Index");
            this.GroupType = new dpz2.db.SqlUnits.TableField(this, "GroupType");
            this.ColumnName = new dpz2.db.SqlUnits.TableField(this, "ColumnName");
            this.PremiseType = new dpz2.db.SqlUnits.TableField(this, "PremiseType");
            this.ValueType = new dpz2.db.SqlUnits.TableField(this, "ValueType");
            this.Value = new dpz2.db.SqlUnits.TableField(this, "Value");
            this.ValueColumnName = new dpz2.db.SqlUnits.TableField(this, "ValueColumnName");
            this.ValueID = new dpz2.db.SqlUnits.TableField(this, "ValueID");
            this.ValueDScript = new dpz2.db.SqlUnits.TableField(this, "ValueDScript");
        }

    }

}
