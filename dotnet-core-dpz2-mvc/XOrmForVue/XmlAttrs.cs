using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Mvc.XOrmForVue {

    /// <summary>
    /// XML属性集合
    /// </summary>
    public class XmlAttrs : dpz2.KeyValues<string> {

        /// <summary>
        /// 获取字符串表示形式
        /// </summary>
        /// <returns></returns>
        protected override string OnParseString() {
            string res = "";
            foreach (var item in this) {
                res += " " + item.Key + "=\"" + item.Value + "\"";
            }
            //return base.OnParseString();
            return res;
        }

    }
}
