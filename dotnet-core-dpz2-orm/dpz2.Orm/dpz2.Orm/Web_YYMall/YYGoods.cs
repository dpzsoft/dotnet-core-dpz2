using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_YYMall {

    /// <summary>
    /// 一元商品
    /// 一元商品
    /// Version 2016.0607
    /// </summary>
    public class YYGoods : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 一元商品 行数据操作器
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
            /// 设置商品标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGoodID(string value) {
                base.Row["GoodID"] = value;
                return this;
            }

            /// <summary>
            /// 设置云购批次
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetNumber(string value) {
                base.Row["Number"] = value;
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
            /// 设置幸运号码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLuckyNumber(string value) {
                base.Row["LuckyNumber"] = value;
                return this;
            }

            /// <summary>
            /// 设置满员时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOverTime(string value) {
                base.Row["OverTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置结束时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFinishTime(string value) {
                base.Row["FinishTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置发货状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetShipStatus(string value) {
                base.Row["ShipStatus"] = value;
                return this;
            }

            /// <summary>
            /// 设置发货信息
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetShipInfo(string value) {
                base.Row["ShipInfo"] = value;
                return this;
            }

            /// <summary>
            /// 设置总需人次
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetNeedNumber(string value) {
                base.Row["NeedNumber"] = value;
                return this;
            }

            /// <summary>
            /// 设置销售人次
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSellNumber(string value) {
                base.Row["SellNumber"] = value;
                return this;
            }

            /// <summary>
            /// 设置剩余人次
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRestNumber(string value) {
                base.Row["RestNumber"] = value;
                return this;
            }

            /// <summary>
            /// 设置销售进度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSellProcess(string value) {
                base.Row["SellProcess"] = value;
                return this;
            }

            /// <summary>
            /// 设置中奖订单
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLuckyOrder(string value) {
                base.Row["LuckyOrder"] = value;
                return this;
            }

            /// <summary>
            /// 设置中奖用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLuckyUser(string value) {
                base.Row["LuckyUser"] = value;
                return this;
            }

            /// <summary>
            /// 设置运算数据和
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLuckySum(string value) {
                base.Row["LuckySum"] = value;
                return this;
            }

            /// <summary>
            /// 设置运算开始
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLuckyStart(string value) {
                base.Row["LuckyStart"] = value;
                return this;
            }

            /// <summary>
            /// 设置运算结束
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLuckyEnd(string value) {
                base.Row["LuckyEnd"] = value;
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
        /// 获取商品标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField GoodID { get; private set; }

        /// <summary>
        /// 获取云购批次字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Number { get; private set; }

        /// <summary>
        /// 获取状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 获取幸运号码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LuckyNumber { get; private set; }

        /// <summary>
        /// 获取满员时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OverTime { get; private set; }

        /// <summary>
        /// 获取结束时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FinishTime { get; private set; }

        /// <summary>
        /// 获取发货状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ShipStatus { get; private set; }

        /// <summary>
        /// 获取发货信息字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ShipInfo { get; private set; }

        /// <summary>
        /// 获取总需人次字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField NeedNumber { get; private set; }

        /// <summary>
        /// 获取销售人次字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SellNumber { get; private set; }

        /// <summary>
        /// 获取剩余人次字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RestNumber { get; private set; }

        /// <summary>
        /// 获取销售进度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SellProcess { get; private set; }

        /// <summary>
        /// 获取中奖订单字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LuckyOrder { get; private set; }

        /// <summary>
        /// 获取中奖用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LuckyUser { get; private set; }

        /// <summary>
        /// 获取运算数据和字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LuckySum { get; private set; }

        /// <summary>
        /// 获取运算开始字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LuckyStart { get; private set; }

        /// <summary>
        /// 获取运算结束字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LuckyEnd { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public YYGoods() : base("YYGoods") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.GoodID = new dpz2.db.SqlUnits.TableField(this, "GoodID");
            this.Number = new dpz2.db.SqlUnits.TableField(this, "Number");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
            this.LuckyNumber = new dpz2.db.SqlUnits.TableField(this, "LuckyNumber");
            this.OverTime = new dpz2.db.SqlUnits.TableField(this, "OverTime");
            this.FinishTime = new dpz2.db.SqlUnits.TableField(this, "FinishTime");
            this.ShipStatus = new dpz2.db.SqlUnits.TableField(this, "ShipStatus");
            this.ShipInfo = new dpz2.db.SqlUnits.TableField(this, "ShipInfo");
            this.NeedNumber = new dpz2.db.SqlUnits.TableField(this, "NeedNumber");
            this.SellNumber = new dpz2.db.SqlUnits.TableField(this, "SellNumber");
            this.RestNumber = new dpz2.db.SqlUnits.TableField(this, "RestNumber");
            this.SellProcess = new dpz2.db.SqlUnits.TableField(this, "SellProcess");
            this.LuckyOrder = new dpz2.db.SqlUnits.TableField(this, "LuckyOrder");
            this.LuckyUser = new dpz2.db.SqlUnits.TableField(this, "LuckyUser");
            this.LuckySum = new dpz2.db.SqlUnits.TableField(this, "LuckySum");
            this.LuckyStart = new dpz2.db.SqlUnits.TableField(this, "LuckyStart");
            this.LuckyEnd = new dpz2.db.SqlUnits.TableField(this, "LuckyEnd");
        }

    }

}
