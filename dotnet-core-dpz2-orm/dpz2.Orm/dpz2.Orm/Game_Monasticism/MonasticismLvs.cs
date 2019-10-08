using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Game_Monasticism {

    /// <summary>
    /// 修真等级
    /// 修真等级
    /// Version 2016.0401
    /// </summary>
    public class MonasticismLvs : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 修真等级 行数据操作器
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
            /// 设置等级名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关等级
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLv(string value) {
                base.Row["Lv"] = value;
                return this;
            }

            /// <summary>
            /// 设置所需经验
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetExp(string value) {
                base.Row["Exp"] = value;
                return this;
            }

            /// <summary>
            /// 设置难度值
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPoint(string value) {
                base.Row["Point"] = value;
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
        /// 获取等级名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取相关等级字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Lv { get; private set; }

        /// <summary>
        /// 获取所需经验字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Exp { get; private set; }

        /// <summary>
        /// 获取难度值字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Point { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public MonasticismLvs() : base("MonasticismLvs") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Lv = new dpz2.db.SqlUnits.TableField(this, "Lv");
            this.Exp = new dpz2.db.SqlUnits.TableField(this, "Exp");
            this.Point = new dpz2.db.SqlUnits.TableField(this, "Point");
        }

    }

}
