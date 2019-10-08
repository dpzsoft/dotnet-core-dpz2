using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Mvc.XOrmForVue {

    /// <summary>
    /// 配置文件
    /// </summary>
    public class Config : dpz2.Object {

        /// <summary>
        /// XML定义地址
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// XML缓存目录
        /// </summary>
        public string CachePath { get; private set; }

        /// <summary>
        /// XML配置目录
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        /// 实例化一个配置文件
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path"></param>
        /// <param name="cachePath"></param>
        public Config(string url, string path, string cachePath) {
            this.Url = url;
            this.Path = path;
            this.CachePath = cachePath;
        }

        /// <summary>
        /// 从配置文件加载
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Config LoadFormConf(string path) {
            // 当文件不存在时，执行初始化创建
            if (!System.IO.File.Exists(path)) {
                using (dpz2.Conf.File file = new Conf.File(path)) {

                    // 建立配置组
                    var group = file["XOrm"];
                    group["Url"] = "http://127.0.0.1/Orm";
                    group["Path"] = "/XOrm/Working";
                    group["CachePath"] = "/XOrm/Cache";

                    //文件保存
                    file.Save();
                }
            }

            Config config;
            using (dpz2.Conf.File file = new Conf.File(path)) {
                var group = file["XOrm"];
                config = new Config(group["Url"], group["Path"], group["CachePath"]);
            }

            return config;
        }

    }
}
