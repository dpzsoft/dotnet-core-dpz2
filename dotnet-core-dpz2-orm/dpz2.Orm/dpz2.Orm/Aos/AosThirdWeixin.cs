using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 第三方接口微信信息
    /// 第三方接口微信信息
    /// Version 1705.0001
    /// </summary>
    public class AosThirdWeixin : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 第三方接口微信信息 行数据操作器
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
            /// 设置标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSign(string value) {
                base.Row["Sign"] = value;
                return this;
            }

            /// <summary>
            /// 设置应用ID
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAppID(string value) {
                base.Row["AppID"] = value;
                return this;
            }

            /// <summary>
            /// 设置应用密钥
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAppSecret(string value) {
                base.Row["AppSecret"] = value;
                return this;
            }

            /// <summary>
            /// 设置商户ID
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMachID(string value) {
                base.Row["MachID"] = value;
                return this;
            }

            /// <summary>
            /// 设置商户密钥
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMachKey(string value) {
                base.Row["MachKey"] = value;
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
        /// 获取标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Sign { get; private set; }

        /// <summary>
        /// 获取应用ID字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AppID { get; private set; }

        /// <summary>
        /// 获取应用密钥字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AppSecret { get; private set; }

        /// <summary>
        /// 获取商户ID字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField MachID { get; private set; }

        /// <summary>
        /// 获取商户密钥字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField MachKey { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AosThirdWeixin() : base("AosThirdWeixin") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Sign = new dpz2.db.SqlUnits.TableField(this, "Sign");
            this.AppID = new dpz2.db.SqlUnits.TableField(this, "AppID");
            this.AppSecret = new dpz2.db.SqlUnits.TableField(this, "AppSecret");
            this.MachID = new dpz2.db.SqlUnits.TableField(this, "MachID");
            this.MachKey = new dpz2.db.SqlUnits.TableField(this, "MachKey");
        }

    }

}
