using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Loan {

    /// <summary>
    /// 客户信息
    /// 贷款客户信息
    /// Version 1707.0001
    /// </summary>
    public class LoanClient : dpz2.db.SqlUnits.Table {

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
            /// 设置姓名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份证号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCardID(string value) {
                base.Row["CardID"] = value;
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
            /// 设置地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAddress(string value) {
                base.Row["Address"] = value;
                return this;
            }

            /// <summary>
            /// 设置工作情况
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWork(string value) {
                base.Row["Work"] = value;
                return this;
            }

            /// <summary>
            /// 设置收入情况
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIncome(string value) {
                base.Row["Income"] = value;
                return this;
            }

            /// <summary>
            /// 设置配偶姓名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSpouseName(string value) {
                base.Row["SpouseName"] = value;
                return this;
            }

            /// <summary>
            /// 设置配偶电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSpousePhone(string value) {
                base.Row["SpousePhone"] = value;
                return this;
            }

            /// <summary>
            /// 设置配偶工作情况
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSpouseWork(string value) {
                base.Row["SpouseWork"] = value;
                return this;
            }

            /// <summary>
            /// 设置房屋属性
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHouseNature(string value) {
                base.Row["HouseNature"] = value;
                return this;
            }

            /// <summary>
            /// 设置房龄
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHouseAge(string value) {
                base.Row["HouseAge"] = value;
                return this;
            }

            /// <summary>
            /// 设置房屋地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHouseAddress(string value) {
                base.Row["HouseAddress"] = value;
                return this;
            }

            /// <summary>
            /// 设置房屋抵押情况
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHouseMortgage(string value) {
                base.Row["HouseMortgage"] = value;
                return this;
            }

            /// <summary>
            /// 设置汽车品牌
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCarBrand(string value) {
                base.Row["CarBrand"] = value;
                return this;
            }

            /// <summary>
            /// 设置车龄
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCarAge(string value) {
                base.Row["CarAge"] = value;
                return this;
            }

            /// <summary>
            /// 设置公里数
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCarKm(string value) {
                base.Row["CarKm"] = value;
                return this;
            }

            /// <summary>
            /// 设置汽车按揭期数
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCarMortgagePeriods(string value) {
                base.Row["CarMortgagePeriods"] = value;
                return this;
            }

            /// <summary>
            /// 设置汽车贷款金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCarMortgageMoney(string value) {
                base.Row["CarMortgageMoney"] = value;
                return this;
            }

            /// <summary>
            /// 设置汽车保险日期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCarInsuranceDate(string value) {
                base.Row["CarInsuranceDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置汽车保险公司
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCarInsuranceCompany(string value) {
                base.Row["CarInsuranceCompany"] = value;
                return this;
            }

            /// <summary>
            /// 设置汽车保费
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCarInsuranceMoney(string value) {
                base.Row["CarInsuranceMoney"] = value;
                return this;
            }

            /// <summary>
            /// 设置汽车保险缴期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCarInsurancePeriods(string value) {
                base.Row["CarInsurancePeriods"] = value;
                return this;
            }

            /// <summary>
            /// 设置公积金状况
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProvidentFund(string value) {
                base.Row["ProvidentFund"] = value;
                return this;
            }

            /// <summary>
            /// 设置社保状况
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSocialSecurity(string value) {
                base.Row["SocialSecurity"] = value;
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
        /// 获取身份证号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CardID { get; private set; }

        /// <summary>
        /// 获取联系电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Address { get; private set; }

        /// <summary>
        /// 获取工作情况字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Work { get; private set; }

        /// <summary>
        /// 获取收入情况字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Income { get; private set; }

        /// <summary>
        /// 获取配偶姓名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SpouseName { get; private set; }

        /// <summary>
        /// 获取配偶电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SpousePhone { get; private set; }

        /// <summary>
        /// 获取配偶工作情况字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SpouseWork { get; private set; }

        /// <summary>
        /// 获取房屋属性字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField HouseNature { get; private set; }

        /// <summary>
        /// 获取房龄字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField HouseAge { get; private set; }

        /// <summary>
        /// 获取房屋地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField HouseAddress { get; private set; }

        /// <summary>
        /// 获取房屋抵押情况字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField HouseMortgage { get; private set; }

        /// <summary>
        /// 获取汽车品牌字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CarBrand { get; private set; }

        /// <summary>
        /// 获取车龄字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CarAge { get; private set; }

        /// <summary>
        /// 获取公里数字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CarKm { get; private set; }

        /// <summary>
        /// 获取汽车按揭期数字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CarMortgagePeriods { get; private set; }

        /// <summary>
        /// 获取汽车贷款金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CarMortgageMoney { get; private set; }

        /// <summary>
        /// 获取汽车保险日期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CarInsuranceDate { get; private set; }

        /// <summary>
        /// 获取汽车保险公司字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CarInsuranceCompany { get; private set; }

        /// <summary>
        /// 获取汽车保费字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CarInsuranceMoney { get; private set; }

        /// <summary>
        /// 获取汽车保险缴期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CarInsurancePeriods { get; private set; }

        /// <summary>
        /// 获取公积金状况字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ProvidentFund { get; private set; }

        /// <summary>
        /// 获取社保状况字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SocialSecurity { get; private set; }

        /// <summary>
        /// 获取备注字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Remarks { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public LoanClient() : base("LoanClient") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.CardID = new dpz2.db.SqlUnits.TableField(this, "CardID");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.Address = new dpz2.db.SqlUnits.TableField(this, "Address");
            this.Work = new dpz2.db.SqlUnits.TableField(this, "Work");
            this.Income = new dpz2.db.SqlUnits.TableField(this, "Income");
            this.SpouseName = new dpz2.db.SqlUnits.TableField(this, "SpouseName");
            this.SpousePhone = new dpz2.db.SqlUnits.TableField(this, "SpousePhone");
            this.SpouseWork = new dpz2.db.SqlUnits.TableField(this, "SpouseWork");
            this.HouseNature = new dpz2.db.SqlUnits.TableField(this, "HouseNature");
            this.HouseAge = new dpz2.db.SqlUnits.TableField(this, "HouseAge");
            this.HouseAddress = new dpz2.db.SqlUnits.TableField(this, "HouseAddress");
            this.HouseMortgage = new dpz2.db.SqlUnits.TableField(this, "HouseMortgage");
            this.CarBrand = new dpz2.db.SqlUnits.TableField(this, "CarBrand");
            this.CarAge = new dpz2.db.SqlUnits.TableField(this, "CarAge");
            this.CarKm = new dpz2.db.SqlUnits.TableField(this, "CarKm");
            this.CarMortgagePeriods = new dpz2.db.SqlUnits.TableField(this, "CarMortgagePeriods");
            this.CarMortgageMoney = new dpz2.db.SqlUnits.TableField(this, "CarMortgageMoney");
            this.CarInsuranceDate = new dpz2.db.SqlUnits.TableField(this, "CarInsuranceDate");
            this.CarInsuranceCompany = new dpz2.db.SqlUnits.TableField(this, "CarInsuranceCompany");
            this.CarInsuranceMoney = new dpz2.db.SqlUnits.TableField(this, "CarInsuranceMoney");
            this.CarInsurancePeriods = new dpz2.db.SqlUnits.TableField(this, "CarInsurancePeriods");
            this.ProvidentFund = new dpz2.db.SqlUnits.TableField(this, "ProvidentFund");
            this.SocialSecurity = new dpz2.db.SqlUnits.TableField(this, "SocialSecurity");
            this.Remarks = new dpz2.db.SqlUnits.TableField(this, "Remarks");
        }

    }

}
