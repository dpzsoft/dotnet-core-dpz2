using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Platform {

    /// <summary>
    /// 点赞信息
    /// 点赞信息
    /// Version 2016.0401
    /// </summary>
    public class PlatformPraise : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 点赞信息 行数据操作器
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
            /// 设置用户编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置商铺编号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetShopID(string value) {
                base.Row["ShopID"] = value;
                return this;
            }

            /// <summary>
            /// 设置IP地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIP(string value) {
                base.Row["IP"] = value;
                return this;
            }

            /// <summary>
            /// 设置点赞时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPraiseTime(string value) {
                base.Row["PraiseTime"] = value;
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
        /// 获取用户编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取商铺编号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ShopID { get; private set; }

        /// <summary>
        /// 获取IP地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IP { get; private set; }

        /// <summary>
        /// 获取点赞时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PraiseTime { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public PlatformPraise() : base("PlatformPraise") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.ShopID = new dpz2.db.SqlUnits.TableField(this, "ShopID");
            this.IP = new dpz2.db.SqlUnits.TableField(this, "IP");
            this.PraiseTime = new dpz2.db.SqlUnits.TableField(this, "PraiseTime");
        }

    }

}
