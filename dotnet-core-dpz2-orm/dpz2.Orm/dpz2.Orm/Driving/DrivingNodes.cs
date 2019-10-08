using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Driving {

    /// <summary>
    /// 驾驶计费节点
    /// 驾驶计费节点
    /// Version 1703.0001
    /// </summary>
    public class DrivingNodes : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 驾驶计费节点 行数据操作器
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
            /// 设置订单标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOrderID(string value) {
                base.Row["OrderID"] = value;
                return this;
            }

            /// <summary>
            /// 设置节点时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetNodeTime(string value) {
                base.Row["NodeTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置节点经度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLongitude(string value) {
                base.Row["Longitude"] = value;
                return this;
            }

            /// <summary>
            /// 设置节点纬度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLatitude(string value) {
                base.Row["Latitude"] = value;
                return this;
            }

            /// <summary>
            /// 设置移动距离
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRemoving(string value) {
                base.Row["Removing"] = value;
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
        /// 获取订单标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OrderID { get; private set; }

        /// <summary>
        /// 获取节点时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField NodeTime { get; private set; }

        /// <summary>
        /// 获取节点经度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Longitude { get; private set; }

        /// <summary>
        /// 获取节点纬度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Latitude { get; private set; }

        /// <summary>
        /// 获取移动距离字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Removing { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public DrivingNodes() : base("DrivingNodes") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.OrderID = new dpz2.db.SqlUnits.TableField(this, "OrderID");
            this.NodeTime = new dpz2.db.SqlUnits.TableField(this, "NodeTime");
            this.Longitude = new dpz2.db.SqlUnits.TableField(this, "Longitude");
            this.Latitude = new dpz2.db.SqlUnits.TableField(this, "Latitude");
            this.Removing = new dpz2.db.SqlUnits.TableField(this, "Removing");
        }

    }

}
