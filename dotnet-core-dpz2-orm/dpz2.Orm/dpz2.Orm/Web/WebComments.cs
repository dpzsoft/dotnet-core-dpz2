using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web {

    /// <summary>
    /// 网站留言表
    /// 网站留言表
    /// Version 1603.3102
    /// </summary>
    public class WebComments : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 网站留言表 行数据操作器
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
            /// 设置姓名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置邮箱
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEmail(string value) {
                base.Row["Email"] = value;
                return this;
            }

            /// <summary>
            /// 设置电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhone(string value) {
                base.Row["Phone"] = value;
                return this;
            }

            /// <summary>
            /// 设置地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAddress(string value) {
                base.Row["Address"] = value;
                return this;
            }

            /// <summary>
            /// 设置内容
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSummary(string value) {
                base.Row["Summary"] = value;
                return this;
            }

            /// <summary>
            /// 设置回复对象
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetReplyID(string value) {
                base.Row["ReplyID"] = value;
                return this;
            }

            /// <summary>
            /// 设置提交时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetApplyTime(string value) {
                base.Row["ApplyTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置提交地点
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetApplyCity(string value) {
                base.Row["ApplyCity"] = value;
                return this;
            }

            /// <summary>
            /// 设置提交IP地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetApplyIP(string value) {
                base.Row["ApplyIP"] = value;
                return this;
            }

            /// <summary>
            /// 设置回复
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetReply(string value) {
                base.Row["Reply"] = value;
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
        /// 获取姓名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取邮箱字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Email { get; private set; }

        /// <summary>
        /// 获取电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Address { get; private set; }

        /// <summary>
        /// 获取内容字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Summary { get; private set; }

        /// <summary>
        /// 获取回复对象字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ReplyID { get; private set; }

        /// <summary>
        /// 获取提交时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ApplyTime { get; private set; }

        /// <summary>
        /// 获取提交地点字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ApplyCity { get; private set; }

        /// <summary>
        /// 获取提交IP地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ApplyIP { get; private set; }

        /// <summary>
        /// 获取回复字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Reply { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public WebComments() : base("WebComments") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Email = new dpz2.db.SqlUnits.TableField(this, "Email");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.Address = new dpz2.db.SqlUnits.TableField(this, "Address");
            this.Summary = new dpz2.db.SqlUnits.TableField(this, "Summary");
            this.ReplyID = new dpz2.db.SqlUnits.TableField(this, "ReplyID");
            this.ApplyTime = new dpz2.db.SqlUnits.TableField(this, "ApplyTime");
            this.ApplyCity = new dpz2.db.SqlUnits.TableField(this, "ApplyCity");
            this.ApplyIP = new dpz2.db.SqlUnits.TableField(this, "ApplyIP");
            this.Reply = new dpz2.db.SqlUnits.TableField(this, "Reply");
        }

    }

}
