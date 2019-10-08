using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Table {

    /// <summary>
    /// OA条件信息
    /// OA条件信息
    /// Version 1511.0701
    /// </summary>
    public class SystemPremises : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// OA条件信息 行数据操作器
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
            /// 设置表格编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTableID(string value) {
                base.Row["TableID"] = value;
                return this;
            }

            /// <summary>
            /// 设置表格名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTableName(string value) {
                base.Row["TableName"] = value;
                return this;
            }

            /// <summary>
            /// 设置列编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetColumn(string value) {
                base.Row["Column"] = value;
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
            /// 设置值
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetValue(string value) {
                base.Row["Value"] = value;
                return this;
            }

            /// <summary>
            /// 设置关联编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRelationID(string value) {
                base.Row["RelationID"] = value;
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
        /// 获取表格编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TableID { get; private set; }

        /// <summary>
        /// 获取表格名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TableName { get; private set; }

        /// <summary>
        /// 获取列编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Column { get; private set; }

        /// <summary>
        /// 获取列名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ColumnName { get; private set; }

        /// <summary>
        /// 获取条件类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PremiseType { get; private set; }

        /// <summary>
        /// 获取值字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Value { get; private set; }

        /// <summary>
        /// 获取关联编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RelationID { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SystemPremises() : base("SystemPremises") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.TableID = new dpz2.db.SqlUnits.TableField(this, "TableID");
            this.TableName = new dpz2.db.SqlUnits.TableField(this, "TableName");
            this.Column = new dpz2.db.SqlUnits.TableField(this, "Column");
            this.ColumnName = new dpz2.db.SqlUnits.TableField(this, "ColumnName");
            this.PremiseType = new dpz2.db.SqlUnits.TableField(this, "PremiseType");
            this.Value = new dpz2.db.SqlUnits.TableField(this, "Value");
            this.RelationID = new dpz2.db.SqlUnits.TableField(this, "RelationID");
        }

    }

}
