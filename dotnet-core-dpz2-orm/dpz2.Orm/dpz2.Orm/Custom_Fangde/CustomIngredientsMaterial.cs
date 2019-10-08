using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Custom_Fangde {

    /// <summary>
    /// 配料所需材料
    /// 配料所需材料
    /// Version 1.0.1809.2
    /// </summary>
    public class CustomIngredientsMaterial : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 配料所需材料 行数据操作器
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
            /// 设置相关配料
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIngredientsID(string value) {
                base.Row["IngredientsID"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关材料
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMaterialID(string value) {
                base.Row["MaterialID"] = value;
                return this;
            }

            /// <summary>
            /// 设置重量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWeight(string value) {
                base.Row["Weight"] = value;
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
        /// 获取相关配料字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IngredientsID { get; private set; }

        /// <summary>
        /// 获取相关材料字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField MaterialID { get; private set; }

        /// <summary>
        /// 获取重量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Weight { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CustomIngredientsMaterial() : base("CustomIngredientsMaterial") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.IngredientsID = new dpz2.db.SqlUnits.TableField(this, "IngredientsID");
            this.MaterialID = new dpz2.db.SqlUnits.TableField(this, "MaterialID");
            this.Weight = new dpz2.db.SqlUnits.TableField(this, "Weight");
        }

    }

}
