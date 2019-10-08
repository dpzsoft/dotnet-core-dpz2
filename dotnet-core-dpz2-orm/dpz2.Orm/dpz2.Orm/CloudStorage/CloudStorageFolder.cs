using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.CloudStorage {

    /// <summary>
    /// 云文件夹
    /// 云文件夹
    /// Version 1806.0002
    /// </summary>
    public class CloudStorageFolder : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 云文件夹 行数据操作器
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
            /// 设置对象标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetObjectID(string value) {
                base.Row["ObjectID"] = value;
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
            /// 设置所属磁盘
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDiskID(string value) {
                base.Row["DiskID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属文件夹
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetParentFolderID(string value) {
                base.Row["ParentFolderID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属路径
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetParentPath(string value) {
                base.Row["ParentPath"] = value;
                return this;
            }

            /// <summary>
            /// 设置属性值
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAttributes(string value) {
                base.Row["Attributes"] = value;
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
        /// 获取对象标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ObjectID { get; private set; }

        /// <summary>
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取所属磁盘字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DiskID { get; private set; }

        /// <summary>
        /// 获取所属文件夹字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ParentFolderID { get; private set; }

        /// <summary>
        /// 获取所属路径字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ParentPath { get; private set; }

        /// <summary>
        /// 获取属性值字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Attributes { get; private set; }

        /// <summary>
        /// 获取时间戳字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Timestamp { get; private set; }

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
        public CloudStorageFolder() : base("CloudStorageFolder") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ObjectID = new dpz2.db.SqlUnits.TableField(this, "ObjectID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.DiskID = new dpz2.db.SqlUnits.TableField(this, "DiskID");
            this.ParentFolderID = new dpz2.db.SqlUnits.TableField(this, "ParentFolderID");
            this.ParentPath = new dpz2.db.SqlUnits.TableField(this, "ParentPath");
            this.Attributes = new dpz2.db.SqlUnits.TableField(this, "Attributes");
            this.Timestamp = new dpz2.db.SqlUnits.TableField(this, "Timestamp");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
