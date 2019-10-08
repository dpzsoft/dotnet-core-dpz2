using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.CPA {

    /// <summary>
    /// 代理记账流程考核标准
    /// 代理记账流程考核标准
    /// Version 1712.0001
    /// </summary>
    public class CPAAccountProcessAssessCriteria : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 代理记账流程考核标准 行数据操作器
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
            /// 设置操作得分
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetScore(string value) {
                base.Row["Score"] = value;
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
        /// 获取操作得分字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Score { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CPAAccountProcessAssessCriteria() : base("CPAAccountProcessAssessCriteria") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.ProcessID = new dpz2.db.SqlUnits.TableField(this, "ProcessID");
            this.Score = new dpz2.db.SqlUnits.TableField(this, "Score");
        }

    }

}
