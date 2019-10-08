using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Table {

    /// <summary>
    /// OA历史信息
    /// OA历史信息
    /// Version 2016.0602
    /// </summary>
    public class SystemHistory : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// OA历史信息 行数据操作器
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
            /// 设置索引
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIndex(string value) {
                base.Row["Index"] = value;
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
            /// 设置关联编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRelationID(string value) {
                base.Row["RelationID"] = value;
                return this;
            }

            /// <summary>
            /// 设置识标值
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetValueID(string value) {
                base.Row["ValueID"] = value;
                return this;
            }

            /// <summary>
            /// 设置显示文本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetText(string value) {
                base.Row["Text"] = value;
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
        /// 获取索引字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Index { get; private set; }

        /// <summary>
        /// 获取表格编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TableID { get; private set; }

        /// <summary>
        /// 获取表格名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TableName { get; private set; }

        /// <summary>
        /// 获取关联编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RelationID { get; private set; }

        /// <summary>
        /// 获取识标值字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ValueID { get; private set; }

        /// <summary>
        /// 获取显示文本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Text { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SystemHistory() : base("SystemHistory") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Index = new dpz2.db.SqlUnits.TableField(this, "Index");
            this.TableID = new dpz2.db.SqlUnits.TableField(this, "TableID");
            this.TableName = new dpz2.db.SqlUnits.TableField(this, "TableName");
            this.RelationID = new dpz2.db.SqlUnits.TableField(this, "RelationID");
            this.ValueID = new dpz2.db.SqlUnits.TableField(this, "ValueID");
            this.Text = new dpz2.db.SqlUnits.TableField(this, "Text");
        }

    }

}
