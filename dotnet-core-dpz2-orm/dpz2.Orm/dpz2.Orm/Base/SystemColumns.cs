using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Base {

    /// <summary>
    /// 数据表字段信息
    /// 数据表字段信息
    /// Version 1706.0003
    /// </summary>
    public class SystemColumns : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 数据表字段信息 行数据操作器
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
            /// 设置所属表格编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetParentID(string value) {
                base.Row["ParentID"] = value;
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
            /// 设置类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetType(string value) {
                base.Row["Type"] = value;
                return this;
            }

            /// <summary>
            /// 设置唯一性
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIsOnly(string value) {
                base.Row["IsOnly"] = value;
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
            /// 设置水平对齐
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAlign(string value) {
                base.Row["Align"] = value;
                return this;
            }

            /// <summary>
            /// 设置宽度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWidth(string value) {
                base.Row["Width"] = value;
                return this;
            }

            /// <summary>
            /// 设置文本长度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLength(string value) {
                base.Row["Length"] = value;
                return this;
            }

            /// <summary>
            /// 设置默认值
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDefaultValue(string value) {
                base.Row["DefaultValue"] = value;
                return this;
            }

            /// <summary>
            /// 设置格式化
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFormat(string value) {
                base.Row["Format"] = value;
                return this;
            }

            /// <summary>
            /// 设置添加时忽略
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAddSlur(string value) {
                base.Row["AddSlur"] = value;
                return this;
            }

            /// <summary>
            /// 设置编辑时忽略
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEditSlur(string value) {
                base.Row["EditSlur"] = value;
                return this;
            }

            /// <summary>
            /// 设置筛选状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIsFilter(string value) {
                base.Row["IsFilter"] = value;
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
            /// 设置权限设置
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLimit(string value) {
                base.Row["Limit"] = value;
                return this;
            }

            /// <summary>
            /// 设置自适应屏幕
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAdaptive(string value) {
                base.Row["Adaptive"] = value;
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
        /// 获取所属表格编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ParentID { get; private set; }

        /// <summary>
        /// 获取识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Text { get; private set; }

        /// <summary>
        /// 获取类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Type { get; private set; }

        /// <summary>
        /// 获取唯一性字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IsOnly { get; private set; }

        /// <summary>
        /// 获取索引字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Index { get; private set; }

        /// <summary>
        /// 获取显示状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Visible { get; private set; }

        /// <summary>
        /// 获取水平对齐字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Align { get; private set; }

        /// <summary>
        /// 获取宽度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Width { get; private set; }

        /// <summary>
        /// 获取文本长度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Length { get; private set; }

        /// <summary>
        /// 获取默认值字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DefaultValue { get; private set; }

        /// <summary>
        /// 获取格式化字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Format { get; private set; }

        /// <summary>
        /// 获取添加时忽略字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AddSlur { get; private set; }

        /// <summary>
        /// 获取编辑时忽略字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EditSlur { get; private set; }

        /// <summary>
        /// 获取筛选状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IsFilter { get; private set; }

        /// <summary>
        /// 获取扩展类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TypeExp { get; private set; }

        /// <summary>
        /// 获取添加事件字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EventAdd { get; private set; }

        /// <summary>
        /// 获取修改事件字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EventEdit { get; private set; }

        /// <summary>
        /// 获取权限设置字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Limit { get; private set; }

        /// <summary>
        /// 获取自适应屏幕字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Adaptive { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SystemColumns() : base("SystemColumns") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ObjectID = new dpz2.db.SqlUnits.TableField(this, "ObjectID");
            this.ParentID = new dpz2.db.SqlUnits.TableField(this, "ParentID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Text = new dpz2.db.SqlUnits.TableField(this, "Text");
            this.Type = new dpz2.db.SqlUnits.TableField(this, "Type");
            this.IsOnly = new dpz2.db.SqlUnits.TableField(this, "IsOnly");
            this.Index = new dpz2.db.SqlUnits.TableField(this, "Index");
            this.Visible = new dpz2.db.SqlUnits.TableField(this, "Visible");
            this.Align = new dpz2.db.SqlUnits.TableField(this, "Align");
            this.Width = new dpz2.db.SqlUnits.TableField(this, "Width");
            this.Length = new dpz2.db.SqlUnits.TableField(this, "Length");
            this.DefaultValue = new dpz2.db.SqlUnits.TableField(this, "DefaultValue");
            this.Format = new dpz2.db.SqlUnits.TableField(this, "Format");
            this.AddSlur = new dpz2.db.SqlUnits.TableField(this, "AddSlur");
            this.EditSlur = new dpz2.db.SqlUnits.TableField(this, "EditSlur");
            this.IsFilter = new dpz2.db.SqlUnits.TableField(this, "IsFilter");
            this.TypeExp = new dpz2.db.SqlUnits.TableField(this, "TypeExp");
            this.EventAdd = new dpz2.db.SqlUnits.TableField(this, "EventAdd");
            this.EventEdit = new dpz2.db.SqlUnits.TableField(this, "EventEdit");
            this.Limit = new dpz2.db.SqlUnits.TableField(this, "Limit");
            this.Adaptive = new dpz2.db.SqlUnits.TableField(this, "Adaptive");
        }

    }

}
