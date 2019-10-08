using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.db.SqlUnits.Functions {

    /// <summary>
    /// 函数定义基类
    /// </summary>
    public abstract class Basic : dpz2.Object {

        /// <summary>
        /// 函数名称
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 对象实例化
        /// </summary>
        /// <param name="name"></param>
        public Basic(string name) {
            this.Name = name;
        }

    }
}
