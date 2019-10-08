using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Weixin {

    /// <summary>
    /// 微信用户
    /// 微信用户
    /// Version 1807.0005
    /// </summary>
    public class WeixinUsers : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 微信用户 行数据操作器
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
            /// 设置唯一识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOpenID(string value) {
                base.Row["OpenID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属平台
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPlatform(string value) {
                base.Row["Platform"] = value;
                return this;
            }

            /// <summary>
            /// 设置管理用户识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetManagerID(string value) {
                base.Row["ManagerID"] = value;
                return this;
            }

            /// <summary>
            /// 设置实例用户识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置会员用户识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMemberID(string value) {
                base.Row["MemberID"] = value;
                return this;
            }

            /// <summary>
            /// 设置昵称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetNick(string value) {
                base.Row["Nick"] = value;
                return this;
            }

            /// <summary>
            /// 设置性别
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSex(string value) {
                base.Row["Sex"] = value;
                return this;
            }

            /// <summary>
            /// 设置省份
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProvince(string value) {
                base.Row["Province"] = value;
                return this;
            }

            /// <summary>
            /// 设置城市
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCity(string value) {
                base.Row["City"] = value;
                return this;
            }

            /// <summary>
            /// 设置国家
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCountry(string value) {
                base.Row["Country"] = value;
                return this;
            }

            /// <summary>
            /// 设置头像地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHeadImgUrl(string value) {
                base.Row["HeadImgUrl"] = value;
                return this;
            }

            /// <summary>
            /// 设置特权信息
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPrivilege(string value) {
                base.Row["Privilege"] = value;
                return this;
            }

            /// <summary>
            /// 设置绑定账号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUnionID(string value) {
                base.Row["UnionID"] = value;
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
            /// 设置最后访问时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLastVisitTime(string value) {
                base.Row["LastVisitTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置手机号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhone(string value) {
                base.Row["Phone"] = value;
                return this;
            }

            /// <summary>
            /// 设置推广员
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSpreadName(string value) {
                base.Row["SpreadName"] = value;
                return this;
            }

            /// <summary>
            /// 设置推广员单位
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSpreadUnit(string value) {
                base.Row["SpreadUnit"] = value;
                return this;
            }

            /// <summary>
            /// 设置推广员编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSpreadID(string value) {
                base.Row["SpreadID"] = value;
                return this;
            }

            /// <summary>
            /// 设置黑名单
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBlacklist(string value) {
                base.Row["Blacklist"] = value;
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
        /// 获取唯一识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OpenID { get; private set; }

        /// <summary>
        /// 获取所属平台字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Platform { get; private set; }

        /// <summary>
        /// 获取管理用户识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ManagerID { get; private set; }

        /// <summary>
        /// 获取实例用户识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取会员用户识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField MemberID { get; private set; }

        /// <summary>
        /// 获取昵称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Nick { get; private set; }

        /// <summary>
        /// 获取性别字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Sex { get; private set; }

        /// <summary>
        /// 获取省份字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Province { get; private set; }

        /// <summary>
        /// 获取城市字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField City { get; private set; }

        /// <summary>
        /// 获取国家字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Country { get; private set; }

        /// <summary>
        /// 获取头像地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField HeadImgUrl { get; private set; }

        /// <summary>
        /// 获取特权信息字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Privilege { get; private set; }

        /// <summary>
        /// 获取绑定账号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UnionID { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取最后访问时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LastVisitTime { get; private set; }

        /// <summary>
        /// 获取手机号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取推广员字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SpreadName { get; private set; }

        /// <summary>
        /// 获取推广员单位字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SpreadUnit { get; private set; }

        /// <summary>
        /// 获取推广员编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SpreadID { get; private set; }

        /// <summary>
        /// 获取黑名单字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Blacklist { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public WeixinUsers() : base("WeixinUsers") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.OpenID = new dpz2.db.SqlUnits.TableField(this, "OpenID");
            this.Platform = new dpz2.db.SqlUnits.TableField(this, "Platform");
            this.ManagerID = new dpz2.db.SqlUnits.TableField(this, "ManagerID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.MemberID = new dpz2.db.SqlUnits.TableField(this, "MemberID");
            this.Nick = new dpz2.db.SqlUnits.TableField(this, "Nick");
            this.Sex = new dpz2.db.SqlUnits.TableField(this, "Sex");
            this.Province = new dpz2.db.SqlUnits.TableField(this, "Province");
            this.City = new dpz2.db.SqlUnits.TableField(this, "City");
            this.Country = new dpz2.db.SqlUnits.TableField(this, "Country");
            this.HeadImgUrl = new dpz2.db.SqlUnits.TableField(this, "HeadImgUrl");
            this.Privilege = new dpz2.db.SqlUnits.TableField(this, "Privilege");
            this.UnionID = new dpz2.db.SqlUnits.TableField(this, "UnionID");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.LastVisitTime = new dpz2.db.SqlUnits.TableField(this, "LastVisitTime");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.SpreadName = new dpz2.db.SqlUnits.TableField(this, "SpreadName");
            this.SpreadUnit = new dpz2.db.SqlUnits.TableField(this, "SpreadUnit");
            this.SpreadID = new dpz2.db.SqlUnits.TableField(this, "SpreadID");
            this.Blacklist = new dpz2.db.SqlUnits.TableField(this, "Blacklist");
        }

    }

}
