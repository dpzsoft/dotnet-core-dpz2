using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.EM {

    /// <summary>
    /// 联系人信息
    /// 联系人信息
    /// Version 1709.0002
    /// </summary>
    public class EMContact : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 联系人信息 行数据操作器
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
            /// 设置姓名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置关联客户信息
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetClientID(string value) {
                base.Row["ClientID"] = value;
                return this;
            }

            /// <summary>
            /// 设置地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAddress(string value) {
                base.Row["Address"] = value;
                return this;
            }

            /// <summary>
            /// 设置联系电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhone(string value) {
                base.Row["Phone"] = value;
                return this;
            }

            /// <summary>
            /// 设置联系QQ
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetQQ(string value) {
                base.Row["QQ"] = value;
                return this;
            }

            /// <summary>
            /// 设置联系邮箱
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEmail(string value) {
                base.Row["Email"] = value;
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
            /// 设置备注
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRemarks(string value) {
                base.Row["Remarks"] = value;
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
        /// 获取姓名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取关联客户信息字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ClientID { get; private set; }

        /// <summary>
        /// 获取地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Address { get; private set; }

        /// <summary>
        /// 获取联系电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取联系QQ字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField QQ { get; private set; }

        /// <summary>
        /// 获取联系邮箱字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Email { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取备注字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Remarks { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public EMContact() : base("EMContact") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.ClientID = new dpz2.db.SqlUnits.TableField(this, "ClientID");
            this.Address = new dpz2.db.SqlUnits.TableField(this, "Address");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.QQ = new dpz2.db.SqlUnits.TableField(this, "QQ");
            this.Email = new dpz2.db.SqlUnits.TableField(this, "Email");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.Remarks = new dpz2.db.SqlUnits.TableField(this, "Remarks");
        }

    }

}
