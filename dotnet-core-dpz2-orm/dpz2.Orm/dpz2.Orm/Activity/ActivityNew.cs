using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Activity {

    /// <summary>
    /// 最新活动
    /// 最新活动
    /// Version 1.0.1810.2
    /// </summary>
    public class ActivityNew : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 最新活动 行数据操作器
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
            /// 设置标题
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTitle(string value) {
                base.Row["Title"] = value;
                return this;
            }

            /// <summary>
            /// 设置图片地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImgPath(string value) {
                base.Row["ImgPath"] = value;
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
            /// 设置排序索引
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIndex(string value) {
                base.Row["Index"] = value;
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
        /// 获取标题字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Title { get; private set; }

        /// <summary>
        /// 获取图片地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ImgPath { get; private set; }

        /// <summary>
        /// 获取描述字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Description { get; private set; }

        /// <summary>
        /// 获取排序索引字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Index { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public ActivityNew() : base("ActivityNew") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Title = new dpz2.db.SqlUnits.TableField(this, "Title");
            this.ImgPath = new dpz2.db.SqlUnits.TableField(this, "ImgPath");
            this.Description = new dpz2.db.SqlUnits.TableField(this, "Description");
            this.Index = new dpz2.db.SqlUnits.TableField(this, "Index");
        }

    }

}
