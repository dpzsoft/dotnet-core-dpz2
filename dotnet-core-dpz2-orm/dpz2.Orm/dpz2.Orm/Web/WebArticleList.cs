using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web {

    /// <summary>
    /// 页面文章列表
    /// 页面文章列表
    /// Version 1.1.1907.7
    /// </summary>
    public class WebArticleList : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 页面文章列表 行数据操作器
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
            /// 设置对象编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetObjID(string value) {
                base.Row["ObjID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属栏目
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetParentID(string value) {
                base.Row["ParentID"] = value;
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
            /// 设置缩略图1
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImg1(string value) {
                base.Row["Img1"] = value;
                return this;
            }

            /// <summary>
            /// 设置缩略图2
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImg2(string value) {
                base.Row["Img2"] = value;
                return this;
            }

            /// <summary>
            /// 设置缩略图3
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImg3(string value) {
                base.Row["Img3"] = value;
                return this;
            }

            /// <summary>
            /// 设置文章标题
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetArtTitle(string value) {
                base.Row["ArtTitle"] = value;
                return this;
            }

            /// <summary>
            /// 设置文章内容
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetArtContent(string value) {
                base.Row["ArtContent"] = value;
                return this;
            }

            /// <summary>
            /// 设置创建时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCreateTime(string value) {
                base.Row["CreateTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置更新时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUpdateTime(string value) {
                base.Row["UpdateTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置阅读数量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetReads(string value) {
                base.Row["Reads"] = value;
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
        /// 获取对象编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ObjID { get; private set; }

        /// <summary>
        /// 获取所属栏目字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ParentID { get; private set; }

        /// <summary>
        /// 获取简介字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Summary { get; private set; }

        /// <summary>
        /// 获取缩略图1字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Img1 { get; private set; }

        /// <summary>
        /// 获取缩略图2字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Img2 { get; private set; }

        /// <summary>
        /// 获取缩略图3字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Img3 { get; private set; }

        /// <summary>
        /// 获取文章标题字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ArtTitle { get; private set; }

        /// <summary>
        /// 获取文章内容字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ArtContent { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取更新时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UpdateTime { get; private set; }

        /// <summary>
        /// 获取阅读数量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Reads { get; private set; }

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
        public WebArticleList() : base("WebArticleList") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ObjID = new dpz2.db.SqlUnits.TableField(this, "ObjID");
            this.ParentID = new dpz2.db.SqlUnits.TableField(this, "ParentID");
            this.Summary = new dpz2.db.SqlUnits.TableField(this, "Summary");
            this.Img1 = new dpz2.db.SqlUnits.TableField(this, "Img1");
            this.Img2 = new dpz2.db.SqlUnits.TableField(this, "Img2");
            this.Img3 = new dpz2.db.SqlUnits.TableField(this, "Img3");
            this.ArtTitle = new dpz2.db.SqlUnits.TableField(this, "ArtTitle");
            this.ArtContent = new dpz2.db.SqlUnits.TableField(this, "ArtContent");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.UpdateTime = new dpz2.db.SqlUnits.TableField(this, "UpdateTime");
            this.Reads = new dpz2.db.SqlUnits.TableField(this, "Reads");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
