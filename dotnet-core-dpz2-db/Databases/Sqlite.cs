using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.db.Databases {

    /// <summary>
    /// 一款轻型的数据库，是遵守ACID的关系型数据库管理系统
    /// </summary>
    public class Sqlite : dpz2.db.Database {

        /// <summary>
        /// 存储路径
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public Sqlite() {
            base.Type = dpz2.db.DatabaseTypes.SQLite;
        }

        /// <summary>
        /// 获取字符串表现形式
        /// </summary>
        /// <returns></returns>
        protected override string OnParseString() {
            //return "server=" + this.Address + ";user id=" + this.User + ";password=" + this.Password + ";database=" + this.Name + ";port=" + this.Port + ";pooling=false;Connect Timeout=600;";
            return $"data source={this.Path}";
        }

    }
}
