using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Driving {

    /// <summary>
    /// 驾驶订单表
    /// 驾驶订单表
    /// Version 1704.0006
    /// </summary>
    public class DrivingOrders : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 驾驶订单表 行数据操作器
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
            /// 设置订单流水号
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCode(string value) {
                base.Row["Code"] = value;
                return this;
            }

            /// <summary>
            /// 设置用户标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
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
            /// 设置出发地点
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFromAddress(string value) {
                base.Row["FromAddress"] = value;
                return this;
            }

            /// <summary>
            /// 设置出发经度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFromLongitude(string value) {
                base.Row["FromLongitude"] = value;
                return this;
            }

            /// <summary>
            /// 设置出发纬度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetFromLatitude(string value) {
                base.Row["FromLatitude"] = value;
                return this;
            }

            /// <summary>
            /// 设置到达地点
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetToAddress(string value) {
                base.Row["ToAddress"] = value;
                return this;
            }

            /// <summary>
            /// 设置到达经度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetToLongitude(string value) {
                base.Row["ToLongitude"] = value;
                return this;
            }

            /// <summary>
            /// 设置到达纬度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetToLatitude(string value) {
                base.Row["ToLatitude"] = value;
                return this;
            }

            /// <summary>
            /// 设置距离
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAwayFrom(string value) {
                base.Row["AwayFrom"] = value;
                return this;
            }

            /// <summary>
            /// 设置预计金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEstimateMoney(string value) {
                base.Row["EstimateMoney"] = value;
                return this;
            }

            /// <summary>
            /// 设置下单时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCreateTime(string value) {
                base.Row["CreateTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置出发时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLeaveTime(string value) {
                base.Row["LeaveTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置司机标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDriverID(string value) {
                base.Row["DriverID"] = value;
                return this;
            }

            /// <summary>
            /// 设置司机联系电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDriverPhone(string value) {
                base.Row["DriverPhone"] = value;
                return this;
            }

            /// <summary>
            /// 设置司机经度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDriverLongitude(string value) {
                base.Row["DriverLongitude"] = value;
                return this;
            }

            /// <summary>
            /// 设置司机纬度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDriverLatitude(string value) {
                base.Row["DriverLatitude"] = value;
                return this;
            }

            /// <summary>
            /// 设置接单时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOrderTime(string value) {
                base.Row["OrderTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置实际出发时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRealLeaveTime(string value) {
                base.Row["RealLeaveTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置出发经度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLeaveLongitude(string value) {
                base.Row["LeaveLongitude"] = value;
                return this;
            }

            /// <summary>
            /// 设置出发纬度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLeaveLatitude(string value) {
                base.Row["LeaveLatitude"] = value;
                return this;
            }

            /// <summary>
            /// 设置到达时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetArriveTime(string value) {
                base.Row["ArriveTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置到达经度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetArriveLongitude(string value) {
                base.Row["ArriveLongitude"] = value;
                return this;
            }

            /// <summary>
            /// 设置到达纬度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetArriveLatitude(string value) {
                base.Row["ArriveLatitude"] = value;
                return this;
            }

            /// <summary>
            /// 设置驾驶耗时
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDuration(string value) {
                base.Row["Duration"] = value;
                return this;
            }

            /// <summary>
            /// 设置驾驶距离
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetRemoving(string value) {
                base.Row["Removing"] = value;
                return this;
            }

            /// <summary>
            /// 设置金额
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMoney(string value) {
                base.Row["Money"] = value;
                return this;
            }

            /// <summary>
            /// 设置支付时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPayTime(string value) {
                base.Row["PayTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置评分
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetScore(string value) {
                base.Row["Score"] = value;
                return this;
            }

            /// <summary>
            /// 设置评价
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEvaluation(string value) {
                base.Row["Evaluation"] = value;
                return this;
            }

            /// <summary>
            /// 设置评价时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEvaluationTime(string value) {
                base.Row["EvaluationTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置司机评分
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDriverScore(string value) {
                base.Row["DriverScore"] = value;
                return this;
            }

            /// <summary>
            /// 设置司机评价
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDriverEvaluation(string value) {
                base.Row["DriverEvaluation"] = value;
                return this;
            }

            /// <summary>
            /// 设置司机评价时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDriverEvaluationTime(string value) {
                base.Row["DriverEvaluationTime"] = value;
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
        /// 获取订单流水号字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Code { get; private set; }

        /// <summary>
        /// 获取用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取联系电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取出发地点字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FromAddress { get; private set; }

        /// <summary>
        /// 获取出发经度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FromLongitude { get; private set; }

        /// <summary>
        /// 获取出发纬度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField FromLatitude { get; private set; }

        /// <summary>
        /// 获取到达地点字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ToAddress { get; private set; }

        /// <summary>
        /// 获取到达经度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ToLongitude { get; private set; }

        /// <summary>
        /// 获取到达纬度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ToLatitude { get; private set; }

        /// <summary>
        /// 获取距离字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AwayFrom { get; private set; }

        /// <summary>
        /// 获取预计金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EstimateMoney { get; private set; }

        /// <summary>
        /// 获取下单时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CreateTime { get; private set; }

        /// <summary>
        /// 获取出发时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LeaveTime { get; private set; }

        /// <summary>
        /// 获取司机标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DriverID { get; private set; }

        /// <summary>
        /// 获取司机联系电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DriverPhone { get; private set; }

        /// <summary>
        /// 获取司机经度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DriverLongitude { get; private set; }

        /// <summary>
        /// 获取司机纬度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DriverLatitude { get; private set; }

        /// <summary>
        /// 获取接单时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OrderTime { get; private set; }

        /// <summary>
        /// 获取实际出发时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField RealLeaveTime { get; private set; }

        /// <summary>
        /// 获取出发经度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LeaveLongitude { get; private set; }

        /// <summary>
        /// 获取出发纬度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField LeaveLatitude { get; private set; }

        /// <summary>
        /// 获取到达时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ArriveTime { get; private set; }

        /// <summary>
        /// 获取到达经度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ArriveLongitude { get; private set; }

        /// <summary>
        /// 获取到达纬度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ArriveLatitude { get; private set; }

        /// <summary>
        /// 获取驾驶耗时字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Duration { get; private set; }

        /// <summary>
        /// 获取驾驶距离字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Removing { get; private set; }

        /// <summary>
        /// 获取金额字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Money { get; private set; }

        /// <summary>
        /// 获取支付时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PayTime { get; private set; }

        /// <summary>
        /// 获取评分字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Score { get; private set; }

        /// <summary>
        /// 获取评价字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Evaluation { get; private set; }

        /// <summary>
        /// 获取评价时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EvaluationTime { get; private set; }

        /// <summary>
        /// 获取司机评分字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DriverScore { get; private set; }

        /// <summary>
        /// 获取司机评价字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DriverEvaluation { get; private set; }

        /// <summary>
        /// 获取司机评价时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DriverEvaluationTime { get; private set; }

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
        public DrivingOrders() : base("DrivingOrders") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Code = new dpz2.db.SqlUnits.TableField(this, "Code");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.FromAddress = new dpz2.db.SqlUnits.TableField(this, "FromAddress");
            this.FromLongitude = new dpz2.db.SqlUnits.TableField(this, "FromLongitude");
            this.FromLatitude = new dpz2.db.SqlUnits.TableField(this, "FromLatitude");
            this.ToAddress = new dpz2.db.SqlUnits.TableField(this, "ToAddress");
            this.ToLongitude = new dpz2.db.SqlUnits.TableField(this, "ToLongitude");
            this.ToLatitude = new dpz2.db.SqlUnits.TableField(this, "ToLatitude");
            this.AwayFrom = new dpz2.db.SqlUnits.TableField(this, "AwayFrom");
            this.EstimateMoney = new dpz2.db.SqlUnits.TableField(this, "EstimateMoney");
            this.CreateTime = new dpz2.db.SqlUnits.TableField(this, "CreateTime");
            this.LeaveTime = new dpz2.db.SqlUnits.TableField(this, "LeaveTime");
            this.DriverID = new dpz2.db.SqlUnits.TableField(this, "DriverID");
            this.DriverPhone = new dpz2.db.SqlUnits.TableField(this, "DriverPhone");
            this.DriverLongitude = new dpz2.db.SqlUnits.TableField(this, "DriverLongitude");
            this.DriverLatitude = new dpz2.db.SqlUnits.TableField(this, "DriverLatitude");
            this.OrderTime = new dpz2.db.SqlUnits.TableField(this, "OrderTime");
            this.RealLeaveTime = new dpz2.db.SqlUnits.TableField(this, "RealLeaveTime");
            this.LeaveLongitude = new dpz2.db.SqlUnits.TableField(this, "LeaveLongitude");
            this.LeaveLatitude = new dpz2.db.SqlUnits.TableField(this, "LeaveLatitude");
            this.ArriveTime = new dpz2.db.SqlUnits.TableField(this, "ArriveTime");
            this.ArriveLongitude = new dpz2.db.SqlUnits.TableField(this, "ArriveLongitude");
            this.ArriveLatitude = new dpz2.db.SqlUnits.TableField(this, "ArriveLatitude");
            this.Duration = new dpz2.db.SqlUnits.TableField(this, "Duration");
            this.Removing = new dpz2.db.SqlUnits.TableField(this, "Removing");
            this.Money = new dpz2.db.SqlUnits.TableField(this, "Money");
            this.PayTime = new dpz2.db.SqlUnits.TableField(this, "PayTime");
            this.Score = new dpz2.db.SqlUnits.TableField(this, "Score");
            this.Evaluation = new dpz2.db.SqlUnits.TableField(this, "Evaluation");
            this.EvaluationTime = new dpz2.db.SqlUnits.TableField(this, "EvaluationTime");
            this.DriverScore = new dpz2.db.SqlUnits.TableField(this, "DriverScore");
            this.DriverEvaluation = new dpz2.db.SqlUnits.TableField(this, "DriverEvaluation");
            this.DriverEvaluationTime = new dpz2.db.SqlUnits.TableField(this, "DriverEvaluationTime");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
