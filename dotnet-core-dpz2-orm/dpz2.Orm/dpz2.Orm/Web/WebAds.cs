using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Web {

    /// <summary>
    /// 页面广告表
    /// 页面广告表
    /// Version 1.1.1905.3
    /// </summary>
    public class WebAds : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 页面广告表 行数据操作器
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
            /// 设置授权识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetAuthID(string value) {
                base.Row["AuthID"] = value;
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
            /// 设置主要图像
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetImgPath(string value) {
                base.Row["ImgPath"] = value;
                return this;
            }

            /// <summary>
            /// 设置背景图像
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBgPath(string value) {
                base.Row["BgPath"] = value;
                return this;
            }

            /// <summary>
            /// 设置链接地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUrl(string value) {
                base.Row["Url"] = value;
                return this;
            }

            /// <summary>
            /// 设置内容对象
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTarget(string value) {
                base.Row["Target"] = value;
                return this;
            }

            /// <summary>
            /// 设置内容对象标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetTargetID(string value) {
                base.Row["TargetID"] = value;
                return this;
            }

            /// <summary>
            /// 设置排序
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIndex(string value) {
                base.Row["Index"] = value;
                return this;
            }

            /// <summary>
            /// 设置有效状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIsEnabled(string value) {
                base.Row["IsEnabled"] = value;
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
        /// 获取授权识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField AuthID { get; private set; }

        /// <summary>
        /// 获取名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取主要图像字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ImgPath { get; private set; }

        /// <summary>
        /// 获取背景图像字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BgPath { get; private set; }

        /// <summary>
        /// 获取链接地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Url { get; private set; }

        /// <summary>
        /// 获取内容对象字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Target { get; private set; }

        /// <summary>
        /// 获取内容对象标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField TargetID { get; private set; }

        /// <summary>
        /// 获取排序字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Index { get; private set; }

        /// <summary>
        /// 获取有效状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField IsEnabled { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public WebAds() : base("WebAds") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.AuthID = new dpz2.db.SqlUnits.TableField(this, "AuthID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.ImgPath = new dpz2.db.SqlUnits.TableField(this, "ImgPath");
            this.BgPath = new dpz2.db.SqlUnits.TableField(this, "BgPath");
            this.Url = new dpz2.db.SqlUnits.TableField(this, "Url");
            this.Target = new dpz2.db.SqlUnits.TableField(this, "Target");
            this.TargetID = new dpz2.db.SqlUnits.TableField(this, "TargetID");
            this.Index = new dpz2.db.SqlUnits.TableField(this, "Index");
            this.IsEnabled = new dpz2.db.SqlUnits.TableField(this, "IsEnabled");
        }

    }

}
