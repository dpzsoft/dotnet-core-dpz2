using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Member {

    /// <summary>
    /// 会员信息表
    /// 存储所有的会员用户信息
    /// Version 1807.0003
    /// </summary>
    public class MemberInfos : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 会员信息表 行数据操作器
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
            /// 设置会员卡信息
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCardID(string value) {
                base.Row["CardID"] = value;
                return this;
            }

            /// <summary>
            /// 设置等级
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLv(string value) {
                base.Row["Lv"] = value;
                return this;
            }

            /// <summary>
            /// 设置成长值
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetExp(string value) {
                base.Row["Exp"] = value;
                return this;
            }

            /// <summary>
            /// 设置姓名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份证号码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIDNumber(string value) {
                base.Row["IDNumber"] = value;
                return this;
            }

            /// <summary>
            /// 设置联系电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhone(string value) {
                base.Row["Phone"] = value;
                return this;
            }

            /// <summary>
            /// 设置余额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMoney(string value) {
                base.Row["Money"] = value;
                return this;
            }

            /// <summary>
            /// 设置积分
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIntegral(string value) {
                base.Row["Integral"] = value;
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
        /// 获取会员卡信息字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CardID { get; private set; }

        /// <summary>
        /// 获取等级字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Lv { get; private set; }

        /// <summary>
        /// 获取成长值字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Exp { get; private set; }

        /// <summary>
        /// 获取姓名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取身份证号码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IDNumber { get; private set; }

        /// <summary>
        /// 获取联系电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取余额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Money { get; private set; }

        /// <summary>
        /// 获取积分字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Integral { get; private set; }

        /// <summary>
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

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
        public MemberInfos() : base("MemberInfos") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.CardID = new dpz2.db.SqlUnits.TableField(this, "CardID");
            this.Lv = new dpz2.db.SqlUnits.TableField(this, "Lv");
            this.Exp = new dpz2.db.SqlUnits.TableField(this, "Exp");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.IDNumber = new dpz2.db.SqlUnits.TableField(this, "IDNumber");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.Money = new dpz2.db.SqlUnits.TableField(this, "Money");
            this.Integral = new dpz2.db.SqlUnits.TableField(this, "Integral");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
