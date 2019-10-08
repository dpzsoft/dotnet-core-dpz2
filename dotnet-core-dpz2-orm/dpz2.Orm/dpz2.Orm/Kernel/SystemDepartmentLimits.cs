using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Kernel {

    /// <summary>
    /// 部门权限信息
    /// 部门权限信息
    /// Version 1512.2001
    /// </summary>
    public class SystemDepartmentLimits : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 部门权限信息 行数据操作器
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
            /// 设置部门
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDepartmentID(string value) {
                base.Row["DepartmentID"] = value;
                return this;
            }

            /// <summary>
            /// 设置表格
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTableID(string value) {
                base.Row["TableID"] = value;
                return this;
            }

            /// <summary>
            /// 设置权限
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLimits(string value) {
                base.Row["Limits"] = value;
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
        /// 获取部门字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DepartmentID { get; private set; }

        /// <summary>
        /// 获取表格字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TableID { get; private set; }

        /// <summary>
        /// 获取权限字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Limits { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SystemDepartmentLimits() : base("SystemDepartmentLimits") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.DepartmentID = new dpz2.db.SqlUnits.TableField(this, "DepartmentID");
            this.TableID = new dpz2.db.SqlUnits.TableField(this, "TableID");
            this.Limits = new dpz2.db.SqlUnits.TableField(this, "Limits");
        }

    }

}
