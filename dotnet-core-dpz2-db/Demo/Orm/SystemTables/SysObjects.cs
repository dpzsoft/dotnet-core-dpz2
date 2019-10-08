using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Orm.SystemTables {

    /// <summary>
    /// Sql Server专用系统对象表
    /// </summary>
    public class SysObjects : dpz2.db.SqlUnits.Table {

        /// <summary>
        /// 获取Id字段
        /// </summary>
        public dpz2.db.SqlUnits.TableField Id { get; private set; }

        /// <summary>
        /// 获取Name字段
        /// </summary>
        public dpz2.db.SqlUnits.TableField Name { get; private set; }

        /// <summary>
        /// 获取Type字段
        /// </summary>
        public dpz2.db.SqlUnits.TableField Type { get; private set; }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public SysObjects() : base("SysObjects") {
            this.Id = new dpz2.db.SqlUnits.TableField(this, "Id");
            this.Name = new dpz2.db.SqlUnits.TableField(this, "Name");
            this.Type = new dpz2.db.SqlUnits.TableField(this, "Type");
        }

    }
}
