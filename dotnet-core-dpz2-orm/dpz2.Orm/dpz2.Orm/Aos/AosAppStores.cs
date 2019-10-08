using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 应用仓库信息
    /// 应用仓库信息
    /// Version 1.0.1904.1
    /// </summary>
    public class AosAppStores : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 应用仓库信息 行数据操作器
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
            /// 设置地址入口
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUrlEntrance(string value) {
                base.Row["UrlEntrance"] = value;
                return this;
            }

            /// <summary>
            /// 设置脚本入口
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetConfigEntrance(string value) {
                base.Row["ConfigEntrance"] = value;
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
        /// 获取地址入口字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UrlEntrance { get; private set; }

        /// <summary>
        /// 获取脚本入口字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ConfigEntrance { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AosAppStores() : base("AosAppStores") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.UrlEntrance = new dpz2.db.SqlUnits.TableField(this, "UrlEntrance");
            this.ConfigEntrance = new dpz2.db.SqlUnits.TableField(this, "ConfigEntrance");
        }

    }

}
