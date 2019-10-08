using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.EM {

    /// <summary>
    /// 任务管理
    /// 任务管理
    /// Version 1712.0004
    /// </summary>
    public class EMTask : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 任务管理 行数据操作器
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
            /// 设置更新状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOperateStatus(string value) {
                base.Row["OperateStatus"] = value;
                return this;
            }

            /// <summary>
            /// 设置更新时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOperateTime(string value) {
                base.Row["OperateTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置更新人员
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOperateUser(string value) {
                base.Row["OperateUser"] = value;
                return this;
            }

            /// <summary>
            /// 设置发布人员
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置独占任务
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIsEngross(string value) {
                base.Row["IsEngross"] = value;
                return this;
            }

            /// <summary>
            /// 设置任务人员
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetToUserID(string value) {
                base.Row["ToUserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置任务描述
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSummary(string value) {
                base.Row["Summary"] = value;
                return this;
            }

            /// <summary>
            /// 设置开始日期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStartDate(string value) {
                base.Row["StartDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置结束日期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFinishDate(string value) {
                base.Row["FinishDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置每天开始时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStartTime(string value) {
                base.Row["StartTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置每天结束时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFinishTime(string value) {
                base.Row["FinishTime"] = value;
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
        /// 获取更新状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OperateStatus { get; private set; }

        /// <summary>
        /// 获取更新时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OperateTime { get; private set; }

        /// <summary>
        /// 获取更新人员字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OperateUser { get; private set; }

        /// <summary>
        /// 获取发布人员字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取独占任务字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IsEngross { get; private set; }

        /// <summary>
        /// 获取任务人员字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ToUserID { get; private set; }

        /// <summary>
        /// 获取任务描述字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Summary { get; private set; }

        /// <summary>
        /// 获取开始日期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField StartDate { get; private set; }

        /// <summary>
        /// 获取结束日期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FinishDate { get; private set; }

        /// <summary>
        /// 获取每天开始时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField StartTime { get; private set; }

        /// <summary>
        /// 获取每天结束时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FinishTime { get; private set; }

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
        public EMTask() : base("EMTask") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.OperateStatus = new dpz2.db.SqlUnits.TableField(this, "OperateStatus");
            this.OperateTime = new dpz2.db.SqlUnits.TableField(this, "OperateTime");
            this.OperateUser = new dpz2.db.SqlUnits.TableField(this, "OperateUser");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.IsEngross = new dpz2.db.SqlUnits.TableField(this, "IsEngross");
            this.ToUserID = new dpz2.db.SqlUnits.TableField(this, "ToUserID");
            this.Summary = new dpz2.db.SqlUnits.TableField(this, "Summary");
            this.StartDate = new dpz2.db.SqlUnits.TableField(this, "StartDate");
            this.FinishDate = new dpz2.db.SqlUnits.TableField(this, "FinishDate");
            this.StartTime = new dpz2.db.SqlUnits.TableField(this, "StartTime");
            this.FinishTime = new dpz2.db.SqlUnits.TableField(this, "FinishTime");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
