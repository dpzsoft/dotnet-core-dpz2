using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Table {

    /// <summary>
    /// 表格筛选
    /// 表格筛选
    /// Version 2015.1202
    /// </summary>
    public class TabFilter : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 表格筛选 行数据操作器
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
            /// 设置关联表格
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTableID(string value) {
                base.Row["TableID"] = value;
                return this;
            }

            /// <summary>
            /// 设置脚本触发
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIsScript(string value) {
                base.Row["IsScript"] = value;
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
        /// 获取关联表格字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TableID { get; private set; }

        /// <summary>
        /// 获取脚本触发字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IsScript { get; private set; }

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
        public TabFilter() : base("TabFilter") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Type = new dpz2.db.SqlUnits.TableField(this, "Type");
            this.TableID = new dpz2.db.SqlUnits.TableField(this, "TableID");
            this.IsScript = new dpz2.db.SqlUnits.TableField(this, "IsScript");
            this.DScript = new dpz2.db.SqlUnits.TableField(this, "DScript");
        }

    }

}
