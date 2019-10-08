using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Mvc.XOrmForVue {

    /// <summary>
    /// XOrm框架组件基类
    /// </summary>
    public abstract class Basic : dpz2.Object {

        /// <summary>
        /// 数据库定义
        /// </summary>
        public dpz2.db.Database Database { get; private set; }

        /// <summary>
        /// 初始化数据表单内容
        /// </summary>
        public dpz2.db.Row Form { get; private set; }

        /// <summary>
        /// 相关ORM表格集合
        /// </summary>
        public dpz2.db.OrmTables Tables { get; private set; }

        /// <summary>
        /// 配置信息
        /// </summary>
        public Config Config { get; private set; }

        /// <summary>
        /// 配置路径
        /// </summary>
        public string XmlPath { get; private set; }

        /// <summary>
        /// 平台名称
        /// </summary>
        public string Platform { get; private set; }

        /// <summary>
        /// 表名称
        /// </summary>
        public string Table { get; private set; }

        //下载配置文件
        private void DownloadSetting(string url, string xmlCachePath, string xmlFormPath) {
            //下载配置文件至缓存
            dpz2.Net.Http.DownFile(url, xmlCachePath);

            //将配置
            //string xmlString = dpz.IO.UTF8File.ReadAllText(xmlCachePath);
            string xmlCacheText = dpz2.File.UTF8File.ReadAllText(xmlCachePath);
            string xmlFormText = dpz2.File.UTF8File.ReadAllText(xmlFormPath);
            using (var xmlCache = dpz2.Xml.Parser.GetDocument(xmlCacheText)) {
                using (var form = dpz2.Xml.Parser.GetDocument(xmlFormText)) {
                    var xmlTable = xmlCache["table"];
                    var formTable = form["table"];

                    // 为空则新建
                    if (formTable == null) {
                        formTable = new Xml.XmlNode("table");
                        form.Nodes.Add(formTable);
                    }
                    formTable.Attr["name"] = xmlTable.Attr["name"];
                    formTable.Attr["title"] = xmlTable.Attr["title"];

                    #region [=====初始化界面定义=====]

                    var formInterfaces = formTable["interfaces"];
                    if (formInterfaces == null) formInterfaces = formTable.AddNode("interfaces");

                    //初始化添加界面
                    if (formInterfaces.GetNodeByAttr("name", "add") == null) {
                        //var formInterface = new dpz2.Xml.XmlNode("interface", formInterfaces);
                        //formInterfaces.Nodes.Add(formInterface);
                        var formInterface = formInterfaces.AddNode("interface");
                        formInterface.Attr["name"] = "add";
                        formInterface.Attr["type"] = "add";
                        formInterface.Attr["description"] = "添加";

                        //var formInterfaceLine = new dpz2.Xml.XmlNode("line", formInterface);
                        //formInterface.Nodes.Add(formInterfaceLine);
                        var formInterfaceLine = formInterface.AddNode("line");
                        formInterfaceLine.Attr["tag-name"] = "div";

                        //var formInterfaceTitle = new dpz2.Xml.XmlNode("title", formInterface);
                        //formInterface.Nodes.Add(formInterfaceTitle);
                        var formInterfaceTitle = formInterface.AddNode("title");
                        formInterfaceTitle.Attr["tag-name"] = "i";

                        //var formInterfaceInput = new dpz2.Xml.XmlNode("content", formInterface);
                        //formInterface.Nodes.Add(formInterfaceInput);
                        var formInterfaceInput = formInterface.AddNode("content");
                        formInterfaceInput.Attr["tag-name"] = "s";
                    }

                    //初始化修改界面
                    if (formInterfaces.GetNodeByAttr("name", "edit") == null) {

                        //var formInterface = new dpz2.Xml.XmlNode("interface", formInterfaces);
                        //formInterfaces.Nodes.Add(formInterface);
                        var formInterface = formInterfaces.AddNode("interface");
                        formInterface.Attr["name"] = "edit";
                        formInterface.Attr["type"] = "edit";
                        formInterface.Attr["description"] = "修改";

                        var formInterfaceLine = formInterface.AddNode("line");
                        //var formInterfaceLine = new dpz2.Xml.XmlNode("line", formInterface);
                        //formInterface.Nodes.Add(formInterfaceLine);
                        formInterfaceLine.Attr["tag-name"] = "div";

                        var formInterfaceTitle = formInterface.AddNode("title");
                        //var formInterfaceTitle = new dpz2.Xml.XmlNode("title", formInterface);
                        //formInterface.Nodes.Add(formInterfaceTitle);
                        formInterfaceTitle.Attr["tag-name"] = "i";

                        var formInterfaceInput = formInterface.AddNode("content");
                        //var formInterfaceInput = new dpz2.Xml.XmlNode("content", formInterface);
                        //formInterface.Nodes.Add(formInterfaceInput);
                        formInterfaceInput.Attr["tag-name"] = "s";
                    }

                    //初始化视图界面
                    if (formInterfaces.GetNodeByAttr("name", "view") == null) {
                        var formInterface = formInterfaces.AddNode("interface");
                        //var formInterface = new dpz2.Xml.XmlNode("interface", formInterfaces);
                        //formInterfaces.Nodes.Add(formInterface);
                        formInterface.Attr["name"] = "view";
                        formInterface.Attr["type"] = "view";
                        formInterface.Attr["description"] = "视图";

                        var formInterfaceLine = formInterface.AddNode("line");
                        //var formInterfaceLine = new dpz2.Xml.XmlNode("line", formInterface);
                        //formInterface.Nodes.Add(formInterfaceLine);
                        formInterfaceLine.Attr["tag-name"] = "div";

                        var formInterfaceTitle = formInterface.AddNode("title");
                        //var formInterfaceTitle = new dpz2.Xml.XmlNode("title", formInterface);
                        //formInterface.Nodes.Add(formInterfaceTitle);
                        formInterfaceTitle.Attr["tag-name"] = "i";

                        var formInterfaceContent = formInterface.AddNode("content");
                        //var formInterfaceContent = new dpz2.Xml.XmlNode("content", formInterface);
                        //formInterface.Nodes.Add(formInterfaceContent);
                        formInterfaceContent.Attr["tag-name"] = "s";
                    }

                    //初始化列表界面
                    if (formInterfaces.GetNodeByAttr("name", "list") == null) {
                        var formInterface = formInterfaces.AddNode("interface");
                        //var formInterface = new dpz2.Xml.XmlNode("interface", formInterfaces);
                        //formInterfaces.Nodes.Add(formInterface);
                        formInterface.Attr["name"] = "list";
                        formInterface.Attr["type"] = "list";
                        formInterface.Attr["description"] = "列表";

                        var formInterfaceVue = formInterface.AddNode("vue");
                        //var formInterfaceVue = new dpz2.Xml.XmlNode("vue", formInterface);
                        //formInterface.Nodes.Add(formInterfaceVue);
                        formInterfaceVue.Attr["for"] = "(row,index) in list";
                        formInterfaceVue.Attr["item"] = "row";
                        formInterfaceVue.Attr["key"] = "row.ID";

                        var formInterfaceVueOrder = formInterfaceVue.AddNode("order");
                        //var formInterfaceVueOrder = new dpz2.Xml.XmlNode("order", formInterfaceVue);
                        //formInterfaceVue.Nodes.Add(formInterfaceVueOrder);
                        formInterfaceVueOrder.Attr["name"] = "orderField";
                        formInterfaceVueOrder.Attr["type"] = "orderType";
                        formInterfaceVueOrder.Attr["click"] = "onOrder";

                        var formInterfaceRow = formInterface.AddNode("row");
                        //var formInterfaceRow = new dpz2.Xml.XmlNode("row", formInterface);
                        //formInterface.Nodes.Add(formInterfaceRow);
                        var formInterfaceCell = formInterface.AddNode("cell");
                        //var formInterfaceCell = new dpz2.Xml.XmlNode("cell", formInterface);
                        //formInterface.Nodes.Add(formInterfaceCell);
                    }

                    #endregion

                    #region [=====初始化字段定义=====]

                    var formFields = formTable["fields"];
                    if (formFields == null) formFields = formTable.AddNode("fields");

                    var xmlFields = xmlTable.GetNodesByTagName("field", false);
                    foreach (var xmlField in xmlFields) {
                        if (xmlField.Name.ToLower() == "field") {
                            string fieldName = xmlField.Attr["name"];
                            var formField = formFields.GetNodeByAttr("name", fieldName);
                            if (formField == null) {
                                formField = formFields.AddNode("field");
                                formField.Attr["name"] = fieldName;
                                formField.AddNode("data");
                            }

                            var formFieldAdd = formField.GetNodeByAttr("name", "add", false);
                            if (formFieldAdd == null) {
                                formFieldAdd = formField.AddNode("add");
                                formFieldAdd.Attr["type"] = "input";
                                formFieldAdd.Attr["save"] = "form";
                                formFieldAdd.Attr["model"] = "form." + fieldName;
                            }

                            var formFieldEdit = formField.GetNodeByAttr("name", "edit", false);
                            if (formFieldEdit == null) {
                                formFieldEdit = formField.AddNode("edit");
                                formFieldEdit.Attr["type"] = "input";
                                formFieldEdit.Attr["save"] = "form";
                                formFieldEdit.Attr["model"] = "form." + fieldName;
                            }

                            var formFieldView = formField.GetNodeByAttr("name", "view");
                            if (formFieldView == null) {
                                formFieldView = formField.AddNode("view");
                                formFieldView.Attr["type"] = "text";
                            }

                            var formFieldList = formField.GetNodeByAttr("name", "list");
                            if (formFieldList == null) {
                                formFieldList = formField.AddNode("list");
                                formFieldList.Attr["type"] = "text";
                                formFieldList.Attr["width"] = "100px";
                            }

                            formField.Attr["title"] = xmlField.Attr["title"];
                            var xmlFieldData = xmlField["data"];
                            var formFieldData = formField["data"];
                            formFieldData.Attr["type"] = xmlFieldData.Attr["type"];
                            formFieldData.Attr["size"] = xmlFieldData.Attr["size"];
                            formFieldData.Attr["float"] = xmlFieldData.Attr["float"];
                        }
                    }

                    #endregion

                    dpz2.File.UTF8File.WriteAllText(xmlFormPath, form.InnerXml);
                    //form.Save();
                }
            }
        }

        /// <summary>
        /// 对象实例化
        /// </summary>
        /// <param name="db"></param>
        /// <param name="form"></param>
        /// <param name="tables"></param>
        /// <param name="config"></param>
        /// <param name="plmName"></param>
        /// <param name="tabName"></param>
        public Basic(dpz2.db.Database db, dpz2.db.OrmTables tables, dpz2.db.Row form, Config config, string plmName, string tabName) {
            //controller = ctl;
            this.Database = db;
            this.Form = form;
            this.Tables = tables;
            this.Config = config;
            this.Platform = plmName;
            this.Table = tabName;
            //this.IsZeroToEmptyInTable = false;

            //下载地址
            string url = $"{config.Url}/{plmName}/{tabName}.xml";

            //配置目录设定
            string xmlCacheFolderPath = $"{config.CachePath}/{plmName}";
            string xmlFormFolderPath = $"{config.Path}/{plmName}";
            if (!System.IO.Directory.Exists(xmlCacheFolderPath)) System.IO.Directory.CreateDirectory(xmlCacheFolderPath);
            if (!System.IO.Directory.Exists(xmlFormFolderPath)) System.IO.Directory.CreateDirectory(xmlFormFolderPath);

            //配置路径设定
            string xmlCachePath = $"{xmlCacheFolderPath}/{tabName}.xml";
            string xmlFormPath = $"{xmlFormFolderPath}/{tabName}.xml";

            //配置文件初始化
            if (!System.IO.File.Exists(xmlCachePath)) {
                DownloadSetting(url, xmlCachePath, xmlFormPath);
            }

            this.XmlPath = xmlFormPath;

        }

    }
}
