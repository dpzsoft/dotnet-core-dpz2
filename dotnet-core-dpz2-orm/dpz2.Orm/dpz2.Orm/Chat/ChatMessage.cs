using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Chat {

    /// <summary>
    /// 聊天消息表
    /// 聊天消息表
    /// Version 1703.0002
    /// </summary>
    public class ChatMessage : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 聊天消息表 行数据操作器
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
            /// 设置发送内容
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetContent(string value) {
                base.Row["Content"] = value;
                return this;
            }

            /// <summary>
            /// 设置内容类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetChatType(string value) {
                base.Row["ChatType"] = value;
                return this;
            }

            /// <summary>
            /// 设置发送时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSendTime(string value) {
                base.Row["SendTime"] = value;
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
        /// 获取发送内容字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Content { get; private set; }

        /// <summary>
        /// 获取内容类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ChatType { get; private set; }

        /// <summary>
        /// 获取发送时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SendTime { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public ChatMessage() : base("ChatMessage") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ChatID = new dpz2.db.SqlUnits.TableField(this, "ChatID");
            this.SessionID = new dpz2.db.SqlUnits.TableField(this, "SessionID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Content = new dpz2.db.SqlUnits.TableField(this, "Content");
            this.ChatType = new dpz2.db.SqlUnits.TableField(this, "ChatType");
            this.SendTime = new dpz2.db.SqlUnits.TableField(this, "SendTime");
        }

    }

}
