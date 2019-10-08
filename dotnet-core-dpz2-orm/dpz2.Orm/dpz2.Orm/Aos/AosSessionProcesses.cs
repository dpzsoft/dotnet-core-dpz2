using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 交互线程信息
    /// 交互线程信息
    /// Version 2016.0601
    /// </summary>
    public class AosSessionProcesses : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 交互线程信息 行数据操作器
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
            /// 设置交互实体标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEntityID(string value) {
                base.Row["EntityID"] = value;
                return this;
            }

            /// <summary>
            /// 设置交互线程标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProcessID(string value) {
                base.Row["ProcessID"] = value;
                return this;
            }

            /// <summary>
            /// 设置交互密钥
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSessionKey(string value) {
                base.Row["SessionKey"] = value;
                return this;
            }

            /// <summary>
            /// 设置区块链验证密钥
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBlockKey(string value) {
                base.Row["BlockKey"] = value;
                return this;
            }

            /// <summary>
            /// 设置
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTime(string value) {
                base.Row["Time"] = value;
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
        /// 获取交互实体标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EntityID { get; private set; }

        /// <summary>
        /// 获取交互线程标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ProcessID { get; private set; }

        /// <summary>
        /// 获取交互密钥字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SessionKey { get; private set; }

        /// <summary>
        /// 获取区块链验证密钥字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BlockKey { get; private set; }

        /// <summary>
        /// 获取字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Time { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AosSessionProcesses() : base("AosSessionProcesses") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.SessionID = new dpz2.db.SqlUnits.TableField(this, "SessionID");
            this.EntityID = new dpz2.db.SqlUnits.TableField(this, "EntityID");
            this.ProcessID = new dpz2.db.SqlUnits.TableField(this, "ProcessID");
            this.SessionKey = new dpz2.db.SqlUnits.TableField(this, "SessionKey");
            this.BlockKey = new dpz2.db.SqlUnits.TableField(this, "BlockKey");
            this.Time = new dpz2.db.SqlUnits.TableField(this, "Time");
        }

    }

}
