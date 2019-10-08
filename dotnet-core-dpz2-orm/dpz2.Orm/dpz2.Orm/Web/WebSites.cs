using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web {

    /// <summary>
    /// 站点信息表
    /// 站点信息表
    /// Version 1604.1001
    /// </summary>
    public class WebSites : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 站点信息表 行数据操作器
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
            /// 设置网站名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置网站标志
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLogo(string value) {
                base.Row["Logo"] = value;
                return this;
            }

            /// <summary>
            /// 设置公司名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCompany(string value) {
                base.Row["Company"] = value;
                return this;
            }

            /// <summary>
            /// 设置公司简称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCompanyShort(string value) {
                base.Row["CompanyShort"] = value;
                return this;
            }

            /// <summary>
            /// 设置主体颜色
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetColor(string value) {
                base.Row["Color"] = value;
                return this;
            }

            /// <summary>
            /// 设置对比颜色
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetColorOver(string value) {
                base.Row["ColorOver"] = value;
                return this;
            }

            /// <summary>
            /// 设置搜索关键字
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetKeyWords(string value) {
                base.Row["KeyWords"] = value;
                return this;
            }

            /// <summary>
            /// 设置搜索描述
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDescription(string value) {
                base.Row["Description"] = value;
                return this;
            }

            /// <summary>
            /// 设置联系地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAddress(string value) {
                base.Row["Address"] = value;
                return this;
            }

            /// <summary>
            /// 设置联系电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhone(string value) {
                base.Row["Phone"] = value;
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
            /// 设置微信号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWeiXin(string value) {
                base.Row["WeiXin"] = value;
                return this;
            }

            /// <summary>
            /// 设置微信二维码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWeiXinCode(string value) {
                base.Row["WeiXinCode"] = value;
                return this;
            }

            /// <summary>
            /// 设置微博地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWeiBoUrl(string value) {
                base.Row["WeiBoUrl"] = value;
                return this;
            }

            /// <summary>
            /// 设置备案号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBeiAn(string value) {
                base.Row["BeiAn"] = value;
                return this;
            }

            /// <summary>
            /// 设置主页地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHomeHost(string value) {
                base.Row["HomeHost"] = value;
                return this;
            }

            /// <summary>
            /// 设置管理地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAzlosHost(string value) {
                base.Row["AzlosHost"] = value;
                return this;
            }

            /// <summary>
            /// 设置有效状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIsEnabled(string value) {
                base.Row["IsEnabled"] = value;
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
        /// 获取网站名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取网站标志字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Logo { get; private set; }

        /// <summary>
        /// 获取公司名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Company { get; private set; }

        /// <summary>
        /// 获取公司简称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CompanyShort { get; private set; }

        /// <summary>
        /// 获取主体颜色字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Color { get; private set; }

        /// <summary>
        /// 获取对比颜色字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ColorOver { get; private set; }

        /// <summary>
        /// 获取搜索关键字字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField KeyWords { get; private set; }

        /// <summary>
        /// 获取搜索描述字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Description { get; private set; }

        /// <summary>
        /// 获取联系地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Address { get; private set; }

        /// <summary>
        /// 获取联系电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取QQ字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField QQ { get; private set; }

        /// <summary>
        /// 获取邮箱字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EMail { get; private set; }

        /// <summary>
        /// 获取微信号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField WeiXin { get; private set; }

        /// <summary>
        /// 获取微信二维码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField WeiXinCode { get; private set; }

        /// <summary>
        /// 获取微博地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField WeiBoUrl { get; private set; }

        /// <summary>
        /// 获取备案号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BeiAn { get; private set; }

        /// <summary>
        /// 获取主页地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField HomeHost { get; private set; }

        /// <summary>
        /// 获取管理地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AzlosHost { get; private set; }

        /// <summary>
        /// 获取有效状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IsEnabled { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public WebSites() : base("WebSites") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Logo = new dpz2.db.SqlUnits.TableField(this, "Logo");
            this.Company = new dpz2.db.SqlUnits.TableField(this, "Company");
            this.CompanyShort = new dpz2.db.SqlUnits.TableField(this, "CompanyShort");
            this.Color = new dpz2.db.SqlUnits.TableField(this, "Color");
            this.ColorOver = new dpz2.db.SqlUnits.TableField(this, "ColorOver");
            this.KeyWords = new dpz2.db.SqlUnits.TableField(this, "KeyWords");
            this.Description = new dpz2.db.SqlUnits.TableField(this, "Description");
            this.Address = new dpz2.db.SqlUnits.TableField(this, "Address");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.QQ = new dpz2.db.SqlUnits.TableField(this, "QQ");
            this.EMail = new dpz2.db.SqlUnits.TableField(this, "EMail");
            this.WeiXin = new dpz2.db.SqlUnits.TableField(this, "WeiXin");
            this.WeiXinCode = new dpz2.db.SqlUnits.TableField(this, "WeiXinCode");
            this.WeiBoUrl = new dpz2.db.SqlUnits.TableField(this, "WeiBoUrl");
            this.BeiAn = new dpz2.db.SqlUnits.TableField(this, "BeiAn");
            this.HomeHost = new dpz2.db.SqlUnits.TableField(this, "HomeHost");
            this.AzlosHost = new dpz2.db.SqlUnits.TableField(this, "AzlosHost");
            this.IsEnabled = new dpz2.db.SqlUnits.TableField(this, "IsEnabled");
        }

    }

}
