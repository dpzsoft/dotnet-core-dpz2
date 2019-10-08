using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Game_Monasticism {

    /// <summary>
    /// 修真用户
    /// 修真用户
    /// Version 2016.0401
    /// </summary>
    public class MonasticismUsers : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 修真用户 行数据操作器
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
            /// 设置用户编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置攻击值
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAttack(string value) {
                base.Row["Attack"] = value;
                return this;
            }

            /// <summary>
            /// 设置防御值
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDefense(string value) {
                base.Row["Defense"] = value;
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
        /// 获取用户编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取攻击值字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Attack { get; private set; }

        /// <summary>
        /// 获取防御值字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Defense { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public MonasticismUsers() : base("MonasticismUsers") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Attack = new dpz2.db.SqlUnits.TableField(this, "Attack");
            this.Defense = new dpz2.db.SqlUnits.TableField(this, "Defense");
        }

    }

}
