using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.EM {

    /// <summary>
    /// 任务参与人员
    /// 任务参与人员
    /// Version 1712.0002
    /// </summary>
    public class EMTaskUser : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 任务参与人员 行数据操作器
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
            /// 设置参与人员
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置确认状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetConfirmStatus(string value) {
                base.Row["ConfirmStatus"] = value;
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
        /// 获取任务标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TaskID { get; private set; }

        /// <summary>
        /// 获取参与人员字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取确认状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ConfirmStatus { get; private set; }

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
        public EMTaskUser() : base("EMTaskUser") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.TaskID = new dpz2.db.SqlUnits.TableField(this, "TaskID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.ConfirmStatus = new dpz2.db.SqlUnits.TableField(this, "ConfirmStatus");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
