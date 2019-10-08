using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Cloud {

    /// <summary>
    /// 云交换文件
    /// 云交换文件
    /// Version 1703.0002
    /// </summary>
    public class CloudExchangeFiles : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 云交换文件 行数据操作器
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
            /// 设置文件标志
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSign(string value) {
                base.Row["Sign"] = value;
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

            /// <summary>
            /// 设置文件存储地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPath(string value) {
                base.Row["Path"] = value;
                return this;
            }

            /// <summary>
            /// 设置文件大小
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSize(string value) {
                base.Row["Size"] = value;
                return this;
            }

            /// <summary>
            /// 设置文件媒体类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMediaType(string value) {
                base.Row["MediaType"] = value;
                return this;
            }

            /// <summary>
            /// 设置图像文件宽度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImgWidth(string value) {
                base.Row["ImgWidth"] = value;
                return this;
            }

            /// <summary>
            /// 设置图像文件高度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImgHeight(string value) {
                base.Row["ImgHeight"] = value;
                return this;
            }

            /// <summary>
            /// 设置文件MD5
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMD5(string value) {
                base.Row["MD5"] = value;
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
            /// 设置上传时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUploadTime(string value) {
                base.Row["UploadTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置上传时间限制
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUploadTimestampLimit(string value) {
                base.Row["UploadTimestampLimit"] = value;
                return this;
            }

            /// <summary>
            /// 设置下载时间限制
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDownTimestampLimit(string value) {
                base.Row["DownTimestampLimit"] = value;
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
        /// 获取文件标志字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Sign { get; private set; }

        /// <summary>
        /// 获取文件名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取文件存储地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Path { get; private set; }

        /// <summary>
        /// 获取文件大小字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Size { get; private set; }

        /// <summary>
        /// 获取文件媒体类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField MediaType { get; private set; }

        /// <summary>
        /// 获取图像文件宽度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ImgWidth { get; private set; }

        /// <summary>
        /// 获取图像文件高度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ImgHeight { get; private set; }

        /// <summary>
        /// 获取文件MD5字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField MD5 { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取上传时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UploadTime { get; private set; }

        /// <summary>
        /// 获取上传时间限制字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UploadTimestampLimit { get; private set; }

        /// <summary>
        /// 获取下载时间限制字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DownTimestampLimit { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CloudExchangeFiles() : base("CloudExchangeFiles") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Sign = new dpz2.db.SqlUnits.TableField(this, "Sign");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Path = new dpz2.db.SqlUnits.TableField(this, "Path");
            this.Size = new dpz2.db.SqlUnits.TableField(this, "Size");
            this.MediaType = new dpz2.db.SqlUnits.TableField(this, "MediaType");
            this.ImgWidth = new dpz2.db.SqlUnits.TableField(this, "ImgWidth");
            this.ImgHeight = new dpz2.db.SqlUnits.TableField(this, "ImgHeight");
            this.MD5 = new dpz2.db.SqlUnits.TableField(this, "MD5");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.UploadTime = new dpz2.db.SqlUnits.TableField(this, "UploadTime");
            this.UploadTimestampLimit = new dpz2.db.SqlUnits.TableField(this, "UploadTimestampLimit");
            this.DownTimestampLimit = new dpz2.db.SqlUnits.TableField(this, "DownTimestampLimit");
        }

    }

}
