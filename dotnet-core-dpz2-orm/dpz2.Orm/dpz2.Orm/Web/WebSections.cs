using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web {

    /// <summary>
    /// 网站栏目表
    /// 网站栏目表
    /// Version 2016.0401
    /// </summary>
    public class WebSections : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 网站栏目表 行数据操作器
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
            /// 设置栏目名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
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
            /// 设置所属模块
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMudID(string value) {
                base.Row["MudID"] = value;
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
            /// 设置排序
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIndex(string value) {
                base.Row["Index"] = value;
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
        /// 获取栏目名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取对象编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ObjID { get; private set; }

        /// <summary>
        /// 获取所属模块字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField MudID { get; private set; }

        /// <summary>
        /// 获取所属栏目字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ParentID { get; private set; }

        /// <summary>
        /// 获取排序字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Index { get; private set; }

        /// <summary>
        /// 获取示意图字段定义
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
        public WebSections() : base("WebSections") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.AuthID = new dpz2.db.SqlUnits.TableField(this, "AuthID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.ObjID = new dpz2.db.SqlUnits.TableField(this, "ObjID");
            this.MudID = new dpz2.db.SqlUnits.TableField(this, "MudID");
            this.ParentID = new dpz2.db.SqlUnits.TableField(this, "ParentID");
            this.Index = new dpz2.db.SqlUnits.TableField(this, "Index");
            this.ImgPath = new dpz2.db.SqlUnits.TableField(this, "ImgPath");
        }

    }

}
