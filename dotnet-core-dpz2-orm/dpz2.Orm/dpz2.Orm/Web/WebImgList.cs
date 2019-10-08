using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web {

    /// <summary>
    /// 网站图片列表
    /// 网站图片列表
    /// Version 1604.1001
    /// </summary>
    public class WebImgList : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 网站图片列表 行数据操作器
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
            /// 设置标题
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTitle(string value) {
                base.Row["Title"] = value;
                return this;
            }

            /// <summary>
            /// 设置图像地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImgPath(string value) {
                base.Row["ImgPath"] = value;
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
        /// 获取标题字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Title { get; private set; }

        /// <summary>
        /// 获取图像地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ImgPath { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public WebImgList() : base("WebImgList") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ObjID = new dpz2.db.SqlUnits.TableField(this, "ObjID");
            this.ParentID = new dpz2.db.SqlUnits.TableField(this, "ParentID");
            this.Title = new dpz2.db.SqlUnits.TableField(this, "Title");
            this.ImgPath = new dpz2.db.SqlUnits.TableField(this, "ImgPath");
        }

    }

}
