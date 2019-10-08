using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.XOrm {

    /// <summary>
    /// 表定义
    /// </summary>
    public class Table : dpz2.Object {

        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 获取或设置继承信息
        /// </summary>
        public string Inherit { get; set; }

        /// <summary>
        /// 获取或设置描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 获取字段定义集合
        /// </summary>s
        public List<TableField> Fields { get; private set; }

        /// <summary>
        /// 填充数据
        /// </summary>
        /// <param name="node"></param>
        public void FillData(dpz2.Xml.XmlNode node) {
            this.Name = node.Attr["name"];
            this.Title = node.Attr["title"];
            this.Inherit = node.Attr["inherit"];
            this.Description = node.Attr["description"];
        }

        /// <summary>
        /// 对象实例化
        /// </summary>
        /// <param name="xml"></param>
        public Table(string xml = null) {
            this.Fields = new List<TableField>();
            if (!xml.IsNoneOrNull()) {
                using (var doc = dpz2.Xml.Parser.GetDocument(xml)) {

                    // 读取数据库设置
                    var table = doc["table"];
                    this.FillData(table);

                    // 读取平台信息
                    var fields = table.GetNodesByTagName("field", false);
                    foreach (var field in fields) {

                        // 添加平台信息
                        TableField tableField = new TableField();
                        this.Fields.Add(tableField);

                        // 设置平台信息
                        tableField.FillData(field);

                    }
                }
            }
        }

        /// <summary>
        /// 从网络加载设置
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Table LoadFromUrl(string url) {
            var xml = "";
            if (url.ToLower().StartsWith("https://")) {
                xml = dpz2.Net.Https.Get(url);
            } else {
                xml = dpz2.Net.Http.GetUTF8(url);
            }
            return new Table(xml);
        }

        /// <summary>
        /// 从文件加载设置
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        public static Table LoadFromFile(string xmlPath) {
            var xml = dpz2.File.UTF8File.ReadAllText(xmlPath);
            return new Table(xml);
        }

        /// <summary>
        /// 保存到文件
        /// </summary>
        /// <param name="path"></param>
        public void SaveToFile(string path) {
            StringBuilder sb = new StringBuilder();
            sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sb.Append(this.ToString());
            dpz2.File.UTF8File.WriteAllText(path, sb.ToString());
        }

        /// <summary>
        /// 获取标准字符串表示形式
        /// </summary>
        /// <returns></returns>
        protected override string OnParseString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<table name=\"{0}\" title=\"{1}\" inherit=\"{2}\" description=\"{3}\">", this.Name, this.Title, this.Inherit, this.Description);
            for (int i = 0; i < this.Fields.Count; i++) {
                sb.Append(this.Fields[i].ToString());
            }
            sb.Append("</table>");
            return sb.ToString();
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        protected override void OnDispose() {

            this.Name = null;
            this.Title = null;

            for (int i = 0; i < this.Fields.Count; i++) {
                this.Fields[i].Dispose();
            }

            this.Fields.Clear();
            this.Fields = null;

            base.OnDispose();
        }

    }
}
