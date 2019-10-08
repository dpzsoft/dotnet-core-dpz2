using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.EM {

    /// <summary>
    /// 信息流程
    /// 信息流程
    /// Version 2016.0401
    /// </summary>
    public class EMProcess : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 信息流程 行数据操作器
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
            /// 设置流程名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置前一流程
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBeforeID(string value) {
                base.Row["BeforeID"] = value;
                return this;
            }

            /// <summary>
            /// 设置流程识标
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSign(string value) {
                base.Row["Sign"] = value;
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
        /// 获取流程名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取前一流程字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BeforeID { get; private set; }

        /// <summary>
        /// 获取流程识标字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Sign { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public EMProcess() : base("EMProcess") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.BeforeID = new dpz2.db.SqlUnits.TableField(this, "BeforeID");
            this.Sign = new dpz2.db.SqlUnits.TableField(this, "Sign");
        }

    }

}
