using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.EMail {

    /// <summary>
    /// 电子邮件账号
    /// 电子邮件账号
    /// Version 1801.0001
    /// </summary>
    public class EMailAccount : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 电子邮件账号 行数据操作器
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
            /// 设置所属用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置账号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAccount(string value) {
                base.Row["Account"] = value;
                return this;
            }

            /// <summary>
            /// 设置密码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPassword(string value) {
                base.Row["Password"] = value;
                return this;
            }

            /// <summary>
            /// 设置发送服务器
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSmtpServer(string value) {
                base.Row["SmtpServer"] = value;
                return this;
            }

            /// <summary>
            /// 设置发送服务器端口号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSmtpServerPort(string value) {
                base.Row["SmtpServerPort"] = value;
                return this;
            }

            /// <summary>
            /// 设置接收服务器
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPopServer(string value) {
                base.Row["PopServer"] = value;
                return this;
            }

            /// <summary>
            /// 设置接收服务器端口号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPopServerPort(string value) {
                base.Row["PopServerPort"] = value;
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
        /// 获取所属用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取账号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Account { get; private set; }

        /// <summary>
        /// 获取密码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Password { get; private set; }

        /// <summary>
        /// 获取发送服务器字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SmtpServer { get; private set; }

        /// <summary>
        /// 获取发送服务器端口号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SmtpServerPort { get; private set; }

        /// <summary>
        /// 获取接收服务器字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PopServer { get; private set; }

        /// <summary>
        /// 获取接收服务器端口号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PopServerPort { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public EMailAccount() : base("EMailAccount") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Account = new dpz2.db.SqlUnits.TableField(this, "Account");
            this.Password = new dpz2.db.SqlUnits.TableField(this, "Password");
            this.SmtpServer = new dpz2.db.SqlUnits.TableField(this, "SmtpServer");
            this.SmtpServerPort = new dpz2.db.SqlUnits.TableField(this, "SmtpServerPort");
            this.PopServer = new dpz2.db.SqlUnits.TableField(this, "PopServer");
            this.PopServerPort = new dpz2.db.SqlUnits.TableField(this, "PopServerPort");
        }

    }

}
