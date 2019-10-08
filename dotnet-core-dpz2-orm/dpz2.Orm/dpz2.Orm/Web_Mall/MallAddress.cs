using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web_Mall {

    /// <summary>
    /// 收货地址
    /// 收货地址
    /// Version 2016.0601
    /// </summary>
    public class MallAddress : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 收货地址 行数据操作器
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
            /// 设置省份
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProvince(string value) {
                base.Row["Province"] = value;
                return this;
            }

            /// <summary>
            /// 设置城市
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCity(string value) {
                base.Row["City"] = value;
                return this;
            }

            /// <summary>
            /// 设置详细地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAddress(string value) {
                base.Row["Address"] = value;
                return this;
            }

            /// <summary>
            /// 设置邮政编码
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetZipCode(string value) {
                base.Row["ZipCode"] = value;
                return this;
            }

            /// <summary>
            /// 设置收件人
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAddressee(string value) {
                base.Row["Addressee"] = value;
                return this;
            }

            /// <summary>
            /// 设置身份证
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCardID(string value) {
                base.Row["CardID"] = value;
                return this;
            }

            /// <summary>
            /// 设置联系方式
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPhone(string value) {
                base.Row["Phone"] = value;
                return this;
            }

            /// <summary>
            /// 设置默认地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDefaultAddress(string value) {
                base.Row["DefaultAddress"] = value;
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
        /// 获取省份字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Province { get; private set; }

        /// <summary>
        /// 获取城市字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField City { get; private set; }

        /// <summary>
        /// 获取详细地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Address { get; private set; }

        /// <summary>
        /// 获取邮政编码字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ZipCode { get; private set; }

        /// <summary>
        /// 获取收件人字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Addressee { get; private set; }

        /// <summary>
        /// 获取身份证字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CardID { get; private set; }

        /// <summary>
        /// 获取联系方式字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Phone { get; private set; }

        /// <summary>
        /// 获取默认地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DefaultAddress { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public MallAddress() : base("MallAddress") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.UserID = new dpz2.db.SqlUnits.TableField(this, "UserID");
            this.Province = new dpz2.db.SqlUnits.TableField(this, "Province");
            this.City = new dpz2.db.SqlUnits.TableField(this, "City");
            this.Address = new dpz2.db.SqlUnits.TableField(this, "Address");
            this.ZipCode = new dpz2.db.SqlUnits.TableField(this, "ZipCode");
            this.Addressee = new dpz2.db.SqlUnits.TableField(this, "Addressee");
            this.CardID = new dpz2.db.SqlUnits.TableField(this, "CardID");
            this.Phone = new dpz2.db.SqlUnits.TableField(this, "Phone");
            this.DefaultAddress = new dpz2.db.SqlUnits.TableField(this, "DefaultAddress");
        }

    }

}
