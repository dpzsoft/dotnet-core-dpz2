using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Game_Card {

    /// <summary>
    /// 卡片发放
    /// 存储所有的卡片发放信息
    /// Version 1702.0001
    /// </summary>
    public class CardsOffers : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 卡片发放 行数据操作器
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
            /// 设置卡片标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetCardID(string value) {
                base.Row["CardID"] = value;
                return this;
            }

            /// <summary>
            /// 设置抽卡用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDistillUser(string value) {
                base.Row["DistillUser"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属用户
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBelongUser(string value) {
                base.Row["BelongUser"] = value;
                return this;
            }

            /// <summary>
            /// 设置抽卡时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDistillTime(string value) {
                base.Row["DistillTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置兑奖时间
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetExchangeTime(string value) {
                base.Row["ExchangeTime"] = value;
                return this;
            }

            /// <summary>
            /// 设置发卡状态
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
        /// 获取卡片标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField CardID { get; private set; }

        /// <summary>
        /// 获取抽卡用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DistillUser { get; private set; }

        /// <summary>
        /// 获取所属用户字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BelongUser { get; private set; }

        /// <summary>
        /// 获取抽卡时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField DistillTime { get; private set; }

        /// <summary>
        /// 获取兑奖时间字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ExchangeTime { get; private set; }

        /// <summary>
        /// 获取发卡状态字段定义
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
        public CardsOffers() : base("CardsOffers") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.CardID = new dpz2.db.SqlUnits.TableField(this, "CardID");
            this.DistillUser = new dpz2.db.SqlUnits.TableField(this, "DistillUser");
            this.BelongUser = new dpz2.db.SqlUnits.TableField(this, "BelongUser");
            this.DistillTime = new dpz2.db.SqlUnits.TableField(this, "DistillTime");
            this.ExchangeTime = new dpz2.db.SqlUnits.TableField(this, "ExchangeTime");
            this.Status = new dpz2.db.SqlUnits.TableField(this, "Status");
        }

    }

}
