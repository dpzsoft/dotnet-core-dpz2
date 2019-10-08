using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Table {

    /// <summary>
    /// OA字段类型
    /// OA字段类型
    /// Version 1511.0701
    /// </summary>
    public class SystemColumnTypes : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// OA字段类型 行数据操作器
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
            /// 设置类型名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置可用状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEnabled(string value) {
                base.Row["Enabled"] = value;
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
        /// 获取类型名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取可用状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Enabled { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SystemColumnTypes() : base("SystemColumnTypes") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Enabled = new dpz2.db.SqlUnits.TableField(this, "Enabled");
        }

    }

}
