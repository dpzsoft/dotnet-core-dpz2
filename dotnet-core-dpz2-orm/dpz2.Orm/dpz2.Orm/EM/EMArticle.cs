using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.EM {

    /// <summary>
    /// 内部文章
    /// 内部文章
    /// Version 2016.1002
    /// </summary>
    public class EMArticle : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 内部文章 行数据操作器
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
            /// 设置标题
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetArtTitle(string value) {
                base.Row["ArtTitle"] = value;
                return this;
            }

            /// <summary>
            /// 设置内容
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetArtContent(string value) {
                base.Row["ArtContent"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关文件
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetArtFile(string value) {
                base.Row["ArtFile"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属分类
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCatalog(string value) {
                base.Row["Catalog"] = value;
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
        /// 获取标题字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ArtTitle { get; private set; }

        /// <summary>
        /// 获取内容字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ArtContent { get; private set; }

        /// <summary>
        /// 获取相关文件字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ArtFile { get; private set; }

        /// <summary>
        /// 获取所属分类字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Catalog { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public EMArticle() : base("EMArticle") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ArtTitle = new dpz2.db.SqlUnits.TableField(this, "ArtTitle");
            this.ArtContent = new dpz2.db.SqlUnits.TableField(this, "ArtContent");
            this.ArtFile = new dpz2.db.SqlUnits.TableField(this, "ArtFile");
            this.Catalog = new dpz2.db.SqlUnits.TableField(this, "Catalog");
        }

    }

}
