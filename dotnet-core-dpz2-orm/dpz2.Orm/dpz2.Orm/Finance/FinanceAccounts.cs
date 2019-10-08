using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Finance {

    /// <summary>
    /// 账目流水
    /// 账目流水
    /// Version 1712.0002
    /// </summary>
    public class FinanceAccounts : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 账目流水 行数据操作器
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
            /// 设置日期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFaDate(string value) {
                base.Row["FaDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属科目
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAccountingID(string value) {
                base.Row["AccountingID"] = value;
                return this;
            }

            /// <summary>
            /// 设置摘要
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSummary(string value) {
                base.Row["Summary"] = value;
                return this;
            }

            /// <summary>
            /// 设置收入
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAccIn(string value) {
                base.Row["AccIn"] = value;
                return this;
            }

            /// <summary>
            /// 设置支出
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAccOut(string value) {
                base.Row["AccOut"] = value;
                return this;
            }

            /// <summary>
            /// 设置备注
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDecription(string value) {
                base.Row["Decription"] = value;
                return this;
            }

            /// <summary>
            /// 设置账户类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAccountTypeID(string value) {
                base.Row["AccountTypeID"] = value;
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
        /// 获取日期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FaDate { get; private set; }

        /// <summary>
        /// 获取所属科目字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AccountingID { get; private set; }

        /// <summary>
        /// 获取摘要字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Summary { get; private set; }

        /// <summary>
        /// 获取收入字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AccIn { get; private set; }

        /// <summary>
        /// 获取支出字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AccOut { get; private set; }

        /// <summary>
        /// 获取备注字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Decription { get; private set; }

        /// <summary>
        /// 获取账户类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AccountTypeID { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public FinanceAccounts() : base("FinanceAccounts") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.FaDate = new dpz2.db.SqlUnits.TableField(this, "FaDate");
            this.AccountingID = new dpz2.db.SqlUnits.TableField(this, "AccountingID");
            this.Summary = new dpz2.db.SqlUnits.TableField(this, "Summary");
            this.AccIn = new dpz2.db.SqlUnits.TableField(this, "AccIn");
            this.AccOut = new dpz2.db.SqlUnits.TableField(this, "AccOut");
            this.Decription = new dpz2.db.SqlUnits.TableField(this, "Decription");
            this.AccountTypeID = new dpz2.db.SqlUnits.TableField(this, "AccountTypeID");
        }

    }

}
