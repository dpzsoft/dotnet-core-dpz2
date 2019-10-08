using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// 统计信息
    /// 统计信息
    /// Version 1612.0001
    /// </summary>
    public class AosCount : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 统计信息 行数据操作器
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
            /// 设置创建时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCreateTime(string value) {
                base.Row["CreateTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置IP地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIPAddress(string value) {
                base.Row["IPAddress"] = value;
                return this;
            }

            /// <summary>
            /// 设置所在城市
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIPCity(string value) {
                base.Row["IPCity"] = value;
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
            /// 设置设备信息
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDevice(string value) {
                base.Row["Device"] = value;
                return this;
            }

            /// <summary>
            /// 设置设备版本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDeviceVersion(string value) {
                base.Row["DeviceVersion"] = value;
                return this;
            }

            /// <summary>
            /// 设置系统信息
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSystem(string value) {
                base.Row["System"] = value;
                return this;
            }

            /// <summary>
            /// 设置系统版本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSystemVersion(string value) {
                base.Row["SystemVersion"] = value;
                return this;
            }

            /// <summary>
            /// 设置客户端标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSign(string value) {
                base.Row["Sign"] = value;
                return this;
            }

            /// <summary>
            /// 设置客户端类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSignType(string value) {
                base.Row["SignType"] = value;
                return this;
            }

            /// <summary>
            /// 设置接口版本
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetInterfaceVersion(string value) {
                base.Row["InterfaceVersion"] = value;
                return this;
            }

            /// <summary>
            /// 设置附加信息
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAttach(string value) {
                base.Row["Attach"] = value;
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
        /// 获取创建时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取IP地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IPAddress { get; private set; }

        /// <summary>
        /// 获取所在城市字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IPCity { get; private set; }

        /// <summary>
        /// 获取交互标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SessionID { get; private set; }

        /// <summary>
        /// 获取设备信息字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Device { get; private set; }

        /// <summary>
        /// 获取设备版本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DeviceVersion { get; private set; }

        /// <summary>
        /// 获取系统信息字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField System { get; private set; }

        /// <summary>
        /// 获取系统版本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SystemVersion { get; private set; }

        /// <summary>
        /// 获取客户端标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Sign { get; private set; }

        /// <summary>
        /// 获取客户端类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SignType { get; private set; }

        /// <summary>
        /// 获取接口版本字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField InterfaceVersion { get; private set; }

        /// <summary>
        /// 获取附加信息字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Attach { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AosCount() : base("AosCount") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.IPAddress = new dpz2.db.SqlUnits.TableField(this, "IPAddress");
            this.IPCity = new dpz2.db.SqlUnits.TableField(this, "IPCity");
            this.SessionID = new dpz2.db.SqlUnits.TableField(this, "SessionID");
            this.Device = new dpz2.db.SqlUnits.TableField(this, "Device");
            this.DeviceVersion = new dpz2.db.SqlUnits.TableField(this, "DeviceVersion");
            this.System = new dpz2.db.SqlUnits.TableField(this, "System");
            this.SystemVersion = new dpz2.db.SqlUnits.TableField(this, "SystemVersion");
            this.Sign = new dpz2.db.SqlUnits.TableField(this, "Sign");
            this.SignType = new dpz2.db.SqlUnits.TableField(this, "SignType");
            this.InterfaceVersion = new dpz2.db.SqlUnits.TableField(this, "InterfaceVersion");
            this.Attach = new dpz2.db.SqlUnits.TableField(this, "Attach");
        }

    }

}
