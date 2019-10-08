using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Platform {

    /// <summary>
    /// 商家注册
    /// 商家注册
    /// Version 1701.0001
    /// </summary>
    public class PlatformReg : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商家注册 行数据操作器
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
            /// 设置名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置城市
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCity(string value) {
                base.Row["City"] = value;
                return this;
            }

            /// <summary>
            /// 设置联系人
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetContact(string value) {
                base.Row["Contact"] = value;
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
            /// 设置操作IP
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOperateIP(string value) {
                base.Row["OperateIP"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOperateTime(string value) {
                base.Row["OperateTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置所在城市
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOperateCity(string value) {
                base.Row["OperateCity"] = value;
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
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取城市字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField City { get; private set; }

        /// <summary>
        /// 获取联系人字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Contact { get; private set; }

        /// <summary>
        /// 获取联系电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取联系QQ字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField QQ { get; private set; }

        /// <summary>
        /// 获取操作IP字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OperateIP { get; private set; }

        /// <summary>
        /// 获取操作时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OperateTime { get; private set; }

        /// <summary>
        /// 获取所在城市字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OperateCity { get; private set; }

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
        public PlatformReg() : base("PlatformReg") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.City = new dpz2.db.SqlUnits.TableField(this, "City");
            this.Contact = new dpz2.db.SqlUnits.TableField(this, "Contact");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.QQ = new dpz2.db.SqlUnits.TableField(this, "QQ");
            this.OperateIP = new dpz2.db.SqlUnits.TableField(this, "OperateIP");
            this.OperateTime = new dpz2.db.SqlUnits.TableField(this, "OperateTime");
            this.OperateCity = new dpz2.db.SqlUnits.TableField(this, "OperateCity");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
