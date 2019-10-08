using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web {

    /// <summary>
    /// 主页模块
    /// 主页模块
    /// Version 1604.1001
    /// </summary>
    public class WebHomeModule : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 主页模块 行数据操作器
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
            /// 设置名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetType(string value) {
                base.Row["Type"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关的表
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTable(string value) {
                base.Row["Table"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关的文本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetText(string value) {
                base.Row["Text"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关的脚本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDScript(string value) {
                base.Row["DScript"] = value;
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
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Type { get; private set; }

        /// <summary>
        /// 获取相关的表字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Table { get; private set; }

        /// <summary>
        /// 获取相关的文本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Text { get; private set; }

        /// <summary>
        /// 获取相关的脚本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DScript { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public WebHomeModule() : base("WebHomeModule") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Type = new dpz2.db.SqlUnits.TableField(this, "Type");
            this.Table = new dpz2.db.SqlUnits.TableField(this, "Table");
            this.Text = new dpz2.db.SqlUnits.TableField(this, "Text");
            this.DScript = new dpz2.db.SqlUnits.TableField(this, "DScript");
        }

    }

}
