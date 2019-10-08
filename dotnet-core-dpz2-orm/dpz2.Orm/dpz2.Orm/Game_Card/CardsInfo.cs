using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Game_Card {

    /// <summary>
    /// 卡片信息
    /// 存储所有的卡片信息
    /// Version 1702.0002
    /// </summary>
    public class CardsInfo : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 卡片信息 行数据操作器
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
            /// 设置卡片类型
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCardType(string value) {
                base.Row["CardType"] = value;
                return this;
            }

            /// <summary>
            /// 设置卡片等级
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCardLv(string value) {
                base.Row["CardLv"] = value;
                return this;
            }

            /// <summary>
            /// 设置价值
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPrice(string value) {
                base.Row["Price"] = value;
                return this;
            }

            /// <summary>
            /// 设置兑换数量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetExchangeNumber(string value) {
                base.Row["ExchangeNumber"] = value;
                return this;
            }

            /// <summary>
            /// 设置发放数量
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOfferNumber(string value) {
                base.Row["OfferNumber"] = value;
                return this;
            }

            /// <summary>
            /// 设置发放间隔
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOfferInterval(string value) {
                base.Row["OfferInterval"] = value;
                return this;
            }

            /// <summary>
            /// 设置发卡时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetOfferTime(string value) {
                base.Row["OfferTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置卡片图像
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCardImageNormal(string value) {
                base.Row["CardImageNormal"] = value;
                return this;
            }

            /// <summary>
            /// 设置卡片图像
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCardImageFull(string value) {
                base.Row["CardImageFull"] = value;
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
        /// 获取卡片类型字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CardType { get; private set; }

        /// <summary>
        /// 获取卡片等级字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CardLv { get; private set; }

        /// <summary>
        /// 获取价值字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Price { get; private set; }

        /// <summary>
        /// 获取兑换数量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ExchangeNumber { get; private set; }

        /// <summary>
        /// 获取发放数量字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OfferNumber { get; private set; }

        /// <summary>
        /// 获取发放间隔字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OfferInterval { get; private set; }

        /// <summary>
        /// 获取发卡时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField OfferTime { get; private set; }

        /// <summary>
        /// 获取卡片图像字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CardImageNormal { get; private set; }

        /// <summary>
        /// 获取卡片图像字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CardImageFull { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public CardsInfo() : base("CardsInfo") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.CardType = new dpz2.db.SqlUnits.TableField(this, "CardType");
            this.CardLv = new dpz2.db.SqlUnits.TableField(this, "CardLv");
            this.Price = new dpz2.db.SqlUnits.TableField(this, "Price");
            this.ExchangeNumber = new dpz2.db.SqlUnits.TableField(this, "ExchangeNumber");
            this.OfferNumber = new dpz2.db.SqlUnits.TableField(this, "OfferNumber");
            this.OfferInterval = new dpz2.db.SqlUnits.TableField(this, "OfferInterval");
            this.OfferTime = new dpz2.db.SqlUnits.TableField(this, "OfferTime");
            this.CardImageNormal = new dpz2.db.SqlUnits.TableField(this, "CardImageNormal");
            this.CardImageFull = new dpz2.db.SqlUnits.TableField(this, "CardImageFull");
        }

    }

}
