using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Chat {

    /// <summary>
    /// 对用户聊天
    /// 对用户聊天
    /// Version 1703.0003
    /// </summary>
    public class ChatToUser : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 对用户聊天 行数据操作器
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
            /// 设置发送者会话标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFromSessionID(string value) {
                base.Row["FromSessionID"] = value;
                return this;
            }

            /// <summary>
            /// 设置发送者标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFromUserID(string value) {
                base.Row["FromUserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置接收者会话标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetToSessionID(string value) {
                base.Row["ToSessionID"] = value;
                return this;
            }

            /// <summary>
            /// 设置接收者标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetToUserID(string value) {
                base.Row["ToUserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置创建时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCreateTime(string value) {
                base.Row["CreateTime"] = value;
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
        /// 获取发送者会话标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FromSessionID { get; private set; }

        /// <summary>
        /// 获取发送者标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FromUserID { get; private set; }

        /// <summary>
        /// 获取接收者会话标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ToSessionID { get; private set; }

        /// <summary>
        /// 获取接收者标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ToUserID { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public ChatToUser() : base("ChatToUser") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ChatID = new dpz2.db.SqlUnits.TableField(this, "ChatID");
            this.FromSessionID = new dpz2.db.SqlUnits.TableField(this, "FromSessionID");
            this.FromUserID = new dpz2.db.SqlUnits.TableField(this, "FromUserID");
            this.ToSessionID = new dpz2.db.SqlUnits.TableField(this, "ToSessionID");
            this.ToUserID = new dpz2.db.SqlUnits.TableField(this, "ToUserID");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
        }

    }

}
