using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Jxc {

    /// <summary>
    /// 进货信息
    /// 存储所有的进货列表
    /// Version 1702.0001
    /// </summary>
    public class JxcPurchaseList : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 进货信息 行数据操作器
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
            /// 设置用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCode(string value) {
                base.Row["Code"] = value;
                return this;
            }

            /// <summary>
            /// 设置供应商标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSupplierID(string value) {
                base.Row["SupplierID"] = value;
                return this;
            }

            /// <summary>
            /// 设置供应商名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSupplierName(string value) {
                base.Row["SupplierName"] = value;
                return this;
            }

            /// <summary>
            /// 设置供应商地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSupplierAddress(string value) {
                base.Row["SupplierAddress"] = value;
                return this;
            }

            /// <summary>
            /// 设置供应商电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSupplierPhone(string value) {
                base.Row["SupplierPhone"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关仓库
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWarehouseID(string value) {
                base.Row["WarehouseID"] = value;
                return this;
            }

            /// <summary>
            /// 设置合计数量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTotalQuantity(string value) {
                base.Row["TotalQuantity"] = value;
                return this;
            }

            /// <summary>
            /// 设置合计金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTotal(string value) {
                base.Row["Total"] = value;
                return this;
            }

            /// <summary>
            /// 设置实定金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTotalFianl(string value) {
                base.Row["TotalFianl"] = value;
                return this;
            }

            /// <summary>
            /// 设置支付方式
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPayType(string value) {
                base.Row["PayType"] = value;
                return this;
            }

            /// <summary>
            /// 设置实收金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCash(string value) {
                base.Row["Cash"] = value;
                return this;
            }

            /// <summary>
            /// 设置找零
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRest(string value) {
                base.Row["Rest"] = value;
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
            /// 设置操作人员
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOpreateUserID(string value) {
                base.Row["OpreateUserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作日期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOpreateDate(string value) {
                base.Row["OpreateDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOpreateTime(string value) {
                base.Row["OpreateTime"] = value;
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
        /// 获取用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 获取供应商标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SupplierID { get; private set; }

        /// <summary>
        /// 获取供应商名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SupplierName { get; private set; }

        /// <summary>
        /// 获取供应商地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SupplierAddress { get; private set; }

        /// <summary>
        /// 获取供应商电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SupplierPhone { get; private set; }

        /// <summary>
        /// 获取相关仓库字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField WarehouseID { get; private set; }

        /// <summary>
        /// 获取合计数量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TotalQuantity { get; private set; }

        /// <summary>
        /// 获取合计金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Total { get; private set; }

        /// <summary>
        /// 获取实定金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TotalFianl { get; private set; }

        /// <summary>
        /// 获取支付方式字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PayType { get; private set; }

        /// <summary>
        /// 获取实收金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Cash { get; private set; }

        /// <summary>
        /// 获取找零字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Rest { get; private set; }

        /// <summary>
        /// 获取备注字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Remarks { get; private set; }

        /// <summary>
        /// 获取操作人员字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OpreateUserID { get; private set; }

        /// <summary>
        /// 获取操作日期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OpreateDate { get; private set; }

        /// <summary>
        /// 获取操作时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OpreateTime { get; private set; }

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
        public JxcPurchaseList() : base("JxcPurchaseList") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.SupplierID = new dpz2.db.SqlUnits.TableField(this, "SupplierID");
            this.SupplierName = new dpz2.db.SqlUnits.TableField(this, "SupplierName");
            this.SupplierAddress = new dpz2.db.SqlUnits.TableField(this, "SupplierAddress");
            this.SupplierPhone = new dpz2.db.SqlUnits.TableField(this, "SupplierPhone");
            this.WarehouseID = new dpz2.db.SqlUnits.TableField(this, "WarehouseID");
            this.TotalQuantity = new dpz2.db.SqlUnits.TableField(this, "TotalQuantity");
            this.Total = new dpz2.db.SqlUnits.TableField(this, "Total");
            this.TotalFianl = new dpz2.db.SqlUnits.TableField(this, "TotalFianl");
            this.PayType = new dpz2.db.SqlUnits.TableField(this, "PayType");
            this.Cash = new dpz2.db.SqlUnits.TableField(this, "Cash");
            this.Rest = new dpz2.db.SqlUnits.TableField(this, "Rest");
            this.Remarks = new dpz2.db.SqlUnits.TableField(this, "Remarks");
            this.OpreateUserID = new dpz2.db.SqlUnits.TableField(this, "OpreateUserID");
            this.OpreateDate = new dpz2.db.SqlUnits.TableField(this, "OpreateDate");
            this.OpreateTime = new dpz2.db.SqlUnits.TableField(this, "OpreateTime");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
