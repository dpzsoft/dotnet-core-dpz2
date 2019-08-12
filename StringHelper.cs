using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace dpz2 {

    /// <summary>
    /// 专用字符串扩展
    /// </summary>
    public static class StringHelper {

        /// <summary>
        /// 是否为空字符串
        /// </summary>
        public static bool IsNull(this string sz) {
            return sz == null;
        }

        /// <summary>
        /// 是否内容为空，同IsNoneOrNull
        /// 兼容接口，为避免混淆，请使用IsNoneOrNull进行为空判断
        /// </summary>
        public static bool IsNone(this string sz) {
            if (sz == null) return true;
            if (sz == "") return true;
            return false;
        }

        /// <summary>
        /// 是否内容为空
        /// </summary>
        public static bool IsNoneOrNull(this string sz) {
            if (sz == null) return true;
            if (sz == "") return true;
            return false;
        }

        /// <summary>
        /// 是否为一个双精度数字
        /// </summary>
        public static bool IsDouble(this string sz) {
            double val = 0;
            if (double.TryParse(sz, out val)) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获取双精度数据
        /// </summary>
        public static double ToDouble(this string sz) {
            double res = 0;
            double.TryParse(sz, out res);
            return res;
        }

        /// <summary>
        /// 是否为一个单精度数字
        /// </summary>
        public static bool IsFloat(this string sz) {
            float val = 0;
            if (float.TryParse(sz, out val)) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获取单精度数据
        /// </summary>
        public static float ToFloat(this string sz) {
            float res = 0;
            float.TryParse(sz, out res);
            return res;
        }

        /// <summary>
        /// 是否为一个整型数字
        /// </summary>
        public static bool IsInteger(this string sz) {
            int val = 0;
            if (int.TryParse(sz, out val)) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获取整型数据
        /// </summary>
        public static int ToInteger(this string sz) {
            int res = 0;
            int.TryParse(sz, out res);
            return res;
        }

        /// <summary>
        /// 是否为一个长整型数字
        /// </summary>
        public static bool IsLong(this string sz) {
            long val = 0;
            if (long.TryParse(sz, out val)) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获取长整形数据
        /// </summary>
        public static long ToLong(this string sz) {
            long res = 0;
            long.TryParse(sz, out res);
            return res;
        }

        /// <summary>
        /// 是否为一个标准的IPv4字符串
        /// </summary>
        public static bool IsIPv4(this string sz) {
            string[] parts = sz.Split('.');
            if (parts.Length != 4) return false;

            for (int i = 0; i < parts.Length; i++) {
                if (!parts[i].IsInteger()) return false;
            }

            return true;
        }

        /// <summary>
        /// 获取字符串的MD5值
        /// </summary>
        public static string GetMD5(this string sz) {
            System.Text.Encoding MyEnc = System.Text.Encoding.UTF8;
            Byte[] StrByte = MyEnc.GetBytes(sz);

            MD5CryptoServiceProvider TheMD5 = new MD5CryptoServiceProvider();
            Byte[] MD5byte = TheMD5.ComputeHash(StrByte);

            string MD5Str = "";

            for (int i = 0; i < MD5byte.Length; i++) {
                MD5Str += MD5byte[i].ToString("X").PadLeft(2, '0');
            }

            return MD5Str;
        }

        /// <summary>
        /// 获取字符串的sha1值
        /// </summary>
        public static string GetSha1(this string sz) {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] bytes_sha1_in = UTF8Encoding.Default.GetBytes(sz);
            byte[] bytes_sha1_out = sha1.ComputeHash(bytes_sha1_in);
            string str_sha1_out = BitConverter.ToString(bytes_sha1_out).Replace("-", "").ToLower();
            //str_sha1_out = str_sha1_out.Replace("-", "");
            return str_sha1_out;
        }

    }
}
