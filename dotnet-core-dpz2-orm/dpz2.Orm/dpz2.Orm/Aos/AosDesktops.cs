using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 桌面信息
    /// 桌面信息
    /// Version 1.2.1902.4
    /// </summary>
    public class AosDesktops : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 桌面信息 行数据操作器
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
            /// 设置显示文本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetText(string value) {
                base.Row["Text"] = value;
                return this;
            }

            /// <summary>
            /// 设置加载地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPath(string value) {
                base.Row["Path"] = value;
                return this;
            }

            /// <summary>
            /// 设置绑定主机
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHost(string value) {
                base.Row["Host"] = value;
                return this;
            }

            /// <summary>
            /// 设置地址入口
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUrlEntrance(string value) {
                base.Row["UrlEntrance"] = value;
                return this;
            }

            /// <summary>
            /// 设置脚本入口
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetScriptEntrance(string value) {
                base.Row["ScriptEntrance"] = value;
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
        /// 获取显示文本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Text { get; private set; }

        /// <summary>
        /// 获取加载地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Path { get; private set; }

        /// <summary>
        /// 获取绑定主机字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Host { get; private set; }

        /// <summary>
        /// 获取地址入口字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UrlEntrance { get; private set; }

        /// <summary>
        /// 获取脚本入口字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ScriptEntrance { get; private set; }

        /// <summary>
        /// 获取描述字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Description { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AosDesktops() : base("AosDesktops") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Text = new dpz2.db.SqlUnits.TableField(this, "Text");
            this.Path = new dpz2.db.SqlUnits.TableField(this, "Path");
            this.Host = new dpz2.db.SqlUnits.TableField(this, "Host");
            this.UrlEntrance = new dpz2.db.SqlUnits.TableField(this, "UrlEntrance");
            this.ScriptEntrance = new dpz2.db.SqlUnits.TableField(this, "ScriptEntrance");
            this.Description = new dpz2.db.SqlUnits.TableField(this, "Description");
        }

    }

}
