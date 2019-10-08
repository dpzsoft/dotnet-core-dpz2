using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm.AI {

    /// <summary>
    /// 记忆库
    /// 记忆库
    /// Version 2016.0401
    /// </summary>
    public class AIMemory : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 记忆库 行数据操作器
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
            /// 设置主词
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetSubject(string value) {
                base.Row["Subject"] = value;
                return this;
            }

            /// <summary>
            /// 设置描述
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetDepict(string value) {
                base.Row["Depict"] = value;
                return this;
            }

            /// <summary>
            /// 设置宾语
            /// </summary>
            /// <param name="value">值</param>
            public RowOperator SetObject(string value) {
                base.Row["Object"] = value;
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
        /// 获取主词字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Subject { get; private set; }

        /// <summary>
        /// 获取描述字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Depict { get; private set; }

        /// <summary>
        /// 获取宾语字段定义
        /// </summary>
        public dpz2.db.SqlUnits.TableField Object { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象</param>
        public RowOperator Rower(dpz2.db.Row row) { return new RowOperator(row); }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public AIMemory() : base("AIMemory") {
            this.All = new dpz2.db.SqlUnits.TableField(this, "*");
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Subject = new dpz2.db.SqlUnits.TableField(this, "Subject");
            this.Depict = new dpz2.db.SqlUnits.TableField(this, "Depict");
            this.Object = new dpz2.db.SqlUnits.TableField(this, "Object");
        }

    }

}
