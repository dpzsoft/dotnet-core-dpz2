using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Mall {

    /// <summary>
    /// 商城订单商品
    /// 商城订单商品
    /// Version 1804.0003
    /// </summary>
    public class MallOrderProduct : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商城订单商品 行数据操作器
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
            /// 设置订单标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOrderID(string value) {
                base.Row["OrderID"] = value;
                return this;
            }

            /// <summary>
            /// 设置用户识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置商品识标
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
            /// 设置单价
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPrice(string value) {
                base.Row["Price"] = value;
                return this;
            }

            /// <summary>
            /// 设置单位
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUnit(string value) {
                base.Row["Unit"] = value;
                return this;
            }

            /// <summary>
            /// 设置封面图片
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFrontImg(string value) {
                base.Row["FrontImg"] = value;
                return this;
            }

            /// <summary>
            /// 设置数量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAmount(string value) {
                base.Row["Amount"] = value;
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
            /// 设置更新时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUpdateTime(string value) {
                base.Row["UpdateTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置订单状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStatus(string value) {
                base.Row["Status"] = value;
                return this;
            }

            /// <summary>
            /// 设置发货时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetShipTime(string value) {
                base.Row["ShipTime"] = value;
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
            /// 设置备注
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRemarks(string value) {
                base.Row["Remarks"] = value;
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
        /// 获取订单标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OrderID { get; private set; }

        /// <summary>
        /// 获取用户识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取商品识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ProductID { get; private set; }

        /// <summary>
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取单价字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Price { get; private set; }

        /// <summary>
        /// 获取单位字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Unit { get; private set; }

        /// <summary>
        /// 获取封面图片字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FrontImg { get; private set; }

        /// <summary>
        /// 获取数量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Amount { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取更新时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UpdateTime { get; private set; }

        /// <summary>
        /// 获取订单状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 获取发货时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ShipTime { get; private set; }

        /// <summary>
        /// 获取发货信息字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ShipInfo { get; private set; }

        /// <summary>
        /// 获取备注字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Remarks { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public MallOrderProduct() : base("MallOrderProduct") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.OrderID = new dpz2.db.SqlUnits.TableField(this, "OrderID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.ProductID = new dpz2.db.SqlUnits.TableField(this, "ProductID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Price = new dpz2.db.SqlUnits.TableField(this, "Price");
            this.Unit = new dpz2.db.SqlUnits.TableField(this, "Unit");
            this.FrontImg = new dpz2.db.SqlUnits.TableField(this, "FrontImg");
            this.Amount = new dpz2.db.SqlUnits.TableField(this, "Amount");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.UpdateTime = new dpz2.db.SqlUnits.TableField(this, "UpdateTime");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
            this.ShipTime = new dpz2.db.SqlUnits.TableField(this, "ShipTime");
            this.ShipInfo = new dpz2.db.SqlUnits.TableField(this, "ShipInfo");
            this.Remarks = new dpz2.db.SqlUnits.TableField(this, "Remarks");
        }

    }

}
