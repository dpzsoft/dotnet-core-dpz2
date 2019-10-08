using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Loan {

    /// <summary>
    /// 贷款提交表
    /// 贷款提交表
    /// Version 2016.0502
    /// </summary>
    public class LoanApply : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 贷款提交表 行数据操作器
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
            /// 设置手机号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhone(string value) {
                base.Row["Phone"] = value;
                return this;
            }

            /// <summary>
            /// 设置贷款金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMoney(string value) {
                base.Row["Money"] = value;
                return this;
            }

            /// <summary>
            /// 设置所在城市
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCity(string value) {
                base.Row["City"] = value;
                return this;
            }

            /// <summary>
            /// 设置办理项目
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProjects(string value) {
                base.Row["Projects"] = value;
                return this;
            }

            /// <summary>
            /// 设置办理服务
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetServices(string value) {
                base.Row["Services"] = value;
                return this;
            }

            /// <summary>
            /// 设置提交时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetApplyTime(string value) {
                base.Row["ApplyTime"] = value;
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
            /// 设置推广员
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSpreadID(string value) {
                base.Row["SpreadID"] = value;
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
        /// 获取手机号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取贷款金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Money { get; private set; }

        /// <summary>
        /// 获取所在城市字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField City { get; private set; }

        /// <summary>
        /// 获取办理项目字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Projects { get; private set; }

        /// <summary>
        /// 获取办理服务字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Services { get; private set; }

        /// <summary>
        /// 获取提交时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ApplyTime { get; private set; }

        /// <summary>
        /// 获取备注字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Remarks { get; private set; }

        /// <summary>
        /// 获取推广员字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SpreadID { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public LoanApply() : base("LoanApply") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.Money = new dpz2.db.SqlUnits.TableField(this, "Money");
            this.City = new dpz2.db.SqlUnits.TableField(this, "City");
            this.Projects = new dpz2.db.SqlUnits.TableField(this, "Projects");
            this.Services = new dpz2.db.SqlUnits.TableField(this, "Services");
            this.ApplyTime = new dpz2.db.SqlUnits.TableField(this, "ApplyTime");
            this.Remarks = new dpz2.db.SqlUnits.TableField(this, "Remarks");
            this.SpreadID = new dpz2.db.SqlUnits.TableField(this, "SpreadID");
        }

    }

}
