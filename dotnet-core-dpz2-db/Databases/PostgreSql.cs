﻿using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.db.Databases {

    /// <summary>
    /// 一款轻型的数据库，是遵守ACID的关系型数据库管理系统
    /// </summary>
    public class PostgreSql : dpz2.db.Database {

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 对象实例化
        /// </summary>
        public PostgreSql() {
            base.Type = dpz2.db.DatabaseTypes.PostgreSQL;
        }

        /// <summary>
        /// 获取字符串表现形式
        /// </summary>
        /// <returns></returns>
        protected override string OnParseString() {
            //return "server=" + this.Address + ";user id=" + this.User + ";password=" + this.Password + ";database=" + this.Name + ";port=" + this.Port + ";pooling=false;Connect Timeout=600;";
            return $"Host={this.Address};Port={this.Port};Username={this.User};Password={this.Password};Database={this.Name};";
        }

    }
}
