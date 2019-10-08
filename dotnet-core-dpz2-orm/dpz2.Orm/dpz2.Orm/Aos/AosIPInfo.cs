using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Aos {

    /// <summary>
    /// IP地址信息
    /// IP地址信息
    /// Version 2016.0501
    /// </summary>
    public class AosIPInfo : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// IP地址信息 行数据操作器
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
            /// 设置开始IP
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIPStart(string value) {
                base.Row["IPStart"] = value;
                return this;
            }

            /// <summary>
            /// 设置结束IP
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIPEnd(string value) {
                base.Row["IPEnd"] = value;
                return this;
            }

            /// <summary>
            /// 设置地址全称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAddress(string value) {
                base.Row["Address"] = value;
                return this;
            }

            /// <summary>
            /// 设置完整开始IP
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIPStart000(string value) {
                base.Row["IPStart000"] = value;
                return this;
            }

            /// <summary>
            /// 设置完整结束IP
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIPEnd000(string value) {
                base.Row["IPEnd000"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属国家
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCountry(string value) {
                base.Row["Country"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属省份
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProvince(string value) {
                base.Row["Province"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属地区
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDistrict(string value) {
                base.Row["District"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属县级
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCounty(string value) {
                base.Row["County"] = value;
                return this;
            }

            /// <summary>
            /// 设置运营商
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOperators(string value) {
                base.Row["Operators"] = value;
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
        /// 获取开始IP字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IPStart { get; private set; }

        /// <summary>
        /// 获取结束IP字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IPEnd { get; private set; }

        /// <summary>
        /// 获取地址全称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Address { get; private set; }

        /// <summary>
        /// 获取完整开始IP字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IPStart000 { get; private set; }

        /// <summary>
        /// 获取完整结束IP字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IPEnd000 { get; private set; }

        /// <summary>
        /// 获取所属国家字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Country { get; private set; }

        /// <summary>
        /// 获取所属省份字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Province { get; private set; }

        /// <summary>
        /// 获取所属地区字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField District { get; private set; }

        /// <summary>
        /// 获取所属县级字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField County { get; private set; }

        /// <summary>
        /// 获取运营商字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Operators { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AosIPInfo() : base("AosIPInfo") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.IPStart = new dpz2.db.SqlUnits.TableField(this, "IPStart");
            this.IPEnd = new dpz2.db.SqlUnits.TableField(this, "IPEnd");
            this.Address = new dpz2.db.SqlUnits.TableField(this, "Address");
            this.IPStart000 = new dpz2.db.SqlUnits.TableField(this, "IPStart000");
            this.IPEnd000 = new dpz2.db.SqlUnits.TableField(this, "IPEnd000");
            this.Country = new dpz2.db.SqlUnits.TableField(this, "Country");
            this.Province = new dpz2.db.SqlUnits.TableField(this, "Province");
            this.District = new dpz2.db.SqlUnits.TableField(this, "District");
            this.County = new dpz2.db.SqlUnits.TableField(this, "County");
            this.Operators = new dpz2.db.SqlUnits.TableField(this, "Operators");
        }

    }

}
