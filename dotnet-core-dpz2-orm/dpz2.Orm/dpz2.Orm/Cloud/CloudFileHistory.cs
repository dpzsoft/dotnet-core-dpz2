using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Cloud {

    /// <summary>
    /// 云文件更新历史
    /// 云文件更新历史
    /// Version 2016.0401
    /// </summary>
    public class CloudFileHistory : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 云文件更新历史 行数据操作器
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
            /// 设置相关文件
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFileID(string value) {
                base.Row["FileID"] = value;
                return this;
            }

            /// <summary>
            /// 设置控制版本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVersion(string value) {
                base.Row["Version"] = value;
                return this;
            }

            /// <summary>
            /// 设置存储地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSavePath(string value) {
                base.Row["SavePath"] = value;
                return this;
            }

            /// <summary>
            /// 设置文件长度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLength(string value) {
                base.Row["Length"] = value;
                return this;
            }

            /// <summary>
            /// 设置MD5校验
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMD5(string value) {
                base.Row["MD5"] = value;
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
        /// 获取相关文件字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FileID { get; private set; }

        /// <summary>
        /// 获取控制版本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Version { get; private set; }

        /// <summary>
        /// 获取存储地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SavePath { get; private set; }

        /// <summary>
        /// 获取文件长度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Length { get; private set; }

        /// <summary>
        /// 获取MD5校验字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField MD5 { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CloudFileHistory() : base("CloudFileHistory") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.FileID = new dpz2.db.SqlUnits.TableField(this, "FileID");
            this.Version = new dpz2.db.SqlUnits.TableField(this, "Version");
            this.SavePath = new dpz2.db.SqlUnits.TableField(this, "SavePath");
            this.Length = new dpz2.db.SqlUnits.TableField(this, "Length");
            this.MD5 = new dpz2.db.SqlUnits.TableField(this, "MD5");
        }

    }

}
