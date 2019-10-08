using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.EMail {

    /// <summary>
    /// 电子邮件信息
    /// 电子邮件信息
    /// Version 1801.0002
    /// </summary>
    public class EMailInfo : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 电子邮件信息 行数据操作器
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
            /// 设置所属账号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAccountID(string value) {
                base.Row["AccountID"] = value;
                return this;
            }

            /// <summary>
            /// 设置唯一标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUid(string value) {
                base.Row["Uid"] = value;
                return this;
            }

            /// <summary>
            /// 设置发件人
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFromAddress(string value) {
                base.Row["FromAddress"] = value;
                return this;
            }

            /// <summary>
            /// 设置抄送人
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCCAddress(string value) {
                base.Row["CCAddress"] = value;
                return this;
            }

            /// <summary>
            /// 设置主题
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSubject(string value) {
                base.Row["Subject"] = value;
                return this;
            }

            /// <summary>
            /// 设置内容
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBody(string value) {
                base.Row["Body"] = value;
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
        /// 获取所属账号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AccountID { get; private set; }

        /// <summary>
        /// 获取唯一标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Uid { get; private set; }

        /// <summary>
        /// 获取发件人字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FromAddress { get; private set; }

        /// <summary>
        /// 获取抄送人字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CCAddress { get; private set; }

        /// <summary>
        /// 获取主题字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Subject { get; private set; }

        /// <summary>
        /// 获取内容字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Body { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public EMailInfo() : base("EMailInfo") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.AccountID = new dpz2.db.SqlUnits.TableField(this, "AccountID");
            this.Uid = new dpz2.db.SqlUnits.TableField(this, "Uid");
            this.FromAddress = new dpz2.db.SqlUnits.TableField(this, "FromAddress");
            this.CCAddress = new dpz2.db.SqlUnits.TableField(this, "CCAddress");
            this.Subject = new dpz2.db.SqlUnits.TableField(this, "Subject");
            this.Body = new dpz2.db.SqlUnits.TableField(this, "Body");
        }

    }

}
