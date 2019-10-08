using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_YYMall {

    /// <summary>
    /// 一元晒单图片
    /// 一元晒单图片
    /// Version 2016.0601
    /// </summary>
    public class YYGoodShowImage : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 一元晒单图片 行数据操作器
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
            /// 设置晒单标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGoodShowID(string value) {
                base.Row["GoodShowID"] = value;
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
        /// 获取晒单标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField GoodShowID { get; private set; }

        /// <summary>
        /// 获取图片地址字段定义
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
        public YYGoodShowImage() : base("YYGoodShowImage") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.GoodShowID = new dpz2.db.SqlUnits.TableField(this, "GoodShowID");
            this.ImgPath = new dpz2.db.SqlUnits.TableField(this, "ImgPath");
        }

    }

}
