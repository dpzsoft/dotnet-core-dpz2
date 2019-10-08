using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 用户信息
    /// 用户信息
    /// Version 1711.0005
    /// </summary>
    public class AosUsers : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 用户信息 行数据操作器
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
            /// 设置头像
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImage(string value) {
                base.Row["Image"] = value;
                return this;
            }

            /// <summary>
            /// 设置桌面
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDesktop(string value) {
                base.Row["Desktop"] = value;
                return this;
            }

            /// <summary>
            /// 设置桌面背景
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBackground(string value) {
                base.Row["Background"] = value;
                return this;
            }

            /// <summary>
            /// 设置应用操作权限
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLimit(string value) {
                base.Row["Limit"] = value;
                return this;
            }

            /// <summary>
            /// 设置授权标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAuthorizeID(string value) {
                base.Row["AuthorizeID"] = value;
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
        /// 获取头像字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Image { get; private set; }

        /// <summary>
        /// 获取桌面字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Desktop { get; private set; }

        /// <summary>
        /// 获取桌面背景字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Background { get; private set; }

        /// <summary>
        /// 获取应用操作权限字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Limit { get; private set; }

        /// <summary>
        /// 获取授权标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AuthorizeID { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AosUsers() : base("AosUsers") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Pwd = new dpz2.db.SqlUnits.TableField(this, "Pwd");
            this.Nick = new dpz2.db.SqlUnits.TableField(this, "Nick");
            this.Image = new dpz2.db.SqlUnits.TableField(this, "Image");
            this.Desktop = new dpz2.db.SqlUnits.TableField(this, "Desktop");
            this.Background = new dpz2.db.SqlUnits.TableField(this, "Background");
            this.Limit = new dpz2.db.SqlUnits.TableField(this, "Limit");
            this.AuthorizeID = new dpz2.db.SqlUnits.TableField(this, "AuthorizeID");
        }

    }

}
