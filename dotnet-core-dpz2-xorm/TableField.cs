using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.XOrm {
    /// <summary>
    /// 表字段定义
    /// </summary>
    public class TableField : dpz2.Object {

        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 获取或设置数据类型
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// 获取或设置数据尺寸
        /// </summary>
        public int DataSize { get; set; }

        /// <summary>
        /// 获取或设置数据精度
        /// </summary>
        public int DataFloat { get; set; }

        public TableField() {
            this.DataSize = 0;
            this.DataFloat = 0;
        }

        /// <summary>
        /// 填充数据
        /// </summary>
        /// <param name="node"></param>
        public void FillData(dpz2.Xml.XmlNode node) {
            this.Name = node.Attr["name"];
            this.Title = node.Attr["title"];
            // 获取字段定义
            var fieldData = node["data"];
            this.DataType = fieldData.Attr["type"];
            this.DataSize = fieldData.Attr["size"].ToInteger();
            this.DataFloat = fieldData.Attr["float"].ToInteger();
        }

        /// <summary>
        /// 复制一个相同的自己
        /// </summary>
        /// <returns></returns>
        public TableField Copy() {
            return new TableField() {
                Name = this.Name,
                Title = this.Title,
                DataType = this.DataType,
                DataSize = this.DataSize,
                DataFloat = this.DataFloat
            };
        }

        /// <summary>
        /// 获取标准字符串表示形式
        /// </summary>
        /// <returns></returns>
        protected override string OnParseString() {
            return String.Format("<field name=\"{0}\" title=\"{1}\"><data type=\"{2}\" size=\"{3}\" float=\"{4}\"/></field>", this.Name, this.Title, this.DataType, this.DataSize, this.DataFloat);
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        protected override void OnDispose() {

            this.Name = null;
            this.Title = null;
            this.DataType = null;

            base.OnDispose();
        }

    }
}
