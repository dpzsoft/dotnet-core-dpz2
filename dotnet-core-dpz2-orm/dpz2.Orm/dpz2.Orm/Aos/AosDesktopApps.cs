using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 桌面应用信息
    /// 用于存储桌面针对应用的支持信息
    /// Version 1.1.1810.2
    /// </summary>
    public class AosDesktopApps : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 桌面应用信息 行数据操作器
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
            /// 设置桌面识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDesktopID(string value) {
                base.Row["DesktopID"] = value;
                return this;
            }

            /// <summary>
            /// 设置应用识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAppID(string value) {
                base.Row["AppID"] = value;
                return this;
            }

            /// <summary>
            /// 设置兼容性
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCompatibility(string value) {
                base.Row["Compatibility"] = value;
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
        /// 获取桌面识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DesktopID { get; private set; }

        /// <summary>
        /// 获取应用识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AppID { get; private set; }

        /// <summary>
        /// 获取兼容性字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Compatibility { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AosDesktopApps() : base("AosDesktopApps") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.DesktopID = new dpz2.db.SqlUnits.TableField(this, "DesktopID");
            this.AppID = new dpz2.db.SqlUnits.TableField(this, "AppID");
            this.Compatibility = new dpz2.db.SqlUnits.TableField(this, "Compatibility");
        }

    }

}
