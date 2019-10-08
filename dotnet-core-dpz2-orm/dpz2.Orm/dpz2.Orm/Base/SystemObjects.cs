using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Base {

    /// <summary>
    /// 基础对象信息
    /// 基础对象信息
    /// Version 1706.0002
    /// </summary>
    public class SystemObjects : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 基础对象信息 行数据操作器
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
            /// 设置类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetType(string value) {
                base.Row["Type"] = value;
                return this;
            }

            /// <summary>
            /// 设置唯一识标符
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGuid(string value) {
                base.Row["Guid"] = value;
                return this;
            }

            /// <summary>
            /// 设置结构版本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVersion(string value) {
                base.Row["Version"] = value;
                return this;
            }

            /// <summary>
            /// 设置管理版本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOAVersion(string value) {
                base.Row["OAVersion"] = value;
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
        /// 获取类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Type { get; private set; }

        /// <summary>
        /// 获取唯一识标符字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Guid { get; private set; }

        /// <summary>
        /// 获取结构版本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Version { get; private set; }

        /// <summary>
        /// 获取管理版本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OAVersion { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SystemObjects() : base("SystemObjects") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Type = new dpz2.db.SqlUnits.TableField(this, "Type");
            this.Guid = new dpz2.db.SqlUnits.TableField(this, "Guid");
            this.Version = new dpz2.db.SqlUnits.TableField(this, "Version");
            this.OAVersion = new dpz2.db.SqlUnits.TableField(this, "OAVersion");
        }

    }

}
