using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Moments {

    /// <summary>
    /// 朋友圈图片
    /// 朋友圈图片
    /// Version 1.0.1905.1
    /// </summary>
    public class MomentsImage : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 朋友圈图片 行数据操作器
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
            /// 设置朋友圈标识
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetMomentsID(string value) {
                base.Row["MomentsID"] = value;
                return this;
            }

            /// <summary>
            /// 设置图片地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetUrl(string value) {
                base.Row["Url"] = value;
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
        /// 获取朋友圈标识字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField MomentsID { get; private set; }

        /// <summary>
        /// 获取图片地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Url { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public MomentsImage() : base("MomentsImage") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.MomentsID = new dpz2.db.SqlUnits.TableField(this, "MomentsID");
            this.Url = new dpz2.db.SqlUnits.TableField(this, "Url");
        }

    }

}
