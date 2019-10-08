using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.App {

    /// <summary>
    /// 应用信息
    /// 应用信息
    /// Version 1708.0002
    /// </summary>
    public class AppInfos : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 应用信息 行数据操作器
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
            /// 设置显示文本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetText(string value) {
                base.Row["Text"] = value;
                return this;
            }

            /// <summary>
            /// 设置应用地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPath(string value) {
                base.Row["Path"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作权限限制
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLimit(string value) {
                base.Row["Limit"] = value;
                return this;
            }

            /// <summary>
            /// 设置是否出现在商城
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOnStore(string value) {
                base.Row["OnStore"] = value;
                return this;
            }

            /// <summary>
            /// 设置是否拥有设置
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHasSetting(string value) {
                base.Row["HasSetting"] = value;
                return this;
            }

            /// <summary>
            /// 设置描述
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDescription(string value) {
                base.Row["Description"] = value;
                return this;
            }

            /// <summary>
            /// 设置分类标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCatalogID(string value) {
                base.Row["CatalogID"] = value;
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
        /// 获取显示文本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Text { get; private set; }

        /// <summary>
        /// 获取应用地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Path { get; private set; }

        /// <summary>
        /// 获取操作权限限制字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Limit { get; private set; }

        /// <summary>
        /// 获取是否出现在商城字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OnStore { get; private set; }

        /// <summary>
        /// 获取是否拥有设置字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField HasSetting { get; private set; }

        /// <summary>
        /// 获取描述字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Description { get; private set; }

        /// <summary>
        /// 获取分类标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CatalogID { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AppInfos() : base("AppInfos") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ObjectID = new dpz2.db.SqlUnits.TableField(this, "ObjectID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Text = new dpz2.db.SqlUnits.TableField(this, "Text");
            this.Path = new dpz2.db.SqlUnits.TableField(this, "Path");
            this.Limit = new dpz2.db.SqlUnits.TableField(this, "Limit");
            this.OnStore = new dpz2.db.SqlUnits.TableField(this, "OnStore");
            this.HasSetting = new dpz2.db.SqlUnits.TableField(this, "HasSetting");
            this.Description = new dpz2.db.SqlUnits.TableField(this, "Description");
            this.CatalogID = new dpz2.db.SqlUnits.TableField(this, "CatalogID");
        }

    }

}
