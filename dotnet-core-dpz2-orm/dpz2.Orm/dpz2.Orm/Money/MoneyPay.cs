using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Money {

    /// <summary>
    /// 资金支付表
    /// 存储所有的用户信息
    /// Version 1809.0003
    /// </summary>
    public class MoneyPay : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 资金支付表 行数据操作器
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
            /// 设置流水号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCode(string value) {
                base.Row["Code"] = value;
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
            /// 设置金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMoney(string value) {
                base.Row["Money"] = value;
                return this;
            }

            /// <summary>
            /// 设置支付类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPayType(string value) {
                base.Row["PayType"] = value;
                return this;
            }

            /// <summary>
            /// 设置支付金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPayMoney(string value) {
                base.Row["PayMoney"] = value;
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
            /// 设置支付时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPayTime(string value) {
                base.Row["PayTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置支付详情
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDetail(string value) {
                base.Row["Detail"] = value;
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
        /// 获取流水号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 获取用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Money { get; private set; }

        /// <summary>
        /// 获取支付类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PayType { get; private set; }

        /// <summary>
        /// 获取支付金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PayMoney { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取支付时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PayTime { get; private set; }

        /// <summary>
        /// 获取支付详情字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Detail { get; private set; }

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
        public MoneyPay() : base("MoneyPay") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Money = new dpz2.db.SqlUnits.TableField(this, "Money");
            this.PayType = new dpz2.db.SqlUnits.TableField(this, "PayType");
            this.PayMoney = new dpz2.db.SqlUnits.TableField(this, "PayMoney");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.PayTime = new dpz2.db.SqlUnits.TableField(this, "PayTime");
            this.Detail = new dpz2.db.SqlUnits.TableField(this, "Detail");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
