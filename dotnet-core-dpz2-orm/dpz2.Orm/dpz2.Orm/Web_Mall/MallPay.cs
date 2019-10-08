using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Mall {

    /// <summary>
    /// 商城支付方式
    /// 商城支付方式
    /// Version 2016.0601
    /// </summary>
    public class MallPay : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 商城支付方式 行数据操作器
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
            /// 设置图片地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImgPath(string value) {
                base.Row["ImgPath"] = value;
                return this;
            }

            /// <summary>
            /// 设置提交网址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUrl(string value) {
                base.Row["Url"] = value;
                return this;
            }

            /// <summary>
            /// 设置支付用户名
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUserName(string value) {
                base.Row["UserName"] = value;
                return this;
            }

            /// <summary>
            /// 设置支付PID
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPID(string value) {
                base.Row["PID"] = value;
                return this;
            }

            /// <summary>
            /// 设置支付Key
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetKey(string value) {
                base.Row["Key"] = value;
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
        /// 获取图片地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ImgPath { get; private set; }

        /// <summary>
        /// 获取提交网址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Url { get; private set; }

        /// <summary>
        /// 获取支付用户名字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField UserName { get; private set; }

        /// <summary>
        /// 获取支付PID字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField PID { get; private set; }

        /// <summary>
        /// 获取支付Key字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Key { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public MallPay() : base("MallPay") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.ImgPath = new dpz2.db.SqlUnits.TableField(this, "ImgPath");
            this.Url = new dpz2.db.SqlUnits.TableField(this, "Url");
            this.UserName = new dpz2.db.SqlUnits.TableField(this, "UserName");
            this.PID = new dpz2.db.SqlUnits.TableField(this, "PID");
            this.Key = new dpz2.db.SqlUnits.TableField(this, "Key");
        }

    }

}
