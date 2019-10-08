using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Table {

    /// <summary>
    /// 二维表配置
    /// 二维表配置
    /// Version 1712.0002
    /// </summary>
    public class Table2D : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 二维表配置 行数据操作器
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
            /// 设置关联字段
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTableID(string value) {
                base.Row["TableID"] = value;
                return this;
            }

            /// <summary>
            /// 设置显示类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetType(string value) {
                base.Row["Type"] = value;
                return this;
            }

            /// <summary>
            /// 设置是否自定义头部
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHasHeader(string value) {
                base.Row["HasHeader"] = value;
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
        /// 获取关联字段字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TableID { get; private set; }

        /// <summary>
        /// 获取显示类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Type { get; private set; }

        /// <summary>
        /// 获取是否自定义头部字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField HasHeader { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public Table2D() : base("Table2D") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.TableID = new dpz2.db.SqlUnits.TableField(this, "TableID");
            this.Type = new dpz2.db.SqlUnits.TableField(this, "Type");
            this.HasHeader = new dpz2.db.SqlUnits.TableField(this, "HasHeader");
        }

    }

}
