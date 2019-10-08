using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.XOrm {

    /// <summary>
    /// 表设置项
    /// </summary>
    public class SettingTable : dpz2.Object {

        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 获取或设置版本
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 获取或设置MD5值
        /// </summary>
        public string MD5 { get; set; }

        /// <summary>
        /// 获取或设置存储路径
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 填充数据
        /// </summary>
        /// <param name="node"></param>
        public void FillData(dpz2.Xml.XmlNode node) {
            this.Name = node.Attr["name"];
            this.Title = node.Attr["title"];
            this.Version = node.Attr["version"];
            this.Path = node.Attr["path"];
            this.MD5 = node.Attr["md5"];
        }

        /// <summary>
        /// 获取标准字符串表示形式
        /// </summary>
        /// <returns></returns>
        protected override string OnParseString() {
            return String.Format("<table name=\"{0}\" title=\"{1}\" version=\"{2}\" md5=\"{3}\" path=\"{4}\"/>", this.Name, this.Title, this.Version, this.MD5, this.Path);
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        protected override void OnDispose() {

            this.Name = null;
            this.Version = null;
            this.MD5 = null;
            this.Path = null;

            base.OnDispose();
        }

    }
}
