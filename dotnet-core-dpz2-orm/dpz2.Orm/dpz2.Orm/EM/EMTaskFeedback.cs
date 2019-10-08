using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.EM {

    /// <summary>
    /// 任务反馈
    /// 任务反馈
    /// Version 1801.0002
    /// </summary>
    public class EMTaskFeedback : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 任务反馈 行数据操作器
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
            /// 设置任务标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTaskID(string value) {
                base.Row["TaskID"] = value;
                return this;
            }

            /// <summary>
            /// 设置描述
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSummary(string value) {
                base.Row["Summary"] = value;
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
        /// 获取任务标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TaskID { get; private set; }

        /// <summary>
        /// 获取描述字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Summary { get; private set; }

        /// <summary>
        /// 获取操作时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OperateTime { get; private set; }

        /// <summary>
        /// 获取操作人员字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OperateUser { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public EMTaskFeedback() : base("EMTaskFeedback") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.TaskID = new dpz2.db.SqlUnits.TableField(this, "TaskID");
            this.Summary = new dpz2.db.SqlUnits.TableField(this, "Summary");
            this.OperateTime = new dpz2.db.SqlUnits.TableField(this, "OperateTime");
            this.OperateUser = new dpz2.db.SqlUnits.TableField(this, "OperateUser");
        }

    }

}
