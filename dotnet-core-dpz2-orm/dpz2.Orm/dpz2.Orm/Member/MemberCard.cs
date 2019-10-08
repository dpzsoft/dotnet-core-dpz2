using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Member {

    /// <summary>
    /// 会员卡信息
    /// 会员卡信息
    /// Version 1807.0001
    /// </summary>
    public class MemberCard : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 会员卡信息 行数据操作器
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
            /// 设置相关用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置卡号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCode(string value) {
                base.Row["Code"] = value;
                return this;
            }

            /// <summary>
            /// 设置卡密
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPwd(string value) {
                base.Row["Pwd"] = value;
                return this;
            }

            /// <summary>
            /// 设置卡类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCardType(string value) {
                base.Row["CardType"] = value;
                return this;
            }

            /// <summary>
            /// 设置激活时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetActiveTime(string value) {
                base.Row["ActiveTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置失效时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetInvalidTime(string value) {
                base.Row["InvalidTime"] = value;
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
        /// 获取相关用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取卡号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 获取卡密字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Pwd { get; private set; }

        /// <summary>
        /// 获取卡类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CardType { get; private set; }

        /// <summary>
        /// 获取激活时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ActiveTime { get; private set; }

        /// <summary>
        /// 获取失效时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField InvalidTime { get; private set; }

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
        public MemberCard() : base("MemberCard") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.Pwd = new dpz2.db.SqlUnits.TableField(this, "Pwd");
            this.CardType = new dpz2.db.SqlUnits.TableField(this, "CardType");
            this.ActiveTime = new dpz2.db.SqlUnits.TableField(this, "ActiveTime");
            this.InvalidTime = new dpz2.db.SqlUnits.TableField(this, "InvalidTime");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
