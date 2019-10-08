using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Mall {

    /// <summary>
    /// 商城商品表
    /// 商城商品表
    /// Version 1703.0002
    /// </summary>
    public class MallProduct : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商城商品表 行数据操作器
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
            /// 设置商品名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
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
            /// 设置关键字
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetKeyWords(string value) {
                base.Row["KeyWords"] = value;
                return this;
            }

            /// <summary>
            /// 设置价格
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPrice(string value) {
                base.Row["Price"] = value;
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
            /// 设置封面图片
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFrontImg(string value) {
                base.Row["FrontImg"] = value;
                return this;
            }

            /// <summary>
            /// 设置详情
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDetail(string value) {
                base.Row["Detail"] = value;
                return this;
            }

            /// <summary>
            /// 设置访问量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVisited(string value) {
                base.Row["Visited"] = value;
                return this;
            }

            /// <summary>
            /// 设置销售量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSales(string value) {
                base.Row["Sales"] = value;
                return this;
            }

            /// <summary>
            /// 设置描述
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDescription(string value) {
                base.Row["Description"] = value;
                return this;
            }

            /// <summary>
            /// 设置有效性
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetValid(string value) {
                base.Row["Valid"] = value;
                return this;
            }

            /// <summary>
            /// 设置特殊商品
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSpecial(string value) {
                base.Row["Special"] = value;
                return this;
            }

            /// <summary>
            /// 设置库存量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStock(string value) {
                base.Row["Stock"] = value;
                return this;
            }

            /// <summary>
            /// 设置限制购买量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLimit(string value) {
                base.Row["Limit"] = value;
                return this;
            }

            /// <summary>
            /// 设置机器人标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFlag(string value) {
                base.Row["Flag"] = value;
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
        /// 获取商品名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取所属分类字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CatalogID { get; private set; }

        /// <summary>
        /// 获取关键字字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField KeyWords { get; private set; }

        /// <summary>
        /// 获取价格字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Price { get; private set; }

        /// <summary>
        /// 获取单位字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Unit { get; private set; }

        /// <summary>
        /// 获取封面图片字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FrontImg { get; private set; }

        /// <summary>
        /// 获取详情字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Detail { get; private set; }

        /// <summary>
        /// 获取访问量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Visited { get; private set; }

        /// <summary>
        /// 获取销售量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Sales { get; private set; }

        /// <summary>
        /// 获取描述字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Description { get; private set; }

        /// <summary>
        /// 获取有效性字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Valid { get; private set; }

        /// <summary>
        /// 获取特殊商品字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Special { get; private set; }

        /// <summary>
        /// 获取库存量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Stock { get; private set; }

        /// <summary>
        /// 获取限制购买量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Limit { get; private set; }

        /// <summary>
        /// 获取机器人标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Flag { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public MallProduct() : base("MallProduct") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.CatalogID = new dpz2.db.SqlUnits.TableField(this, "CatalogID");
            this.KeyWords = new dpz2.db.SqlUnits.TableField(this, "KeyWords");
            this.Price = new dpz2.db.SqlUnits.TableField(this, "Price");
            this.Unit = new dpz2.db.SqlUnits.TableField(this, "Unit");
            this.FrontImg = new dpz2.db.SqlUnits.TableField(this, "FrontImg");
            this.Detail = new dpz2.db.SqlUnits.TableField(this, "Detail");
            this.Visited = new dpz2.db.SqlUnits.TableField(this, "Visited");
            this.Sales = new dpz2.db.SqlUnits.TableField(this, "Sales");
            this.Description = new dpz2.db.SqlUnits.TableField(this, "Description");
            this.Valid = new dpz2.db.SqlUnits.TableField(this, "Valid");
            this.Special = new dpz2.db.SqlUnits.TableField(this, "Special");
            this.Stock = new dpz2.db.SqlUnits.TableField(this, "Stock");
            this.Limit = new dpz2.db.SqlUnits.TableField(this, "Limit");
            this.Flag = new dpz2.db.SqlUnits.TableField(this, "Flag");
        }

    }

}
