using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Mall {

    /// <summary>
    /// 商城充值表
    /// 商城充值表
    /// Version 2016.0602
    /// </summary>
    public class MallRecharges : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商城充值表 行数据操作器
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
            /// 设置授权识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAuthID(string value) {
                base.Row["AuthID"] = value;
                return this;
            }

            /// <summary>
            /// 设置用户识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置单价
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMoney(string value) {
                base.Row["Money"] = value;
                return this;
            }

            /// <summary>
            /// 设置创建时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCreateTime(string value) {
                base.Row["CreateTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置订单状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStatus(string value) {
                base.Row["Status"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetType(string value) {
                base.Row["Type"] = value;
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
        /// 获取授权识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AuthID { get; private set; }

        /// <summary>
        /// 获取用户识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取单价字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Money { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取订单状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 获取操作类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Type { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public MallRecharges() : base("MallRecharges") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.AuthID = new dpz2.db.SqlUnits.TableField(this, "AuthID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Money = new dpz2.db.SqlUnits.TableField(this, "Money");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
            this.Type = new dpz2.db.SqlUnits.TableField(this, "Type");
        }

    }

}
