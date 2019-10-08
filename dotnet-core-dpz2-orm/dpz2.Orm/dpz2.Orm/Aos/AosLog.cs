using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 日志
    /// 日志
    /// Version 1512.0501
    /// </summary>
    public class AosLog : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 日志 行数据操作器
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
            /// 设置授权识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAuthID(string value) {
                base.Row["AuthID"] = value;
                return this;
            }

            /// <summary>
            /// 设置会话识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSessionID(string value) {
                base.Row["SessionID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属分类
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置创建时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCreateTime(string value) {
                base.Row["CreateTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置日志等级
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLv(string value) {
                base.Row["Lv"] = value;
                return this;
            }

            /// <summary>
            /// 设置类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetType(string value) {
                base.Row["Type"] = value;
                return this;
            }

            /// <summary>
            /// 设置摘要
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSummary(string value) {
                base.Row["Summary"] = value;
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
        /// 获取授权识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AuthID { get; private set; }

        /// <summary>
        /// 获取会话识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SessionID { get; private set; }

        /// <summary>
        /// 获取所属分类字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取日志等级字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Lv { get; private set; }

        /// <summary>
        /// 获取类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Type { get; private set; }

        /// <summary>
        /// 获取摘要字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Summary { get; private set; }

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
        public AosLog() : base("AosLog") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.AuthID = new dpz2.db.SqlUnits.TableField(this, "AuthID");
            this.SessionID = new dpz2.db.SqlUnits.TableField(this, "SessionID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.Lv = new dpz2.db.SqlUnits.TableField(this, "Lv");
            this.Type = new dpz2.db.SqlUnits.TableField(this, "Type");
            this.Summary = new dpz2.db.SqlUnits.TableField(this, "Summary");
            this.Detail = new dpz2.db.SqlUnits.TableField(this, "Detail");
        }

    }

}
