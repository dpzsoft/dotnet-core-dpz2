using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Platform {

    /// <summary>
    /// 投票信息
    /// 投票信息
    /// Version 2016.1002
    /// </summary>
    public class PlatformVotes : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 投票信息 行数据操作器
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
            /// 设置开始日期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetStartDate(string value) {
                base.Row["StartDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置结束日期
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEndDate(string value) {
                base.Row["EndDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置时间间隔
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTimeInterval(string value) {
                base.Row["TimeInterval"] = value;
                return this;
            }

            /// <summary>
            /// 设置上传开始时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUploadStartDate(string value) {
                base.Row["UploadStartDate"] = value;
                return this;
            }

            /// <summary>
            /// 设置上传结束时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUploadEndDate(string value) {
                base.Row["UploadEndDate"] = value;
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
        /// 获取开始日期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField StartDate { get; private set; }

        /// <summary>
        /// 获取结束日期字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField EndDate { get; private set; }

        /// <summary>
        /// 获取时间间隔字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TimeInterval { get; private set; }

        /// <summary>
        /// 获取上传开始时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UploadStartDate { get; private set; }

        /// <summary>
        /// 获取上传结束时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UploadEndDate { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public PlatformVotes() : base("PlatformVotes") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.StartDate = new dpz2.db.SqlUnits.TableField(this, "StartDate");
            this.EndDate = new dpz2.db.SqlUnits.TableField(this, "EndDate");
            this.TimeInterval = new dpz2.db.SqlUnits.TableField(this, "TimeInterval");
            this.UploadStartDate = new dpz2.db.SqlUnits.TableField(this, "UploadStartDate");
            this.UploadEndDate = new dpz2.db.SqlUnits.TableField(this, "UploadEndDate");
        }

    }

}
