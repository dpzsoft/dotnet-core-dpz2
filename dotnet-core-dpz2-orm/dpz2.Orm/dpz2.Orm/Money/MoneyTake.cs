using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Money {

    /// <summary>
    /// 资金提现表
    /// 存储所有的用户信息
    /// Version 1704.0001
    /// </summary>
    public class MoneyTake : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 资金提现表 行数据操作器
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
            /// 设置银行
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBank(string value) {
                base.Row["Bank"] = value;
                return this;
            }

            /// <summary>
            /// 设置银行账户名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBankAccountName(string value) {
                base.Row["BankAccountName"] = value;
                return this;
            }

            /// <summary>
            /// 设置银行账户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBankAccount(string value) {
                base.Row["BankAccount"] = value;
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
        /// 获取银行字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Bank { get; private set; }

        /// <summary>
        /// 获取银行账户名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BankAccountName { get; private set; }

        /// <summary>
        /// 获取银行账户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BankAccount { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取支付时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PayTime { get; private set; }

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
        public MoneyTake() : base("MoneyTake") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Money = new dpz2.db.SqlUnits.TableField(this, "Money");
            this.Bank = new dpz2.db.SqlUnits.TableField(this, "Bank");
            this.BankAccountName = new dpz2.db.SqlUnits.TableField(this, "BankAccountName");
            this.BankAccount = new dpz2.db.SqlUnits.TableField(this, "BankAccount");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.PayTime = new dpz2.db.SqlUnits.TableField(this, "PayTime");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
