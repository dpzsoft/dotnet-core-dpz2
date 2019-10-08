using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Loan {

    /// <summary>
    /// 贷款业务评估数据
    /// 贷款业务评估数据
    /// Version 2017.0621
    /// </summary>
    public class LoanBusinessEvaluation : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 贷款业务评估数据 行数据操作器
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
            /// 设置姓名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAddress(string value) {
                base.Row["Address"] = value;
                return this;
            }

            /// <summary>
            /// 设置房屋属性/土地性质
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProperty(string value) {
                base.Row["Property"] = value;
                return this;
            }

            /// <summary>
            /// 设置评估结果
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEvaluation(string value) {
                base.Row["Evaluation"] = value;
                return this;
            }

            /// <summary>
            /// 设置业务来源
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSource(string value) {
                base.Row["Source"] = value;
                return this;
            }

            /// <summary>
            /// 设置报评日期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetApplyDate(string value) {
                base.Row["ApplyDate"] = value;
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
        /// 获取姓名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Address { get; private set; }

        /// <summary>
        /// 获取房屋属性/土地性质字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Property { get; private set; }

        /// <summary>
        /// 获取评估结果字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Evaluation { get; private set; }

        /// <summary>
        /// 获取业务来源字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Source { get; private set; }

        /// <summary>
        /// 获取报评日期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ApplyDate { get; private set; }

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
        public LoanBusinessEvaluation() : base("LoanBusinessEvaluation") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Address = new dpz2.db.SqlUnits.TableField(this, "Address");
            this.Property = new dpz2.db.SqlUnits.TableField(this, "Property");
            this.Evaluation = new dpz2.db.SqlUnits.TableField(this, "Evaluation");
            this.Source = new dpz2.db.SqlUnits.TableField(this, "Source");
            this.ApplyDate = new dpz2.db.SqlUnits.TableField(this, "ApplyDate");
            this.Remarks = new dpz2.db.SqlUnits.TableField(this, "Remarks");
        }

    }

}
