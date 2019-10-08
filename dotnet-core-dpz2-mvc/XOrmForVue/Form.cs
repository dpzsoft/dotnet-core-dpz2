using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Mvc.XOrmForVue {

    /// <summary>
    /// 表单
    /// </summary>
    public class Form : Basic {

        /// <summary>
        /// 对象实例化
        /// </summary>
        /// <param name="db"></param>
        /// <param name="form"></param>
        /// <param name="tables"></param>
        /// <param name="config"></param>
        /// <param name="plmName"></param>
        /// <param name="tabName"></param>
        public Form(dpz2.db.Database db, dpz2.db.OrmTables tables, dpz2.db.Row form, Config config, string plmName, string tabName) : base(db, tables, form, config, plmName, tabName) {
        }

        /// <summary>
        /// 获取数据表单HTML代码
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="formType"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public string GetHtml(string tagName, string formType, string formId = "") {

            string res;

            //存储所有的列信息
            string html = "";

            //读取配置文件内容
            string xmlText = dpz2.File.UTF8File.ReadAllText(base.XmlPath);
            using (var xml = dpz2.Xml.Parser.GetDocument(xmlText)) {
                var table = xml["table"];
                if (table == null) {
                    table = new Xml.XmlNode("table");
                    xml.Nodes.Add(table);
                }

                var inf = table["interfaces"].GetNodeByAttr("name", tagName);
                if (inf == null) throw new Exception($"未找到界面\"{tagName}\"定义，请检查配置文件");
                if (inf.Attr["type"] != formType) throw new Exception($"界面\"{tagName}\"非{formType}类型，请检查配置文件");

                var infLine = inf["line"];
                var infTitle = inf["title"];
                var infContent = inf["content"];
                string tagLineName = infLine.Attr["tag-name"];
                string tagTitleName = infTitle.Attr["tag-name"];
                string tagContentName = infContent.Attr["tag-name"];
                //string tagContentBind = infContent.Attr["bind"];

                var fields = table["fields"].GetNodesByTagName("field", false);
                foreach (var field in fields) {
                    if (field.Name.ToLower() == "field") {
                        string fieldName = field.Attr["name"];
                        string fieldTitle = field.Attr["title"];
                        string fieldInputId = "txt" + formId + fieldName;

                        // 获取数据配置
                        var fieldData = field["data"];
                        string fieldDataType = "";
                        if (fieldData != null) fieldDataType = fieldData.Attr["type"];

                        // 获取表单类型配置
                        var fieldForm = field[formType];
                        if (fieldForm == null) {
                            fieldForm = new Xml.XmlNode(formType);
                            fieldForm.Attr["type"] = "";
                        }

                        string fieldAddType = fieldForm.Attr["type"]?.ToLower();

                        string fieldBind = fieldForm.Attr["bind"];
                        string fieldModel = fieldForm.Attr["model"];
                        string fieldValue = "";

                        //添加行信息
                        #region [=====输出行=====]
                        switch (fieldAddType) {
                            case "": case "none": break;
                            case "input":
                            case "select":
                            case "textarea":
                            case "html":


                                string lineAttr = "";

                                //添加专用样式
                                string lineClass = infLine.Attr["class"];

                                foreach (var attr in infLine.Attr) {

                                    string attrValue = attr.Value;

                                    if (attr.Key != "tag-name") {
                                        switch (attr.Key) {
                                            case "class":
                                                if (attrValue != "") attrValue += " ";
                                                attrValue += "xform-line-" + fieldName;
                                                lineAttr += $" {attr.Key}=\"{attrValue}\"";
                                                break;
                                            default:
                                                lineAttr += $" {attr.Key}=\"{attrValue}\"";
                                                break;
                                        }


                                    }

                                }

                                html += $"<{tagLineName}{lineAttr}>";
                                break;
                            default:
                                throw new Exception($"不支持的表单字段类型：'{fieldAddType}',相关字段：'{fieldTitle}'");
                        }

                        #endregion

                        //处理操作类型
                        string fieldContent = "";
                        XmlAttrs elAttr = new XmlAttrs();


                        switch (fieldAddType) {
                            case "": case "none": break;
                            case "input":
                                elAttr["id"] = fieldInputId;
                                elAttr["name"] = fieldName;
                                elAttr["type"] = "text";
                                elAttr["placeholder"] = fieldTitle;
                                string fieldAddReadonly = fieldForm.Attr["readonly"]?.ToLower();
                                string fieldAddWidth = fieldForm.Attr["width"]?.ToLower();

                                elAttr["style"] = (!fieldAddWidth.IsNoneOrNull() ? "width:" + fieldAddWidth + ";" : "");
                                if (!fieldBind.IsNone()) elAttr["v-bind:value"] = fieldBind;
                                if (!fieldModel.IsNone()) elAttr["v-model"] = fieldModel;
                                elAttr["value"] = fieldValue;
                                if (fieldAddReadonly == "true") elAttr["readonly"] = "readonly";

                                fieldContent = $"<input{elAttr.ToString()} />";
                                break;
                            case "select":
                                fieldAddReadonly = fieldForm.Attr["readonly"]?.ToLower();
                                fieldAddWidth = fieldForm.Attr["width"]?.ToLower();

                                elAttr["id"] = fieldInputId;
                                elAttr["name"] = fieldName;
                                //样式处理
                                elAttr["style"] = (!fieldAddWidth.IsNoneOrNull() ? "width:" + fieldAddWidth + ";" : "");
                                //只读处理
                                if (fieldAddReadonly == "true") elAttr["readonly"] = "readonly";

                                //vue表单绑定
                                if (!fieldModel.IsNone()) elAttr["v-model"] = fieldModel;

                                fieldContent = $"<select{elAttr.ToString()}>";

                                var fieldSelect = fieldForm["select"].GetNodesByTagName("option", false);
                                foreach (var option in fieldSelect) {
                                    if (option.Name == "option") {
                                        var optionValue = option.Attr["value"];
                                        var optionText = option.Attr["text"];
                                        if (optionText.IsNoneOrNull()) optionText = option.InnerXml;

                                        if (fieldBind.IsNone()) {
                                            fieldContent += $"<option value=\"{optionValue}\">{optionText}</option>";
                                        } else {
                                            fieldContent += $"<option v-if=\"{fieldBind}==='{optionValue}'\" value=\"{optionValue}\" selected=\"selected\">{optionText}</option>";
                                            fieldContent += $"<option v-else value=\"{optionValue}\">{optionText}</option>";
                                        }
                                    }
                                }

                                fieldContent += "</select>";
                                break;
                            case "textarea":
                                fieldAddReadonly = fieldForm.Attr["readonly"].ToLower();
                                fieldAddWidth = fieldForm.Attr["width"].ToLower();
                                var fieldAddHeight = fieldForm.Attr["height"].ToLower();

                                //id属性
                                elAttr["id"] = fieldInputId;
                                //name属性
                                elAttr["name"] = fieldName;
                                //placeholder属性
                                elAttr["placeholder"] = fieldTitle;
                                //样式处理
                                elAttr["style"] = (fieldAddWidth != "" ? "width:" + fieldAddWidth + ";" : "") + (fieldAddHeight != "" ? "height:" + fieldAddHeight + ";" : "");
                                //只读处理
                                if (fieldAddReadonly == "true") elAttr["readonly"] = "readonly";
                                //vue表单绑定
                                if (!fieldModel.IsNone()) elAttr["v-model"] = fieldModel;

                                if (fieldBind.IsNone()) {
                                    fieldContent = $"<textarea{elAttr.ToString()}></textarea>";
                                } else {
                                    fieldContent = $"<textarea{elAttr.ToString()}>{{{{{fieldBind}}}}}</textarea>";
                                }
                                break;
                            case "html":
                                //fieldAddFollow = fieldAdd.Attr["follow"].ToLower();
                                var tableFolder = base.XmlPath.Substring(0, base.XmlPath.Length - 4);
                                if (!System.IO.Directory.Exists(tableFolder)) System.IO.Directory.CreateDirectory(tableFolder);
                                var htmlPath = tableFolder + "/" + fieldName + "." + formType + ".html";
                                var fieldHtmlContent = dpz2.File.UTF8File.ReadAllText(htmlPath, true);
                                fieldContent = fieldHtmlContent;
                                break;

                        }

                        //合成html
                        switch (fieldAddType) {
                            case "": case "none": break;
                            case "input":
                            case "select":
                            case "textarea":
                            case "html":
                                #region [=====输出标题=====]

                                string titleAttr = "";

                                foreach (var attr in infTitle.Attr) {

                                    if (attr.Key != "tag-name") {
                                        titleAttr += $" {attr.Key}=\"{attr.Value}\"";
                                    }

                                }

                                string contentAttr = "";

                                foreach (var attr in infContent.Attr) {

                                    if (attr.Key != "tag-name") {
                                        contentAttr += $" {attr.Key}=\"{attr.Value}\"";
                                    }

                                }

                                //html += $"<{tagLineName}>{fieldTitle}</{tagTitleName}>";
                                html += $"<{tagTitleName}{titleAttr}>{fieldTitle}</{tagTitleName}>";

                                #endregion

                                if (tagContentName.IsNone()) {
                                    html += fieldContent;
                                } else {
                                    html += $"<{tagContentName}{contentAttr}>{fieldContent}</{tagContentName}>";
                                }

                                break;
                        }

                        //添加行结尾

                        #region [=====输出行结尾=====]
                        switch (fieldAddType) {
                            case "": case "none": break;
                            case "input":
                            case "select":
                            case "textarea":
                            case "html":
                                html += $"</{tagLineName}>";
                                break;
                            default:
                                throw new Exception($"不支持的表单字段类型：'{fieldAddType}',相关字段：'{fieldTitle}'");
                        }

                        #endregion
                    }
                }
                res = html;
            }

            return res;

        }

    }

}
