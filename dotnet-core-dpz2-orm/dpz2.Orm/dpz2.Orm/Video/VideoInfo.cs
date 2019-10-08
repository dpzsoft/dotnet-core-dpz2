using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.Video {

    /// <summary>
    /// 视频信息
    /// 视频信息
    /// Version 1712.0002
    /// </summary>
    public class VideoInfo : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 视频信息 行数据操作器
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
            /// 设置视频系列
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSeriesID(string value) {
                base.Row["SeriesID"] = value;
                return this;
            }

            /// <summary>
            /// 设置视频分组
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetGroupID(string value) {
                base.Row["GroupID"] = value;
                return this;
            }

            /// <summary>
            /// 设置视频名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置排序索引
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetIndex(string value) {
                base.Row["Index"] = value;
                return this;
            }

            /// <summary>
            /// 设置存储地址
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetPath(string value) {
                base.Row["Path"] = value;
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
        /// 获取视频系列字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SeriesID { get; private set; }

        /// <summary>
        /// 获取视频分组字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField GroupID { get; private set; }

        /// <summary>
        /// 获取视频名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取排序索引字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Index { get; private set; }

        /// <summary>
        /// 获取存储地址字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Path { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public VideoInfo() : base("VideoInfo") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.SeriesID = new dpz2.db.SqlUnits.TableField(this, "SeriesID");
            this.GroupID = new dpz2.db.SqlUnits.TableField(this, "GroupID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Index = new dpz2.db.SqlUnits.TableField(this, "Index");
            this.Path = new dpz2.db.SqlUnits.TableField(this, "Path");
        }

    }

}
