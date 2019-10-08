using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Mvc.XOrmForVue {

    /// <summary>
    /// 视图
    /// </summary>
    public class View : Basic {

        /// <summary>
        /// 对象实例化
        /// </summary>
        /// <param name="db"></param>
        /// <param name="form"></param>
        /// <param name="tables"></param>
        /// <param name="config"></param>
        /// <param name="plmName"></param>
        /// <param name="tabName"></param>
        public View(dpz2.db.Database db, dpz2.db.OrmTables tables, dpz2.db.Row form, Config config, string plmName, string tabName) : base(db, tables, form, config, plmName, tabName) {
        }

        /// <summary>
        /// 获取数据查看HTML代码
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="plmName"></param>
        /// <param name="tabName"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public string GetHtml(string tagName, string plmName, string tabName, dpz2.db.Row row = null) {

            string res;

            if (row == null) row = new dpz2.db.Row();

            //存储所有的列信息
            string html = "";

            //读取配置文件内容
            string xmlText = dpz2.File.UTF8File.ReadAllText(base.XmlPath);
            using (var xml = dpz2.Xml.Parser.GetDocument(xmlText)) {
                var table = xml["table"];

                var inf = table["interfaces"].GetNodeByAttr("name", tagName);
                if (inf == null) throw new Exception($"未找到界面\"{tagName}\"定义，请检查配置文件");
                if (inf.Attr["type"] != "view") throw new Exception($"界面\"{tagName}\"非视图类型，请检查配置文件");

                var infLine = inf["line"];
                var infTitle = inf["title"];
                var infContent = inf["Content"];

                string tagLineName = infLine.Attr["tag-name"];
                string tagTitleName = infTitle.Attr["tag-name"];
                string tagContentName = infContent.Attr["tag-name"];

                // 获取所有的字段定义
                var fields = table["fields"].GetNodesByTagName("field", false);
                foreach (var field in fields) {
                    if (field.Name.ToLower() == "field") {
                        string fieldName = field.Attr["name"];
                        string fieldTitle = field.Attr["title"];
                        //string fieldInputId = "txt" + formId + fieldName;

                        string fieldValue = row[fieldName];
                        var fieldData = field["data"];
                        string fieldDataType = fieldData.Attr["type"];

                        //处理所有数字类的值
                        switch (fieldDataType) {
                            case "double":
                            case "float":
                            case "decimal":
                            case "numeric":
                            case "long":
                            case "bigint":
                            case "integer":
                            case "int":
                                //fieldValue = YString.New(fieldValue).Double.ToString();
                                if (fieldValue != "") {
                                    string yString = fieldValue;
                                    fieldValue = yString.ToDouble().ToString();
                                }
                                break;
                        }

                        var fieldView = field[tagName];
                        string fieldViewType = fieldView.Attr["type"].ToLower();

                        switch (fieldViewType) {
                            case "": case "none": break;
                            case "text"://文本处理
                                string fieldAddFollow = fieldView.Attr["follow"].ToLower();
                                if (html != "") {
                                    if (fieldAddFollow != "true") {

                                        #region [=====输出行=====]

                                        string lineAttr = "";

                                        foreach (var attr in infLine.Attr) {

                                            if (attr.Key != "tag-name") {
                                                string sz = attr.Value;

                                                sz = sz.Replace("{{", "{{}");
                                                sz = sz.Replace("}}", "{}}");

                                                foreach (var item in row) {
                                                    sz = sz.Replace("{" + item.Key + "}", item.Value);
                                                }

                                                sz = sz.Replace("{{}", "{");
                                                sz = sz.Replace("{}}", "}");

                                                lineAttr += $" {attr.Key}=\"{attr.Value}\"";
                                            }

                                        }

                                        html += $"</{tagLineName}><{tagLineName}{lineAttr}>";

                                        #endregion
                                    }
                                }

                                #region [=====输出标题=====]

                                string titleAttr = "";

                                foreach (var attr in infTitle.Attr) {

                                    if (attr.Key != "tag-name") {
                                        string sz = attr.Value;

                                        sz = sz.Replace("{{", "{{}");
                                        sz = sz.Replace("}}", "{}}");

                                        foreach (var item in row) {
                                            sz = sz.Replace("{" + item.Key + "}", item.Value);
                                        }

                                        sz = sz.Replace("{{}", "{");
                                        sz = sz.Replace("{}}", "}");

                                        titleAttr += $" {attr.Key}=\"{attr.Value}\"";
                                    }

                                }

                                html += $"<{tagTitleName}{titleAttr}>{fieldTitle}</{tagTitleName}>";

                                #endregion

                                #region [=====输出内容=====]

                                string contentAttr = "";

                                foreach (var attr in infTitle.Attr) {

                                    if (attr.Key != "tag-name") {
                                        string sz = attr.Value;

                                        sz = sz.Replace("{{", "{{}");
                                        sz = sz.Replace("}}", "{}}");

                                        foreach (var item in row) {
                                            sz = sz.Replace("{" + item.Key + "}", item.Value);
                                        }

                                        sz = sz.Replace("{{}", "{");
                                        sz = sz.Replace("{}}", "}");

                                        contentAttr += $" {attr.Key}=\"{attr.Value}\"";
                                    }

                                }

                                html += $"<{tagContentName}{contentAttr}>{fieldValue}</{tagContentName}>";

                                #endregion
                                //html += $"<{titleTagName}>{fieldTitle}</{titleTagName}>" +
                                //$"<{contentTagName}>{fieldValue}</{contentTagName}>";
                                break;
                            default:
                                throw new Exception($"不支持的表单字段类型：'{fieldViewType}',相关字段：'{fieldTitle}'");
                        }
                    }
                }

                #region [=====输出第一个字段行及全部内容=====]

                string lineFirst = "";

                foreach (var attr in infLine.Attr) {

                    if (attr.Key != "tag-name") {
                        string sz = attr.Value;

                        sz = sz.Replace("{{", "{{}");
                        sz = sz.Replace("}}", "{}}");

                        foreach (var item in row) {
                            sz = sz.Replace("{" + item.Key + "}", item.Value);
                        }

                        sz = sz.Replace("{{}", "{");
                        sz = sz.Replace("{}}", "}");

                        lineFirst += $" {attr.Key}=\"{attr.Value}\"";
                    }

                }

                res = $"<{tagLineName}{lineFirst}>{html}</{tagLineName}>";

                #endregion

            }

            return res;

        }

        /// <summary>
        /// 获取数据查看HTML代码
        /// </summary>
        /// <param name="plmName"></param>
        /// <param name="tabName"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public string GetHtml(string plmName, string tabName, dpz2.db.Row row = null) {
            return GetHtml("view", plmName, tabName, row);
        }

    }

}
