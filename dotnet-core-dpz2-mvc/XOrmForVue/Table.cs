using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Mvc.XOrmForVue {

    /// <summary>
    /// 表格
    /// </summary>
    public class Table : HtmlBuilder {

        /// <summary>
        /// 对象实例化
        /// </summary>
        /// <param name="db"></param>
        /// <param name="form"></param>
        /// <param name="tables"></param>
        /// <param name="config"></param>
        /// <param name="plmName"></param>
        /// <param name="tabName"></param>
        public Table(dpz2.db.Database db, dpz2.db.OrmTables tables, dpz2.db.Row form, Config config, string plmName, string tabName) : base(db, tables, form, config, plmName, tabName) {
        }

        /// <summary>
        /// 获取列表表格HTML代码
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public string GetHtml(string tagName) {

            string res;

            //存储所有的列信息
            string th = "";
            string td = "";
            bool hasTotal = false;
            Dictionary<string, double> totals = new Dictionary<string, double>();

            //读取配置文件内容
            string xmlText = dpz2.File.UTF8File.ReadAllText(base.XmlPath);
            using (var xml = dpz2.Xml.Parser.GetDocument(xmlText)) {
                var table = xml["table"];

                var inf = table["interfaces"].GetNodeByAttr("name", tagName);
                if (inf == null) throw new Exception($"未找到界面\"{tagName}\"定义，请检查配置文件");
                if (inf.Attr["type"] != "list") throw new Exception($"界面\"{tagName}\"非列表类型，请检查配置文件");

                // 行设置
                var rowConfig = inf["row"];
                if (rowConfig == null) rowConfig = inf.AddNode("row");

                // 单元格设置
                var cellConfig = inf["cell"];
                if (cellConfig == null) cellConfig = inf.AddNode("cell");

                // vue设置
                var vueConfig = inf["vue"];
                if (vueConfig == null) vueConfig = inf.AddNode("vue");
                var vueOrderConfig = vueConfig["order"];
                if (vueOrderConfig == null) vueOrderConfig = vueConfig.AddNode("order");

                var fields = table["fields"].GetNodesByTagName("field", false);
                foreach (var field in fields) {
                    if (field.Name.ToLower() == "field") {
                        string fieldName = field.Attr["name"];
                        string fieldTitle = field.Attr["title"];

                        var fieldList = field[tagName];
                        string fieldListType = fieldList.Attr["type"].ToLower();

                        // 统计设定 可选
                        string fieldListTotal = "";// fieldList.Attr["total"].ToLower();
                        if (fieldList.Attr.ContainsKey("total")) fieldListTotal = fieldList.Attr["total"].ToLower();

                        // 排序设定 可选
                        string fieldListOrder = ""; //fieldList.Attr["order"].ToLower();
                        if (fieldList.Attr.ContainsKey("order")) fieldListOrder = fieldList.Attr["order"].ToLower();

                        //类型处理
                        switch (fieldListType) {
                            case "define":
                            case "text":
                            case "html":
                                th += $"<th style='width:{fieldList.Attr["width"]};min-width:{fieldList.Attr["width"]};max-width:{fieldList.Attr["width"]};'>" +
                                    $"{fieldTitle}";
                                if (fieldListOrder == "yes" || fieldListOrder == "true") {
                                    th += $"<div style=\"display:inline-block;width:16px;height:16px;overflow:hidden;vertical-align:middle;cursor:pointer;\" v-on:click=\"{vueOrderConfig.Attr["click"]}('{fieldName}')\">";
                                    th += $"<template v-if=\"{vueOrderConfig.Attr["name"]} === '{fieldName}' && {vueOrderConfig.Attr["type"]} === 'asc'\">";
                                    th += $"<div style=\"width:0px;border:5px solid #000;border-color: transparent transparent #34495e;margin: -3px 0px 0px 2px;\"></div>";
                                    th += $"</template>";
                                    th += $"<template v-else>";
                                    th += $"<div style=\"width:0px;border:5px solid #000;border-color: transparent transparent #ccc;margin: -3px 0px 0px 2px;\"></div>";
                                    th += $"</template>";
                                    th += $"<template v-if=\"{vueOrderConfig.Attr["name"]} === '{fieldName}' && {vueOrderConfig.Attr["type"]} === 'desc'\">";
                                    th += $"<div style=\"width:0px;border:5px solid #000;border-color: #34495e transparent transparent;margin: 1px 0px 0px 2px;\"></div>";
                                    th += $"</template>";
                                    th += $"<template v-else>";
                                    th += $"<div style=\"width:0px;border:5px solid #000;border-color: #ccc transparent transparent;margin: 1px 0px 0px 2px;\"></div>";
                                    th += $"</template>";
                                    th += $"</div>";
                                }
                                th += $"</th>";
                                break;
                            case "none": case "": break;
                            default:
                                throw new Exception($"未知列表类型:\"{fieldListType}\"");
                        }

                        //是否为累计项目
                        if (fieldListTotal == "sum") {
                            hasTotal = true;
                            totals.Add(fieldName, 0);
                        }

                    }
                }

                //foreach (var row in list) {
                //string trId = $"row_{row["ID"]}";

                //处理tr属性
                Dictionary<string, string> rowAttr = new Dictionary<string, string>();
                //rowAttr.Add("id", trId);
                //导入row字段定义
                foreach (var attr in rowConfig.Attr) {
                    rowAttr.Add(attr.Key, attr.Value);
                }

                string vueFor = vueConfig.Attr["for"];
                string vueItem = vueConfig.Attr["item"];
                string vueKey = vueConfig.Attr["key"];

                if (rowAttr.ContainsKey("v-for")) {
                    rowAttr["v-for"] = vueFor;
                } else {
                    rowAttr.Add("v-for", vueFor);
                }

                if (rowAttr.ContainsKey("v-bind:key")) {
                    rowAttr["v-bind:key"] = vueKey;
                } else {
                    rowAttr.Add("v-bind:key", vueKey);
                }
                //rowAttr.Add("v-bind:key", vueKey);

                string trAttr = "";
                foreach (var attr in rowAttr) {
                    trAttr += $" {attr.Key}=\"{attr.Value.Replace("\"", "\\\"")}\"";
                }

                td += $"<tr{trAttr}>";
                foreach (var field in fields) {
                    if (field.Name.ToLower() == "field") {

                        string fieldName = field.Attr["name"];
                        string fieldTitle = field.Attr["title"];
                        //string tdId = $"row_{row["ID"]}_cell_{fieldName}";

                        //处理td属性
                        Dictionary<string, string> cellAttr = new Dictionary<string, string>();

                        //导入row字段定义
                        foreach (var attr in cellConfig.Attr) {
                            rowAttr.Add(attr.Key, attr.Value);
                        }

                        var fieldList = field[tagName];
                        string fieldListAlign = fieldList.Attr["align"];
                        //string fieldListAlignStyle = fieldListAlign != "" ? $"text-align:{fieldListAlign};" : "";
                        //string style = $"{fieldListAlignStyle}";
                        if (fieldListAlign != "") {
                            if (cellAttr.ContainsKey("style")) {
                                cellAttr["style"] += $"text-align:{fieldListAlign};";
                            } else {
                                cellAttr.Add("style", $"text-align:{fieldListAlign};");
                            }
                        }

                        string fieldValue = vueItem + "." + fieldName;//row[fieldName];
                        //var fieldData = field["data"];
                        //string fieldDataType = fieldData.Attr["type"];

                        //生成td属性
                        string tdAttr = "";
                        foreach (var attr in cellAttr) {
                            tdAttr += $" {attr.Key}=\"{attr.Value.Replace("\"", "\\\"")}\"";
                        }

                        string fieldListType = fieldList.Attr["type"].ToLower();
                        switch (fieldListType) {
                            case "define":
                                var fieldListDefines = fieldList.GetNodesByTagName("define", false);
                                foreach (var fieldListDefine in fieldListDefines) {
                                    string fieldListDefineValue = fieldListDefine.Attr["value"];
                                    if (fieldValue == fieldListDefineValue) {
                                        fieldValue = fieldListDefine.Attr["text"];
                                        break;
                                    }
                                }
                                td += $"<td{tdAttr}>{fieldValue}</td>";
                                break;
                            case "text":
                                td += $"<td{tdAttr}>{{{{{fieldValue}}}}}</td>";
                                break;
                            case "html":

                                var tableFolder = base.XmlPath.Substring(0, base.XmlPath.Length - 4);
                                if (!System.IO.Directory.Exists(tableFolder)) System.IO.Directory.CreateDirectory(tableFolder);
                                var htmlPath = tableFolder + "/" + fieldName + "." + tagName + ".html";
                                var fieldHtmlContent = dpz2.File.UTF8File.ReadAllText(htmlPath, true);
                                //var fieldHtml = fieldList["html"];
                                //var fieldHtmlContent = fieldHtml.InnerXml;

                                ////进行内容填充
                                //if (row != null) {
                                //    fieldHtmlContent = fieldHtmlContent.Replace("{{", "{{}");
                                //    fieldHtmlContent = fieldHtmlContent.Replace("}}", "{}}");
                                //    foreach (var item in row) {
                                //        fieldHtmlContent = fieldHtmlContent.Replace("{" + item.Key + "}", item.Value);
                                //    }
                                //    fieldHtmlContent = fieldHtmlContent.Replace("{{}", "{");
                                //    fieldHtmlContent = fieldHtmlContent.Replace("{}}", "}");
                                //}

                                td += $"<td{tdAttr}>{fieldHtmlContent}</td>";
                                break;
                            case "none": case "": break;
                            default: throw new Exception($"不支持的类型\"{fieldListType}\"");
                        }

                        //项目累计
                        // 统计设定 可选
                        string fieldListTotal = "";// fieldList.Attr["total"].ToLower();
                        if (fieldList.Attr.ContainsKey("total")) fieldListTotal = fieldList.Attr["total"].ToLower();
                        //string fieldListTotal = fieldList.Attr["total"].ToLower();
                        if (fieldListTotal == "sum") {
                            double fieldTotal = totals[fieldName];
                            fieldTotal += fieldValue.ToDouble();
                            totals[fieldName] = fieldTotal;
                        }

                    }
                }
                td += "</tr>";
                //}

                if (hasTotal) {

                    td += $"<tr>";
                    foreach (var field in fields) {
                        if (field.Name.ToLower() == "field") {
                            string fieldName = field.Attr["name"];
                            string fieldTitle = field.Attr["title"];
                            //string tdId = $"cell_{row["ID"]}_{fieldName}";

                            var fieldList = field["list"];
                            string fieldListAlign = fieldList.Attr["align"];
                            string fieldListAlignStyle = fieldListAlign != "" ? $"text-align:{fieldListAlign}" : "";
                            string style = $"{fieldListAlignStyle}";

                            string fieldListType = fieldList.Attr["type"].ToLower();
                            switch (fieldListType) {
                                case "define":
                                case "text":
                                case "html":
                                    //项目累计
                                    string fieldListTotal = fieldList.Attr["total"].ToLower();
                                    if (fieldListTotal == "sum") {
                                        double fieldTotal = totals[fieldName];
                                        td += $"<td style='{style}'>{fieldTotal}</td>";
                                    } else if (fieldListTotal == "name") {
                                        td += $"<td style='{style}'>合计</td>";
                                    } else {
                                        td += $"<td style='{style}'>&nbsp;</td>";
                                    }
                                    break;
                                case "none": case "": break;
                                default: throw new Exception($"不支持的类型\"{fieldListType}\"");
                            }


                        }
                    }
                    td += "</tr>";
                }
            }

            if (th == "") throw new Exception("未发现可显示字段，请检查配置文件");

            res = $"<table><tr>{th}</tr>{td}</table>";

            return res;

        }

        /// <summary>
        /// 获取列表表格HTML代码
        /// </summary>
        /// <returns></returns>
        public string GetHtml() {
            return GetHtml("list");
        }

    }

}
