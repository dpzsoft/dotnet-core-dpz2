using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Jxc {

    /// <summary>
    /// 账套成员信息
    /// 账套成员信息
    /// Version 1.0.1906.1
    /// </summary>
    public class JxcBookMember : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 账套成员信息 行数据操作器
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
            /// 设置账套标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBookID(string value) {
                base.Row["BookID"] = value;
                return this;
            }

            /// <summary>
            /// 设置用户标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStatus(string value) {
                base.Row["Status"] = value;
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
        /// 获取账套标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BookID { get; private set; }

        /// <summary>
        /// 获取用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public JxcBookMember() : base("JxcBookMember") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.BookID = new dpz2.db.SqlUnits.TableField(this, "BookID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
