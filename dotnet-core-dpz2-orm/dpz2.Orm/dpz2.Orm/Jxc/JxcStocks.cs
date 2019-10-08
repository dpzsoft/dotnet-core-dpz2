using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Jxc {

    /// <summary>
    /// 库存流水
    /// 存储所有的库存流水信息
    /// Version 1702.0001
    /// </summary>
    public class JxcStocks : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 库存流水 行数据操作器
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
            /// 设置相关仓库
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWarehouseID(string value) {
                base.Row["WarehouseID"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关商品
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProductID(string value) {
                base.Row["ProductID"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关单据
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTicketCode(string value) {
                base.Row["TicketCode"] = value;
                return this;
            }

            /// <summary>
            /// 设置摘要
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSummary(string value) {
                base.Row["Summary"] = value;
                return this;
            }

            /// <summary>
            /// 设置数量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetQuantity(string value) {
                base.Row["Quantity"] = value;
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
        /// 获取相关仓库字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField WarehouseID { get; private set; }

        /// <summary>
        /// 获取相关商品字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ProductID { get; private set; }

        /// <summary>
        /// 获取相关单据字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TicketCode { get; private set; }

        /// <summary>
        /// 获取摘要字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Summary { get; private set; }

        /// <summary>
        /// 获取数量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Quantity { get; private set; }

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
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public JxcStocks() : base("JxcStocks") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.WarehouseID = new dpz2.db.SqlUnits.TableField(this, "WarehouseID");
            this.ProductID = new dpz2.db.SqlUnits.TableField(this, "ProductID");
            this.TicketCode = new dpz2.db.SqlUnits.TableField(this, "TicketCode");
            this.Summary = new dpz2.db.SqlUnits.TableField(this, "Summary");
            this.Quantity = new dpz2.db.SqlUnits.TableField(this, "Quantity");
            this.Remarks = new dpz2.db.SqlUnits.TableField(this, "Remarks");
            this.OpreateUserID = new dpz2.db.SqlUnits.TableField(this, "OpreateUserID");
            this.OpreateDate = new dpz2.db.SqlUnits.TableField(this, "OpreateDate");
            this.OpreateTime = new dpz2.db.SqlUnits.TableField(this, "OpreateTime");
        }

    }

}
