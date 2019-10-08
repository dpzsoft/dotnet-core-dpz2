using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Platform {

    /// <summary>
    /// 搜索历史纪录
    /// 搜索历史纪录
    /// Version 2016.0501
    /// </summary>
    public class PlatformSearchHistory : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 搜索历史纪录 行数据操作器
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
            /// 设置关键字
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetKey(string value) {
                base.Row["Key"] = value;
                return this;
            }

            /// <summary>
            /// 设置相关用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOperateTime(string value) {
                base.Row["OperateTime"] = value;
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
        /// 获取关键字字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Key { get; private set; }

        /// <summary>
        /// 获取相关用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取操作时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OperateTime { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public PlatformSearchHistory() : base("PlatformSearchHistory") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Key = new dpz2.db.SqlUnits.TableField(this, "Key");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.OperateTime = new dpz2.db.SqlUnits.TableField(this, "OperateTime");
        }

    }

}
