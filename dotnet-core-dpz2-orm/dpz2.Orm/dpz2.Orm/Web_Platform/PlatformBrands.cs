using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Platform {

    /// <summary>
    /// 品牌信息
    /// 品牌信息
    /// Version 2016.0401
    /// </summary>
    public class PlatformBrands : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 品牌信息 行数据操作器
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
            /// 设置所属分类
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBelong(string value) {
                base.Row["Belong"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关图像
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImage(string value) {
                base.Row["Image"] = value;
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
        /// 获取所属分类字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Belong { get; private set; }

        /// <summary>
        /// 获取相关图像字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Image { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public PlatformBrands() : base("PlatformBrands") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Belong = new dpz2.db.SqlUnits.TableField(this, "Belong");
            this.Image = new dpz2.db.SqlUnits.TableField(this, "Image");
        }

    }

}
