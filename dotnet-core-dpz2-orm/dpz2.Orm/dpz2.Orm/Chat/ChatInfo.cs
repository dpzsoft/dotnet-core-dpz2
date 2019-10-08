using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Chat {

    /// <summary>
    /// 聊天信息表
    /// 聊天信息表
    /// Version 1703.0002
    /// </summary>
    public class ChatInfo : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 聊天信息表 行数据操作器
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
            /// 设置聊天编码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCode(string value) {
                base.Row["Code"] = value;
                return this;
            }

            /// <summary>
            /// 设置申请者会话标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetApplySessionID(string value) {
                base.Row["ApplySessionID"] = value;
                return this;
            }

            /// <summary>
            /// 设置申请者标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetApplyUserID(string value) {
                base.Row["ApplyUserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置申请时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetApplyTime(string value) {
                base.Row["ApplyTime"] = value;
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
        /// 获取聊天编码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 获取申请者会话标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ApplySessionID { get; private set; }

        /// <summary>
        /// 获取申请者标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ApplyUserID { get; private set; }

        /// <summary>
        /// 获取申请时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ApplyTime { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public ChatInfo() : base("ChatInfo") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.ApplySessionID = new dpz2.db.SqlUnits.TableField(this, "ApplySessionID");
            this.ApplyUserID = new dpz2.db.SqlUnits.TableField(this, "ApplyUserID");
            this.ApplyTime = new dpz2.db.SqlUnits.TableField(this, "ApplyTime");
        }

    }

}
