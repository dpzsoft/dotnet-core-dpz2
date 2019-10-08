using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Mall {

    /// <summary>
    /// 商城商品图片表
    /// 商城商品图片表
    /// Version 2016.0602
    /// </summary>
    public class MallGoodImages : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商城商品图片表 行数据操作器
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
            /// 设置相关产品
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGoodID(string value) {
                base.Row["GoodID"] = value;
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
        /// 获取相关产品字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField GoodID { get; private set; }

        /// <summary>
        /// 获取图片地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ImgPath { get; private set; }

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
        public MallGoodImages() : base("MallGoodImages") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.GoodID = new dpz2.db.SqlUnits.TableField(this, "GoodID");
            this.ImgPath = new dpz2.db.SqlUnits.TableField(this, "ImgPath");
            this.Index = new dpz2.db.SqlUnits.TableField(this, "Index");
        }

    }

}
