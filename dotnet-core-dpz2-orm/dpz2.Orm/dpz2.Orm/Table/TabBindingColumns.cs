using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Table {

    /// <summary>
    /// 信息绑定字段
    /// 信息绑定字段
    /// Version 2016.0201
    /// </summary>
    public class TabBindingColumns : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 信息绑定字段 行数据操作器
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
            /// 设置绑定编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBindingID(string value) {
                base.Row["BindingID"] = value;
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
            /// 设置字段名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetColumnName(string value) {
                base.Row["ColumnName"] = value;
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
        /// 获取绑定编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BindingID { get; private set; }

        /// <summary>
        /// 获取表格名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TableName { get; private set; }

        /// <summary>
        /// 获取字段名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ColumnName { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public TabBindingColumns() : base("TabBindingColumns") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.BindingID = new dpz2.db.SqlUnits.TableField(this, "BindingID");
            this.TableName = new dpz2.db.SqlUnits.TableField(this, "TableName");
            this.ColumnName = new dpz2.db.SqlUnits.TableField(this, "ColumnName");
        }

    }

}
