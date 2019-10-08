using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web {

    /// <summary>
    /// 网站推广
    /// 网站推广
    /// Version 2016.0601
    /// </summary>
    public class WebSpread : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 网站推广 行数据操作器
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
            /// 设置推广地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUrl(string value) {
                base.Row["Url"] = value;
                return this;
            }

            /// <summary>
            /// 设置访问量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVisited(string value) {
                base.Row["Visited"] = value;
                return this;
            }

            /// <summary>
            /// 设置销量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSales(string value) {
                base.Row["Sales"] = value;
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
        /// 获取推广地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Url { get; private set; }

        /// <summary>
        /// 获取访问量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Visited { get; private set; }

        /// <summary>
        /// 获取销量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Sales { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public WebSpread() : base("WebSpread") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Url = new dpz2.db.SqlUnits.TableField(this, "Url");
            this.Visited = new dpz2.db.SqlUnits.TableField(this, "Visited");
            this.Sales = new dpz2.db.SqlUnits.TableField(this, "Sales");
        }

    }

}
