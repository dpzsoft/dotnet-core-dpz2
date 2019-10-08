using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Table {

    /// <summary>
    /// OA事件信息
    /// OA事件信息
    /// Version 2016.0201
    /// </summary>
    public class SystemEvents : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// OA事件信息 行数据操作器
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
            public RowOperator SetTable(string value) {
                base.Row["Table"] = value;
                return this;
            }

            /// <summary>
            /// 设置事件名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置执行的DS脚本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDScript(string value) {
                base.Row["DScript"] = value;
                return this;
            }

            /// <summary>
            /// 设置执行的SQL脚本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAzSQL(string value) {
                base.Row["AzSQL"] = value;
                return this;
            }

            /// <summary>
            /// 设置执行的Az脚本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAzScript(string value) {
                base.Row["AzScript"] = value;
                return this;
            }

            /// <summary>
            /// 设置执行的Json脚本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAzJson(string value) {
                base.Row["AzJson"] = value;
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
        public dpz2.db.SqlUnits.TableField Table { get; private set; }

        /// <summary>
        /// 获取事件名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取执行的DS脚本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DScript { get; private set; }

        /// <summary>
        /// 获取执行的SQL脚本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AzSQL { get; private set; }

        /// <summary>
        /// 获取执行的Az脚本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AzScript { get; private set; }

        /// <summary>
        /// 获取执行的Json脚本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AzJson { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SystemEvents() : base("SystemEvents") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.TableID = new dpz2.db.SqlUnits.TableField(this, "TableID");
            this.Table = new dpz2.db.SqlUnits.TableField(this, "Table");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.DScript = new dpz2.db.SqlUnits.TableField(this, "DScript");
            this.AzSQL = new dpz2.db.SqlUnits.TableField(this, "AzSQL");
            this.AzScript = new dpz2.db.SqlUnits.TableField(this, "AzScript");
            this.AzJson = new dpz2.db.SqlUnits.TableField(this, "AzJson");
        }

    }

}
