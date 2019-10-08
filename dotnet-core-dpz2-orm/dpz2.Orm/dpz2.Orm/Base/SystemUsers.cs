using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Base {

    /// <summary>
    /// 基础用户信息
    /// 基础用户信息
    /// Version 1706.0003
    /// </summary>
    public class SystemUsers : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 基础用户信息 行数据操作器
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
            /// 设置用户名
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
            /// 设置职位
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetJobs(string value) {
                base.Row["Jobs"] = value;
                return this;
            }

            /// <summary>
            /// 设置部门
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDepartment(string value) {
                base.Row["Department"] = value;
                return this;
            }

            /// <summary>
            /// 设置用户组
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserGroup(string value) {
                base.Row["UserGroup"] = value;
                return this;
            }

            /// <summary>
            /// 设置最后阅读
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetChatLastRead(string value) {
                base.Row["ChatLastRead"] = value;
                return this;
            }

            /// <summary>
            /// 设置账户类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserType(string value) {
                base.Row["UserType"] = value;
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
        /// 获取用户名字段定义
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
        /// 获取职位字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Jobs { get; private set; }

        /// <summary>
        /// 获取部门字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Department { get; private set; }

        /// <summary>
        /// 获取用户组字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserGroup { get; private set; }

        /// <summary>
        /// 获取最后阅读字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ChatLastRead { get; private set; }

        /// <summary>
        /// 获取账户类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserType { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SystemUsers() : base("SystemUsers") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ObjectID = new dpz2.db.SqlUnits.TableField(this, "ObjectID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Pwd = new dpz2.db.SqlUnits.TableField(this, "Pwd");
            this.Nick = new dpz2.db.SqlUnits.TableField(this, "Nick");
            this.Jobs = new dpz2.db.SqlUnits.TableField(this, "Jobs");
            this.Department = new dpz2.db.SqlUnits.TableField(this, "Department");
            this.UserGroup = new dpz2.db.SqlUnits.TableField(this, "UserGroup");
            this.ChatLastRead = new dpz2.db.SqlUnits.TableField(this, "ChatLastRead");
            this.UserType = new dpz2.db.SqlUnits.TableField(this, "UserType");
        }

    }

}
