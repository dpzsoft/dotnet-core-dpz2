using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.CPA {

    /// <summary>
    /// 企业基本信息
    /// 企业基本信息
    /// Version 1712.0002
    /// </summary>
    public class CPAClient : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 企业基本信息 行数据操作器
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
            /// 设置客户编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCode(string value) {
                base.Row["Code"] = value;
                return this;
            }

            /// <summary>
            /// 设置单位名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属部门
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDepartmentID(string value) {
                base.Row["DepartmentID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属职位
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPositionID(string value) {
                base.Row["PositionID"] = value;
                return this;
            }

            /// <summary>
            /// 设置国税编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTaxCode(string value) {
                base.Row["TaxCode"] = value;
                return this;
            }

            /// <summary>
            /// 设置地税编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRentCode(string value) {
                base.Row["RentCode"] = value;
                return this;
            }

            /// <summary>
            /// 设置法人代表
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRepresentative(string value) {
                base.Row["Representative"] = value;
                return this;
            }

            /// <summary>
            /// 设置行业
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIndustry(string value) {
                base.Row["Industry"] = value;
                return this;
            }

            /// <summary>
            /// 设置公司类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCompanyType(string value) {
                base.Row["CompanyType"] = value;
                return this;
            }

            /// <summary>
            /// 设置注册地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRegAddress(string value) {
                base.Row["RegAddress"] = value;
                return this;
            }

            /// <summary>
            /// 设置开业日期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOpenedDate(string value) {
                base.Row["OpenedDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置法人代表电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRepresentativeTel(string value) {
                base.Row["RepresentativeTel"] = value;
                return this;
            }

            /// <summary>
            /// 设置公司电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCompanyTel(string value) {
                base.Row["CompanyTel"] = value;
                return this;
            }

            /// <summary>
            /// 设置联系人电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetContactsTel(string value) {
                base.Row["ContactsTel"] = value;
                return this;
            }

            /// <summary>
            /// 设置最初认定一般纳税人时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTaxDate(string value) {
                base.Row["TaxDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置批准工商执照机关
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTradeBureau(string value) {
                base.Row["TradeBureau"] = value;
                return this;
            }

            /// <summary>
            /// 设置营业执照号码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTradeCode(string value) {
                base.Row["TradeCode"] = value;
                return this;
            }

            /// <summary>
            /// 设置营业执照有效期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTradeDate(string value) {
                base.Row["TradeDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置批准组织机构代码证机关
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGroupBureau(string value) {
                base.Row["GroupBureau"] = value;
                return this;
            }

            /// <summary>
            /// 设置组织机构代码证号码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGroupCode(string value) {
                base.Row["GroupCode"] = value;
                return this;
            }

            /// <summary>
            /// 设置组织机构代码证有效期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGroupDate(string value) {
                base.Row["GroupDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置经营范围
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBusiness(string value) {
                base.Row["Business"] = value;
                return this;
            }

            /// <summary>
            /// 设置注册资金(万元)
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRegMoney(string value) {
                base.Row["RegMoney"] = value;
                return this;
            }

            /// <summary>
            /// 设置币种
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRegType(string value) {
                base.Row["RegType"] = value;
                return this;
            }

            /// <summary>
            /// 设置国税税所
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTaxOffice(string value) {
                base.Row["TaxOffice"] = value;
                return this;
            }

            /// <summary>
            /// 设置国税专管员
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTaxManager(string value) {
                base.Row["TaxManager"] = value;
                return this;
            }

            /// <summary>
            /// 设置国税分局
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTaxBureau(string value) {
                base.Row["TaxBureau"] = value;
                return this;
            }

            /// <summary>
            /// 设置国税专管员电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTaxManagerTel(string value) {
                base.Row["TaxManagerTel"] = value;
                return this;
            }

            /// <summary>
            /// 设置国税备注
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTaxDescription(string value) {
                base.Row["TaxDescription"] = value;
                return this;
            }

            /// <summary>
            /// 设置地税税所
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRentOffice(string value) {
                base.Row["RentOffice"] = value;
                return this;
            }

            /// <summary>
            /// 设置地税专管员
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRentManager(string value) {
                base.Row["RentManager"] = value;
                return this;
            }

            /// <summary>
            /// 设置地税分局
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRentBureau(string value) {
                base.Row["RentBureau"] = value;
                return this;
            }

            /// <summary>
            /// 设置地税专管员电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRentManagerTel(string value) {
                base.Row["RentManagerTel"] = value;
                return this;
            }

            /// <summary>
            /// 设置地税备注
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRentDescription(string value) {
                base.Row["RentDescription"] = value;
                return this;
            }

            /// <summary>
            /// 设置职工人数
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStaffNum(string value) {
                base.Row["StaffNum"] = value;
                return this;
            }

            /// <summary>
            /// 设置汽车数量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCarNum(string value) {
                base.Row["CarNum"] = value;
                return this;
            }

            /// <summary>
            /// 设置车牌号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCarCode(string value) {
                base.Row["CarCode"] = value;
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
            /// 设置操作时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOperateTime(string value) {
                base.Row["OperateTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOperateStatus(string value) {
                base.Row["OperateStatus"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作人员
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOperateUser(string value) {
                base.Row["OperateUser"] = value;
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
        /// 获取客户编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 获取单位名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取所属部门字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DepartmentID { get; private set; }

        /// <summary>
        /// 获取所属职位字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PositionID { get; private set; }

        /// <summary>
        /// 获取国税编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TaxCode { get; private set; }

        /// <summary>
        /// 获取地税编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RentCode { get; private set; }

        /// <summary>
        /// 获取法人代表字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Representative { get; private set; }

        /// <summary>
        /// 获取行业字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Industry { get; private set; }

        /// <summary>
        /// 获取公司类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CompanyType { get; private set; }

        /// <summary>
        /// 获取注册地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RegAddress { get; private set; }

        /// <summary>
        /// 获取开业日期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OpenedDate { get; private set; }

        /// <summary>
        /// 获取法人代表电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RepresentativeTel { get; private set; }

        /// <summary>
        /// 获取公司电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CompanyTel { get; private set; }

        /// <summary>
        /// 获取联系人电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ContactsTel { get; private set; }

        /// <summary>
        /// 获取最初认定一般纳税人时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TaxDate { get; private set; }

        /// <summary>
        /// 获取批准工商执照机关字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TradeBureau { get; private set; }

        /// <summary>
        /// 获取营业执照号码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TradeCode { get; private set; }

        /// <summary>
        /// 获取营业执照有效期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TradeDate { get; private set; }

        /// <summary>
        /// 获取批准组织机构代码证机关字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField GroupBureau { get; private set; }

        /// <summary>
        /// 获取组织机构代码证号码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField GroupCode { get; private set; }

        /// <summary>
        /// 获取组织机构代码证有效期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField GroupDate { get; private set; }

        /// <summary>
        /// 获取经营范围字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Business { get; private set; }

        /// <summary>
        /// 获取注册资金(万元)字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RegMoney { get; private set; }

        /// <summary>
        /// 获取币种字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RegType { get; private set; }

        /// <summary>
        /// 获取国税税所字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TaxOffice { get; private set; }

        /// <summary>
        /// 获取国税专管员字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TaxManager { get; private set; }

        /// <summary>
        /// 获取国税分局字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TaxBureau { get; private set; }

        /// <summary>
        /// 获取国税专管员电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TaxManagerTel { get; private set; }

        /// <summary>
        /// 获取国税备注字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TaxDescription { get; private set; }

        /// <summary>
        /// 获取地税税所字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RentOffice { get; private set; }

        /// <summary>
        /// 获取地税专管员字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RentManager { get; private set; }

        /// <summary>
        /// 获取地税分局字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RentBureau { get; private set; }

        /// <summary>
        /// 获取地税专管员电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RentManagerTel { get; private set; }

        /// <summary>
        /// 获取地税备注字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RentDescription { get; private set; }

        /// <summary>
        /// 获取职工人数字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField StaffNum { get; private set; }

        /// <summary>
        /// 获取汽车数量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CarNum { get; private set; }

        /// <summary>
        /// 获取车牌号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CarCode { get; private set; }

        /// <summary>
        /// 获取状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 获取操作时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OperateTime { get; private set; }

        /// <summary>
        /// 获取操作状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OperateStatus { get; private set; }

        /// <summary>
        /// 获取操作人员字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OperateUser { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CPAClient() : base("CPAClient") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.DepartmentID = new dpz2.db.SqlUnits.TableField(this, "DepartmentID");
            this.PositionID = new dpz2.db.SqlUnits.TableField(this, "PositionID");
            this.TaxCode = new dpz2.db.SqlUnits.TableField(this, "TaxCode");
            this.RentCode = new dpz2.db.SqlUnits.TableField(this, "RentCode");
            this.Representative = new dpz2.db.SqlUnits.TableField(this, "Representative");
            this.Industry = new dpz2.db.SqlUnits.TableField(this, "Industry");
            this.CompanyType = new dpz2.db.SqlUnits.TableField(this, "CompanyType");
            this.RegAddress = new dpz2.db.SqlUnits.TableField(this, "RegAddress");
            this.OpenedDate = new dpz2.db.SqlUnits.TableField(this, "OpenedDate");
            this.RepresentativeTel = new dpz2.db.SqlUnits.TableField(this, "RepresentativeTel");
            this.CompanyTel = new dpz2.db.SqlUnits.TableField(this, "CompanyTel");
            this.ContactsTel = new dpz2.db.SqlUnits.TableField(this, "ContactsTel");
            this.TaxDate = new dpz2.db.SqlUnits.TableField(this, "TaxDate");
            this.TradeBureau = new dpz2.db.SqlUnits.TableField(this, "TradeBureau");
            this.TradeCode = new dpz2.db.SqlUnits.TableField(this, "TradeCode");
            this.TradeDate = new dpz2.db.SqlUnits.TableField(this, "TradeDate");
            this.GroupBureau = new dpz2.db.SqlUnits.TableField(this, "GroupBureau");
            this.GroupCode = new dpz2.db.SqlUnits.TableField(this, "GroupCode");
            this.GroupDate = new dpz2.db.SqlUnits.TableField(this, "GroupDate");
            this.Business = new dpz2.db.SqlUnits.TableField(this, "Business");
            this.RegMoney = new dpz2.db.SqlUnits.TableField(this, "RegMoney");
            this.RegType = new dpz2.db.SqlUnits.TableField(this, "RegType");
            this.TaxOffice = new dpz2.db.SqlUnits.TableField(this, "TaxOffice");
            this.TaxManager = new dpz2.db.SqlUnits.TableField(this, "TaxManager");
            this.TaxBureau = new dpz2.db.SqlUnits.TableField(this, "TaxBureau");
            this.TaxManagerTel = new dpz2.db.SqlUnits.TableField(this, "TaxManagerTel");
            this.TaxDescription = new dpz2.db.SqlUnits.TableField(this, "TaxDescription");
            this.RentOffice = new dpz2.db.SqlUnits.TableField(this, "RentOffice");
            this.RentManager = new dpz2.db.SqlUnits.TableField(this, "RentManager");
            this.RentBureau = new dpz2.db.SqlUnits.TableField(this, "RentBureau");
            this.RentManagerTel = new dpz2.db.SqlUnits.TableField(this, "RentManagerTel");
            this.RentDescription = new dpz2.db.SqlUnits.TableField(this, "RentDescription");
            this.StaffNum = new dpz2.db.SqlUnits.TableField(this, "StaffNum");
            this.CarNum = new dpz2.db.SqlUnits.TableField(this, "CarNum");
            this.CarCode = new dpz2.db.SqlUnits.TableField(this, "CarCode");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
            this.OperateTime = new dpz2.db.SqlUnits.TableField(this, "OperateTime");
            this.OperateStatus = new dpz2.db.SqlUnits.TableField(this, "OperateStatus");
            this.OperateUser = new dpz2.db.SqlUnits.TableField(this, "OperateUser");
        }

    }

}
