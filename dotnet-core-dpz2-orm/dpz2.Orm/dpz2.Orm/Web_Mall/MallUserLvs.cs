using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Mall {

    /// <summary>
    /// 商城等级信息表
    /// 商城等级信息表
    /// Version 1709.0002
    /// </summary>
    public class MallUserLvs : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商城等级信息表 行数据操作器
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
            /// 设置等级
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLv(string value) {
                base.Row["Lv"] = value;
                return this;
            }

            /// <summary>
            /// 设置等级名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置所需经验值
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetExp(string value) {
                base.Row["Exp"] = value;
                return this;
            }

            /// <summary>
            /// 设置享受折扣
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDiscount(string value) {
                base.Row["Discount"] = value;
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
        /// 获取等级字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Lv { get; private set; }

        /// <summary>
        /// 获取等级名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取所需经验值字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Exp { get; private set; }

        /// <summary>
        /// 获取享受折扣字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Discount { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public MallUserLvs() : base("MallUserLvs") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Lv = new dpz2.db.SqlUnits.TableField(this, "Lv");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Exp = new dpz2.db.SqlUnits.TableField(this, "Exp");
            this.Discount = new dpz2.db.SqlUnits.TableField(this, "Discount");
        }

    }

}
