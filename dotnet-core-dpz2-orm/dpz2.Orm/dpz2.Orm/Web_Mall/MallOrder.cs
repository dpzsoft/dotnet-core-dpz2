using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Mall {

    /// <summary>
    /// 商城订单列表
    /// 商城订单列表
    /// Version 1802.0006
    /// </summary>
    public class MallOrder : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商城订单列表 行数据操作器
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
            public RowOperator SetCode(string value) {
                base.Row["Code"] = value;
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
            /// 设置数量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetQuantity(string value) {
                base.Row["Quantity"] = value;
                return this;
            }

            /// <summary>
            /// 设置支付金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMoney(string value) {
                base.Row["Money"] = value;
                return this;
            }

            /// <summary>
            /// 设置优惠前金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOriginalMoney(string value) {
                base.Row["OriginalMoney"] = value;
                return this;
            }

            /// <summary>
            /// 设置优惠金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDiscountMoney(string value) {
                base.Row["DiscountMoney"] = value;
                return this;
            }

            /// <summary>
            /// 设置优惠说明
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDiscountDescrition(string value) {
                base.Row["DiscountDescrition"] = value;
                return this;
            }

            /// <summary>
            /// 设置联系人
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetContact(string value) {
                base.Row["Contact"] = value;
                return this;
            }

            /// <summary>
            /// 设置联系电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhone(string value) {
                base.Row["Phone"] = value;
                return this;
            }

            /// <summary>
            /// 设置收货地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAddress(string value) {
                base.Row["Address"] = value;
                return this;
            }

            /// <summary>
            /// 设置运费
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFreight(string value) {
                base.Row["Freight"] = value;
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
            /// 设置支付方式
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPayType(string value) {
                base.Row["PayType"] = value;
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
            /// 设置发货时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetShipTime(string value) {
                base.Row["ShipTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置收货时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetReceiptTime(string value) {
                base.Row["ReceiptTime"] = value;
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
            /// 设置分销相关状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetS3Status(string value) {
                base.Row["S3Status"] = value;
                return this;
            }

            /// <summary>
            /// 设置积分相关状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIntegralStatus(string value) {
                base.Row["IntegralStatus"] = value;
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
        /// 获取编码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 获取用户识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取数量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Quantity { get; private set; }

        /// <summary>
        /// 获取支付金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Money { get; private set; }

        /// <summary>
        /// 获取优惠前金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OriginalMoney { get; private set; }

        /// <summary>
        /// 获取优惠金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DiscountMoney { get; private set; }

        /// <summary>
        /// 获取优惠说明字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DiscountDescrition { get; private set; }

        /// <summary>
        /// 获取联系人字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Contact { get; private set; }

        /// <summary>
        /// 获取联系电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取收货地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Address { get; private set; }

        /// <summary>
        /// 获取运费字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Freight { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取支付方式字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PayType { get; private set; }

        /// <summary>
        /// 获取支付时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PayTime { get; private set; }

        /// <summary>
        /// 获取发货时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ShipTime { get; private set; }

        /// <summary>
        /// 获取收货时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ReceiptTime { get; private set; }

        /// <summary>
        /// 获取订单状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 获取分销相关状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField S3Status { get; private set; }

        /// <summary>
        /// 获取积分相关状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IntegralStatus { get; private set; }

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
        public MallOrder() : base("MallOrder") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Quantity = new dpz2.db.SqlUnits.TableField(this, "Quantity");
            this.Money = new dpz2.db.SqlUnits.TableField(this, "Money");
            this.OriginalMoney = new dpz2.db.SqlUnits.TableField(this, "OriginalMoney");
            this.DiscountMoney = new dpz2.db.SqlUnits.TableField(this, "DiscountMoney");
            this.DiscountDescrition = new dpz2.db.SqlUnits.TableField(this, "DiscountDescrition");
            this.Contact = new dpz2.db.SqlUnits.TableField(this, "Contact");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.Address = new dpz2.db.SqlUnits.TableField(this, "Address");
            this.Freight = new dpz2.db.SqlUnits.TableField(this, "Freight");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.PayType = new dpz2.db.SqlUnits.TableField(this, "PayType");
            this.PayTime = new dpz2.db.SqlUnits.TableField(this, "PayTime");
            this.ShipTime = new dpz2.db.SqlUnits.TableField(this, "ShipTime");
            this.ReceiptTime = new dpz2.db.SqlUnits.TableField(this, "ReceiptTime");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
            this.S3Status = new dpz2.db.SqlUnits.TableField(this, "S3Status");
            this.IntegralStatus = new dpz2.db.SqlUnits.TableField(this, "IntegralStatus");
            this.ShipInfo = new dpz2.db.SqlUnits.TableField(this, "ShipInfo");
            this.Remarks = new dpz2.db.SqlUnits.TableField(this, "Remarks");
        }

    }

}
