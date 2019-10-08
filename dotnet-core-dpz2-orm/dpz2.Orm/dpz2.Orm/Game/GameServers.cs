using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Game {

    /// <summary>
    /// 游戏服务器
    /// 游戏服务器
    /// Version 2016.0401
    /// </summary>
    public class GameServers : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 游戏服务器 行数据操作器
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
            /// 设置服务器名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
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
            /// 设置通讯端口
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPort(string value) {
                base.Row["Port"] = value;
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
        /// 获取服务器名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取IP地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IP { get; private set; }

        /// <summary>
        /// 获取通讯端口字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Port { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public GameServers() : base("GameServers") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.IP = new dpz2.db.SqlUnits.TableField(this, "IP");
            this.Port = new dpz2.db.SqlUnits.TableField(this, "Port");
        }

    }

}
