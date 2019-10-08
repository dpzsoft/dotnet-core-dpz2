using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_YYMall {

    /// <summary>
    /// 一元晒单
    /// 一元晒单
    /// Version 2016.0703
    /// </summary>
    public class YYGoodShow : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 一元晒单 行数据操作器
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
            /// 设置商品标识
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
            /// 设置抽奖标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLotteryID(string value) {
                base.Row["LotteryID"] = value;
                return this;
            }

            /// <summary>
            /// 设置标题
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTitle(string value) {
                base.Row["Title"] = value;
                return this;
            }

            /// <summary>
            /// 设置详情
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDetail(string value) {
                base.Row["Detail"] = value;
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
            /// 设置状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStatus(string value) {
                base.Row["Status"] = value;
                return this;
            }

            /// <summary>
            /// 设置获得积分
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIntegral(string value) {
                base.Row["Integral"] = value;
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
        /// 获取商品标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField GoodID { get; private set; }

        /// <summary>
        /// 获取订单标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OrderID { get; private set; }

        /// <summary>
        /// 获取抽奖标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LotteryID { get; private set; }

        /// <summary>
        /// 获取标题字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Title { get; private set; }

        /// <summary>
        /// 获取详情字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Detail { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 获取获得积分字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Integral { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public YYGoodShow() : base("YYGoodShow") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.GoodID = new dpz2.db.SqlUnits.TableField(this, "GoodID");
            this.OrderID = new dpz2.db.SqlUnits.TableField(this, "OrderID");
            this.LotteryID = new dpz2.db.SqlUnits.TableField(this, "LotteryID");
            this.Title = new dpz2.db.SqlUnits.TableField(this, "Title");
            this.Detail = new dpz2.db.SqlUnits.TableField(this, "Detail");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
            this.Integral = new dpz2.db.SqlUnits.TableField(this, "Integral");
        }

    }

}
