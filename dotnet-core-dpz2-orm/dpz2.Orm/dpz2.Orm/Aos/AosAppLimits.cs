using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 应用权限定义
    /// 应用权限定义
    /// Version 1612.0001
    /// </summary>
    public class AosAppLimits : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 应用权限定义 行数据操作器
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
            /// 设置应用标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAppID(string value) {
                base.Row["AppID"] = value;
                return this;
            }

            /// <summary>
            /// 设置权限标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLimitID(string value) {
                base.Row["LimitID"] = value;
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
        /// 获取应用标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AppID { get; private set; }

        /// <summary>
        /// 获取权限标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LimitID { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AosAppLimits() : base("AosAppLimits") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.AppID = new dpz2.db.SqlUnits.TableField(this, "AppID");
            this.LimitID = new dpz2.db.SqlUnits.TableField(this, "LimitID");
        }

    }

}
