using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Mall {

    /// <summary>
    /// 商品访问记录
    /// 商品访问记录
    /// Version 2016.0601
    /// </summary>
    public class MallGoodVisited : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商品访问记录 行数据操作器
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
            /// 设置用户标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置商品标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGoodID(string value) {
                base.Row["GoodID"] = value;
                return this;
            }

            /// <summary>
            /// 设置访问时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVisitTime(string value) {
                base.Row["VisitTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置商品关键字
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVisitKey(string value) {
                base.Row["VisitKey"] = value;
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
        /// 获取用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取商品标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField GoodID { get; private set; }

        /// <summary>
        /// 获取访问时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField VisitTime { get; private set; }

        /// <summary>
        /// 获取商品关键字字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField VisitKey { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public MallGoodVisited() : base("MallGoodVisited") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.GoodID = new dpz2.db.SqlUnits.TableField(this, "GoodID");
            this.VisitTime = new dpz2.db.SqlUnits.TableField(this, "VisitTime");
            this.VisitKey = new dpz2.db.SqlUnits.TableField(this, "VisitKey");
        }

    }

}
