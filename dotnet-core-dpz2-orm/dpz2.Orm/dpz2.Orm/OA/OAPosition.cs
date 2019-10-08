using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.OA {

    /// <summary>
    /// 职位信息
    /// OA职位信息
    /// Version 1712.0003
    /// </summary>
    public class OAPosition : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 职位信息 行数据操作器
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
            /// 设置职位对象
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetObjectID(string value) {
                base.Row["ObjectID"] = value;
                return this;
            }

            /// <summary>
            /// 设置职位名称
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }

            /// <summary>
            /// 设置上级职位
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSuperiorID(string value) {
                base.Row["SuperiorID"] = value;
                return this;
            }

            /// <summary>
            /// 设置所属路径
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetBelongPath(string value) {
                base.Row["BelongPath"] = value;
                return this;
            }

            /// <summary>
            /// 设置可用状态
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetEnabled(string value) {
                base.Row["Enabled"] = value;
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
        /// 获取职位对象字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField ObjectID { get; private set; }

        /// <summary>
        /// 获取职位名称字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取上级职位字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField SuperiorID { get; private set; }

        /// <summary>
        /// 获取所属路径字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField BelongPath { get; private set; }

        /// <summary>
        /// 获取可用状态字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Enabled { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public OAPosition() : base("OAPosition") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.ObjectID = new dpz2.db.SqlUnits.TableField(this, "ObjectID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.SuperiorID = new dpz2.db.SqlUnits.TableField(this, "SuperiorID");
            this.BelongPath = new dpz2.db.SqlUnits.TableField(this, "BelongPath");
            this.Enabled = new dpz2.db.SqlUnits.TableField(this, "Enabled");
        }

    }

}
