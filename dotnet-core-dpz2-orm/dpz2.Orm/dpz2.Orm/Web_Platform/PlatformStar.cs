using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Platform {

    /// <summary>
    /// 电商之星表
    /// 电商之星表
    /// Version 1804.0001
    /// </summary>
    public class PlatformStar : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 电商之星表 行数据操作器
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
            /// 设置头像
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAvatar(string value) {
                base.Row["Avatar"] = value;
                return this;
            }

            /// <summary>
            /// 设置介绍
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSummary(string value) {
                base.Row["Summary"] = value;
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
        /// 获取头像字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Avatar { get; private set; }

        /// <summary>
        /// 获取介绍字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Summary { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public PlatformStar() : base("PlatformStar") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Avatar = new dpz2.db.SqlUnits.TableField(this, "Avatar");
            this.Summary = new dpz2.db.SqlUnits.TableField(this, "Summary");
        }

    }

}
