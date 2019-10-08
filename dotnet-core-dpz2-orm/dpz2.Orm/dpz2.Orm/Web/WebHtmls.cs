using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web {

    /// <summary>
    /// 页面代码表
    /// 页面代码表
    /// Version 1511.2601
    /// </summary>
    public class WebHtmls : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 页面代码表 行数据操作器
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
            /// 设置HTML代码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHTML(string value) {
                base.Row["HTML"] = value;
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
        /// 获取HTML代码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField HTML { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public WebHtmls() : base("WebHtmls") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ObjID = new dpz2.db.SqlUnits.TableField(this, "ObjID");
            this.HTML = new dpz2.db.SqlUnits.TableField(this, "HTML");
        }

    }

}
