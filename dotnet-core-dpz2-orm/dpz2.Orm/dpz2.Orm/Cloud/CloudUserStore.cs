using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Cloud {

    /// <summary>
    /// 云用户库
    /// 云用户库
    /// Version 2016.0801
    /// </summary>
    public class CloudUserStore : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 云用户库 行数据操作器
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
            /// 设置用户标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
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
            /// 设置云存储标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFileID(string value) {
                base.Row["FileID"] = value;
                return this;
            }

            /// <summary>
            /// 设置权限
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLimit(string value) {
                base.Row["Limit"] = value;
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
        /// 获取用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取云存储标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FileID { get; private set; }

        /// <summary>
        /// 获取权限字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Limit { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CloudUserStore() : base("CloudUserStore") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.FileID = new dpz2.db.SqlUnits.TableField(this, "FileID");
            this.Limit = new dpz2.db.SqlUnits.TableField(this, "Limit");
        }

    }

}
