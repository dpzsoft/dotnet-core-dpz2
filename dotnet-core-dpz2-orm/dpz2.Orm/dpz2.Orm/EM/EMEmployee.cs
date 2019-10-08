using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.EM {

    /// <summary>
    /// 员工信息
    /// 员工信息
    /// Version 1512.2001
    /// </summary>
    public class EMEmployee : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 员工信息 行数据操作器
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
            /// 设置员工编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCode(string value) {
                base.Row["Code"] = value;
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
            /// 设置英文名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetNameEn(string value) {
                base.Row["NameEn"] = value;
                return this;
            }

            /// <summary>
            /// 设置部门
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDepartmentID(string value) {
                base.Row["DepartmentID"] = value;
                return this;
            }

            /// <summary>
            /// 设置职务
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetJobID(string value) {
                base.Row["JobID"] = value;
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
            /// 设置婚姻状况
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMarriage(string value) {
                base.Row["Marriage"] = value;
                return this;
            }

            /// <summary>
            /// 设置文化程度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEducation(string value) {
                base.Row["Education"] = value;
                return this;
            }

            /// <summary>
            /// 设置毕业学校
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSchool(string value) {
                base.Row["School"] = value;
                return this;
            }

            /// <summary>
            /// 设置所学专业
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProfessionals(string value) {
                base.Row["Professionals"] = value;
                return this;
            }

            /// <summary>
            /// 设置政治面貌
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPolitical(string value) {
                base.Row["Political"] = value;
                return this;
            }

            /// <summary>
            /// 设置民族
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetNation(string value) {
                base.Row["Nation"] = value;
                return this;
            }

            /// <summary>
            /// 设置籍贯
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHometown(string value) {
                base.Row["Hometown"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份证号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIDCard(string value) {
                base.Row["IDCard"] = value;
                return this;
            }

            /// <summary>
            /// 设置职称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetJobTitle(string value) {
                base.Row["JobTitle"] = value;
                return this;
            }

            /// <summary>
            /// 设置参加工作时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWorkDate(string value) {
                base.Row["WorkDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置入职时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetJobDate(string value) {
                base.Row["JobDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置身高
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHeight(string value) {
                base.Row["Height"] = value;
                return this;
            }

            /// <summary>
            /// 设置体重
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWeight(string value) {
                base.Row["Weight"] = value;
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
            /// 设置邮箱地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEMail(string value) {
                base.Row["EMail"] = value;
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
            /// 设置联系地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAddress(string value) {
                base.Row["Address"] = value;
                return this;
            }

            /// <summary>
            /// 设置合同编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetContractCode(string value) {
                base.Row["ContractCode"] = value;
                return this;
            }

            /// <summary>
            /// 设置合同有效期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetContractDate(string value) {
                base.Row["ContractDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置离职日期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTurnoverDate(string value) {
                base.Row["TurnoverDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置离职原因
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTurnoverReason(string value) {
                base.Row["TurnoverReason"] = value;
                return this;
            }

            /// <summary>
            /// 设置其他
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDetail(string value) {
                base.Row["Detail"] = value;
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
        /// 获取员工编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 获取姓名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取英文名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField NameEn { get; private set; }

        /// <summary>
        /// 获取部门字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DepartmentID { get; private set; }

        /// <summary>
        /// 获取职务字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField JobID { get; private set; }

        /// <summary>
        /// 获取性别字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Sex { get; private set; }

        /// <summary>
        /// 获取生日字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Birthday { get; private set; }

        /// <summary>
        /// 获取婚姻状况字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Marriage { get; private set; }

        /// <summary>
        /// 获取文化程度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Education { get; private set; }

        /// <summary>
        /// 获取毕业学校字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField School { get; private set; }

        /// <summary>
        /// 获取所学专业字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Professionals { get; private set; }

        /// <summary>
        /// 获取政治面貌字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Political { get; private set; }

        /// <summary>
        /// 获取民族字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Nation { get; private set; }

        /// <summary>
        /// 获取籍贯字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Hometown { get; private set; }

        /// <summary>
        /// 获取身份证号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IDCard { get; private set; }

        /// <summary>
        /// 获取职称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField JobTitle { get; private set; }

        /// <summary>
        /// 获取参加工作时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField WorkDate { get; private set; }

        /// <summary>
        /// 获取入职时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField JobDate { get; private set; }

        /// <summary>
        /// 获取身高字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Height { get; private set; }

        /// <summary>
        /// 获取体重字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Weight { get; private set; }

        /// <summary>
        /// 获取联系电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取邮箱地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EMail { get; private set; }

        /// <summary>
        /// 获取QQ字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField QQ { get; private set; }

        /// <summary>
        /// 获取联系地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Address { get; private set; }

        /// <summary>
        /// 获取合同编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ContractCode { get; private set; }

        /// <summary>
        /// 获取合同有效期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ContractDate { get; private set; }

        /// <summary>
        /// 获取离职日期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TurnoverDate { get; private set; }

        /// <summary>
        /// 获取离职原因字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TurnoverReason { get; private set; }

        /// <summary>
        /// 获取其他字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Detail { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public EMEmployee() : base("EMEmployee") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.NameEn = new dpz2.db.SqlUnits.TableField(this, "NameEn");
            this.DepartmentID = new dpz2.db.SqlUnits.TableField(this, "DepartmentID");
            this.JobID = new dpz2.db.SqlUnits.TableField(this, "JobID");
            this.Sex = new dpz2.db.SqlUnits.TableField(this, "Sex");
            this.Birthday = new dpz2.db.SqlUnits.TableField(this, "Birthday");
            this.Marriage = new dpz2.db.SqlUnits.TableField(this, "Marriage");
            this.Education = new dpz2.db.SqlUnits.TableField(this, "Education");
            this.School = new dpz2.db.SqlUnits.TableField(this, "School");
            this.Professionals = new dpz2.db.SqlUnits.TableField(this, "Professionals");
            this.Political = new dpz2.db.SqlUnits.TableField(this, "Political");
            this.Nation = new dpz2.db.SqlUnits.TableField(this, "Nation");
            this.Hometown = new dpz2.db.SqlUnits.TableField(this, "Hometown");
            this.IDCard = new dpz2.db.SqlUnits.TableField(this, "IDCard");
            this.JobTitle = new dpz2.db.SqlUnits.TableField(this, "JobTitle");
            this.WorkDate = new dpz2.db.SqlUnits.TableField(this, "WorkDate");
            this.JobDate = new dpz2.db.SqlUnits.TableField(this, "JobDate");
            this.Height = new dpz2.db.SqlUnits.TableField(this, "Height");
            this.Weight = new dpz2.db.SqlUnits.TableField(this, "Weight");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.EMail = new dpz2.db.SqlUnits.TableField(this, "EMail");
            this.QQ = new dpz2.db.SqlUnits.TableField(this, "QQ");
            this.Address = new dpz2.db.SqlUnits.TableField(this, "Address");
            this.ContractCode = new dpz2.db.SqlUnits.TableField(this, "ContractCode");
            this.ContractDate = new dpz2.db.SqlUnits.TableField(this, "ContractDate");
            this.TurnoverDate = new dpz2.db.SqlUnits.TableField(this, "TurnoverDate");
            this.TurnoverReason = new dpz2.db.SqlUnits.TableField(this, "TurnoverReason");
            this.Detail = new dpz2.db.SqlUnits.TableField(this, "Detail");
        }

    }

}
