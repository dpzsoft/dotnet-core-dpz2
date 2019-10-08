using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Mall {

    /// <summary>
    /// 商城用户表
    /// 商城用户表
    /// Version 1709.0010
    /// </summary>
    public class MallUsers : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商城用户表 行数据操作器
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
            /// 设置用户识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置余额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBalance(string value) {
                base.Row["Balance"] = value;
                return this;
            }

            /// <summary>
            /// 设置手机号码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhone(string value) {
                base.Row["Phone"] = value;
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
            /// 设置姓名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRealName(string value) {
                base.Row["RealName"] = value;
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
            /// 设置生日
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBirthday(string value) {
                base.Row["Birthday"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份证
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIDCard(string value) {
                base.Row["IDCard"] = value;
                return this;
            }

            /// <summary>
            /// 设置问题一
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAsk1(string value) {
                base.Row["Ask1"] = value;
                return this;
            }

            /// <summary>
            /// 设置回答一
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAnswer1(string value) {
                base.Row["Answer1"] = value;
                return this;
            }

            /// <summary>
            /// 设置问题二
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAsk2(string value) {
                base.Row["Ask2"] = value;
                return this;
            }

            /// <summary>
            /// 设置回答二
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAnswer2(string value) {
                base.Row["Answer2"] = value;
                return this;
            }

            /// <summary>
            /// 设置问题三
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAsk3(string value) {
                base.Row["Ask3"] = value;
                return this;
            }

            /// <summary>
            /// 设置回答三
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAnswer3(string value) {
                base.Row["Answer3"] = value;
                return this;
            }

            /// <summary>
            /// 设置手机认证
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhoneAuth(string value) {
                base.Row["PhoneAuth"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份认证
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIDAuth(string value) {
                base.Row["IDAuth"] = value;
                return this;
            }

            /// <summary>
            /// 设置邮箱认证
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEMailAuth(string value) {
                base.Row["EMailAuth"] = value;
                return this;
            }

            /// <summary>
            /// 设置用户等级
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLv(string value) {
                base.Row["Lv"] = value;
                return this;
            }

            /// <summary>
            /// 设置等级相关经验
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLvExp(string value) {
                base.Row["LvExp"] = value;
                return this;
            }

            /// <summary>
            /// 设置默认联系方式
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetContact(string value) {
                base.Row["Contact"] = value;
                return this;
            }

            /// <summary>
            /// 设置用户状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStatus(string value) {
                base.Row["Status"] = value;
                return this;
            }

            /// <summary>
            /// 设置注册时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCreateTime(string value) {
                base.Row["CreateTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置手机认证时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhoneAuthTime(string value) {
                base.Row["PhoneAuthTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份认证时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIDAuthTime(string value) {
                base.Row["IDAuthTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置邮箱认证时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEMailAuthTime(string value) {
                base.Row["EMailAuthTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置微信用户识别号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOpenID(string value) {
                base.Row["OpenID"] = value;
                return this;
            }

            /// <summary>
            /// 设置标志
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFlag(string value) {
                base.Row["Flag"] = value;
                return this;
            }

            /// <summary>
            /// 设置用户头像
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLogo(string value) {
                base.Row["Logo"] = value;
                return this;
            }

            /// <summary>
            /// 设置推广信息
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSpreadID(string value) {
                base.Row["SpreadID"] = value;
                return this;
            }

            /// <summary>
            /// 设置充值累计金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAllMoney(string value) {
                base.Row["AllMoney"] = value;
                return this;
            }

            /// <summary>
            /// 设置消费累计金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBuyMoney(string value) {
                base.Row["BuyMoney"] = value;
                return this;
            }

            /// <summary>
            /// 设置幸运金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLuckyMoney(string value) {
                base.Row["LuckyMoney"] = value;
                return this;
            }

            /// <summary>
            /// 设置积分
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIntegral(string value) {
                base.Row["Integral"] = value;
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
        /// 获取用户识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取余额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Balance { get; private set; }

        /// <summary>
        /// 获取手机号码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取邮箱字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EMail { get; private set; }

        /// <summary>
        /// 获取姓名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RealName { get; private set; }

        /// <summary>
        /// 获取性别字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Sex { get; private set; }

        /// <summary>
        /// 获取生日字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Birthday { get; private set; }

        /// <summary>
        /// 获取身份证字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IDCard { get; private set; }

        /// <summary>
        /// 获取问题一字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Ask1 { get; private set; }

        /// <summary>
        /// 获取回答一字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Answer1 { get; private set; }

        /// <summary>
        /// 获取问题二字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Ask2 { get; private set; }

        /// <summary>
        /// 获取回答二字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Answer2 { get; private set; }

        /// <summary>
        /// 获取问题三字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Ask3 { get; private set; }

        /// <summary>
        /// 获取回答三字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Answer3 { get; private set; }

        /// <summary>
        /// 获取手机认证字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PhoneAuth { get; private set; }

        /// <summary>
        /// 获取身份认证字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IDAuth { get; private set; }

        /// <summary>
        /// 获取邮箱认证字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EMailAuth { get; private set; }

        /// <summary>
        /// 获取用户等级字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Lv { get; private set; }

        /// <summary>
        /// 获取等级相关经验字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LvExp { get; private set; }

        /// <summary>
        /// 获取默认联系方式字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Contact { get; private set; }

        /// <summary>
        /// 获取用户状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 获取注册时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取手机认证时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PhoneAuthTime { get; private set; }

        /// <summary>
        /// 获取身份认证时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IDAuthTime { get; private set; }

        /// <summary>
        /// 获取邮箱认证时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EMailAuthTime { get; private set; }

        /// <summary>
        /// 获取微信用户识别号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OpenID { get; private set; }

        /// <summary>
        /// 获取标志字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Flag { get; private set; }

        /// <summary>
        /// 获取用户头像字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Logo { get; private set; }

        /// <summary>
        /// 获取推广信息字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SpreadID { get; private set; }

        /// <summary>
        /// 获取充值累计金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AllMoney { get; private set; }

        /// <summary>
        /// 获取消费累计金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BuyMoney { get; private set; }

        /// <summary>
        /// 获取幸运金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LuckyMoney { get; private set; }

        /// <summary>
        /// 获取积分字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Integral { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public MallUsers() : base("MallUsers") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Balance = new dpz2.db.SqlUnits.TableField(this, "Balance");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.EMail = new dpz2.db.SqlUnits.TableField(this, "EMail");
            this.RealName = new dpz2.db.SqlUnits.TableField(this, "RealName");
            this.Sex = new dpz2.db.SqlUnits.TableField(this, "Sex");
            this.Birthday = new dpz2.db.SqlUnits.TableField(this, "Birthday");
            this.IDCard = new dpz2.db.SqlUnits.TableField(this, "IDCard");
            this.Ask1 = new dpz2.db.SqlUnits.TableField(this, "Ask1");
            this.Answer1 = new dpz2.db.SqlUnits.TableField(this, "Answer1");
            this.Ask2 = new dpz2.db.SqlUnits.TableField(this, "Ask2");
            this.Answer2 = new dpz2.db.SqlUnits.TableField(this, "Answer2");
            this.Ask3 = new dpz2.db.SqlUnits.TableField(this, "Ask3");
            this.Answer3 = new dpz2.db.SqlUnits.TableField(this, "Answer3");
            this.PhoneAuth = new dpz2.db.SqlUnits.TableField(this, "PhoneAuth");
            this.IDAuth = new dpz2.db.SqlUnits.TableField(this, "IDAuth");
            this.EMailAuth = new dpz2.db.SqlUnits.TableField(this, "EMailAuth");
            this.Lv = new dpz2.db.SqlUnits.TableField(this, "Lv");
            this.LvExp = new dpz2.db.SqlUnits.TableField(this, "LvExp");
            this.Contact = new dpz2.db.SqlUnits.TableField(this, "Contact");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.PhoneAuthTime = new dpz2.db.SqlUnits.TableField(this, "PhoneAuthTime");
            this.IDAuthTime = new dpz2.db.SqlUnits.TableField(this, "IDAuthTime");
            this.EMailAuthTime = new dpz2.db.SqlUnits.TableField(this, "EMailAuthTime");
            this.OpenID = new dpz2.db.SqlUnits.TableField(this, "OpenID");
            this.Flag = new dpz2.db.SqlUnits.TableField(this, "Flag");
            this.Logo = new dpz2.db.SqlUnits.TableField(this, "Logo");
            this.SpreadID = new dpz2.db.SqlUnits.TableField(this, "SpreadID");
            this.AllMoney = new dpz2.db.SqlUnits.TableField(this, "AllMoney");
            this.BuyMoney = new dpz2.db.SqlUnits.TableField(this, "BuyMoney");
            this.LuckyMoney = new dpz2.db.SqlUnits.TableField(this, "LuckyMoney");
            this.Integral = new dpz2.db.SqlUnits.TableField(this, "Integral");
        }

    }

}
