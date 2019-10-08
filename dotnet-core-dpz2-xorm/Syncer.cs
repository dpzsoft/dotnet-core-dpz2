using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.XOrm {

    /// <summary>
    /// 配置同步器
    /// </summary>
    public class Syncer : dpz2.Object {

        // 同步参数
        private string remoteUrl;
        private string localPath;

        /// <summary>
        /// 实例化一个新的配置同步器
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path"></param>
        public Syncer(string url, string path) {
            remoteUrl = url;
            localPath = path;
        }

        /// <summary>
        /// 同步设置文件
        /// </summary>
        public void SyncSetting() {
            string remoteVersion = Setting.GetVersionCacheFromUrl($"{remoteUrl}/Version.xml");
            string localVersion = Setting.GetVersionCacheFromFile($"{localPath}/Version.xml");
            if (localVersion != remoteVersion) {
                using (var doc = Setting.LoadFromUrl($"{remoteUrl}/Setting.xml")) {
                    doc.SaveToFile($"{localPath}/Setting.xml");
                    doc.SaveVersionCacheToFile($"{localPath}/Version.xml");
                }
            }
        }

        /// <summary>
        /// 同步表文件
        /// </summary>
        public void SyncTable(string platform, string table) {
            using (var setting = Setting.LoadFromFile($"{localPath}/Setting.xml")) {
                foreach (var plm in setting.Platforms) {
                    if (plm.Name == platform) {
                        // 创建目录
                        if (!System.IO.Directory.Exists(localPath + "/" + plm.Name)) System.IO.Directory.CreateDirectory(localPath + "/" + plm.Name);
                        foreach (var tab in plm.Tables) {
                            if (tab.Name == table) {
                                // 校对MD5值
                                string md5 = "";
                                if (System.IO.File.Exists($"{localPath}{tab.Path}")) md5 = dpz2.File.BinaryFile.GetMD5($"{localPath}{tab.Path}");
                                if (tab.MD5 != md5) {
                                    using (var tabDoc = Table.LoadFromUrl($"{remoteUrl}{tab.Path}")) {
                                        tabDoc.SaveToFile($"{localPath}{tab.Path}");
                                    }
                                }
                                return;
                            }
                        }
                    }
                }
            }
            throw new Exception("未找到配置信息");
        }

    }
}
