using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 消息
    /// 消息
    /// Version 1709.0001
    /// </summary>
    public class AosMessages : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 消息 行数据操作器
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
            /// 设置发送用户标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSenderID(string value) {
                base.Row["SenderID"] = value;
                return this;
            }

            /// <summary>
            /// 设置标题
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTitle(string value) {
                base.Row["Title"] = value;
                return this;
            }

            /// <summary>
            /// 设置内容
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetContent(string value) {
                base.Row["Content"] = value;
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
        /// 获取用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取发送用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SenderID { get; private set; }

        /// <summary>
        /// 获取标题字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Title { get; private set; }

        /// <summary>
        /// 获取内容字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Content { get; private set; }

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
        public AosMessages() : base("AosMessages") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.SenderID = new dpz2.db.SqlUnits.TableField(this, "SenderID");
            this.Title = new dpz2.db.SqlUnits.TableField(this, "Title");
            this.Content = new dpz2.db.SqlUnits.TableField(this, "Content");
            this.SendTime = new dpz2.db.SqlUnits.TableField(this, "SendTime");
        }

    }

}
