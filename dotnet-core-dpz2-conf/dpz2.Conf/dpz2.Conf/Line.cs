﻿using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Conf {

    /// <summary>
    /// 配置行
    /// </summary>
    public class Line : dpz2.Object {

        /// <summary>
        /// 获取标准字符串表示形式
        /// </summary>
        /// <returns></returns>
        protected override string OnParseString() {
            return "";
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        protected override void OnDispose() {
            base.OnDispose();
        }

    }

}
