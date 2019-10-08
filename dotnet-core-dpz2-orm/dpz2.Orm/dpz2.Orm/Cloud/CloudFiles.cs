using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Cloud {

    /// <summary>
    /// 云文件
    /// 云文件
    /// Version 2016.1106
    /// </summary>
    public class CloudFiles : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 云文件 行数据操作器
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
            /// 设置文件存储地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPath(string value) {
                base.Row["Path"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关云信息
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCloudID(string value) {
                base.Row["CloudID"] = value;
                return this;
            }

            /// <summary>
            /// 设置文件类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFileType(string value) {
                base.Row["FileType"] = value;
                return this;
            }

            /// <summary>
            /// 设置父路径
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetParentPath(string value) {
                base.Row["ParentPath"] = value;
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

            /// <summary>
            /// 设置时间戳
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTimestamp(string value) {
                base.Row["Timestamp"] = value;
                return this;
            }

            /// <summary>
            /// 设置文件名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
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
        /// 获取文件存储地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Path { get; private set; }

        /// <summary>
        /// 获取相关云信息字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CloudID { get; private set; }

        /// <summary>
        /// 获取文件类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FileType { get; private set; }

        /// <summary>
        /// 获取父路径字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ParentPath { get; private set; }

        /// <summary>
        /// 获取状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 获取时间戳字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Timestamp { get; private set; }

        /// <summary>
        /// 获取文件名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CloudFiles() : base("CloudFiles") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Path = new dpz2.db.SqlUnits.TableField(this, "Path");
            this.CloudID = new dpz2.db.SqlUnits.TableField(this, "CloudID");
            this.FileType = new dpz2.db.SqlUnits.TableField(this, "FileType");
            this.ParentPath = new dpz2.db.SqlUnits.TableField(this, "ParentPath");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
            this.Timestamp = new dpz2.db.SqlUnits.TableField(this, "Timestamp");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
        }

    }

}
