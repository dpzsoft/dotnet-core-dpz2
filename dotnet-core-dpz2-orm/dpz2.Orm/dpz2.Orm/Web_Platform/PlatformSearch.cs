using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Platform {

    /// <summary>
    /// 搜索记录
    /// 搜索记录
    /// Version 2016.0502
    /// </summary>
    public class PlatformSearch : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 搜索记录 行数据操作器
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
            /// 设置关键字
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetKey(string value) {
                base.Row["Key"] = value;
                return this;
            }

            /// <summary>
            /// 设置搜索总量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSearchCount(string value) {
                base.Row["SearchCount"] = value;
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
        /// 获取关键字字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Key { get; private set; }

        /// <summary>
        /// 获取搜索总量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SearchCount { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public PlatformSearch() : base("PlatformSearch") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Key = new dpz2.db.SqlUnits.TableField(this, "Key");
            this.SearchCount = new dpz2.db.SqlUnits.TableField(this, "SearchCount");
        }

    }

}
