using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Xml {

    /// <summary>
    /// 文档对象
    /// </summary>
    public class XmlDocument : dpz2.Object {

        /// <summary>
        /// 获取子节点集合
        /// </summary>
        public List<BasicNode> Nodes { get; private set; }

        /// <summary>
        /// 对象实例化
        /// </summary>
        /// <param name="xml"></param>
        public XmlDocument(string xml = null) {
            if (!xml.IsNone()) {
                this.Nodes = Parser.GetNodes(xml);
            } else {
                this.Nodes = new List<BasicNode>();
            }
        }

        /// <summary>
        /// 获取一个子节点
        /// </summary>
        /// <param name="tagname"></param>
        /// <returns></returns>
        public XmlNode this[string tagName] {
            get {
                tagName = tagName.ToLower();
                for (int i = 0; i < this.Nodes.Count; i++) {
                    if (this.Nodes[i].NodeType == NodeType.Normal) {
                        var node = (XmlNode)this.Nodes[i];
                        if (node.Name.ToLower() == tagName) {
                            return node;
                        }
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// 获取所有标签名节点
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="searchChildNodes"></param>
        /// <returns></returns>
        public List<XmlNode> GetNodesByTagName(string tagName, bool searchChildNodes = true) {
            List<XmlNode> nodes = new List<XmlNode>();
            for (int i = 0; i < this.Nodes.Count; i++) {
                if (this.Nodes[i].NodeType == NodeType.Normal) {
                    var node = (XmlNode)this.Nodes[i];
                    if (node.Name.ToLower() == tagName) {
                        nodes.Add(node);
                    }

                    // 深度查询
                    if (searchChildNodes) {
                        if (node.Nodes.Count > 0) {
                            // 获取子节点的查询结果并应用到结果中
                            var childNodes = node.GetNodesByTagName(tagName);
                            for (int j = 0; j < childNodes.Count; j++) {
                                nodes.Add(childNodes[j]);
                            }
                        }
                    }
                }
            }
            return nodes;
        }

        /// <summary>
        /// 获取所有满足属性限定的节点
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="searchChildNodes"></param>
        /// <returns></returns>
        public List<XmlNode> GetNodesByAttr(string attrName, string attrValue, bool searchChildNodes = true) {
            List<XmlNode> nodes = new List<XmlNode>();
            for (int i = 0; i < this.Nodes.Count; i++) {
                if (this.Nodes[i].NodeType == NodeType.Normal) {
                    var node = (XmlNode)this.Nodes[i];
                    if (node.Attr[attrName] == attrValue) {
                        nodes.Add(node);
                    }

                    // 深度查询
                    if (searchChildNodes) {
                        if (node.Nodes.Count > 0) {
                            // 获取子节点的查询结果并应用到结果中
                            var childNodes = node.GetNodesByAttr(attrName, attrValue);
                            for (int j = 0; j < childNodes.Count; j++) {
                                nodes.Add(childNodes[j]);
                            }
                        }
                    }
                }
            }
            return nodes;
        }

        /// <summary>
        /// 获取第一个满足属性限定的节点
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="searchChildNodes"></param>
        /// <returns></returns>
        public XmlNode GetNodeByAttr(string attrName, string attrValue) {
            List<XmlNode> nodes = new List<XmlNode>();
            for (int i = 0; i < this.Nodes.Count; i++) {
                if (this.Nodes[i].NodeType == NodeType.Normal) {
                    var node = (XmlNode)this.Nodes[i];
                    if (node.Attr[attrName] == attrValue) {
                        return node;
                    }

                    if (node.Nodes.Count > 0) {
                        // 获取子节点的查询结果并应用到结果中
                        var childNode = node.GetNodeByAttr(attrName, attrValue);
                        if (childNode != null) return childNode;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 获取包含的XML字符串
        /// </summary>
        public string InnerXml {
            get {
                StringBuilder res = new StringBuilder();
                for (int i = 0; i < this.Nodes.Count; i++) {
                    res.Append(this.Nodes[i].OuterXml);
                }
                return res.ToString();
            }
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        protected override void OnDispose() {
            base.OnDispose();

            for (int i = 0; i < this.Nodes.Count; i++) {
                this.Nodes[i].Dispose();
            }

            this.Nodes.Clear();

        }
    }
}
