using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Kernel {

    /// <summary>
    /// 系统图像库
    /// 系统图像库
    /// Version 1512.0701
    /// </summary>
    public class SystemImages : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 系统图像库 行数据操作器
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
            /// 设置路径
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImgPath(string value) {
                base.Row["ImgPath"] = value;
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
        /// 获取路径字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ImgPath { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SystemImages() : base("SystemImages") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.ImgPath = new dpz2.db.SqlUnits.TableField(this, "ImgPath");
        }

    }

}
