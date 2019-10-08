using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Jxc {

    /// <summary>
    /// 客户信息
    /// 存储所有的客户信息
    /// Version 1702.0001
    /// </summary>
    public class JxcClients : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 客户信息 行数据操作器
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
            /// 设置编码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCode(string value) {
                base.Row["Code"] = value;
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
            /// 设置公司
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCompany(string value) {
                base.Row["Company"] = value;
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
            /// 设置电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhone(string value) {
                base.Row["Phone"] = value;
                return this;
            }

            /// <summary>
            /// 设置传真
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFax(string value) {
                base.Row["Fax"] = value;
                return this;
            }

            /// <summary>
            /// 设置QQ
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetQQ(string value) {
                base.Row["QQ"] = value;
                return this;
            }

            /// <summary>
            /// 设置邮箱
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEMail(string value) {
                base.Row["EMail"] = value;
                return this;
            }

            /// <summary>
            /// 设置微博
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWeiBo(string value) {
                base.Row["WeiBo"] = value;
                return this;
            }

            /// <summary>
            /// 设置微信
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWeixin(string value) {
                base.Row["Weixin"] = value;
                return this;
            }

            /// <summary>
            /// 设置网站
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWebSite(string value) {
                base.Row["WebSite"] = value;
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

            /// <summary>
            /// 设置应收款
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetReceivables(string value) {
                base.Row["Receivables"] = value;
                return this;
            }

            /// <summary>
            /// 设置备注
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRemarks(string value) {
                base.Row["Remarks"] = value;
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
        /// 获取编码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取公司字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Company { get; private set; }

        /// <summary>
        /// 获取地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Address { get; private set; }

        /// <summary>
        /// 获取电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取传真字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Fax { get; private set; }

        /// <summary>
        /// 获取QQ字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField QQ { get; private set; }

        /// <summary>
        /// 获取邮箱字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EMail { get; private set; }

        /// <summary>
        /// 获取微博字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField WeiBo { get; private set; }

        /// <summary>
        /// 获取微信字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Weixin { get; private set; }

        /// <summary>
        /// 获取网站字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField WebSite { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取应收款字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Receivables { get; private set; }

        /// <summary>
        /// 获取备注字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Remarks { get; private set; }

        /// <summary>
        /// 获取状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public JxcClients() : base("JxcClients") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Company = new dpz2.db.SqlUnits.TableField(this, "Company");
            this.Address = new dpz2.db.SqlUnits.TableField(this, "Address");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.Fax = new dpz2.db.SqlUnits.TableField(this, "Fax");
            this.QQ = new dpz2.db.SqlUnits.TableField(this, "QQ");
            this.EMail = new dpz2.db.SqlUnits.TableField(this, "EMail");
            this.WeiBo = new dpz2.db.SqlUnits.TableField(this, "WeiBo");
            this.Weixin = new dpz2.db.SqlUnits.TableField(this, "Weixin");
            this.WebSite = new dpz2.db.SqlUnits.TableField(this, "WebSite");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.Receivables = new dpz2.db.SqlUnits.TableField(this, "Receivables");
            this.Remarks = new dpz2.db.SqlUnits.TableField(this, "Remarks");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
