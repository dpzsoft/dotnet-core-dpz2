using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Jxc {

    /// <summary>
    /// 商品分类信息
    /// 存储所有的商品分类信息
    /// Version 1710.0004
    /// </summary>
    public class JxcCatalogs : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商品分类信息 行数据操作器
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
            /// 设置拼音
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPinyin(string value) {
                base.Row["Pinyin"] = value;
                return this;
            }

            /// <summary>
            /// 设置栏目图标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImgPath(string value) {
                base.Row["ImgPath"] = value;
                return this;
            }

            /// <summary>
            /// 设置栏目示意图
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBannerPath(string value) {
                base.Row["BannerPath"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属分类
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBelongCatalogID(string value) {
                base.Row["BelongCatalogID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属分类路径
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBelongPath(string value) {
                base.Row["BelongPath"] = value;
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
        /// 获取拼音字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Pinyin { get; private set; }

        /// <summary>
        /// 获取栏目图标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ImgPath { get; private set; }

        /// <summary>
        /// 获取栏目示意图字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BannerPath { get; private set; }

        /// <summary>
        /// 获取所属分类字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BelongCatalogID { get; private set; }

        /// <summary>
        /// 获取所属分类路径字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BelongPath { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public JxcCatalogs() : base("JxcCatalogs") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Pinyin = new dpz2.db.SqlUnits.TableField(this, "Pinyin");
            this.ImgPath = new dpz2.db.SqlUnits.TableField(this, "ImgPath");
            this.BannerPath = new dpz2.db.SqlUnits.TableField(this, "BannerPath");
            this.BelongCatalogID = new dpz2.db.SqlUnits.TableField(this, "BelongCatalogID");
            this.BelongPath = new dpz2.db.SqlUnits.TableField(this, "BelongPath");
        }

    }

}
