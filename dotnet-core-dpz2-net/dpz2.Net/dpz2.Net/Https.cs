using dpz2.Net.HttpModules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace dpz2.Net {

    /// <summary>
    /// 超文本传输协议处理类
    /// </summary>
    public class Https {

        /// <summary>
        /// 获取网页HTML内容
        /// </summary>
        /// <param name="url">URL地址</param>
        /// <returns></returns>
        public static string Get(string url) {
            string respHTML = "";

            try {
                //var url = @"https://xxx.xxx.xxx.xxx:xxxx/xxx-web/services/xxxx?wsdl";

                var handler = new HttpClientHandler {
                    //ServerCertificateCustomValidationCallback = (message, certificate2, arg3, arg4) => true,
                    //ClientCertificateOptions = ClientCertificateOption.Manual,
                    //ClientCertificates ={
                    //    new X509Certificate2(@"E:\cert\rootTrust.cer","11111111"),
                    //    new X509Certificate2(@"E:\cert\middleTrust.cer","11111111"),
                    //    new X509Certificate2(@"E:\cert\wskey.pfx","ws654321")
                    //}
                    AllowAutoRedirect = true,
                    UseProxy = false,
                    Proxy = null,
                    //UseCookies = true,
                    //CookieContainer = cookies,
                    ClientCertificateOptions = ClientCertificateOption.Automatic
                };

                var webRequest = new System.Net.Http.HttpClient(handler);
                respHTML = webRequest.GetStringAsync(url).GetAwaiter().GetResult();
                //Console.WriteLine("xx");


            } catch (Exception ex) {
                throw new Exception("获取HTML发生异常:" + ex.Message);
                //System.Windows.Forms.MessageBox.Show("获取信息发生异常:\r\n" + ex.Message + "\r\n" + Url);
                //Debug.WriteLine("Debug\\>GetHTML::Error(" + ex + ")");
            }

            return respHTML;
        }

        /// <summary>
        /// 使用原生Socket组件以GET方式获取HTTPS内容并以Utf8编码组织内容
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string GetUtf8BySocket(string url) {
            string res = "";
            using (SocketHttps https = new SocketHttps(url)) {
                int status = https.Get();
                switch (status) {
                    case 200:
                        res = https.Response.GetUtf8Content();
                        break;
                    default:
                        throw new Exception($"Request Status Code {status}");
                }
            }
            return res;
        }


    }
}
