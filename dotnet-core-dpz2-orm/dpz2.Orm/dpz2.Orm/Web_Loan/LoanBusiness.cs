using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Loan {

    /// <summary>
    /// 业务进件受理流程
    /// 业务进件受理流程
    /// Version 2017.0621
    /// </summary>
    public class LoanBusiness : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 业务进件受理流程 行数据操作器
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
            /// 设置电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhone(string value) {
                base.Row["Phone"] = value;
                return this;
            }

            /// <summary>
            /// 设置业务种类
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBusinessType(string value) {
                base.Row["BusinessType"] = value;
                return this;
            }

            /// <summary>
            /// 设置申请金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetApplyMoney(string value) {
                base.Row["ApplyMoney"] = value;
                return this;
            }

            /// <summary>
            /// 设置受理时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAcceptedTime(string value) {
                base.Row["AcceptedTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置面签时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFaceTime(string value) {
                base.Row["FaceTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置下款时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetReplyTime(string value) {
                base.Row["ReplyTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置实际下款时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRealReplyTime(string value) {
                base.Row["RealReplyTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置业务备注
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
        /// 获取电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取业务种类字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BusinessType { get; private set; }

        /// <summary>
        /// 获取申请金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ApplyMoney { get; private set; }

        /// <summary>
        /// 获取受理时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AcceptedTime { get; private set; }

        /// <summary>
        /// 获取面签时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FaceTime { get; private set; }

        /// <summary>
        /// 获取下款时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ReplyTime { get; private set; }

        /// <summary>
        /// 获取实际下款时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RealReplyTime { get; private set; }

        /// <summary>
        /// 获取业务备注字段定义
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
        public LoanBusiness() : base("LoanBusiness") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.BusinessType = new dpz2.db.SqlUnits.TableField(this, "BusinessType");
            this.ApplyMoney = new dpz2.db.SqlUnits.TableField(this, "ApplyMoney");
            this.AcceptedTime = new dpz2.db.SqlUnits.TableField(this, "AcceptedTime");
            this.FaceTime = new dpz2.db.SqlUnits.TableField(this, "FaceTime");
            this.ReplyTime = new dpz2.db.SqlUnits.TableField(this, "ReplyTime");
            this.RealReplyTime = new dpz2.db.SqlUnits.TableField(this, "RealReplyTime");
            this.Remarks = new dpz2.db.SqlUnits.TableField(this, "Remarks");
        }

    }

}
