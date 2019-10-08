using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Sales3 {

    /// <summary>
    /// 分销系统用户表
    /// 分销系统用户表
    /// Version 1803.0006
    /// </summary>
    public class Sales3Users : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 分销系统用户表 行数据操作器
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
            /// 设置用户名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置姓名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置联系方式
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhone(string value) {
                base.Row["Phone"] = value;
                return this;
            }

            /// <summary>
            /// 设置上级用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetParentID1(string value) {
                base.Row["ParentID1"] = value;
                return this;
            }

            /// <summary>
            /// 设置上二级用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetParentID2(string value) {
                base.Row["ParentID2"] = value;
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
        /// 获取用户名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取姓名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取联系方式字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取上级用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ParentID1 { get; private set; }

        /// <summary>
        /// 获取上二级用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ParentID2 { get; private set; }

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
        public Sales3Users() : base("Sales3Users") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.ParentID1 = new dpz2.db.SqlUnits.TableField(this, "ParentID1");
            this.ParentID2 = new dpz2.db.SqlUnits.TableField(this, "ParentID2");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
