using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.User {

    /// <summary>
    /// 用户信息表
    /// 存储所有的用户信息
    /// Version 1.1.1810.4
    /// </summary>
    public class UserInfos : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 用户信息表 行数据操作器
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
            /// 设置对象标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetObjectID(string value) {
                base.Row["ObjectID"] = value;
                return this;
            }

            /// <summary>
            /// 设置名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置密码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPwd(string value) {
                base.Row["Pwd"] = value;
                return this;
            }

            /// <summary>
            /// 设置昵称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetNick(string value) {
                base.Row["Nick"] = value;
                return this;
            }

            /// <summary>
            /// 设置生日
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBirthday(string value) {
                base.Row["Birthday"] = value;
                return this;
            }

            /// <summary>
            /// 设置头像
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPicture(string value) {
                base.Row["Picture"] = value;
                return this;
            }

            /// <summary>
            /// 设置头像状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPictureStatus(string value) {
                base.Row["PictureStatus"] = value;
                return this;
            }

            /// <summary>
            /// 设置姓名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRealName(string value) {
                base.Row["RealName"] = value;
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
            /// 设置经验
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetExp(string value) {
                base.Row["Exp"] = value;
                return this;
            }

            /// <summary>
            /// 设置类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserType(string value) {
                base.Row["UserType"] = value;
                return this;
            }

            /// <summary>
            /// 设置绑定的管理用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetManagerID(string value) {
                base.Row["ManagerID"] = value;
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
        /// 获取对象标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ObjectID { get; private set; }

        /// <summary>
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取密码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Pwd { get; private set; }

        /// <summary>
        /// 获取昵称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Nick { get; private set; }

        /// <summary>
        /// 获取生日字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Birthday { get; private set; }

        /// <summary>
        /// 获取头像字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Picture { get; private set; }

        /// <summary>
        /// 获取头像状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PictureStatus { get; private set; }

        /// <summary>
        /// 获取姓名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RealName { get; private set; }

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
        /// 获取经验字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Exp { get; private set; }

        /// <summary>
        /// 获取类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserType { get; private set; }

        /// <summary>
        /// 获取绑定的管理用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ManagerID { get; private set; }

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
        public UserInfos() : base("UserInfos") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ObjectID = new dpz2.db.SqlUnits.TableField(this, "ObjectID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Pwd = new dpz2.db.SqlUnits.TableField(this, "Pwd");
            this.Nick = new dpz2.db.SqlUnits.TableField(this, "Nick");
            this.Birthday = new dpz2.db.SqlUnits.TableField(this, "Birthday");
            this.Picture = new dpz2.db.SqlUnits.TableField(this, "Picture");
            this.PictureStatus = new dpz2.db.SqlUnits.TableField(this, "PictureStatus");
            this.RealName = new dpz2.db.SqlUnits.TableField(this, "RealName");
            this.IDNumber = new dpz2.db.SqlUnits.TableField(this, "IDNumber");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.Money = new dpz2.db.SqlUnits.TableField(this, "Money");
            this.Integral = new dpz2.db.SqlUnits.TableField(this, "Integral");
            this.Exp = new dpz2.db.SqlUnits.TableField(this, "Exp");
            this.UserType = new dpz2.db.SqlUnits.TableField(this, "UserType");
            this.ManagerID = new dpz2.db.SqlUnits.TableField(this, "ManagerID");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
