using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Platform {

    /// <summary>
    /// 平台商铺表
    /// 平台商铺表
    /// Version 1.1.1905.10
    /// </summary>
    public class PlatformShop : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 平台商铺表 行数据操作器
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
            /// 设置地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAddress(string value) {
                base.Row["Address"] = value;
                return this;
            }

            /// <summary>
            /// 设置楼层
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFloor(string value) {
                base.Row["Floor"] = value;
                return this;
            }

            /// <summary>
            /// 设置手机
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhone(string value) {
                base.Row["Phone"] = value;
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
            /// 设置图标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLogo(string value) {
                base.Row["Logo"] = value;
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
            /// 设置固定电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTel(string value) {
                base.Row["Tel"] = value;
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
            /// 设置邮箱
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEmail(string value) {
                base.Row["Email"] = value;
                return this;
            }

            /// <summary>
            /// 设置商铺网站
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHomePage(string value) {
                base.Row["HomePage"] = value;
                return this;
            }

            /// <summary>
            /// 设置详情
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDetail(string value) {
                base.Row["Detail"] = value;
                return this;
            }

            /// <summary>
            /// 设置排名权重
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRank(string value) {
                base.Row["Rank"] = value;
                return this;
            }

            /// <summary>
            /// 设置联系人
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhoneContacts(string value) {
                base.Row["PhoneContacts"] = value;
                return this;
            }

            /// <summary>
            /// 设置形象图片
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImage(string value) {
                base.Row["Image"] = value;
                return this;
            }

            /// <summary>
            /// 设置党员经营户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPartyMember(string value) {
                base.Row["PartyMember"] = value;
                return this;
            }

            /// <summary>
            /// 设置精选
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetChosen(string value) {
                base.Row["Chosen"] = value;
                return this;
            }

            /// <summary>
            /// 设置精选图片
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetChosenImage(string value) {
                base.Row["ChosenImage"] = value;
                return this;
            }

            /// <summary>
            /// 设置精选广告语
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetChosenAd(string value) {
                base.Row["ChosenAd"] = value;
                return this;
            }

            /// <summary>
            /// 设置旗舰店
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVIP(string value) {
                base.Row["VIP"] = value;
                return this;
            }

            /// <summary>
            /// 设置黑名单
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBlack(string value) {
                base.Row["Black"] = value;
                return this;
            }

            /// <summary>
            /// 设置访问量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVisit(string value) {
                base.Row["Visit"] = value;
                return this;
            }

            /// <summary>
            /// 设置收藏量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFocus(string value) {
                base.Row["Focus"] = value;
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
        /// 获取地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Address { get; private set; }

        /// <summary>
        /// 获取楼层字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Floor { get; private set; }

        /// <summary>
        /// 获取手机字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取简介字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Summary { get; private set; }

        /// <summary>
        /// 获取图标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Logo { get; private set; }

        /// <summary>
        /// 获取搜索关键字字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField KeyWords { get; private set; }

        /// <summary>
        /// 获取固定电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Tel { get; private set; }

        /// <summary>
        /// 获取传真字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Fax { get; private set; }

        /// <summary>
        /// 获取邮箱字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Email { get; private set; }

        /// <summary>
        /// 获取商铺网站字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField HomePage { get; private set; }

        /// <summary>
        /// 获取详情字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Detail { get; private set; }

        /// <summary>
        /// 获取排名权重字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Rank { get; private set; }

        /// <summary>
        /// 获取联系人字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PhoneContacts { get; private set; }

        /// <summary>
        /// 获取形象图片字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Image { get; private set; }

        /// <summary>
        /// 获取党员经营户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PartyMember { get; private set; }

        /// <summary>
        /// 获取精选字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Chosen { get; private set; }

        /// <summary>
        /// 获取精选图片字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ChosenImage { get; private set; }

        /// <summary>
        /// 获取精选广告语字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ChosenAd { get; private set; }

        /// <summary>
        /// 获取旗舰店字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField VIP { get; private set; }

        /// <summary>
        /// 获取黑名单字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Black { get; private set; }

        /// <summary>
        /// 获取访问量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Visit { get; private set; }

        /// <summary>
        /// 获取收藏量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Focus { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public PlatformShop() : base("PlatformShop") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Address = new dpz2.db.SqlUnits.TableField(this, "Address");
            this.Floor = new dpz2.db.SqlUnits.TableField(this, "Floor");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.Summary = new dpz2.db.SqlUnits.TableField(this, "Summary");
            this.Logo = new dpz2.db.SqlUnits.TableField(this, "Logo");
            this.KeyWords = new dpz2.db.SqlUnits.TableField(this, "KeyWords");
            this.Tel = new dpz2.db.SqlUnits.TableField(this, "Tel");
            this.Fax = new dpz2.db.SqlUnits.TableField(this, "Fax");
            this.Email = new dpz2.db.SqlUnits.TableField(this, "Email");
            this.HomePage = new dpz2.db.SqlUnits.TableField(this, "HomePage");
            this.Detail = new dpz2.db.SqlUnits.TableField(this, "Detail");
            this.Rank = new dpz2.db.SqlUnits.TableField(this, "Rank");
            this.PhoneContacts = new dpz2.db.SqlUnits.TableField(this, "PhoneContacts");
            this.Image = new dpz2.db.SqlUnits.TableField(this, "Image");
            this.PartyMember = new dpz2.db.SqlUnits.TableField(this, "PartyMember");
            this.Chosen = new dpz2.db.SqlUnits.TableField(this, "Chosen");
            this.ChosenImage = new dpz2.db.SqlUnits.TableField(this, "ChosenImage");
            this.ChosenAd = new dpz2.db.SqlUnits.TableField(this, "ChosenAd");
            this.VIP = new dpz2.db.SqlUnits.TableField(this, "VIP");
            this.Black = new dpz2.db.SqlUnits.TableField(this, "Black");
            this.Visit = new dpz2.db.SqlUnits.TableField(this, "Visit");
            this.Focus = new dpz2.db.SqlUnits.TableField(this, "Focus");
        }

    }

}
