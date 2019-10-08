using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_YYMall {

    /// <summary>
    /// 一元抽奖
    /// 一元抽奖
    /// Version 2016.0602
    /// </summary>
    public class YYLottery : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 一元抽奖 行数据操作器
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
            /// 设置用户标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
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
            /// 设置订单标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOrderID(string value) {
                base.Row["OrderID"] = value;
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
            /// 设置标记
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFlag(string value) {
                base.Row["Flag"] = value;
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
        /// 获取用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取一元商品标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField GoodID { get; private set; }

        /// <summary>
        /// 获取订单标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OrderID { get; private set; }

        /// <summary>
        /// 获取购物码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LuckyNumber { get; private set; }

        /// <summary>
        /// 获取标记字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Flag { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public YYLottery() : base("YYLottery") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.GoodID = new dpz2.db.SqlUnits.TableField(this, "GoodID");
            this.OrderID = new dpz2.db.SqlUnits.TableField(this, "OrderID");
            this.LuckyNumber = new dpz2.db.SqlUnits.TableField(this, "LuckyNumber");
            this.Flag = new dpz2.db.SqlUnits.TableField(this, "Flag");
        }

    }

}
