using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Table {

    /// <summary>
    /// OA表格关联
    /// OA表格关联
    /// Version 2015.1201
    /// </summary>
    public class SystemRelation : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// OA表格关联 行数据操作器
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
            /// 设置名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetType(string value) {
                base.Row["Type"] = value;
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
            /// 设置关联表格编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRelationTableID(string value) {
                base.Row["RelationTableID"] = value;
                return this;
            }

            /// <summary>
            /// 设置表格字段
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetColumn(string value) {
                base.Row["Column"] = value;
                return this;
            }

            /// <summary>
            /// 设置关联表格字段
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRelationColumn(string value) {
                base.Row["RelationColumn"] = value;
                return this;
            }

            /// <summary>
            /// 设置索引
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIndex(string value) {
                base.Row["Index"] = value;
                return this;
            }

            /// <summary>
            /// 设置显示状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVisible(string value) {
                base.Row["Visible"] = value;
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
            /// 设置关联表格名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRelationTableName(string value) {
                base.Row["RelationTableName"] = value;
                return this;
            }

            /// <summary>
            /// 设置表格字段名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetColumnName(string value) {
                base.Row["ColumnName"] = value;
                return this;
            }

            /// <summary>
            /// 设置关联表格字段名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRelationColumnName(string value) {
                base.Row["RelationColumnName"] = value;
                return this;
            }

            /// <summary>
            /// 设置路径关联字段
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPathColumn(string value) {
                base.Row["PathColumn"] = value;
                return this;
            }

            /// <summary>
            /// 设置路径关联字段名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPathColumnName(string value) {
                base.Row["PathColumnName"] = value;
                return this;
            }

            /// <summary>
            /// 设置文件路径
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPath(string value) {
                base.Row["Path"] = value;
                return this;
            }

            /// <summary>
            /// 设置DS脚本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDScript(string value) {
                base.Row["DScript"] = value;
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
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Type { get; private set; }

        /// <summary>
        /// 获取表格编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TableID { get; private set; }

        /// <summary>
        /// 获取关联表格编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RelationTableID { get; private set; }

        /// <summary>
        /// 获取表格字段字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Column { get; private set; }

        /// <summary>
        /// 获取关联表格字段字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RelationColumn { get; private set; }

        /// <summary>
        /// 获取索引字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Index { get; private set; }

        /// <summary>
        /// 获取显示状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Visible { get; private set; }

        /// <summary>
        /// 获取表格名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TableName { get; private set; }

        /// <summary>
        /// 获取关联表格名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RelationTableName { get; private set; }

        /// <summary>
        /// 获取表格字段名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ColumnName { get; private set; }

        /// <summary>
        /// 获取关联表格字段名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RelationColumnName { get; private set; }

        /// <summary>
        /// 获取路径关联字段字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PathColumn { get; private set; }

        /// <summary>
        /// 获取路径关联字段名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PathColumnName { get; private set; }

        /// <summary>
        /// 获取文件路径字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Path { get; private set; }

        /// <summary>
        /// 获取DS脚本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DScript { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SystemRelation() : base("SystemRelation") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Type = new dpz2.db.SqlUnits.TableField(this, "Type");
            this.TableID = new dpz2.db.SqlUnits.TableField(this, "TableID");
            this.RelationTableID = new dpz2.db.SqlUnits.TableField(this, "RelationTableID");
            this.Column = new dpz2.db.SqlUnits.TableField(this, "Column");
            this.RelationColumn = new dpz2.db.SqlUnits.TableField(this, "RelationColumn");
            this.Index = new dpz2.db.SqlUnits.TableField(this, "Index");
            this.Visible = new dpz2.db.SqlUnits.TableField(this, "Visible");
            this.TableName = new dpz2.db.SqlUnits.TableField(this, "TableName");
            this.RelationTableName = new dpz2.db.SqlUnits.TableField(this, "RelationTableName");
            this.ColumnName = new dpz2.db.SqlUnits.TableField(this, "ColumnName");
            this.RelationColumnName = new dpz2.db.SqlUnits.TableField(this, "RelationColumnName");
            this.PathColumn = new dpz2.db.SqlUnits.TableField(this, "PathColumn");
            this.PathColumnName = new dpz2.db.SqlUnits.TableField(this, "PathColumnName");
            this.Path = new dpz2.db.SqlUnits.TableField(this, "Path");
            this.DScript = new dpz2.db.SqlUnits.TableField(this, "DScript");
        }

    }

}
