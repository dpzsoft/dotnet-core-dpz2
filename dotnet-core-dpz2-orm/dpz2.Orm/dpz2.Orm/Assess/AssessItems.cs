using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Assess {

    /// <summary>
    /// 考核项
    /// 考核项
    /// Version 1711.0003
    /// </summary>
    public class AssessItems : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 考核项 行数据操作器
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
            /// 设置考核标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAssessID(string value) {
                base.Row["AssessID"] = value;
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
            /// 设置显示名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetText(string value) {
                base.Row["Text"] = value;
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
            /// 设置描述
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDescription(string value) {
                base.Row["Description"] = value;
                return this;
            }

            /// <summary>
            /// 设置评分单位
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetScoreUnit(string value) {
                base.Row["ScoreUnit"] = value;
                return this;
            }

            /// <summary>
            /// 设置总分
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetScore(string value) {
                base.Row["Score"] = value;
                return this;
            }

            /// <summary>
            /// 设置手工操作项
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIsOpearte(string value) {
                base.Row["IsOpearte"] = value;
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
        /// 获取考核标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AssessID { get; private set; }

        /// <summary>
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取显示名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Text { get; private set; }

        /// <summary>
        /// 获取索引字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Index { get; private set; }

        /// <summary>
        /// 获取描述字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Description { get; private set; }

        /// <summary>
        /// 获取评分单位字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ScoreUnit { get; private set; }

        /// <summary>
        /// 获取总分字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Score { get; private set; }

        /// <summary>
        /// 获取手工操作项字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IsOpearte { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AssessItems() : base("AssessItems") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.AssessID = new dpz2.db.SqlUnits.TableField(this, "AssessID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Text = new dpz2.db.SqlUnits.TableField(this, "Text");
            this.Index = new dpz2.db.SqlUnits.TableField(this, "Index");
            this.Description = new dpz2.db.SqlUnits.TableField(this, "Description");
            this.ScoreUnit = new dpz2.db.SqlUnits.TableField(this, "ScoreUnit");
            this.Score = new dpz2.db.SqlUnits.TableField(this, "Score");
            this.IsOpearte = new dpz2.db.SqlUnits.TableField(this, "IsOpearte");
        }

    }

}
