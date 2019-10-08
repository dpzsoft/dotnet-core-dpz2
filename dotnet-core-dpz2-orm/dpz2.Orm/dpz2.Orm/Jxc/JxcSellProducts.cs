using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Jxc {

    /// <summary>
    /// 销售商品信息
    /// 存储所有的销售商品信息
    /// Version 1702.0001
    /// </summary>
    public class JxcSellProducts : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 销售商品信息 行数据操作器
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
            /// 设置编码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSellCode(string value) {
                base.Row["SellCode"] = value;
                return this;
            }

            /// <summary>
            /// 设置编码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProductID(string value) {
                base.Row["ProductID"] = value;
                return this;
            }

            /// <summary>
            /// 设置编码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCode(string value) {
                base.Row["Code"] = value;
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
            /// 设置规格
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetNorm(string value) {
                base.Row["Norm"] = value;
                return this;
            }

            /// <summary>
            /// 设置拼音
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPinyin(string value) {
                base.Row["Pinyin"] = value;
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
            /// 设置单位
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUnit(string value) {
                base.Row["Unit"] = value;
                return this;
            }

            /// <summary>
            /// 设置售价
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPrice(string value) {
                base.Row["Price"] = value;
                return this;
            }

            /// <summary>
            /// 设置折扣
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDiscount(string value) {
                base.Row["Discount"] = value;
                return this;
            }

            /// <summary>
            /// 设置折后价
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPriceFianl(string value) {
                base.Row["PriceFianl"] = value;
                return this;
            }

            /// <summary>
            /// 设置税率
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCess(string value) {
                base.Row["Cess"] = value;
                return this;
            }

            /// <summary>
            /// 设置总价
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTotal(string value) {
                base.Row["Total"] = value;
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
        /// 获取编码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SellCode { get; private set; }

        /// <summary>
        /// 获取编码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ProductID { get; private set; }

        /// <summary>
        /// 获取编码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取规格字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Norm { get; private set; }

        /// <summary>
        /// 获取拼音字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Pinyin { get; private set; }

        /// <summary>
        /// 获取数量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Quantity { get; private set; }

        /// <summary>
        /// 获取单位字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Unit { get; private set; }

        /// <summary>
        /// 获取售价字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Price { get; private set; }

        /// <summary>
        /// 获取折扣字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Discount { get; private set; }

        /// <summary>
        /// 获取折后价字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PriceFianl { get; private set; }

        /// <summary>
        /// 获取税率字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Cess { get; private set; }

        /// <summary>
        /// 获取总价字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Total { get; private set; }

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
        public JxcSellProducts() : base("JxcSellProducts") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.SellCode = new dpz2.db.SqlUnits.TableField(this, "SellCode");
            this.ProductID = new dpz2.db.SqlUnits.TableField(this, "ProductID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Norm = new dpz2.db.SqlUnits.TableField(this, "Norm");
            this.Pinyin = new dpz2.db.SqlUnits.TableField(this, "Pinyin");
            this.Quantity = new dpz2.db.SqlUnits.TableField(this, "Quantity");
            this.Unit = new dpz2.db.SqlUnits.TableField(this, "Unit");
            this.Price = new dpz2.db.SqlUnits.TableField(this, "Price");
            this.Discount = new dpz2.db.SqlUnits.TableField(this, "Discount");
            this.PriceFianl = new dpz2.db.SqlUnits.TableField(this, "PriceFianl");
            this.Cess = new dpz2.db.SqlUnits.TableField(this, "Cess");
            this.Total = new dpz2.db.SqlUnits.TableField(this, "Total");
            this.Remarks = new dpz2.db.SqlUnits.TableField(this, "Remarks");
        }

    }

}
