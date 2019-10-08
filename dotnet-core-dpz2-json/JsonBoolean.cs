﻿using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Json {

    /// <summary>
    /// 布尔单元类型
    /// </summary>
    public class JsonBoolean : JsonUnit {

        /// <summary>
        /// 获取或设置值
        /// </summary>
        public bool Value { get; set; }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public JsonBoolean(JsonUnit parent) : base(UnitType.Number, parent) {
            this.Value = false;
        }

        /// <summary>
        /// 获取数值
        /// </summary>
        /// <returns></returns>
        protected override bool OnGetBoolean() {
            return this.Value;
        }

        /// <summary>
        /// 获取字符串
        /// </summary>
        /// <returns></returns>
        protected override string OnGetString() {
            return "" + this.Value;
        }

        /// <summary>
        /// 设置数值
        /// </summary>
        /// <param name="value"></param>
        protected override void OnSetBoolean(bool value) {
            this.Value = value;
        }

        /// <summary>
        /// 获取Json字符串
        /// </summary>
        /// <returns></returns>
        protected override string OnGetJsonString() {
            return this.Value ? "true" : "false";
        }

    }
}
