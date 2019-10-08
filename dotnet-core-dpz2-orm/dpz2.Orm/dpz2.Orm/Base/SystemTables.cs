using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Base {

    /// <summary>
    /// 数据表信息
    /// 数据表信息
    /// Version 1706.0002
    /// </summary>
    public class SystemTables : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 数据表信息 行数据操作器
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
            /// 设置识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetText(string value) {
                base.Row["Text"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属目录
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCatalogID(string value) {
                base.Row["CatalogID"] = value;
                return this;
            }

            /// <summary>
            /// 设置表格类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTableTypeID(string value) {
                base.Row["TableTypeID"] = value;
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
            /// 设置扩展类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTypeExp(string value) {
                base.Row["TypeExp"] = value;
                return this;
            }

            /// <summary>
            /// 设置索引
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIndex(string value) {
                base.Row["Index"] = value;
                return this;
            }

            /// <summary>
            /// 设置显示状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVisible(string value) {
                base.Row["Visible"] = value;
                return this;
            }

            /// <summary>
            /// 设置自定义Sql语句
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCustomSQL(string value) {
                base.Row["CustomSQL"] = value;
                return this;
            }

            /// <summary>
            /// 设置继承表格
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetInheritTable(string value) {
                base.Row["InheritTable"] = value;
                return this;
            }

            /// <summary>
            /// 设置继承设定
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetInheritSetting(string value) {
                base.Row["InheritSetting"] = value;
                return this;
            }

            /// <summary>
            /// 设置添加事件
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEventAdd(string value) {
                base.Row["EventAdd"] = value;
                return this;
            }

            /// <summary>
            /// 设置修改事件
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEventEdit(string value) {
                base.Row["EventEdit"] = value;
                return this;
            }

            /// <summary>
            /// 设置保存检测
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSaveCheck(string value) {
                base.Row["SaveCheck"] = value;
                return this;
            }

            /// <summary>
            /// 设置等级
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLv(string value) {
                base.Row["Lv"] = value;
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
        /// 获取识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Text { get; private set; }

        /// <summary>
        /// 获取所属目录字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CatalogID { get; private set; }

        /// <summary>
        /// 获取表格类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TableTypeID { get; private set; }

        /// <summary>
        /// 获取类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Type { get; private set; }

        /// <summary>
        /// 获取扩展类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TypeExp { get; private set; }

        /// <summary>
        /// 获取索引字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Index { get; private set; }

        /// <summary>
        /// 获取显示状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Visible { get; private set; }

        /// <summary>
        /// 获取自定义Sql语句字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CustomSQL { get; private set; }

        /// <summary>
        /// 获取继承表格字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField InheritTable { get; private set; }

        /// <summary>
        /// 获取继承设定字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField InheritSetting { get; private set; }

        /// <summary>
        /// 获取添加事件字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EventAdd { get; private set; }

        /// <summary>
        /// 获取修改事件字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EventEdit { get; private set; }

        /// <summary>
        /// 获取保存检测字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SaveCheck { get; private set; }

        /// <summary>
        /// 获取等级字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Lv { get; private set; }

        /// <summary>
        /// 获取存储地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SavePath { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SystemTables() : base("SystemTables") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ObjectID = new dpz2.db.SqlUnits.TableField(this, "ObjectID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Text = new dpz2.db.SqlUnits.TableField(this, "Text");
            this.CatalogID = new dpz2.db.SqlUnits.TableField(this, "CatalogID");
            this.TableTypeID = new dpz2.db.SqlUnits.TableField(this, "TableTypeID");
            this.Type = new dpz2.db.SqlUnits.TableField(this, "Type");
            this.TypeExp = new dpz2.db.SqlUnits.TableField(this, "TypeExp");
            this.Index = new dpz2.db.SqlUnits.TableField(this, "Index");
            this.Visible = new dpz2.db.SqlUnits.TableField(this, "Visible");
            this.CustomSQL = new dpz2.db.SqlUnits.TableField(this, "CustomSQL");
            this.InheritTable = new dpz2.db.SqlUnits.TableField(this, "InheritTable");
            this.InheritSetting = new dpz2.db.SqlUnits.TableField(this, "InheritSetting");
            this.EventAdd = new dpz2.db.SqlUnits.TableField(this, "EventAdd");
            this.EventEdit = new dpz2.db.SqlUnits.TableField(this, "EventEdit");
            this.SaveCheck = new dpz2.db.SqlUnits.TableField(this, "SaveCheck");
            this.Lv = new dpz2.db.SqlUnits.TableField(this, "Lv");
            this.SavePath = new dpz2.db.SqlUnits.TableField(this, "SavePath");
        }

    }

}
