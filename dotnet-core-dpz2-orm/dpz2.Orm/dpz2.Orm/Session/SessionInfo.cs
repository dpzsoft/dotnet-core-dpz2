using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Session {

    /// <summary>
    /// 交互信息
    /// 交互信息
    /// Version 1807.0002
    /// </summary>
    public class SessionInfo : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 交互信息 行数据操作器
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
            /// 设置交互识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSessionID(string value) {
                base.Row["SessionID"] = value;
                return this;
            }

            /// <summary>
            /// 设置有效时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetExpireTime(string value) {
                base.Row["ExpireTime"] = value;
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
        /// 获取交互识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SessionID { get; private set; }

        /// <summary>
        /// 获取有效时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ExpireTime { get; private set; }

        /// <summary>
        /// 获取IP地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IP { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SessionInfo() : base("SessionInfo") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.SessionID = new dpz2.db.SqlUnits.TableField(this, "SessionID");
            this.ExpireTime = new dpz2.db.SqlUnits.TableField(this, "ExpireTime");
            this.IP = new dpz2.db.SqlUnits.TableField(this, "IP");
        }

    }

}
