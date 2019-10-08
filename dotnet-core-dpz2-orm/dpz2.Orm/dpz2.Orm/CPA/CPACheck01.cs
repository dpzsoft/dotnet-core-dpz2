using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.CPA {

    /// <summary>
    /// 审核01
    /// 审核01
    /// Version 1712.0004
    /// </summary>
    public class CPACheck01 : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 审核01 行数据操作器
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
            /// 设置审核员
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置备注
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRemark(string value) {
                base.Row["Remark"] = value;
                return this;
            }

            /// <summary>
            /// 设置审核时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCheckTime(string value) {
                base.Row["CheckTime"] = value;
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
            /// 设置审核结果
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetResult(string value) {
                base.Row["Result"] = value;
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
        /// 获取审核员字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取备注字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Remark { get; private set; }

        /// <summary>
        /// 获取审核时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CheckTime { get; private set; }

        /// <summary>
        /// 获取相关流程字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ProcessID { get; private set; }

        /// <summary>
        /// 获取审核结果字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Result { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CPACheck01() : base("CPACheck01") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Remark = new dpz2.db.SqlUnits.TableField(this, "Remark");
            this.CheckTime = new dpz2.db.SqlUnits.TableField(this, "CheckTime");
            this.ProcessID = new dpz2.db.SqlUnits.TableField(this, "ProcessID");
            this.Result = new dpz2.db.SqlUnits.TableField(this, "Result");
        }

    }

}
