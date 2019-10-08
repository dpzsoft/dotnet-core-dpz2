using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 授权库
    /// 授权库
    /// Version 1.5.1904.16
    /// </summary>
    public class AosAuthorize : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 授权库 行数据操作器
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
            /// 设置授权码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCode(string value) {
                base.Row["Code"] = value;
                return this;
            }

            /// <summary>
            /// 设置安全码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSecurityKey(string value) {
                base.Row["SecurityKey"] = value;
                return this;
            }

            /// <summary>
            /// 设置授权等级
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLv(string value) {
                base.Row["Lv"] = value;
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
            /// 设置数据库标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDBSign(string value) {
                base.Row["DBSign"] = value;
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
            /// 设置安装目录
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDBPath(string value) {
                base.Row["DBPath"] = value;
                return this;
            }

            /// <summary>
            /// 设置交互地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetInterfaceUrl(string value) {
                base.Row["InterfaceUrl"] = value;
                return this;
            }

            /// <summary>
            /// 设置文件站点
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFileSite(string value) {
                base.Row["FileSite"] = value;
                return this;
            }

            /// <summary>
            /// 设置应用站点
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAppSite(string value) {
                base.Row["AppSite"] = value;
                return this;
            }

            /// <summary>
            /// 设置主页地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetHomeUrl(string value) {
                base.Row["HomeUrl"] = value;
                return this;
            }

            /// <summary>
            /// 设置设置地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSettingUrl(string value) {
                base.Row["SettingUrl"] = value;
                return this;
            }

            /// <summary>
            /// 设置标志地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLogoUrl(string value) {
                base.Row["LogoUrl"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属桌面
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDesktopID(string value) {
                base.Row["DesktopID"] = value;
                return this;
            }

            /// <summary>
            /// 设置地址入口
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUrlEntrance(string value) {
                base.Row["UrlEntrance"] = value;
                return this;
            }

            /// <summary>
            /// 设置脚本入口
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetScriptEntrance(string value) {
                base.Row["ScriptEntrance"] = value;
                return this;
            }

            /// <summary>
            /// 设置应用配置入口
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAppConfigEntrance(string value) {
                base.Row["AppConfigEntrance"] = value;
                return this;
            }

            /// <summary>
            /// 设置创建用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCreateUserID(string value) {
                base.Row["CreateUserID"] = value;
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
        /// 获取授权码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 获取安全码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SecurityKey { get; private set; }

        /// <summary>
        /// 获取授权等级字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Lv { get; private set; }

        /// <summary>
        /// 获取数据库类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DBType { get; private set; }

        /// <summary>
        /// 获取数据库标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DBSign { get; private set; }

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
        /// 获取安装目录字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DBPath { get; private set; }

        /// <summary>
        /// 获取交互地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField InterfaceUrl { get; private set; }

        /// <summary>
        /// 获取文件站点字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FileSite { get; private set; }

        /// <summary>
        /// 获取应用站点字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AppSite { get; private set; }

        /// <summary>
        /// 获取主页地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField HomeUrl { get; private set; }

        /// <summary>
        /// 获取设置地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SettingUrl { get; private set; }

        /// <summary>
        /// 获取标志地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LogoUrl { get; private set; }

        /// <summary>
        /// 获取所属桌面字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DesktopID { get; private set; }

        /// <summary>
        /// 获取地址入口字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UrlEntrance { get; private set; }

        /// <summary>
        /// 获取脚本入口字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ScriptEntrance { get; private set; }

        /// <summary>
        /// 获取应用配置入口字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AppConfigEntrance { get; private set; }

        /// <summary>
        /// 获取创建用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateUserID { get; private set; }

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
        public AosAuthorize() : base("AosAuthorize") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.SecurityKey = new dpz2.db.SqlUnits.TableField(this, "SecurityKey");
            this.Lv = new dpz2.db.SqlUnits.TableField(this, "Lv");
            this.DBType = new dpz2.db.SqlUnits.TableField(this, "DBType");
            this.DBSign = new dpz2.db.SqlUnits.TableField(this, "DBSign");
            this.DBIP = new dpz2.db.SqlUnits.TableField(this, "DBIP");
            this.DBPort = new dpz2.db.SqlUnits.TableField(this, "DBPort");
            this.DBUser = new dpz2.db.SqlUnits.TableField(this, "DBUser");
            this.DBPwd = new dpz2.db.SqlUnits.TableField(this, "DBPwd");
            this.DBPath = new dpz2.db.SqlUnits.TableField(this, "DBPath");
            this.InterfaceUrl = new dpz2.db.SqlUnits.TableField(this, "InterfaceUrl");
            this.FileSite = new dpz2.db.SqlUnits.TableField(this, "FileSite");
            this.AppSite = new dpz2.db.SqlUnits.TableField(this, "AppSite");
            this.HomeUrl = new dpz2.db.SqlUnits.TableField(this, "HomeUrl");
            this.SettingUrl = new dpz2.db.SqlUnits.TableField(this, "SettingUrl");
            this.LogoUrl = new dpz2.db.SqlUnits.TableField(this, "LogoUrl");
            this.DesktopID = new dpz2.db.SqlUnits.TableField(this, "DesktopID");
            this.UrlEntrance = new dpz2.db.SqlUnits.TableField(this, "UrlEntrance");
            this.ScriptEntrance = new dpz2.db.SqlUnits.TableField(this, "ScriptEntrance");
            this.AppConfigEntrance = new dpz2.db.SqlUnits.TableField(this, "AppConfigEntrance");
            this.CreateUserID = new dpz2.db.SqlUnits.TableField(this, "CreateUserID");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
