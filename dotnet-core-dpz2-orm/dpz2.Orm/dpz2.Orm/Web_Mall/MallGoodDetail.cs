using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Mall {

    /// <summary>
    /// 商城商品详情表
    /// 商城商品详情表
    /// Version 1511.2801
    /// </summary>
    public class MallGoodDetail : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商城商品详情表 行数据操作器
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
            /// 设置商品识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGoodID(string value) {
                base.Row["GoodID"] = value;
                return this;
            }

            /// <summary>
            /// 设置排序
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIndex(string value) {
                base.Row["Index"] = value;
                return this;
            }

            /// <summary>
            /// 设置段落标题
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTitle(string value) {
                base.Row["Title"] = value;
                return this;
            }

            /// <summary>
            /// 设置详情
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDetail(string value) {
                base.Row["Detail"] = value;
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
        /// 获取商品识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField GoodID { get; private set; }

        /// <summary>
        /// 获取排序字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Index { get; private set; }

        /// <summary>
        /// 获取段落标题字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Title { get; private set; }

        /// <summary>
        /// 获取详情字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Detail { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public MallGoodDetail() : base("MallGoodDetail") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.GoodID = new dpz2.db.SqlUnits.TableField(this, "GoodID");
            this.Index = new dpz2.db.SqlUnits.TableField(this, "Index");
            this.Title = new dpz2.db.SqlUnits.TableField(this, "Title");
            this.Detail = new dpz2.db.SqlUnits.TableField(this, "Detail");
        }

    }

}
