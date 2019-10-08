using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Cloud {

    /// <summary>
    /// 云更新历史
    /// 云更新历史
    /// Version 2016.0401
    /// </summary>
    public class CloudHistory : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 云更新历史 行数据操作器
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
            /// 设置相关云信息
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCloudID(string value) {
                base.Row["CloudID"] = value;
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
            /// 设置版本名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVersionName(string value) {
                base.Row["VersionName"] = value;
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
        /// 获取相关云信息字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CloudID { get; private set; }

        /// <summary>
        /// 获取控制版本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Version { get; private set; }

        /// <summary>
        /// 获取版本名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField VersionName { get; private set; }

        /// <summary>
        /// 获取识标符字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Guid { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CloudHistory() : base("CloudHistory") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.CloudID = new dpz2.db.SqlUnits.TableField(this, "CloudID");
            this.Version = new dpz2.db.SqlUnits.TableField(this, "Version");
            this.VersionName = new dpz2.db.SqlUnits.TableField(this, "VersionName");
            this.Guid = new dpz2.db.SqlUnits.TableField(this, "Guid");
        }

    }

}
