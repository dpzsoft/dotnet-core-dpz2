using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.CPA {

    /// <summary>
    /// 代理记账信息
    /// 代理记账信息
    /// Version 1803.0008
    /// </summary>
    public class CPAAccountClient : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 代理记账信息 行数据操作器
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
            /// 设置单位名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属部门
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDepartmentID(string value) {
                base.Row["DepartmentID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属职位
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPositionID(string value) {
                base.Row["PositionID"] = value;
                return this;
            }

            /// <summary>
            /// 设置流程状态
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
            /// 设置统计生成年份
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetReportYear(string value) {
                base.Row["ReportYear"] = value;
                return this;
            }

            /// <summary>
            /// 设置公司类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCompanyType(string value) {
                base.Row["CompanyType"] = value;
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
        /// 获取客户编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 获取单位名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取所属部门字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DepartmentID { get; private set; }

        /// <summary>
        /// 获取所属职位字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PositionID { get; private set; }

        /// <summary>
        /// 获取流程状态字段定义
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
        /// 获取统计生成年份字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ReportYear { get; private set; }

        /// <summary>
        /// 获取公司类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CompanyType { get; private set; }

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
        public CPAAccountClient() : base("CPAAccountClient") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.DepartmentID = new dpz2.db.SqlUnits.TableField(this, "DepartmentID");
            this.PositionID = new dpz2.db.SqlUnits.TableField(this, "PositionID");
            this.ProcessID = new dpz2.db.SqlUnits.TableField(this, "ProcessID");
            this.OperateTime = new dpz2.db.SqlUnits.TableField(this, "OperateTime");
            this.OperateUser = new dpz2.db.SqlUnits.TableField(this, "OperateUser");
            this.ReportYear = new dpz2.db.SqlUnits.TableField(this, "ReportYear");
            this.CompanyType = new dpz2.db.SqlUnits.TableField(this, "CompanyType");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
