using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Platform {

    /// <summary>
    /// 平台成员构架表
    /// 平台成员构架表
    /// Version 1706.0001
    /// </summary>
    public class PlatformShopArchitectures : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 平台成员构架表 行数据操作器
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
            /// 设置相关构架
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetArchitectureID(string value) {
                base.Row["ArchitectureID"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关商铺
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetShopID(string value) {
                base.Row["ShopID"] = value;
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
            public RowOperator SetPicture(string value) {
                base.Row["Picture"] = value;
                return this;
            }

            /// <summary>
            /// 设置简介
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
        /// 获取相关构架字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ArchitectureID { get; private set; }

        /// <summary>
        /// 获取相关商铺字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ShopID { get; private set; }

        /// <summary>
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取头像字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Picture { get; private set; }

        /// <summary>
        /// 获取简介字段定义
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
        public PlatformShopArchitectures() : base("PlatformShopArchitectures") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ArchitectureID = new dpz2.db.SqlUnits.TableField(this, "ArchitectureID");
            this.ShopID = new dpz2.db.SqlUnits.TableField(this, "ShopID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Picture = new dpz2.db.SqlUnits.TableField(this, "Picture");
            this.Summary = new dpz2.db.SqlUnits.TableField(this, "Summary");
        }

    }

}
