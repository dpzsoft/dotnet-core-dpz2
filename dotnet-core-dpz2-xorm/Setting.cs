using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.XOrm {

    /// <summary>
    /// 设置类型
    /// </summary>
    public class Setting : dpz2.Object {

        /// <summary>
        /// 获取或设置版本
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 获取平台定义集合
        /// </summary>
        public List<SettingPlatform> Platforms { get; private set; }

        /// <summary>
        /// 填充数据
        /// </summary>
        /// <param name="node"></param>
        public void FillData(dpz2.Xml.XmlNode node) {
            this.Version = node.Attr["version"];
        }

        /// <summary>
        /// 对象实例化
        /// </summary>
        /// <param name="xml"></param>
        public Setting(string xml = null) {
            this.Platforms = new List<SettingPlatform>();
            if (!xml.IsNoneOrNull()) {
                using (var doc = dpz2.Xml.Parser.GetDocument(xml)) {

                    // 读取数据库设置
                    var database = doc["database"];
                    this.FillData(database);

                    // 读取平台信息
                    var platforms = database.GetNodesByTagName("platform", false);
                    foreach (var platform in platforms) {

                        // 添加平台信息
                        SettingPlatform settingPlatform = new SettingPlatform();
                        this.Platforms.Add(settingPlatform);

                        // 设置平台信息
                        settingPlatform.FillData(platform);

                        // 读取平台中的表定义
                        var tables = platform.GetNodesByTagName("table", false);
                        foreach (var table in tables) {

                            // 添加表信息
                            SettingTable settingTable = new SettingTable();
                            settingPlatform.Tables.Add(settingTable);

                            // 设置表信息
                            settingTable.FillData(table);

                        }
                    }
                }
            }
        }

        /// <summary>
        /// 从网络加载设置
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Setting LoadFromUrl(string url) {
            var xml = "";
            if (url.ToLower().StartsWith("https://")) {
                xml = dpz2.Net.Https.Get(url);
            } else {
                xml = dpz2.Net.Http.GetUTF8(url);
            }
            return new Setting(xml);
        }

        /// <summary>
        /// 从文件加载设置
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        public static Setting LoadFromFile(string xmlPath) {
            var xml = dpz2.File.UTF8File.ReadAllText(xmlPath);
            return new Setting(xml);
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
        /// 从文件加载版本缓存
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        public static string GetVersionCacheFromUrl(string url) {
            string res = "";
            var xml = "";
            if (url.ToLower().StartsWith("https://")) {
                xml = dpz2.Net.Https.Get(url);
            } else {
                xml = dpz2.Net.Http.GetUTF8(url);
            }
            if (!xml.IsNoneOrNull()) {
                using (var doc = dpz2.Xml.Parser.GetDocument(xml)) {

                    // 读取数据库设置
                    var database = doc["database"];
                    res = database.Attr["version"];

                }
            }
            return res;
        }

        /// <summary>
        /// 从文件加载版本缓存
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        public static string GetVersionCacheFromFile(string xmlPath) {
            string res = "";
            var xml = dpz2.File.UTF8File.ReadAllText(xmlPath);
            if (!xml.IsNoneOrNull()) {
                using (var doc = dpz2.Xml.Parser.GetDocument(xml)) {

                    // 读取数据库设置
                    var database = doc["database"];
                    res = database.Attr["version"];

                }
            }
            return res;
        }

        /// <summary>
        /// 保存到文件
        /// </summary>
        /// <param name="path"></param>
        public void SaveVersionCacheToFile(string path) {
            StringBuilder sb = new StringBuilder();
            sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sb.AppendFormat("<database version=\"{0}\"/>", this.Version);
            dpz2.File.UTF8File.WriteAllText(path, sb.ToString());
        }

        /// <summary>
        /// 获取标准字符串表示形式
        /// </summary>
        /// <returns></returns>
        protected override string OnParseString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<database version=\"{0}\">", this.Version);
            for (int i = 0; i < this.Platforms.Count; i++) {
                sb.Append(this.Platforms[i].ToString());
            }
            sb.Append("</database>");
            return sb.ToString();
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        protected override void OnDispose() {

            this.Version = null;

            for (int i = 0; i < this.Platforms.Count; i++) {
                this.Platforms[i].Dispose();
            }

            this.Platforms.Clear();
            this.Platforms = null;

            base.OnDispose();
        }

    }
}
