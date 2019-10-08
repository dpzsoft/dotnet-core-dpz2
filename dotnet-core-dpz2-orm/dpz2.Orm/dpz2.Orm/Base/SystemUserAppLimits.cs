using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Base {

    /// <summary>
    /// 用户应用权限信息
    /// 用户应用权限信息
    /// Version 1512.2001
    /// </summary>
    public class SystemUserAppLimits : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 用户应用权限信息 行数据操作器
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
            /// 设置应用
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAppID(string value) {
                base.Row["AppID"] = value;
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
        /// 获取用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取应用字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AppID { get; private set; }

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
        public SystemUserAppLimits() : base("SystemUserAppLimits") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.AppID = new dpz2.db.SqlUnits.TableField(this, "AppID");
            this.Limits = new dpz2.db.SqlUnits.TableField(this, "Limits");
        }

    }

}
