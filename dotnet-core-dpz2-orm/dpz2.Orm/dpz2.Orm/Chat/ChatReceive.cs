using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Chat {

    /// <summary>
    /// 聊天接收记录
    /// 聊天接收记录
    /// Version 1703.0002
    /// </summary>
    public class ChatReceive : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 聊天接收记录 行数据操作器
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
            /// 设置聊天标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetChatID(string value) {
                base.Row["ChatID"] = value;
                return this;
            }

            /// <summary>
            /// 设置会话标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSessionID(string value) {
                base.Row["SessionID"] = value;
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
            /// 设置最后一次接收时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLastReceiveTime(string value) {
                base.Row["LastReceiveTime"] = value;
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
        /// 获取聊天标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ChatID { get; private set; }

        /// <summary>
        /// 获取会话标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SessionID { get; private set; }

        /// <summary>
        /// 获取用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取最后一次接收时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LastReceiveTime { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public ChatReceive() : base("ChatReceive") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ChatID = new dpz2.db.SqlUnits.TableField(this, "ChatID");
            this.SessionID = new dpz2.db.SqlUnits.TableField(this, "SessionID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.LastReceiveTime = new dpz2.db.SqlUnits.TableField(this, "LastReceiveTime");
        }

    }

}
