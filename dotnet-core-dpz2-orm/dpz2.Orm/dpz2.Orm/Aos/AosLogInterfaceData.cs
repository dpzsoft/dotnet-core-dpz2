using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 接口数据日志
    /// 接口数据日志
    /// Version 1711.0002
    /// </summary>
    public class AosLogInterfaceData : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 接口数据日志 行数据操作器
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
            /// 设置日志时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLogTime(string value) {
                base.Row["LogTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置接口地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUrl(string value) {
                base.Row["Url"] = value;
                return this;
            }

            /// <summary>
            /// 设置IP地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIPAddress(string value) {
                base.Row["IPAddress"] = value;
                return this;
            }

            /// <summary>
            /// 设置日志详情
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLogData(string value) {
                base.Row["LogData"] = value;
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
        /// 获取日志时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LogTime { get; private set; }

        /// <summary>
        /// 获取接口地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Url { get; private set; }

        /// <summary>
        /// 获取IP地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IPAddress { get; private set; }

        /// <summary>
        /// 获取日志详情字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LogData { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AosLogInterfaceData() : base("AosLogInterfaceData") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.LogTime = new dpz2.db.SqlUnits.TableField(this, "LogTime");
            this.Url = new dpz2.db.SqlUnits.TableField(this, "Url");
            this.IPAddress = new dpz2.db.SqlUnits.TableField(this, "IPAddress");
            this.LogData = new dpz2.db.SqlUnits.TableField(this, "LogData");
        }

    }

}
