using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace dpz2.File {

    /// <summary>
    /// 以UTF8编码操作文件
    /// </summary>
    public class UTF8File : TextFile {

        private long position = 0;

        /// <summary>
        /// 对象实例化
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        public UTF8File(string path, System.IO.FileMode mode = FileMode.Open) : base(path, Encoding.UTF8, mode) { }

        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="create"></param>
        /// <returns></returns>
        public static string ReadAllText(string Path, bool create) {
            byte[] res = BinaryFile.ReadAllBytes(Path, create);
            if (res.Length >= 3) {
                if (res[0] == 0xEF && res[1] == 0xBB && res[2] == 0xBF) {
                    return System.Text.Encoding.UTF8.GetString(res, 3, res.Length - 3);
                }
            }
            return System.Text.Encoding.UTF8.GetString(res);
        }

        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public static string ReadAllText(string Path) {
            return ReadAllText(Path, false);
        }

        /// <summary>
        /// 将内容写入文件
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="cnt"></param>
        public static void WriteAllText(string Path, string cnt) {
            byte[] res = System.Text.Encoding.UTF8.GetBytes(cnt);
            BinaryFile.WriteAlBytes(Path, res);
        }

        /// <summary>
        /// 将内容追加写入文件
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="cnt"></param>
        public static void AppendText(string Path, string cnt) {
            string szOld = ReadAllText(Path);
            byte[] res = System.Text.Encoding.UTF8.GetBytes(szOld + cnt);
            BinaryFile.WriteAlBytes(Path, res);
        }

        /// <summary>
        /// 将内容追加写入文件并换行
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="cnt"></param>
        public static void AppendTextLine(string Path, string cnt) {
            AppendText(Path, cnt + "\r\n");
        }

    }
}
