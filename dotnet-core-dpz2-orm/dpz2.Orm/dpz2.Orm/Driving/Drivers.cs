using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Driving {

    /// <summary>
    /// 司机信息表
    /// 存储所有的代驾司机信息
    /// Version 1704.0003
    /// </summary>
    public class Drivers : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 司机信息表 行数据操作器
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
            /// 设置用户标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserID(string value) {
                base.Row["UserID"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份证姓名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIDCardName(string value) {
                base.Row["IDCardName"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份证号码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIDCardNumber(string value) {
                base.Row["IDCardNumber"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份证有效期开始
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIDCardStart(string value) {
                base.Row["IDCardStart"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份证有效期结束
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIDCardEnd(string value) {
                base.Row["IDCardEnd"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份证正面照片
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIDCardFrontPicture(string value) {
                base.Row["IDCardFrontPicture"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份证背面照片
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIDCardBackPicture(string value) {
                base.Row["IDCardBackPicture"] = value;
                return this;
            }

            /// <summary>
            /// 设置驾驶证初领
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDriverCardFirst(string value) {
                base.Row["DriverCardFirst"] = value;
                return this;
            }

            /// <summary>
            /// 设置驾驶证有效期开始
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDriverCardStart(string value) {
                base.Row["DriverCardStart"] = value;
                return this;
            }

            /// <summary>
            /// 设置驾驶证有效期结束
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDriverCardEnd(string value) {
                base.Row["DriverCardEnd"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份证正面照片
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDriverCardFrontPicture(string value) {
                base.Row["DriverCardFrontPicture"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份证背面照片
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDriverCardBackPicture(string value) {
                base.Row["DriverCardBackPicture"] = value;
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
        /// 获取用户标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserID { get; private set; }

        /// <summary>
        /// 获取身份证姓名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IDCardName { get; private set; }

        /// <summary>
        /// 获取身份证号码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IDCardNumber { get; private set; }

        /// <summary>
        /// 获取身份证有效期开始字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IDCardStart { get; private set; }

        /// <summary>
        /// 获取身份证有效期结束字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IDCardEnd { get; private set; }

        /// <summary>
        /// 获取身份证正面照片字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IDCardFrontPicture { get; private set; }

        /// <summary>
        /// 获取身份证背面照片字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IDCardBackPicture { get; private set; }

        /// <summary>
        /// 获取驾驶证初领字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DriverCardFirst { get; private set; }

        /// <summary>
        /// 获取驾驶证有效期开始字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DriverCardStart { get; private set; }

        /// <summary>
        /// 获取驾驶证有效期结束字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DriverCardEnd { get; private set; }

        /// <summary>
        /// 获取身份证正面照片字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DriverCardFrontPicture { get; private set; }

        /// <summary>
        /// 获取身份证背面照片字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DriverCardBackPicture { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public Drivers() : base("Drivers") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.IDCardName = new dpz2.db.SqlUnits.TableField(this, "IDCardName");
            this.IDCardNumber = new dpz2.db.SqlUnits.TableField(this, "IDCardNumber");
            this.IDCardStart = new dpz2.db.SqlUnits.TableField(this, "IDCardStart");
            this.IDCardEnd = new dpz2.db.SqlUnits.TableField(this, "IDCardEnd");
            this.IDCardFrontPicture = new dpz2.db.SqlUnits.TableField(this, "IDCardFrontPicture");
            this.IDCardBackPicture = new dpz2.db.SqlUnits.TableField(this, "IDCardBackPicture");
            this.DriverCardFirst = new dpz2.db.SqlUnits.TableField(this, "DriverCardFirst");
            this.DriverCardStart = new dpz2.db.SqlUnits.TableField(this, "DriverCardStart");
            this.DriverCardEnd = new dpz2.db.SqlUnits.TableField(this, "DriverCardEnd");
            this.DriverCardFrontPicture = new dpz2.db.SqlUnits.TableField(this, "DriverCardFrontPicture");
            this.DriverCardBackPicture = new dpz2.db.SqlUnits.TableField(this, "DriverCardBackPicture");
        }

    }

}
