using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 权限定义
    /// 权限定义
    /// Version 1612.0002
    /// </summary>
    public class AosLimits : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 权限定义 行数据操作器
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
            /// 设置权限名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置权限类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetType(string value) {
                base.Row["Type"] = value;
                return this;
            }

            /// <summary>
            /// 设置权限内容
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLimit(string value) {
                base.Row["Limit"] = value;
                return this;
            }

            /// <summary>
            /// 设置显示名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetText(string value) {
                base.Row["Text"] = value;
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
        /// 获取权限名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取权限类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Type { get; private set; }

        /// <summary>
        /// 获取权限内容字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Limit { get; private set; }

        /// <summary>
        /// 获取显示名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Text { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AosLimits() : base("AosLimits") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Type = new dpz2.db.SqlUnits.TableField(this, "Type");
            this.Limit = new dpz2.db.SqlUnits.TableField(this, "Limit");
            this.Text = new dpz2.db.SqlUnits.TableField(this, "Text");
        }

    }

}
