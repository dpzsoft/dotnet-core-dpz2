using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Platform {

    /// <summary>
    /// 投票记录
    /// 投票记录
    /// Version 2016.0401
    /// </summary>
    public class PlatformVoteCast : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 投票记录 行数据操作器
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
            /// 设置用户编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关投票
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVoteID(string value) {
                base.Row["VoteID"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关投票项
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVoteItemID(string value) {
                base.Row["VoteItemID"] = value;
                return this;
            }

            /// <summary>
            /// 设置投票时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVoteTime(string value) {
                base.Row["VoteTime"] = value;
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
        /// 获取用户编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取相关投票字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField VoteID { get; private set; }

        /// <summary>
        /// 获取相关投票项字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField VoteItemID { get; private set; }

        /// <summary>
        /// 获取投票时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField VoteTime { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public PlatformVoteCast() : base("PlatformVoteCast") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.VoteID = new dpz2.db.SqlUnits.TableField(this, "VoteID");
            this.VoteItemID = new dpz2.db.SqlUnits.TableField(this, "VoteItemID");
            this.VoteTime = new dpz2.db.SqlUnits.TableField(this, "VoteTime");
        }

    }

}
