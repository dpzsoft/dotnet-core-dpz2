using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Jxc {

    /// <summary>
    /// 账套信息
    /// 账套信息
    /// Version 1.0.1906.1
    /// </summary>
    public class JxcBook : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 账套信息 行数据操作器
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
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置数据库类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDBType(string value) {
                base.Row["DBType"] = value;
                return this;
            }

            /// <summary>
            /// 设置数据库名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDBName(string value) {
                base.Row["DBName"] = value;
                return this;
            }

            /// <summary>
            /// 设置地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDBIP(string value) {
                base.Row["DBIP"] = value;
                return this;
            }

            /// <summary>
            /// 设置端口
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDBPort(string value) {
                base.Row["DBPort"] = value;
                return this;
            }

            /// <summary>
            /// 设置用户名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDBUser(string value) {
                base.Row["DBUser"] = value;
                return this;
            }

            /// <summary>
            /// 设置密码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDBPwd(string value) {
                base.Row["DBPwd"] = value;
                return this;
            }

            /// <summary>
            /// 设置数据库版本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDBVersion(string value) {
                base.Row["DBVersion"] = value;
                return this;
            }

            /// <summary>
            /// 设置账套类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBookType(string value) {
                base.Row["BookType"] = value;
                return this;
            }

            /// <summary>
            /// 设置成员数限制
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBookMemberLimit(string value) {
                base.Row["BookMemberLimit"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属用户标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOwnerID(string value) {
                base.Row["OwnerID"] = value;
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
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取数据库类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DBType { get; private set; }

        /// <summary>
        /// 获取数据库名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DBName { get; private set; }

        /// <summary>
        /// 获取地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DBIP { get; private set; }

        /// <summary>
        /// 获取端口字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DBPort { get; private set; }

        /// <summary>
        /// 获取用户名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DBUser { get; private set; }

        /// <summary>
        /// 获取密码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DBPwd { get; private set; }

        /// <summary>
        /// 获取数据库版本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DBVersion { get; private set; }

        /// <summary>
        /// 获取账套类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BookType { get; private set; }

        /// <summary>
        /// 获取成员数限制字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BookMemberLimit { get; private set; }

        /// <summary>
        /// 获取所属用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OwnerID { get; private set; }

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
        public JxcBook() : base("JxcBook") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.DBType = new dpz2.db.SqlUnits.TableField(this, "DBType");
            this.DBName = new dpz2.db.SqlUnits.TableField(this, "DBName");
            this.DBIP = new dpz2.db.SqlUnits.TableField(this, "DBIP");
            this.DBPort = new dpz2.db.SqlUnits.TableField(this, "DBPort");
            this.DBUser = new dpz2.db.SqlUnits.TableField(this, "DBUser");
            this.DBPwd = new dpz2.db.SqlUnits.TableField(this, "DBPwd");
            this.DBVersion = new dpz2.db.SqlUnits.TableField(this, "DBVersion");
            this.BookType = new dpz2.db.SqlUnits.TableField(this, "BookType");
            this.BookMemberLimit = new dpz2.db.SqlUnits.TableField(this, "BookMemberLimit");
            this.OwnerID = new dpz2.db.SqlUnits.TableField(this, "OwnerID");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
