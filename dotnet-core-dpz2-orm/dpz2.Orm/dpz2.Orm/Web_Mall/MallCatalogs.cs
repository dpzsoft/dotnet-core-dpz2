using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Mall {

    /// <summary>
    /// 商城商品分类表
    /// 商城商品分类表
    /// Version 2016.0803
    /// </summary>
    public class MallCatalogs : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商城商品分类表 行数据操作器
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
            /// 设置授权识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAuthID(string value) {
                base.Row["AuthID"] = value;
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
            /// 设置所属分类
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCatalogID(string value) {
                base.Row["CatalogID"] = value;
                return this;
            }

            /// <summary>
            /// 设置示意图
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImgPath(string value) {
                base.Row["ImgPath"] = value;
                return this;
            }

            /// <summary>
            /// 设置移动示意图
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhoneImgPath(string value) {
                base.Row["PhoneImgPath"] = value;
                return this;
            }

            /// <summary>
            /// 设置颜色
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetColor(string value) {
                base.Row["Color"] = value;
                return this;
            }

            /// <summary>
            /// 设置排序
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIndex(string value) {
                base.Row["Index"] = value;
                return this;
            }

            /// <summary>
            /// 设置关键字
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetKeys(string value) {
                base.Row["Keys"] = value;
                return this;
            }

            /// <summary>
            /// 设置有效性
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEnable(string value) {
                base.Row["Enable"] = value;
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
        /// 获取授权识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AuthID { get; private set; }

        /// <summary>
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取所属分类字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CatalogID { get; private set; }

        /// <summary>
        /// 获取示意图字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ImgPath { get; private set; }

        /// <summary>
        /// 获取移动示意图字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PhoneImgPath { get; private set; }

        /// <summary>
        /// 获取颜色字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Color { get; private set; }

        /// <summary>
        /// 获取排序字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Index { get; private set; }

        /// <summary>
        /// 获取关键字字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Keys { get; private set; }

        /// <summary>
        /// 获取有效性字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Enable { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public MallCatalogs() : base("MallCatalogs") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.AuthID = new dpz2.db.SqlUnits.TableField(this, "AuthID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.CatalogID = new dpz2.db.SqlUnits.TableField(this, "CatalogID");
            this.ImgPath = new dpz2.db.SqlUnits.TableField(this, "ImgPath");
            this.PhoneImgPath = new dpz2.db.SqlUnits.TableField(this, "PhoneImgPath");
            this.Color = new dpz2.db.SqlUnits.TableField(this, "Color");
            this.Index = new dpz2.db.SqlUnits.TableField(this, "Index");
            this.Keys = new dpz2.db.SqlUnits.TableField(this, "Keys");
            this.Enable = new dpz2.db.SqlUnits.TableField(this, "Enable");
        }

    }

}
