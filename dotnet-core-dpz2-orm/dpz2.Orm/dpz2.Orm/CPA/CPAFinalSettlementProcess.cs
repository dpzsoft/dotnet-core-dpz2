using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.CPA {

    /// <summary>
    /// 汇算清缴流程
    /// 汇算清缴流程
    /// Version 2016.0402
    /// </summary>
    public class CPAFinalSettlementProcess : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 汇算清缴流程 行数据操作器
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
            /// 设置相关年份
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetYear(string value) {
                base.Row["Year"] = value;
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
        /// 获取相关年份字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Year { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CPAFinalSettlementProcess() : base("CPAFinalSettlementProcess") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.ProcessID = new dpz2.db.SqlUnits.TableField(this, "ProcessID");
            this.OperateTime = new dpz2.db.SqlUnits.TableField(this, "OperateTime");
            this.OperateUser = new dpz2.db.SqlUnits.TableField(this, "OperateUser");
            this.Detail = new dpz2.db.SqlUnits.TableField(this, "Detail");
            this.Year = new dpz2.db.SqlUnits.TableField(this, "Year");
        }

    }

}
