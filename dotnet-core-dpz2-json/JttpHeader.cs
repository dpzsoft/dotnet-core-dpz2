using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Json {

    /// <summary>
    /// Jttp协议专用头部
    /// </summary>
    public class JttpHeader {

        /// <summary>
        /// 获取或设置协议版本
        /// </summary>
        public string Ver { get; set; } = "";

        /// <summary>
        /// 获取或设置协议类型
        /// </summary>
        public string Type { get; set; } = "";

        /// <summary>
        /// 获取或设置交互识标
        /// </summary>
        public string SessionID { get; set; } = "";

        /// <summary>
        /// 获取或设置时间戳
        /// </summary>
        public string Time { get; set; } = "";

        /// <summary>
        /// 获取或设置通讯状态
        /// </summary>
        public string Status { get; set; } = "";

        /// <summary>
        /// 获取或设置错误代码
        /// </summary>
        public string Error { get; set; } = "";

    }
}
