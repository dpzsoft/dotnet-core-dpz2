using System;
using System.Collections.Generic;
using System.Text;
using dpz2.db;
using dpz2.db.SqlUnits;
using dpz2;

namespace Demo.Orm.SystemTables {

    /// <summary>
    /// Sql Server专用系统对象表
    /// </summary>
    public class abc : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 行数据操作器
        /// </summary>
        public class RowOperator : dpz2.db.RowOperator {

            /// <summary>
            /// 对象实例化
            /// </summary>
            /// <param name="row"></param>
            public RowOperator(Row row) : base(row) { }

            /// <summary>
            /// 获取或设置 ID
            /// </summary>
            public long ID { get { return base.Row["ID"].ToLong(); } set { base.Row["ID"] = "" + value; } }

            /// <summary>
            /// 获取或设置 ID
            /// </summary>
            public string Name { get { return base.Row["Name"]; } set { base.Row["Name"] = value; } }

            /// <summary>
            /// 设置ID
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public RowOperator SetID(long value) {
                base.Row["ID"] = "" + value;
                return this;
            }

            /// <summary>
            /// 设置Name
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public RowOperator SetName(string value) {
                base.Row["Name"] = value;
                return this;
            }
        }

        /// <summary>
        /// 获取Id字段
        /// </summary>
        public dpz2.db.SqlUnits.TableField ID { get; private set; }

        /// <summary>
        /// 获取Name字段
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 创建一个行数据操作器
        /// </summary>
        /// <param name="row">行数据对象,默认为NULL,为NULL时操作器将实例化一个新的行数据对象</param>
        /// <returns></returns>
        public RowOperator Rower(Row row = null) {
            if (row == null) row = new Row();
            return new RowOperator(row);
        }

        /// <summary>
        /// 获取字段定义
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        protected override TableField OnGetField(string name) {
            switch (name) {
                case "ID": return this.ID;
                case "Name": return this.Name;
                default: return base.OnGetField(name);
            }

        }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public abc() : base("abc") {
            this.ID = new dpz2.db.SqlUnits.TableField(this, "ID");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
        }

    }
}
