using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Base {

    /// <summary>
    /// 表格访问信息
    /// 表格访问信息
    /// Version 1512.1101
    /// </summary>
    public class SystemUserTableVisits : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 表格访问信息 行数据操作器
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
            /// 设置用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置数据表
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTableID(string value) {
                base.Row["TableID"] = value;
                return this;
            }

            /// <summary>
            /// 设置访问次数
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVisits(string value) {
                base.Row["Visits"] = value;
                return this;
            }

            /// <summary>
            /// 设置最后访问
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLastVisitTime(string value) {
                base.Row["LastVisitTime"] = value;
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
        /// 获取用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取数据表字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TableID { get; private set; }

        /// <summary>
        /// 获取访问次数字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Visits { get; private set; }

        /// <summary>
        /// 获取最后访问字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LastVisitTime { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SystemUserTableVisits() : base("SystemUserTableVisits") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.TableID = new dpz2.db.SqlUnits.TableField(this, "TableID");
            this.Visits = new dpz2.db.SqlUnits.TableField(this, "Visits");
            this.LastVisitTime = new dpz2.db.SqlUnits.TableField(this, "LastVisitTime");
        }

    }

}
