using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Weixin {

    /// <summary>
    /// 微信活动
    /// 微信活动
    /// Version 1705.0004
    /// </summary>
    public class WeixinActivity : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 微信活动 行数据操作器
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
            /// 设置微信用户标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置关注状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAttentionStatus(string value) {
                base.Row["AttentionStatus"] = value;
                return this;
            }

            /// <summary>
            /// 设置分享状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetShareStatus(string value) {
                base.Row["ShareStatus"] = value;
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

            /// <summary>
            /// 设置兑奖码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCode(string value) {
                base.Row["Code"] = value;
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
        /// 获取微信用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取关注状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AttentionStatus { get; private set; }

        /// <summary>
        /// 获取分享状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ShareStatus { get; private set; }

        /// <summary>
        /// 获取状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 获取兑奖码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public WeixinActivity() : base("WeixinActivity") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.AttentionStatus = new dpz2.db.SqlUnits.TableField(this, "AttentionStatus");
            this.ShareStatus = new dpz2.db.SqlUnits.TableField(this, "ShareStatus");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
        }

    }

}
