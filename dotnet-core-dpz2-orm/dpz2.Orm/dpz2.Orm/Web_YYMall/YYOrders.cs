using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_YYMall {

    /// <summary>
    /// 一元订单
    /// 一元订单
    /// Version 2016.0803
    /// </summary>
    public class YYOrders : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 一元订单 行数据操作器
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
            /// 设置数量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetNumber(string value) {
                base.Row["Number"] = value;
                return this;
            }

            /// <summary>
            /// 设置支付时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPayTime(string value) {
                base.Row["PayTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置IP地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIPAddress(string value) {
                base.Row["IPAddress"] = value;
                return this;
            }

            /// <summary>
            /// 设置IP定位点
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIPCity(string value) {
                base.Row["IPCity"] = value;
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

            /// <summary>
            /// 设置标志
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFlag(string value) {
                base.Row["Flag"] = value;
                return this;
            }

            /// <summary>
            /// 设置创建时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCreateTime(string value) {
                base.Row["CreateTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置购物码获取数量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLotteryCount(string value) {
                base.Row["LotteryCount"] = value;
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
        /// 获取数量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Number { get; private set; }

        /// <summary>
        /// 获取支付时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PayTime { get; private set; }

        /// <summary>
        /// 获取IP地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IPAddress { get; private set; }

        /// <summary>
        /// 获取IP定位点字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IPCity { get; private set; }

        /// <summary>
        /// 获取状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 获取标志字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Flag { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取购物码获取数量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LotteryCount { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public YYOrders() : base("YYOrders") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.GoodID = new dpz2.db.SqlUnits.TableField(this, "GoodID");
            this.Number = new dpz2.db.SqlUnits.TableField(this, "Number");
            this.PayTime = new dpz2.db.SqlUnits.TableField(this, "PayTime");
            this.IPAddress = new dpz2.db.SqlUnits.TableField(this, "IPAddress");
            this.IPCity = new dpz2.db.SqlUnits.TableField(this, "IPCity");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
            this.Flag = new dpz2.db.SqlUnits.TableField(this, "Flag");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.LotteryCount = new dpz2.db.SqlUnits.TableField(this, "LotteryCount");
        }

    }

}
