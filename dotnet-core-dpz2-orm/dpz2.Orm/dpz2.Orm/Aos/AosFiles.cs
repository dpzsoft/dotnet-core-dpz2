using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 文件信息
    /// 文件信息
    /// Version 1709.0001
    /// </summary>
    public class AosFiles : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 文件信息 行数据操作器
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
            /// 设置标识符
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGuid(string value) {
                base.Row["Guid"] = value;
                return this;
            }

            /// <summary>
            /// 设置交互标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSessionID(string value) {
                base.Row["SessionID"] = value;
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
            /// 设置存储路径
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPath(string value) {
                base.Row["Path"] = value;
                return this;
            }

            /// <summary>
            /// 设置校验码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMD5(string value) {
                base.Row["MD5"] = value;
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
            /// 设置创建时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCreateTime(string value) {
                base.Row["CreateTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置创建时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUploadTime(string value) {
                base.Row["UploadTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置有效时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEffectiveTime(string value) {
                base.Row["EffectiveTime"] = value;
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
        /// 获取标识符字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Guid { get; private set; }

        /// <summary>
        /// 获取交互标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SessionID { get; private set; }

        /// <summary>
        /// 获取用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取存储路径字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Path { get; private set; }

        /// <summary>
        /// 获取校验码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField MD5 { get; private set; }

        /// <summary>
        /// 获取文件长度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Length { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UploadTime { get; private set; }

        /// <summary>
        /// 获取有效时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EffectiveTime { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AosFiles() : base("AosFiles") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Guid = new dpz2.db.SqlUnits.TableField(this, "Guid");
            this.SessionID = new dpz2.db.SqlUnits.TableField(this, "SessionID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Path = new dpz2.db.SqlUnits.TableField(this, "Path");
            this.MD5 = new dpz2.db.SqlUnits.TableField(this, "MD5");
            this.Length = new dpz2.db.SqlUnits.TableField(this, "Length");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.UploadTime = new dpz2.db.SqlUnits.TableField(this, "UploadTime");
            this.EffectiveTime = new dpz2.db.SqlUnits.TableField(this, "EffectiveTime");
        }

    }

}
