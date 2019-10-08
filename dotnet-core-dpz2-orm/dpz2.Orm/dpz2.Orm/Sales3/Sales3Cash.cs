using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Sales3 {

    /// <summary>
    /// 分销提现表
    /// 分销提现表
    /// Version 1707.0002
    /// </summary>
    public class Sales3Cash : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 分销提现表 行数据操作器
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
            /// 设置用户名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置开户银行
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBank(string value) {
                base.Row["Bank"] = value;
                return this;
            }

            /// <summary>
            /// 设置银行账号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBankAccount(string value) {
                base.Row["BankAccount"] = value;
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
            /// 设置申请时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetApplyTimestamp(string value) {
                base.Row["ApplyTimestamp"] = value;
                return this;
            }

            /// <summary>
            /// 设置处理时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAcceptTimestamp(string value) {
                base.Row["AcceptTimestamp"] = value;
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
        /// 获取用户名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取开户银行字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Bank { get; private set; }

        /// <summary>
        /// 获取银行账号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BankAccount { get; private set; }

        /// <summary>
        /// 获取金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Money { get; private set; }

        /// <summary>
        /// 获取申请时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ApplyTimestamp { get; private set; }

        /// <summary>
        /// 获取处理时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AcceptTimestamp { get; private set; }

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
        public Sales3Cash() : base("Sales3Cash") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Bank = new dpz2.db.SqlUnits.TableField(this, "Bank");
            this.BankAccount = new dpz2.db.SqlUnits.TableField(this, "BankAccount");
            this.Money = new dpz2.db.SqlUnits.TableField(this, "Money");
            this.ApplyTimestamp = new dpz2.db.SqlUnits.TableField(this, "ApplyTimestamp");
            this.AcceptTimestamp = new dpz2.db.SqlUnits.TableField(this, "AcceptTimestamp");
            this.Remarks = new dpz2.db.SqlUnits.TableField(this, "Remarks");
        }

    }

}
