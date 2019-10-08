using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Mvc.XOrmForVue {

    /// <summary>
    /// 添加表单
    /// </summary>
    public class AddForm : Form {

        /// <summary>
        /// 对象实例化
        /// </summary>
        /// <param name="db"></param>
        /// <param name="form"></param>
        /// <param name="tables"></param>
        /// <param name="config"></param>
        /// <param name="plmName"></param>
        /// <param name="tabName"></param>
        public AddForm(dpz2.db.Database db, dpz2.db.OrmTables tables, dpz2.db.Row form, Config config, string plmName, string tabName) : base(db, tables, form, config, plmName, tabName) {
        }

        /// <summary>
        /// 获取修改数据表单HTML代码
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public string GetHtml(string formId = "") {
            return GetHtml("add", "add", formId);
        }

        /// <summary>
        /// 获取修改数据表单HTML代码
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public string GetHtml(string tagName, string formId = "") {
            return GetHtml(tagName, "add", formId);
        }

    }
}
