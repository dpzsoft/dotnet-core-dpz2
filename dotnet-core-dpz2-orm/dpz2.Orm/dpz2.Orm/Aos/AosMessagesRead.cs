using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 消息阅读
    /// 消息阅读
    /// Version 1709.0001
    /// </summary>
    public class AosMessagesRead : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 消息阅读 行数据操作器
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
            /// 设置用户标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置消息标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMessageID(string value) {
                base.Row["MessageID"] = value;
                return this;
            }

            /// <summary>
            /// 设置消息状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStatus(string value) {
                base.Row["Status"] = value;
                return this;
            }

            /// <summary>
            /// 设置阅读时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetReadTime(string value) {
                base.Row["ReadTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置回复时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetReplyTime(string value) {
                base.Row["ReplyTime"] = value;
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
        /// 获取用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取消息标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField MessageID { get; private set; }

        /// <summary>
        /// 获取消息状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 获取阅读时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ReadTime { get; private set; }

        /// <summary>
        /// 获取回复时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ReplyTime { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AosMessagesRead() : base("AosMessagesRead") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.MessageID = new dpz2.db.SqlUnits.TableField(this, "MessageID");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
            this.ReadTime = new dpz2.db.SqlUnits.TableField(this, "ReadTime");
            this.ReplyTime = new dpz2.db.SqlUnits.TableField(this, "ReplyTime");
        }

    }

}
