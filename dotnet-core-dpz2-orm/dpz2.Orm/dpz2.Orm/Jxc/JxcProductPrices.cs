using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Jxc {

    /// <summary>
    /// 商品价格信息
    /// 存储所有的商品价格信息
    /// Version 1710.0001
    /// </summary>
    public class JxcProductPrices : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商品价格信息 行数据操作器
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
            /// 设置编码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProductID(string value) {
                base.Row["ProductID"] = value;
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
            /// 设置售价
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPrice(string value) {
                base.Row["Price"] = value;
                return this;
            }

            /// <summary>
            /// 设置状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStatus(string value) {
                base.Row["Status"] = value;
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
        /// 获取编码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ProductID { get; private set; }

        /// <summary>
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取售价字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Price { get; private set; }

        /// <summary>
        /// 获取状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public JxcProductPrices() : base("JxcProductPrices") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ProductID = new dpz2.db.SqlUnits.TableField(this, "ProductID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Price = new dpz2.db.SqlUnits.TableField(this, "Price");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
