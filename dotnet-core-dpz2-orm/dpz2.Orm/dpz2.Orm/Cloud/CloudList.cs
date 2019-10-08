using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Cloud {

    /// <summary>
    /// 云操作目录
    /// 云操作目录
    /// Version 2016.0902
    /// </summary>
    public class CloudList : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 云操作目录 行数据操作器
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
            /// 设置目录名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置识标符
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGuid(string value) {
                base.Row["Guid"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置时间戳
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTimestamp(string value) {
                base.Row["Timestamp"] = value;
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
        /// 获取目录名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取识标符字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Guid { get; private set; }

        /// <summary>
        /// 获取所属用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取时间戳字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Timestamp { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CloudList() : base("CloudList") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Guid = new dpz2.db.SqlUnits.TableField(this, "Guid");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Timestamp = new dpz2.db.SqlUnits.TableField(this, "Timestamp");
        }

    }

}
