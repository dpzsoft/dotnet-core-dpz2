using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.CPA {

    /// <summary>
    /// 代理记账流程
    /// 代理记账流程
    /// Version 1701.0003
    /// </summary>
    public class CPAAccountProcess : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 代理记账流程 行数据操作器
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
            /// 设置客户编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCode(string value) {
                base.Row["Code"] = value;
                return this;
            }

            /// <summary>
            /// 设置年份
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetYear(string value) {
                base.Row["Year"] = value;
                return this;
            }

            /// <summary>
            /// 设置月份
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMonth(string value) {
                base.Row["Month"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关流程
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProcessID(string value) {
                base.Row["ProcessID"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOperateTime(string value) {
                base.Row["OperateTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作人员
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOperateUser(string value) {
                base.Row["OperateUser"] = value;
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
            /// 设置审核人员1
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCheck01(string value) {
                base.Row["Check01"] = value;
                return this;
            }

            /// <summary>
            /// 设置备注1
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRemark01(string value) {
                base.Row["Remark01"] = value;
                return this;
            }

            /// <summary>
            /// 设置审核人员2
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCheck02(string value) {
                base.Row["Check02"] = value;
                return this;
            }

            /// <summary>
            /// 设置备注2
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRemark02(string value) {
                base.Row["Remark02"] = value;
                return this;
            }

            /// <summary>
            /// 设置审核人员3
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCheck03(string value) {
                base.Row["Check03"] = value;
                return this;
            }

            /// <summary>
            /// 设置备注3
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRemark03(string value) {
                base.Row["Remark03"] = value;
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
        /// 获取客户编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 获取年份字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Year { get; private set; }

        /// <summary>
        /// 获取月份字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Month { get; private set; }

        /// <summary>
        /// 获取相关流程字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ProcessID { get; private set; }

        /// <summary>
        /// 获取操作时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OperateTime { get; private set; }

        /// <summary>
        /// 获取操作人员字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OperateUser { get; private set; }

        /// <summary>
        /// 获取详情字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Detail { get; private set; }

        /// <summary>
        /// 获取审核人员1字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Check01 { get; private set; }

        /// <summary>
        /// 获取备注1字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Remark01 { get; private set; }

        /// <summary>
        /// 获取审核人员2字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Check02 { get; private set; }

        /// <summary>
        /// 获取备注2字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Remark02 { get; private set; }

        /// <summary>
        /// 获取审核人员3字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Check03 { get; private set; }

        /// <summary>
        /// 获取备注3字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Remark03 { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CPAAccountProcess() : base("CPAAccountProcess") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.Year = new dpz2.db.SqlUnits.TableField(this, "Year");
            this.Month = new dpz2.db.SqlUnits.TableField(this, "Month");
            this.ProcessID = new dpz2.db.SqlUnits.TableField(this, "ProcessID");
            this.OperateTime = new dpz2.db.SqlUnits.TableField(this, "OperateTime");
            this.OperateUser = new dpz2.db.SqlUnits.TableField(this, "OperateUser");
            this.Detail = new dpz2.db.SqlUnits.TableField(this, "Detail");
            this.Check01 = new dpz2.db.SqlUnits.TableField(this, "Check01");
            this.Remark01 = new dpz2.db.SqlUnits.TableField(this, "Remark01");
            this.Check02 = new dpz2.db.SqlUnits.TableField(this, "Check02");
            this.Remark02 = new dpz2.db.SqlUnits.TableField(this, "Remark02");
            this.Check03 = new dpz2.db.SqlUnits.TableField(this, "Check03");
            this.Remark03 = new dpz2.db.SqlUnits.TableField(this, "Remark03");
        }

    }

}
