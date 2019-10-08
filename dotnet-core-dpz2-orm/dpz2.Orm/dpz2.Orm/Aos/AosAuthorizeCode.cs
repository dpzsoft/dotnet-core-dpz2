using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 授权代码库
    /// 授权代码库
    /// Version 1711.0002
    /// </summary>
    public class AosAuthorizeCode : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 授权代码库 行数据操作器
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
            /// 设置名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAuthID(string value) {
                base.Row["AuthID"] = value;
                return this;
            }

            /// <summary>
            /// 设置交互标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSessionID(string value) {
                base.Row["SessionID"] = value;
                return this;
            }

            /// <summary>
            /// 设置授权码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCode(string value) {
                base.Row["Code"] = value;
                return this;
            }

            /// <summary>
            /// 设置操作码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetToken(string value) {
                base.Row["Token"] = value;
                return this;
            }

            /// <summary>
            /// 设置有效时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEffectiveTime(string value) {
                base.Row["EffectiveTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStatus(string value) {
                base.Row["Status"] = value;
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
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AuthID { get; private set; }

        /// <summary>
        /// 获取交互标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SessionID { get; private set; }

        /// <summary>
        /// 获取授权码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 获取操作码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Token { get; private set; }

        /// <summary>
        /// 获取有效时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EffectiveTime { get; private set; }

        /// <summary>
        /// 获取状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Status { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AosAuthorizeCode() : base("AosAuthorizeCode") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.AuthID = new dpz2.db.SqlUnits.TableField(this, "AuthID");
            this.SessionID = new dpz2.db.SqlUnits.TableField(this, "SessionID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.Token = new dpz2.db.SqlUnits.TableField(this, "Token");
            this.EffectiveTime = new dpz2.db.SqlUnits.TableField(this, "EffectiveTime");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
