using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Chat {

    /// <summary>
    /// 对群组聊天
    /// 对群组聊天
    /// Version 1703.0001
    /// </summary>
    public class ChatToGroup : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 对群组聊天 行数据操作器
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
            /// 设置群组标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGroupID(string value) {
                base.Row["GroupID"] = value;
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
        /// 获取群组标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField GroupID { get; private set; }

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
        public ChatToGroup() : base("ChatToGroup") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ChatID = new dpz2.db.SqlUnits.TableField(this, "ChatID");
            this.GroupID = new dpz2.db.SqlUnits.TableField(this, "GroupID");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
        }

    }

}
