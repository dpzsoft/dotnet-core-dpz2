using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Travel {

    /// <summary>
    /// 景区信息表
    /// 景区信息表
    /// Version 1807.0007
    /// </summary>
    public class TravelScenicArea : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 景区信息表 行数据操作器
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
            /// 设置景区名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置景区评级
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLv(string value) {
                base.Row["Lv"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属国家
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCountryID(string value) {
                base.Row["CountryID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属省份
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetProvinceID(string value) {
                base.Row["ProvinceID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属城市
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCityID(string value) {
                base.Row["CityID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属城市区域
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAreaID(string value) {
                base.Row["AreaID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属乡镇
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTownID(string value) {
                base.Row["TownID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属村庄
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVillageID(string value) {
                base.Row["VillageID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属景区
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetScenicAreaID(string value) {
                base.Row["ScenicAreaID"] = value;
                return this;
            }

            /// <summary>
            /// 设置经度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLongitude(string value) {
                base.Row["Longitude"] = value;
                return this;
            }

            /// <summary>
            /// 设置纬度
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetLatitude(string value) {
                base.Row["Latitude"] = value;
                return this;
            }

            /// <summary>
            /// 设置示意图
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImgPath(string value) {
                base.Row["ImgPath"] = value;
                return this;
            }

            /// <summary>
            /// 设置价格
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPrice(string value) {
                base.Row["Price"] = value;
                return this;
            }

            /// <summary>
            /// 设置门票信息
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTickets(string value) {
                base.Row["Tickets"] = value;
                return this;
            }

            /// <summary>
            /// 设置订票电话
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTel(string value) {
                base.Row["Tel"] = value;
                return this;
            }

            /// <summary>
            /// 设置网站
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetWebsite(string value) {
                base.Row["Website"] = value;
                return this;
            }

            /// <summary>
            /// 设置交通情况
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTraffic(string value) {
                base.Row["Traffic"] = value;
                return this;
            }

            /// <summary>
            /// 设置开放时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOpeningHours(string value) {
                base.Row["OpeningHours"] = value;
                return this;
            }

            /// <summary>
            /// 设置游玩时长
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDuration(string value) {
                base.Row["Duration"] = value;
                return this;
            }

            /// <summary>
            /// 设置访问量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetVisited(string value) {
                base.Row["Visited"] = value;
                return this;
            }

            /// <summary>
            /// 设置简介
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSummary(string value) {
                base.Row["Summary"] = value;
                return this;
            }

            /// <summary>
            /// 设置详情
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDescription(string value) {
                base.Row["Description"] = value;
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
        /// 获取景区名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取景区评级字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Lv { get; private set; }

        /// <summary>
        /// 获取所属国家字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CountryID { get; private set; }

        /// <summary>
        /// 获取所属省份字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ProvinceID { get; private set; }

        /// <summary>
        /// 获取所属城市字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CityID { get; private set; }

        /// <summary>
        /// 获取所属城市区域字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AreaID { get; private set; }

        /// <summary>
        /// 获取所属乡镇字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TownID { get; private set; }

        /// <summary>
        /// 获取所属村庄字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField VillageID { get; private set; }

        /// <summary>
        /// 获取所属景区字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ScenicAreaID { get; private set; }

        /// <summary>
        /// 获取经度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Longitude { get; private set; }

        /// <summary>
        /// 获取纬度字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Latitude { get; private set; }

        /// <summary>
        /// 获取示意图字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ImgPath { get; private set; }

        /// <summary>
        /// 获取价格字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Price { get; private set; }

        /// <summary>
        /// 获取门票信息字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Tickets { get; private set; }

        /// <summary>
        /// 获取订票电话字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Tel { get; private set; }

        /// <summary>
        /// 获取网站字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Website { get; private set; }

        /// <summary>
        /// 获取交通情况字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Traffic { get; private set; }

        /// <summary>
        /// 获取开放时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OpeningHours { get; private set; }

        /// <summary>
        /// 获取游玩时长字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Duration { get; private set; }

        /// <summary>
        /// 获取访问量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Visited { get; private set; }

        /// <summary>
        /// 获取简介字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Summary { get; private set; }

        /// <summary>
        /// 获取详情字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Description { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public TravelScenicArea() : base("TravelScenicArea") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Lv = new dpz2.db.SqlUnits.TableField(this, "Lv");
            this.CountryID = new dpz2.db.SqlUnits.TableField(this, "CountryID");
            this.ProvinceID = new dpz2.db.SqlUnits.TableField(this, "ProvinceID");
            this.CityID = new dpz2.db.SqlUnits.TableField(this, "CityID");
            this.AreaID = new dpz2.db.SqlUnits.TableField(this, "AreaID");
            this.TownID = new dpz2.db.SqlUnits.TableField(this, "TownID");
            this.VillageID = new dpz2.db.SqlUnits.TableField(this, "VillageID");
            this.ScenicAreaID = new dpz2.db.SqlUnits.TableField(this, "ScenicAreaID");
            this.Longitude = new dpz2.db.SqlUnits.TableField(this, "Longitude");
            this.Latitude = new dpz2.db.SqlUnits.TableField(this, "Latitude");
            this.ImgPath = new dpz2.db.SqlUnits.TableField(this, "ImgPath");
            this.Price = new dpz2.db.SqlUnits.TableField(this, "Price");
            this.Tickets = new dpz2.db.SqlUnits.TableField(this, "Tickets");
            this.Tel = new dpz2.db.SqlUnits.TableField(this, "Tel");
            this.Website = new dpz2.db.SqlUnits.TableField(this, "Website");
            this.Traffic = new dpz2.db.SqlUnits.TableField(this, "Traffic");
            this.OpeningHours = new dpz2.db.SqlUnits.TableField(this, "OpeningHours");
            this.Duration = new dpz2.db.SqlUnits.TableField(this, "Duration");
            this.Visited = new dpz2.db.SqlUnits.TableField(this, "Visited");
            this.Summary = new dpz2.db.SqlUnits.TableField(this, "Summary");
            this.Description = new dpz2.db.SqlUnits.TableField(this, "Description");
        }

    }

}
