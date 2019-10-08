using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Kernel {

    /// <summary>
    /// 系统常用数据
    /// 系统常用数据
    /// Version 1612.0003
    /// </summary>
    public class SystemGeneralDatas : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 系统常用数据 行数据操作器
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
            /// 设置值
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetValue(string value) {
                base.Row["Value"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属分类
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBelong(string value) {
                base.Row["Belong"] = value;
                return this;
            }

            /// <summary>
            /// 设置数值
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetNumValue(string value) {
                base.Row["NumValue"] = value;
                return this;
            }

            /// <summary>
            /// 设置标志
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFlag(string value) {
                base.Row["Flag"] = value;
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
        /// 获取值字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Value { get; private set; }

        /// <summary>
        /// 获取所属分类字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Belong { get; private set; }

        /// <summary>
        /// 获取数值字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField NumValue { get; private set; }

        /// <summary>
        /// 获取标志字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Flag { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SystemGeneralDatas() : base("SystemGeneralDatas") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Value = new dpz2.db.SqlUnits.TableField(this, "Value");
            this.Belong = new dpz2.db.SqlUnits.TableField(this, "Belong");
            this.NumValue = new dpz2.db.SqlUnits.TableField(this, "NumValue");
            this.Flag = new dpz2.db.SqlUnits.TableField(this, "Flag");
        }

    }

}
