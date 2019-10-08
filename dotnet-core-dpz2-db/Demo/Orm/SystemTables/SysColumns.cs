using System;
using System.Collections.Generic;
using System.Text;
using dpz2.db;

namespace Demo.Orm.SystemTables {

    /// <summary>
    /// Sql Server专用系统对象表
    /// </summary>
    public class SysColumns : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 行数据操作器
        /// </summary>
        public class RowOperator : dpz2.db.RowOperator {

            /// <summary>
            /// 对象实例化
            /// </summary>
            /// <param name="row"></param>
            public RowOperator(Row row) : base(row) { }

            /// <summary>
            /// 获取基础数据行对象
            /// </summary>
            /// <returns></returns>
            public Row GetRow() { return base.Row; }

            /// <summary>
            /// 设置Id
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public RowOperator SetId(long value) {
                base.Row["Id"] = "" + value;
                return this;
            }

            /// <summary>
            /// 设置Name
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }
        }

        /// <summary>
        /// 获取Id字段
        /// </summary>
        public dpz2.db.SqlUnits.TableField Id { get; private set; }

        /// <summary>
        /// 获取Name字段
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public RowOperator Rower(Row row) {
            return new RowOperator(row);
        }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SysColumns() : base("SysColumns") {
            this.Id = new dpz2.db.SqlUnits.TableField(this, "Id");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
        }

    }
}
