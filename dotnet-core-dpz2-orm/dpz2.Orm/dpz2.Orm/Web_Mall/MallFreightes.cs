using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Mall {

    /// <summary>
    /// 商城运费定义
    /// 商城运费定义
    /// Version 1705.0001
    /// </summary>
    public class MallFreightes : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商城运费定义 行数据操作器
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
            /// 设置省份
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProvince(string value) {
                base.Row["Province"] = value;
                return this;
            }

            /// <summary>
            /// 设置运费
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFreight(string value) {
                base.Row["Freight"] = value;
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
        /// 获取省份字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Province { get; private set; }

        /// <summary>
        /// 获取运费字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Freight { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public MallFreightes() : base("MallFreightes") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Province = new dpz2.db.SqlUnits.TableField(this, "Province");
            this.Freight = new dpz2.db.SqlUnits.TableField(this, "Freight");
        }

    }

}
