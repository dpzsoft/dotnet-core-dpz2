using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_YYMall {

    /// <summary>
    /// 一元购物码
    /// 一元购物码
    /// Version 2016.0801
    /// </summary>
    public class YYGoodLottery : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 一元购物码 行数据操作器
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
            /// 设置一元商品标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGoodID(string value) {
                base.Row["GoodID"] = value;
                return this;
            }

            /// <summary>
            /// 设置购物码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLuckyNumber(string value) {
                base.Row["LuckyNumber"] = value;
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
        /// 获取一元商品标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField GoodID { get; private set; }

        /// <summary>
        /// 获取购物码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LuckyNumber { get; private set; }

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
        public YYGoodLottery() : base("YYGoodLottery") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.GoodID = new dpz2.db.SqlUnits.TableField(this, "GoodID");
            this.LuckyNumber = new dpz2.db.SqlUnits.TableField(this, "LuckyNumber");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
