using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace dpz2.Net {

    /// <summary>
    /// 超文本协议持续传输器
    /// </summary>
    public class HttpClient : dpz2.Object {

        dpz2.Net.HttpModules.HttpCookies _cookies;

        /// <summary>
        /// 对象实例化
        /// </summary>
        public HttpClient() {
            _cookies = new dpz2.Net.HttpModules.HttpCookies();
        }

        //设置Cookie
        private void SetCookies(string str) {
            using (dpz2.Net.HttpModules.HttpCookies cookies = new dpz2.Net.HttpModules.HttpCookies(str)) {
                foreach (var cookie in cookies) {
                    if (cookie.Key != "expires" && cookie.Key != "path") {
                        _cookies[cookie.Key] = cookie.Value;
                    }
                }
            }
        }

        /// <summary>
        /// 提交数据并获取返回内容
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="Args"></param>
        /// <param name="enc"></param>
        /// <returns></returns>
        public string Post(string Url, string Args, Encoding enc) {
            string respHTML = "";

            //try {
            System.Net.HttpWebRequest httpReq;
            System.Net.HttpWebResponse httpResp;
            System.Uri httpURL = new System.Uri(Url);

            httpReq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(httpURL);
            httpReq.Method = "POST";

            httpReq.Headers.Add("Cookie", _cookies.ToString());

            byte[] bs = enc.GetBytes(Args);

            httpReq.KeepAlive = false;
            httpReq.ContentType = "application/x-www-form-urlencoded";
            httpReq.ContentLength = bs.Length;
            httpReq.Timeout = 30000;
            //httpReq.

            //post数据
            using (System.IO.Stream reqStream = httpReq.GetRequestStream()) {
                reqStream.Write(bs, 0, bs.Length);
                reqStream.Close();
            }

            httpResp = (System.Net.HttpWebResponse)httpReq.GetResponse();
            SetCookies("" + httpResp.Headers["Set-Cookie"]);

            using (System.IO.Stream MyStream = httpResp.GetResponseStream()) {
                System.IO.StreamReader reader = new System.IO.StreamReader(MyStream, Encoding.UTF8);

                respHTML = reader.ReadToEnd();

                reader.Dispose();
                MyStream.Dispose();
            }

            httpResp.Close();
            httpReq = null;

            return respHTML;
        }

        /// <summary>
        /// 获取网页HTML内容
        /// </summary>
        /// <param name="Url">URL地址</param>
        /// <param name="Enc">字符编码</param>
        /// <returns></returns>
        public string Get(string Url, Encoding Enc) {
            string respHTML = "";

            System.Net.HttpWebRequest httpReq;
            System.Net.HttpWebResponse httpResp;
            System.Uri httpURL = new System.Uri(Url);

            httpReq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(httpURL);
            httpReq.Method = "GET";
            httpReq.KeepAlive = false;
            httpReq.ContentType = "text/html";
            httpReq.Timeout = 30000;
            httpReq.Headers.Add("Cookie", _cookies.ToString());

            httpResp = (System.Net.HttpWebResponse)httpReq.GetResponse();
            SetCookies("" + httpResp.Headers["Set-Cookie"]);

            using (System.IO.Stream MyStream = httpResp.GetResponseStream()) {
                System.IO.StreamReader reader = new System.IO.StreamReader(MyStream, Encoding.UTF8);
                respHTML = reader.ReadToEnd();

                reader.Dispose();
                MyStream.Dispose();
            }

            httpResp.Close();
            httpReq = null;

            return respHTML;
        }

        /// <summary>
        /// 获取UTF8网页HTML内容
        /// </summary>
        /// <param name="Url">URL地址</param>
        /// <returns></returns>
        public string GetUTF8(string Url) {
            return Get(Url, Encoding.UTF8);
        }

        /// <summary>
        /// 获取UTF8网页HTML内容
        /// </summary>
        /// <param name="Url">URL地址</param>
        /// <param name="Args">提交参数</param>
        /// <returns></returns>
        public string PostUTF8(string Url, string Args) {
            return Post(Url, Args, Encoding.UTF8);
        }

        /// <summary>
        /// 提交数据并获取返回内容
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="Args"></param>
        /// <param name="enc"></param>
        /// <returns></returns>
        public string PostFile(string Url, string Path) {
            string respHTML = "";
            //string szError = "";
            Exception Err = null;

            try {
                System.Net.HttpWebRequest httpReq;
                //System.Net.HttpWebResponse httpResp;
                System.Uri httpURL = new System.Uri(Url);

                httpReq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(httpURL);
                httpReq.Method = "POST";
                //httpReq.KeepAlive = true;
                httpReq.Credentials = CredentialCache.DefaultCredentials;
                httpReq.KeepAlive = false;
                httpReq.Timeout = 600000;
                httpReq.Headers.Add("Cookie", _cookies.ToString());

                string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
                byte[] boundarybytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");
                byte[] endbytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");

                httpReq.ContentType = "multipart/form-data; boundary=" + boundary;

                //byte[] bs = enc.GetBytes(Args);

                //httpReq.KeepAlive = false;
                //httpReq.ContentType = "application/x-www-form-urlencoded";
                //httpReq.ContentLength = bs.Length;
                //httpReq.

                //异步提交
                httpReq.BeginGetRequestStream(new AsyncCallback((IAsyncResult ar) => {

                    try {

                        HttpWebRequest hwr = ar.AsyncState as HttpWebRequest;

                        //post数据
                        using (System.IO.Stream reqStream = hwr.EndGetRequestStream(ar)) {
                            //reqStream.Write(bs, 0, bs.Length);
                            //reqStream.Flush();

                            string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: application/octet-stream\r\n\r\n";
                            byte[] buffer = new byte[4096];
                            int bytesRead = 0;
                            //for (int i = 0; i < files.Length; i++) {
                            reqStream.Write(boundarybytes, 0, boundarybytes.Length);
                            string header = string.Format(headerTemplate, "file0", System.IO.Path.GetFileName(Path));
                            byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
                            reqStream.Write(headerbytes, 0, headerbytes.Length);
                            using (System.IO.FileStream fileStream = new System.IO.FileStream(Path, FileMode.Open, FileAccess.Read)) {
                                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0) {
                                    reqStream.Write(buffer, 0, bytesRead);
                                }
                            }
                            //}

                            //1.3 form end
                            reqStream.Write(endbytes, 0, endbytes.Length);
                            //reqStream.Close();
                        }

                        //异步获取
                        hwr.BeginGetResponse(new AsyncCallback((IAsyncResult wrar) => {

                            try {

                                HttpWebRequest wrwr = wrar.AsyncState as HttpWebRequest;
                                System.Net.HttpWebResponse wr = (System.Net.HttpWebResponse)wrwr.EndGetResponse(wrar);
                                SetCookies("" + wr.Headers["Set-Cookie"]);

                                using (System.IO.Stream MyStream = wr.GetResponseStream()) {
                                    System.IO.StreamReader reader = new System.IO.StreamReader(MyStream, Encoding.UTF8);

                                    //byte[] TheBytes = new byte[MyStream.Length];
                                    //MyStream.Read(TheBytes, 0, (int)MyStream.Length);

                                    //respHTML = Encoding.UTF8.GetString(TheBytes);
                                    respHTML = reader.ReadToEnd();
                                    //Console.WriteLine(respHTML);

                                    reader.Dispose();
                                    MyStream.Dispose();
                                }

                            } catch (Exception ex) {
                                dpz2.Debug.WriteLine("BeginGetResponse:" + ex.Message);
                                //szError = ex.Message;
                                Err = ex;
                            }

                        }), hwr);

                    } catch (Exception ex) {
                        dpz2.Debug.WriteLine("BeginGetRequestStream:" + ex.Message);
                        Err = ex;
                    }



                }), httpReq);

                int tick = Environment.TickCount;
                bool bCheck = true;

                while (bCheck) {
                    if (Environment.TickCount - tick > 10) {
                        tick = Environment.TickCount;
                        if (respHTML != "") {
                            bCheck = false;
                            return respHTML;
                        }
                        if (Err != null) {
                            bCheck = false;
                            throw Err;
                        }
                    }
                    System.Threading.Thread.Sleep(1);
                }

                //httpResp = (System.Net.HttpWebResponse)httpReq.GetResponse();

                //httpResp.Close();
                //httpReq = null;


            } catch (Exception ex) {
                throw new Exception("获取HTML发生异常", ex);
                //System.Windows.Forms.MessageBox.Show("获取信息发生异常:\r\n" + ex.Message + "\r\n" + Url);
                //Debug.WriteLine("Debug\\>GetHTML::Error(" + ex + ")");
            }

            return respHTML;
        }

        /// <summary>
        /// 提交数据并获取返回内容
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="Args"></param>
        /// <param name="enc"></param>
        /// <returns></returns>
        public void DownFile(string Url, string Path) {
            //string respHTML = "";
            string szError = "";
            bool bAccess = false;

            try {
                System.Net.HttpWebRequest httpReq;
                //System.Net.HttpWebResponse httpResp;
                System.Uri httpURL = new System.Uri(Url);

                httpReq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(httpURL);
                httpReq.Method = "Get";
                httpReq.Headers.Add("Cookie", _cookies.ToString());

                //异步获取
                httpReq.BeginGetResponse(new AsyncCallback((IAsyncResult wrar) => {

                    try {

                        HttpWebRequest wrwr = wrar.AsyncState as HttpWebRequest;
                        System.Net.HttpWebResponse wr = (System.Net.HttpWebResponse)wrwr.EndGetResponse(wrar);
                        SetCookies("" + wr.Headers["Set-Cookie"]);

                        using (System.IO.Stream MyStream = wr.GetResponseStream()) {
                            //System.IO.StreamReader reader = new System.IO.StreamReader(MyStream, Encoding.UTF8);

                            //byte[] TheBytes = new byte[MyStream.Length];
                            //MyStream.Read(TheBytes, 0, (int)MyStream.Length);
                            //保存文件
                            using (FileStream fs = File.Create(Path)) {
                                byte[] bytes = new byte[102400];
                                int n = 0;
                                do {
                                    n = MyStream.Read(bytes, 0, 10240);
                                    fs.Write(bytes, 0, n);
                                } while (n > 0);
                            }

                            //下载成功
                            bAccess = true;

                            //respHTML = Encoding.UTF8.GetString(TheBytes);
                            //respHTML = reader.ReadToEnd();
                            //Console.WriteLine(respHTML);

                            //reader.Dispose();
                            MyStream.Dispose();
                        }

                    } catch (Exception ex) {
                        dpz2.Debug.WriteLine("BeginGetResponse:" + ex.Message);
                        szError = ex.Message;
                    }

                }), httpReq);

            } catch (Exception ex) {
                dpz2.Debug.WriteLine("BeginGetRequestStream:" + ex.Message);
            }


            int tick = Environment.TickCount;
            bool bCheck = true;

            while (bCheck) {
                if (Environment.TickCount - tick > 10) {
                    tick = Environment.TickCount;
                    if (szError != "") {
                        bCheck = false;
                        throw new Exception(szError);
                    }
                    if (bAccess) bCheck = false;
                }
                System.Threading.Thread.Sleep(1);
            }

            //httpResp = (System.Net.HttpWebResponse)httpReq.GetResponse();

            //httpResp.Close();
            //httpReq = null;

            //return respHTML;
        }

        /// <summary>
        /// 提交数据并获取返回内容
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="Args"></param>
        /// <param name="enc"></param>
        /// <returns></returns>
        public void DownFile(string Url, string Args, string Path) {
            //string respHTML = "";
            string szError = "";
            bool bAccess = false;

            try {
                System.Net.HttpWebRequest httpReq;
                //System.Net.HttpWebResponse httpResp;
                System.Uri httpURL = new System.Uri(Url);

                httpReq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(httpURL);
                httpReq.Method = "POST";

                byte[] bs = System.Text.Encoding.UTF8.GetBytes(Args);

                //httpReq.KeepAlive = false;
                httpReq.ContentType = "application/x-www-form-urlencoded";
                httpReq.Headers.Add("Cookie", _cookies.ToString());

                //异步提交
                httpReq.BeginGetRequestStream(new AsyncCallback((IAsyncResult ar) => {

                    try {

                        HttpWebRequest hwr = ar.AsyncState as HttpWebRequest;

                        //post数据
                        using (System.IO.Stream reqStream = hwr.EndGetRequestStream(ar)) {
                            reqStream.Write(bs, 0, bs.Length);
                            reqStream.Flush();
                            //reqStream.Close();
                        }

                        //异步获取
                        hwr.BeginGetResponse(new AsyncCallback((IAsyncResult wrar) => {

                            try {

                                HttpWebRequest wrwr = wrar.AsyncState as HttpWebRequest;
                                System.Net.HttpWebResponse wr = (System.Net.HttpWebResponse)wrwr.EndGetResponse(wrar);
                                SetCookies("" + wr.Headers["Set-Cookie"]);

                                using (System.IO.Stream MyStream = wr.GetResponseStream()) {
                                    //System.IO.StreamReader reader = new System.IO.StreamReader(MyStream, Encoding.UTF8);

                                    //byte[] TheBytes = new byte[MyStream.Length];
                                    //MyStream.Read(TheBytes, 0, (int)MyStream.Length);

                                    using (FileStream fs = File.Create(Path)) {
                                        byte[] bytes = new byte[102400];
                                        int n = 0;
                                        do {
                                            n = MyStream.Read(bytes, 0, 10240);
                                            fs.Write(bytes, 0, n);
                                        } while (n > 0);
                                    }

                                    //下载成功
                                    bAccess = true;

                                    //respHTML = Encoding.UTF8.GetString(TheBytes);
                                    //respHTML = reader.ReadToEnd();
                                    //Console.WriteLine(respHTML);

                                    //reader.Dispose();
                                    MyStream.Dispose();
                                }

                            } catch (Exception ex) {
                                dpz2.Debug.WriteLine("BeginGetResponse:" + ex.Message);
                                szError = ex.Message;
                            }

                        }), hwr);

                    } catch (Exception ex) {
                        dpz2.Debug.WriteLine("BeginGetRequestStream:" + ex.Message);
                    }



                }), httpReq);

                int tick = Environment.TickCount;
                bool bCheck = true;

                while (bCheck) {
                    if (Environment.TickCount - tick > 10) {
                        tick = Environment.TickCount;
                        //if (respHTML != "") {
                        //    bCheck = false;
                        //    return respHTML;
                        //}
                        if (szError != "") {
                            bCheck = false;
                            throw new Exception(szError);
                        }
                        if (bAccess) bCheck = false;
                    }
                    System.Threading.Thread.Sleep(1);
                }

                //httpResp = (System.Net.HttpWebResponse)httpReq.GetResponse();

                //httpResp.Close();
                //httpReq = null;


            } catch (Exception ex) {
                throw new Exception("获取HTML发生异常:" + ex.Message);
                //System.Windows.Forms.MessageBox.Show("获取信息发生异常:\r\n" + ex.Message + "\r\n" + Url);
                //Debug.WriteLine("Debug\\>GetHTML::Error(" + ex + ")");
            }

            //return respHTML;
        }

    }
}
