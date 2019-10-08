using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Jxc {

    /// <summary>
    /// 商品信息
    /// 存储所有的商品信息
    /// Version 1803.0005
    /// </summary>
    public class JxcProducts : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商品信息 行数据操作器
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
            /// 设置所属分类
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCatalogID(string value) {
                base.Row["CatalogID"] = value;
                return this;
            }

            /// <summary>
            /// 设置商品类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProductType(string value) {
                base.Row["ProductType"] = value;
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
            /// 设置进货价
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPurchasePrice(string value) {
                base.Row["PurchasePrice"] = value;
                return this;
            }

            /// <summary>
            /// 设置库存
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStock(string value) {
                base.Row["Stock"] = value;
                return this;
            }

            /// <summary>
            /// 设置图片
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPicture(string value) {
                base.Row["Picture"] = value;
                return this;
            }

            /// <summary>
            /// 设置简介
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSummary(string value) {
                base.Row["Summary"] = value;
                return this;
            }

            /// <summary>
            /// 设置安全库存
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSafeStock(string value) {
                base.Row["SafeStock"] = value;
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
            /// 设置扩展状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetExpandStatus(string value) {
                base.Row["ExpandStatus"] = value;
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
        /// 获取所属分类字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CatalogID { get; private set; }

        /// <summary>
        /// 获取商品类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ProductType { get; private set; }

        /// <summary>
        /// 获取单位字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Unit { get; private set; }

        /// <summary>
        /// 获取售价字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Price { get; private set; }

        /// <summary>
        /// 获取进货价字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PurchasePrice { get; private set; }

        /// <summary>
        /// 获取库存字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Stock { get; private set; }

        /// <summary>
        /// 获取图片字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Picture { get; private set; }

        /// <summary>
        /// 获取简介字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Summary { get; private set; }

        /// <summary>
        /// 获取安全库存字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SafeStock { get; private set; }

        /// <summary>
        /// 获取状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 获取扩展状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ExpandStatus { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public JxcProducts() : base("JxcProducts") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Norm = new dpz2.db.SqlUnits.TableField(this, "Norm");
            this.Pinyin = new dpz2.db.SqlUnits.TableField(this, "Pinyin");
            this.CatalogID = new dpz2.db.SqlUnits.TableField(this, "CatalogID");
            this.ProductType = new dpz2.db.SqlUnits.TableField(this, "ProductType");
            this.Unit = new dpz2.db.SqlUnits.TableField(this, "Unit");
            this.Price = new dpz2.db.SqlUnits.TableField(this, "Price");
            this.PurchasePrice = new dpz2.db.SqlUnits.TableField(this, "PurchasePrice");
            this.Stock = new dpz2.db.SqlUnits.TableField(this, "Stock");
            this.Picture = new dpz2.db.SqlUnits.TableField(this, "Picture");
            this.Summary = new dpz2.db.SqlUnits.TableField(this, "Summary");
            this.SafeStock = new dpz2.db.SqlUnits.TableField(this, "SafeStock");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
            this.ExpandStatus = new dpz2.db.SqlUnits.TableField(this, "ExpandStatus");
        }

    }

}
