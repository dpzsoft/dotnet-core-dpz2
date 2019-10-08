using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Platform {

    /// <summary>
    /// 投票项
    /// 投票项
    /// Version 2016.1004
    /// </summary>
    public class PlatformVoteItems : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 投票项 行数据操作器
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
            /// 设置名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关图像
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImage(string value) {
                base.Row["Image"] = value;
                return this;
            }

            /// <summary>
            /// 设置简介
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSummary(string value) {
                base.Row["Summary"] = value;
                return this;
            }

            /// <summary>
            /// 设置票数
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVotes(string value) {
                base.Row["Votes"] = value;
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
            /// 设置序号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIdx(string value) {
                base.Row["Idx"] = value;
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
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取相关图像字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Image { get; private set; }

        /// <summary>
        /// 获取简介字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Summary { get; private set; }

        /// <summary>
        /// 获取票数字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Votes { get; private set; }

        /// <summary>
        /// 获取相关投票字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField VoteID { get; private set; }

        /// <summary>
        /// 获取序号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Idx { get; private set; }

        /// <summary>
        /// 获取用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public PlatformVoteItems() : base("PlatformVoteItems") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Image = new dpz2.db.SqlUnits.TableField(this, "Image");
            this.Summary = new dpz2.db.SqlUnits.TableField(this, "Summary");
            this.Votes = new dpz2.db.SqlUnits.TableField(this, "Votes");
            this.VoteID = new dpz2.db.SqlUnits.TableField(this, "VoteID");
            this.Idx = new dpz2.db.SqlUnits.TableField(this, "Idx");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
        }

    }

}
